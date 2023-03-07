using Microsoft.AspNetCore.Mvc;
using Services.Models;
using AppointmentBooker.Interfaces;

namespace AppointmentBooker.Controllers
{
    /// <summary>
    /// sccheduling Controller constructor partial and the main entrypoints to this class
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public partial class SchedulingController : ControllerBase
    {
        // injected services for the controller
        private readonly ICalendarService _calendarService;
        // constructors
        public SchedulingController(Services.CalendarService calendarService) 
        {
            _calendarService = calendarService;
        }
    }
}