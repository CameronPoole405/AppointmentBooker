using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooker.Services
{
    public static class ActivateServiceLayer
    {
        /// <summary>
        /// Extension method for injecting the service layer with default configurations
        /// </summary>
        /// <param name="services"></param>
        public static void Activate(this IServiceCollection services)
        {
            // creates a scoped injection for the CalendarService
            services.AddScoped<CalendarService>();
        }
    }
}
