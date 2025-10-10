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
    public partial class UserForm : MaterialForm
    {
        private MainForm _mainForm;
        private UsersModel _user;
        private bool _isViewed = false;
        private bool _isSaving = false;
        public UserForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this._mainForm = mainForm;
            dtp_day_of_birth.MaxDate = DateTime.Today;
            dtp_day_of_birth.MinDate = new DateTime(1900, 1, 1);

        }
        public UserForm(MainForm mainForm, UsersModel user)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this._mainForm = mainForm;
            this._user = user;
            dtp_day_of_birth.MaxDate = DateTime.Today;
            dtp_day_of_birth.MinDate = new DateTime(1900, 1, 1);

            if (_user != null)
            {
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

                btn_save.Visible = false;
                btn_update.Visible = true;

            }
            else
            {
                btn_save.Visible = true;
                btn_update.Visible = false;
            }
        }
        public UserForm(MainForm mainForm, UsersModel user, bool isViewed)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this._mainForm = mainForm;
            this._user = user;
            this._isViewed = isViewed;


            if (_isViewed)
            {
                txt_first_name.Enabled = false;
                txt_middle_name.Enabled = false;
                txt_last_name.Enabled = false;
                dtp_day_of_birth.Enabled = false;
                txt_contact.Enabled = false;
                txt_email.Enabled = false;
                txt_address.Enabled = false;
                txt_username.Enabled = false;
                txt_password.Enabled = false;
                txt_confirm_password.Enabled = false;
                btn_save.Visible = false;
                btn_update.Visible = false;
                chk_show_password.Enabled = false;

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

                btn_save.Visible = false;
                btn_update.Visible = false;
                btn_cancel.Visible = false;
            }

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
                userPassword = txt_password.Text,
                Position = "Staff",
            };
            var _repo = new UserRepository();
            var userController = new UserController(_repo);

     
            userController.AddUser(user); 

        }
        private void UpdateUser()
        {
            if (_user != null)
            {
                _user.first_Name = txt_first_name.Text;
                _user.middle_Name = txt_middle_name.Text;
                _user.last_Name = txt_last_name.Text;
                _user.birth_date = dtp_day_of_birth.Value;
                _user.phone_Number = txt_contact.Text;
                _user.email = txt_email.Text;
                _user.address = txt_address.Text;
                _user.userName = txt_username.Text;
                _user.userPassword = txt_password.Text;
                var _repo = new UserRepository();
                var userController = new UserController(_repo);
                userController.UpdateUser(_user);
            }
        }
        private bool Validated()
        {

            bool validated = true;
            // REQUIRED FIELD
            validated &= Validator.IsRequired(txt_first_name, errorProvider1,"First name is required.");
            validated &= Validator.IsRequired(txt_middle_name, errorProvider1, "Middle name is required.");
            validated &= Validator.IsRequired(txt_last_name, errorProvider1, "Last name is required.");
            validated &= Validator.IsRequired(txt_email, errorProvider1, "Email is required.");
            validated &= Validator.IsRequired(txt_contact, errorProvider1, "Contact number is required.");
            validated &= Validator.IsRequired(txt_address, errorProvider1, "Address is required.");

            // VALID EMAIL
            bool emailValid = Validator.IsValidEmail(txt_email, errorProvider1);
            validated &= emailValid;

            // VALID PHONE
            bool phoneValid = Validator.IsValidPhone(txt_contact, errorProvider1);
            validated &= phoneValid;



            // ACCOUNT VALIDATION
            
            validated &= Validator.IsRequired(txt_username, errorProvider1, "Username is required.");
            validated &= Validator.IsRequired(txt_password, errorProvider1, "Password is required.");
            validated &= Validator.IsRequired(txt_confirm_password, errorProvider1, "Confirm password is required.");
            validated &= Validator.MinLength(txt_password, errorProvider1, 8, "Password must be at least 8 characters..");
            validated &= Validator.MinLength(txt_confirm_password, errorProvider1, 8, "Confirm password must be at least 8 characters..");

            // EXISTS VALIDATION
            int excludeId = _user?.user_id ?? 0;

       
            validated &= Validator.IsUserExists(txt_username, errorProvider1, "Username already exists.", excludeId);
            if (emailValid)
                validated &= Validator.IsEmailExists(txt_email, errorProvider1, "Email already exists.", excludeId);

            if (phoneValid)
                validated &= Validator.IsPhoneExists(txt_contact, errorProvider1, "Contact number already exists.", excludeId);

            return validated;



        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            _isSaving = true;

            btn_save.Enabled = false;

            // Run validation on UI thread
            if (!Validated())
            {
               
                btn_save.Enabled = true;
                _isSaving = false;

                return;
            }
          

            SaveUser();
            string fullName = txt_first_name.Text +" "+ txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage User", $"Created new user for {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            Clear();
            _mainForm.LoadUser();
            this.Close();
            btn_save.Enabled = true;
            _isSaving = false;



        }


        private  void btn_update_Click(object sender, EventArgs e)
        {

            btn_update.Enabled = false;

            // Run validation on UI thread
            if (!Validated())
            {
          
                btn_update.Enabled = true;
                return;
            }

          


            // Offload only the save logic
             UpdateUser();
            string fullName = txt_first_name.Text + " " + txt_last_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage User", $"Updated user {fullName} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            Clear();
            _mainForm.LoadUser();
            this.Close();


     
            btn_update.Enabled = true;
     ;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
           
        }

        private void chk_show_password_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_show_password_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_password.Password = !chk_show_password.Checked;
            txt_confirm_password.Password = !chk_show_password.Checked;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (_isSaving)
            {
                MessageBox.Show("Please wait for the save operation to complete.");
                return;
            }

            this.Close();


        }
        private void Clear() 
        {
            txt_first_name.Text = string.Empty;
            txt_middle_name.Text = string.Empty;
            txt_last_name.Text = string.Empty;
            dtp_day_of_birth.Value = DateTime.Today;
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
    }
}
