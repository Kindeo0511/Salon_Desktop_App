using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface IWalkIn
    {
        IEnumerable<WalkInModel> GetWalkIn();
        int getWalkInCode();
        void AddWalkIn(WalkInModel walkIn);
        void UpdateWalkIn(WalkInModel walkIn);
        void DeleteWalkIn(int id);
    }
}
