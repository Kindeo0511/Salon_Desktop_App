using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class StylistController
    {
        private readonly StylistRepository _repo;

        public StylistController(StylistRepository _repo)
        {
            this._repo = _repo;
        }

        public IEnumerable<StylistModel> GetAll()
        {
            return _repo.GetAllStylist();
        }
        public IEnumerable<StylistModel> StylistFullName() 
        {
            return _repo.GetStylistWithFullName();
        }
        public StylistModel getStylistTotalCost() 
        {
            return _repo.GetStylistCost();
        }
        public void Add(StylistModel stylist)
        {
            _repo.AddStylist(stylist);
        }
        public void Update(StylistModel stylist)
        {
            _repo.UpdateStylist(stylist);
        }
        public void Delete(int stylist_id)
        {
            _repo.DeleteStylist(stylist_id);
        }
    }
}
