using Microsoft.AspNetCore.Mvc;
using Services.Models;

namespace AppointmentBooker.Controllers
{
    public partial class SchedulingController
    {
        [HttpGet("GetSchedule")]
        public IActionResult GetSchedule()
        {
            Schedule schedule = new Schedule();
            //IClientService
            //CalendarListResource.GetRequest request = new();


            return Ok(schedule);
        }
    }
}
