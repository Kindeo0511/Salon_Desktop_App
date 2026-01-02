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
using Salon.Models;
using Salon.Repository;
using Salon.Controller;
namespace Salon.View
{
    public partial class UpdateDiscountStatusForm : MaterialForm
    {
        private MainForm mainForm;
        private DiscountModel discountModel;
        public UpdateDiscountStatusForm(MainForm mainForm, DiscountModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
            this.discountModel = model;
            
        }


        private void UpdateStatus() 
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);

            discountModel.status = cmb_status.Text.Trim();

            controller.UpdateDiscountStatus(discountModel);

        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_status.SelectedItem != null && cmb_status.SelectedIndex > 0)
            {
                UpdateStatus();
                MessageBox.Show("Status Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.Close();
            }
            else
            {

                errorProvider1.SetError(cmb_status, "Please select a status.");

            }
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
