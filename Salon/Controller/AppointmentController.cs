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
        public List<AppointmentModel> GetAppointmentsByDate(DateTime date, int stylist_id)
        {
            return repo.GetAppointmentsByDate(date, stylist_id);
        }


        public async Task<IEnumerable<AppointmentModel>> GetAllAppointmentAsync(string status, int page_size, int off_set) 
        {
            return await repo.ShowAllAppointmentAsync(status, page_size, off_set);
        }

        public IEnumerable<AppointmentModel> ShowQueue()
        {
            return  repo.ShowQueue();
        }
        public IEnumerable<AppointmentModel> ShowOnGoingQueue()
        {
            return repo.ShowOnGoingQueue();
        }
        public IEnumerable<AppointmentModel> LoadAppointments()
        {
            return repo.GetAll();
        }
        public IEnumerable<AppointmentModel> LoadAllAppointments()
        {
            return repo.GetAllAppointments();
        }
        public IEnumerable<AppointmentModel> GetTodayAppointment()
        {
            return repo.GetTodayAppointment();
        }
        public bool GetStylistAvailability(int stylistId)
        {
            return repo.GetStylistStatus(stylistId);
        }
        public bool IsStylistOfDuty(int stylistId)
        {
            return repo.IsStylistOffDuty(stylistId);
        }
        public IEnumerable<AppointmentModel> GetStylistTrack() 
        {
            return repo.StylistTrackingPanel();
        }
        public int CreateAppointment(AppointmentModel model)
        {
           
             return repo.Add(model);
        }
        public int CreateWalkInAppointment(AppointmentModel model)
        {

            return repo.AddWalkIn(model);
        }

        public void UpdateTheAppointment(DateTime new_date, int AppointmentId) 
        {
            repo.UpdateAppointment(new_date, AppointmentId);
        }
        public void UpdateAppointmentStatus(int id, string status) 
        {
            repo.UpdateAppointmentStatus(id, status);
        }
        public void UpdateWalkin(DateTime new_date, int AppointmentId)
        {
            repo.UpdateWalkin(new_date, AppointmentId);
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
        public IEnumerable<AppointmentModel> CheckAppointmentTimeSlot(int id, DateTime date) 
        {
            return repo.GetAppointment(id, date);
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
