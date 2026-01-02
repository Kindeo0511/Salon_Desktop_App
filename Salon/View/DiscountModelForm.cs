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
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Util;
namespace Salon.View
{
    public partial class DiscountModelForm : MaterialForm
    {
        public  string discountName;
        public decimal discountRate { get; set; }
        public decimal fixedDiscount { get; set; }
        public decimal originalPrice { get; set; }
        public int discountedQty { get; set; }
        public int quantity { get; set; }
        public string name { get; set; }
        public bool isVatExempt { get; set; } = false;
        public bool IsFreeReward { get; set; } = false;
        public string pos { get; set; }
        public DiscountModelForm(string name, int qty ,decimal price)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            
            this.name = name;
            this.quantity = qty;
            this.originalPrice = price;

            lbl_item_name.Text = name;
            txt_qty.Value = qty;

        }
        public DiscountModelForm(string name, int qty, decimal price, string pos)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.pos = pos;
            this.name = name;
            this.quantity = qty;
            this.originalPrice = price;

            lbl_item_name.Text = name;
            txt_qty.Value = qty;

            btn_free.Visible = false;
        }



        private void PremadeDiscountButtons(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return;


            if (decimal.TryParse(input, out decimal discountValue))
            {
                discountRate = discountValue ;
               
            }


        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_apply_discount_Click(object sender, EventArgs e)
        {


            //discountRate = Convert.ToInt32(cmb_discount.SelectedValue);
            //discountName = discountRate.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
       
        private void txt_discount_percent_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_discount_percent.Text))
            {
                PremadeDiscountButtons(txt_discount_percent.Text);
       
            }
        }



        private void txt_fixed_amount_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_fixed_amount.Text))
            {
                if (decimal.TryParse(txt_fixed_amount.Text, out decimal fixedAmount))
                {
                    fixedDiscount = fixedAmount;
                }
            }
        }

        private void txt_qty_ValueChanged(object sender, EventArgs e)
        {
            discountedQty = (int)txt_qty.Value;
        }

        private void btn_discount_senior_Click(object sender, EventArgs e)
        {
            var discount = LoadDiscountType("Senior");
            isVatExempt = discount.vat_exempt > 0;
            PremadeDiscountButtons(discount.discount_rate.ToString());
            txt_discount_percent.Text = discount.discount_rate.ToString();
        }

        private void btn_discount_pwd_Click(object sender, EventArgs e)
        {
            var discount = LoadDiscountType("PWD");
            isVatExempt = discount.vat_exempt > 0;
            PremadeDiscountButtons(discount.discount_rate.ToString());
            txt_discount_percent.Text = discount.discount_rate.ToString();
        }
        public DiscountModel LoadDiscountType(string type)
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);
            var discount = controller.GetDiscountType(type);
            return discount;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var discount = LoadDiscountType("Free");
            IsFreeReward = true;
            PremadeDiscountButtons(discount.discount_rate.ToString());
            txt_discount_percent.Text = discount.discount_rate.ToString();
        }
    }
}
