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

        public IEnumerable<AppointmentModel> GetAllShowAppointments(string filter) 
        {
            return repo.ShowAllAppointmnets(filter);
        }

        public async Task<IEnumerable<AppointmentModel>> GetAllAppointmentAsync(string status) 
        {
            return await repo.ShowAllAppointmentAsync(status);
        }
        public IEnumerable<AppointmentModel> LoadAppointments()
        {
            return repo.GetAll();
        }
        public IEnumerable<AppointmentModel> LoadAllAppointments()
        {
            return repo.GetAllAppointments();
        }
        public int CreateAppointment(AppointmentModel model)
        {
           
             return repo.Add(model);
        }
        public int CreateWalkInAppointment(AppointmentModel model)
        {

            return repo.AddWalkIn(model);
        }
        public int UpdatingTheAppointment(AppointmentModel model) 
        {
            return repo.Update(model);
        }
        public void UpdateAppointment(AppointmentModel model)
        {


            repo.UpdateStylist(model);

        }
        public void UpdateAppointmentPayment(int appointmentId, string paymentStatus, string status)
        {
            var appointment = new Models.AppointmentModel { AppointmentId = appointmentId, PaymentStatus = paymentStatus , Status = status };

            repo.UpdatePaymentStatus(appointment);

        }
        public void UpdateStatus(string status, int id)
        {
            repo.UpdateStatus(status, id);
        }


        // VALIDATION

        //public async Task<bool> CheckIsSlotTaken(DateTime date, TimeSpan startTime) 
        //{
        //    //return  await repo.IsSlotTakenAsync(date, startTime);

        //}


        public async Task<bool> CheckIsSlotTaken(DateTime date, TimeSpan startTime)
        {
            return await repo.IsSlotTakenAsync(date, startTime);
        }

        //public async Task<bool> CheckSlotRangeAvailable(DateTime date, TimeSpan startTime, TimeSpan duration)
        //{
        //    int slotsNeeded = (int)Math.Ceiling(duration.TotalHours);

        //    for (int i = 0; i < slotsNeeded; i++)
        //    {
        //        var slotTime = startTime.Add(TimeSpan.FromHours(i));
        //        if (await CheckIsSlotTaken(date, slotTime))
        //            return false;
        //    }

        //    return true;
        //}
        public async Task<bool> CustomerIsAlreadyBooked(DateTime date, TimeSpan startTime, TimeSpan duration, int customerId)
        {
            return await repo.CustomerIsAlreadyBooked(date, startTime, duration, customerId);
        }

        public async Task<bool> CheckCustomerSlotRangeAvailable(DateTime date, TimeSpan startTime, TimeSpan duration, int id)
        {
            int slotsNeeded = (int)Math.Ceiling(duration.TotalHours);

            for (int i = 0; i < slotsNeeded; i++)
            {
                var slotTime = startTime.Add(TimeSpan.FromHours(i));
                if (await CheckIsSlotTaken(date, slotTime))
                    return false;
            }

            return true;
        }

        //public async Task<bool> CustomerIsAlreadyBooked(DateTime date, TimeSpan start_time, TimeSpan end_time, int customer_id)
        //{
        //    return await repo.CustomerIsAlreadyBooked(date, start_time, end_time, customer_id);
        //}
    }
}
