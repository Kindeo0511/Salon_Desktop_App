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
        public void AddSchedule(List<StylistScheduleModel> stylistSchedules)
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

        public void PermanetDeleteWeeklySchedule(int scheduleId) 
        {
            _repo.PermanentDelete(scheduleId);
        }

        public void RestoreSchedule(int scheduleId)
        {
            _repo.RestoreStylistSchedule(scheduleId);
        }
        // VALIDATION

        public List<StylistModel> CheckStylistSchedule(DateTime day)
        {
            string dayOfWeek = day.DayOfWeek.ToString();
            return _repo.StylistSchedules(dayOfWeek);
        }

        public bool GetIsScheduleConflict(int stylist_id, string day, TimeSpan start, TimeSpan end, int id = 0) 
        {
            return _repo.IsScheduleConflict(stylist_id, day, start, end, id);
        }
    }
}
