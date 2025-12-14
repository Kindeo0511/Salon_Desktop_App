using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Salon.View
{
    public partial class PaymentForm : MaterialForm
    {
        private MainForm mainForm;
        private AppointmentModel model;

        private decimal vat_rate;
        private decimal discount_rate;
        private int invoice_id;
        private decimal _subtotal;
        private decimal _discountAmount;
        private decimal _vatAmount;
        private decimal _totalWithVat;

        private readonly PaymentController paymentController;
        private readonly AppointmentController appointment = new AppointmentController();

        private readonly AppointmentServiceController _appointmentServiceController;
        private List<AppointmentServicesModel> _serviceList;

        private string invoice, payment_status;
        public PaymentForm(MainForm mainForm, AppointmentModel appointmentModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
            this.model = appointmentModel;
            var _repo = new PaymentRepository();
            paymentController = new PaymentController(_repo);
  
            if (model != null)
            {
                var _appointmentServiceRepo = new AppointmentServiceRepository();
                _appointmentServiceController = new AppointmentServiceController(_appointmentServiceRepo);
                _serviceList = _appointmentServiceController
                .GetServicesByAppointmentId(model.AppointmentId)
                .ToList();

                DateTime startTime = DateTime.Today.Add(model.StartTime);
                DateTime endTime = DateTime.Today.Add(model.EndTime);

                string formattedStartTime = startTime.ToString("hh:mm tt");
                string formattedEndTime = endTime.ToString("hh:mm tt");


                txt_name.Text = this.model.DisplayCustomerName;
                lbl_Date.Text = model.AppointmentDate.ToString("yyyy-MM-dd");
                lbl_Time.Text = formattedStartTime + " - " + formattedEndTime;
               
              

                lbl_book_type.Text = model.BookingType.ToString();

                

                _subtotal = Convert.ToDecimal(model.selling_price.ToString());

                invoice_id = GetInvoiceId(this.model.AppointmentId);

                LoadServices(invoice_id);

                lbl_Subtotal.Text = CalculateSubTotal().ToString("N2");
                _subtotal =  lbl_Subtotal.Text != "" ? Convert.ToDecimal(lbl_Subtotal.Text) : 0m;
            }
            LoadVat();
            LoadDiscount();
           
 

            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }

     
        private void LoadServices(int id) 
        {
            var repo = new InvoiceServiceRepository();
            var controller = new InvoiceServiceCartController(repo);
            var services = controller.GetInvoiceServiceCartByInvoiceId(id);

            dgv_Table.AutoGenerateColumns = false;

            col_service.DataPropertyName = "ItemName";
            col_price.DataPropertyName = "TotalPrice";
            col_duration.DataPropertyName = "Duration";
            col_qty.DataPropertyName = "Quantity";
            dgv_Table.DataSource = services;

        }
        private void LoadDiscount()
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);
            var discounts = controller.GetDiscounts();

            cb_discount.DisplayMember = "discount_and_promo_code";
            cb_discount.ValueMember = "discount_id";
            cb_discount.DataSource = discounts;

            cb_discount.SelectedIndex = -1;

            lbl_discount_type.Text = "Discount";
            lbl_Discount.Text = "0.00";


        }
        private void LoadVat()
        {
            var repo = new VatRepository();
            var controller = new VatController(repo);
            var vat = controller.LoadLatestTax();

            if (vat != null)
            {
                vat_rate = vat.tax;
                lbl_tax_rate.Text = $"Vat ({vat.tax}%)";
             
            }
            else
            {
                lbl_tax_rate.Text = "Vat";
                lbl_Vat.Text = "₱0.00";
            }
        }
        private int GetInvoiceId(int id)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int invoice_id = controller.GetInvoice(id);

            return invoice_id;

        }
        private decimal CalculateSubTotal() 
        {
            decimal subtotal = 0m;
            foreach (DataGridViewRow row in dgv_Table.Rows)
            {
                if (row.Cells["col_price"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["col_price"].Value);
                }
            }

           
            return subtotal;
        }
        private decimal CalculateVatInclusive(string price, decimal vat_rate, decimal discount_rate)
        {
            decimal inclusive_price = ParseCurrency(price); // VAT-inclusive total

            // Step 1: Remove VAT
            decimal base_price = inclusive_price / (1 + (vat_rate / 100));

            // Step 2: Compute VAT amount
            decimal vat_amount = inclusive_price - base_price;

            // Step 3: Compute discount (base price)
            decimal discount = base_price * (discount_rate / 100);

            // Step 4: Compute final payable amount
            decimal final_price = base_price - discount;

            // Update labels
            vat_amount = Math.Round(vat_amount, 2, MidpointRounding.AwayFromZero);
            discount = Math.Round(discount, 2, MidpointRounding.AwayFromZero);
            final_price = Math.Round(final_price, 0, MidpointRounding.AwayFromZero);

            _vatAmount = vat_amount;
            _discountAmount = discount;
            lbl_Vat.Text = vat_amount > 0 ? $"₱ {vat_amount:N2}" : "₱0.00";
            lbl_Discount.Text = discount > 0 ? $"₱ {discount:N2}" : "₱0.00";
            return final_price;
        }

        //private void cb_discount_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cb_discount.SelectedIndex >= 0)
        //    {
        //        var selectedDiscount = cb_discount.SelectedItem as DiscountModel;
        //        if (selectedDiscount != null)
        //        {
        //            discount_rate = selectedDiscount.discount_rate; // Set the actual rate
        //            lbl_discount_type.Text = $"Discount ({discount_rate}%)";


        //            calculate();
        //        }
        //    }
        //    else
        //    {

        //        discount_rate = 0;
        //        lbl_discount_type.Text = "Discount";
        //        lbl_Discount.Text = "₱0.00";
        //        calculate();
        //    }


        //}
        private void cb_discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_discount.Text.Length > 0)
            {
                var selectedDiscount = cb_discount.SelectedItem as DiscountModel;
                if (selectedDiscount != null)
                {
                    discount_rate = selectedDiscount.discount_rate;
                    lbl_discount_type.Text = $"Discount ({discount_rate}%)";

                    lbl_Total.Text = CalculateVatInclusive(lbl_Subtotal.Text, vat_rate, discount_rate).ToString("N2");
                }
               
            }
            else
            {
                discount_rate = 0;
                lbl_discount_type.Text = "Discount";
                lbl_Discount.Text = "₱0.00";
                lbl_Vat.Text = "₱0.00";
                lbl_Total.Text = "₱0.00";

                // ✅ Reset VAT exemption when no discount is selected
                sw_exempt_vat.Checked = false;

         
            }
        }

        private decimal ParseCurrency(string input)
        {
            string cleaned = input.Replace("₱", "").Trim();
            return decimal.TryParse(cleaned, out decimal value) ? value : 0;
        }
        private void calculate()
        {
           
        }

        private void txt_amount_paid_TextChanged(object sender, EventArgs e)
        {
            decimal amountPaid = 0m;
            decimal totalAmount = ParseCurrency(lbl_Total.Text);


            if (!decimal.TryParse(txt_amount_paid.Text, out amountPaid))
            {
                lbl_change_amount.Text = "0.00";
                return;
            }


            decimal changeAmount = amountPaid - totalAmount;


            lbl_change_amount.Text = changeAmount < 0 ? "0.00" : changeAmount.ToString("F2");

        }

        private async  void PaymentForm_Load(object sender, EventArgs e)
        {
       
            LoadVat();
            calculate();
            DateTime startTime = DateTime.Today.Add(model.StartTime);
            DateTime endTime = DateTime.Today.Add(model.EndTime);

            string formattedStartTime = startTime.ToString("hh:mm tt");
            string formattedEndTime = endTime.ToString("hh:mm tt");

            invoice = "INV-" + model.AppointmentDate.ToString("yyyy-MM-dd") + "-" + model.AppointmentId.ToString("D6");
            txt_name.Text = model.DisplayCustomerName;
            lbl_Date.Text = model.AppointmentDate.ToString("yyyy-MM-dd");
            lbl_Time.Text = formattedStartTime + " - " + formattedEndTime;
       
            payment_status = model.PaymentStatus;
            lbl_book_type.Text = model.BookingType.ToString();
             

            int baseHeight = 400; // estimated in pixels or logical units
            int rowHeight = 20;
            int estimatedHeight = baseHeight + (_serviceList.Count * rowHeight);

            // Convert to hundredths of an inch (assuming 96 DPI)
            int heightInHundredths = (int)(estimatedHeight * 100f / 96f); // or just *100 if you're already in inches
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 300, heightInHundredths);
        }

        private bool Validated()
        {

            bool validated = true;
            // REQUIRED FIELD
            validated &= Validator.IsRequired(cb_PaymentMethod, errorProvider1, "Payment Method is required.");
            validated &= Validator.IsRequired(txt_amount_paid, errorProvider1, "Amount is required.");

            //if (cb_PaymentMethod.Text.ToLower() == "gcash")
            //{
            //    validated &= Validator.IsRequired(txt_Reference, errorProvider1, "Reference No. is required.");

            //    // Validate 13-digit numeric format
            //    string reference = txt_Reference.Text.Trim();
            //    bool isValidFormat = reference.Length == 13 && reference.All(char.IsDigit);

            //    if (!isValidFormat)
            //    {
            //        errorProvider1.SetError(txt_Reference, "Reference No. must be exactly 13 digits.");
            //        validated = false;
            //    }
            //    else
            //    {
            //        errorProvider1.SetError(txt_Reference, "");
            //    }
            //}



            return validated;


        }
        private int CustomerDiscountUsageCount(int discount_id, int customer_id) 
        {
            var repo = new DiscountUsageRepository();
            var controller = new DiscountUsageController(repo);
            var counts =  controller.GetUsageCount(discount_id, customer_id);

            return counts;
            
        }

        private int DiscountCustomerlimit(int discount_id) 
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);
            var limit = controller.GetDiscountById(discount_id);

            return limit.per_customer_limit;

        }

        private void InsertIntoDiscountUsage(int discount_id, int customer_id, int appointment_id, DateTime used_on) 
        {
            var repo = new DiscountUsageRepository();
            var controller = new DiscountUsageController(repo);
            var model = new DiscountUsageModel
            {
                discount_id = discount_id,
                customer_id = customer_id,
                appointment_id = appointment_id,
                used_on = used_on,
            };

           
                controller.AddDiscountUsage(model);
            
   
            
        }
        private async void btn_confirm_payment_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;

            decimal amountPaid = 0m;
            decimal totalAmount = ParseCurrency(lbl_Total.Text);
            decimal changeAmount = ParseCurrency(lbl_change_amount.Text);

            if (!decimal.TryParse(txt_amount_paid.Text, out amountPaid))
            {
                MessageBox.Show("Invalid amount paid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (amountPaid < totalAmount)
            {
                MessageBox.Show("Insufficient payment. Please collect the full amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_PaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            var discount_type = string.IsNullOrWhiteSpace(cb_discount.Text) ? "N/A" : cb_discount.Text;
            var reference_no = string.IsNullOrWhiteSpace(txt_Reference.Text) ? "N/A" : txt_Reference.Text;

            var invoice = new InvoiceModel
            {
                InvoiceID = invoice_id,
                TotalAmount = amountPaid,
                VATAmount = _vatAmount,
                DiscountAmount = _discountAmount,
                PaymentMethod = cb_PaymentMethod.SelectedItem.ToString(),
                Timestamp = DateTime.Now
            };

            //DiscountModel discount = null;
            //int selectedDiscountId = -1;

            //if (cb_discount.SelectedIndex >= 0 && cb_discount.SelectedValue != null)
            //{
            //    selectedDiscountId = Convert.ToInt32(cb_discount.SelectedValue);
            //    var repo = new DiscountRepository();
            //    var controller = new DiscountController(repo);
            //    discount = controller.GetDiscountById(selectedDiscountId);
            //}




            //if (discount != null)
            //{
            //    if (discount.discount_type != "Senior/PWD" &&
            //        discount.per_customer_limit > 0 &&
            //        CustomerDiscountUsageCount(selectedDiscountId, model.CustomerId) >= discount.per_customer_limit)
            //    {
            //        MessageBox.Show("This customer has reached the usage limit for this discount.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    InsertIntoDiscountUsage(selectedDiscountId, model.CustomerId, model.AppointmentId, DateTime.Today);
            //}

            // Finalize payment
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);

            controller.UpdateInvoice(invoice);
            //AddTransactions(model.AppointmentId, _vatAmount, _discountAmount, _subtotal, totalAmount, cb_PaymentMethod.SelectedItem.ToString(), "Paid", DateTime.Now);
            appointment.UpdateAppointmentPayment(model.AppointmentId, "Paid", "Completed");

            MessageBox.Show("✅ Payment has been recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Audit.AuditLog(
                DateTime.Now,
                "Process Payment",
                UserSession.CurrentUser.first_Name,
                "Appointment",
                $"Processed payment for client '{model.ClientName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
            );
           PrintInvoice();

            await mainForm.RefreshInventoryAsync();
            await mainForm.RefreshBatchInventory();
            await mainForm.RefreshAppointmentAsync();
            await mainForm.RefreshTotalSales();
            await mainForm.RefreshTransactionAsync();

            this.Close();
        }

        //private void btn_confirm_payment_Click(object sender, EventArgs e)
        //{
        //    if (!Validated()) return;

        //    decimal amountPaid = 0m;
        //    decimal totalAmount = ParseCurrency(lbl_Total.Text);
        //    decimal changeAmount = ParseCurrency(lbl_change_amount.Text);
        //    if (!decimal.TryParse(txt_amount_paid.Text, out amountPaid))
        //    {
        //        MessageBox.Show("Invalid amount paid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (amountPaid < totalAmount)
        //    {
        //        MessageBox.Show("Insufficient payment. Please collect the full amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }


        //    var discount_type = string.IsNullOrWhiteSpace(cb_discount.Text) ? "N/A" : cb_discount.Text;
        //    var reference_no = string.IsNullOrWhiteSpace(txt_Reference.Text) ? "N/A" : txt_Reference.Text;

        //    var payment = new PaymentModel
        //    {
        //        AppointmentId = model.AppointmentId,
        //        AmountPaid = amountPaid,
        //        DiscountType = discount_type,
        //        TotalAmount = _totalWithVat,
        //        ChangeAmount = changeAmount,
        //        DiscountAmount = _discountAmount,
        //        VatAmount = _vatAmount,
        //        PaymentMethod = cb_PaymentMethod.SelectedItem.ToString(),
        //        ReferenceNo = reference_no,
        //        PaidAt = DateTime.Now
        //    };

        //    if (cb_PaymentMethod.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Please select a payment method.");     
        //        return;
        //    }

        //    int selectedDiscountId = Convert.ToInt32(cb_discount.SelectedValue);
        //    var repo = new DiscountRepository();
        //    var controller = new DiscountController(repo);
        //    var discount = controller.GetDiscountById(selectedDiscountId);

        //    // Bypass usage limit for Senior/PWD
        //    if (discount != null)
        //    {
        //        if (discount.discount_type != "Senior/PWD" &&
        //            discount.per_customer_limit > 0 &&
        //            CustomerDiscountUsageCount(selectedDiscountId, model.CustomerId) >= discount.per_customer_limit)
        //        {
        //            MessageBox.Show("This customer has reached the usage limit for this discount.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }
        //        else
        //        {
        //            bool inventoryOk = Product_Inventory();
        //            if (!inventoryOk)
        //            {
        //                MessageBox.Show("❌ Payment cannot proceed due to insufficient inventory.", "Payment Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }

        //            if (!string.IsNullOrWhiteSpace(cb_discount.Text) && cb_discount.SelectedValue != null)
        //            {
        //                int discountId = Convert.ToInt32(cb_discount.SelectedValue);
        //                InsertIntoDiscountUsage(discountId, model.CustomerId, model.AppointmentId, DateTime.Today);
        //            }

        //            paymentController.CreatePayment(payment);
        //            AddTransactions(model.AppointmentId, _vatAmount, _discountAmount, _subtotal, totalAmount, cb_PaymentMethod.SelectedItem.ToString(), "Paid", DateTime.Now);
        //            appointment.UpdateAppointmentPayment(model.AppointmentId, "Paid", "Completed");
        //            MessageBox.Show("✅ Payment has been recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            Audit.AuditLog(
        //              DateTime.Now,
        //              "Process Payment",
        //              UserSession.CurrentUser.first_Name,
        //              "Appointment",
        //              $"Processed payment for client '{model.ClientName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
        //          );

        //            mainForm.LoadAppointments();
        //            mainForm.LoadTotalSales();
        //            mainForm.LoadAllTransactions();
        //            btn_invoice.Enabled = true;
        //            btn_confirm_payment.Enabled = false;
        //        }
        //    }
        //}



        //if (CustomerDiscountUsageCount(Convert.ToInt32(cb_discount.SelectedValue), model.CustomerId) >= DiscountCustomerlimit(Convert.ToInt32(cb_discount.SelectedValue)))
        //{
        //    MessageBox.Show("This customer has reached the usage limit for this discount.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    return;
        //}



        private bool Product_Inventory()
        {
            var inventoryController = new InventoryController(new InventoryRepository());
            var batchController = new InventoryBatchController(new InventoryBatchRepository());
            var serviceProductController = new ServiceProductUsageController(new ServiceProductUsageRepository());
            var appointmentService = new AppointmentServiceController(new AppointmentServiceRepository());

            int appointmentId = model.AppointmentId;
            var serviceList = appointmentService.GetServicesByAppointmentId(appointmentId)?.ToList();

            if (serviceList == null || !serviceList.Any()) return true; // No services, nothing to deduct

            var inventoryProductList = inventoryController.GetAllInventory().ToList();

            foreach (var service in serviceList)
            {
                var serviceProducts = serviceProductController.GetAllServiceProducts(service.ServiceId)?.ToList();
                if (serviceProducts == null || !serviceProducts.Any()) continue;
                foreach (var product in serviceProducts)
                {
                    var inventoryItem = inventoryProductList
                        .FirstOrDefault(inv => inv.product_id == product.product_id);

                 

                    double unitVolume = (double)inventoryItem.volume / inventoryItem.unit;
                    double totalVolume = unitVolume * inventoryItem.unit;
                    double usedVolume = product.total_usage_amount;

                 

                    // 🔁 Deduct from batches
                    var availableBatches = batchController.GetAvailableBatchesByProductId(product.product_id);
                    double remainingUsage = usedVolume;


                    foreach (var batch in availableBatches)
                    {
                        double available = batch.volume - batch.used_volume;
                        if (available <= 0) continue;

                        double toUse = Math.Min(available, remainingUsage);
                        batchController.RecordBatchProductUsage(batch.batch_id, toUse);
                        remainingUsage -= toUse;

                        if (remainingUsage <= 0) break;
                    }

                  
                    // ✅ Update overall inventory
                    double remainingVolume = totalVolume - usedVolume;
                    double updatedUnitCount = remainingVolume / unitVolume;

                    inventoryController.UpdateInventoryByVolume(product.product_id, updatedUnitCount, usedVolume);
                }

                //foreach (var product in serviceProducts)
                //{
                //    var inventoryItem = inventoryProductList
                //        .FirstOrDefault(inv => inv.product_id == product.product_id);

                //    if (inventoryItem == null) continue;

                //    if (inventoryItem.unit <= 0)
                //    {
                //        string productName = inventoryItem.product_name ?? "Unknown Product";
                //        MessageBox.Show($"❌ \"{productName}\" has no available units in stock.", "Inventory Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return false;
                //    }

                //    double unitVolume = (double)inventoryItem.volume / inventoryItem.unit;
                //    double totalVolume = unitVolume * inventoryItem.unit;
                //    double usedVolume = product.total_usage_amount;

                //    if (totalVolume < usedVolume)
                //    {
                //        string productName = inventoryItem.product_name ?? "Unknown Product";
                //        MessageBox.Show($"❌ Insufficient stock for \"{productName}\".\nRequired: {usedVolume:N2} ml\nAvailable: {totalVolume:N2} ml", "Inventory Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return false;
                //    }

                //    double remainingVolume = totalVolume - usedVolume;
                //    double updatedUnitCount = remainingVolume / unitVolume;

                //    inventoryController.UpdateInventoryByVolume(product.product_id, updatedUnitCount, usedVolume);

                //}
            }

           

            return true;
        }

        private void PrintInvoice() 
        {
            if (ValidateChildren())
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                    Audit.AuditLog(
                    DateTime.Now,
                    "Generate Invoice",
                    UserSession.CurrentUser.first_Name,
                    "Appointment",
                    $"Generated Invoice for client '{model.ClientName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                    );
                }
            }
        }
        private void btn_invoice_Click(object sender, EventArgs e)
        {
           

         
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Define fonts
            Font font = new Font("Consolas", 10);
            Font boldFont = new Font("Consolas", 10, FontStyle.Bold);

            // Calculate centerX based on page width
            float pageWidth = e.MarginBounds.Width;
            float centerX = e.MarginBounds.Left + (pageWidth / 2);



            var renderer = new ReceiptRenderer(e.Graphics, font, boldFont, centerX);

            renderer.DrawHeader("Hair Care Center Salon");

            renderer.DrawCenteredLines(new[]
            {
                $"Invoice #: {invoice}",
                $"Customer: {model.CustomerName}",
                $"Date: {lbl_Date.Text}",
                $"Time: {lbl_Time.Text}"
            });

            renderer.DrawSeparator();
            renderer.DrawLabelValue("Service","Qty", "Price"); 
            renderer.DrawSeparator();

            // Service rows
     


            foreach (DataGridViewRow row in dgv_Table.Rows)
            {
                if (row.Cells["col_service"].Value != null && row.Cells["col_price"].Value != null)
                {
                    string service = row.Cells["col_service"].Value.ToString();
                    decimal price = Convert.ToDecimal(row.Cells["col_price"].Value);

                    // Render each service with its price
                    renderer.DrawLabelValue(service,"", price.ToString("C2"));
                }
            }



            renderer.DrawSeparator();
      
            // Totals
            renderer.DrawLabelValue("Subtotal:", "", _subtotal.ToString("C2"));
            renderer.DrawLabelValue("Discount:", "", _discountAmount.ToString());
            renderer.DrawLabelValue($"VAT ({vat_rate:N0}%):", "", _vatAmount.ToString("C2"));
            renderer.DrawBoldValue("Total:", lbl_Total.Text);
            renderer.DrawBoldValue("Change Amount:", lbl_change_amount.Text);
            renderer.DrawBoldValue("Payment Method:", cb_PaymentMethod.Text);

            if (cb_PaymentMethod.Text.Trim().Equals("GCash", StringComparison.OrdinalIgnoreCase))
            {
                renderer.DrawBoldValue("Reference No.:", txt_Reference.Text);
            }

            renderer.DrawFooter("Thank you for choosing us!");



        }

        private void sw_exempt_vat_CheckedChanged(object sender, EventArgs e)
        {
       
            calculate();
        }

        private void cb_PaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_PaymentMethod.Text.ToLower() == "gcash")
            {
                decimal amountPaid = ParseCurrency(lbl_Total.Text);
                txt_amount_paid.Text = amountPaid.ToString();
                txt_Reference.Enabled = true;
                txt_amount_paid.ReadOnly = true;
                txt_amount_paid.Enabled = true;
            }
            else if (cb_PaymentMethod.Text.ToLower() == "cash")
            {

                txt_Reference.Text = string.Empty;
                txt_amount_paid.Enabled = true;
                txt_Reference.Enabled = false;
                txt_amount_paid.ReadOnly = false;
            }
            else
            {
                txt_amount_paid.Text = string.Empty;
                txt_Reference.Text = string.Empty;
                txt_amount_paid.ReadOnly = false;
            }

            //if (cb_PaymentMethod.Text.ToLower() == "cash")
            //{
            //    txt_Reference.Enabled = false;
            //    txt_amount_paid
            //}
            //else if (cb_PaymentMethod.Text.ToLower() == "gcash")
            //{
            //    decimal amountPaid = ParseCurrency(lbl_Total.Text);
            //    txt_amount_paid.Text = amountPaid.ToString();
            //    txt_Reference.Enabled = true;
            //}
            //else 
            //{
            //    txt_Reference.Enabled = false;
            //}

        }

        private void lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void txt_Reference_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Allow letters and digits
            if (char.IsLetterOrDigit(c))
                return;

            // Allow hyphen (optional, depends on format)
            if (c == '-')
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_Reference_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            if (txt == null)
                return;

            // Only validate if GCash is selected
            if (cb_PaymentMethod.Text.Trim().ToLower() == "gcash")
            {
                string input = txt.Text.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    errorProvider1.SetError(txt, "Reference number is required.");
                    e.Cancel = true;
                }
                else if (input.Length != 13)
                {
                    errorProvider1.SetError(txt, "Reference number must be exactly 13 characters.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txt, ""); // Clear error
                }
            }
            else
            {
                // Clear error if not GCash
                errorProvider1.SetError(txt, "");
            }
        }

        private void dgv_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        // TRANSACTION
        private void AddTransactions(int appointment_id, decimal vat_amount, decimal discount_amount, decimal sub_total, decimal amount_paid, string payment_method, string payment_status, DateTime timestamp)
        {
            var repo = new TransactionRepository();
            var controller = new TransactionController(repo);

            var model = new TransactionModel
            {
                appointment_id = appointment_id,
                vat_amount = vat_amount,
                discount_amount = discount_amount,
                sub_total = sub_total,
                amount_paid = amount_paid,
                payment_method = payment_method,
                payment_status = payment_status,
                timestamp = timestamp
            };

            controller.AddTransaction(model);


        }
    }
}

