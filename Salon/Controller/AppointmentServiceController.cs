using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class AppointmentServiceController
    {
        private readonly IAppointmentServiceRepository repo;
        public AppointmentServiceController(IAppointmentServiceRepository repo)
        {
            this.repo = repo;
        }


        public void AddServicesToAppointment(int appointmentId, int serviceId,int? stylistId, DateTime startTime, DateTime endTime)
        {
            var appointmentService = new Models.AppointmentServicesModel
            {
                AppointmentId = appointmentId,
                ServiceId = serviceId,
                StylistId = stylistId,
                StartTime = startTime,
                EndTime = endTime,
            };
            repo.AddAppointmentService(appointmentService);
        }

        public void UpdateServicesAppointment(AppointmentServicesModel model) 
        {
            repo.UpdateAppointmentService(model);
        } 
        public void ClearDeleteAllServicesForAppointment(int id) 
        {
             repo.ClearDeleteAllServicesForAppointment(id);
        }

        public IEnumerable<AppointmentServicesModel> GetAllAppointmentServices(int id) 
        {
           return repo.AppointmentServicesSelected(id);
        }
        public IEnumerable<AppointmentServicesModel> GetPopularServices() 
        {
            return repo.GetAll();
        }
        public async Task<IEnumerable<AppointmentServicesModel>> GetPopulatServicesAsync() 
        {
            return await repo.GetAllAsync();
        }
        public IEnumerable<Models.AppointmentServicesModel> GetServicesByAppointmentId(int appointmentId)
        {
            return repo.GetServicesByAppointmentId(appointmentId);
        }

        public IEnumerable<AppointmentServicesModel> GetSelectedServices(int id) 
        {
            return repo.ServicesSelected(id);
        }
    }
}
