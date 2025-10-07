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

        // SUMMARY STYlIST REPORT

        StylistModel TotalStaff();

        StylistModel TotalActive();

        StylistModel TotalInactive();

        StylistModel TopPerformer();
        StylistModel TopPerformer(DateTime start, DateTime end);

        // END OF STYLIST RERORT


        // VALIDATION
        List<int> AssignedStylist(DateTime date, TimeSpan start, TimeSpan end);
 




        }
    }
