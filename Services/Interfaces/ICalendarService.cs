using AppointmentBooker.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooker.Interfaces
{
    public interface ICalendarService
    {
        public Task<CreateCalendarResponse> CreateCalendarEvent();
    }
}
