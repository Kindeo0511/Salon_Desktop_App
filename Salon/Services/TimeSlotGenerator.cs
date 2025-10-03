using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Services
{
    public class TimeSlotGenerator
    {

        public List<TimeSpan> GenerateAvailableSlots(
              TimeSpan businessStart,
              TimeSpan businessEnd,
              List<AppointmentModel> existingAppointments,
              int serviceDurationMinutes)
        {
            var allSlots = new List<TimeSpan>();

            for (var time = businessStart; time.Add(TimeSpan.FromMinutes(serviceDurationMinutes)) <= businessEnd; time = time.Add(TimeSpan.FromMinutes(30)))
            {
                allSlots.Add(time);
            }

            var availableSlots = allSlots.Where(slot =>
                !existingAppointments.Any(appointment =>
                    slot < appointment.EndTime && slot.Add(TimeSpan.FromMinutes(serviceDurationMinutes)) > appointment.StartTime
                )).ToList();

            return availableSlots;
        }

        public List<TimeSlot> GenerateSlots(BusinessHour hours, DateTime date, int intervalMinutes = 30)
        {
            var slots = new List<TimeSlot>();
            var current = hours.OpenTime;

            while (current + TimeSpan.FromMinutes(intervalMinutes) <= hours.CloseTime)
            {
                var slotTime = date.Date + current;
                slots.Add(new TimeSlot(slotTime));
                current += TimeSpan.FromMinutes(intervalMinutes);
            }

            return slots;
        }

    }
}
