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
using System.Windows.Controls;
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

  


        private void btn_personal_tab_next_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex < materialTabControl1.TabCount - 1)
            {
                materialTabControl1.SelectedIndex++; // move forward }
                
            }
        }

        private void btn_account_tab_back_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex > 0)
            {
                materialTabControl1.SelectedIndex--; // move backward }
            }
        }

        private void btn_account_tab_next_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex < materialTabControl1.TabCount - 1)
            {
                materialTabControl1.SelectedIndex++; // move forward }

            }
        }

        private void btn_vat_tab_back_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex > 0)
            {
                materialTabControl1.SelectedIndex--; // move backward }
            }
        }

        private void btn_vat_tab_next_Click(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedIndex < materialTabControl1.TabCount - 1)
            {
                materialTabControl1.SelectedIndex++; // move forward }

            }
        }

        
    }
}
