using MaterialSkin.Controls;
using Microsoft.Extensions.Logging;
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
    public partial class DiscountForm : MaterialForm
    {
        private MainForm main;
        private DiscountModel discountModel;
        private bool is_saving = false;
        private bool is_updating = false;
        private int isSystemDefined = 0;
        public DiscountForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            is_saving = true;
            this.main = mainForm;
        
        }
        public DiscountForm(MainForm mainForm, DiscountModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.main = mainForm;
            this.discountModel = model;
            is_updating = true;

          
                // Defensive null checks for numeric fields
               
                cmb_discount_type.SelectedItem = discountModel.discount_type;
            txt_promo_name.Text = discountModel.promo_code;
            txt_discount.Text = discountModel.discount_rate.ToString("0.##");

                string mode = discountModel.mode;

                if (mode == "Percentage")
                {
                    rad_percent.Checked = true;
                    rad_fixed.Checked = false;
                }
                else if (mode == "Fixed Amount")
                {
                    rad_fixed.Checked = true;
                    rad_percent.Checked = false;
                }
        

                chk_is_active.Checked = discountModel.status == 1;
                chk_vat_exempt.Checked = (discountModel.vat_exempt == 1);

            
                btn_add_discount.Visible = false;
                btn_update_discount.Visible = true;

              

              

             
               
            

        }
    

        private  void btn_update_discount_Click(object sender, EventArgs e)
        {
           

            UpdateDiscount();
          
            this.Close();
        }
        private void UpdateDiscount()
        {
            int id = discountModel.discount_id;
            string discount_type = cmb_discount_type.Text;
            string promo_name = txt_promo_name.Text.Trim();
            int discount_value = Convert.ToInt32(txt_discount.Value);
            string mode = rad_percent.Checked ? rad_percent.Text : rad_fixed.Text;
            int vat_exempt = chk_vat_exempt.Checked ? 1 : 0;
            int is_active = chk_is_active.Checked ? 1 : 0;

            var discount = new DiscountModel
            {
                discount_id = id,
                discount_type = discount_type,
                promo_code = promo_name,
                discount_rate = discount_value,
                mode = mode,
                vat_exempt = vat_exempt,
                is_defined = isSystemDefined,
                status = is_active

            };
            var update_repo = new DiscountRepository();
            var update_discount_controller = new DiscountController(update_repo);
            if (MessageBox.Show($"Are you sure you want to update {discountModel.discount_type}?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                update_discount_controller.UpdateDiscount(discount);
                MessageBox.Show("Discount updated succesfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
          
     
                Audit.AuditLog(
                   DateTime.Now,
                   "Update",
                   UserSession.CurrentUser.first_Name,
                   "Vat/Discount",
                   $"Updated discount '{cmb_discount_type.Text}' with rate ({txt_discount.Text}%) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
               );

                main.LoadDiscount();
            }
        }
        private void AddDiscount()
        {
            string discount_type = cmb_discount_type.Text;
            string promo_name = txt_promo_name.Text.Trim();
            int discount_value = Convert.ToInt32(txt_discount.Value);
            string mode = rad_percent.Checked ? rad_percent.Text : rad_fixed.Text;
            int vat_exempt = chk_vat_exempt.Checked ? 1 : 0;
            int is_active = chk_is_active.Checked ? 1 : 0;
           

            var repo = new DiscountRepository();
            var discount_controller = new DiscountController(repo);
            var discount = new DiscountModel
            {
                discount_type = discount_type,
                promo_code = promo_name,
                discount_rate = discount_value,
                mode = mode,
               vat_exempt = vat_exempt,
               is_defined = isSystemDefined,
               status = is_active
               
            };
            int id = discount_controller.AddDiscount(discount);
            

            if(id > 0) 
            {
                MessageBox.Show("Discount added succesfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Audit.AuditLog(
                       DateTime.Now,
                       "Create",
                       UserSession.CurrentUser.first_Name,
                       "Vat/Discount",
                       $"Created discount '{cmb_discount_type.Text}' with rate ({txt_discount.Text}%) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                   );

                main.LoadDiscount();
            }
           
       

        }

       
     
      
        private void btn_cancel_discount_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clear_discount_fields()
        {
           
            cmb_discount_type.SelectedIndex = -1;
            rad_fixed.Checked = false;
            rad_percent.Checked = false;
            chk_is_active.Checked = false;
            txt_promo_name.Text = "";
    
           
        }
     
       
        private async void btn_add_discount_Click(object sender, EventArgs e)
        {
           
            AddDiscount();
            clear_discount_fields();
           
            this.Close();
        }
       

        

        private void txt_promo_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys
            if (char.IsControl(c))
                return;

            // Allow letters, digits, hyphen, underscore
            if (char.IsLetterOrDigit(c) || c == '-' || c == '_')
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys
            if (char.IsControl(c))
                return;

            // Allow digits
            if (char.IsDigit(c))
                return;

            // Allow one decimal point, not at the start
            if (c == '.' && txt != null)
            {
                if (!txt.Text.Contains(".") && txt.SelectionStart > 0)
                    return;

                e.Handled = true;
                return;
            }

            // Block everything else
            e.Handled = true;
        }

        private void cmb_discount_type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selected = cmb_discount_type.SelectedItem?.ToString();
            if (is_saving)
                {
                if (selected == "PWD" || selected == "Senior")
                {
                        txt_promo_name.Enabled = false;
                        rad_percent.Checked = true;
                        chk_vat_exempt.Checked = (selected == "PWD" || selected == "Senior");
                        chk_is_active.Checked = true;
                       txt_promo_name.Text = string.Empty;
                        isSystemDefined = 1;

                }
                    else 
                    {
                        isSystemDefined = 0;
                        txt_promo_name.Enabled = true;
                        rad_percent.Checked = false;
                        chk_vat_exempt.Checked = false;
                        chk_is_active.Checked = false;
                    
                    }
                }
                else if (is_updating) 
                {
                if (selected == "PWD" || selected == "Senior")
                {
                    txt_promo_name.Enabled = false;
                    isSystemDefined = 1;
                    txt_promo_name.Text = string.Empty;
                }
                else
                {
                    isSystemDefined = 0;
                    txt_promo_name.Text = discountModel.promo_code;
                }
            }


               
            }
        

        private void DiscountForm_Load(object sender, EventArgs e)
        {
          
           
        }
    }
}
