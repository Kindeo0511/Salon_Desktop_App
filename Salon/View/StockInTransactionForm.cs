using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Salon.View
{
    public partial class StockInTransactionForm : MaterialForm
    {
        private int supplierId;
        private readonly MainForm mainForm;
        public event EventHandler RefreshData;
        public StockInTransactionForm(MainForm main)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = main;
            LoadReferenceNumber();

        }
        private void LoadReferenceNumber()
        {
            var repo = new DeliveryRepository();
            var controller = new DeliveryController(repo);

            var invoices = controller.GetDeliveryInvoice();

            cmb_invoice_number.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_invoice_number.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_invoice_number.ValueMember = "delivery_id";
            cmb_invoice_number.DisplayMember = "invoice";
            cmb_invoice_number.DataSource = invoices;

            var autoSource = new AutoCompleteStringCollection();
            foreach (var inv in invoices)
            {
                autoSource.Add(inv.invoice);
            }
            cmb_invoice_number.AutoCompleteCustomSource = autoSource;
        }

        public void LoadDeliveryItems(string invoice_id)
        {

            var _repo = new DeliveredItemRepository();
            var deliveryItemController = new DeliveryItemController(_repo);
            dgv_items.AutoGenerateColumns = false;
            dgv_items.DataSource = deliveryItemController.GetDeliveryItemByInvoice(invoice_id);
            col_DeliveryItemId.DataPropertyName = "delivery_item_id";
            col_DeliveryId.DataPropertyName = "delivery_id";
            col_invoice_number.DataPropertyName = "invoice";
            col_ProductId.DataPropertyName = "product_id";
            col_ProductName.DataPropertyName = "product_name";
            col_product_size_id.DataPropertyName = "product_size_id";
            col_Quantity.DataPropertyName = "qty_delivered";
            col_qty_accepted.DataPropertyName = "qty_received";
            col_qty_rejected.DataPropertyName = "qty_rejected";
            col_total_accepted.DataPropertyName = "total_accepted";
            col_total_rejected.DataPropertyName = "total_rejected";
            col_total_qty.DataPropertyName = "total_qty";
            col_content.DataPropertyName = "content";
            col_UnitPrice.DataPropertyName = "unit_price";
            col_TotalPrice.DataPropertyName = "total_price";
            col_ExpiryDate.DataPropertyName = "expiry_date";
            col_notes.DataPropertyName = "notes";
            col_item_status.DataPropertyName = "item_status";

        }

        private void cmb_invoice_number_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_invoice_number_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_invoice_number.SelectedItem is DeliveryItemModel selectedInvoice)

            {   var deliveryId = selectedInvoice.delivery_id;
                string invoiceNumber = selectedInvoice.invoice;
                var supplierName = selectedInvoice.supplier_name;
                int supplier_id = selectedInvoice.supplier_id;

                lbl_supplier.Tag = supplier_id;
                lbl_supplier.Text = supplierName;
                lbl_date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
                lbl_staff_name.Text = $"{UserSession.CurrentUser.first_Name}, {UserSession.CurrentUser.last_Name}";
         
                LoadDeliveryItems(invoiceNumber);
       
            }
        }

        private void StockInTransactionForm_Load(object sender, EventArgs e)
        {
  
            cmb_invoice_number.SelectedIndex = -1;
        }

        private void cmb_invoice_number_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmb_invoice_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (cmb_invoice_number.SelectedItem is DeliveryItemModel selectedInvoice)

            {
                var deliveryId = selectedInvoice.delivery_id;
                string invoiceNumber = selectedInvoice.invoice;
                var supplierName = selectedInvoice.supplier_name;
                var supplier_id = selectedInvoice.supplier_id;

                lbl_supplier.Tag = supplier_id;
                lbl_supplier.Text = supplierName;
                lbl_date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
                lbl_staff_name.Text = $"{UserSession.CurrentUser.first_Name}, {UserSession.CurrentUser.last_Name}";

                LoadDeliveryItems(invoiceNumber);

            }
        }
        private int AddStockTransaction()
        {
            var repo = new StockTransactionRepository();
            var controller = new StockTransactionController(repo);
  
            var stockIn = new StockTransactionModel
            {
                transaction_type = "IN",
                reference_no = cmb_invoice_number.Text,
                date = DateTime.Now,
                supplier_id = Convert.ToInt32(lbl_supplier.Tag),          
                user_id = UserSession.CurrentUser.user_id,
                notes = txt_notes.Text,
                status = "Closed"

            };

            return controller.AddStockTransaction(stockIn);
        }

        private void InsertIntoInventory(int product_id, int product_size_id, int qty_accepted, int total_qty) 
        {
            var repo = new InventoryRepository();
            var controller = new InventoryController(repo);

          
            bool exists = controller.ProductExists(product_id, product_size_id);

            if (exists)
            {

                controller.UpdateInventory(product_id, product_size_id, qty_accepted, total_qty);



               // Audit.AuditLog(
               // DateTime.Now,
               // "Restock",
               // UserSession.CurrentUser.first_Name,
               // "Manage Delivery",
               //$"Restocked existing product '{cb_product_names.Text}' (Qty: {quantity}, Volume: {total_volume}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
               // );

            }
            else
            {

                var inventoryModel = new InventoryViewModel
                {
                    product_id = product_id,
                    product_size_id = product_size_id,
                    qty = qty_accepted,
                    total_remaining = total_qty
                };
                controller.AddInventory(inventoryModel);



                //Audit.AuditLog(
                //DateTime.Now,
                //"Add",
                //UserSession.CurrentUser.first_Name,
                //"Manage Delivery",
                //$"Added delivery for product '{cb_product_names.Text}' (Qty: {quantity}, Volume: {total_volume}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                //);

            }
        }

        private void AddTransactionDetails(int transaction_id) 
        {
            var repo = new TransactionDetailsRepository();
            var controller = new TransactionDetailController(repo);

            foreach (DataGridViewRow row in dgv_items.Rows)
            {
                if (row.IsNewRow) continue;
                int product_id = Convert.ToInt32(row.Cells["col_ProductId"].Value);
                int product_size_id = Convert.ToInt32(row.Cells["col_product_size_id"].Value);
                int qty_delivered = Convert.ToInt32(row.Cells["col_Quantity"].Value);
                int qty_accepted = Convert.ToInt32(row.Cells["col_qty_accepted"].Value);
                int qty_rejected = Convert.ToInt32(row.Cells["col_qty_rejected"].Value);
                int content = Convert.ToInt32(row.Cells["col_content"].Value);
                decimal unitPrice = Convert.ToDecimal(row.Cells["col_UnitPrice"].Value);
                decimal totalPrce = Convert.ToDecimal(row.Cells["col_TotalPrice"].Value);

                int total_quantity = qty_accepted * content;

                var transactionDetails = new TransactionDetailsModel
                {
                    transaction_id = transaction_id,
                    product_id = product_id,
                    product_size_id = product_size_id,
                    qty_delivered = qty_delivered,
                    qty_accepted = qty_accepted,
                    qty_rejected = qty_rejected,
                    qty_remaining = qty_accepted,
                    total_remaining = total_quantity,
                    unit_price = unitPrice,
                    total = totalPrce,
                };


                controller.AddTransactionDetail(transactionDetails);


                InsertIntoInventory(product_id,product_size_id, qty_accepted, total_quantity);
            }



        }
        private void UpdateDeliveryStatus() 
        {
            var repo = new DeliveryRepository();
            var controller = new DeliveryController(repo);
            controller.UpdateDeliveryStatus();
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {

            int transaction_id = AddStockTransaction();

            AddTransactionDetails(transaction_id);

            UpdateDeliveryStatus();

            RefreshData?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Save Succesfully!");
           
        }

        private void dgv_items_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var status = dgv_items.Rows[e.RowIndex].Cells["col_item_status"].Value?.ToString(); if (status == "Completed")
            {
                e.Cancel = true;
            }
         }
    }
}
