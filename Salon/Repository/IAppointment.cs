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
        IEnumerable<AppointmentModel> GetAllAppointments();
        AppointmentModel GetTotalAppointment();
        IEnumerable<AppointmentModel> GetAll();
        List<AppointmentModel> GetAppointmentsByDate(DateTime date);
        int Add(AppointmentModel appointment);
        void UpdateStylist(AppointmentModel appointment);
        void UpdatePaymentStatus(AppointmentModel appointment);
        void UpdateStatus(string status, int id);

    }
}
