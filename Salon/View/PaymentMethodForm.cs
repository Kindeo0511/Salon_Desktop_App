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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Salon.View
{
    public partial class PaymentMethodForm : MaterialForm
    {
        private readonly MainForm main;
        private readonly ConfigureSettingsForm settings;
        private readonly PaymentMethodModel paymentMethod;
        private bool IsSave = false;
        private bool IsUpdate = false;
        private bool configureSettings = false;
        public PaymentMethodForm(MainForm main)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.main = main;
            IsSave = true;

            this.AcceptButton = btn_save;
        }
        public PaymentMethodForm(ConfigureSettingsForm settingsForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.settings = settingsForm;
            configureSettings = true;
        
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
 
            IsUpdate = true;
            this.AcceptButton = btn_update;
        }
        public void LoadPaymentMethod(PaymentMethodModel model) 
        {
            txt_name.Text = model.name;
            rad_yes.Checked = model.required_reference;
            rad_no.Checked = !model.required_reference;

            
        }
       
        private bool Save() 
        {
            var repo = new PaymentMethodRepository();
            var controller = new PaymentMethodController(repo);

            string name = txt_name.Text.Trim();
            bool is_required = rad_yes.Checked;

            var SaveModel = new PaymentMethodModel
            {
   
                name = name,
                required_reference = is_required,
 
            };

            return controller.AddPaymentMethod(SaveModel);
        }
        private bool Update() 
        {
            var repo = new PaymentMethodRepository();
            var controller = new PaymentMethodController(repo);

            string name = txt_name.Text.Trim();
            bool is_required = rad_yes.Checked;
  

            var UpdateModel = new PaymentMethodModel
            {
                id = this.paymentMethod.id,
                name = name,
                required_reference = is_required,
        
            };
            return controller.UpdatePaymentMethod(UpdateModel);
        }
        private void PaymentMethodForm_Load(object sender, EventArgs e)
        {
           
        }
        private bool IsPaymentValid()
        {
            bool validated = true;
            int excludeId = paymentMethod?.id ?? 0;


            string name = txt_name.Text.Trim();


            int deleted_payment_method_id = 0;
            if (IsSave)
            {

                deleted_payment_method_id = ExistingPaymentMethodButDeleted(name);
            }

            if (string.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(txt_name, "Payment name cannot be empty");
                validated = false;
            }
            else if (name.Length < 2)
            {
                errorProvider1.SetError(txt_name, "Payment name must be at least 2 characters");
                validated = false;
            }
            else if (name.Length > 50)
            {
                errorProvider1.SetError(txt_name, "Payment name cannot exceed 50 characters");
                validated = false;
            }
            else if (!Regex.IsMatch(name, @"^[a-zA-Z0-9\s\-]+$"))
            {
                errorProvider1.SetError(txt_name, "Payment name contains invalid characters");
                validated = false;
            }
            else if (deleted_payment_method_id > 0)
            {
                var result = MessageBox.Show("This Payment Method exists but is deleted. Do you want to restore it?",
                                  "Restore Payment",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {



                    RestorePaymentMethod(deleted_payment_method_id);

                }
                validated = false;
            }
            else if (ExistingPaymentMethodActive(name, excludeId))
            {
                errorProvider1.SetError(txt_name, $"Payment name already exists.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_name, ""); // clear error
            }

   

           
            return validated;
        }
        private bool ExistingPaymentMethodActive(string name, int id) 
        {
            var repo = new PaymentMethodRepository();
            var controller = new PaymentMethodController(repo);

            return controller.IsPaymentMethodExists(name, id);
        }
        private int ExistingPaymentMethodButDeleted(string name) 
        {
            var repo = new PaymentMethodRepository();
            var controller = new PaymentMethodController(repo);

            return controller.GetDeletedPaymentMethodId(name);
        }
        public void RestorePaymentMethod(int id) 
        {
            var repo = new PaymentMethodRepository();
            var controller = new PaymentMethodController(repo);

           
            if (controller.RestorePaymentMethod(id))
            {
                main.DeleteDeletedRecord(id);
                MessageBox.Show("Payment method restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.LoadPaymentMethod();
                main.LoadPaymentMethodCombobox();
                this.Close();
            }


        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            
            if (!IsPaymentValid()) return;
            if (Save())
                
            {
                MessageBox.Show("Payment Method added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
               
                    main.LoadPaymentMethod();
                    main.LoadPaymentMethodCombobox();
                    this.Close();


            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsPaymentValid()) return;
            if (IsUpdate) 
            {
                if (Update())

                {
                    MessageBox.Show("Payment Method updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main.LoadPaymentMethod();
                    main.LoadPaymentMethodCombobox();
                    this.Close();
                }
            }
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
