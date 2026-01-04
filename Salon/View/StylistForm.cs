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
    public partial class StylistForm : MaterialForm
    {
        private readonly MainForm _mainForm;
        private StylistModel _stylist;
        private bool _isSaving = false;
        private bool _isUpdating = false;
        public StylistForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isSaving = true;
            _mainForm = mainForm;
            dtp_day_of_birth.MaxDate = DateTime.Today;
            dtp_day_of_birth.MinDate = new DateTime(1900, 1, 1);
        }
        public StylistForm(MainForm mainForm, StylistModel stylist)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isUpdating = true;
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


                btn_save.Visible = false;
                btn_update.Visible = true;

            }
            else
            {
                btn_save.Visible = true;
                btn_update.Visible = false;
            }
        }

        private bool SaveStylist() 
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
     
                
                };

           return stylistController.Add(stylist);
        }

        private bool UpdateStylist()
        {
            if (_stylist == null) return false;

            
            _stylist.firstName = txt_first_name.Text;
            _stylist.middleName = txt_middle_name.Text;
            _stylist.lastName = txt_last_name.Text;
            _stylist.birth_date = dtp_day_of_birth.Value;
            _stylist.contactNumber = txt_contact.Text;
            _stylist.email = txt_email.Text;
            _stylist.address = txt_address.Text;


            var repo = new StylistRepository();
            var stylistController = new Controller.StylistController(repo);

            return stylistController.Update(_stylist);
            
            
        }
        private void IsAccountExists()
        {
            var _repo = new StylistRepository();
            var userController = new StylistController(_repo);
            var existingUser = userController.GetEmail(txt_email.Text.Trim());

            if (existingUser != null)
            {

                if (existingUser.is_deleted == 1)
                {
                    var result = MessageBox.Show("This Stylist exists but is deleted. Do you want to restore it?",
                                   "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                      

                        if (userController.restoreStylist(existingUser.stylist_id))
                        {
                            _mainForm.DeleteDeletedRecord(existingUser.stylist_id);
                            MessageBox.Show("Stylist restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }



                    }
                }
            }

            else
            {
                if (_isSaving)
                {
                    

                    if (SaveStylist())
                    {
                        MessageBox.Show("Stylist added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdating)
                {
                    if (UpdateStylist())
                    {
                        MessageBox.Show("Stylist updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_first_name.Text + " " + txt_last_name.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Stylist", $"Created stylist {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                   
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

        }
        private async  void btn_save_Click(object sender, EventArgs e)
        {


            // Run validation on UI thread
            if (!IsValid()) return;

            IsAccountExists();



            await _mainForm.RefreshStylistAsync(1, 25);



        }

        private async void btn_update_Click(object sender, EventArgs e)
        {


            if (!IsValid()) return;


            IsAccountExists();



            var fullName = txt_first_name.Text + " " + txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Stylist", $"Updated stylist {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            await _mainForm.RefreshStylistAsync(1, 25);
    
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
            // Allows letters, spaces, hyphens, apostrophes, accented characters
            else if (!Validator.Pattern(txt_first_name, errorProvider1, @"^[A-Za-zÀ-ÿ'’\- ]+$", "First Name contains invalid characters."))
            {
                validated = false;
            } 
            else if (!Validator.DisallowSpaces(txt_first_name, errorProvider1, "No Space Allowed"))
            {
                validated = false;
            }


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
            else if (!Validator.Pattern(
                   txt_email,
                   errorProvider1,
                   @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                   "Please enter a valid email address."))
            {
                validated = false;
            }
            else if (!Validator.DisallowSpaces(txt_email, errorProvider1, "No Space Allowed"))
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
            else if (!Validator.MultiLinePattern(txt_address, errorProvider1, @"^[A-Za-z0-9\s.,#-]+$", "Address contains invalid characters."))
            {
                validated = false;
            }


        

         
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

        private void StylistForm_Load(object sender, EventArgs e)
        {

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

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string allowed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";

            if (!char.IsControl(c) && !allowed.Contains(c))
                e.Handled = true;
        }

        private void txt_daily_wage_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Allow digits
            if (char.IsDigit(c))
                return;

            // Allow one decimal point, but not as the first character
            if (c == '.' && txt != null)
            {
                if (!txt.Text.Contains(".") && txt.Text.Length > 0)
                    return;

                e.Handled = true; // Block if already has a decimal or it's first character
                return;
            }

            // Block everything else
            e.Handled = true;
        }

    }
}
