using MaterialSkin;
using MaterialSkin.Controls;
using MySqlX.XDevAPI;
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Util;
using Salon.View;
using System;
using System.Windows.Forms;

namespace Salon
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.DARK;
            skin.ColorScheme = new ColorScheme(
                             Primary.BlueGrey800,   // App bar / header background (dark neutral)
                             Primary.BlueGrey900,   // Darker tone for depth
                             Primary.BlueGrey500,   // Lighter tone for contrast
                             Accent.LightBlue200,   // Accent (buttons, highlights, checkboxes)
                             TextShade.WHITE        // White text for readability
                         );
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            log_in();
        }

        private void log_in() 
        {
            string username = txt_user_name.Text.Trim();
            string password = txt_password.Text.Trim();
            var repo = new UserRepository();
            var controler = new UserController(repo);
            var user = controler.GetUserAndPass(username, password);

            if (user != null)
            {
                // ✅ Success: proceed to dashboard
                UserSession.CurrentUser = user;
                MessageBox.Show($"Welcome {user.userName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // ❌ Failure: show error
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

       

        private void chk_show_password_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_password.Password = !chk_show_password.Checked;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
    


}

