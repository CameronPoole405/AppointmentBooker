using Microsoft.AspNetCore.Mvc;
using Google.Apis.Calendar.v3;
using Services;
using Google.Apis.Services;

namespace AppointmentBooker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchedulingController : ControllerBase
    {

        [HttpGet (Name = "GetSchedule")]
        public Schedule GetSchedule()
        {
            Schedule schedule = new Schedule();
            //IClientService
            //CalendarListResource.GetRequest request = new();


            return schedule;
        }

    }
}