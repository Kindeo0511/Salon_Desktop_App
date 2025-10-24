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
using Salon.Models;

namespace Salon.View
{
    public partial class StylistForm : MaterialForm
    {
        private readonly MainForm _mainForm;
        private StylistModel _stylist;
        public StylistForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;
            dtp_day_of_birth.MaxDate = DateTime.Today;
            dtp_day_of_birth.MinDate = new DateTime(1900, 1, 1);
        }
        public StylistForm(MainForm mainForm, StylistModel stylist)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _mainForm = mainForm;
            _stylist = stylist;
            dtp_day_of_birth.MaxDate = DateTime.Today;
            dtp_day_of_birth.MinDate = new DateTime(1900, 1, 1);

            if (_stylist != null)
            {
                txt_first_name.Text = _stylist.firstName;
                txt_middle_name.Text = _stylist.middleName;
                txt_last_name.Text = _stylist.lastName;
                dtp_day_of_birth.Value = _stylist.birth_date;
                txt_contact.Text = _stylist.contactNumber;
                txt_email.Text = _stylist.email;
                txt_address.Text = _stylist.address;
                txt_daily_wage.Text = _stylist.daily_wage.ToString();

                btn_save.Visible = false;
                btn_update.Visible = true;

            }
            else
            {
                btn_save.Visible = true;
                btn_update.Visible = false;
            }
        }

        private void SaveStylist() 
        {
            var repo = new StylistRepository();
            var stylistController = new Controller.StylistController(repo);
            var stylist = new StylistModel 
            {
                firstName = txt_first_name.Text,
                middleName = txt_middle_name.Text,
                lastName = txt_last_name.Text,
                birth_date = dtp_day_of_birth.Value,
                contactNumber = txt_contact.Text,
                email = txt_email.Text,
                address = txt_address.Text,
                daily_wage = Convert.ToDecimal(txt_daily_wage.Text)
                
                };

            stylistController.Add(stylist);
        }

        private void UpdateStylist()
        {
            if (_stylist != null) 
            {
            _stylist.firstName = txt_first_name.Text;
            _stylist.middleName = txt_middle_name.Text;
            _stylist.lastName = txt_last_name.Text;
            _stylist.birth_date = dtp_day_of_birth.Value;
            _stylist.contactNumber = txt_contact.Text;
            _stylist.email = txt_email.Text;
            _stylist.address = txt_address.Text;
            _stylist.daily_wage = Convert.ToDecimal(txt_daily_wage.Text);

            var repo = new StylistRepository();
            var stylistController = new Controller.StylistController(repo);
            stylistController.Update(_stylist);
            }
            
        }

        private async  void btn_save_Click(object sender, EventArgs e)
        {


            // Run validation on UI thread
            if (!IsValid()) return;
        

            MessageBox.Show("Stylist added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SaveStylist();
            var fullName = txt_first_name.Text + " " + txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Stylist", $"Created stylist {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            await _mainForm.RefreshStylistAsync();
      
            this.Close();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {


            if (!IsValid()) return;
         

            MessageBox.Show("Stylist updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateStylist();
            var fullName = txt_first_name.Text + " " + txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Stylist", $"Updated stylist {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            await _mainForm.RefreshStylistAsync();
            this.Close();
        }

        private bool IsValid()
        {
            DateTime birthDate = dtp_day_of_birth.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            int excludeId = _stylist?.stylist_id ?? 0;

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
            else if (!Validator.IsStylistEmailExists(txt_email, errorProvider1, "Email already exists.", excludeId))
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
            else if (!Validator.IsStylistPhoneExists(txt_contact, errorProvider1, "Contact number already exists.", excludeId))
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


            if (!Validator.IsRequiredTextField(txt_daily_wage, errorProvider1, "Daily wage is required."))
            {
                validated = false;
            }
            else
            {
                if (decimal.TryParse(txt_daily_wage.Text.Trim(), out decimal wage))
                {
                    if (wage <= 0)
                    {
                        errorProvider1.SetError(txt_daily_wage, "Daily wage must be greater than zero.");
                        validated = false;
                    }
                    else if (wage > 10000) 
                    {
                        errorProvider1.SetError(txt_daily_wage, "Daily wage seems unusually high. Please double-check.");
                        validated = false;
                    }
                    else
                    {
                        errorProvider1.SetError(txt_daily_wage, "");
                    }
                }
                else
                {
                    errorProvider1.SetError(txt_daily_wage, "Daily wage must be a valid number.");
                    validated = false;
                }
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


            return validated;



        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
