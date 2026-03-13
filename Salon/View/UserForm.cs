using MaterialSkin.Controls;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Salon.View
{
    public partial class UserForm : MaterialForm
    {
        private MainForm _mainForm;
        private UsersModel _user;
        private int user_id;
        private bool _isViewed = false;
        private bool _isSaving = false;
        private bool _isUpdating = false;

        public UserForm(MainForm mainForm)
        {
            InitializeComponent();
         
            ThemeManager.ApplyTheme(this);
            _isSaving = true;
            this._mainForm = mainForm;
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

            this.AcceptButton = btn_save;
            btn_cancel.DialogResult = DialogResult.Cancel;

            LoadRole();

          



        }
        public UserForm(MainForm mainForm, UsersModel user)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
      
            this._mainForm = mainForm;
            this._user = user;
            int currentYear = DateTime.Now.Year; 

            int minYear = currentYear - 65; // Oldest allowed: 65 years old
            int maxYear = currentYear - 18; // Youngest allowed: 18 years old

            dtp_day_of_birth.MinDate = new DateTime(minYear, 1, 1);      // e.g., Jan 1, 1960 if it's 2025
            dtp_day_of_birth.MaxDate = new DateTime(maxYear, 12, 31);    // e.g., Dec 31, 2007 if it's 2025


            _isUpdating = true;

            if (_user != null)
            {

                PopulateRoleComboBox(_user, cmb_role);
                user_id = _user.user_id;
                txt_first_name.Text = _user.first_Name;
                txt_middle_name.Text = _user.middle_Name;
                txt_last_name.Text = _user.last_Name;
                dtp_day_of_birth.Value = _user.birth_date;
                txt_contact.Text = _user.phone_Number;
                txt_email.Text = _user.email;
                txt_address.Text = _user.address;
                txt_username.Text = _user.userName;
                cmb_role.Text = _user.Position;

                if (_user.Position == "Admin" && UserSession.CurrentUser.Position == "Super Admin")
                {
                    cmb_role.Enabled = true;
                }
                else if (_user.Position == "Super Admin" && UserSession.CurrentUser.Position == "Super Admin")
                {
                    cmb_role.Enabled = false;
                }
                else if (_user.Position == "Admin" && UserSession.CurrentUser.Position == "Admin")
                {
                    cmb_role.Enabled = false;
                }
                else 
                {
                    cmb_role.Enabled = true;
                }

                btn_save.Visible = false;
                btn_update.Visible = true;



            }
            else
            {
                btn_save.Visible = true;
                btn_update.Visible = false;

           
            }

            this.AcceptButton = btn_update;

        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public UserForm(MainForm mainForm, UsersModel user, bool isViewed)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this._mainForm = mainForm;
            this._user = user;
            this._isViewed = isViewed;

            PopulateRoleComboBox(_user,cmb_role);

            if (_isViewed)
            {
                txt_first_name.ReadOnly = true;
                txt_middle_name.ReadOnly = true;
                txt_last_name.ReadOnly = true;
                dtp_day_of_birth.Enabled = false;
                txt_contact.ReadOnly = true;
                txt_email.ReadOnly = true;
                txt_address.ReadOnly = true;
                txt_username.ReadOnly = true;
                txt_password.ReadOnly = true;
                txt_confirm_password.ReadOnly = true;
                btn_save.Visible = false;
                btn_update.Visible = false;
                chk_show_password.ReadOnly = true;
                cmb_role.Enabled = false;

                user_id = _user.user_id;
                txt_first_name.Text = _user.first_Name;
                txt_middle_name.Text = _user.middle_Name;
                txt_last_name.Text = _user.last_Name;
                dtp_day_of_birth.Value = _user.birth_date;
                txt_contact.Text = _user.phone_Number;
                txt_email.Text = _user.email;
                txt_address.Text = _user.address;
                txt_username.Text = _user.userName;
                txt_password.Text = _user.userPassword;
                txt_confirm_password.Text = _user.userPassword;
                cmb_role.Text = _user.Position;

                btn_save.Visible = false;
                btn_update.Visible = false;
                btn_cancel.Visible = true;





                this.AcceptButton = btn_update;
            }

        }

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
                userName = txt_username.Text.Trim(),
                userPassword = HashPassword(txt_password.Text.Trim()),
                Position = cmb_role.Text.Trim()


        };
            var _repo = new UserRepository();
            var userController = new UserController(_repo);

     
           user_id =  userController.AddUser(user); 

           return user_id;

        }
        private bool UpdateUser()
        {
            var _repo = new UserRepository();
            var userController = new UserController(_repo);

            if(_user == null) return false;

            string password = string.IsNullOrWhiteSpace(txt_password.Text)
                               ? _user.userPassword                       
                               : HashPassword(txt_password.Text.Trim());       


            var user = new UsersModel
            {
                user_id = user_id,
                first_Name = txt_first_name.Text.Trim(),
                middle_Name = txt_middle_name.Text.Trim(),
                last_Name = txt_last_name.Text.Trim(),
                birth_date = dtp_day_of_birth.Value,
                phone_Number = txt_contact.Text.Trim(),
                email = txt_email.Text.Trim(),
                address = txt_address.Text.Trim(),
                userName = txt_username.Text.Trim(),
                userPassword = password,
                Position = cmb_role.Text.Trim()


            };


            try 
            { 
                return userController.UpdateUser(user);
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Update failed: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool HasChanges()
        {
            return txt_first_name.Text != _user.first_Name
                || txt_middle_name.Text != _user.middle_Name
                || txt_last_name.Text != _user.last_Name
                || dtp_day_of_birth.Value != _user.birth_date
                || txt_contact.Text != _user.phone_Number
                || txt_email.Text != _user.email
                || txt_address.Text != _user.address
                || txt_username.Text != _user.userName
                || !string.IsNullOrWhiteSpace(txt_password.Text)
                || cmb_role.Text != _user.Position;
        }

        public UsersModel UserModel() 
        {


            var userModel = new UsersModel
            {

                email = InputSanitizer.Email(txt_email.Text),
                birth_date = dtp_day_of_birth.Value,
                phone_Number = InputSanitizer.Phone(txt_contact.Text),
                userName = InputSanitizer.Username(txt_username.Text),

            };


            return userModel;
        }

        private async Task<bool> IsAccountAlreadyExistsButDeleted() 
        {
            int deactivated_user_id = UserAccountExistsDeactivated(UserModel());

            if (deactivated_user_id > 0)
            {
                // check deactivated FIRST before checking if username exists
                var result = MessageBox.Show("This account exists but is deactivated. Do you want to restore it?",
                                "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                   await RestorDeactivatedAccount(deactivated_user_id);

                }
             
            }
            return deactivated_user_id > 0;
        }
        private bool IsValid()
        {
            DateTime birthDate = dtp_day_of_birth.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            int excludeId = _user?.user_id ?? 0;
       
            bool validated = true;

            // REQUIRED AND MIN LENGTH FIELD
            string firstName = txt_first_name.Text.Trim();


           

            // First Name
            if (!Validator.IsRequiredTextField(txt_first_name, errorProvider1, "First name is required."))
                validated = false;
            else if (!Validator.IsMinimumLength(txt_first_name, errorProvider1, "First name must be at least 3 characters.", 3))
                validated = false;
            else if (!Validator.Pattern(
                txt_first_name,
                errorProvider1,
                @"^[A-Za-z]+(?: [A-Za-z]+)*$",
                "First name should only contain letters and no special characters."))
                validated = false;

            // Middle Name (optional)
            if (!string.IsNullOrWhiteSpace(txt_middle_name.Text))
            {
                if (!Validator.IsMinimumLength(txt_middle_name, errorProvider1, "Middle name must be at least 2 characters.", 2))
                    validated = false;
                else if (!Validator.Pattern(
                    txt_middle_name,
                    errorProvider1,
                    @"^[A-Za-z]+(?: [A-Za-z]+)*$",
                    "Middle name should only contain letters and no special characters."))
                    validated = false;
            }


            // Last Name
            if (!Validator.IsRequiredTextField(txt_last_name, errorProvider1, "Last name is required."))
                validated = false;
            else if (!Validator.IsMinimumLength(txt_last_name, errorProvider1, "Last name must be at least 2 characters.", 2))
                validated = false;
            else if (!Validator.Pattern(
                txt_last_name,
                errorProvider1,
                @"^[A-Za-z]+(?: [A-Za-z]+)*$",
                "Last name should only contain letters and no special characters."))
                validated = false;




            if (!Validator.IsRequired(txt_email, errorProvider1, "Email is required."))
            {
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

            else if (!Validator.IsEmailExists(txt_email, errorProvider1, "Email already exists.", excludeId))
            {
                validated = false;
            }






            if (!Validator.IsRequiredTextField(txt_contact, errorProvider1, "Contact number is required."))
            {
                validated = false;
            }
            else if (!Validator.Pattern(
                txt_contact,
                errorProvider1,
                @"^09\d{9}$",
                "Contact number must start with '09' and be exactly 11 digits long with no spaces or symbols."))
            {
                validated = false;
            }
            else if (!Validator.IsPhoneExists(txt_contact, errorProvider1, "Contact number already exists.", excludeId))
            {
                validated = false;
            }



            //if (!Validator.IsAddressRequiredField(txt_address, errorProvider1, "Address is required."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsMinimumLength(txt_address, errorProvider1, "Address must be at least 10 characters.", 10))
            //{
            //    validated = false;
                        //}
            //else if (!Validator.MultiLinePattern(
            //    txt_address,
            //    errorProvider1,
            //    @"^[A-Za-z0-9\s.,\-#]+$",
            //    "Address may only contain letters, numbers, commas, periods, dashes, and #. Avoid special characters."))
//{
            //    validated = false;
            //}


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

            // Address
            if (string.IsNullOrWhiteSpace(txt_address.Text))
            {
                errorProvider1.SetError(txt_address, "Address is required.");
                validated = false;
            }
            else 
            {
                errorProvider1.SetError(txt_address, "");
            }
            // Username
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                errorProvider1.SetError(txt_username, "Username is required.");
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_username, errorProvider1, "Username must be at least 4 characters.", 4))
            {
                validated = false;
            }
           
            else if (!Validator.IsUserExists(txt_username, errorProvider1, "Username already exists.", excludeId))
            {
                // then check if active username exists
                validated = false;
            }
            else
            {
                errorProvider1.SetError(txt_username, "");
            }

            // Password & Confirm Password

            if (_isUpdating)
            {
                if (!Validator.IsMinimumLength(txt_password, errorProvider1, "Password must be at least 8 characters.", 8))
                {
                    validated = false;
                }
                else
                {
                    errorProvider1.SetError(txt_password, "");
                }

                if (txt_confirm_password.Text != txt_password.Text)
                {
                    errorProvider1.SetError(txt_confirm_password, "Passwords do not match.");
                    validated = false;
                }
                else
                {
                    errorProvider1.SetError(txt_confirm_password, "");
                }

            }
            else 
            {
                if (string.IsNullOrWhiteSpace(txt_password.Text))
                {
                    errorProvider1.SetError(txt_password, "Password is required.");
                    validated = false;
                }
            }
           
          
            // Role
            if (string.IsNullOrWhiteSpace(cmb_role.Text))
            {
                errorProvider1.SetError(cmb_role, "Role is required.");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(cmb_role, "");
            }






            ////ACCOUNT VALIDATION
            //if (!Validator.IsRequiredTextField(txt_username, errorProvider1, "Username is required."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsMinimumLength(txt_username, errorProvider1, "Username must be at least 4 characters.", 4))
            //{
            //    validated = false;
            //}
            //else if (!Validator.Pattern(
            //    txt_username,
            //    errorProvider1,
            //    @"^[A-Za-z0-9]+$",
            //    "Username must only contain letters and numbers. No spaces or special characters allowed."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsUserExists(txt_username, errorProvider1, "Username already exists.", excludeId))
            //{
            //    validated = false;
            //}




            ////Password validation
            //if (!Validator.IsRequiredTextField(txt_password, errorProvider1, "Password is required."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsMinimumLength(txt_password, errorProvider1, "Password must be at least 8 characters.", 8))
            //{
            //    validated = false;
            //}
            //else if (!Validator.DisallowSpaces(txt_password, errorProvider1, "Password should not contain spaces."))
            //{

            //    validated = false;
            //}
            //else if (!Validator.Pattern(
            //    txt_password,
            //    errorProvider1,
            //    @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*()_+\-=!?\u005F]).{8,}$",
            //    "Password must include uppercase, lowercase, number, and a special character (@ # $ % ^ & * ( ) _ + - = ! ?)."))
            //{
            //    validated = false;
            //}


            //// Confirm password validation
            //if (!Validator.IsRequiredTextField(txt_confirm_password, errorProvider1, "Confirm password is required."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsMinimumLength(txt_confirm_password, errorProvider1, "Confirm password must be at least 8 characters.", 8))
            //{
            //    validated = false;
            //}
            //else if (!Validator.DisallowSpaces(txt_confirm_password, errorProvider1, "Confirm password should not contain spaces."))
            //{

            //    validated = false;
            //}
            //else if (txt_password.Text != txt_confirm_password.Text)
            //{
            //    errorProvider1.SetError(txt_confirm_password, "Passwords must match exactly.");
            //    validated = false;
            //}




            //validated &= Validator.IsUserExists(txt_username, errorProvider1, "Username already exists.", excludeId);
            //if (emailValid)
            //    validated &= Validator.IsEmailExists(txt_email, errorProvider1, "Email already exists.", excludeId);

            //if (phoneValid)
            //    validated &= Validator.IsPhoneExists(txt_contact, errorProvider1, "Contact number already exists.", excludeId);

            return validated;



        }

        private bool IsValidAccount()
        {
            int excludeId = _user?.user_id ?? 0;
            bool validated = true;
            //ACCOUNT VALIDATION
            if (!Validator.IsRequiredTextField(txt_username, errorProvider1, "Username is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_username, errorProvider1, "Username must be at least 4 characters.", 4))
            {
                validated = false;
            }
            else if (!Validator.Pattern(
                txt_username,
                errorProvider1,
                @"^[A-Za-z0-9]+$",
                "Username must only contain letters and numbers. No spaces or special characters allowed."))
            {
                validated = false;
            }
            else if (!Validator.IsUserExists(txt_username, errorProvider1, "Username already exists.", excludeId))
            {
                validated = false;
            }

        

            // Check if password is empty
            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                validated = false;

                errorProvider1.SetError(txt_password, "Password cannot be empty.");

            }

            // Check if confirm password is empty
            else if (string.IsNullOrWhiteSpace(txt_confirm_password.Text))
            {
                validated = false;
                errorProvider1.SetError(txt_confirm_password, "Confirm Password cannot be empty.");
            }

            // Check if passwords match
            else if (txt_password.Text != txt_confirm_password.Text)
            {
                validated = false;
                errorProvider1.SetError(txt_confirm_password, "Passwords do not match.");

            }




            ////Password validation
            //if (!Validator.IsRequiredTextField(txt_password, errorProvider1, "Password is required."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsMinimumLength(txt_password, errorProvider1, "Password must be at least 8 characters.", 8))
            //{
            //    validated = false;
            //}
            //else if (!Validator.DisallowSpaces(txt_password, errorProvider1, "Password should not contain spaces."))
            //{

            //    validated = false;
            //}
            //else if (!Validator.Pattern(
            //    txt_password,
            //    errorProvider1,
            //    @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*()_+\-=!?\u005F]).{8,}$",
            //    "Password must include uppercase, lowercase, number, and a special character (@ # $ % ^ & * ( ) _ + - = ! ?)."))
            //{
            //    validated = false;
            //}


            //// Confirm password validation
            //if (!Validator.IsRequiredTextField(txt_confirm_password, errorProvider1, "Confirm password is required."))
            //{
            //    validated = false;
            //}
            //else if (!Validator.IsMinimumLength(txt_confirm_password, errorProvider1, "Confirm password must be at least 8 characters.", 8))
            //{
            //    validated = false;
            //}
            //else if (!Validator.DisallowSpaces(txt_confirm_password, errorProvider1, "Confirm password should not contain spaces."))
            //{

            //    validated = false;
            //}
            //else if (txt_password.Text != txt_confirm_password.Text)
            //{
            //    errorProvider1.SetError(txt_confirm_password, "Passwords must match exactly.");
            //    validated = false;
            //}


            return validated; 
        }





        private void UserForm_Load(object sender, EventArgs e)
        {
            cmb_role.MouseWheel += Helper.ComboBox_MouseWheel;

        }
        private void LoadRole() 
        {
            cmb_role.Items.Clear();

            var currentUser = UserSession.CurrentUser; // static reference

            if (currentUser.Position == "Super Admin")
            {
               
                cmb_role.Items.Add("Admin");
                cmb_role.Items.Add("Staff");
            }
            else if (currentUser.Position == "Admin")
            {

                cmb_role.Items.Add("Staff");
            }
           


        }
        private void PopulateRoleComboBox(UsersModel targetUser, MaterialComboBox comboBoxRoles)
        {
            comboBoxRoles.Items.Clear();

            var currentUser = UserSession.CurrentUser; // static reference

            if (currentUser.Position == "Super Admin")
            {
                // If Super Admin is updating their own account, include Super Admin
                if (currentUser.user_id == targetUser.user_id)
                {
                    comboBoxRoles.Items.Add("Super Admin");
                }

                // Super Admin can always assign Admin and Staff
                comboBoxRoles.Items.Add("Admin");
                comboBoxRoles.Items.Add("Staff");
            }
            else if (currentUser.Position == "Admin")
            {
                if (currentUser.user_id == targetUser.user_id)
                {
                    comboBoxRoles.Items.Add("Admin");
                }
                comboBoxRoles.Items.Add("Staff");
            }
            else if (currentUser.Position == "Admin") 
            {
                comboBoxRoles.Items.Add("Staff");
            }
          
        }

        private void chk_show_password_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_show_password_CheckedChanged_1(object sender, EventArgs e)
        {
        
            txt_password.UseSystemPasswordChar = !chk_show_password.Checked;
            txt_confirm_password.UseSystemPasswordChar = !chk_show_password.Checked;
     

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
          
            this.Close();

        }
        private void Clear() 
        {
            txt_first_name.Text = string.Empty;
            txt_middle_name.Text = string.Empty;
            txt_last_name.Text = string.Empty;
            txt_contact.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_confirm_password.Text = string.Empty;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           

        }

        private void txt_first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
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
            MaterialTextBox txt = sender as MaterialTextBox;
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
            MaterialTextBox txt = sender as MaterialTextBox;
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

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string allowed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 .,-";

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

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string allowed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";

            if (!char.IsControl(c) && !allowed.Contains(c))
                e.Handled = true;
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Allow letters, digits, underscore, hyphen, dot
            if (char.IsLetterOrDigit(c) || c == '_' || c == '-' || c == '.')
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Block space
            if (char.IsWhiteSpace(c))
            {
                e.Handled = true;
                return;
            }

            // Allow letters, digits, and common symbols
            if (char.IsLetterOrDigit(c) || "!@#$%^&*()-_=+[]{}|;:',.<>?/".Contains(c))
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_confirm_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Block space
            if (char.IsWhiteSpace(c))
            {
                e.Handled = true;
                return;
            }

            // Allow letters, digits, and common symbols
            if (char.IsLetterOrDigit(c) || "!@#$%^&*()-_=+[]{}|;:',.<>?/".Contains(c))
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null || string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider1.SetError(txt, "Password is required.");
                e.Cancel = true;
                return;
            }

            if (txt.Text.Length < 8)
            {
                errorProvider1.SetError(txt, "Password must be at least 8 characters.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt, ""); // Clear error
            }
        }

        
        public int UserAccountExistsDeactivated(UsersModel model)
        {
            var _repo = new UserRepository();
            var userController = new UserController(_repo);
            int user_id = userController.IsUserAccountExistsButDeactivated(model);

      
            return user_id;

        }

        public async Task RestorDeactivatedAccount(int user_id) 
        {
            var _repo = new UserRepository();
            var userController = new UserController(_repo);

            int rowAffected = userController.RestoreUserAccount(user_id);

            if (rowAffected > 0)
            {
                _mainForm.DeleteDeletedRecord(user_id);
                MessageBox.Show("Account restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 await _mainForm.RefreshUsersAsync(1, 25);
                this.Close();

            }


            
        }
        private void IsAccountExists()
        {

                if (_isSaving)
                {
                    int result = SaveUser();

                    if (result > 0)
                    {
                        MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdating) 
                {
                
                    if (UpdateUser())
                    {
                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



            }

            

        }
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (await IsAccountAlreadyExistsButDeleted()) return;

            if (!IsValid()) return;

            IsAccountExists();



            string fullName = txt_first_name.Text + " " + txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage User", $"Created new user for {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            //await _mainForm.RefreshAuditLog();
          
 
            await _mainForm.RefreshUsersAsync(1,25);
      
            btn_save.Enabled = true;
            _isSaving = false;
            this.Close();
           
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            btn_update.Enabled = false;


            if (!IsValid())
            {

                btn_update.Enabled = true;
                return;
            }
            if (!HasChanges())
            {
                MessageBox.Show("No changes detected.",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
                return;
            }

            IsAccountExists();


            // Offload only the save logic

            string fullName = txt_first_name.Text + " " + txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage User", $"Updated user {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            Clear();

            await _mainForm.RefreshUsersAsync(1, 25);
            await _mainForm.RefreshAuditLog();

            this.Close();



            btn_update.Enabled = true;
        }
      

     

        private void btn_save_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_update_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btn_update.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                //btn_update_account.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_account_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
