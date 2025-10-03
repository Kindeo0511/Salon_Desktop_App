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
            LoadStylist();
        }


        private void LoadStylist() 
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylist = controller.StylistFullName();

            cmb_stylist.DisplayMember = "fullName";
            cmb_stylist.ValueMember = "stylist_id";

            cmb_stylist.DataSource = stylist;
            cmb_stylist.SelectedIndex = -1;
        
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
    }
}
