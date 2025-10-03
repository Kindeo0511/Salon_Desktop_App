using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IStylist
    {
        IEnumerable<StylistModel> GetAllStylist();
        IEnumerable<StylistModel> GetStylistWithFullName();
        StylistModel GetStylistCost();
        void AddStylist(StylistModel stylist);
        void UpdateStylist(StylistModel stylist);
        void DeleteStylist(int stylist_id);
    }
}
