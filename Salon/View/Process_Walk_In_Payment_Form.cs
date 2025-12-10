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
namespace Salon.View
{
    public partial class Process_Walk_In_Payment_Form : MaterialForm
    {
        private readonly MainForm main;
        private readonly WalkInModel model;
        public Process_Walk_In_Payment_Form(MainForm main, WalkInModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.main = main;
            this.model = model;
       
            LoadDiscount();

            LoadSelectedData(this.model);
            LoadVat();
        }

        private void LoadSelectedData(WalkInModel model)
        {
   

            txt_walk_in_code.Text = model.name;
            txt_services.Text = model.serviceName;
            lbl_Subtotal.Text = "₱ " + model.selling_price.ToString("N2");
            txt_date.Text = model.date.ToString("d");
            DateTime start = model.date.Date.Add(model.start_time);
            DateTime end = model.date.Date.Add(model.end_time);

            txt_time.Text = start.ToString("hh:mm tt") + " - " + end.ToString("hh:mm tt");





        }
        private void LoadDiscount()
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);
            var discounts = controller.GetDiscounts();

            cb_discount.DisplayMember = "discount_and_promo_code";
            cb_discount.ValueMember = "discount_id";
            cb_discount.DataSource = discounts;

            cb_discount.SelectedIndex = -1;

            lbl_discount_type.Text = "Discount";
            lbl_Discount.Text = "0.00";


        }
        private void LoadVat()
        {
            var repo = new VatRepository();
            var controller = new VatController(repo);
            var vat = controller.LoadLatestTax();

            if (vat != null)
            {
                // Show the tax rate
                lbl_tax_rate.Text = $"Vat ({vat.tax}%)";

                // Get subtotal
                string rawSubtotal = lbl_Subtotal.Text.Replace("₱", "").Trim();
                decimal total = Convert.ToDecimal(rawSubtotal);
                decimal vatRate = vat.tax / 100m;

                // Compute net and VAT amount
                decimal net = total / (1 + vatRate);
                decimal vatAmount = total - net;

                // Show VAT amount
                lbl_Vat.Text = $"₱ {vatAmount:N2}";

            }
            else
            {
                lbl_tax_rate.Text = "Vat";
                lbl_Vat.Text = "₱0.00";
            }
        }
        private decimal ParseCurrency(string input)
        {
            string cleaned = input.Replace("₱", "").Trim();
            return decimal.TryParse(cleaned, out decimal value) ? value : 0;
        }
        private void calculate()
        {
            // Step 0: Parse values
            decimal _subtotal = ParseCurrency(lbl_Subtotal.Text);
            decimal vat_rate = 0;
            decimal discount_rate = 0;
            decimal discountAmount = 0;
            decimal total_With_Vat = 0;
            decimal vat_amount = 0;
            // Convert percentage rates from int to decimal
            decimal vatRate = vat_rate / 100m;         // Converts 12 to 0.12
            decimal discountRate = discount_rate / 100m;

            // Step 1: Extract VAT from VAT-inclusive subtotal
            decimal vatPortion = Math.Round(_subtotal * vatRate / (1 + vatRate), 2);
            decimal netAmount = Math.Round(_subtotal - vatPortion, 2);

            // Step 2: Determine discount base
            decimal discountBase = sw_exempt_vat.Checked ? netAmount : _subtotal;

            // Step 3: Calculate discount
            discountAmount = Math.Round(discountBase * discountRate, 2);

            // Step 4: Final total
            total_With_Vat = Math.Round(discountBase - discountAmount, 2);

            // Step 5: Update UI
            lbl_Vat.Text = sw_exempt_vat.Checked ? "₱0.00" : $"₱ {vatPortion:N2}";
            lbl_Discount.Text = discountAmount > 0 ? $"₱ {discountAmount:N2}" : "₱0.00";
            lbl_Total.Text = $"₱ {total_With_Vat:N2}";

            if (cb_PaymentMethod.Text.ToLower() == "gcash")
            {
                decimal amountPaid = ParseCurrency(lbl_Total.Text);
                txt_amount_paid.Text = amountPaid.ToString();
                txt_Reference.Enabled = true;
                txt_amount_paid.ReadOnly = true;
                txt_amount_paid.Enabled = true;
            }
            else if (cb_PaymentMethod.Text.ToLower() == "cash")
            {

                decimal amountPaid = ParseCurrency(txt_amount_paid.Text);
                txt_amount_paid.Text = amountPaid.ToString();
                txt_Reference.Text = string.Empty;
                txt_Reference.Enabled = false;
                txt_amount_paid.Enabled = true;
                txt_amount_paid.ReadOnly = false;
            }
            else
            {
                txt_amount_paid.Text = string.Empty;
                txt_Reference.Text = string.Empty;
                txt_amount_paid.ReadOnly = false;
            }
            // Step 6: Store for audit/export
            vat_amount = sw_exempt_vat.Checked ? 0 : vatPortion;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_amount_paid_TextChanged(object sender, EventArgs e)
        {
            decimal amountPaid = 0m;
            decimal totalAmount = ParseCurrency(lbl_Total.Text);


            if (!decimal.TryParse(txt_amount_paid.Text, out amountPaid))
            {
                lbl_change_amount.Text = "0.00";
                return;
            }


            decimal changeAmount = amountPaid - totalAmount;


            lbl_change_amount.Text = changeAmount < 0 ? "0.00" : changeAmount.ToString("F2");
        }

        private void cb_PaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_PaymentMethod.Text.ToLower() == "gcash")
            {
                decimal amountPaid = ParseCurrency(lbl_Total.Text);
                txt_amount_paid.Text = amountPaid.ToString();
                txt_Reference.Enabled = true;
                txt_amount_paid.ReadOnly = true;
                txt_amount_paid.Enabled = true;
            }
            else if (cb_PaymentMethod.Text.ToLower() == "cash")
            {

                txt_Reference.Text = string.Empty;
                txt_amount_paid.Enabled = true;
                txt_Reference.Enabled = false;
                txt_amount_paid.ReadOnly = false;
            }
            else
            {
                txt_amount_paid.Text = string.Empty;
                txt_Reference.Text = string.Empty;
                txt_amount_paid.ReadOnly = false;
            }
        }

        private void lbl_Vat_Click(object sender, EventArgs e)
        {

        }
    }
}
