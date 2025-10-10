using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Util
{
    public static class ThemeManager
    {
   
            private static MaterialSkinManager skinManager;

            public static void ApplyTheme(MaterialForm form)
            {
                if (skinManager == null)
                {
                    skinManager = MaterialSkinManager.Instance;
                    skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    skinManager.ColorScheme = new ColorScheme(
                       Primary.DeepPurple500,     // Elegant purple base
                       Primary.DeepPurple700,     // Rich header/nav tone
                       Primary.DeepPurple200,     // Soft accent for controls
                       Accent.Pink200,            // Feminine, vibrant accent
                       TextShade.WHITE            // Clean, readable text
                   );

            }

            skinManager.AddFormToManage(form);
            }

        ////public static Color Primary = ColorTranslator.FromHtml("#2C3E50");
        //public static Color Primary = ColorTranslator.FromHtml("#202225"); // Header
        //public static Color Secondary = ColorTranslator.FromHtml("#363940"); //sidebar
        ////public static Color Secondary = ColorTranslator.FromHtml("#FFFFFF");     // Panels
        //public static Color Content = ColorTranslator.FromHtml("#F4F6F7");       // DataGridView rows
        //public static Color Accent = ColorTranslator.FromHtml("#26C6DA");        // Buttons/icons
        //public static Color Background = ColorTranslator.FromHtml("#202932");    // Window background
        //public static Color TextLight = ColorTranslator.FromHtml("#E0E0E0"); // Light gray (very readable)
        //public static Color Highlight = ColorTranslator.FromHtml("#81D4FA");     // Selection hover/focus
        //public static Color ButtonHover = ColorTranslator.FromHtml("#232426");
        //public static Color ButtonText = ColorTranslator.FromHtml("#CCCCCC");


        public static void StyleDataGridView(DataGridView dgv)
        {
            // Background — soft lavender-gray
            dgv.BackgroundColor = Color.FromArgb(245, 240, 250); // light, elegant base
            dgv.BorderStyle = BorderStyle.None;

            // Column Headers — deep plum with white text
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 51, 153); // rich purple
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Bold);

            // Row Headers — match column headers
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 51, 153);
            dgv.RowHeadersDefaultCellStyle.ForeColor = Color.White;

            // Rows — soft blush with dark text
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 245); // blush pink
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(60, 30, 80);    // deep plum text
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 182, 193); // light rose
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Regular);

            // Grid lines — subtle lavender
            dgv.GridColor = Color.FromArgb(230, 220, 240);

            // Auto sizing for a cleaner look
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        //public static void DatagridViewTheme(DataGridView dgv)
        //{
        //    dgv.EnableHeadersVisualStyles = false;
        //    dgv.RowHeadersVisible = false;

        //    // Grid background and border
        //    dgv.BackgroundColor = Background;
        //    dgv.BorderStyle = BorderStyle.None;
        //    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        //    dgv.GridColor = ButtonHover; // subtle grid lines

        //    // Column headers
        //    dgv.ColumnHeadersDefaultCellStyle.BackColor = Primary;
        //    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // better contrast
        //    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        //    dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        //    // Normal rows
        //    dgv.RowsDefaultCellStyle.BackColor = Secondary;
        //    dgv.RowsDefaultCellStyle.ForeColor = ButtonText;
        //    dgv.RowsDefaultCellStyle.SelectionBackColor = ButtonHover; // better for visibility
        //    dgv.RowsDefaultCellStyle.SelectionForeColor = Color.White;

        //    // Alternating rows
        //    dgv.AlternatingRowsDefaultCellStyle.BackColor = Primary;
        //    dgv.AlternatingRowsDefaultCellStyle.ForeColor = TextLight;
        //    dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = ButtonHover;
        //    dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

        //    // Row headers are hidden, but if shown, style them too
        //    dgv.RowHeadersDefaultCellStyle.BackColor = Primary;
        //    dgv.RowHeadersDefaultCellStyle.ForeColor = ButtonText;
        //}


        //public static void ButtonsTheme(Button btn) 
        //{

        //    btn.BackColor = ThemeManager.Secondary;
        //    btn.ForeColor = ThemeManager.ButtonText;       
        //    btn.FlatAppearance.MouseOverBackColor = ThemeManager.ButtonHover;
        //}



        //public static void LabelTheme(Label lbl)
        //{

        //    lbl.ForeColor = ThemeManager.TextLight;

        //}




    }
}
