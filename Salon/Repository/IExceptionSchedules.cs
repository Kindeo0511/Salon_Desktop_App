using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IExceptionSchedules
    {

        IEnumerable<ExceptionScheduleModel> GetExceptionSchedules(int stylist_id);
        void AddExceptionSchedule(ExceptionScheduleModel exceptionSchedule);
        void UpdateExceptionSchedule(ExceptionScheduleModel exceptionSchedule);
        void DeleteExceptionSchedule(int exceptionScheduleId);
        void RestoreExceptionSchedule(int exceptionScheduleId);


        // VALIDATION
        bool CheckExceptionSchedule(DateTime date);

        bool IsExceptionScheduleConflict(int stylist_id, DateTime date, TimeSpan start, TimeSpan end, int id = 0);
    }
}
