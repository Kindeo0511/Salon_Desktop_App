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
        public decimal totalAmount;
        public CustomAmountForm(decimal total)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            totalAmount = total;
        }

        private void txt_confirm_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_amount, "");

            if (string.IsNullOrWhiteSpace(txt_amount.Text))
            {
                errorProvider1.SetError(txt_amount, "Amount cannot be empty.");
                return;
            }

            if (!decimal.TryParse(txt_amount.Text, out decimal value))
            {
                errorProvider1.SetError(txt_amount, "Please enter a valid number.");
                return;
            }

            if (value <= 0)
            {
                errorProvider1.SetError(txt_amount, "Amount must be greater than 0.");
                return;
            }
            // Must be at least equal to total bill
            if (value < totalAmount)
            {
                decimal shortage = totalAmount - value;
                errorProvider1.SetError(txt_amount, $"Insufficient. Short by ₱{shortage:N2}.");
                return;
            }

            // Cannot exceed 10x the total bill
            if (value > totalAmount * 5)
            {
                errorProvider1.SetError(txt_amount, $"Amount is too large. Max allowed is ₱{totalAmount * 5:N2}.");
                return;
            }

            CustomAmount = (decimal)value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
