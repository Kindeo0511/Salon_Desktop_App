using MaterialSkin.Controls;
using Salon.Card;
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
        public int invoice_id;
        private decimal _subtotal;
        private decimal _discountAmount;
        private decimal _vatAmount;
        private decimal _totalWithVat;
        private bool pointsRedeemedAlready = false;
        private bool discountAppliedAlready = false;
        private readonly PaymentController paymentController;
        private readonly AppointmentController appointment = new AppointmentController();

        private readonly AppointmentServiceController _appointmentServiceController;
        private List<AppointmentServicesModel> _serviceList;
        public BindingList<ServiceCart> summaryItem = new BindingList<ServiceCart>();

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
                lbl_Time.Text =  formattedStartTime + " - " + formattedEndTime;

                if (model.CustomerType == "Member") 
                {
                    materialLabel4.Visible = true;
                    lbl_points.Visible = true;
                    lbl_points.Text = model.LoyaltyPoints.ToString();
                    btn_redeem_points.Enabled = true;
                }



                lbl_book_type.Text = model.CustomerType.ToString();

                

                _subtotal = Convert.ToDecimal(model.selling_price.ToString());
                
                invoice_id = GetInvoiceId(this.model.AppointmentId);

                LoadServices(invoice_id);

            }
            LoadVat();
          
           
 

            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }

        private void DeductByBaseUnitsFIFO() 
        {
           
          

            var repo = new StockOutRepository();
            var controller = new StockOutController(repo);

            var serviceProductController = new ServiceProductUsageController(new ServiceProductUsageRepository());



            foreach (var item in summaryItem)
            {
                // Case 1: Service-based item
                if (item.ServiceId.HasValue && item.ServiceId.Value != 0)
                {
                    var serviceProducts = serviceProductController
                        .GetAllServiceProducts(item.ServiceId.Value)?
                        .ToList();

                    if (serviceProducts != null && serviceProducts.Any())
                    {
                        foreach (var product in serviceProducts)
                        {
                            var qtyDeduction = product.qty_required;
                            controller.DeductStockOut(product.product_id, qtyDeduction);
                        }
                    }

                   
                }

                // Case 2: Product-based item
                else if (item.ProductId.HasValue && item.ProductId.Value != 0)
                {
                    int qty = item.Quantity;
                    var transactionId = controller.GetTransactionId(item.ProductId.Value);
                   
                    if (transactionId.transaction_id > 0)
                    {
                       controller.DeductProductStockOut(item.ProductId.Value, item.ProductSizeId ?? 0, qty);
                      

                    }
                    else
                    {
                        // Optional: notify user no transaction found
                    }
                }
            }
            MessageBox.Show("Payment has been recorded successfully!",
                                   "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
        public void LoadServices(int id) 
        {
            var repo = new InvoiceServiceRepository();
            var controller = new InvoiceServiceCartController(repo);
            var services = controller.GetInvoiceServiceCartByInvoiceId(id);

            var serviceItems = services.Where(s => s.ItemType == "Service").ToList();
            var productItems = services.Where(s => s.ItemType == "Product").ToList();


            dgv_table.AutoGenerateColumns = false;
            dgv_table.DataSource = null;
            col_service_id.DataPropertyName = "ServiceId";
            col_item_name.DataPropertyName = "ItemName";
            col_qty.DataPropertyName = "Quantity";
            col_unit_price.DataPropertyName = "Price";
            col_total.DataPropertyName = "TotalPrice";
            dgv_table.DataSource = serviceItems;
               
            dgv_product.AutoGenerateColumns = false;
            dgv_product.DataSource = null;
            col_product_isc_id.DataPropertyName = "service_cart_id";
            col_product_id.DataPropertyName = "ProductId";
            col_product_name.DataPropertyName = "ItemName";
            col_product_size.DataPropertyName = "Size";
            col_product_qty.DataPropertyName = "Quantity";
            col_product_price.DataPropertyName = "Price";
            col_product_total.DataPropertyName = "TotalPrice";
            dgv_product.DataSource = productItems;


            if (productItems.Count == 0)
            {
                flowLayoutPanel1.Height = 620;
                dgv_product.Height = 0;
               
                product_panel.Height = 0;
            }
            else
            {

            
                dgv_product.Visible = true;
                product_panel.Visible = true;
                dgv_product.Height = 250;
                product_panel.Height = 250;
            }


                summaryItem.Clear();
            foreach (var item in services) 
            {
                summaryItem.Add(item);
            }



            lbl_Subtotal.Text = CalculateSubTotal().ToString("N2");
            _subtotal = lbl_Subtotal.Text != "" ? Convert.ToDecimal(lbl_Subtotal.Text) : 0m;

            calculate();
        }

        private decimal LoadVat()
        {
            var repo = new VatRepository();
            var controller = new VatController(repo);
            var vat = controller.LoadLatestTax();

            if (vat != null)
            {
                vat_rate = vat.tax;
                return vat.tax;

            }
            else
            {
                return 0m;
            }
        }

        private int GetInvoiceId(int id)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int invoice_id = controller.GetInvoice(id);

            return invoice_id;

        }
        public decimal CalculateSubTotal() 
        {
            decimal subtotal = 0m;
            foreach (var item  in summaryItem)
            {
               
                    subtotal += item.Price * item.Quantity;
                
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
      

        private decimal ParseCurrency(string input)
        {
            string cleaned = input.Replace("₱", "").Trim();
            return decimal.TryParse(cleaned, out decimal value) ? value : 0;
        }
        private void UpdateMemberPoints()
        {
            int pointsBalance = Convert.ToInt32(lbl_point_amount.Tag);
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);


            var customerModel = new CustomerModel
            {
                customer_id = model.CustomerId ?? 0,
                loyalty_points = pointsBalance
            };

            controller.DeductCustomerPoints(customerModel);

        }
        private void calculate()
        {

            int pointsBalance;
            if (!int.TryParse(lbl_points.Text, out pointsBalance))
            {
                pointsBalance = 0; // fallback if parsing fails
            }

            decimal vat = LoadVat();
            decimal original_price = Convert.ToDecimal(lbl_Subtotal.Text);
            decimal discount_rate = Convert.ToDecimal(lbl_Discount.Tag);
            decimal discount_amount = 0m;
            decimal points_discount_amount = 0m;
            decimal vat_amount = 0m;
            decimal final_price = 0m;
            decimal base_price = 0m;

            // Step 1: VAT handling
            if (discount_rate != 0)
            {
                decimal inclusive_price = original_price;
                base_price = inclusive_price / (1 + (vat / 100));
                vat_amount = inclusive_price - base_price;
                discount_amount = (original_price * discount_rate) / 100;
            }
            else
            {
                base_price = original_price;
                vat_amount = (base_price * vat) / 100;
            }

            lbl_Vat.Text = vat_amount.ToString("N2");
            _vatAmount = vat_amount;

            // Step 2: Loyalty points (use already redeemed value, don’t redeem again)
            points_discount_amount = Convert.ToDecimal(lbl_point_amount.Text);

            // Step 3: Final payable
            final_price = base_price - discount_amount - points_discount_amount;

            // Update UI
            _discountAmount = discount_amount;
            lbl_Discount.Text = discount_amount.ToString("N2");
            lbl_Total.Text = final_price.ToString("N2");
            AmountPaid();

        }



        //private void calculate()
        //{
        //    int pointsBalance = Convert.ToInt32(lbl_points.Text);
        //    decimal vat = LoadVat();
        //    decimal original_price = Convert.ToDecimal(lbl_Subtotal.Text);
        //    decimal discount_rate = Convert.ToDecimal(lbl_Discount.Tag);
        //    decimal discount_amount = 0m;
        //    decimal vat_amount = 0m;
        //    decimal final_price = 0m;
        //    decimal inclusive_price = original_price;
        //    decimal base_price = 0m;

        //    if (discount_rate != 0)
        //    {
        //        discount_amount = (original_price * discount_rate) / 100;



        //        // Step 1: Remove VAT
        //        base_price = inclusive_price / (1 + (LoadVat() / 100));

        //        // Step 2: Compute VAT amount
        //        vat_amount = inclusive_price - base_price;

        //        // Step 3: Compute final payable amount
        //        final_price = base_price - discount_amount;

        //        lbl_Vat.Text = vat_amount.ToString("N2");
        //        _vatAmount = vat_amount;
        //        lbl_Discount.Text = discount_amount.ToString("N2");
        //        lbl_Total.Text = final_price.ToString("N2");



        //    }
        //    else
        //    {
        //        // Step 1: Remove VAT
        //        base_price = inclusive_price / (1 + (LoadVat() / 100));

        //        // Step 2: Compute VAT amount
        //        vat_amount = inclusive_price - base_price;
        //        lbl_Vat.Text = vat_amount.ToString("N2");
        //        _vatAmount = vat_amount;
        //        lbl_Total.Text = original_price.ToString("N2");
        //    }





        //}

        private void txt_amount_paid_TextChanged(object sender, EventArgs e)
        {

            AmountPaid();
        }
        private void AmountPaid() 
        {
            decimal received_amount = Convert.ToDecimal(txt_amount_paid.Text == "" ? "0" : txt_amount_paid.Text);
            decimal total_amount = Convert.ToDecimal(lbl_Total.Text);
            decimal change_amount = 0m;

            if (txt_amount_paid.Text.Length > 0)
            {
                change_amount = received_amount - total_amount;

                lbl_change_amount.Text = change_amount.ToString("N2");
            }
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
            lbl_book_type.Text = model.CustomerType.ToString();
             

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
        private void UpdateCustomerLoyaltyPoints()
        {
        
            decimal total = ParseCurrency(lbl_Total.Text);
            int earnedPoints = (int)total / 100;
            var customerModel = new CustomerModel
            {
                customer_id = model.CustomerId ?? 0,
                customer_type = model.CustomerType,
                loyalty_points = earnedPoints
            };
            var repo = new CustomerRepository();
            var customerController = new CustomerController(repo);
            customerController.UpdateCustomerPoints(customerModel);
        }
        private void btn_confirm_payment_Click(object sender, EventArgs e)
        {
            DeductByBaseUnitsFIFO();
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


            var reference_no = string.IsNullOrWhiteSpace(txt_Reference.Text) ? "N/A" : txt_Reference.Text;

            var invoice = new InvoiceModel
            {
                InvoiceID = invoice_id,
                TotalAmount = totalAmount,
                VATAmount = _vatAmount,
                DiscountAmount = _discountAmount,
                PaymentMethod = cb_PaymentMethod.SelectedItem.ToString(),
                Timestamp = DateTime.Now
            };

            DiscountModel discount = null;
            int selectedDiscountId = -1;

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





            //Finalize payment
             var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);

            controller.UpdateInvoice(invoice);
            //AddTransactions(model.AppointmentId, _vatAmount, _discountAmount, _subtotal, totalAmount, cb_PaymentMethod.SelectedItem.ToString(), "Paid", DateTime.Now);
            //appointment.UpdateAppointmentPayment(model.AppointmentId, "Paid", "Completed");
            UpdateCustomerLoyaltyPoints();
            UpdateMemberPoints();



            Audit.AuditLog(
                DateTime.Now,
                "Process Payment",
                UserSession.CurrentUser.first_Name,
                "Appointment",
                $"Processed payment for client '{model.ClientName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
            );
            PrintInvoice();

            //await mainForm.RefreshInventoryAsync();
            //await mainForm.RefreshBatchInventory();
            //await mainForm.RefreshAppointmentAsync();
            //await mainForm.RefreshTotalSales();
            //await mainForm.RefreshTransactionAsync();

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
  

                    //inventoryController.UpdateInventoryByVolume(product.product_id, usedVolume);
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
     


            foreach (var item in summaryItem)
            {
             
                    string service =item.ItemName;
                    decimal price = item.Price;
                    int qty = item.Quantity;

                // Render each service with its price
                renderer.DrawLabelValue(service, qty.ToString(), price.ToString("C2"));
                
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
      
        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (discountAppliedAlready) return; 

            using (var discountForm = new DiscountModelForm())
            {
                if (discountForm.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected discount rate from the discount form
                    lbl_Discount.Text = $"DISCOUNT ({discountForm.discountName}%)";
                    lbl_Discount.Tag = discountForm.discountRate.ToString("N2");
                    calculate();
                    btn_discount.Enabled = discountAppliedAlready;
                }
            }
        }

        private void txt_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_redeem_points_Click(object sender, EventArgs e)
        {
            if (pointsRedeemedAlready) return;
            using (var redeemPoints = new RedeemPointsForm())
            {
                if (redeemPoints.ShowDialog() == DialogResult.OK)
                {
                    int pointsBalance = Convert.ToInt32(lbl_points.Text);
                    int pointsToRedeem = redeemPoints.points;

                    int redeemableBlocks = pointsToRedeem / 100;
                    if (redeemableBlocks > 0 && pointsBalance >= pointsToRedeem)
                    {
                        int pointsRedeemed = redeemableBlocks * 100;
                        decimal pesoValue = redeemableBlocks * 50;

                        pointsBalance -= pointsRedeemed;
                        lbl_points.Text = pointsBalance.ToString(); 
                        lbl_point_amount.Text = pesoValue.ToString("N2");
                        lbl_point_amount.Tag = pointsRedeemed.ToString();
                        btn_redeem_points.Enabled = pointsRedeemedAlready;
                    }
                    calculate();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cb_PaymentMethod.SelectedIndex = -1;
            cb_PaymentMethod.Hint = "";
            lbl_points.Tag = "0";
            lbl_points.Text = model.LoyaltyPoints.ToString();
            lbl_Discount.Tag = "0";
            lbl_discount_type.Text = "Discount";
            lbl_Discount.Text = "0.00";
            lbl_Subtotal.Text = _subtotal.ToString("N2");
            lbl_point_amount.Text = "0.00";
            cb_PaymentMethod.Hint = "Select Payment Method";
            txt_amount_paid.Text = string.Empty;
            txt_Reference.Text = string.Empty;
            lbl_change_amount.Text = "0.00";

            btn_redeem_points.Enabled = !pointsRedeemedAlready;
            btn_discount.Enabled = !discountAppliedAlready;
            calculate();
        }

        private void btn_add_on_Click(object sender, EventArgs e)
        {
            using (var form = new AddProductForm(this)) 
            {
                form.ShowDialog();
            }
        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_product.Columns[e.ColumnIndex].Name == "btn_remove") 
            {
                var product = dgv_product.Rows[e.RowIndex].DataBoundItem as ServiceCart;

                var repo = new InvoiceServiceRepository();
                var controller = new InvoiceServiceCartController(repo);

           

                var result = MessageBox.Show($"Are you sure you want to remove '{product.ItemName}'?",
                            "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) 
                {
                    controller.RemoveProduct(product.service_cart_id);
                    LoadServices(product.InvoiceId);
                }
            }
        }

        private void materialExpansionPanel1_Paint(object sender, PaintEventArgs e)
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

