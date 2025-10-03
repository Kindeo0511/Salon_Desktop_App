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
        private bool _isViewed;
        public UserForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this._mainForm = mainForm;

        }
        public UserForm(MainForm mainForm, UsersModel user)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this._mainForm = mainForm;
            this._user = user;

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
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveUser();
            _mainForm.LoadUser();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateUser();
            _mainForm.LoadUser();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
           
        }

    
    }
}
