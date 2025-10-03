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
using Salon.Util;
namespace Salon.View
{
    public partial class OverHeadAndTotalWorkingHoursForm : MaterialForm
    {
        private MainForm mainForm;
        public OverHeadAndTotalWorkingHoursForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;

            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OverHeadAndTotalWorkingHoursForm_Load(object sender, EventArgs e)
        {

        }
    }
}
