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
    public partial class PromoForm : MaterialForm
    {
        public decimal promo_rate { get; set; }
        public decimal promo_fixed_amount { get; set; }
        public int vat_exempt { get; set; }

        public PromoForm( )
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
           
        }
        private void LoadPromo() 
        {
            var repo = new DiscountRepository();
            var controller = new DiscountController(repo);

            var promo = controller.GetAllPromo();

            var promoList = promo.Where(p=>p.discount_type == "Promo" && p.is_deleted == 0 && p.status == 1).ToList();

            
            cmb_promo.DisplayMember = "promo_code";
            cmb_promo.ValueMember = "discount_id";
            cmb_promo.DataSource = promoList;
            cmb_promo.SelectedIndex = -1;







        }

        private void PromoForm_Load(object sender, EventArgs e)
        {
            LoadPromo();
        }

        private void cmb_promo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_promo.SelectedItem is DiscountModel selected_promo)
            {
                if (selected_promo.mode == "Percentage")
                {
                    promo_rate = selected_promo.discount_rate;
                    promo_fixed_amount = 0;
                }
                else if (selected_promo.mode == "Fixed Amount")
                {
                    promo_fixed_amount = selected_promo.discount_rate;
                    promo_rate = 0;
                }
                vat_exempt = selected_promo.vat_exempt;

            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
