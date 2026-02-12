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
        private AppointmentModel appointmentModel;
        private AppointmentModel model;
        private List<ServiceModel> _services = new List<ServiceModel>();
        private List<ProductModel> _products;
        //public List<ServiceCart> selectedServices = new List<ServiceCart>();
        public BindingList<ServiceCart> selectedServices = new BindingList<ServiceCart>();
        public List<int> service_id_look_up = new List<int>();
        private DateTime selectedTime;
        private int totalDuration = 0;
        private int service_duration = 0;
        private int service_qty = 0;
        private bool isUpdate = false;
        private int ss_id = 0;
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


            LoadSubcategory();
            LoadServices();

            LoadTimeSlots();
        }
        private void LoadSubcategory()
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);
            var services = controller.getSubCategory();


            cmb_subcategory.ValueMember = "subCategory_id";
            cmb_subcategory.DisplayMember = "subCategoryName";

            cmb_subcategory.DataSource = services;
            cmb_subcategory.SelectedIndex = -1;

        }
        private void LoadServices()
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var services = controller.getServices();

            cmb_services.DataSource = null;

            cmb_services.ValueMember = "serviceName_id";
            cmb_services.DisplayMember = "serviceName";


            cmb_services.DataSource = services;

            cmb_services.SelectedIndex = -1;
            txt_duration.Text = string.Empty;
            txt_price.Text = string.Empty;


        }
        private void LoadServices(int id)
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var services = controller.getServicesById(id);

            cmb_services.DataSource = null;
            cmb_services.ValueMember = "serviceName_id";
            cmb_services.DisplayMember = "serviceName";

            cmb_services.DataSource = services;

        }
        private void LoadStylist(int id)
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.GetStylistSpecialistById(id);

            cmb_stylist.DataSource = null;
            cmb_stylist.ValueMember = "stylist_id";
            cmb_stylist.DisplayMember = "FullName";

            cmb_stylist.DataSource = stylist;
            cmb_stylist.SelectedIndex = -1;
        }
        public void LoadStylistForRow(int index) 
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.GetAll();

            DataGridViewComboBoxCell stylist_cell = (DataGridViewComboBoxCell)dgv_available_services.Rows[index].Cells["col_cmb_stylist"];

            stylist_cell.DataSource = stylist;
            stylist_cell.DisplayMember = "FullName";
            stylist_cell.ValueMember = "stylist_id";
            stylist_cell.Value = null;

        }
        public AppointmentForm(MainForm mainForm, AppointmentModel model, bool isUpdate)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadSubcategory();
            LoadServices();
    
            //LoadProduct();
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

            //LoadStylist();


            cmb_stylist.SelectedValue = model.StylistId;
          


            //invoice_id = GetInvoiceId(this.model.AppointmentId);

            //LoadCart(invoice_id);

            // Services




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
          
          
            cmb_stylist.Hint = "Select Stylist";
             
        }
        private void LoadTimeSlots()
        {
            var repo = new BusinessHourRepository();
            var controller = new TimeSlotController(repo);
            var businessHours = controller.GetBusinessHours();

            var openTime = businessHours.open_time;   // TimeSpan
            var closeTime = businessHours.close_time; // TimeSpan

            var appointmentRepo = new AppointmentRepository();
            var appointmentController = new AppointmentController(appointmentRepo);
            var todaysAppointments = appointmentController.GetTodayAppointment();

            cmb_time_slot.Items.Clear();

            for (DateTime time = DateTime.Today.Add(openTime);
                 time < DateTime.Today.Add(closeTime);
                 time = time.AddMinutes(30))
            {
                if (time < DateTime.Now)
                    continue;

                bool taken = todaysAppointments.Any(appt =>
                    (time < appt.EndTime && time.AddMinutes(30) > appt.StartTime));

                if (taken)
                    continue;

                // Show only the start time in 12-hour format
                cmb_time_slot.Items.Add($"{time:hh:mm tt}");
            }

            cmb_time_slot.SelectedIndex = -1;
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

                  

                   
                    selectedServices.Add(item);

                    dgv_available_services.AutoGenerateColumns = false;
                    dgv_available_services.DataSource = null;
                    col_service_id.DataPropertyName = "ServiceId";
                    col_service_name.DataPropertyName = "ItemName";
                    col_service_category_2.DataPropertyName = "SubCategory";
                    col_price_2.DataPropertyName = "Price";
                    col_qty_2.DataPropertyName = "Quantity";
                    col_duration.DataPropertyName = "Duration";
                    dgv_available_services.DataSource = selectedServices;

                }

            }

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

            totalDuration = 0;

            foreach (var service in selectedServices)
            {

                totalDuration += service.Duration * service.Quantity;

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
                    StartTime = cmb_Date.Value + selectedTime.TimeOfDay,
                    EndTime = cmb_Date.Value +  selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
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
                    StartTime = cmb_Date.Value + selectedTime.TimeOfDay,
                    EndTime = cmb_Date.Value + selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
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
            ThemeManager.StyleDataGridView(dgv_available_services);
           
            dgv_available_services.CellValueChanged += dgv_available_services_CellValueChanged;
            dgv_available_services.CurrentCellDirtyStateChanged += dgv_available_services_CurrentCellDirtyStateChanged;
            LoadServicesForAutocomplete();
            LoadServices();


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

            string prefix_code = $"A-{walkInCode.ToString().PadLeft(4, '0')}";

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





        private string GenerateInvoiceNumber()
        {
            string prefix = "INV";
            string datePart = DateTime.Now.ToString("yyyyMMdd-HHmm");
            return $"{prefix}-{datePart}";
        }


        private void SaveAppointment()
        {
            var repo = new AppointmentRepository();
            var appointmentController = new AppointmentController(repo);

            var service_repo = new AppointmentServiceRepository();
            var service_controller = new AppointmentServiceController(service_repo);

            //selectedServices.Clear();
  
            //foreach (selectedServices card in fl_service.Controls.OfType<ServiceCard>())
            //{
            //    int serviceId = (int)card.SelectedServiceID;
            //    string name = card.ItemName;
            //    decimal price = card.Price;
            //    int duration = card.Duration;
            //    int quantity = card.Quantity;


            //    ServiceCart cartItem = new ServiceCart
            //    {
            //        ProductId = null,
            //        ServiceId = serviceId,
            //        ItemName = name,
            //        ItemType = "Service",
            //        Price = price,
            //        Duration = duration,
            //        Quantity = quantity
            //    };
            //    totalDuration += cartItem.Duration;
            //    selectedServices.Add(cartItem);
            //}
            int totalDuration = 0;

            foreach (DataGridViewRow row in dgv_service_selected.Rows)
            {
                int duration = 0;

                var rawValue = row.Cells["col_duration"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(rawValue))
                {
                    // If the cell contains "45 mins", strip non-numeric characters
                    string digitsOnly = new string(rawValue.Where(char.IsDigit).ToArray());

                    if (int.TryParse(digitsOnly, out int parsed))
                    {
                        duration = parsed;
                    }
                }

                totalDuration += duration;
            }


            var startTime = DateTime.Parse(cmb_time_slot.SelectedItem.ToString());

            if (rad_guest.Checked)
            {
                model = new AppointmentModel
                {
                    CustomerName = txt_FullName.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    StylistName = cmb_stylist.Text,
                    AppointmentDate = cmb_Date.Value,
                    StartTime = startTime,
                    EndTime = startTime.Add(TimeSpan.FromMinutes(totalDuration)),
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
                    StartTime = cmb_Date.Value + selectedTime.TimeOfDay,
                    EndDuration = cmb_Date.Value + selectedTime.TimeOfDay,
                    EndTime = cmb_Date.Value + selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                    Status = "Scheduled",
                    CustomerType = "Member",
                    PaymentStatus = "Unpaid",
                };
            }
            int appointment_id = model.CustomerType == "Member"
              ? appointmentController.CreateAppointment(model)
              : appointmentController.CreateWalkInAppointment(model);

            var invoiceModel = new InvoiceModel
            {
                AppointmentID = appointment_id,
                InvoiceNumber = GenerateInvoiceNumber(),
                TotalAmount = 0,
                VATAmount = 0,
                DiscountAmount = 0,
                Timestamp = null,
                CustomerID = null,
            };

            int invoice_id = SaveInvoice(invoiceModel);

            foreach (DataGridViewRow row in dgv_service_selected.Rows)
            {
                if (row.IsNewRow) continue;
                int? stylist_id = null;
                int service_id = Convert.ToInt32(row.Cells["col_service_id"].Value);
                if (row.Cells["col_stylist_id"].Value != null && int.TryParse(row.Cells["col_stylist_id"].Value.ToString(), out int parsed)) { stylist_id = parsed; }
                int duration = 0;
                var rawValue = row.Cells["col_duration"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(rawValue))
                {
                    // If the cell contains "45 mins", strip non-numeric characters
                    string digitsOnly = new string(rawValue.Where(char.IsDigit).ToArray());

                    if (int.TryParse(digitsOnly, out int parse))
                    {
                        duration = parse;
                    }
                }

                decimal price = Convert.ToDecimal(row.Cells["col_price"].Value.ToString());


                var invoiceServiceCart = new ServiceCart
                {
                    InvoiceId = invoice_id,
                    ServiceId = service_id,
                    StylistId = stylist_id,
                    ItemType = "Service",
                    Quantity = 1,
                    Price = price,
                    Duration = duration
                };

                var statusValue = Convert.ToString(row.Cells["col_status"].Value);
                string rowStatus = "Scheduled"; // default

                rowStatus = "Waiting";
                var start_time = DateTime.Now;
                var endTimeDuration = DateTime.Now.AddMinutes(duration);
                service_controller.AddServicesToAppointment(appointment_id, service_id, stylist_id, start_time, endTimeDuration, rowStatus);
                SaveInvoiceServices(invoiceServiceCart);


            }

            //using (var summaryForm = new ConfirmationBooking(model, mainForm, this))
            //{
            //    summaryForm.ShowDialog();
            //}

            mainForm.LoadWalkIn();
            mainForm.LoadAppointments();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            SaveAppointment();
            MessageBox.Show("Appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            this.Close();

       

        }
       



                private int SaveInvoice(InvoiceModel model)
        {
            var repo = new InvoiceRepository();
            var invoiceController = new InvoiceController(repo);
            var invoice_id = invoiceController.AddInvoice(model);

            return invoice_id;
        }
        private void SaveInvoiceServices(ServiceCart cart)
        {
            var repo = new InvoiceServiceRepository();
            var serviceController = new InvoiceServiceCartController(repo);
            serviceController.AddServiceToInvoiceCart(cart);

        }


        private void rad_guest_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rad_guest.Checked)
            {
                LoadWalkInCode();
            
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

    

      
        private void LoadServicesForAutocomplete()
        {
      
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var service = controller.getServices().ToList(); // or however you fetch all




            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
  
            source.AddRange(service.Select(s => s.serviceName).ToArray());

          
        

        }
        private void InsertServicesToCart(string name)
        {
            var repo = new ServiceRepository();
            var controller = new ServiceController(repo);
            var service = controller.GetServiceByName(name);


            if (service == null) { MessageBox.Show("Service not found."); return; }


            var existing = selectedServices.FirstOrDefault(p => p.ServiceId == service.serviceName_id);
            if (existing != null)
            {
                MessageBox.Show("This service is already in the cart.");
                return;
            }


            var model = new ServiceCart
            {
                ServiceId = service.serviceName_id,
                ItemName = service.serviceName,
                SubCategory = service.subCategoryName,
                ItemType = "Service",
                Price = service.servicePrice,
                Duration = service.duration
            };
            service_duration += model.Duration;
            selectedServices.Add(model);
            dgv_available_services.AutoGenerateColumns = false;
            dgv_available_services.DataSource = null;
            col_service_id.DataPropertyName = "ServiceId";
            col_service_name.DataPropertyName = "ItemName";
            col_service_category_2.DataPropertyName = "subCategoryName";
            col_price_2.DataPropertyName = "Price";
            col_qty_2.DataPropertyName = "Quantity";
            col_duration.DataPropertyName = "Duration";

            dgv_available_services.DataSource = selectedServices;
        }

      

      

        private void dgv_available_services_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;

            if (dgv_available_services.Columns[e.ColumnIndex].Name == "col_cmb_stylist")
            {
            //    if (dgv_available_services.Rows[e.RowIndex]
            //.Cells["col_service_id"].Value == null)
            //        return;

            //    int serviceId = Convert.ToInt32(
            //        dgv_available_services.Rows[e.RowIndex]
            //        .Cells["col_service_id"].Value
            //    );
                LoadStylistForRow(e.RowIndex);
            }

            if (e.RowIndex >= 0 && dgv_available_services.Columns[e.ColumnIndex].Name == "col_remove") 
            {
               selectedServices.RemoveAt(e.RowIndex);
            }

        }

        private void dgv_available_services_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_available_services_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_available_services.IsCurrentCellDirty) 
            {
                dgv_available_services.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_available_services_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            if (dgv_available_services.Columns[e.ColumnIndex].Name == "col_cmb_stylist")
            {
                int stylistId = Convert.ToInt32(dgv_available_services.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                string stylistName = dgv_available_services.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

                selectedServices[e.RowIndex].StylistId = stylistId;
 

                // Update available time slots for this stylist
              
            }

            if (dgv_available_services.Columns[e.ColumnIndex].Name == "col_qty") 
            {
                var row = dgv_available_services.Rows[e.RowIndex];
                int quantity = Convert.ToInt32(row.Cells["col_qty"].Value);

                service_qty = quantity;

                if (cmb_stylist.Text.Length > 0)
                {
                    //LoadTimeSlots(Convert.ToInt32(cmb_stylist.SelectedValue));
                }
                else
                {
                   
                }
            }
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AppointmentForm_Shown(object sender, EventArgs e)
        {
            materialCard1.AutoScrollPosition = new Point(0, 0);
        }

        private void dgv_available_services_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        //private void cmb_services_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if (model == null)
        //    {

        //        LoadServices(Convert.ToInt32(cmb_subcategory.SelectedValue));
        //    }
        //}
        public bool Stylist_Is_Available()
        {
            var repo = new AppointmentServiceRepository();
            var controller = new AppointmentServiceController(repo);

            return controller.IsStylistAvailable(
                Convert.ToInt32(cmb_stylist.SelectedValue),
                DateTime.Now,
                totalDuration
                );

        }
        private void btn_add_service_Click(object sender, EventArgs e)
        {
            string stylistAvailability = Stylist_Is_Available()
          ? "Ready to Start"
          : "Busy";


            dgv_service_selected.Rows.Add(
            cmb_services.SelectedValue,
            cmb_services.Text,
            cmb_stylist.SelectedValue,
            cmb_stylist.Text,
            txt_duration.Text,
            txt_price.Text,
            stylistAvailability
            );

        }

        private void cmb_services_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_services.SelectedItem is ServiceModel selectedService)
            {

                totalDuration = selectedService.duration;
                txt_duration.Text = selectedService.duration.ToString() + " mins";
                txt_price.Text = selectedService.servicePrice.ToString();
               

            }
        }

        private void cmb_services_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_services.SelectedItem is ServiceModel selectedService)
            {
              
                LoadStylist(selectedService.serviceName_id);

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
