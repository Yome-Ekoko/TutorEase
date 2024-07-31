using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorEase.Core.Contract;
using TutorEase.Core.Contract.Repository;
using TutorEase.Core.DTO.Request;
using TutorEase.Core.DTO.Response;
using TutorEase.Core.Exceptions;
using TutorEase.Core.Repository;
using TutorEase.Domain.Common;
using TutorEase.Domain.Entities;
using TutorEase.Domain.Enum;
using TutorEase.Persistence;

namespace TutorEase.Core.Implementation
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ITutorRepository _tutorRepository;

        public ScheduleService(IScheduleRepository scheduleRepository, IHttpContextAccessor httpContextAccessor,ITutorRepository tutorRepository)
        {
            _scheduleRepository = scheduleRepository;
            _httpContextAccessor = httpContextAccessor;
            _tutorRepository = tutorRepository;
        }

        public async Task<Response<string>> BookScheduleAsync(BookScheduleRequest request)
        {
            //var userId = _httpContextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value;

            //if (string.IsNullOrEmpty(userId))
            //{
            //    throw new ApiException("User not found.");
            //}
          
                var tutor = await _tutorRepository.GetById(request.TutorId);
                if (tutor == null)
                {
                    throw new Exception("Tutor not found.");
                }
          
            var existingBooking = await _scheduleRepository.GetAllTutorScheduleAsync(request.TutorId,request.Day,request.Time1,request.Time);

            if (existingBooking.Count==0)
            {
                throw new Exception("No tutors found for the given criteria.");
            }

            var newSchedule = new Schedule
            {
                TutorId = request.TutorId,
               // StudentId = userId,
                Day = request.Day,
                Time = request.Time,
                Time1 = request.Time1,
                Status = BookingStatus.Pending
            };

          
            await _scheduleRepository.Add(newSchedule);

            return new Response<string>(newSchedule.Id, "Booking successful.");
        }

        public async Task<Response<string>> AcceptBookingAsync(string bookingId)
        {
            var userId = _httpContextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                throw new ApiException("User not found.");
            }

            var booking = await _scheduleRepository.GetById(bookingId);

            if (booking == null || booking.TutorId != userId)
            {
                throw new ApiException("Booking not found or unauthorized.");
            }

            booking.Status = BookingStatus.Accepted;
            await _scheduleRepository.Update(booking);

            return new Response<string>(booking.Id, "Booking accepted.");
        }

        public async Task<Response<string>> RejectBookingAsync(string bookingId)
        {
            var userId = _httpContextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                throw new ApiException("User not found.");
            }

            var booking = await _scheduleRepository.GetById(bookingId);

            if (booking == null || booking.TutorId != userId)
            {
                throw new ApiException("Booking not found or unauthorized.");
            }

            booking.Status = BookingStatus.Rejected;
            await _scheduleRepository.Update(booking);

            return new Response<string>(booking.Id, "Booking rejected.");
        }

        public async Task<Response<List<BookingResponse>>> GetUserBookingsAsync()
        {
            var userId = _httpContextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                throw new ApiException("User not found.");
            }

            var bookings = await _scheduleRepository.GetByUserId(userId);

            var response = bookings.Select(booking => new BookingResponse
            {
                BookingId = booking.Id,
                TutorId = booking.TutorId,
                StudentId = booking.StudentId,
                Day = booking.Day,
                Time = booking.Time,
                Time1 = booking.Time1,
                Status = booking.Status
            }).ToList();

            return new Response<List<BookingResponse>>(response);
        }
    }
}
