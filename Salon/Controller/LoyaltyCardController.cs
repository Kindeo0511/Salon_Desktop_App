using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class LoyaltyCardController
    {
        private readonly LoyaltyCardRepository repo;

        public LoyaltyCardController(LoyaltyCardRepository repo) 
        {
            this.repo = repo;
        }

        public IEnumerable<LoyaltyCardModel> GetLoyaltyCardModels() 
        {
            return repo.GetLoyaltyCards();
        }

        public bool AddService(LoyaltyCardModel model) 
        {
            return repo.Add(model);
        }
        public bool UpdateSerivce(LoyaltyCardModel model)
        {
            return repo.Update(model);
        }
        public bool DeleteService(int id)
        {
            return repo.Delete(id);
        }

        public bool IsServiceExists(int id, int exclude_id) 
        {
            return repo.IsServiceExists(id, exclude_id);
        }

        // tbl loyalty card

        public int GetLastCardNumber() 
        {
            return repo.GetLastCardNumber();
        }
        public bool CreateCustomerCard(int id , string number)
        {
            return repo.CreateCustomerCard(id, number);
        }
        public LoyaltyCardModel GetCardByCustomerId(int id) 
        {
            return repo.GetCardByCustomerId(id);
        }
        public List<LoyaltyCardModel> GetVisitProgress(int customer_id) 
        {
            return repo.GetVisitProgress(customer_id);
        }
    }
}
