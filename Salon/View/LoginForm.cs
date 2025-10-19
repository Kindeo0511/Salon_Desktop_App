using MaterialSkin.Controls;
using Salon.Controller;
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
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => txt_user_name.Focus()));
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
            var user = controler.AuthenticateUser(username, password);

            if (user != null)
            {
                // ✅ Success: proceed to dashboard
                UserSession.CurrentUser = user;
                MessageBox.Show($"Welcome {user.userName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Audit.AuditLog(
                      DateTime.Now,
                      "Log In",
                      UserSession.CurrentUser.first_Name,
                      "User",
                      $"Log In '{UserSession.CurrentUser.first_Name}'on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
                  );
                var form = new MainForm(this);
                form.ShowDialog();
                this.Hide();
                //this.Close();




            }
            else
            {
                // ❌ Failure: show error
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void chk_show_password_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.Password = !chk_show_password.Checked;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lnk_forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form = new ForgotPasswordForm(this);
            
                form.Show();
              
            
        }
    }
}
