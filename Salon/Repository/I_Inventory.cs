using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface I_Inventory
    {
        IEnumerable<InventoryViewModel> GetAllInventory();
        IEnumerable<InventoryViewModel> GetAllInventory(string status);

        InventoryViewModel InventoryReportSummary();
        InventoryViewModel InventoryReportSummary(string status);

        int LowOrOutOfStock();
        void UpdateExpiredInventory();

        bool ProductExists(int id);
        void AddInventory(InventoryViewModel inventory);
        void UpdateInventory(int id, int unit, int volume);
        void UpdateInventoryVolume(int id, double unit, double volume);
        void DeleteInventory(int inventoryId);
    }
}
