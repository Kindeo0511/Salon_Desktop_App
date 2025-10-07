using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class AppointmentReportController
    {
        private readonly AppointmentReportRepository repo;
        public AppointmentReportController(AppointmentReportRepository repo) 
        {
            this.repo = repo;

        }


        public AppointmentModel GetTopSpender() 
        {
            return repo.TopSpender();
        }
        public AppointmentModel GetTopSpender(DateTime start, DateTime end)
        {
            return repo.TopSpender(start, end);
        }

        public AppointmentModel GetRepeatedCustomer()
        {
            return repo.RepeatClient();
        }
        public AppointmentModel GetRepeatedCustomer(DateTime start, DateTime end)
        {
            return repo.RepeatClient(start, end);
        }

        public IEnumerable<AppointmentModel> GetFrequentCustomer() 
        {
            return repo.CustomerVisit();
        }

        public IEnumerable<AppointmentModel> GetFrequentCustomer(DateTime start, DateTime end)
        {
            return repo.CustomerVisit(start, end);
        }



    }
}
