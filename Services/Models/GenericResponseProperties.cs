using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooker.Services.Models
{
    public class GenericResponseProperties
    {
        private bool _Success;
        public List<string> Errors { get; set; } = new List<string>();

        // Success is determined by weather there are no errors or not 
        public bool Success { 
            get { return !(this.Errors.Count > 0) && this._Success; } 
            set { this._Success = value; } 
        }

        // sets the success variable to false signifying a failure
        public void Fail()
        {
            this._Success = false;
        }
    }
}
