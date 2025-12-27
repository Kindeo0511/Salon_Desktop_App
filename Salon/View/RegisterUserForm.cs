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
    public partial class RegisterUserForm : MaterialForm
    {
        private readonly MainForm main;
        public RegisterUserForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.main = mainform;   
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EnableTextBox(string customer_type) 
        {
            if (customer_type != null)
            {
                txt_first_name.Enabled = true;
                txt_middle_name.Enabled = true;
                txt_last_name.Enabled = true;
                txt_email.Enabled = true;
                txt_number.Enabled = true;
            }
            else 
            {
                txt_first_name.Enabled = false;
                txt_middle_name.Enabled = false;
                txt_last_name.Enabled = false;
                txt_email.Enabled = false;
                txt_number.Enabled = false;
            }
        }
        private bool IsValid() 
        {
            var validated = true;

            if (cmb_customer_type.SelectedItem?.ToString() == "Registered")
            {
                // first name
                if (!Validator.IsRequiredTextField(txt_first_name, errorProvider1, "First name is required."))
                {
                    validated = false;
                }

                // middle name


                // last name
                if (!Validator.IsRequiredTextField(txt_last_name, errorProvider1, "Last name is required."))
                {
                    validated = false;
                }

                // email
                if (!Validator.IsRequiredTextField(txt_email, errorProvider1, "Email is required."))
                {
                    validated = false;
                }
                // contact number

                if (!Validator.IsRequiredTextField(txt_number, errorProvider1, "Contact number is required."))
                {
                    validated = false;
                }


            }
            else if (cmb_customer_type.SelectedItem?.ToString() == "Walk-In")
            {
                // first name
                if (!Validator.IsRequiredTextField(txt_first_name, errorProvider1, "First name is required."))
                {
                    validated = false;
                }

                // middle name


                // last name
                if (!Validator.IsRequiredTextField(txt_last_name, errorProvider1, "Last name is required."))
                {
                    validated = false;
                }



            }
            else 
            {
                MessageBox.Show("Please select a valid customer type (Registered or Walk-In).", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validated = false;
            }



                return validated;
        }

        private void SaveUser(string first_name = null, string middle_name = null, string last_name = null, string email = null, string number = null, string customer_type = null) 
        {
            var controller = new CustomerController(new CustomerRepository());

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
        private void cmb_customer_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableTextBox(cmb_customer_type.Text);

            if (cmb_customer_type.Text.ToLower() == "registered")
            {
                txt_email.Visible = true;
                txt_number.Visible = true;
            }
            else if (cmb_customer_type.Text.ToLower() == "walk-in") 
            {
                txt_email.Visible = false;
                txt_number.Visible = false;
            }
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;


            SaveUser(txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_email.Text , txt_number.Text, "Member");
            string type = cmb_customer_type.SelectedItem?.ToString() ?? "Unknown";
            MessageBox.Show($"Customer added successfully ({type}).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await main.RefreshCustomers();
        }
    }
}
