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
        InventoryBatchModel GetProductPriceByName(int product_id);
        void AddInventoryBatch(InventoryBatchModel inventoryBatch);
        void UpdateInventoryBatch();
        void DeleteInventoryBatch(InventoryBatchModel inventoryBatch);
    }
}
