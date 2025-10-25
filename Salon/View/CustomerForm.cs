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
                cmb_customer_type.Text = customer.customer_type;
                btn_save.Visible = false;
                btn_update.Visible = true;
                
            }
        }


        private void AddCustomer(string first_name = null, string middle_name = null, string last_name = null, string email = null, string number = null, string customer_type = null) 
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            var customer = new CustomerModel
            {
                firstName = first_name,
                middleName = middle_name,
                lastName = last_name,
                email = email,
                phoneNumber = number,
                customer_type = customer_type
            };

            controller.AddCustomer(customer);
        }
        private void UpdateCustomer(string first_name = null, string middle_name = null, string last_name = null, string email = null, string number = null, string customer_type = null) 
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            customer.firstName = first_name;
            customer.middleName = middle_name;
            customer.lastName = last_name;
            customer.phoneNumber = number;
            customer.email = email;
            customer.customer_type = customer_type;
            controller.UpdateCustomer(customer);
        }
        private bool IsValid()
        {
            int excludeId = customer?.customer_id ?? 0;
            bool validated = true;

            // First name
            if (!Validator.IsRequiredTextField(txt_first_name, errorProvider1, "First name is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_first_name, errorProvider1, "First name must be at least 3 characters.", 3))
            {
                validated = false;
            }
            // Allows letters, spaces, hyphens, apostrophes, accented characters
            else if (!Validator.Pattern(txt_first_name, errorProvider1, @"^[A-Za-zÀ-ÿ'’\- ]+$", "First Name contains invalid characters."))
            {
                validated = false;
            }
            else if (!Validator.DisallowSpaces(txt_first_name, errorProvider1, "No Space Allowed"))
            {
                validated = false;
            }


            // Middle name (optional)
            if (!string.IsNullOrWhiteSpace(txt_middle_name.Text))
            {
                if (!Validator.IsMinimumLength(txt_middle_name, errorProvider1, "Middle name must be at least 3 characters.", 3))
                {
                    validated = false;
                }
                else if (!Validator.Pattern(txt_middle_name, errorProvider1, @"^[A-Za-z]+$", "Middle name should only contain letters."))
                {
                    validated = false;
                }
                else if (!Validator.DisallowSpaces(txt_middle_name, errorProvider1, "No space allowed in middle name."))
                {
                    validated = false;
                }
            }

            // Last name
            if (!Validator.IsRequiredTextField(txt_last_name, errorProvider1, "Last name is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_last_name, errorProvider1, "Last name must be at least 3 characters.", 3))
            {
                validated = false;
            }
            else if (!Validator.Pattern(txt_last_name, errorProvider1, @"^[A-Za-z]+$", "Last name should only contain letters."))
            {
                validated = false;
            }
            else if (!Validator.DisallowSpaces(txt_last_name, errorProvider1, "No Space Allowed"))
            {
                validated = false;
            }

            // Customer type logic
            string customerType = cmb_customer_type.SelectedItem?.ToString();

            if (customerType == "Registered")
            {
                // Email
                if (!Validator.IsRequired(txt_email, errorProvider1, "Email is required."))
                {
                    validated = false;
                }

                else if (!Validator.IsValidEmail(txt_email, errorProvider1))
                {
                    validated = false;
                }
                else if (txt_email.Text.Count(c => c == '@') != 1)
                {
                    errorProvider1.SetError(txt_email, "Email must contain exactly one '@' symbol.");
                    validated = false;
                }
                //else if (!Validator.Pattern(txt_email, errorProvider1, "@^[A-Za-z0-9](?!.*?[@]{2})[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]+.[A-Za-z]{2,}$", "Email address should not start or end with a special character and must be valid.")) 
                //{
                //    validated = false;
                //}

                else if (!Validator.IsCustomerEmailExists(txt_email, errorProvider1, "Email already exists.", excludeId))
                {
                    validated = false;
                }
                else if (!Validator.DisallowSpaces(txt_email, errorProvider1, "No spaces allowed"))
                {
                    validated = false;
                }

                // Contact number
                if (!Validator.IsRequiredTextField(txt_contact, errorProvider1, "Contact number is required."))
                {
                    validated = false;
                }
                else if (!Validator.DisallowSpaces(txt_contact, errorProvider1, "No spaces allowed")) 
                {
                    validated = false;
                }
                else if (txt_contact.Text.Length != 11)
                {
                    errorProvider1.SetError(txt_contact, "Contact number must be exactly 11 digits.");
                    validated = false;
                }
                else if (!txt_contact.Text.StartsWith("09"))
                {
                    errorProvider1.SetError(txt_contact, "Contact number should start with '09'.");
                    validated = false;
                }
                else if (!Validator.IsValidPhone(txt_contact, errorProvider1))
                {
                    validated = false;
                }

                else if (!Validator.IsCustomerPhoneExists(txt_contact, errorProvider1, "Contact number already exists.", excludeId))
                {
                    validated = false;
                }
                    
            }
            else if (customerType == "Walk-In")
            {
                // Walk-ins require only name fields (already validated above)
                // You may optionally auto-fill email/contact with placeholders here
            }

            else
            {
                MessageBox.Show("Please select a valid customer type (Registered or Walk-In).", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validated = false;
            }

            return validated;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            AddCustomer(txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_email.Text, txt_contact.Text, cmb_customer_type.Text);
            var fullName = txt_first_name.Text +" "+ txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Customer", $"Created customer '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
             await mainform.RefreshCustomers();
            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            UpdateCustomer(txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_email.Text, txt_contact.Text, cmb_customer_type.Text);
            var fullName = txt_first_name.Text + " " + txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Customer", $"Updated customer '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await mainform.RefreshCustomers();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
