using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TutorEase.Core.Contract;
using TutorEase.Core.DTO.Request;

namespace TutorEase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpPost("book")]
        public async Task<IActionResult> BookSchedule([FromBody] BookScheduleRequest request)
        {
            var response = await _scheduleService.BookScheduleAsync(request);
            return Ok(response);
        }

        [HttpPost("accept/{id}")]
        public async Task<IActionResult> AcceptBooking(string id)
        {
            var response = await _scheduleService.AcceptBookingAsync(id);
            return Ok(response);
        }

        [HttpPost("reject/{id}")]
        public async Task<IActionResult> RejectBooking(string id)
        {
            var response = await _scheduleService.RejectBookingAsync(id);
            return Ok(response);
        }

        [HttpGet("mybookings")]
        public async Task<IActionResult> GetUserBookings()
        {
            var response = await _scheduleService.GetUserBookingsAsync();
            return Ok(response);
        }
    }

}
