using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IAppointment
    {
        // SUMMARY REPORT

        AppointmentModel TopSpender();
        AppointmentModel TopSpender(DateTime start, DateTime end);

        AppointmentModel RepeatClient();
        AppointmentModel RepeatClient(DateTime start, DateTime end);

        IEnumerable<AppointmentModel> CustomerVisit();
        IEnumerable<AppointmentModel> CustomerVisit(DateTime start, DateTime end);
    }
}
