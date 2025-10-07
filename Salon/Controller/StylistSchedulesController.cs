using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class StylistSchedulesController
    {
        private readonly IStylistSchedules _repo;

        public StylistSchedulesController(IStylistSchedules repo)
        {
            this._repo = repo;
        }

        public IEnumerable<StylistScheduleModel> GetAllSchedules(int stylistId)
        {
            return _repo.GetStylistSchedules(stylistId);
        }
        public void AddSchedule(StylistScheduleModel stylistSchedules)
        {
            _repo.AddStylistSchedule(stylistSchedules);
        }
        public void UpdateSchedule(StylistScheduleModel stylistSchedules)
        {
            _repo.UpdateStylistSchedule(stylistSchedules);
        }
        public void DeleteSchedule(int scheduleId)
        {
            _repo.DeleteStylistSchedule(scheduleId);
        }

        // VALIDATION

        public List<StylistModel> CheckStylistSchedule(DateTime day)
        {
            string dayOfWeek = day.DayOfWeek.ToString();
            return _repo.StylistSchedules(dayOfWeek);
        }
    }
}
