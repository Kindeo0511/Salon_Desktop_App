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
    public partial class CustomerForm : MaterialForm
    {
        private MainForm mainform;
        private CustomerModel customer; 
        public CustomerForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
        }

        public CustomerForm(MainForm mainform, CustomerModel customer)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
            this.customer = customer;

            if (customer != null) 
            {
                txt_first_name.Text = customer.firstName;
                txt_middle_name.Text = customer.middleName;
                txt_last_name.Text = customer.lastName;
                txt_contact.Text = customer.phoneNumber;
                txt_email.Text = customer.email;

                btn_save.Visible = false;
                btn_update.Visible = true;
                
            }
        }


        private void AddCustomer() 
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            var customer = new CustomerModel
            {
                firstName = txt_first_name.Text,
                middleName = txt_middle_name.Text,
                lastName = txt_last_name.Text,
                phoneNumber = txt_contact.Text,
                email = txt_email.Text
            };

            controller.AddCustomer(customer);
        }
        private void UpdateCustomer() 
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            customer.firstName = txt_first_name.Text;
            customer.middleName = txt_middle_name.Text;
            customer.lastName = txt_last_name.Text;
            customer.phoneNumber = txt_contact.Text;
            customer.email = txt_email.Text;
            controller.UpdateCustomer(customer);
        }
        private bool Validated()
        {

            bool validated = true;
            // REQUIRED FIELD
            validated &= Validator.IsRequired(txt_first_name, errorProvider1, "First name is required.");
            validated &= Validator.IsRequired(txt_middle_name, errorProvider1, "Middle name is required.");
            validated &= Validator.IsRequired(txt_last_name, errorProvider1, "Last name is required.");
            validated &= Validator.IsRequired(txt_email, errorProvider1, "Email is required.");
            validated &= Validator.IsRequired(txt_contact, errorProvider1, "Contact number is required.");
   ;

            // VALID EMAIL
            validated &= Validator.IsValidEmail(txt_email, errorProvider1);
            // VAILD PHONE NUMBER
            validated &= Validator.IsValidPhone(txt_contact, errorProvider1);


            // EXISTS VALIDATION
            int excludeId = customer?.customer_id ?? 0;

            validated &= Validator.IsCustomerEmailExists(txt_email, errorProvider1, "Email already exists.", excludeId);
            validated &= Validator.IsCustomerPhoneExists(txt_contact, errorProvider1, "Contact number already exists.", excludeId);

            return validated;


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            AddCustomer();
            var fullName = txt_first_name.Text +" "+ txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Customer", $"Created customer '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            mainform.LoadCustomers();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            UpdateCustomer();
            var fullName = txt_first_name.Text + " " + txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Customer", $"Updated customer '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            mainform.LoadCustomers();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
