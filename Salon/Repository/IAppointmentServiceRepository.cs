using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IAppointmentServiceRepository
    {
        void AddAppointmentService(AppointmentServicesModel appointmentServices);
        void ClearDeleteAllServicesForAppointment(int id);
        IEnumerable<AppointmentServicesModel> GetAll();
        IEnumerable<AppointmentServicesModel> GetServicesByAppointmentId(int appointmentId);

        IEnumerable<AppointmentServicesModel> ServicesSelected(int id);
        IEnumerable<AppointmentServicesModel> AppointmentServicesSelected(int id);
    }
}
