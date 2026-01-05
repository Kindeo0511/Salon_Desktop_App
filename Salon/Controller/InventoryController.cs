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
        public IEnumerable<InventoryViewModel> GetAllInventory(int page_size, int off_set)
        {
            return inventoryRepository.GetAllInventory(page_size, off_set);
        }
        public int GetTotalInventory() 
        {
            return inventoryRepository.TotalInventory();
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

        public bool ProductExists(int id, int product_size_id)
        {
            return inventoryRepository.ProductExists(id, product_size_id);
        }

        public void AddInventory(InventoryViewModel inventory)
        {
            inventoryRepository.AddInventory(inventory);
        }

        public void UpdateInventory(int id, int product_size_id, int unit, int volume)
        {
            inventoryRepository.UpdateInventory(id, product_size_id, unit, volume);
        }
        public bool UpdateInventoryCriticalLevel(int qty) 
        {
            return inventoryRepository.UpdateCriticalLevel(qty) > 0;
        }
        public void VoidProductInventory(int product_id, int size_id, int qty) 
        {
            inventoryRepository.VoidProductInventory(product_id, size_id, qty);
        }
        public void DeductInventory(int product_id, int product_size_id, int qty, int total)
        {
            inventoryRepository.DeductInventory(product_id, product_size_id, qty, total);
        }

        public void UpdateExpiredProducts() 
        {
            inventoryRepository.UpdateExpiredInventory();
        }
        public void UpdateInventoryByVolume(int id, double unit, double volume)
        {
            inventoryRepository.UpdateInventoryVolume(id, unit, volume);
        }
        public void RefundInventoryVolume(int id, double unit, double volume)
        {
            inventoryRepository.RefundInventoryVolume(id, unit, volume);
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
