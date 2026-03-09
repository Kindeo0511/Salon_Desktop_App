using Laundry.Data;
using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

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
        public int GetSSId(int stylist_id, int service_id) 
        {
            return _repo.GetSSId(stylist_id, service_id);
        }
        public IEnumerable<StylistModel> GetStylistSpecialist()
        {
            return _repo.GetStylistSpecialist();
        }
        public IEnumerable<StylistModel> GetStylistById(int id)
        {
            return _repo.StylistId(id);
        }
        public IEnumerable<StylistModel> GetStylistsByServiceId(int serviceId)
        {
            return _repo.GetStylistsByServiceId(serviceId);
        }
        public async Task<IEnumerable<StylistModel>> RefreshStlyistAsync(int PageSize, int Offset) 
        {
            return await _repo.GetAllStylistAsync(PageSize, Offset);
        }
        public IEnumerable<StylistModel> StylistFullName() 
        {
            return _repo.GetStylistWithFullName();
        }
        public IEnumerable<StylistModel> LoadStylistBasedOnServiceId(int id)
        {
            return _repo.LoadStylistBasedOnService(id);
        }
        public IEnumerable<StylistModel> GetStylistSpecialistById(int id)
        {
            return _repo.GetStylistSpecialist(id);
        }
        public StylistModel getStylistTotalCost() 
        {
            return _repo.GetStylistCost();
        }
        public int Add(StylistModel stylist)
        {
            return _repo.AddStylist(stylist);
        }
        public bool AssignService(int stylist_id, int service_id) 
        {
            return _repo.AssignService(stylist_id, service_id);
        }
        public bool UpdateAssignService(int ss_id)
        {
            return _repo.UpdateAssignService(ss_id);
        }
        public bool UnassignService(int stylist_id, int service_id) 
        {
            return _repo.UnassignService(stylist_id, service_id);
        }
        public bool Update(StylistModel stylist)
        {
            return _repo.UpdateStylist(stylist) > 0;
        }
        public bool UpdateDuty(int id, bool duty_value)
        {
            return _repo.UpdateStylistDuty(id, duty_value);
        }
        public bool Delete(int stylist_id)
        {
           return _repo.DeleteStylist(stylist_id) > 0;
        }

        public bool restoreStylist(int stylist_id) 
        {
            return _repo.ActivateStylist(stylist_id) > 0;
        }

        public bool PermanentDeleteStylist(int id) 
        {
            return _repo.PermanentDelete(id) > 0;
        }
        public bool CheckIsStylistIsUsed(int stylist_id) 
        {
            return _repo.IsStylistUsed(stylist_id);
        }
        public int GetEmail(string email) 
        {
            return _repo.GetEmail(email);
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

        public List<int> GetAssignedServiceIds(int stylist_id) 
        {
            return _repo.GetAssignedServiceIds(stylist_id);
        }



    }
}
