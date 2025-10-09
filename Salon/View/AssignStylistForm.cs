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
using MaterialSkin.Controls;
using Salon.Repository;
using Salon.Controller;
using Salon.Models;
namespace Salon.View
{
    public partial class AssignStylistForm : MaterialForm
    {
        private MainForm mainForm;
        AppointmentModel appointment;
        public AssignStylistForm(MainForm mainForm, AppointmentModel appointment)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
            this.appointment = appointment;
            StylistExceptionSchedules();

       
        }

        private void StylistExceptionSchedules()
        {
            var repo = new ExceptionSchedulesRepository();
            var controller = new ExceptionSchedulesController(repo);
            var hasException = controller.GetCheckExceptionSchedule(appointment.AppointmentDate);

            if (hasException)
            {
                // Exception exists — block stylist assignment
                cmb_stylist.DataSource = null;
                cmb_stylist.Items.Clear();
                cmb_stylist.Items.Add("Stylist assignment blocked due to exception");
                cmb_stylist.SelectedIndex = 0;
                cmb_stylist.Enabled = false;
                btn_assign.Enabled = false;
                return;
            }

            // No exception — check stylist schedule
            var sh_repo = new StylistSchedulesRepository();
            var sh_controller = new StylistSchedulesController(sh_repo);
            var sh_sched = sh_controller.CheckStylistSchedule(appointment.AppointmentDate);

            var stylist_repo = new StylistRepository();
            var stylist_controller = new StylistController(stylist_repo);
            var assignedStylists =stylist_controller.GetAssignedStylist(appointment.AppointmentDate, appointment.StartTime, appointment.EndTime);
            var freeStylists = sh_sched
                .Where(s => !assignedStylists.Contains(s.stylist_id))
                .ToList();


            if (freeStylists != null && freeStylists.Count > 0)
            {
                LoadStylist(freeStylists);
            }
            else
            {
                cmb_stylist.DataSource = null;
                cmb_stylist.Items.Clear();
                cmb_stylist.Items.Add("No Available Stylist");
                cmb_stylist.SelectedIndex = 0;
                cmb_stylist.Enabled = false;
                btn_assign.Enabled = false;
            }

        }
        private void LoadStylist(List<StylistModel> stylists)
    {
        cmb_stylist.DisplayMember = "fullName";
        cmb_stylist.ValueMember = "stylist_id";
        cmb_stylist.DataSource = stylists;
        cmb_stylist.SelectedIndex = -1;
        cmb_stylist.Enabled = true;
        btn_assign.Enabled = true;
    }



        private void UpdateAppointment() 
        {
            var repo = new AppointmentRepository();
            var controller = new AppointmentController(repo);

            appointment.StylistId = (int)cmb_stylist.SelectedValue;

            controller.UpdateAppointment(appointment);

            MessageBox.Show("Stylist successfully assigned to the appointment!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mainForm.LoadAppointments();
            this.Close(); 

        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            UpdateAppointment();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
