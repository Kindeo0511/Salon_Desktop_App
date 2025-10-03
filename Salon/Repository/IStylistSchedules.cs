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
    }
}
