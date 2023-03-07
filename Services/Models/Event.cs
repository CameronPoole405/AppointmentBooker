using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Event
    {
        public DateTime AppointmentDate { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public List<string> Attendees { get; set; }
        public string Subject { get; set; }
    }
}
