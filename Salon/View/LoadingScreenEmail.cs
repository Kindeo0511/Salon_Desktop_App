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
namespace Salon.View
{
    public partial class LoadingScreenEmail : MaterialForm
    {
        public LoadingScreenEmail()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
