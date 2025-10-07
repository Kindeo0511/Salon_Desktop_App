using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IUtility
    {
        IEnumerable<UtilityModel> AllUtilities();

        UtilityModel AllUtilty();
        UtilityModel TotalUtility();
        void AddUtility(UtilityModel model);
        void UpdateUtility(UtilityModel model);
        void RemoveUtility(int id);
    }
}
