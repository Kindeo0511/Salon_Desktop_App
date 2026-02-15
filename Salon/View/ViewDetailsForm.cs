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

        }
        public void LoadSelectedAppointmentDetails(AppointmentModel model) 
        {
            LoadWalkInCode();

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
        private void LoadServices(int id)
        {
            var repo = new AppointmentServiceRepository();
            var controller = new AppointmentServiceController(repo);
            var services = controller.ViewSelectedServices(id);


            dgv_service_selected.AutoGenerateColumns = false;
            col_service_id.DataPropertyName = "AppointmentServiceId";
            col_stylist.DataPropertyName = "StylistName";
            col_service_name.DataPropertyName = "ServiceName";
            col_service_time.DataPropertyName = "Duration";
            col_time.DataPropertyName = "DisplayTime";
            col_status.DataPropertyName = "Status";
       
           


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
           
             foreach (DataGridViewRow row in dgv_service_selected.Rows)
            {
                int appointmentServiceId = Convert.ToInt32(row.Cells["col_service_id"].Value);
                string serviceName = row.Cells["col_service_name"].Value.ToString();
                bool isCompleted = Convert.ToBoolean(row.Cells["col_mark_as_completed"].Value);
                if (isCompleted)
                {
                    if (MarkAsCompleted(appointmentServiceId)) 
                    {

                        MessageBox.Show($"Service {serviceName} marked as completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainForm.LoadWalkIn();
                        this.Close();
                    }
                    

                }
             }
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
            if (e.RowIndex >= 0 && dgv_service_selected.Columns[e.ColumnIndex].Name == "col_start_service") 
            {
                string status = dgv_service_selected.Rows[e.RowIndex].Cells["col_status"].Value.ToString();

                if (status == "On Going")
                {
                    return;
                }
                else 
                {
                    var controller = new AppointmentServiceRepository();
                    int appointmentServiceId = Convert.ToInt32(dgv_service_selected.Rows[e.RowIndex].Cells["col_service_id"].Value);
                    int service_duration = Convert.ToInt32(dgv_service_selected.Rows[e.RowIndex].Cells["col_service_time"].Value);

                    var start_time = DateTime.Now;
                    var endTimeDuration = DateTime.Now.AddMinutes(service_duration);

                    if (controller.StartWalkInService(appointmentServiceId, start_time, endTimeDuration))
                    {
                        MessageBox.Show("Service Started Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainForm.LoadWalkIn();
                        LoadServices(appointmentModel.AppointmentId);
                    }
                    else
                    {
                        MessageBox.Show("Failed to Start Service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
