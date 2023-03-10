using Microsoft.AspNetCore.Mvc;
using Services.Models;

namespace AppointmentBooker.Controllers
{
    public partial class SchedulingController
    {
        [HttpGet("CreateEvent")]
        public async Task<IActionResult> CreateEvent()
        {
            var createNewEventResponse = await _calendarService.CreateCalendarEvent();

            return Ok(createNewEventResponse);
        }
    }
}
