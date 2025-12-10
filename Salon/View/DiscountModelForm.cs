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
 
        public DiscountModelForm( )
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            LoadDiscounts();
        }

        private void LoadDiscounts()
        {
           var repo = new DiscountRepository();
           var controller = new DiscountController(repo);
           var discounts = controller.getAllDiscount();

            cmb_discount.DataSource = null;
            cmb_discount.DisplayMember = "discount_type";
            cmb_discount.ValueMember = "discount_rate";

    

            cmb_discount.DataSource = discounts;

            cmb_discount.SelectedIndex = -1;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_apply_discount_Click(object sender, EventArgs e)
        {
            discountRate = Convert.ToInt32(cmb_discount.SelectedValue);
            discountName = discountRate.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
