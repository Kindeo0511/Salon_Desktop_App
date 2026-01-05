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
        public event EventHandler CustomerAdded;
        public event EventHandler CustomerUpdated;
        private MainForm mainform;
        private CustomerModel customer;
        private bool _isSaving = false;
        private bool _isUpdating = false;
        public CustomerForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isSaving = true;
            this.mainform = mainform;
        }

        public CustomerForm(MainForm mainform, CustomerModel customer)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isUpdating = true;
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


        private bool AddCustomer(string first_name = null, string middle_name = null, string last_name = null, string email = null, string number = null, string customer_type = null) 
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

            return controller.AddCustomer(customer);
        }
        private bool UpdateCustomer(string first_name = null, string middle_name = null, string last_name = null, string email = null, string number = null, string customer_type = null) 
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            customer.firstName = first_name;
            customer.middleName = middle_name;
            customer.lastName = last_name;
            customer.phoneNumber = number;
            customer.email = email;
            customer.customer_type = customer_type;
            return controller.UpdateCustomer(customer);
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

          

            return validated;
        }
        private void IsAccountExists()
        {
            var repo = new CustomerRepository();
            var controller = new CustomerController(repo);
            var existingUser = controller.GetEmail(txt_email.Text.Trim());

            if (existingUser != null)
            {

                if (existingUser.is_deleted == 1)
                {
                    var result = MessageBox.Show("This Customer exists but is deleted. Do you want to restore it?",
                                   "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {



                        if (controller.RestoreCustomer(existingUser.customer_id))
                        {
                            mainform.DeleteDeletedRecord(existingUser.customer_id);
                            MessageBox.Show("Customer restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }



                    }
                }
            }

            else
            {
                if (_isSaving)
                {
                   

                    if (AddCustomer(txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_email.Text, txt_contact.Text, "Member"))
                    {
                        CustomerAdded?.Invoke(this, EventArgs.Empty);
                        var fullName = txt_first_name.Text + " " + txt_last_name.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Customer", $"Created customer '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdating)
                {
                    if (UpdateCustomer(txt_first_name.Text, txt_middle_name.Text, txt_last_name.Text, txt_email.Text, txt_contact.Text))
                    {
                        CustomerUpdated?.Invoke(this, EventArgs.Empty);
                        var fullName = txt_first_name.Text + " " + txt_last_name.Text;
                        Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Customer", $"Updated customer '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

        }
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            IsAccountExists();


            //await mainform.RefreshCustomers();
      
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            IsAccountExists();
            
            //await mainform.RefreshCustomers();
       
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow only letters and spaces
            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
            {
                e.Handled = true;
            }
        }

        private void txt_middle_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow only letters and spaces
            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
            {
                e.Handled = true;
            }
        }

        private void txt_last_name_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string allowed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";

            if (!char.IsControl(c) && !allowed.Contains(c))
                e.Handled = true;
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (char.IsControl(c))
                return;

            if (!char.IsDigit(c))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_last_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow only letters and spaces
            if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
            {
                e.Handled = true;
            }
        }

      
    }
}
