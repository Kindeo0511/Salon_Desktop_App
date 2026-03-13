using iText.Layout.Element;
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
    public partial class ViewDetailsForm : MaterialForm
    {
        private MainForm mainForm;
        private AppointmentModel appointmentModel;
        private bool StartServiceClicked = false;
        private bool MarkAsCompletedClicked = false;
        public ViewDetailsForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        public ViewDetailsForm(MainForm main, AppointmentModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = main;
            this.appointmentModel = model;

            LoadSelectedAppointmentDetails(model);
            LoadServices(appointmentModel.AppointmentId);
        

        }
        public ViewDetailsForm(MainForm main, AppointmentModel model, bool IsViewDetails)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = main;
            this.appointmentModel = model;
        
            LoadSelectedAppointmentDetails(model);
            LoadServices(appointmentModel.AppointmentId);

            if (IsViewDetails)
            {
                dgv_service_selected.Columns["col_mark_as_completed"].Visible = false;
            }
            else 
            {
                dgv_service_selected.Columns["col_mark_as_completed"].Visible = true;
                dgv_service_selected.Columns["col_start_service"].Visible = false;
            }

        }

        public bool Stylist_Is_Available(int stylist_id)
        {
            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);

            return controller.GetStylistAvailability(
                Convert.ToInt32(stylist_id));

        }
        public bool Stylist_Is_Off_Duty()
        {
            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);

            return controller.IsStylistOfDuty(
                Convert.ToInt32(appointmentModel.StylistId));

        }
        public void LoadSelectedAppointmentDetails(AppointmentModel model) 
        {

            lbl_prefix.Text = model.DisplayCustomerName;

            rad_walk_in.Checked = model.AppointmentType == "Walk-In";
            rad_appointment.Checked = model.AppointmentType == "Appointment";

            rad_guest.Checked = model.CustomerType == "Walk-In";
            rad_exists.Checked = model.CustomerType == "Member";

            rad_appointment.Enabled = false;
            rad_walk_in.Enabled = false;
            rad_guest.Enabled = false;
            rad_exists.Enabled = false;





        }
     
        private void LoadWalkInCode()
        {
            var repo = new WalkInRepository();
            var controller = new Walk_In_Controller(repo);
            int walkInCode = controller.GetWalkInCode();

            string prefix_code = $"W-{walkInCode.ToString().PadLeft(4, '0')}";

            lbl_prefix.Text = prefix_code;
        }
        public void LoadServices(int id)
        {
            var repo = new AppointmentServiceRepository();
            var controller = new AppointmentServiceController(repo);
            var services = controller.ViewSelectedServices(id);


            dgv_service_selected.AutoGenerateColumns = false;
            col_aps_id.DataPropertyName = "AppointmentServiceId";
            col_stylist_id.DataPropertyName = "StylistId";
            col_service_id.DataPropertyName = "ServiceId";
            col_stylist.DataPropertyName = "StylistName";
            col_service_name.DataPropertyName = "ServiceName";
            col_service_time.DataPropertyName = "Duration";
            col_time.DataPropertyName = "DisplayTime";
            col_status.DataPropertyName = "Status";
            col_mark_as_completed.DataPropertyName = "IsCompleted";




            dgv_service_selected.DataSource = services;

        }
        private bool MarkAsCompleted(int appointmentServiceId) 
        {
            var repo = new AppointmentServiceRepository();
            var controller = new AppointmentServiceController(repo);
            return controller.MarkServiceAsCompleted(appointmentServiceId);
          
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            if (MarkAsCompletedClicked)
            {
                var controller = new AppointmentServiceRepository();
                var aps_controller = new AppointmentServiceRepository();
                foreach (DataGridViewRow row in dgv_service_selected.Rows)
                {
                    int appointmentServiceId = Convert.ToInt32(row.Cells["col_aps_id"].Value);
                    string serviceName = row.Cells["col_service_name"].Value.ToString();
                    bool isCompleted = Convert.ToBoolean(row.Cells["col_mark_as_completed"].Value);
                    int stylist_id = Convert.ToInt32(row.Cells["col_stylist_id"].Value);
                    if (isCompleted)
                    {
                        if (MarkAsCompleted(appointmentServiceId))
                        {

                            MessageBox.Show($"Service {serviceName} marked as completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            controller.UpdateStylistStatusOnDuty(null, null, null, null, "Available", stylist_id);
                        }


                    }
                }
                MarkOverallAppointmentStatus(appointmentModel.AppointmentId);
            }
            else if (StartServiceClicked) 
            {


                MarkOverallAppointmentStatusWhenStart(appointmentModel.AppointmentId);
            }


            mainForm.LoadWalkIn();
            this.Close();
        }
        public void MarkOverallAppointmentStatus(int appointment_id)
        {
            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);

            bool allCompleted = true; // assume completed until proven otherwise

            foreach (DataGridViewRow row in dgv_service_selected.Rows)
            {
                var status = row.Cells["col_status"].Value?.ToString();

                if (status != "Completed")
                {
                    allCompleted = false;
                    break; // no need to check further
                }
            }

            string newStatus = allCompleted ? "Completed" : "On Going";
            controller.UpdateAppointmentStatus(appointment_id, newStatus);
        }

        private void dgv_service_selected_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgv_service_selected.Columns[e.ColumnIndex].Name == "col_mark_as_completed")
            {
                var row = dgv_service_selected.Rows[e.RowIndex];
                bool completed = Convert.ToBoolean(row.Cells["col_mark_as_completed"].Value);

                row.Cells["col_status"].Value = completed ? "Completed" : "On Going";


            }

        }

        private void dgv_service_selected_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
       
            if (dgv_service_selected.IsCurrentCellDirty)
            {
                dgv_service_selected.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_service_selected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var dgv = dgv_service_selected;

            int stylist_id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["col_stylist_id"].Value);
            bool IsBusy = Stylist_Is_Available(stylist_id);
 
            bool stylistOffDuty = Stylist_Is_Off_Duty();

            if (e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "col_start_service")
            {
                string status = dgv.Rows[e.RowIndex].Cells["col_status"].Value.ToString();
                StartServiceClicked = true;
                if (status == "On Going")
                {
                    MessageBox.Show("Service is already on going. Please mark it as completed once done.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (status == "Completed")
                {
                    MessageBox.Show("Service is already completed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (IsBusy)
                {
                    MessageBox.Show("Stylist is currently busy with another service. Please wait until they are ready to start this service.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                else if (stylistOffDuty)
                {
                    MessageBox.Show("Stylist is currently off duty. Please wait until they are back to start this service.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    var controller = new AppointmentServiceRepository();
                    int appointmentServiceId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["col_aps_id"].Value);
                    int service_duration = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["col_service_time"].Value);

                    string service = dgv.Rows[e.RowIndex].Cells["col_service_name"].Value.ToString();
                    var start_time = DateTime.Now;
                    var endTimeDuration = DateTime.Now.AddMinutes(service_duration);

                    if (controller.StartWalkInService(appointmentServiceId, start_time, endTimeDuration))
                    {

                        controller.UpdateStylistStatusOnDuty(lbl_prefix.Text, service,  start_time, endTimeDuration, "Busy", stylist_id);
                        MessageBox.Show("Service Started Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadServices(appointmentModel.AppointmentId);
                      
                    }
                    else
                    {
                        MessageBox.Show("Failed to Start Service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "col_change_stylist")
            {
               
                int appointment_service_id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["col_aps_id"].Value);
                int service_id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["col_service_id"].Value);
                using (var form = new AssignStylistForm(mainForm, appointment_service_id, service_id))
                {
                    form.ShowDialog();
                }
            }

            else if (e.RowIndex >= 0 && dgv_service_selected.Columns[e.ColumnIndex].Name == "col_mark_as_completed")
            {
                var controller = new AppointmentServiceRepository();
                var status = dgv_service_selected.Rows[e.RowIndex].Cells["col_status"].Value.ToString();
             
                MarkAsCompletedClicked = true;
                if (status == "Waiting")
                {
              
                    MessageBox.Show("Service is still waiting to start. Please start the service first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                
           
            }
            else if (e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "col_remove")
            {

                var repo = new AppointmentServiceRepository();
                var controller = new AppointmentServiceController(repo);

                var inv_repo = new InvoiceServiceRepository();
                var inv_service_controller = new InvoiceServiceCartController(inv_repo);

                int appointmentServiceId = Convert.ToInt32(dgv_service_selected.Rows[e.RowIndex].Cells["col_aps_id"].Value);
                int serviceId = Convert.ToInt32(dgv_service_selected.Rows[e.RowIndex].Cells["col_service_id"].Value);
                string status = Convert.ToString(dgv_service_selected.Rows[e.RowIndex].Cells["col_status"].Value);
                string serviceName = Convert.ToString(dgv_service_selected.Rows[e.RowIndex].Cells["col_service_name"].Value);





                if (status == "Completed")
                {
                    MessageBox.Show("Cannot remove a completed service.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (status == "On Going")
                {
                    MessageBox.Show("Cannot remove a service that is currently on going.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show($"Are you sure to remove {serviceName}?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (confirmResult == DialogResult.Yes)
                {
                    if (appointmentServiceId == 0)
                    {
                        // Not saved yet, just remove from the grid
                        dgv_service_selected.Rows.RemoveAt(e.RowIndex);

                        MessageBox.Show($"{serviceName} removed successfully!",
                                        "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        int invoice_id = GetInvoiceId(appointmentModel.AppointmentId);
                        int invoice_service_id = inv_service_controller.GetInvoiceServiceById(invoice_id, serviceId);
                        controller.DeleteAppointmentServiceById(appointmentServiceId);
                        inv_service_controller.DeleteServiceFromInvoiceCart(invoice_service_id);
                       
                    }
                }

            }
        }
        public int GetInvoiceId(int id)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int invoice_id = controller.GetInvoice(id);

            return invoice_id;

        }
        private void dgv_service_selected_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_service_selected.Columns[e.ColumnIndex].Name == "col_mark_as_completed" && e.RowIndex >= 0)
            {
                var row = dgv_service_selected.Rows[e.RowIndex];
                var status = row.Cells["col_status"].Value?.ToString();

                if (status == "Completed")
                {
                    // Force checkbox to show checked
                    e.Value = true;
                    e.FormattingApplied = true;

                    // Make the checkbox cell read-only
                    row.Cells["col_mark_as_completed"].ReadOnly = true;
                }
                else if (status == "Waiting") 
                {
                    e.Value = false;
                    e.FormattingApplied = true;

                    // Make the checkbox cell read-only
                    row.Cells["col_mark_as_completed"].ReadOnly = true;
                }
                else
                {
                    // Allow editing if not completed
                    row.Cells["col_mark_as_completed"].ReadOnly = false;
                }
            }

            if (dgv_service_selected.Columns[e.ColumnIndex].Name == "col_status" && e.RowIndex >= 0)
            {
                var status = e.Value?.ToString();

                if (status == "On Going")
                {
                    e.CellStyle.BackColor = Color.LightYellow;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (status == "Completed")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }

            }

        }
        public void MarkOverallAppointmentStatusWhenStart(int appointment_id)
        {
            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);

            bool anyOnGoing = false;

            foreach (DataGridViewRow row in dgv_service_selected.Rows)
            {
                var status = row.Cells["col_status"].Value?.ToString();

                if (status == "On Going")
                {
                    anyOnGoing = true;
                    break; // no need to check further
                }
            }

            string newStatus = anyOnGoing ? "On Going" : "Waiting";

            controller.UpdateAppointmentStatus(appointment_id, newStatus);
        }
        private void ViewDetailsForm_Load(object sender, EventArgs e)
        {
            ThemeManager.StyleDataGridView(dgv_service_selected);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_service_selected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new AddNewServiceForm(this, appointmentModel.AppointmentId)) 
            {
                form.ShowDialog();
                LoadServices(appointmentModel.AppointmentId);
            }
        }
    }
}
