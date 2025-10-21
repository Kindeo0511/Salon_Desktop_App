using MaterialSkin.Controls;
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
using System.Windows.Forms;
namespace Salon.View
{
    public partial class ConfigureSettingsForm : MaterialForm
    {
        public ConfigureSettingsForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void materialTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Cancel tab selection if triggered by user click
            if (e.Action == TabControlAction.Selecting)
            {
                e.Cancel = true;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (!IsValidUser()) return;

            materialTabControl1.Selecting -= materialTabControl1_Selecting;
            materialTabControl1.SelectedIndex = 1;
            materialTabControl1.Selecting += materialTabControl1_Selecting;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            materialTabControl1.Selecting -= materialTabControl1_Selecting;
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Selecting += materialTabControl1_Selecting;
        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private void SaveUser()
        {
            var user = new UsersModel
            {
                first_Name = txt_first_name.Text,
                middle_Name = txt_middle_name.Text,
                last_Name = txt_last_name.Text,
                birth_date = dtp_day_of_birth.Value,
                phone_Number = txt_contact.Text,
                email = txt_email.Text,
                address = txt_address.Text,
                userName = txt_username.Text,
                userPassword = HashPassword(txt_password.Text.Trim()),
                Position = "Admin",
            };
            var _repo = new UserRepository();
            var userController = new UserController(_repo);


            userController.AddUser(user);

        }
        private void SaveVat() 
        {
      
            var _repo = new VatRepository();
            var tax_controller = new VatController(_repo);
            var tax_exists = tax_controller.checkTax();

            int tax_rate = Convert.ToInt32(txt_vat.Text.Trim());
       
         
                var tax_model = new VatModel
                {
                    tax = tax_rate
                };
              
                tax_controller.CreateTax(tax_model);
                Audit.AuditLog(
                   DateTime.Now,
                   "Create",
                   txt_first_name.Text,
                   "Vat/Discount",
                   $"Created Vat with rate '{tax_rate}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
               );
            
        }
        
        private void SaveUtil() 
        {
            decimal month_rent = 0;
            decimal electric_bill = 0;
            decimal water_bill = 0;
            decimal internet_bill = 0;
            decimal other_bill = 0;
            string notes_bill = "";
            decimal total_cost = 0;
            int total_working_hrs = 0;


            decimal.TryParse(txt_month_rent.Text, out month_rent);
            decimal.TryParse(txt_electric_bill.Text, out electric_bill);
            decimal.TryParse(txt_water_bill.Text, out water_bill);
            decimal.TryParse(txt_internet_bill.Text, out internet_bill);
            decimal.TryParse(txt_other_bill.Text, out other_bill);
            decimal.TryParse(lbl_total_cost.Text, out total_cost);
            int.TryParse(txt_working_hours.Text, out total_working_hrs);

            notes_bill = txt_bill_note.Text;

            var repo = new OverHeadRepository();
            var controller = new OverHeadController(repo);

            var model = new OverHeadModel
            {
                monthly_rent = month_rent,
                electricity_bill = electric_bill,
                water_bill = water_bill,
                internet_bill = internet_bill,
                other_bill = other_bill,
                notes = notes_bill,
                total_over_head = total_cost,
                total_working_hours = total_working_hrs,

            };

            controller.Add(model);
            AddOrUpdateExpense("Utilities", "Created Monthly Rent & Bills", total_cost, txt_first_name.Text, "", DateTime.Now);
        
        }
        private bool IsValidUser()
        {
            DateTime birthDate = dtp_day_of_birth.Value;
            int age = DateTime.Now.Year - birthDate.Year;

            bool validated = true;

            // REQUIRED AND MIN LENGTH FIELD
            if (!Validator.IsRequiredTextField(txt_first_name, errorProvider1, "First name is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_first_name, errorProvider1, "First name must be at least 3 characters.", 3))
            {
                validated = false;
            }

            if (!string.IsNullOrWhiteSpace(txt_middle_name.Text))
            {
                validated &= Validator.IsMinimumLength(txt_middle_name, errorProvider1, "Middle name must be at least 3 characters.", 3);
            }

            if (!Validator.IsRequiredTextField(txt_last_name, errorProvider1, "Last name is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_last_name, errorProvider1, "Last name must be at least 3 characters.", 3))
            {
                validated = false;
            }

            if (!Validator.IsRequired(txt_email, errorProvider1, "Email is required."))
            {
                validated = false;
            }
            else if (!Validator.IsValidEmail(txt_email, errorProvider1))
            {
                validated = false;
            }
     



            if (!Validator.IsRequiredTextField(txt_contact, errorProvider1, "Contact number is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_contact, errorProvider1, "Contact number must be at least 11 characters.", 11))
            {
                validated = false;
            }
            else if (!Validator.IsValidPhone(txt_contact, errorProvider1))
            {
                validated = false;
            }
     


            if (!Validator.IsAddressRequiredField(txt_address, errorProvider1, "Address is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_address, errorProvider1, "Address must be at least 10 characters.", 10))
            {
                validated = false;
            }

            // Adjust if birthday hasn't occurred yet this year
            if (birthDate > DateTime.Now.AddYears(-age))
            {
                age--;
            }

            if (age < 18)
            {
                errorProvider1.SetError(dtp_day_of_birth, "Must be 18+ years old.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(dtp_day_of_birth, "");
            }







            // ACCOUNT VALIDATION
            if (!Validator.IsRequiredTextField(txt_username, errorProvider1, "Username is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_username, errorProvider1, "Username must be at least 5 characters.", 5))
            {
                validated = false;
            }
        


            if (!Validator.IsRequiredTextField(txt_password, errorProvider1, "Password is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_password, errorProvider1, "Password must be at least 8 characters.", 8))
            {
                validated = false;
            }

            if (!Validator.IsRequiredTextField(txt_confirm_password, errorProvider1, "Confirm password is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_confirm_password, errorProvider1, "Confirm password must be at least 8 characters.", 8))
            {
                validated = false;
            }



            //validated &= Validator.IsUserExists(txt_username, errorProvider1, "Username already exists.", excludeId);
            //if (emailValid)
            //    validated &= Validator.IsEmailExists(txt_email, errorProvider1, "Email already exists.", excludeId);

            //if (phoneValid)
            //    validated &= Validator.IsPhoneExists(txt_contact, errorProvider1, "Contact number already exists.", excludeId);

            return validated;



        }
        private bool OverHeadValidated()
        {

            bool validated = true;
            // REQUIRED FIELD

            // PRICE
            if (!Validator.DecimalOnly(txt_month_rent, errorProvider1,
                "Monthly rent is required.",
                "No spaces allowed.",
                "Monthly rent must be a valid number.",
                "Monthly rent must be at least 1.00."))
            {
                validated = false;
            }
            if (!Validator.DecimalOnly(txt_electric_bill, errorProvider1,
            "Electric bill is required.",
            "No spaces allowed.",
            "Electric bill must be a valid number.",
            "Electric bill must be at least 1.00."))
            {
                validated = false;
            }
            if (!Validator.DecimalOnly(txt_water_bill, errorProvider1,
            "Water bill is required.",
            "No spaces allowed.",
            "Water bill be a valid number.",
            "Water bill be at least 1.00."))
            {
                validated = false;
            }
            if (!Validator.DecimalOnly(txt_internet_bill, errorProvider1,
            "Internet bill is required.",
            "No spaces allowed.",
            "Internet bill must be a valid number.",
            "Internet bill must be at least 1.00."))
            {
                validated = false;
            }

            if (!Validator.IntOnly(txt_working_hours, errorProvider1, "Working hours is required.", "No spaces allowed.", "Working hours must be a whole number.", "Working hours must be greater than zero."))
            {
                validated = false;
            }

            if (!string.IsNullOrWhiteSpace(txt_bill_note.Text))
            {
                if (!Validator.IsMinimumLength(txt_bill_note, errorProvider1, "Notes must be at least 5 characters.", 5))
                {
                    validated = false;
                }
                else if (!Validator.MultiLinePattern(txt_bill_note, errorProvider1, @"^[A-Za-z0-9\s]+$", "Notes can only contain letters, numbers, and spaces."))
                {
                    validated = false;
                }

            }




            return validated;


        }
        private bool IsValidVat() 
        {
            bool validated = true;

            if (!Validator.IntOnly(txt_vat, errorProvider1, "Vat is required.", "No spaces allowed.", "Vat must be a whole number.", "Vat must be greater than zero."))
            {
                validated = false;
            }

            return validated;
        }
        private void AddOrUpdateExpense(string category, string description, decimal amount, string paid_by, string notes, DateTime timestamp)
        {
            var repo = new ExpensesRepository();
            var controller = new ExpensesController(repo);

            var model = new ExpensesModel
            {
                category = category,
                description = description,
                amount = amount,
                paid_by = paid_by,
                notes = notes,
                timestamp = timestamp
            };

           
            
                controller.AddExpenses(model);
            

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!OverHeadValidated()) return;

            if (!IsValidVat()) return;

            SaveUser();
            SaveVat();
            SaveUtil();

            var form = new LoginForm();
            form.Show();
            this.Hide();
     


        }
        private void CalculateTotal()
        {
            decimal total_util = 0;
            decimal month_rent = 0;
            decimal electric_bill = 0;
            decimal water_bill = 0;
            decimal internet_bill = 0;
            decimal other_bill = 0;

            decimal.TryParse(txt_month_rent.Text, out month_rent);
            decimal.TryParse(txt_electric_bill.Text, out electric_bill);
            decimal.TryParse(txt_water_bill.Text, out water_bill);
            decimal.TryParse(txt_internet_bill.Text, out internet_bill);
            decimal.TryParse(txt_other_bill.Text, out other_bill);

            total_util = electric_bill + water_bill + internet_bill + other_bill;
            decimal total_cost = month_rent + total_util;
            lbl_total_cost.Text = total_cost.ToString("N2");
        }

        private void txt_month_rent_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txt_electric_bill_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txt_water_bill_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txt_internet_bill_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txt_other_bill_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
    }
}
