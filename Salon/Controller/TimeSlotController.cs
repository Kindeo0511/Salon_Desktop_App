using Laundry.Data;
using Salon.Models;
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
        public TimeSlotController(BusinessHourRepository repo)
        {
            this.repo = repo;

        }

        public BusinessHour GetBusinessHours() 
        {
            return repo.GetOpenHour();
        }



    }
}
