using iText.Kernel.Pdf.Canvas.Parser.ClipperLib;
using MaterialSkin.Controls;
using Org.BouncyCastle.Asn1.Cmp;
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
        private CustomerModel customerModel;
        private List<ServiceItemSelected> serviceSelected;
        public List<ServiceCart> selectedServices = new List<ServiceCart>();
        public List<InvoiceServicesCart> cart = new List<InvoiceServicesCart>();
        public BindingList<ServiceCart> cartItem = new BindingList<ServiceCart>();

        private int duration_temp = 0;
        private int totalDuration = 0;
        private DateTime selectedTime;
        private bool isUpdate = false;
        private int AppointmentId;
        public int invoice_id;
        public int update_invoice_id;
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

        public string Email
        {
            get => txt_Email.Text;
            set => txt_Email.Text = value;
        }

        public string Contact
        {
            get => txt_Contact.Text;
            set => txt_Contact.Text = value;
        }
        public AppointmentForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_appointment_product);
            ThemeManager.StyleDataGridView(dgv_cart);
            ThemeManager.StyleDataGridView(dgv_services);
            this.mainForm = mainForm;
            cmb_Date.MinDate = DateTime.Today;
            cmb_Date.MaxDate = DateTime.Today.AddMonths(3);



            LoadServices();
            LoadProducts();
            LoadStylist();
        }
        public AppointmentForm(MainForm mainForm, AppointmentModel model, bool isUpdate)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_appointment_product);
            ThemeManager.StyleDataGridView(dgv_cart);
            ThemeManager.StyleDataGridView(dgv_services);
            this.mainForm = mainForm;
            this.model = model;
            AppointmentId = model.AppointmentId;
            cmb_Date.MinDate = model.AppointmentDate.Date;
            cmb_Date.MaxDate = DateTime.Today.AddMonths(3);
            btn_search.Enabled = false;
            btn_register_customer.Enabled = false;
            rad_guest.Enabled = false;
            rad_exists.Enabled = false;
            this.isUpdate = isUpdate;
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
            txt_Contact.Text = model.PhoneNumber;
            txt_Email.Text = model.Email;
            btn_update.Visible = true;

            cmb_Date.Value = model.AppointmentDate;

            btn_confirm.Visible = false;

            //reloadSelectedServices(model.AppointmentId);



            LoadServices();
            LoadProducts();
            LoadStylist();


            cmb_stylist.SelectedValue = model.StylistId;
            LoadTimeSlots(model.StartTime != null ? model.AppointmentDate.Date + model.StartTime : (DateTime?)null);

            //foreach (DataGridViewRow row in dgv_table.Rows)
            //{
            //    if (row.Cells["col_duration"].Value != null)
            //    {
            //        int durationn = Convert.ToInt32(row.Cells["col_duration"].Value);
            //        totalDuration += durationn;
            //    }
            //}
            invoice_id = GetInvoiceId(this.model.AppointmentId);

            LoadCart(invoice_id);

        }
        public void Clear() 
        {
          
            cmb_stylist.Hint = string.Empty;
            lbl_ID.Text = string.Empty;
            txt_FullName.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Contact.Text = string.Empty;
          
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

      
        private void LoadServices()
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var services = controller.getServices();

           
            dgv_services.AutoGenerateColumns = false;

            col_service_id.DataPropertyName = "serviceName_id";
            col_service.DataPropertyName = "serviceName";
            col_category.DataPropertyName = "subCategoryName";
            col_price.DataPropertyName = "servicePrice";
            col_duration.DataPropertyName = "duration";
     
            dgv_services.DataSource = services;


        }
        private void LoadProducts()
        {
            var repo = new ProductRepository();
            var controller = new ProductController(repo);
            var products = controller.GetRetailProduct();


            dgv_appointment_product.AutoGenerateColumns = false;

            col_app_product_id.DataPropertyName = "product_id";
            col_app_product_name.DataPropertyName = "product_name";
            col_app_product_brand.DataPropertyName = "brand";
            col_app_product_unit_type.DataPropertyName = "unit_type";
            col_app_product_price.DataPropertyName = "price";

            dgv_appointment_product.DataSource = products;


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

        //private void LoadServices() 
        //{
        //    var repo = new ServiceRepository();
        //    var controller = new ServiceController(repo);
        //    var services = controller.getServices();


        //    foreach (var service in services)
        //    {
        //        MaterialButton button = new MaterialButton();
        //        button.Text = $"{service.serviceName} ₱{service.servicePrice:N2}";
        //        button.Tag = service.serviceName_id;
        //        button.Width = 150;
        //        button.Height = 40;
        //        button.AutoSize = false;

        //        button.Click += (sender, e) =>
        //        {
        //            OnAddToCart(this, new ServicePriceModel
        //            {
        //                serviceName_id = service.serviceName_id,
        //                serviceName = service.serviceName,
        //                duration = service.duration,
        //                selling_price = service.servicePrice
        //            });
        //        };


        //        services_panel.Controls.Add(button);

        //    }
        //}
     
        public int GetInvoiceId(int id)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int invoice_id = controller.GetInvoice(id);

            return invoice_id; 

        }
        private void LoadCart(int id)
        {
            var repo = new InvoiceServiceRepository();
            var controller = new InvoiceServiceCartController(repo);

            // If the controller returns a BindingList<ServiceCart>
            cartItem = controller.GetInvoiceServiceCartByInvoiceId(id);



           

        }

       

  
       
        private void reloadSelectedServices(int id)
        {
            var repo = new AppointmentServiceRepository();
            var controller = new AppointmentServiceController(repo);
            var services = controller.GetSelectedServices(id);

            //foreach (var service in services) 
            //{
            //    dgv_table.Rows.Add(service.ServiceId, service.ServiceName, service.SubCategoryname, service.Duration);
            //}
        }




        private bool CustomerFieldMissing()
        {
            if (string.IsNullOrWhiteSpace(txt_FullName.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_Contact.Text)
              )
            {

                return true;
            }

            return false;
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

        private void cb_Time_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txt_search_services_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnAddToCart(object sender, ServicePriceModel service)
        {
            //txt_search_services.Text = string.Empty;
            //// Optional: check for duplicates or validate
            //if (!IsAlreadyInCart(service.serviceName))
            //{
            //    dgv_table.Rows.Add(service.serviceName_id, service.serviceName,service.selling_price, service.duration);
            //}


        }

        private bool IsAlreadyInCart(string item_name)
        {
            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                if (row.Cells["col_item"].Value?.ToString() == item_name)
                    return true;
            }
            return false;
        }
        private void UpdateAppointment()
        {
            var repo = new ServiceRepository();
            var serviceController = new ServiceController(repo);
            int total_duration = 0;
            decimal total_price = 0;

            serviceSelected = new List<ServiceItemSelected>();



            //foreach (DataGridViewRow row in dgv_table.Rows)
            //{

            //    int service_id = Convert.ToInt32(row.Cells["col_service_id"].Value);
            //    string name = row.Cells["col_service_name"].Value.ToString();
            //    string category = row.Cells["col_category_name"].Value.ToString();
            //    int duration = Convert.ToInt32(row.Cells["col_duration"].Value);


            //    total_duration += duration;
            //    var service = new ServiceItemSelected
            //    {
            //        service_id = service_id,
            //        service_name = name,
            //        category_name = category,
            //        total_duration = duration,
            //        price = total_price

            //    };



            //    serviceSelected.Add(service);
            //}

            if (serviceSelected.Count == 0)
            {
                MessageBox.Show("Please select at least one service before confirming.", "No Services Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CustomerFieldMissing())
            {
                MessageBox.Show("Please complete all required fields before confirming.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UpdateAppointment(total_duration);
            }
        }
        private BookingSummary BuildBookingSummary(int total_duration)
        {
            var customer = new CustomerModel
            {
                customer_id = Convert.ToInt32(lbl_ID.Text),
                customer_name = txt_FullName.Text,
                email = txt_Email.Text,
                phoneNumber = txt_Contact.Text,
        

            };

            var appointmentDate = cmb_Date.Value.Date;
            //var appointmentTime = DateTime.Parse(cb_Time.SelectedItem.ToString()).TimeOfDay;
            //var appointmentEndTime = appointmentTime.Add(TimeSpan.FromMinutes(total_duration));


            return new BookingSummary
            {
                CustomerModel = customer,
                SelectedServices = serviceSelected,
                AppointmentDate = appointmentDate,
                //AppointmentTime = appointmentTime,
                //AppointmentEndTime = appointmentEndTime,
                
            };
        }

        private void UpdateAppointment(int total_duration)
        {
            
            //var customer = new CustomerModel
            //{
            //    customer_id = Convert.ToInt32(lbl_ID.Text),
            //    customer_name = txt_FullName.Text,
            //    email = txt_Email.Text,
            //    phoneNumber = txt_Contact.Text
            //};


            //var appointmentDate = cmb_Date.Value.Date;
            //var appointmentTime = DateTime.Parse(cb_Time.SelectedItem.ToString()).TimeOfDay;
            //var appointmentEndTime = appointmentTime.Add(TimeSpan.FromMinutes(total_duration));
            //var book_type = cb_book_type.Text;

            //var summary = new BookingSummary
            //{
            //    CustomerModel = customer,
            //    SelectedServices = serviceSelected,
            //    AppointmentDate = appointmentDate,
            //    AppointmentTime = appointmentTime,
            //    AppointmentEndTime = appointmentEndTime,
            //    BookingType = book_type
            //};

            //var appointment = new Models.AppointmentModel
            //{
            //    AppointmentId = model.AppointmentId,
            //    CustomerId = model.CustomerId,
            //    AppointmentDate = appointmentDate,
            //    StartTime = appointmentTime,
            //    EndTime = appointmentEndTime,
            //    Status = model.Status,
            //    PaymentStatus = model.PaymentStatus,
            //    BookingType = book_type

            //};

            //var repo = new AppointmentRepository();
            //var appointmentController = new AppointmentController(repo);
            //int appointmentId = appointmentController.UpdatingTheAppointment(appointment);

            //var service_repo = new AppointmentServiceRepository();
            //var service_controller = new AppointmentServiceController(service_repo);

            //service_controller.ClearDeleteAllServicesForAppointment(appointmentId);

            //foreach (var service in serviceSelected)
            //{

            //var appointmentService = new AppointmentServicesModel
            //{

            //    AppointmentId = appointmentId,
            //    ServiceId = service.service_id

            //};
            //var appointmentServiceRepo = new Repository.AppointmentServiceRepository();
            // appointmentServiceRepo.AddAppointmentService(appointmentService);

            //}
            //MessageBox.Show("The appointment has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //mainForm.LoadAppointments();
            //mainForm.LoadTotalAppointments();
            //mainForm.LoadPopularServices();


            //this.Close();



        }
        private void SaveAppointment()
        {
            var repo = new ServiceRepository();
            var serviceController = new ServiceController(repo);
            int total_duration = 0;
            decimal total_price = 0;

            serviceSelected = new List<ServiceItemSelected>();



            //foreach (DataGridViewRow row in dgv_table.Rows)
            //{

            //    int service_id = Convert.ToInt32(row.Cells["col_service_id"].Value);
            //    string name = row.Cells["col_service_name"].Value.ToString();
            //    string category = row.Cells["col_category_name"].Value.ToString();
            //    int duration = Convert.ToInt32(row.Cells["col_duration"].Value);

            //    duration_temp += duration;
            //    total_duration += duration;
            //    var service = new ServiceItemSelected
            //    {
            //        service_id = service_id,
            //        service_name = name,
            //        category_name = category,
            //        total_duration = duration,

            //    };



            //    serviceSelected.Add(service);
            //}

            if (serviceSelected.Count == 0)
            {
                MessageBox.Show("Please select at least one service before confirming.", "No Services Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //else if (CustomerFieldMissing())
            //{
            //    MessageBox.Show("Please complete all required fields before confirming.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            else
            {
                SaveAppointment(total_duration);
            }

        }
        private void SaveAppointment(int total_duration)
        {
           


            //var customer = new CustomerModel
            //{
            //    customer_id = Convert.ToInt32(lbl_ID.Text),
            //    customer_name = txt_FullName.Text,
            //    email = txt_Email.Text,
            //    phoneNumber = txt_Contact.Text
            //};

            //var appointmentDate = cmb_Date.Value.Date;
            //var appointmentTime = DateTime.Parse(cb_Time.SelectedItem.ToString()).TimeOfDay;
            //var appointmentEndTime = appointmentTime.Add(TimeSpan.FromMinutes(total_duration));
            //var book_type = cb_book_type.Text;

            //var summary = new BookingSummary
            //{
            //    CustomerModel = customer,
            //    SelectedServices = serviceSelected,
            //    AppointmentDate = appointmentDate,
            //    AppointmentTime = appointmentTime,
            //    AppointmentEndTime = appointmentEndTime,
            //    BookingType = book_type
            //};



            //var confirmationForm = new ConfirmationBooking(this, mainForm, summary);
            //confirmationForm.ShowDialog();
            //serviceSelected.Clear();


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


   

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //var appointmentEndTime = appointmentTime.Add(TimeSpan.FromMinutes(total_duration));

            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                // Ensure the row is not a new row placeholder
                if (row.IsNewRow) continue;




                ServiceCart cartItem = new ServiceCart
                {
                    ProductId = Convert.ToInt32(row.Cells["col_item_product_id"].Value),
                    ServiceId = Convert.ToInt32(row.Cells["col_item_service_id"].Value),
                    ItemName = row.Cells["col_item"].Value.ToString(),
                    Price = Convert.ToDecimal(row.Cells["col_item_price"].Value),
                    Duration = Convert.ToInt32(row.Cells["col_item_duration"].Value),
                    Quantity = Convert.ToInt32(row.Cells["col_item_qty"].Value)
                };
                totalDuration += cartItem.Duration;
                selectedServices.Add(cartItem);

            }
            //// Just sum durations from selectedServices
            //foreach (var service in selectedServices)
            //{
            //    totalDuration += service.Duration;
            //}



            //// Example: show all selected services
            //foreach (var service in selectedServices)
            //{
            //    MessageBox.Show($"Selected: {service.ServiceName} - {service.Price} ({service.Duration} mins)");
            //}
            //bool inventoryOk = Product_Inventory();
            //if (!inventoryOk)
            //{
            //    return;
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
                    BookingType = "Walk-In",
                    PaymentStatus = "Unpaid",
                };
            }
            else
            {
                model = new AppointmentModel
                {
                    CustomerId = Convert.ToInt32(lbl_ID.Text),
                    CustomerName = txt_FullName.Text,
                    Email = txt_Email.Text,
                    PhoneNumber = txt_Contact.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    StylistName = cmb_stylist.Text,
                    AppointmentDate = cmb_Date.Value,
                    StartTime = selectedTime.TimeOfDay,
                    EndTime = selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                    Status = "Scheduled",
                    BookingType = "Appointment",
                    PaymentStatus = "Unpaid",
                };
            }


            using (var summaryForm = new ConfirmationBooking(model, mainForm, this)) 
            {
                summaryForm.ShowDialog();
            }
            //if (model != null)
            //{

            //    UpdateAppointment();
            //}
            //else
            //{
            //    SaveAppointment();
            //}

        }

        private void dgv_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (dgv_table.CurrentRow == null || dgv_table.CurrentRow.Index < 0)
        //        return;

        //    if (e.RowIndex >= 0 && dgv_table.Columns[e.ColumnIndex].Name == "col_btn_delete")
        //    {
        //        var confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
        //        if (confirm == DialogResult.Yes)
        //        {
        //            if (model != null)
        //            {
        //                var service_repo = new AppointmentServiceRepository();
        //                var service_controller = new AppointmentServiceController(service_repo);
        //                service_controller.ClearDeleteAllServicesForAppointment(model.AppointmentId);
        //                dgv_table.Rows.RemoveAt(dgv_table.CurrentRow.Index);

        //                btn_confirm.Enabled = false;
        //            }
        //            else 
        //            {
        //                dgv_table.Rows.RemoveAt(dgv_table.CurrentRow.Index);
        //                btn_confirm.Enabled = false;
        //            }

        //            // Remove from the grid

        //        }
        }

            
        
        public void CommitAppointment(BookingSummary summary, bool isUpdate)
        {
            //var appointment = new AppointmentModel
            //{
            //    AppointmentId = isUpdate ? model.AppointmentId : 0,
            //    CustomerId = summary.CustomerModel.customer_id,
            //    AppointmentDate = summary.AppointmentDate,
            //    StartTime = summary.AppointmentTime,
            //    EndTime = summary.AppointmentEndTime,
            //    Status = "Scheduled",
            //    PaymentStatus = "Unpaid",
            //    BookingType = summary.BookingType
            //};

            //var repo = new AppointmentRepository();
            //var appointmentController = new AppointmentController(repo);

            //int appointmentId = isUpdate
            //    ? appointmentController.UpdatingTheAppointment(appointment)
            //    : appointmentController.CreateAppointment(appointment); 

            //var serviceRepo = new AppointmentServiceRepository();
            //var serviceController = new AppointmentServiceController(serviceRepo);

            //if (isUpdate)
            //    serviceController.ClearDeleteAllServicesForAppointment(appointmentId);

            //foreach (var service in summary.SelectedServices)
            //{
            //    var appointmentService = new AppointmentServicesModel
            //    {
            //        AppointmentId = appointmentId,
            //        ServiceId = service.service_id
            //    };
            //    serviceRepo.AddAppointmentService(appointmentService);
            //}

            //MessageBox.Show("The appointment has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //mainForm.LoadAppointments();
            //mainForm.LoadTotalAppointments();
            //mainForm.LoadPopularServices();
            //this.Close();
        }
        private async void btn_update_Click(object sender, EventArgs e)
        {
            {
                //if (!Validated(totalDuration)) return;

                //var repo = new AppointmentRepository();
                //var controller = new AppointmentController(repo);
                //var date = cmb_Date.Value.Date;
                ////var startTime = DateTime.Parse(cb_Time.SelectedItem.ToString()).TimeOfDay;
                //var duration = TimeSpan.FromMinutes(totalDuration);
                //int id = Convert.ToInt32(lbl_ID.Text.ToString());

                //bool isCustomerAlreadyBooked = await controller.CustomerIsAlreadyBooked(date, startTime, duration, id);

                //string message;
                //MessageBoxIcon icon;

                //if (isCustomerAlreadyBooked)
                //{
                //    message = "❗This time slot is already booked.";
                //    icon = MessageBoxIcon.Warning;
                   

                //    MessageBox.Show(message, "Slot Status", MessageBoxButtons.OK, icon);
                //    return; // ⛔ Exit early to prevent proceeding
                //}

                //message = "✅ Slot is available for this customer.";
                //icon = MessageBoxIcon.Information;
              

                //MessageBox.Show(message, "Slot Status", MessageBoxButtons.OK, icon);

                //UpdateAppointment(); // ✅ Only called if slot is available

            }
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

        private async void btn_check_available_Click(object sender, EventArgs e)
        {
           


            //foreach (DataGridViewRow row in dgv_table.Rows)
            //{
            //    if (row.Cells["col_duration"].Value != null)
            //    {
            //        int durationn = Convert.ToInt32(row.Cells["col_duration"].Value);
            //        totalDuration += durationn;
            //    }
            //}
   
            if (!Validated(totalDuration)) return;
           

            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);
            var date = cmb_Date.Value.Date;
            //var startTime = DateTime.Parse(cb_Time.SelectedItem.ToString()).TimeOfDay;
            var duration = TimeSpan.FromMinutes(totalDuration);
            //int  id = Convert.ToInt32(lbl_ID.Text.ToString());

            //bool isCustomerAlreadyBooked = await controller.CustomerIsAlreadyBooked(date, startTime, duration, id);
            //bool isAvailable = await controller.CheckSlotRangeAvailable(date, startTime, duration);

            string message;
            MessageBoxIcon icon;

            //if (isCustomerAlreadyBooked)
            //{
            //    message = "❗ Customer is already booked for this slot.";
            //    icon = MessageBoxIcon.Warning;
            //    btn_confirm.Enabled = false;
            //}
            ////else if (!isAvailable)
            ////{
            ////    message = "❌ Slot is taken by another customer.";
            ////    icon = MessageBoxIcon.Warning;
            ////    btn_confirm.Enabled = false;
            ////}
            //else
            //{
            //    message = "✅ Slot is available.";
            //    icon = MessageBoxIcon.Information;
            //    btn_confirm.Enabled = true;
            //}

            //if (isCustomerAlreadyBooked)
            //{
            //    message = "❗This time slot is already booked.";
            //    icon = MessageBoxIcon.Warning;
            //    btn_confirm.Enabled = false;
            //}
            //else
            //{
            //message = "✅ Slot is available for this customer.";
            //icon = MessageBoxIcon.Information;
            btn_confirm.Enabled = true;
            //}



            //MessageBox.Show(message, "Slot Status", MessageBoxButtons.OK, icon);


        }

        private void AppointmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (model != null) 
            //{
            //    if (dgv_table.Rows.Count == 0)
            //    {
            //        MessageBox.Show(
            //            "You must select at least one service before closing.",
            //            "Missing Services",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Warning
            //        );

            //        e.Cancel = true; // Prevent form from closing
            //    }
            //}
       

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_check_stylist_avail_Click(object sender, EventArgs e)
        {
            //var appointmentRepo = new AppointmentRepository();
            //var appointmentController = new AppointmentController(appointmentRepo);

            //// Get the appointment you're checking (e.g., selected from a grid or form)
            //var appointments = appointmentController.GetAllShowAppointments("");
            //var appointment = appointments.FirstOrDefault(); // Replace with actual selected appointment

            //if (appointment == null)
            //{
            //    MessageBox.Show("No appointment selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Load stylists who are marked unavailable on this date
       
          


            //// Load stylists who are scheduled to work on this day
      
       


            //// Load stylists already assigned to appointments during this time
            //var stylistRepo = new StylistRepository();
            //var stylistController = new StylistController(stylistRepo);
            //var assignedStylists = stylistController.GetAssignedStylist(
            //    appointment.AppointmentDate,
            //    appointment.StartTime,
            //    appointment.EndTime
            //);

         

         
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.SelectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow letters, digits, space, hyphen, apostrophe, ampersand, parentheses, dot, at-sign
            if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '-' || c == '\'' || c == '&' || c == '(' || c == ')' || c == '.' || c == '@')
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_search_services_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.SelectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow letters, space, ampersand, hyphen, apostrophe, parentheses
            if (char.IsLetter(c) || char.IsWhiteSpace(c) || c == '&' || c == '-' || c == '\'' || c == '(' || c == ')')
                return;

            // Block everything else
            e.Handled = true;
        }

        private void cb_book_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_customer_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ID_Click(object sender, EventArgs e)
        {

        }

        private void cmb_services_SelectedIndexChanged(object sender, EventArgs e)
        {
         
                //if (cmb_services.SelectedItem is ServiceModel selectedService)
                //{

                //    totalDuration = selectedService.duration;
                   
                //}
            

           

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

        private void tabPage_date_n_time_Click(object sender, EventArgs e)
        {

        }

        private void time_slot_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void booking_tab_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (var searchCustomerForm = new SearchCustomerForm(this))
            {
                searchCustomerForm.ShowDialog();
            }
        }

       

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
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
            foreach (DataGridViewRow row in dgv_cart.Rows)
            {
                // Ensure the row is not a new row placeholder
                if (row.IsNewRow) continue;

                foreach (var service in cartItem) // iterate the bound list, not dgv_cart.Rows
                {
                    totalDuration += service.Duration;
                }


               

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
                    BookingType = "Walk-In",
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
                    Email = txt_Email.Text,
                    PhoneNumber = txt_Contact.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    StylistName = cmb_stylist.Text,
                    AppointmentDate = cmb_Date.Value,
                    StartTime = selectedTime.TimeOfDay,
                    EndTime = selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                    Status = "Scheduled",
                    BookingType = "Appointment",
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
            dgv_cart.AutoGenerateColumns = false;
         


            col_item_invoice_id.DataPropertyName = "InvoiceId";
            col_item_product_id.DataPropertyName = "ProductID";
            col_item_service_id.DataPropertyName = "ServiceID";
            col_item.DataPropertyName = "ItemName";
            col_item_type.DataPropertyName = "ItemType";
            col_item_price.DataPropertyName = "Price";
            col_item_duration.DataPropertyName = "Duration";
            col_item_qty.DataPropertyName = "Quantity";

            dgv_cart.DataSource = cartItem;
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

        private void dgv_services_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0) return;

            if (dgv_services.Columns[e.ColumnIndex].Name == "col_btn_add_to_cart")
            {
                DataGridViewRow row = dgv_services.Rows[e.RowIndex];

                ServiceCart items = new ServiceCart
                {
                    ServiceId = Convert.ToInt32(row.Cells["col_service_id"].Value),
                    ItemName = row.Cells["col_service"].Value.ToString(),
                    Price = Convert.ToDecimal(row.Cells["col_price"].Value),
                    Duration = Convert.ToInt32(row.Cells["col_duration"].Value),
                    Quantity = 1
                };

                cartItem.Add(items); // ✅ adds to BindingList, grid updates automatically
            }




        }
    

        private void dgv_cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

           
           
                if (dgv_cart.Columns[e.ColumnIndex].Name == "col_btn_remove")
                {
                    var item = dgv_cart.Rows[e.RowIndex].DataBoundItem as ServiceCart;
                    if (cartItem != null)
                    {
                        cartItem.Remove(item); // ✅ removes from BindingList, grid updates automatically
                    }
                }
            
           




        }

        private void dgv_appointment_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgv_appointment_product.Columns[e.ColumnIndex].Name == "col_app_btn_product_add")
            {
                DataGridViewRow row = dgv_appointment_product.Rows[e.RowIndex];


                ServiceCart items = new ServiceCart
                {
                    ProductId = Convert.ToInt32(row.Cells["col_app_product_id"].Value),
                    ItemName = row.Cells["col_app_product_name"].Value.ToString(),
                    ItemType = "Product",
                    Price = Convert.ToDecimal(row.Cells["col_app_product_price"].Value),
                    Duration = 0,
                    Quantity = 1
                };

                cartItem.Add(items); // ✅ adds to BindingList, grid updates automatically
            }
        }

        private void dgv_cart_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = dgv_cart.Rows[e.RowIndex];
            var itemType = row.Cells["col_item_type"].Value?.ToString();

            // Only allow editing Quantity if it's a Product
            if (dgv_cart.Columns[e.ColumnIndex].Name == "col_item_qty")
            {
                if (itemType != "Product")
                {
                    e.Cancel = true; // block editing
                }
            }
            else
            {
                e.Cancel = true; // block editing for all other columns
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
