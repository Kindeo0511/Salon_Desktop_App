using Salon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Repository
{
    public interface I_InventoryBatches
    {
        IEnumerable<InventoryBatchModel> GetAllInventoryBatch();

        Task<IEnumerable<InventoryBatchModel>> GetAllInventoryBatchAsync();
        int? GetAvailableBatchId(int productId, int requiredVolume);
        void RecordBatchUsage(int batchId, double volumeUsed);
        InventoryBatchModel GetProductPriceByName(int product_id);
        void AddInventoryBatch(InventoryBatchModel inventoryBatch);
        void UpdateInventoryBatch();
        void DeleteInventoryBatch(InventoryBatchModel inventoryBatch);
    }
}
