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
        public async Task<IEnumerable<StylistModel>> RefreshStlyistAsync() 
        {
            return await _repo.GetAllStylistAsync();
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

        public void restoreStylist(int stylist_id) 
        {
            _repo.ActivateStylist(stylist_id);
        }

        // SUMMARY REPORT

        public StylistModel GetTotalStaff() 
        {
            return _repo.TotalStaff();
        }
        public StylistModel GetActiveStaff() 
        {
            return _repo.TotalActive();
        }
        public StylistModel GetInactiveStaff() 
        {
            return _repo.TotalInactive();
        }
        public StylistModel GetTopPerformerStaff() 
        {
            return _repo.TopPerformer();
        }

        public StylistModel GetTopPerformerStaff(DateTime start, DateTime end)
        {
            return _repo.TopPerformer(start, end);
        }

        public IEnumerable<StylistModel> GetStaffList() 
        {
            return _repo.StaffList();
        }

        public IEnumerable<StylistModel> GetStaffList(DateTime start, DateTime end)
        {
            return _repo.StaffList(start, end);
        }

        public List<int> GetAssignedStylist(DateTime date, TimeSpan start, TimeSpan end) 
        {
            return _repo.AssignedStylist(date, start, end);
        }


        public bool GetEmailExists(string email, int id = 0) 
        {
            return _repo.EmailExists(email, id);
        }

        public bool GetContactExists(string email, int id = 0)
        {
            return _repo.ContactExists(email, id);
        }


    }
}
