using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class ExceptionSchedulesController
    {
        private readonly IExceptionSchedules _repo;
        public ExceptionSchedulesController(IExceptionSchedules repo)
        {
            this._repo = repo;
        }
        public IEnumerable<ExceptionScheduleModel> LoadExceptionSchedules(int stylist_id)
        {
            return _repo.GetExceptionSchedules(stylist_id);
        }
        public void Create_ExceptionSchedule(ExceptionScheduleModel exceptionSchedule)
        {
            _repo.AddExceptionSchedule(exceptionSchedule);
        }
        public void Update_ExceptionSchedule(ExceptionScheduleModel exceptionSchedule)
        {
            _repo.UpdateExceptionSchedule(exceptionSchedule);
        }
        public void Delete_ExceptionSchedule(int exceptionScheduleId)
        {
            _repo.DeleteExceptionSchedule(exceptionScheduleId);
        }

        public void RestoreExceptionSchedule(int id) 
        {
            _repo.RestoreExceptionSchedule(id);
        }

        // VALIDATION 

        public bool GetCheckExceptionSchedule(DateTime date) 
        {
           return _repo.CheckExceptionSchedule(date);
        }
        public bool GetIsExceptionScheduleConflict(int stylist_id, DateTime date, TimeSpan start, TimeSpan end, int id = 0)
        {
            return _repo.IsExceptionScheduleConflict(stylist_id, date, start, end, id);
        }
    }
}
