using Laundry.Data;
using Salon.Repository;
using Salon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class TimeSlotController
    {
        private readonly BusinessHourRepository repo;
        private readonly AppointmentRepository appointmentRepository;
        private readonly TimeSlotGenerator generator;

        public TimeSlotController()
        {
            using (var con = Database.GetConnection()) 
            {
                repo = new BusinessHourRepository();
                appointmentRepository = new AppointmentRepository();
                generator = new TimeSlotGenerator();
            }
         
        }

        public List<string> GetAvailableTimeSlots(DateTime selectedDate, int serviceDurationMinutes)
        {
            var day = selectedDate.DayOfWeek.ToString();
            var hours = repo.GetHoursForDay(day);
            var appointments = appointmentRepository.GetAppointmentsByDate(selectedDate);

            var availableSlots = generator.GenerateAvailableSlots(
                hours.OpenTime,
                hours.CloseTime,
                appointments,
                serviceDurationMinutes
            );

            return availableSlots.Select(s => s.ToString(@"hh\:mm")).ToList();
        }

        public List<String> GetTimeSlots(DateTime selectedDate)
        {
            var day = selectedDate.DayOfWeek.ToString();
            var hours = repo.GetHoursForDay(day);
            var slots = generator.GenerateSlots(hours, selectedDate);
            return slots.Select(s => s.ToString()).ToList();

        }

    }
}
