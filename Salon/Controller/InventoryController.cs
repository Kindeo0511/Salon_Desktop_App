using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Controller
{
    public class InventoryController
    {
        private readonly InventoryRepository inventoryRepository;
        public InventoryController(InventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public IEnumerable<InventoryViewModel> GetAllInventory()
        {
            return inventoryRepository.GetAllInventory();
        }

        public async Task<IEnumerable<InventoryViewModel>> GetAllInventoryAsync() 
        {
            return await inventoryRepository.GetAllInventoryAsync();
        }
        public IEnumerable<InventoryViewModel> GetAllInventory(string status)
        {
            return inventoryRepository.GetAllInventory(status);
        }

        public InventoryViewModel GetInventorySummaryReport() 
        {
            return inventoryRepository.InventoryReportSummary();
        }
        public InventoryViewModel GetInventorySummaryReport(string status)
        {
            return inventoryRepository.InventoryReportSummary(status);
        }

        public bool ProductExists(int id)
        {
            return inventoryRepository.ProductExists(id);
        }

        public void AddInventory(InventoryViewModel inventory)
        {
            inventoryRepository.AddInventory(inventory);
        }

        public void UpdateInventory(int id, int unit, int volume)
        {
            inventoryRepository.UpdateInventory(id, unit, volume);
        }

        public void UpdateExpiredProducts() 
        {
            inventoryRepository.UpdateExpiredInventory();
        }
        public void UpdateInventoryByVolume(int id, double unit, double volume)
        {
            inventoryRepository.UpdateInventoryVolume(id, unit, volume);
        }
        public int GetLowOrOutOfStock() 
        {
            return inventoryRepository.LowOrOutOfStock();
        }

        public void DeleteInventory(int inventoryId)
        {
            inventoryRepository.DeleteInventory(inventoryId);
        }



    }
}
