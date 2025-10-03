using MaterialSkin;
using MaterialSkin.Controls;
using Salon.View;
using System;

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
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
