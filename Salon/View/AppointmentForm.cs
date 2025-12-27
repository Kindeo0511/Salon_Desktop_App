using iText.Kernel.Pdf.Canvas.Parser.ClipperLib;
using MaterialSkin.Controls;
using Org.BouncyCastle.Asn1.Cmp;
using Salon.Card;
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Services;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
namespace Salon.View
{
    public partial class AppointmentForm : MaterialForm
    {

        private MainForm mainForm;
        private AppointmentModel model;
        private List<ServiceModel> _services;
        private List<ProductModel> _products;
        public List<ServiceCart> selectedServices = new List<ServiceCart>();
        private DateTime selectedTime;
        private int totalDuration = 0;
        private bool isUpdate = false;
        public string CustomerId
        {
            get => lbl_ID.Text;
            set => lbl_ID.Text = value;
        }

        public string FullName
        {
            get => txt_FullName.Text;
            set => txt_FullName.Text = value;
        }

       
        public AppointmentForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
            cmb_Date.MinDate = DateTime.Today;
            cmb_Date.MaxDate = DateTime.Today.AddMonths(3);



     
            LoadStylist();
        }
        public AppointmentForm(MainForm mainForm, AppointmentModel model, bool isUpdate)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadServices(); // populate _services once
            LoadProduct();
            this.mainForm = mainForm;
            this.model = model;
            this.isUpdate = isUpdate;
            cmb_Date.MinDate = model.AppointmentDate.Date;
            cmb_Date.MaxDate = DateTime.Today.AddMonths(3);
            btn_search.Enabled = false;
            btn_register_customer.Enabled = false;
            rad_guest.Enabled = false;
            rad_exists.Enabled = false;
            //this.isUpdate = isUpdate;
            if (model.CustomerId == null)
            {
                rad_guest.Checked = true;
            }
            else
            {
                rad_exists.Checked = true;
            }
            //customerModel.customer_name = model.CustomerName;
            //customerModel.phoneNumber = model.PhoneNumber;
            //customerModel.email = model.Email;
            //customerModel.customer_id = model.CustomerId;
            txt_FullName.Text = model.DisplayCustomerName;
            lbl_ID.Text = model.CustomerId.ToString();
          
            btn_update.Visible = true;

            cmb_Date.Value = model.AppointmentDate;

            btn_confirm.Visible = false;

      


            int invoice_id = GetInvoiceId(model.AppointmentId);
 
            LoadCart(invoice_id);

            LoadStylist();


            cmb_stylist.SelectedValue = model.StylistId;
            LoadTimeSlots(model.StartTime != null ? model.AppointmentDate.Date + model.StartTime : (DateTime?)null);


            //invoice_id = GetInvoiceId(this.model.AppointmentId);

            //LoadCart(invoice_id);

            // Services

        


        }
        public void LoadServices()
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);

            _services = controller.getServices().ToList();
        }

        public void LoadProduct()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);

            _products = controller.GetRetailProduct().ToList();
        }


     

        public void Clear() 
        {
          
            cmb_stylist.Hint = string.Empty;
            lbl_ID.Text = string.Empty;
            txt_FullName.Text = string.Empty;

          
            cmb_stylist.SelectedIndex = -1;
         
            cmb_Date.Value = DateTime.Now;
            time_slot_panel.Controls.Clear();

          
            cmb_stylist.Hint = "Select Stylist";
             
        }
        private void LoadTimeSlots()
        {

            time_slot_panel.Controls.Clear();
            for (int hour = 9; hour <= 21; hour++)
            {
                MaterialButton button = new MaterialButton();
                DateTime time = new DateTime(1, 1, 1, hour, 0, 0);
                string formattedTime = time.ToString("hh:mm tt"); // 12-hour format with AM/PM
                button.AutoSize = true;
                button.Text = formattedTime;
                button.Click += (sender, e) =>
                {
                    // Reset all buttons back to default
                    foreach (Control ctrl in time_slot_panel.Controls)
                    {
                        if (ctrl is MaterialButton btn)
                        {
                            btn.UseAccentColor = false; // reset
                        }
                    }

                    // Highlight the selected one
                    var clickedButton = sender as MaterialButton;
                    if (clickedButton != null)
                    {
                        clickedButton.UseAccentColor = true;

                        // Store the actual DateTime value from THIS button
                        selectedTime = DateTime.Parse(clickedButton.Text);
                    }
                };

                time_slot_panel.Controls.Add(button);

            }

        }
        private void LoadTimeSlots(DateTime? previousSelectedTime = null)
        {
            time_slot_panel.Controls.Clear();

            for (int hour = 9; hour <= 21; hour++)
            {
                MaterialButton button = new MaterialButton();
                DateTime time = new DateTime(1, 1, 1, hour, 0, 0);
                string formattedTime = time.ToString("hh:mm tt"); // 12-hour format with AM/PM
                button.AutoSize = true;
                button.Text = formattedTime;

                // If this button matches the previously selected time, highlight it
                if (previousSelectedTime.HasValue &&
                    time.ToString("hh:mm tt") == previousSelectedTime.Value.ToString("hh:mm tt"))
                {
                    button.UseAccentColor = true;
                    selectedTime = previousSelectedTime.Value; // keep it in sync
                }

                button.Click += (sender, e) =>
                {
                    // Reset all buttons back to default
                    foreach (Control ctrl in time_slot_panel.Controls)
                    {
                        if (ctrl is MaterialButton btn)
                        {
                            btn.UseAccentColor = false; // reset
                        }
                    }

                    // Highlight the selected one
                    var clickedButton = sender as MaterialButton;
                    if (clickedButton != null)
                    {
                        clickedButton.UseAccentColor = true;

                        // Store the actual DateTime value from THIS button
                        selectedTime = DateTime.Parse(clickedButton.Text);
                    }
                };

                time_slot_panel.Controls.Add(button);
            }
        }

      
     
        private void LoadStylist()
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.GetAll();


            cmb_stylist.ValueMember = "stylist_id";
            cmb_stylist.DisplayMember = "FullName";

            cmb_stylist.DataSource = stylist;
            cmb_stylist.SelectedIndex = -1;
        }

       
        public int GetInvoiceId(int id)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int invoice_id = controller.GetInvoice(id);

            return invoice_id; 

        }
        private void LoadCart(int invoice_id)
        {
            var repo = new InvoiceServiceRepository();
            var controller = new InvoiceServiceCartController(repo);
            var services = controller.GetInvoiceServiceCartByInvoiceId(invoice_id);
      
            foreach (var item in services)
            {
                if (item.ItemType == "Service")
                {
                    var serviceCard = new ServiceCard();
                    serviceCard.SetServices(_services); // bind all services
                    serviceCard.LoadSelectedProduct(item);      // helper method inside ServiceCard
                    fl_service.Controls.Add(serviceCard);
 

                    selectedServices.Add(new ServiceCart
                    {
                        ServiceId = item.ServiceId,
                        ItemName = item.ItemName,
                        ItemType = item.ItemType,
                        Price = item.Price,
                        Duration = item.Duration,
  
                    });
                }
               
            }

        }
       
       

  
    



    

        private void LoadTimeSlots(DateTime selectedDate)
        {
            var repo = new BusinessHourRepository();
            var generator = new TimeSlotGenerator();
            var timeSlotController = new TimeSlotController();
            var day = selectedDate.DayOfWeek.ToString();
            var hours = repo.GetHoursForDay(day);
            var slots = generator.GenerateSlots(hours, selectedDate);


            var availableSlots = timeSlotController.GetTimeSlots(selectedDate);


        }

     
       


      
       
       

       
        
        
        private bool Product_Inventory()
        {
            var inventoryController = new InventoryController(new InventoryRepository());
            var batchController = new InventoryBatchController(new InventoryBatchRepository());
            var serviceProductController = new ServiceProductUsageController(new ServiceProductUsageRepository());
            var appointmentService = new AppointmentServiceController(new AppointmentServiceRepository());

            //int appointmentId = model.AppointmentId;
            //var serviceList = appointmentService.GetServicesByAppointmentId(appointmentId)?.ToList();

            //if (serviceList == null || !serviceList.Any()) return true; // No services, nothing to deduct

            var inventoryProductList = inventoryController.GetAllInventory().ToList();
            List<string> stockWarnings = new List<string>();
            HashSet<int> flaggedProductIds = new HashSet<int>(); // ✅ Track duplicates

            //foreach (DataGridViewRow row in dgv_table.Rows)
            //{
            //    int serviceId = Convert.ToInt32(row.Cells["col_service_id"].Value);
            //    var serviceProducts = serviceProductController.GetAllServiceProducts(serviceId)?.ToList();
            //    if (serviceProducts == null || !serviceProducts.Any()) continue;

            //    foreach (var product in serviceProducts)
            //    {
            //        int productId = product.product_id;

            //        // Skip if already flagged
            //        if (flaggedProductIds.Contains(productId)) continue;

            //        var inventoryItem = inventoryProductList
            //            .FirstOrDefault(inv => inv.product_id == productId);

            //        string productName = inventoryItem?.product_name ?? "Unknown Product";

            //        if (inventoryItem == null || inventoryItem.unit <= 0)
            //        {
            //            stockWarnings.Add($"❌ \"{productName}\" has no available units in stock.");
            //            flaggedProductIds.Add(productId);
            //            continue;
            //        }

            //        double unitVolume = (double)inventoryItem.volume / inventoryItem.unit;
            //        double totalVolume = unitVolume * inventoryItem.unit;
            //        double usedVolume = product.total_usage_amount;

            //        if (totalVolume < usedVolume)
            //        {
            //            stockWarnings.Add($"❌ Insufficient stock for \"{productName}\".\nRequired: {usedVolume:N2} ml\nAvailable: {totalVolume:N2} ml");
            //            flaggedProductIds.Add(productId);
            //        }
            //    }
            //}

            if (stockWarnings.Any())
            {
                string message = string.Join("\n\n", stockWarnings);
                MessageBox.Show(message, "Inventory Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;




        }


   

      

      
        
        
       
        private bool Validated(int totalDuration)
        {
            bool validated = true;

          
         

            // 2. Check if at least one service is selected
            if (totalDuration <= 0)
            {
                MessageBox.Show("Please select at least one service before checking availability.", "No Services Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        
            // 3. Required field validations
 
            //validated &= Validator.IsRequired(txt_Contact, errorProvider1, "Contact is required.");
            //validated &= Validator.IsRequired(txt_Email, errorProvider1, "Email is required.");
            
            //validated &= Validator.IsRequired(cb_Time, errorProvider1, "Time is required.");
            validated &= Validator.IsRequired(cmb_Date, errorProvider1, "Date is required.");

            // 4. Date validation
            DateTime selectedDate = cmb_Date.Value.Date;
            DateTime today = DateTime.Today;

            if (selectedDate < today)
            {
                errorProvider1.SetError(cmb_Date, "Appointment date must be today or later.");
                validated = false;
            }
            else if (selectedDate > today.AddMonths(3))
            {
                errorProvider1.SetError(cmb_Date, "Appointments can only be booked up to 3 months in advance.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(cmb_Date, "");
            }

            return validated;
        }

       

        private void AppointmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
       

        }

        

     
       

       

       

       

        

       

       

        


       

       

        private void materialButton2_Click(object sender, EventArgs e)
        {
            using (var registerCustomerForm = new CustomerForm(mainForm)) 
            {
                registerCustomerForm.ShowDialog();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            selectedServices.Clear();
            totalDuration = 0;
            foreach (ServiceCard card in fl_service.Controls.OfType<ServiceCard>())
            {
                int serviceId = (int)card.SelectedServiceID;
                string name = card.ItemName;
                decimal price = card.Price;
                int duration = card.Duration;
                int quantity = card.Quantity;


                ServiceCart cartItem = new ServiceCart
                {
                    ProductId = null,
                    ServiceId = serviceId,
                    ItemName = name,
                    ItemType = "Service",
                    Price = price,
                    Duration = duration,
                    Quantity = quantity
                };
                totalDuration += cartItem.Duration;
                selectedServices.Add(cartItem);
            }
           



            if (rad_guest.Checked)
            {
                model = new AppointmentModel
                {
                    AppointmentId = model.AppointmentId,
                    CustomerName = txt_FullName.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    StylistName = cmb_stylist.Text,
                    AppointmentDate = cmb_Date.Value,
                    StartTime = selectedTime.TimeOfDay,
                    EndTime = selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                    Status = "Scheduled",
                    CustomerType = "Guest",
                    PaymentStatus = "Unpaid",
                };
            }
            else
            {
                model = new AppointmentModel
                {
                    AppointmentId = model.AppointmentId,
                    CustomerId = Convert.ToInt32(lbl_ID.Text),
                    CustomerName = txt_FullName.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    StylistName = cmb_stylist.Text,
                    AppointmentDate = cmb_Date.Value,
                    StartTime = selectedTime.TimeOfDay,
                    EndTime = selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                    Status = "Scheduled",
                    CustomerType = "Member",
                    PaymentStatus = "Unpaid",
                };
            }


            using (var summaryForm = new ConfirmationBooking(this, mainForm, model, isUpdate))
            {
                summaryForm.ShowDialog();
            }
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadServices(); // populate _services once
            LoadProduct();
        }

        private void rad_guest_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_guest.Checked) 
            {
                LoadWalkInCode();
                cmb_Date.Enabled = false;
            }
        }
        private void LoadWalkInCode()
        {
            var repo = new WalkInRepository();
            var controller = new Walk_In_Controller(repo);
            int walkInCode = controller.GetWalkInCode();

            string prefix_code = $"W-{walkInCode.ToString().PadLeft(4, '0')}";

            txt_FullName.Text = prefix_code;
        }

        private void rad_exists_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_exists.Checked) 
            {
                rad_guest.Checked = false;
                cmb_Date.Enabled = true;
                txt_FullName.Clear();
            }
        }

        
    

       

        

        

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            selectedServices.Clear();
            totalDuration = 0;
            foreach (ServiceCard card in fl_service.Controls.OfType<ServiceCard>())
            {
                int serviceId = (int)card.SelectedServiceID;
                string name = card.ItemName;
                decimal price = card.Price;
                int duration = card.Duration;
                int quantity = card.Quantity;


                ServiceCart cartItem = new ServiceCart
                {
                    ProductId = null,
                    ServiceId = serviceId,
                    ItemName = name,
                    ItemType = "Service",
                    Price = price,
                    Duration = duration,
                    Quantity = quantity
                };
                totalDuration += cartItem.Duration;
                selectedServices.Add(cartItem);
            }
            //foreach (ProductCard card in fl_product.Controls.OfType<ProductCard>())
            //{
            //    int productId = (int)card.SelectedProductID;
            //    string name = card.ItemName;
            //    decimal price = card.Price;
            //    int duration = card.Duration;
            //    int quantity = card.Quantity;


            //    ServiceCart cartItem = new ServiceCart
            //    {
            //        ProductId = productId,
            //        ServiceId = null,
            //        ItemName = name,
            //        ItemType = "Product",
            //        Price = price,
            //        Duration = duration,
            //        Quantity = quantity
            //    };
     
            //    selectedServices.Add(cartItem);
            //}

            if (rad_guest.Checked)
            {
                model = new AppointmentModel
                {
                    CustomerName = txt_FullName.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    StylistName = cmb_stylist.Text,
                    AppointmentDate = cmb_Date.Value,
                    StartTime = selectedTime.TimeOfDay,
                    EndTime = selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                    Status = "Scheduled",
                    CustomerType = "Guest",
                    PaymentStatus = "Unpaid",
                };
            }
            else
            {
                model = new AppointmentModel
                {
                    CustomerId = Convert.ToInt32(lbl_ID.Text),
                    CustomerName = txt_FullName.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    StylistName = cmb_stylist.Text,
                    AppointmentDate = cmb_Date.Value,
                    StartTime = selectedTime.TimeOfDay,
                    EndTime = selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                    Status = "Scheduled",
                    CustomerType = "Member",
                    PaymentStatus = "Unpaid",
                };
            }
            using (var summaryForm = new ConfirmationBooking(model, mainForm, this))
            {
                summaryForm.ShowDialog();
            }
         

        }

        private void btn_add_service_Click(object sender, EventArgs e)
        {
            // SERVICE CARD 
            var serviceCard = new ServiceCard();

            // Optional: hook up remove button
            serviceCard.OnRemove += (s, ev) => fl_service.Controls.Remove(serviceCard);
            serviceCard.SetServices(_services);
            fl_service.Controls.Add(serviceCard);

        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
           
        }

      

        private void rad_guest_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rad_guest.Checked)
            {
                LoadWalkInCode();
                cmb_Date.Enabled = false;
            }
        }

        private void rad_exists_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (var searchCustomerForm = new SearchCustomerForm(this))
            {
                searchCustomerForm.ShowDialog();
            }
        }

        private void btn_register_customer_Click(object sender, EventArgs e)
        {
            using (var registerCustomer = new CustomerForm(mainForm))
            {
                registerCustomer.ShowDialog();
            }
        }

        private void cmb_stylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_stylist.Text.Length > 0)
            {
                LoadTimeSlots();
            }
            else
            {
                time_slot_panel.Controls.Clear();
            }
        }





        //public async Task<bool> IsSlotRangeAvailableAsync(DateTime date, TimeSpan startTime, TimeSpan duration)
        //{
        //    int slotsNeeded = (int)Math.Ceiling(duration.TotalHours);
        //    var repo = new AppointmentRepository();
        //    var controller = new AppointmentController(repo);
        //    for (int i = 0; i < slotsNeeded; i++)
        //    {
        //        var slotTime = startTime.Add(TimeSpan.FromHours(i));
        //        if (await controller.CheckIsSlotTaken(date, slotTime)) 
        //            return false;
        //    }

        //    return true;
        //}
    }
}
