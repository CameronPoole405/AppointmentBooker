using AppointmentBooker.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooker.Services
{
    public partial class CalendarService
    {
        public async Task<CreateCalendarResponse> CreateCalendarEvent()
        {
            var response = new CreateCalendarResponse
            {
                Success = true,
                StatusDescription = "you hit the create Calendar Event service method that we created"
            };

            return response;
        }
    }
}
