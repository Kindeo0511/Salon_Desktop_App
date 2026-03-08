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

        public bool IsVisitIsVisitRequiredExists(int visit_req) 
        {
            return repo.IsVisitRequiredExists(visit_req);
        }
        public bool DeleteService(int id)
        {
            return repo.Delete(id);
        }

        public bool DeleteCardVisit(int id) 
        {
            return repo.DeleteCardVisit(id);
        }
        public bool DeleteCard(int id)
        {
            return repo.DeleteCard(id);
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

        // IS CUSTOMER HAVE CARD NUMBER
        public bool IsCustomerHaveCardNumber(int customer_id) 
        {
        
            return repo.IsCustomerHasCardNumber(customer_id);
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
        // STAMP VISIT
        public bool StampVisit(int card_id) 
        {
            return repo.StampVisit(card_id);
        }

        // GET TOTAL VISIT
        public int GetTotalVisit(int card_id) 
        {
            return repo.GetTotalVisits(card_id);
        }
        public bool IsAlreadyStampedToday(int card_id) 
        {
            return repo.IsAlreadyStampedToday(card_id);
        }

        // GET MILESTONE

        public LoyaltyCardModel GetMileStone(int total_visits) 
        {
            return repo.GetMilestone(total_visits);
        }

        // REDEEM FREE SERVICE

        public bool RedeemFreeService(int card_id, int service_id) 
        {
            return repo.RedeemFreeService(card_id, service_id);
        }

        // SHOW BUTTON IF FREE
        public bool ShowButtonIfFree(int customer_id) 
        {
            return repo.ShowButtonIfFree(customer_id);
        }

        public bool IsServiceMatchToTheCard(int service_id) 
        {
            return repo.IsServiceMatchTotheCard(service_id);
        }


        // REDEEM ALL FREE SEREVICE

        public List<LoyaltyCardModel> RedeemAllFreeServices(int customer_id) 
        {
            return repo.GetRedeemableService(customer_id);
        }

        // UNREDEEM FREE SERVICE
        public bool IsAllMilestonesRedeemed(int customer_id) 
        {
            return repo.IsAllMilestonesRedeemed(customer_id);
        }
    }
}
