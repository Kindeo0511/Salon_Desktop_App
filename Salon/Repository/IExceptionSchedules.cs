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


        // VALIDATION
        bool CheckExceptionSchedule(DateTime date);
    }
}
