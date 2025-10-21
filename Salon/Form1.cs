﻿using MaterialSkin;
using MaterialSkin.Controls;
using MySqlX.XDevAPI;
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Util;
using Salon.View;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Salon
{

    public partial class Form1 : MaterialForm
    {
        

        public Form1()
        {
            InitializeComponent();
    

        

            ThemeManager.ApplyTheme(this);

            

           
        }

      

       

       

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            var repo = new UserRepository();
            var controller = new UserController(repo);
            lbl_progress_bar.Increment(2);
            

            if (lbl_progress_bar.Value == 100) 
            {
                timer1.Enabled = false;

                if (!controller.CheckAdminExists())
                {
                    var form = new ConfigureSettingsForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    var form = new LoginForm();
                    form.Show();
                    this.Hide();
                }

            }

        }

        private void lbl_progress_bar_Click(object sender, EventArgs e)
        {

        }
    }
    


}

