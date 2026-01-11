using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class progressForm : MaterialForm
    {
        public event EventHandler CancelRequested;
        public progressForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
        }
        public void SetTitle(string title)
        { 
            this.Text = title;
        }
        public void UpdateStatus(string message)
        {
            lbl_message.Text = message;
            progress_bar.Value = 0;
            timer1.Start(); // start simulating progress

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progress_bar.Value < progress_bar.Maximum)
            {
                progress_bar.Value += 5; // increment by 5 }
            }
        }

        public void Complete(string message = "Backup completed!")
        {
            timer1.Stop();
            progress_bar.Value = progress_bar.Maximum;
            lbl_message.Text = message; 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lbl_message.Text = "Cancelling...";
            CancelRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
