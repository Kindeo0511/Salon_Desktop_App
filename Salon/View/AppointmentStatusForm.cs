using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Models;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Salon.View
{
    public partial class AppointmentStatusForm : MaterialForm
    {
        private MainForm mainForm;
        private AppointmentModel AppointmentModel;
        public AppointmentStatusForm(MainForm mainForm, AppointmentModel AppointmentModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
            this.AppointmentModel = AppointmentModel;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmb_status.Text))
            {
                MessageBox.Show("Please select a valid status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppointmentModel.Status = cmb_status.Text;
            var controller = new AppointmentController();
            controller.UpdateStatus(AppointmentModel.Status, AppointmentModel.AppointmentId);

            MessageBox.Show("Status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await mainForm.RefreshAppointmentAsync();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
