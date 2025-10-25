using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class LoadingScreenControl : UserControl
    {
        public LoadingScreenControl()
        {
            InitializeComponent();
        }

        private void LoadingScreenControl_Load(object sender, EventArgs e)
        {

        }
  

        public void ShowOverlay()
        {
            this.Visible = true;
            this.BringToFront();
        }

        public void HideOverlay()
        {
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
