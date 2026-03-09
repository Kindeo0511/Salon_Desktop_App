using Dapper;
using Laundry.Data;
using Mysqlx.Crud;
using Salon.Models;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Salon.Repository
{
    public class StockOutRepository
    {

        public IEnumerable<StockOutModel> GetAllTransactionDetails() 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"SELECT p.product_name, ps.size_label, td.qty_delivered, td.qty_accepted, td.qty_rejected, td.qty_remaining, td.total_remaining,  td.unit_price, td.total, d_i.expiry_date

                        FROM tbl_transaction_details td
                        LEFT JOIN tbl_products p ON p.product_id = td.product_id
                        LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                        LEFT JOIN tbl_stock_transaction t ON t.transaction_id = td.transaction_id
                        LEFT JOIN tbl_delivery d ON d.invoice = t.reference_no
                        LEFT JOIN tbl_delivery_items d_i ON d_i.delivery_id = d.delivery_id";

                return con.Query<StockOutModel>(sql);
            }
        }
        public StockOutModel GetTransactionId(int product_id) 
        {
            using (var con =  Database.GetConnection()) 
            {
                var sql = @"SELECT si.stock_in_id, si.product_size_id
                        FROM tbl_stock_in si
                        LEFT JOIN tbl_products p ON p.product_id = si.product_id
                        LEFT JOIN tbl_product_size ps ON ps.product_id = si.product_id
                        LEFT JOIN tbl_delivery d ON d.delivery_id = si.delivery_id
                        LEFT JOIN tbl_delivery_items d_i ON d_i.delivery_id = d.delivery_id
                        WHERE p.product_id = @ProductId ORDER BY d_i.expiry_date ASC
                        LIMIT 1;";

                return con.QueryFirstOrDefault<StockOutModel>(sql, new { ProductId = product_id });
            }
        }
        public void RefundProduct(int stock_in_id, int product_size, int qty)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_stock_in si
                            LEFT JOIN tbl_products p ON p.product_id = si.product_id
                            LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                            LEFT JOIN tbl_delivery d ON d.delivery_id = si.delivery_id
                            LEFT JOIN tbl_delivery_items d_i ON d_i.delivery_id = d.delivery_id
                            SET si.total_remaining = GREATEST(si.total_remaining + (ps.content * @Qty),0),
                                 si.qty_remaining = GREATEST(si.qty_remaining + @Qty, 0)
                            WHERE si.stock_in_id =@Id AND si.product_size_id = @Size ORDER BY d_i.expiry_date ASC
                            LIMIT 1;;
";

                con.Execute(sql, new { Id = stock_in_id, Size = product_size, Qty = @qty });
            }
        }
        public void UpdateTransaction(int stock_in_id, int deduct) 
        {
            using (var con = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_stock_in si
                            LEFT JOIN tbl_products p ON p.product_id = td.product_id
                            LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                            LEFT JOIN tbl_stock_transaction t ON t.transaction_id = td.transaction_id
                            LEFT JOIN tbl_delivery d ON d.invoice = t.reference_no
                            LEFT JOIN tbl_delivery_items d_i ON d_i.delivery_id = d.delivery_id
                            SET si.total_remaining = GREATEST(si.total_remaining - @qty_deduct,0),
                                si.qty_remaining = GREATEST((si.total_remaining - @qty_deduct) / ps.content,0)
                            WHERE si.stock_in_id = @Id  AND si.total_remaining > 0 ORDER BY d_i.expiry_date ASC
                            LIMIT 1;
                            ";
                con.Execute(sql, new { Id = stock_in_id, qty_deduct = deduct });
            }
        }

        public void UpdateProducTransaction(int stock_in_id, int product_size, int qty) 
        {
            using (var con  = Database.GetConnection()) 
            {
                var sql = @"UPDATE tbl_stock_in si
                            LEFT JOIN tbl_products p ON p.product_id = si.product_id
                            LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                            LEFT JOIN tbl_stock_transaction t ON t.transaction_id = td.transaction_id
                            LEFT JOIN tbl_delivery d ON d.invoice = t.reference_no
                            LEFT JOIN tbl_delivery_items d_i ON d_i.delivery_id = d.delivery_id
                            SET si.total_remaining = GREATEST(si.total_remaining - @qty_deduct,0),
                                si.qty_remaining = GREATEST((si.total_remaining - @qty_deduct) / ps.content,0)
                            WHERE si.stock_in_id = @Id  AND si.total_remaining > 0 ORDER BY d_i.expiry_date ASC
                            LIMIT 1;
";

                con.Execute(sql, new { Id = stock_in_id, Size = product_size, Qty=@qty });
            }
        }
        public void VoidProductTransaction(int transaction_id, int product_size, int qty)
        {
            using (var con = Database.GetConnection())
            {
                var sql = @"UPDATE tbl_transaction_details td
                    LEFT JOIN tbl_products p ON p.product_id = td.product_id
                    LEFT JOIN tbl_product_size ps ON ps.product_id = p.product_id
                    LEFT JOIN tbl_stock_transaction t ON t.transaction_id = td.transaction_id
                    LEFT JOIN tbl_delivery d ON d.invoice = t.reference_no
                    LEFT JOIN tbl_delivery_items d_i ON d_i.delivery_id = d.delivery_id
                    SET td.total_remaining = GREATEST(td.total_remaining + (ps.content * @Qty),0),
                        td.qty_remaining = GREATEST(td.qty_remaining + @Qty, 0)
                    WHERE td.transaction_id = @TransactionId  AND ps.product_size_id =@Size AND td.total_remaining > 0 ORDER BY d_i.expiry_date ASC
                    LIMIT 1;";

                con.Execute(sql, new { TransactionId = transaction_id, Size = product_size, Qty = @qty });
            }
        }

        public void DeductStock(int product_id, int qty_deduction, string out_type, string unit_type) 
        {
            using (var con = Database.GetConnection()) 
            {
                con.Execute("CALL deduck_product_consumables(@in_product_id, @in_deduction_ml, @in_out_type, @in_unit_type)",
                      new { in_product_id = product_id, in_deduction_ml = qty_deduction, in_out_type = out_type, in_unit_type = unit_type });
            }   
        }
        public void DeductProductStockConsumables(int productId, int requestedQty, int invoice_id)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                using (var tx = con.BeginTransaction())
                {
                    try
                    {
                        decimal remainingQty = Convert.ToDecimal(requestedQty);

                        void ConsumeRows(IEnumerable<(int inventory_id, decimal qty, int product_id, int product_size_id, decimal content, decimal selling_price, decimal total_remaining, string unit_type)> candidateRows)
                        {
                            foreach (var row in candidateRows)
                            {
                                if (remainingQty <= 0) break;

                                var availableQty = row.total_remaining;
                                if (availableQty <= 0) continue;

                                var takeQty = Math.Min(availableQty, remainingQty);
                                var bottle_volume = row.content;

                                switch (row.unit_type.ToLower())
                                {
                                    case "ml":
                                    case "g":
                                    case "pcs":

                                        con.Execute(
                                        @"UPDATE tbl_inventory
                                          SET qty = GREATEST(total_remaining - @takeQty, 0) / @bottle_volume,
                                              total_remaining = GREATEST(total_remaining - @takeQty, 0),
                                              status = CASE
                                                  WHEN GREATEST(total_remaining - @takeQty, 0) = 0 THEN 'Out of Stock'
                                                  WHEN GREATEST(total_remaining - @takeQty, 0) / @bottle_volume <= critical_level THEN 'Low Stock'
                                                  ELSE 'In Stock'
                                              END
                                          WHERE inventory_id = @id",
                                        new { takeQty, id = row.inventory_id, bottle_volume }, tx);

                                                                        con.Execute(@"
                                        INSERT INTO tbl_stock_out
                                            (invoice_id, inventory_id, product_id, product_size_id, qty, qty_volume,
                                             unit_price, line_total, previous_total_remaining, new_total_remaining,
                                             previous_qty, new_qty, movement_type, reason, created_by, created_at)
                                        VALUES
                                            (@invoice_id, @inventoryId, @productId, @productSizeId, @qtyUnits, @volumeQty,
                                             @unitPrice, @lineTotal, @prevTotalRemaining, @newTotalRemaining,
                                             @prevQty, @newQty, 'Service', @reason, @userId, NOW());",
                                            new
                                            {
                                                invoice_id,
                                                inventoryId = row.inventory_id,
                                                productId = row.product_id,
                                                productSizeId = row.product_size_id,
                                                qtyUnits = takeQty / row.content,       // how many packs consumed
                                                volumeQty = takeQty,                     // actual pieces consumed
                                                unitPrice = row.selling_price,
                                                lineTotal = row.selling_price * (takeQty / row.content),
                                                prevTotalRemaining = row.total_remaining,
                                                newTotalRemaining = row.total_remaining - takeQty,
                                                prevQty = row.qty,
                                                newQty = (row.total_remaining - takeQty) / row.content,
                                                reason = "Service Ingredient",
                                                userId = UserSession.CurrentUser.user_id,
                                            }, tx);
                                        break;

                                    default:
                                        throw new InvalidOperationException($"Unknown unit type: {row.unit_type}");
                                }

                                remainingQty -= takeQty;
                            }
                        }

                        // Fetch inventory rows with unit_type
                        var preferredRows = con.Query<(int inventory_id, decimal qty, int product_id, int product_size_id, decimal content, decimal selling_price, decimal total_remaining, string unit_type)>(
                            @"SELECT i.inventory_id, i.qty, ps.product_id, ps.product_size_id, 
                             ps.content, ps.selling_price, i.total_remaining, p.unit_type
                      FROM tbl_inventory i
                      JOIN tbl_product_size ps ON ps.product_size_id = i.product_size_id
                      JOIN tbl_products p ON p.product_id = ps.product_id
                      WHERE ps.product_id = @pid
                        AND i.total_remaining > 0
                      ORDER BY i.expiry_date ASC
                      FOR UPDATE",
                            new { pid = productId }, tx).ToList();

                        ConsumeRows(preferredRows);

                        if (remainingQty > 0)
                        {
                            tx.Rollback();
                            throw new InvalidOperationException($"Not enough stock. Remaining: {remainingQty}");
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        try { tx.Rollback(); } catch { }
                        throw;
                    }
                }
            }
        }

        public void DeductProductRetailStock(int product_id, int product_size_id, decimal qtyBottles, int invoice_id, decimal unit_price)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                using (var tx = con.BeginTransaction())
                {
                    try
                    {
                        var qty_sold = qtyBottles;
                        // 1) Get bottle volume (ml) for the exact product_size_id
                        var ps = con.QueryFirstOrDefault<(int product_size_id, decimal content)>(
                            @"SELECT product_size_id, content
                      FROM tbl_product_size
                      WHERE product_size_id = @psi AND product_id = @pid",
                            new { psi = product_size_id, pid = product_id }, tx);

                        if (ps.product_size_id == 0)
                            throw new InvalidOperationException("Product size not found.");

                        // 2) Convert bottles to ml (use exact decimal then round as needed)
                        var requestedMlDecimal = qtyBottles * ps.content;
                        // Use integer ml for DB operations; choose rounding policy (Ceiling ensures enough ml)
                        var requestedMl = (int)Math.Ceiling(requestedMlDecimal);
                        var remainingMl = requestedMl;

                        // 3) Select candidate inventory rows for this product_size (FEFO) and lock them
                        var rows = con.Query<(int inventory_id, decimal qty, decimal total_remaining)>(
                            @"
                    SELECT i.inventory_id,i.qty, i.total_remaining
                    FROM tbl_inventory i
                    WHERE i.product_size_id = @psi
                      AND i.total_remaining > 0
                    ORDER BY i.expiry_date ASC
                    FOR UPDATE",
                            new { psi = product_size_id }, tx).ToList();

                        // 4) Consume rows
                        foreach (var row in rows)
                        {
                            if (remainingMl <= 0) break;

                            var availableMl = (int)row.total_remaining;
                            if (availableMl <= 0) continue;

                            var takeMl = Math.Min(availableMl, remainingMl);

                            // Atomic update: subtract ml and recompute qty as decimal (total_remaining / content)
                            con.Execute(
                                @"
                        UPDATE tbl_inventory i
                        JOIN tbl_product_size ps ON ps.product_size_id = i.product_size_id
                        SET i.total_remaining = GREATEST(i.total_remaining - @takeMl, 0),
                            i.qty = GREATEST(i.qty - @qty_sold, 0),
                            i.status = CASE
                                WHEN (GREATEST(i.total_remaining - @takeMl, 0) / ps.content) = 0 THEN 'Out of Stock'
                                WHEN (GREATEST(i.total_remaining - @takeMl, 0) / ps.content) <= i.critical_level THEN 'Low Stock'
                                ELSE 'In Stock'
                            END
                        WHERE i.inventory_id = @id",
                                new { @qty_sold, takeMl, id = row.inventory_id }, tx);

                            // 5) Insert movement / sale item for audit (adjust columns to your schema)
                            // after updating tbl_inventory for this inventory row
                            var insertSql = @"
                            INSERT INTO tbl_stock_out
                              (invoice_id, inventory_id, product_id, product_size_id, qty, qty_volume,
                               unit_price, line_total, previous_total_remaining, new_total_remaining,
                               previous_qty, new_qty, movement_type, reason, created_by, created_at)
                            VALUES
                              (@invoice_id, @inventoryId, @productId, @productSizeId, @qtyBottles, @volumeMl,
                               @unitPrice, @lineTotal, @prevTotalRemaining, @newTotalRemaining,
                               @prevQty, @newQty, 'Sale', @reason, @userId, NOW());";

                            con.Execute(insertSql, new
                            {
                                invoice_id = invoice_id,
                                inventoryId = row.inventory_id,
                                productId = product_id,
                                productSizeId = product_size_id,
                                qtyBottles = qty_sold,
                                volumeMl = takeMl,
                                unitPrice = unit_price,
                                lineTotal = unit_price * (qty_sold),
                                prevTotalRemaining = row.total_remaining,
                                newTotalRemaining = row.total_remaining - takeMl,
                                prevQty = row.qty,
                                newQty = (row.total_remaining - takeMl) / ps.content,
                                reason = "POS sale",
                                userId = UserSession.CurrentUser.user_id,
                            }, tx);

                            remainingMl -= takeMl;
                        }

                        // 6) If still short, rollback and throw
                        if (remainingMl > 0)
                        {
                            tx.Rollback();
                            throw new InvalidOperationException($"Insufficient stock for product {product_id} size {product_size_id}. Missing {remainingMl} ml.");
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        try { tx.Rollback(); } catch { /* log rollback failure if needed */ }
                        throw;
                    }
                }
            }
        }

        public void RefundProductRetailStock(int product_id, int product_size_id, decimal qtyBottlesToRefund, int invoice_id,int refund_id, decimal unit_price, string reason)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                using (var tx = con.BeginTransaction())
                {
                    try
                    {
                        // 1) Get product size content (ml per bottle)
                        var ps = con.QueryFirstOrDefault<(int product_size_id, decimal content)>(
                            @"SELECT product_size_id, content
                      FROM tbl_product_size
                      WHERE product_size_id = @psi AND product_id = @pid",
                            new { psi = product_size_id, pid = product_id }, tx);

                        if (ps.product_size_id == 0)
                            throw new InvalidOperationException("Product size not found.");

                        // total ml to refund
                        var refundMlDecimal = qtyBottlesToRefund * ps.content;
                        var refundMlRemaining = (int)Math.Ceiling(refundMlDecimal);

                        // 2) Get stock_out rows for this invoice and product_size_id ordered by most recent consumption
                        //    We will reverse in the same order they were recorded (so we add back to the same inventory rows).
                        var outs = con.Query<(int stock_out_id, int inventory_id, int qty_volume, decimal qty, decimal previous_total_remaining, decimal new_total_remaining, decimal previous_qty, decimal new_qty)>(
                            @"SELECT so.stock_out_id, so.inventory_id, so.qty_volume, so.qty, so.previous_total_remaining, so.new_total_remaining, so.previous_qty, so.new_qty
                      FROM tbl_stock_out so
                      WHERE so.invoice_id = @invoiceId
                        AND so.product_id = @productId
                        AND so.product_size_id = @productSizeId
                      ORDER BY so.stock_out_id DESC", // reverse chronological; adjust if you have timestamp
                            new { invoiceId = invoice_id, productId = product_id, productSizeId = product_size_id }, tx).ToList();

                        if (!outs.Any())
                            throw new InvalidOperationException("No sale records found for this invoice/product to refund.");

                        // 3) Iterate stock_out rows and add back ml to the same inventory rows
                        foreach (var outRow in outs)
                        {
                            if (refundMlRemaining <= 0) break;

                            // Lock the inventory row
                            var inv = con.QueryFirstOrDefault<(int inventory_id, decimal qty, decimal total_remaining, decimal critical_level)>(
                                @"SELECT i.inventory_id, i.qty, i.total_remaining, i.critical_level
                          FROM tbl_inventory i
                          WHERE i.inventory_id = @id
                          FOR UPDATE",
                                new { id = outRow.inventory_id }, tx);

                            if (inv.inventory_id == 0)
                                throw new InvalidOperationException($"Inventory row {outRow.inventory_id} not found.");

                            // Determine how much ml was originally taken from this inventory row (use qty_volume from stock_out)
                            var takenMl = (int)outRow.qty_volume;
                            // We should not add back more than was taken for this stock_out row.
                            var addMl = Math.Min(takenMl, refundMlRemaining);

                            // Update inventory: add ml and recompute qty (qty = total_remaining / content)
                            var newTotalRemaining = inv.total_remaining + addMl;
                            var newQtyDecimal = newTotalRemaining / ps.content;

                            con.Execute(
                                @"UPDATE tbl_inventory i
                          JOIN tbl_product_size ps ON ps.product_size_id = i.product_size_id
                          SET i.total_remaining = @newTotalRemaining,
                              i.qty = @newQty,
                              i.status = CASE
                                  WHEN (@newTotalRemaining / ps.content) = 0 THEN 'Out of Stock'
                                  WHEN (@newTotalRemaining / ps.content) <= i.critical_level THEN 'Low Stock'
                                  ELSE 'In Stock'
                              END
                          WHERE i.inventory_id = @id",
                                new
                                {
                                    newTotalRemaining,
                                    newQty = newQtyDecimal,
                                    id = inv.inventory_id
                                }, tx);

                            // Insert stock_in / refund audit row
                            con.Execute(
                                @"INSERT INTO tbl_stock_in
                          (refund_id,
                           stock_out_id,
                            inventory_id,
                            product_id,
                            product_size_id,
                            qty,
                            qty_volume,
                            unit_price,
                            line_total,
                            previous_total_remaining,
                            new_total_remaining,
                            previous_qty,
                            new_qty, 
                            movement_type,
                            reason,
                            created_by,
                            created_at)
                          VALUES
                          (@refund_id, @stock_out_id, @inventoryId, @productId, @productSizeId, @qtyBottles, @volumeMl, @unitPrice, @lineTotal,
                           @prevTotalRemaining, @newTotalRemaining, @prevQty, @newQty, 'Refund', @reason, @userId, NOW());",
                                new
                                {
                                    refund_id = refund_id,
                                    stock_out_id = outRow.stock_out_id,
                                    inventoryId = inv.inventory_id,
                                    productId = product_id,
                                    productSizeId = product_size_id,
                                    qtyBottles = qtyBottlesToRefund, 
                                    volumeMl = addMl,
                                    unitPrice = unit_price,
                                    lineTotal = unit_price * (decimal)qtyBottlesToRefund,
                                    prevTotalRemaining = inv.total_remaining,
                                    newTotalRemaining = newTotalRemaining,
                                    prevQty = inv.qty,
                                    newQty = newQtyDecimal,
                                    reason = reason,
                                    userId = UserSession.CurrentUser.user_id
                                }, tx);

                            // Reduce remaining ml to refund
                            refundMlRemaining -= addMl;
                        }

                        // 4) If still remaining ml to refund, we can either:
                        //    - create a new inventory row (if your business accepts returns that create new stock),
                        //    - or fail the refund because we cannot map returned stock to inventory rows.
                        if (refundMlRemaining > 0)
                        {
                            // Option A: create a new inventory row (uncomment if desired)
                            // var newQtyDecimal = refundMlRemaining / ps.content;
                            // con.Execute("INSERT INTO tbl_inventory (product_id, product_size_id, qty, total_remaining, status, created_at) VALUES (@pid, @psi, @qty, @total, 'In Stock', NOW())",
                            //             new { pid = product_id, psi = product_size_id, qty = newQtyDecimal, total = refundMlRemaining }, tx);
                            //
                            // // Insert a stock_in record pointing to the new inventory row (you need to fetch its id)

                            // Option B: rollback and throw
                            tx.Rollback();
                            throw new InvalidOperationException($"Refund amount exceeds recorded sale quantities. Unmatched {refundMlRemaining} ml.");
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        try { tx.Rollback(); } catch { /* log */ }
                        throw;
                    }
                }
            }
        }
        public void DeductProductStock(int product_id, int product_size_id , int qty_deduction, string out_type, string unit_type)
        {
            using (var con = Database.GetConnection())
            {
                con.Execute("CALL deduct_stock(@in_product_id, @in_product_size_id, @in_qty, @in_out_type, @in_unit_type)",
                      new { in_product_id = product_id, in_product_size_id = product_size_id, in_qty = qty_deduction, in_out_type = out_type, in_unit_type = unit_type });
            }
        }

        public void DeductExpiredStock()
        {
            using (var con = Database.GetConnection())
            {
                con.Open();
                using (var tx = con.BeginTransaction())
                {
                    try
                    {
                        // 1) Get expired batches that have NOT been deducted yet
                        var expiredRows = con.Query<(int delivery_item_id, int inventory_id, int product_size_id, decimal qty_delivered, decimal total_qty)>(
                            @"SELECT 
                        delivery_item_id, 
                        inventory_id, 
                        product_size_id, 
                        qty_delivered,
                        total_qty
                      FROM tbl_delivery_items 
                      WHERE DATE(expiry_date) < CURDATE()
                      AND is_deducted = 0", 
        
                            transaction: tx).ToList();
               

                        if (!expiredRows.Any()) return;

                        foreach (var row in expiredRows)
                        {
                            // 2) Get current inventory state
                            var inventory = con.QueryFirstOrDefault<(int inventory_id, decimal qty, decimal total_remaining, decimal content, decimal critical_level)>(
                                @"SELECT i.inventory_id, i.qty, i.total_remaining, 
                                 ps.content, i.critical_level  
                          FROM tbl_inventory i
                          JOIN tbl_product_size ps ON ps.product_size_id = i.product_size_id
                          WHERE i.inventory_id = @id 
                          AND i.total_remaining > 0
                          FOR UPDATE",
                                new { id = row.inventory_id }, tx);

                            if (inventory.inventory_id == 0)
                            {
                                // ✅ Even if inventory is 0, mark as deducted to skip next time
                                con.Execute(
                                    @"UPDATE tbl_delivery_items 
                              SET is_deducted = 1 
                              WHERE delivery_item_id = @id",
                                    new { id = row.delivery_item_id }, tx);
                                continue;
                            }

                            // 3) Calculate deduction
                            var mlToDeduct = Math.Min((int)(row.qty_delivered * inventory.content), (int)inventory.total_remaining);
                            var newRemaining = Math.Max(inventory.total_remaining - mlToDeduct, 0);
                            var newQty = newRemaining / inventory.content;

                            // 4) Update inventory
                            con.Execute(
                                @"UPDATE tbl_inventory
                          SET total_remaining = @newRemaining,
                              qty             = @newQty,
                              status          = CASE
                                                    WHEN @newRemaining = 0 THEN 'Out of Stock'
                                                    WHEN @newQty <= critical_level THEN 'Low Stock'
                                                    ELSE 'In Stock'
                                                END
                          WHERE inventory_id = @id",
                                new { newRemaining, newQty, id = row.inventory_id }, tx);

                            // 5) Get product_id
                            var productId = con.ExecuteScalar<int>(
                                @"SELECT product_id 
                          FROM tbl_product_size 
                          WHERE product_size_id = @psi",
                                new { psi = row.product_size_id }, tx);

                            // 6) Insert audit record
                            con.Execute(
                                @"INSERT INTO tbl_stock_out
                            (inventory_id, product_id, product_size_id, qty, qty_volume,
                             unit_price, line_total, previous_total_remaining, new_total_remaining,
                             previous_qty, new_qty, movement_type, reason,
                             created_by, out_type, created_at)
                          VALUES
                            (@inventoryId, @productId, @productSizeId, @qty, @qtyVolume,
                             0, 0, @prevTotalRemaining, @newTotalRemaining,
                             @prevQty, @newQty, 'Expired', 'Auto-deducted Expired Product',
                             @userId, 'Expired', NOW())",
                                new
                                {
                                    inventoryId = row.inventory_id,
                                    productId = productId,
                                    productSizeId = row.product_size_id,
                                    qty = inventory.qty - newQty,
                                    qtyVolume = mlToDeduct,
                                    prevTotalRemaining = inventory.total_remaining,
                                    newTotalRemaining = newRemaining,
                                    prevQty = inventory.qty,
                                    newQty = newQty,
                                    userId = UserSession.CurrentUser.user_id,
                                }, tx);

                            // 7) ✅ Mark batch as deducted so it never runs again
                            con.Execute(
                                @"UPDATE tbl_delivery_items 
                          SET is_deducted = 1 
                          WHERE delivery_item_id = @id",
                                new { id = row.delivery_item_id }, tx);
                        }

                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        throw new Exception($"DeductExpiredStock failed: {ex.Message}", ex);
                    }
                }
            }
        }
    }
}
