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


        public void AddServicesToAppointment(int appointmentId, int serviceId)
        {
            var appointmentService = new Models.AppointmentServicesModel
            {
                AppointmentId = appointmentId,
                ServiceId = serviceId
            };
            repo.AddAppointmentService(appointmentService);
        }
        public IEnumerable<AppointmentServicesModel> GetPopularServices() 
        {
            return repo.GetAll();
        }

        public IEnumerable<Models.AppointmentServicesModel> GetServicesByAppointmentId(int appointmentId)
        {
            return repo.GetServicesByAppointmentId(appointmentId);
        }
    }
}
