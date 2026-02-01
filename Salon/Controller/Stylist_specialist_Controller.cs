using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class Stylist_specialist_Controller
    {
        private readonly Stylist_Specialist_Repository repo;

        public Stylist_specialist_Controller(Stylist_Specialist_Repository repo) 
        {
            this.repo = repo;   
        }

        public IEnumerable<Stylist_Specialist_Model> GetStylistById(int id) 
        {
            return repo.StylistId(id);
        }
        public void CreateStylistSpecialist(int specialist_id, int stylist_id) 
        {
            var model = new Stylist_Specialist_Model 
            {
                specialist_id = specialist_id,
                stylist_id = stylist_id
            };

            repo.Create(model);
        }
        public void UpdateStylistSpecialist(int specialist_id, int stylist_id) 
        {
            var model = new Stylist_Specialist_Model
            {
                specialist_id = specialist_id,
                stylist_id = stylist_id
            };

            repo.Update(model);
        }
    }
}
