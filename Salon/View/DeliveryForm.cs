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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Salon.View
{
    public partial class DeliveryForm : MaterialForm
    {
        private MainForm mainform;
        private int totalVolume = 0;
        private int content = 0;
        private int total_qty = 0;
        public event EventHandler RefreshData;
        public DeliveryForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_Items);
            LoadSupplier();
            LoadProducts();
            this.mainform = mainform;
            // Delivered date: allow up to 2 years back, but not future
            dtp_delivery_date.MinDate = DateTime.Today.AddYears(-2);
            dtp_delivery_date.MaxDate = DateTime.Today;

            // Expiry date: must be on or after delivery, up to 10 years ahead
            dtp_expiry.MinDate = dtp_delivery_date.Value.Date;
            dtp_expiry.MaxDate = DateTime.Today.AddYears(10);

            txt_received_by.Text = UserSession.CurrentUser.first_Name.ToString();
        }

        private bool InvoiceExists(string invoice) 
        {
            var repo = new DeliveryRepository();
            var controller = new DeliveryController(repo);

            return controller.GetDeliveryExists(invoice);
        }

        private bool IsValid() 
        {
            bool validated = true;

            var repo = new DeliveryRepository();
            var controller = new DeliveryController(repo);
            

            validated &= Validator.ValidateDeliveredDate(dtp_delivery_date, errorProvider1);
            validated &= Validator.ValidateExpirationDate(dtp_expiry, dtp_delivery_date, errorProvider1);
            validated &= Validator.ValidateSupplier(cb_supplier_name, errorProvider1);
            validated &= Validator.ValidateProduct(cb_product_names, errorProvider1);
            validated &= Validator.ValidateInvoice(txt_invoice.Text.Trim(), txt_invoice, errorProvider1, name => controller.GetDeliveryExists(txt_invoice.Text));
            validated &= Validator.ValidateQuantity(txt_qty.Text.Trim(), txt_qty, errorProvider1);
            validated &= Validator.ValidateDecimalValue(txt_price.Text.Trim(), txt_price, errorProvider1, "Price");
            validated &= Validator.ValidateNotes(txt_notes.Text.Trim(), txt_notes, errorProvider1);
            validated &= Validator.ValidateSellingPrice(txt_price.Text.Trim(), txt_price, errorProvider1);

            return validated;

        }
        //private bool IsValid()
        //{

        //    bool validated = true;
        //    DateTime deliveredDate = dtp_delivery_date.Value;
        //    DateTime expirationDate = dtp_expiry.Value;


        //    // REQUIRED FIELD

        //    // INBOICE 
        //    if (!Validator.IsRequiredTextField(txt_invoice, errorProvider1, "Invoice is required."))
        //    {
        //        validated = false;
        //    }
        //    else if (!Validator.IsMinimumLength(txt_invoice, errorProvider1, "Invoice must be at least 3 characters.", 3))
        //    {
        //        validated = false;
        //    }
        //    else if (!Validator.Pattern(txt_invoice, errorProvider1, @"^[A-Za-z0-9 _.\-&/]{3,50}$", "Invoice can only contain letters, numbers, spaces, dots, underscores, hyphens, ampersands, and slashes."))
        //    {
        //        validated = false;
        //    }
        //    else if (InvoiceExists(txt_invoice.Text.Trim()))
        //    {
        //        errorProvider1.SetError(txt_invoice, "Invoice already exists!");
        //        validated = false;
        //    }


        //    // QTY 
        //    if (!Validator.IntOnly(txt_qty, errorProvider1, "Quantity is required.", "No spaces allowed.", "Quantity must be a whole number.", "Quantity must be greater than zero."))
        //    {
        //        validated = false;
        //    }

        //    // PRICE
        //    if (!Validator.DecimalOnly(txt_price, errorProvider1,
        //        "Price is required.",
        //        "No spaces allowed.",
        //        "Price must be a valid number.",
        //        "Price must be at least 1.00."))
        //    {
        //        validated = false;
        //    }


        //    if (!string.IsNullOrWhiteSpace(txt_notes.Text)) 
        //    {
        //        if (txt_notes.Text.Length < 10)
        //        {
        //            errorProvider1.SetError(txt_notes, "Notes must be at least 10 characters..");
        //            validated = false;
        //        }

        //        else if (!Validator.MultiLinePattern(txt_notes, errorProvider1,
        //            @"^[A-Za-z0-9\s.,!?()\-']+$""",
        //            "Notes can only contain letters, numbers, and common punctuation(. , ! ? ( ) - ')."))
        //        {
        //            validated = false;
        //        }



        //    }



        //    if (!Validator.IsComboBoxSelected(cb_product_names, errorProvider1, "Product is Required"))
        //    {
        //        validated = false;
        //    }

        //    if (!Validator.IsComboBoxSelected(cb_supplier_name, errorProvider1, "Supplier is Required"))
        //    {
        //        validated = false;
        //    }

        //    if (deliveredDate > DateTime.Now)
        //    {
        //        errorProvider1.SetError(dtp_delivery_date, "Delivered date cannot be in the future.");
        //        validated = false;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(dtp_delivery_date, "");
        //    }

        //    if (expirationDate <= deliveredDate)
        //    {
        //        errorProvider1.SetError(dtp_expiry, "Expiration date must be after the delivered date.");
        //        validated = false;
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(dtp_expiry, "");
        //    }




        //    return validated;


        //}

        private void LoadSupplier() 
        {
            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
            var suppliers = controller.GetAllSuppliers();

            cb_supplier_name.DisplayMember = "supplier_name";
            cb_supplier_name.ValueMember = "supplier_id";
            cb_supplier_name.DataSource = suppliers;
            cb_supplier_name.SelectedIndex = -1;
        }
        private void LoadProducts()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var products = controller.GetProductToOrder();

            cb_product_names.DisplayMember = "product_name";
            cb_product_names.ValueMember = "product_id";
            cb_product_names.DataSource = products;
            cb_product_names.SelectedIndex = -1;



            txt_price.Clear();

        }
        
        private void LoadProductSizes(int product_id) 
        {
            var repo = new ProductSizeRepository();
            var controller = new ProductSizeController(repo);
            var products_size = controller.GetProductSize(product_id);

            cmb_product_size.DisplayMember = "size_label";
            cmb_product_size.ValueMember = "product_size_id";
            cmb_product_size.DataSource = products_size;
            cmb_product_size.SelectedIndex = -1;

            txt_price.Clear();



        }
        private void UpdateTotal()
        {
            if (decimal.TryParse(txt_price.Text, out decimal price) &&
                int.TryParse(txt_qty.Text, out int qty))
            {
                var total = price * qty;
                txt_total.Text = total.ToString("N2");

            }
            else 
            {
                txt_total.Text = string.Empty;
            }
           
        }
        private void Clear()
        {
            cb_product_names.Hint = string.Empty;
            cb_supplier_name.Hint = string.Empty;
            cb_product_names.SelectedIndex = -1;
            txt_notes.Clear();
            txt_price.Clear();
            txt_total.Clear();
            txt_qty.Clear();
            totalVolume = 0;
            cb_product_names.Hint = "Select Product";
            cb_supplier_name.Hint = "Select Supplier";


        }

        private void cb_product_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_product_names.SelectedIndex >= 0)
            {
                var selectedProduct = cb_product_names.SelectedItem as ProductModel;
                if (selectedProduct != null)
                {
                    LoadProductSizes(selectedProduct.product_id);
                    

                }
                else
                {


                }
            }

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(txt_qty.Text);
            total_qty = qty * content;
            if (!IsValid()) return;
 

            string product_id_size = cmb_product_size.SelectedValue.ToString();
            bool isDuplicate = dgv_Items.Rows
                .Cast<DataGridViewRow>()
                .Any(row => row.Cells[0].Value?.ToString() == product_id_size);

            if (isDuplicate)
            {
                MessageBox.Show("Duplicate products are not allowed in the same delivery.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgv_Items.Rows.Add(
                  cb_product_names.SelectedValue,
                  cb_product_names.Text,
                  cmb_product_size.SelectedValue,
                  cmb_product_size.Text,
                  txt_qty.Text.Trim(),
                  content.ToString(),
                  total_qty.ToString(),
                  txt_price.Text.Trim(),
                  txt_total.Text.Trim(),
                  dtp_delivery_date.Value.ToShortDateString(),
                  dtp_expiry.Value.ToShortDateString(),
                  txt_notes.Text.Trim()

               );
            btn_save.Enabled = dgv_Items.Rows.Count > 0;

          
            if (dgv_Items.Rows.Count > 0)
            {
                btn_save.Enabled = true;
            }
            else
            {
                btn_save.Enabled = false;
            }



            Clear();

        }



        private void dgv_Items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_Items.Columns[e.ColumnIndex].Name == "col_view_delivered_items") 
            {


                DataGridViewRow row = dgv_Items.Rows[e.RowIndex];
                cb_product_names.Hint = string.Empty;
                cb_supplier_name.Hint = string.Empty;
                cmb_product_size.Hint = string.Empty;
                cb_product_names.SelectedValue = Convert.ToInt32(row.Cells["product_id"].Value);
                cmb_product_size.SelectedValue = Convert.ToInt32(row.Cells["col_product_size_id"].Value);
                txt_qty.Text = row.Cells["col_qty"].Value?.ToString();
                txt_price.Text = row.Cells["col_price"].Value?.ToString();
                txt_total.Text = row.Cells["col_total"].Value?.ToString();
                dtp_delivery_date.Value = DateTime.Parse(row.Cells["col_delivered_date"].Value?.ToString());
                dtp_expiry.Value = DateTime.Parse(row.Cells["col_expiry_date"].Value?.ToString());
                txt_notes.Text = row.Cells["col_note"].Value?.ToString();

                cb_product_names.Hint = "Select Product";
                cb_supplier_name.Hint = "Select Supplier";
                cmb_product_size.Hint = "Select Product Size";
                btn_update.Visible = true;
                btn_cancel.Visible = true;
                btn_add.Visible = false;
                btn_delete.Enabled = true;
            }


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_add.Visible = true;
            btn_cancel.Visible = false;
            btn_update.Visible = false;
            btn_delete.Enabled = false;
            
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            var _repo = new DeliveryRepository();
            var deliveryController = new DeliveryController(_repo);

            var itemDeliveredRepo = new DeliveredItemRepository();
            var deliveryItemController = new DeliveryItemController(itemDeliveredRepo);

            var inventoryRepo = new InventoryRepository();
            var inventoryController = new InventoryController(inventoryRepo);

            var stock_in_repo = new Stock_In_Repository();
            var stock_in_controller = new Stock_In_Controller(stock_in_repo);


            // SUMMARY
            var deliveryModel = new DeliveryModel
                {
                    supplier_id = Convert.ToInt32(cb_supplier_name.SelectedValue),
                    date = dtp_delivery_date.Value,
                    invoice = txt_invoice.Text,
                    received_by = txt_received_by.Text,
                    status = "Pending"
        

                };

            int id = deliveryController.AddDelivery(deliveryModel);


            // ITEMS DELIVERED
            foreach (DataGridViewRow row in dgv_Items.Rows)
            {
                if (row.IsNewRow) continue;
                int product_id = Convert.ToInt32(row.Cells["product_id"].Value);
                int product_size_id = Convert.ToInt32(row.Cells["col_product_size_id"].Value);
                int quantity = Convert.ToInt32(row.Cells["col_qty"].Value);
                string size_label = row.Cells["col_size_label"].Value.ToString();
                int content = Convert.ToInt32(row.Cells["col_content"].Value.ToString());
                int total_qty = Convert.ToInt32(row.Cells["col_total_qty"].Value.ToString());
                decimal unitPrice = Convert.ToDecimal(row.Cells["col_price"].Value);
                decimal totalPrce = Convert.ToDecimal(row.Cells["col_total"].Value);
                DateTime deliveredDate = Convert.ToDateTime(row.Cells["col_delivered_date"].Value);
                DateTime expiryDate = Convert.ToDateTime(row.Cells["col_expiry_date"].Value);
                string notes = row.Cells["col_note"].Value.ToString();


                var deliveryItemModel = new DeliveryItemModel
                {
                    delivery_id = id,
                    product_id = product_id,
                    product_size_id = product_size_id,
                    qty_delivered = quantity,
                    content = content,
                    total_qty = total_qty,
                    unit_price = unitPrice,
                    total_price = totalPrce,
                    expiry_date = expiryDate,
                    notes = notes,
                };
                deliveryItemController.AddDeliveryItem(deliveryItemModel);

                var Stock_In = new Stock_In_Model
                {
                    delivery_id = id,
                    product_id = product_id,
                    product_size_id = product_size_id,
                    qty = quantity,
                    total = total_qty
                };

                if (stock_in_controller.AddStock(Stock_In)) 
                {

                    bool exists = inventoryController.ProductExists(product_id, product_size_id);

                    if (exists)
                    {
                        inventoryController.UpdateInventory(product_id, product_size_id, quantity, total_qty);
                    }
                    else 
                    {
                        var inventoryModel = new InventoryViewModel
                        {
                            product_id = product_id,
                            product_size_id = product_size_id,
                            qty = quantity,
                            total_remaining = total_qty
                        };
                        inventoryController.AddInventory(inventoryModel);
                    }
                    mainform.LoadInventory(1,25);
                }
                //bool exists = inventoryController.ProductExists(product_id);

                //if (exists)
                //{

                //    inventoryController.UpdateInventory(product_id, quantity, total_volume);

                //    AddAndLoadExpenses("Inventory Purchase", cb_product_names.Text + " restock ("+ quantity +" units)", totalPrce, txt_received_by.Text, "", DateTime.Now);

                //    Audit.AuditLog(
                //    DateTime.Now,
                //    "Restock",
                //    UserSession.CurrentUser.first_Name,
                //    "Manage Delivery",
                //   $"Restocked existing product '{cb_product_names.Text}' (Qty: {quantity}, Volume: {total_volume}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                //    );

                //}
                //else
                //{

                //    var inventoryModel = new InventoryViewModel
                //    {
                //        product_id = product_id,
                //        unit = quantity,
                //        volume_per_unit = volume,
                //        volume = total_volume
                //    };
                //    inventoryController.AddInventory(inventoryModel);

                //    AddAndLoadExpenses("Inventory Purchase", cb_product_names.Text, totalPrce, txt_received_by.Text,"",DateTime.Now);

                //    Audit.AuditLog(
                //    DateTime.Now,
                //    "Add",
                //    UserSession.CurrentUser.first_Name,
                //    "Manage Delivery",
                //    $"Added delivery for product '{cb_product_names.Text}' (Qty: {quantity}, Volume: {total_volume}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                //    );

                //}



                //var inventoryBath = new InventoryBatchModel
                //{
                //    delivery_item_id = item_id,
                //    product_id = product_id,
                //    unit = quantity,
                //    volume_per_unit = volume,
                //    volume = total_volume,
                //    price = unitPrice,
                //    notes = notes,
                //    delivered_date = deliveredDate,
                //    expiry_date = expiryDate
                //};

                //inventoryBatchController.AddBatchInventory(inventoryBath);






            }
            RefreshData?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Delivery has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //await mainform.RefreshDeliveryAsync();
            //await mainform.RefreshInventoryAsync();
    
            this.Close(); 

        }

        private void AddAndLoadExpenses(string category, string description, decimal amount, string paid_by, string notes, DateTime timestamp)
        {
            var repo = new ExpensesRepository();
            var controller = new ExpensesController(repo);

            var model = new ExpensesModel 
            {
                category = category,
                description = description,
                amount = amount,
                paid_by = paid_by,
                notes = notes,
                timestamp = timestamp
            };

            controller.AddExpenses(model);

    
                
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_Items.CurrentRow == null || dgv_Items.CurrentRow.Index < 0)
                return;

            var confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                dgv_Items.Rows.RemoveAt(dgv_Items.CurrentRow.Index);

                btn_add.Visible = true;
                btn_cancel.Visible = false;
                btn_update.Visible = false;
                btn_delete.Enabled = false;

                if (dgv_Items.Rows.Count <= 0)
                {
                    btn_save.Enabled = false;
                }
                else
                {
                    btn_save.Enabled = true;
                }
                Clear();
            }


        }

        private void txt_notes_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_Items.CurrentRow != null)
            {
                var row = dgv_Items.CurrentRow;
                row.Cells["product_id"].Value = cb_product_names.SelectedValue;
                row.Cells["col_product_name"].Value = cb_product_names.Text;
                row.Cells["col_qty"].Value = txt_qty.Text;
                row.Cells["col_volume"].Value = cmb_product_size.Text;
                row.Cells["col_price"].Value = txt_price.Text;
                row.Cells["col_total"].Value = txt_price.Text;
                row.Cells["col_delivered_date"].Value = dtp_delivery_date.Value.ToShortDateString();
                row.Cells["col_expiry_date"].Value = dtp_expiry.Value.ToShortDateString();
                row.Cells["col_note"].Value = txt_notes.Text;
            }

            btn_add.Visible = true;
            btn_cancel.Visible = false;
            btn_update.Visible = false;
            Clear();
        }

        private void txt_invoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Allow uppercase letters, digits, hyphen, slash
            if (char.IsLetterOrDigit(c) || c == '-' || c == '/')
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Allow digits only
            if (char.IsDigit(c))
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Allow digits
            if (char.IsDigit(c))
                return;

            // Allow one decimal point, not at the start
            if (c == '.' && txt != null)
            {
                if (!txt.Text.Contains(".") && txt.SelectionStart > 0)
                    return;

                e.Handled = true;
                return;
            }

            // Block everything else
            e.Handled = true;
        }

        private void txt_notes_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialMultiLineTextBox2 txt = sender as MaterialMultiLineTextBox2;
            if (txt == null || string.IsNullOrWhiteSpace(txt.Text))
                return;

            // Trim leading/trailing spaces and normalize spacing
            string cleaned = txt.Text.Trim();

            // Optional: replace multiple spaces with single space
            cleaned = System.Text.RegularExpressions.Regex.Replace(cleaned, @"\s{2,}", " ");

            txt.Text = cleaned;
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_product_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_product_size.SelectedIndex >= 0)
            {
                var selectedProductSize = cmb_product_size.SelectedItem as ProductSizeModel;
                if (selectedProductSize != null)
                {

                    txt_price.Text = selectedProductSize.cost_price.ToString("N2");
                    content = selectedProductSize.content;
                }
                else
                {


                }
            }
        }
    }
}
