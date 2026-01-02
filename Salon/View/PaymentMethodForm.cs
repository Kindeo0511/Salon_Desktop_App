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
    public partial class PaymentMethodForm : MaterialForm
    {
        private readonly MainForm main;
        private readonly PaymentMethodModel paymentMethod;
        private bool IsSave = false;
        private bool IsUpdate = false;
        public PaymentMethodForm(MainForm main)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.main = main;
        }
        public PaymentMethodForm(MainForm main, PaymentMethodModel paymentMethod)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.main = main;
            this.paymentMethod = paymentMethod;
            LoadPaymentMethod(this.paymentMethod);

            btn_save.Visible = false;
            btn_update.Visible = true;
            IsSave = true;
            IsUpdate = false;
        }
        public void LoadPaymentMethod(PaymentMethodModel model) 
        {
            txt_name.Text = model.name;
            rad_yes.Checked = model.required_reference;
            rad_no.Checked = !model.required_reference;
            chk_yes.Checked = model.is_active;
            
        }
       
        private bool Save() 
        {
            var repo = new PaymentMethodRepository();
            var controller = new PaymentMethodController(repo);

            string name = txt_name.Text.Trim();
            bool is_required = rad_yes.Checked;
            bool is_checked = chk_yes.Checked;

            var SaveModel = new PaymentMethodModel
            {
   
                name = name,
                required_reference = is_required,
                is_active = is_checked,
            };

            return controller.AddPaymentMethod(SaveModel);
        }
        private bool Update() 
        {
            var repo = new PaymentMethodRepository();
            var controller = new PaymentMethodController(repo);

            string name = txt_name.Text.Trim();
            bool is_required = rad_yes.Checked;
            bool is_checked = chk_yes.Checked;

            var UpdateModel = new PaymentMethodModel
            {
                id = this.paymentMethod.id,
                name = name,
                required_reference = is_required,
                is_active = is_checked,
            };
            return controller.UpdatePaymentMethod(UpdateModel);
        }
        private void PaymentMethodForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Save())
                
            {
                MessageBox.Show("Payment Method added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadPaymentMethod();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (Update())

            {
                MessageBox.Show("Payment Method updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadPaymentMethod();
            }
        }
    }
}
