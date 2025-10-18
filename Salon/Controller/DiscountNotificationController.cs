using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class DiscountNotificationController
    {
        private readonly DiscountNotificationRepository repo;
        public DiscountNotificationController(DiscountNotificationRepository repo) 
        {
            this.repo = repo;
        }

        public IEnumerable<DiscountNotificationModel> GetAll() 
        {
            return repo.All();
        }
        public void AddDiscountNotif(DiscountNotificationModel model) 
        {
            repo.addNotification(model);
        }
        public void UpdateDiscountNotification(DiscountNotificationModel model)
        {
            repo.addNotification(model);
        }


        public void UpdateDiscountNotif(int id) 
        {
            repo.UpdateNotificationStatus(id);
        }
    }
}
