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
using Salon.Util;
namespace Salon.View
{
    public partial class CustomAmountForm : MaterialForm
    {
        public decimal CustomAmount { get; set; }
        public CustomAmountForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void txt_confirm_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_amount, "");

            if (string.IsNullOrWhiteSpace(txt_amount.Text)) 
            {
                errorProvider1.SetError(txt_amount, "Amount cannot be empty.");
                return;

            }
            if (int.TryParse(txt_amount.Text, out int value))
            {
                CustomAmount = value;
;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else 
            {
                errorProvider1.SetError(txt_amount, "Please enter a valid number.");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
