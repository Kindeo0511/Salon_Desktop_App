using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IStylistSchedules
    {
        IEnumerable<StylistScheduleModel> GetStylistSchedules(int stylistId);
        void AddStylistSchedule(StylistScheduleModel stylistSchedules);
        void UpdateStylistSchedule(StylistScheduleModel stylistSchedules);
        void DeleteStylistSchedule(int scheduleId);
        void RestoreStylistSchedule(int scheduleId);
        void PermanentDelete(int scheduleId);

        // VALIDATION

        List<StylistModel> StylistSchedules(string day);

        bool IsScheduleConflict(int stylist_id, string day, TimeSpan start, TimeSpan end, int id = 0);
    }
}
