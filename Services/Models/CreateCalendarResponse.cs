using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooker.Services.Models
{
    public class CreateCalendarResponse : GenericResponseProperties
    {
        public string StatusDescription { get; set; }
    }
}
