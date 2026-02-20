using MaterialSkin.Controls;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Mysqlx.Crud;
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
using System.Windows.Controls;
using System.Windows.Forms;
namespace Salon.View
{
    public partial class ConfigureSettingsForm : MaterialForm
    {
        public ConfigureSettingsForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            int currentYear = DateTime.Now.Year;

            int minYear = currentYear - 65; // Oldest allowed: 65 years old
            int maxYear = currentYear - 18; // Youngest allowed: 18 years old


            dtp_day_of_birth.MinDate = new DateTime(minYear, 1, 1);      // e.g., Jan 1, 1960 if it's 2025
            dtp_day_of_birth.MaxDate = new DateTime(maxYear, 12, 31);    // e.g., Dec 31, 2007 if it's 2025

            DateTime defaultDate = new DateTime(currentYear - 25, 1, 1); // e.g., 25 years old

            if (defaultDate < dtp_day_of_birth.MinDate)
                defaultDate = dtp_day_of_birth.MinDate;
            else if (defaultDate > dtp_day_of_birth.MaxDate)
                defaultDate = dtp_day_of_birth.MaxDate;

            dtp_day_of_birth.Value = defaultDate;
        }

  


        private void btn_personal_tab_next_Click(object sender, EventArgs e)
        {

            if (!IsValid()) return;

            if (materialTabControl1.SelectedIndex < materialTabControl1.TabCount - 1)
            {
                materialTabControl1.SelectedIndex++; // move forward }
                
            }
        }

        private void btn_account_tab_back_Click(object sender, EventArgs e)
        {
        
            if (materialTabControl1.SelectedIndex > 0)
            {
                materialTabControl1.SelectedIndex--; // move backward }
            }
        }

        private void btn_account_tab_next_Click(object sender, EventArgs e)
        {
            if (!AccountValid()) return;
            if (materialTabControl1.SelectedIndex < materialTabControl1.TabCount - 1)
            {
                materialTabControl1.SelectedIndex++; // move forward }

            }
        }

        private void btn_vat_tab_back_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex > 0)
            {
                materialTabControl1.SelectedIndex--; // move backward }
            }
        }

        private void btn_vat_tab_next_Click(object sender, EventArgs e)
        {
            if (!VatValid()) return;

            if (materialTabControl1.SelectedIndex < materialTabControl1.TabCount - 1)
            {
                materialTabControl1.SelectedIndex++; // move forward }

            }
        }
        private bool VatValid() 
        {
            bool validated = true;

            // VAT validation
            if (txt_vat.Value == 0) // treat 0 as "empty" or not set
            {
                errorProvider1.SetError(txt_vat, "VAT is required.");
                validated = false;
            }
            else if (txt_vat.Value < 0 || txt_vat.Value > 100)
            {
                errorProvider1.SetError(txt_vat, "VAT must be between 0% and 100%.");
                validated = false;
            }
            else if (txt_vat.Value % 1 != 0)
            {
                errorProvider1.SetError(txt_vat, "VAT must be a whole number.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_vat, string.Empty);
            }

            return validated;
        }
        private bool IsValid()
        {
            DateTime birthDate = dtp_day_of_birth.Value;
            int age = DateTime.Now.Year - birthDate.Year;
          

            bool validated = true;

            // First Name
            if (string.IsNullOrWhiteSpace(txt_first_name.Text))
            {
                errorProvider1.SetError(txt_first_name, "First name is required.");
                validated = false;
            }
            else if (txt_first_name.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txt_first_name, "First name must be at least 3 characters.");
                validated = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_first_name.Text.Trim(), @"^[A-Za-z]+(?: [A-Za-z]+)*$"))
            {
                errorProvider1.SetError(txt_first_name, "First name should only contain letters and no special characters.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_first_name, string.Empty);
            }

            // Middle Name (optional)
            if (!string.IsNullOrWhiteSpace(txt_middle_name.Text))
            {
                if (txt_middle_name.Text.Trim().Length < 2)
                {
                    errorProvider1.SetError(txt_middle_name, "Middle name must be at least 2 characters.");
                    validated = false;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_middle_name.Text.Trim(), @"^[A-Za-z]+(?: [A-Za-z]+)*$"))
                {
                    errorProvider1.SetError(txt_middle_name, "Middle name should only contain letters and no special characters.");
                    validated = false;
                }
                else
                {
                    errorProvider1.SetError(txt_middle_name, string.Empty);
                }
            }

            // Last Name
            if (string.IsNullOrWhiteSpace(txt_last_name.Text))
            {
                errorProvider1.SetError(txt_last_name, "Last name is required.");
                validated = false;
            }
            else if (txt_last_name.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(txt_last_name, "Last name must be at least 2 characters.");
                validated = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_last_name.Text.Trim(), @"^[A-Za-z]+(?: [A-Za-z]+)*$"))
            {
                errorProvider1.SetError(txt_last_name, "Last name should only contain letters and no special characters.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_last_name, string.Empty);
            }

            // Email
            if (string.IsNullOrWhiteSpace(txt_user_email.Text))
            {
                errorProvider1.SetError(txt_user_email, "Email is required.");
                validated = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_user_email.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(txt_user_email, "Please enter a valid email address.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_email, string.Empty);
            }

            // Contact
            if (string.IsNullOrWhiteSpace(txt_contact.Text))
            {
                errorProvider1.SetError(txt_contact, "Contact number is required.");
                validated = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_contact.Text.Trim(), @"^09\d{9}$"))
            {
                errorProvider1.SetError(txt_contact, "Contact number must start with '09' and be exactly 11 digits long with no spaces or symbols.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_contact, string.Empty);
            }

            // Age check
            if (birthDate > DateTime.Now.AddYears(-age)) age--;
            if (age < 18)
            {
                errorProvider1.SetError(dtp_day_of_birth, "Must be 18+ years old.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(dtp_day_of_birth, string.Empty);
            }

            // Address
            if (string.IsNullOrWhiteSpace(txt_address.Text))
            {
                errorProvider1.SetError(txt_address, "Address is required.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_address, string.Empty);
            }

           

            return validated;
        }

        private bool AccountValid() 
        {
            bool validated = true;
            // Username
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                errorProvider1.SetError(txt_username, "Username is required.");
                validated = false;
            }
            else if (txt_username.Text.Trim().Length < 4)
            {
                errorProvider1.SetError(txt_username, "Username must be at least 4 characters.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_username, string.Empty);
            }

            // Password
            if (string.IsNullOrWhiteSpace(txt_HashPassword.Text))
            {
                errorProvider1.SetError(txt_HashPassword, "Password is required.");
                validated = false;
            }
            else if (txt_HashPassword.Text.Trim().Length < 8)
            {
                errorProvider1.SetError(txt_HashPassword, "Password must be at least 8 characters.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_HashPassword, string.Empty);
            }

            // Confirm Password
            if (txt_confirm_password.Text != txt_HashPassword.Text)
            {
                errorProvider1.SetError(txt_confirm_password, "Passwords do not match.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_confirm_password, string.Empty);
            }

            return validated;
        }
        private bool SMPTPVALID() 
        {
            bool validated = true;
            // Business Name
            if (string.IsNullOrWhiteSpace(txt_business_name.Text))
            {
                errorProvider1.SetError(txt_business_name, "Business name is required.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_business_name, string.Empty);
            }
            // SMTP Email
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                errorProvider1.SetError(txt_email, "Email is required.");
                validated = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_email.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider1.SetError(txt_email, "Please enter a valid email address.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_email, string.Empty);
            }
            // SMTP Password
            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                errorProvider1.SetError(txt_password, "SMTP password is required.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_password, string.Empty);
            }
            return validated;
        }
        private int user_id;
        private int SaveUser()
        {
            var user = new UsersModel
            {
                first_Name = txt_first_name.Text.Trim(),
                middle_Name = txt_middle_name.Text.Trim(),
                last_Name = txt_last_name.Text.Trim(),
                birth_date = dtp_day_of_birth.Value,
                phone_Number = txt_contact.Text.Trim(),
                email = txt_email.Text.Trim(),
                address = txt_address.Text.Trim(),

            };
            var _repo = new UserRepository();
            var userController = new UserController(_repo);


            user_id = userController.AddUser(user);

            return user_id;

        }
        private void UpdateUserAccount()
        {
            var _repo = new UserRepository();
            var userController = new UserController(_repo);

            var user_model = new UsersModel
            {
                user_id = user_id,
                userName = txt_username.Text.Trim(),
                userPassword = HashPassword(txt_HashPassword.Text.Trim()),
                Position = "Admin"
            };
            userController.UpdateUserAccount(user_model);

        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
      
        private void AddVat()
        {
            var _repo = new VatRepository();
            var tax_controller = new VatController(_repo);

            // Safely parse VAT value (NumericUpDown.Value is already decimal)
            int tax_rate = Convert.ToInt32(txt_vat.Value);

            // Build a new model for creation
            var tax_model = new VatModel
            {
                tax = tax_rate
            };

            // Save to database
            tax_controller.CreateTax(tax_model);

          
        }

        private void btn_smtp_next_Click(object sender, EventArgs e)
        {
            if (!SMPTPVALID()) return;

            var _repo = new UserRepository();
            var userController = new UserController(_repo);
            user_id = SaveUser();

            UpdateUserAccount();

            AddVat();

            CreateBusinessHour();

            CreateSMTPSettings();

            // Confirmation dialog
            var result = MessageBox.Show(
                "Settings saved successfully! Do you want to proceed to the login form?",
                "Success",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {

                var form = new LoginForm();
                form.Show();
                this.Hide();
            }


        }
        private void CreateSMTPSettings() 
        {
        var owner_repo = new OwnderEmailRepository();
        var owner_controller = new OwnerEmailController(owner_repo);

            var model = new OwnerEmaillModel
            {
                shop_name = txt_business_name.Text,
                email = txt_email.Text,
                pass = txt_password.Text,

            };
     
            var saved = owner_controller.Create(model);
         
        }
       
        private void CreateBusinessHour() 
        {
            var repo = new BusinessHourRepository();
            var controller = new TimeSlotController(repo);

                var businessHour = new BusinessHour
                {
                    business_hours_id = 0, // Assuming 0 or null for new record, adjust as needed
                    open_time = dtp_opening.Value.TimeOfDay,
                    close_time = dtp_closing.Value.TimeOfDay,
                };
            controller.CreateOrUpdateBusinessHours(businessHour);
        }
        private void btn_add_payment_method_Click(object sender, EventArgs e)
        {
            using (var form = new PaymentMethodForm(this))
            {
                form.ShowDialog();
            }
        }

        private void chk_show_password_CheckedChanged(object sender, EventArgs e)
        {
            txt_HashPassword.UseSystemPasswordChar = !chk_show_password.Checked;
            txt_confirm_password.UseSystemPasswordChar = !chk_show_password.Checked;
        }
    }
}
