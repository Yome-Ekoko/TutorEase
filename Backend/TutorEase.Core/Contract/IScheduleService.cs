using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorEase.Core.DTO.Request;
using TutorEase.Core.DTO.Response;
using TutorEase.Domain.Common;

namespace TutorEase.Core.Contract
{
    public interface IScheduleService
    {
        Task<Response<string>> BookScheduleAsync(BookScheduleRequest request);
        Task<Response<string>> AcceptBookingAsync(string bookingId);
        Task<Response<string>> RejectBookingAsync(string bookingId);
        Task<Response<List<BookingResponse>>> GetUserBookingsAsync();
    }
}
