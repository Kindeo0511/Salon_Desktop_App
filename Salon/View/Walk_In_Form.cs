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
        private WalkInModel _model;
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
        public Walk_In_Form(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;


            LoadSubcategory();

            LoadServices();

            LoadStylist();

           
           


        }
        public Walk_In_Form(MainForm mainForm, WalkInModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;
            _model = model;


            LoadSubcategory();

            LoadServices();

            LoadStylist();


            LoadWalkInCode();
           

            LoadSelectedData(_model);
        }
        private void LoadSelectedData(WalkInModel model) 
        {
            cmb_stylist.MouseWheel += cmb_stylist_MouseWheel;

            lbl_prefix.Text = model.name;
            cmb_services.SelectedValue = model.serviceName_id;
            cmb_subcategory.SelectedValue = model.subCategoryId > 0 ? model.subCategoryId : 0;
            cmb_stylist.SelectedValue = model.stylist_id;
          

            btn_save.Visible = false;
            btn_update.Visible = true;
            btn_save_and_add_another.Visible = false;

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
        private void LoadStylist()
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.GetAll();

            var availble_stylist = stylist.Where(s=> s.Availability == "Available").ToList();
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
                    CustomerType = "Guest",
                    PaymentStatus = "Unpaid",
                };
            }
            else
            {
                //appointmentModel = new AppointmentModel
                //{
                //    CustomerId = Convert.ToInt32(lbl_ID.Text),
                //    CustomerName = txt_FullName.Text,
                //    //StylistId = Convert.ToInt32(cmb_stylist.SelectedValue),
                //    StylistName = cmb_stylist.Text,
                //    AppointmentDate = cmb_Date.Value,
                //    StartTime = cmb_Date.Value + selectedTime.TimeOfDay,
                //    EndDuration = cmb_Date.Value + selectedTime.TimeOfDay,
                //    EndTime = cmb_Date.Value + selectedTime.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                //    Status = "Scheduled",
                //    CustomerType = "Member",
                //    PaymentStatus = "Unpaid",
                //};
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
                else if (statusValue == "Busy")
                {
                    rowStatus = "Waiting";
                    DateTime? start_time = null;
                    DateTime? end_time = DateTime.Now.AddMinutes(duration);
                    service_controller.AddServicesToAppointment(appointment_id, service_id, stylist_id, start_time, end_time, rowStatus);
                    SaveInvoiceServices(invoiceServiceCart);
                }






            }

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
        private void UpdateWalkIn() 
        {
            var repo = new WalkInRepository();
            var controller = new Walk_In_Controller(repo);


            var model = new WalkInModel()
            {
                id = _model.id,
                name = lbl_prefix.Text,
                stylist_id = Convert.ToInt32(cmb_stylist.SelectedValue),
                serviceName_id = Convert.ToInt32(cmb_services.SelectedValue),
                date = DateTime.Now,
                start_time = DateTime.Now.TimeOfDay,
                end_time = DateTime.Now.TimeOfDay.Add(TimeSpan.FromMinutes(totalDuration)),
                status = "Scheduled",
                payment_status = "Unpaid",
            };
            controller.UpdateWalkIn(model);
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
            if (_model == null)
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateWalkIn();
            MessageBox.Show("Walk-In appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.LoadWalkIn();
            this.Close();

        }

    

        private void btn_add_service_Click_1(object sender, EventArgs e)
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

        }
    }
}
