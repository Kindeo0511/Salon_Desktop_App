using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class AppointmentController
    {
        private readonly AppointmentRepository repo;

        public AppointmentController()
        {
            repo = new AppointmentRepository();
        }
        public AppointmentController(AppointmentRepository repository)
        {
            repo = repository;
        }


        public IEnumerable<AppointmentModel> LoadAppointments()
        {
            return repo.GetAll();
        }
        public IEnumerable<AppointmentModel> LoadAllAppointments()
        {
            return repo.GetAllAppointments();
        }
        public int CreateAppointment(int customer_id, DateTime date, TimeSpan startTime, TimeSpan endTime, string status, string paymentStatus, string booking_type)
        {
            var appointment = new Models.AppointmentModel
            {
                CustomerId = customer_id,
                AppointmentDate = date,
                StartTime = startTime,
                Status = status,
                PaymentStatus = paymentStatus,
                BookingType = booking_type

            };
            return repo.Add(appointment);
        }
        public void UpdateAppointment(AppointmentModel model)
        {


            repo.UpdateStylist(model);

        }
        public void UpdateAppointmentPayment(int appointmentId, string paymentStatus)
        {
            var appointment = new Models.AppointmentModel { AppointmentId = appointmentId, PaymentStatus = paymentStatus };

            repo.UpdatePaymentStatus(appointment);

        }
        public void UpdateStatus(string status, int id)
        {
            repo.UpdateStatus(status, id);
        }
    }
}
