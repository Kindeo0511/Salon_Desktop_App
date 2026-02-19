using iText.Kernel.Pdf.Canvas.Parser.ClipperLib;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Ink;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Salon.View
{
    public partial class Walk_In_Form : MaterialForm
    {
        private DateTime selectedTime;
        private int totalDuration = 0;
        private MainForm _mainForm;
        private AppointmentModel appointmentModel;
        private bool isWaiting = false;
        private bool isOnGoing = false;

        private string status
        {
            get
            {
                if (isOnGoing)
                {
                    return "On Going";
                }
                else if (isWaiting)
                {
                    return "Waiting";
                }
                else
                {
                    return "Scheduled";
                }
            }
        }
        public string CustomerId
        {
            get => lbl_ID.Text;
            set => lbl_ID.Text = value;
        }

        public string FullName
        {
            get => lbl_ID.Text;
            set => lbl_prefix.Text = value;
        }
        public Walk_In_Form(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;


            LoadSubcategory();

            LoadServices();

            

           
           


        }
        public Walk_In_Form(MainForm mainForm, AppointmentModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;
            appointmentModel = model;

            rad_guest.Checked = appointmentModel.AppointmentType == "Walk-In";
            rad_exists.Checked = appointmentModel.AppointmentType == "Member";

            LoadSubcategory();

            LoadServices();

            LoadWalkInCode();
           

            LoadSelectedData(appointmentModel);

            LoadSelectedServices(appointmentModel.AppointmentId);
        }
        private void LoadSelectedData(AppointmentModel model) 
        {
            cmb_stylist.MouseWheel += cmb_stylist_MouseWheel;

    
           
          

            btn_save.Visible = false;
            btn_update.Visible = true;
            btn_save_and_add_another.Visible = false;

        }

        public void LoadSelectedServices(int appointment_id) 
        {
            var service_repo = new AppointmentServiceRepository();
            var service_controller = new AppointmentServiceController(service_repo);
            var services = service_controller.GetServicesByAppointmentId(appointment_id);

            dgv_service_selected.Rows.Clear();
            foreach (var service in services) 
            {
                dgv_service_selected.Rows.Add(
                service.AppointmentServiceId,
                service.ServiceId,
                service.ServiceName,
                service.StylistId,
                service.StylistName,
                service.Duration + " mins",
                service.SellingPrice,
                service.StartTime,
                service.EndTime,
                service.Status  
                  );
            }

          

        }
        private void LoadWalkInCode() 
        {
            var repo = new WalkInRepository();
            var controller = new Walk_In_Controller(repo);
            int walkInCode = controller.GetWalkInCode();

            string prefix_code = $"W-{walkInCode.ToString().PadLeft(4, '0')}";

            lbl_prefix.Text = prefix_code;
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
        private void cmb_stylist_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void Clear() 
        {
            cmb_services.SelectedIndex = -1;
            txt_duration.Text = string.Empty;
            txt_price.Text = string.Empty;
            cmb_subcategory.SelectedIndex = -1;
            cmb_stylist.SelectedIndex = -1;
           
            LoadWalkInCode();
        }

        private void SaveWalkIn() 
        {

            var repo = new AppointmentRepository();
            var appointmentController = new AppointmentController(repo);

            var service_repo = new AppointmentServiceRepository();
            var service_controller = new AppointmentServiceController(service_repo);

          

            if (rad_guest.Checked)
            {

                appointmentModel = new AppointmentModel
                {
                    CustomerName = lbl_prefix.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    AppointmentDate = DateTime.Now,
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.Add(TimeSpan.FromMinutes(totalDuration)),
                    AppointmentType = "Walk-In",
                    CustomerType = "Guest",
                    PaymentStatus = "Unpaid",
                };
            }
            else
            {
                appointmentModel = new AppointmentModel
                {
                    CustomerName = lbl_prefix.Text,
                    StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    AppointmentDate = DateTime.Now,
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.Add(TimeSpan.FromMinutes(totalDuration)),
                    AppointmentType = "Walk-In",
                    CustomerType = "Member",
                    PaymentStatus = "Unpaid",
                    //CustomerId = Convert.ToInt32(lbl_ID.Text),
                    //CustomerName = lbl_prefix.Text,
                    ////StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                    //StylistName = cmb_stylist.Text,
                    //AppointmentDate = cmb_Date.Value,
                    //StartTime = cmb_Date.Value + selectedTime.TimeOfDay,
                    //EndDuration = cmb_Date.Value + selectedTime.TimeOfDay,
                    //EndTime = cmb_Date.Value + selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                    //Status = "Scheduled",
                    //CustomerType = "Member",
                    //PaymentStatus = "Unpaid",
                };
            }
            int appointment_id = appointmentModel.CustomerType == "Member"
            ? appointmentController.CreateAppointment(appointmentModel)
            : appointmentController.CreateWalkInAppointment(appointmentModel);

            var invoiceModel = new InvoiceModel
            {
                AppointmentID = appointment_id,
                InvoiceNumber = GenerateInvoiceNumber(),
                TotalAmount = 0,
                VATAmount = 0,
                DiscountAmount = 0,
                Timestamp = null,
                CustomerID =null,
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

                if (statusValue == "Ready to Start")
                {
                    rowStatus = "On Going";
                    var start_time = DateTime.Now;
                    var endTimeDuration = DateTime.Now.AddMinutes(duration);
                    service_controller.AddServicesToAppointment(appointment_id, service_id, stylist_id, start_time, endTimeDuration, rowStatus);
                    SaveInvoiceServices(invoiceServiceCart);
                }
                else if (statusValue == "Busy" || statusValue == "Waiting")
                {
                    rowStatus = "Waiting";
                    DateTime? start_time = null;
                    DateTime? end_time = DateTime.Now.AddMinutes(duration);
                    service_controller.AddServicesToAppointment(appointment_id, service_id, stylist_id, start_time, end_time, rowStatus);
                    SaveInvoiceServices(invoiceServiceCart);
                }

                MarkOverallAppointmentStatus(appointment_id);




            }

        }
        public void MarkOverallAppointmentStatus(int appointment_id)
        {
            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);

            bool anyOnGoing = false;

            foreach (DataGridViewRow row in dgv_service_selected.Rows)
            {
                var status = row.Cells["col_status"].Value?.ToString();

                if (status == "On Going" || status == "Ready to Start")
                {
                    anyOnGoing = true;
                    break; // no need to check further
                }
            }

            string newStatus = anyOnGoing ? "On Going" : "Waiting";

            controller.UpdateAppointmentStatus(appointment_id, newStatus);
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
        public int GetInvoiceId(int id)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int invoice_id = controller.GetInvoice(id);

            return invoice_id;

        }
        private void UpdateWalkIn()
        {
            var service_repo = new AppointmentServiceRepository();
            var service_controller = new AppointmentServiceController(service_repo);



            var service_invoice_repo = new InvoiceServiceRepository();
            var service_invoice_controller = new InvoiceServiceCartController(service_invoice_repo);
            int invoice_id = GetInvoiceId(appointmentModel.AppointmentId);


            service_controller.DeleteAppointmentService(appointmentModel.AppointmentId);
            foreach (DataGridViewRow row in dgv_service_selected.Rows)
            {
                if (row.IsNewRow) continue;

                int? stylist_id = null;
                int service_id = Convert.ToInt32(row.Cells["col_service_id"].Value);
                if (row.Cells["col_stylist_id"].Value != null &&
                    int.TryParse(row.Cells["col_stylist_id"].Value.ToString(), out int parsed))
                {
                    stylist_id = parsed;
                }

                int duration = 0;
                var rawValue = row.Cells["col_duration"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(rawValue))
                {
                    string digitsOnly = new string(rawValue.Where(char.IsDigit).ToArray());
                    if (int.TryParse(digitsOnly, out int parse))
                    {
                        duration = parse;
                    }
                }
                
                decimal price = Convert.ToDecimal(row.Cells["col_price"].Value.ToString());
                var statusValue = Convert.ToString(row.Cells["col_status"].Value);

                DateTime? start_time = null;
                DateTime? end_time = null;
                string rowStatus = statusValue; // preserve whatever status is in the grid

                if (statusValue == "Ready to Start" || statusValue == "On Going")
                {
                    rowStatus = "On Going";
                    start_time = DateTime.Now;
                    end_time = DateTime.Now.AddMinutes(duration);
                }
                else if (statusValue == "Busy")
                {
                    rowStatus = "Waiting";
                    end_time = DateTime.Now.AddMinutes(duration);
                }
                bool service_exists = service_invoice_controller.CheckIfServiceExistInCart(invoice_id,service_id);
                if (!service_exists)
                {
             
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

                    SaveInvoiceServices(invoiceServiceCart);

                }
                bool serviceExistInAppointment = service_controller.CheckIfServiceExists(appointmentModel.AppointmentId, service_id);
                if (!serviceExistInAppointment) 
                {
                    service_controller.AddServicesToAppointment(
                       appointmentModel.AppointmentId,
                       service_id,
                       stylist_id,
                       start_time,
                       end_time,
                       rowStatus
                   );
                }

               
                MarkOverallAppointmentStatus(appointmentModel.AppointmentId);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveWalkIn();
            MessageBox.Show("Walk-In appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.LoadWalkIn();
            this.Close();

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

        private void cmb_subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appointmentModel == null)
            {

                LoadServices(Convert.ToInt32(cmb_subcategory.SelectedValue));
            }
        }

        private void btn_save_and_add_another_Click(object sender, EventArgs e)
        {
            SaveWalkIn();
            MessageBox.Show("Walk-In appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.LoadWalkIn();
            Clear();
        }

        public class NoScrollComboBox : ComboBox
        {
            protected override void OnMouseWheel(MouseEventArgs e)
            {
                // Do nothing: disables scroll wheel changing selection
            }
        }
     
        private void cmb_stylist_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }



        public void CheckIngredients() 
        {
            
        }
        private void btn_add_service_Click_1(object sender, EventArgs e)
        {
            string stylistAvailability = Stylist_Is_Available()
            ? "Ready to Start"
            : "Busy";


            if (string.IsNullOrEmpty(cmb_services.Text)) 
            {
                MessageBox.Show("Please select a service.",
                                "Service Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (string.IsNullOrEmpty(cmb_stylist.Text)) 
            {
                MessageBox.Show("Please select a stylist.",
                                "Stylist Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected service ID
            var selectedServiceId = cmb_services.SelectedValue;

            // Check if the service is already in the grid
            bool alreadyAdded = false;
            foreach (DataGridViewRow row in dgv_service_selected.Rows)
            {
                if (row.Cells["col_service_id"].Value?.ToString() == selectedServiceId.ToString())
                {
                    alreadyAdded = true;
                    break;
                }
            }
            if (!rad_exists.Checked && !rad_guest.Checked) 
            {
                MessageBox.Show("Please select a client type.",
                                "Customer Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rad_exists.Checked) 
            {
                if (string.IsNullOrEmpty(lbl_prefix.Text))
                {
                    MessageBox.Show("Please select a member.",
                                    "Member Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (alreadyAdded)
            {
                MessageBox.Show("This service has already been added.",
                                "Duplicate Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dgv_service_selected.Rows.Add(
                    0,
                    cmb_services.SelectedValue,
                    cmb_services.Text,
                    cmb_stylist.SelectedValue,
                    cmb_stylist.Text,
                    txt_duration.Text,
                    txt_price.Text,
                    null,
                    null,
                    stylistAvailability
                );
            }
           


        }
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
        private string GenerateInvoiceNumber()
        {
            string prefix = "INV";
            string datePart = DateTime.Now.ToString("yyyyMMdd-HHmm");
            return $"{prefix}-{datePart}";
        }
        private void rad_guest_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_guest.Checked)
            {
                LoadWalkInCode();

            }
        }

        private void rad_exists_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_exists.Checked)
            {
                btn_search.Enabled = true;
            }
            else 
            {
                btn_search.Enabled = false;
            }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            UpdateWalkIn();
            MessageBox.Show("Walk-In appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.LoadWalkIn();
            this.Close();
        }

        private void dgv_service_selected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_service_selected.Columns[e.ColumnIndex].Name == "btn_remove")
            {
                int appointmentServiceId = Convert.ToInt32(dgv_service_selected.Rows[e.RowIndex].Cells["col_appointment_service_id"].Value);
                int serviceId = Convert.ToInt32(dgv_service_selected.Rows[e.RowIndex].Cells["col_service_id"].Value);
                string serviceName = dgv_service_selected.Rows[e.RowIndex].Cells["col_service_name"].Value.ToString();


                var confirmResult = MessageBox.Show($"Are you sure to remove {serviceName}?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    if (appointmentServiceId == 0)
                    {
                        // Not saved yet, just remove from the grid
                        dgv_service_selected.Rows.RemoveAt(e.RowIndex); // ✅ use RemoveAt for index

                        MessageBox.Show($"{serviceName} removed successfully!",
                                        "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Saved in DB, delete through repository
                        var repo = new AppointmentServiceRepository();
                        var controller = new AppointmentServiceController(repo);


                        var inv_repo = new InvoiceServiceRepository();
                        var inv_service_controller = new InvoiceServiceCartController(inv_repo);

                        int invoice_id = GetInvoiceId(appointmentModel.AppointmentId);

                        int invoice_service_id = inv_service_controller.GetInvoiceServiceById(invoice_id, serviceId);
                        
                        inv_service_controller.DeleteServiceFromInvoiceCart(invoice_service_id);
                        controller.DeleteAppointmentServiceById(appointmentServiceId);

                        MessageBox.Show($"{serviceName} removed successfully!",
                                        "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadSelectedServices(appointmentModel.AppointmentId);
                        _mainForm.LoadWalkIn();
                    }

                  
                }
            }
            else if (e.RowIndex >= 0  && dgv_service_selected.Columns[e.ColumnIndex].Name == "btn_mark_as_waiting") 
            {
                string status = Convert.ToString(dgv_service_selected.Rows[e.RowIndex].Cells["col_status"].Value);
                if (status == "Waiting")
                {
                    MessageBox.Show("This service is already marked as Waiting.",
                                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (status == "Busy") 
                {
                    MessageBox.Show("This service is currently Busy and cannot be marked as Waiting.",
                                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var row = dgv_service_selected.Rows[e.RowIndex];
                    row.Cells["col_status"].Value = "Waiting";


                }





            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchCustomerForm(this, true))
            {
                searchForm.ShowDialog();
            }

        }

        private void btn_register_customer_Click(object sender, EventArgs e)
        {
            using (var registerCustomer = new CustomerForm(_mainForm))
            {
                registerCustomer.ShowDialog();
            }
        }

        private void cmb_services_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_services.SelectedItem is ServiceModel selectedService)
            {

                LoadStylist(selectedService.serviceName_id);

            }
        }

        private void dgv_service_selected_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_service_selected_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
          
        }

        private void dgv_service_selected_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void Walk_In_Form_Load(object sender, EventArgs e)
        {
            ThemeManager.StyleDataGridView(dgv_service_selected);
        }
    }
}
