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

        void UpdateAppointmentService(AppointmentServicesModel model);
        IEnumerable<AppointmentServicesModel> GetAll();
        Task<IEnumerable<AppointmentServicesModel>> GetAllAsync();
        IEnumerable<AppointmentServicesModel> GetServicesByAppointmentId(int appointmentId);

        IEnumerable<AppointmentServicesModel> ServicesSelected(int id);
        IEnumerable<AppointmentServicesModel> AppointmentServicesSelected(int id);
    }
}
