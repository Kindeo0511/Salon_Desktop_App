using Google.Protobuf.WellKnownTypes;
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
using System.Xml.Linq;
namespace Salon.View
{
    public partial class UtilityForm : MaterialForm
    {
        private MainForm mainForm;
        private UtilityModel model;
        public UtilityForm(MainForm main)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = main;
        }
        public UtilityForm(MainForm main, UtilityModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = main;
            this.model = model;

            if (model != null) 
            {
                txt_utility_name.Text = model.util_name;
                txt_amount.Text = model.util_text.ToString();
                btn_add.Visible = false;
                btn_update.Visible = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SaveUtility(txt_utility_name.Text, txt_amount.Text);
            mainForm.LoadUtility();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveUtility(string name, string value) 
        {
            decimal text = decimal.Parse(value);
            var repo = new UtilityRepository();
            var controller = new UtilController(repo);
            var model = new UtilityModel 
            {
                util_name = name,
                util_text = text,
            };
            controller.AddUtility(model);
        }

        private void UpdateUtility(string name, string value)
        {
            decimal text = decimal.Parse(value);
            var repo = new UtilityRepository();
            var controller = new UtilController(repo);

            model.util_name = name;
            model.util_text = text;
            controller.UpdateUtility(model);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateUtility(txt_utility_name.Text, txt_amount.Text);
            mainForm.LoadUtility();
            this.Close();
        }
    }
}
