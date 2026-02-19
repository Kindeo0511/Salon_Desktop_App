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
        private readonly AppointmentServiceRepository repo;
        public AppointmentServiceController(AppointmentServiceRepository repo)
        {
            this.repo = repo;
        }


        public void AddServicesToAppointment(int appointmentId, int serviceId,int? stylistId, DateTime? startTime, DateTime? endTime, string status)
        {
            var appointmentService = new Models.AppointmentServicesModel
            {
                AppointmentId = appointmentId,
                ServiceId = serviceId,
                StylistId = stylistId,
                StartTime = startTime,
                EndTime = endTime,
                Status = status
            };
            repo.AddAppointmentService(appointmentService);
        }
        public void DeleteAppointmentService(int appointmentServiceId) 
        {
            repo.DeleteAppointmentServiceByAppointmentId(appointmentServiceId);
        }
        public void DeleteAppointmentServiceById(int appointmentServiceId)
        {
            repo.DeleteAppointmentServiceByAppointmentServiceId(appointmentServiceId);
        }
        public void UpdateServicesAppointment(AppointmentServicesModel model) 
        {
            repo.UpdateAppointmentService(model);
        }
        public bool CheckIfServiceExists(int appointmentId, int serviceId) 
        {
            return repo.CheckIfServiceExists(appointmentId, serviceId);
        }
        public bool MarkServiceAsCompleted(int appointmentServiceId) 
        {
            return repo.MarkAsCompleted(appointmentServiceId);
        }
        public bool IsStylistAvailable(int stylistId, DateTime requestedStart, int durationMinutes)
        {
            return repo.IsStylistAvailable(stylistId, requestedStart, durationMinutes);
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
        public IEnumerable<AppointmentServicesModel> ViewSelectedServices(int id) 
        {
            return repo.GetViewSelectedServices(id);
        }
        public bool ChangeStylist(int appointmentServiceId, int newStylistId) 
        {
            return repo.ChangeStylist(appointmentServiceId, newStylistId);
        }
        public bool StartWalkInService(int id, DateTime start_time, DateTime end_time) 
        {
            return repo.StartWalkInService(id, start_time, end_time);
        }
    }
}
