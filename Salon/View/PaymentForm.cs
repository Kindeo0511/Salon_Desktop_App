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
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Salon.View
{
    public partial class PaymentForm : MaterialForm
    {
        private MainForm mainForm;
        private AppointmentModel model;

        private decimal vat_rate;
        private decimal discount_rate;

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

             
                lbl_CustomerName.Text = model.CustomerName;
                lbl_Date.Text = model.AppointmentDate.ToString("yyyy-MM-dd");
                lbl_Time.Text = formattedStartTime + " - " + formattedEndTime;
                lbl_Services.Text = model.Services;
                lbl_Subtotal.Text = model.selling_price.ToString("N2");
                lbl_Vat.Text = model.vat_amount.ToString("N2");
                lbl_book_type.Text = model.BookingType.ToString();
                _vatAmount = decimal.TryParse(lbl_Vat.Text, out var result) ? result : 0;
                _subtotal = Convert.ToDecimal(model.selling_price.ToString());


            }
            LoadDiscount();
            LoadVat();
            calculate();

            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

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
                calculate();
            }
            else
            {
                lbl_tax_rate.Text = "Vat";
                lbl_Vat.Text = "₱0.00";
            }
        }


        private void cb_discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_discount.SelectedIndex >= 0)
            {
                var selectedDiscount = cb_discount.SelectedItem as DiscountModel;
                if (selectedDiscount != null)
                {
                    discount_rate = selectedDiscount.discount_rate; // Set the actual rate
                    lbl_discount_type.Text = $"Discount ({discount_rate}%)";
                    calculate();
                }
            }
            else
            {

                discount_rate = 0;
                lbl_discount_type.Text = "Discount";
                lbl_Discount.Text = "₱0.00";
                calculate();
            }


        }
        private decimal ParseCurrency(string input)
        {
            string cleaned = input.Replace("₱", "").Trim();
            return decimal.TryParse(cleaned, out decimal value) ? value : 0;
        }
        private void calculate()
        {
            _subtotal = ParseCurrency(lbl_Subtotal.Text);
            _discountAmount = _subtotal * (discount_rate / 100);
            _totalWithVat = _subtotal - _discountAmount;

            lbl_Discount.Text = _discountAmount > 0 ? $"₱ {_discountAmount:N2}" : "₱0.00";


            lbl_Total.Text = $"₱ {_totalWithVat:N2}";
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

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            calculate();
            DateTime startTime = DateTime.Today.Add(model.StartTime);
            DateTime endTime = DateTime.Today.Add(model.EndTime);

            string formattedStartTime = startTime.ToString("hh:mm tt");
            string formattedEndTime = endTime.ToString("hh:mm tt");

            invoice = "INV-" + model.AppointmentDate.ToString("yyyy-MM-dd") + "-" + model.AppointmentId.ToString("D6");
            lbl_CustomerName.Text = model.CustomerName;
            lbl_Date.Text = model.AppointmentDate.ToString("yyyy-MM-dd");
            lbl_Time.Text = formattedStartTime + " - " + formattedEndTime;
            lbl_Services.Text = model.Services;
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

            if (cb_PaymentMethod.Text.ToLower() == "gcash") 
            {
                validated &= Validator.IsRequired(txt_Reference, errorProvider1, "Reference No. is required.");
            }


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
        private void btn_confirm_payment_Click(object sender, EventArgs e)
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


            var discount_type = string.IsNullOrWhiteSpace(cb_discount.Text) ? "N/A" : cb_discount.Text;
            var reference_no = string.IsNullOrWhiteSpace(txt_Reference.Text) ? "N/A" : txt_Reference.Text;

            var payment = new PaymentModel
            {
                AppointmentId = model.AppointmentId,
                AmountPaid = amountPaid,
                DiscountType = discount_type,
                TotalAmount = _totalWithVat,
                ChangeAmount = changeAmount,
                DiscountAmount = _discountAmount,
                VatAmount = _vatAmount,
                PaymentMethod = cb_PaymentMethod.SelectedItem.ToString(),
                ReferenceNo = reference_no,
                PaidAt = DateTime.Now
            };

            if (cb_PaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");     
                return;
            }
            if (CustomerDiscountUsageCount(Convert.ToInt32(cb_discount.SelectedValue), model.CustomerId) >= DiscountCustomerlimit(Convert.ToInt32(cb_discount.SelectedValue)))
            {
                MessageBox.Show("This customer has reached the usage limit for this discount.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bool inventoryOk = Product_Inventory();
                if (!inventoryOk)
                {
                    MessageBox.Show("❌ Payment cannot proceed due to insufficient inventory.", "Payment Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                InsertIntoDiscountUsage(Convert.ToInt32(cb_discount.SelectedValue), model.CustomerId, model.AppointmentId, DateTime.Today);
                paymentController.CreatePayment(payment);
                AddTransactions(model.AppointmentId, _vatAmount, _discountAmount,_subtotal, totalAmount, cb_PaymentMethod.SelectedItem.ToString(), "Paid", DateTime.Now);
                appointment.UpdateAppointmentPayment(model.AppointmentId, "Paid", "Completed");
                MessageBox.Show("✅ Payment has been recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Audit.AuditLog(
                  DateTime.Now,
                  "Process Payment", 
                  UserSession.CurrentUser.first_Name,
                  "Appointment",
                  $"Processed payment for client '{model.ClientName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
              );

                mainForm.LoadAppointments();
                mainForm.LoadTotalSales();
                mainForm.LoadAllTransactions();
                btn_invoice.Enabled = true;
                btn_confirm_payment.Enabled = false;
            }
        }

        private bool Product_Inventory()
        {
            var inventoryController = new InventoryController(new InventoryRepository());
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

                    if (inventoryItem == null) continue;

                    if (inventoryItem.unit <= 0)
                    {
                        string productName = inventoryItem.product_name ?? "Unknown Product";
                        MessageBox.Show($"❌ \"{productName}\" has no available units in stock.", "Inventory Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    double unitVolume = (double)inventoryItem.volume / inventoryItem.unit;
                    double totalVolume = unitVolume * inventoryItem.unit;
                    double usedVolume = product.total_usage_amount;

                    if (totalVolume < usedVolume)
                    {
                        string productName = inventoryItem.product_name ?? "Unknown Product";
                        MessageBox.Show($"❌ Insufficient stock for \"{productName}\".\nRequired: {usedVolume:N2} ml\nAvailable: {totalVolume:N2} ml", "Inventory Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    double remainingVolume = totalVolume - usedVolume;
                    double updatedUnitCount = remainingVolume / unitVolume;

                    inventoryController.UpdateInventoryByVolume(product.product_id, updatedUnitCount, usedVolume);
                }
            }

            mainForm.LoadInventory();
            return true;
        }

        private void btn_invoice_Click(object sender, EventArgs e)
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
            renderer.DrawLabelValue("Service", "Price"); // Table header
            renderer.DrawSeparator();

            // Service rows
            decimal subtotal = 0;
            foreach (var service in _serviceList)
            {
                renderer.DrawLabelValue(service.ServiceName, service.SellingPrice.ToString("C2"));
                subtotal += service.SellingPrice;
            }

            renderer.DrawSeparator();
      
            // Totals
            renderer.DrawLabelValue("Subtotal:", subtotal.ToString("C2"));
            renderer.DrawLabelValue("Discount:", _discountAmount.ToString());
            renderer.DrawLabelValue($"VAT ({vat_rate:N0}%):", _vatAmount.ToString("C2"));
            renderer.DrawBoldValue("Total:", lbl_Total.Text);
            renderer.DrawBoldValue("Change Amount:", lbl_change_amount.Text);
            renderer.DrawBoldValue("Payment Method:", cb_PaymentMethod.Text);

            if (cb_PaymentMethod.Text.Trim().Equals("GCash", StringComparison.OrdinalIgnoreCase))
            {
                renderer.DrawBoldValue("Reference No.:", txt_Reference.Text);
            }

            renderer.DrawFooter("Thank you for choosing us!");



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

