namespace Salon.View
{
    partial class POS_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_back = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_back.Depth = 0;
            this.btn_back.HighEmphasis = true;
            this.btn_back.Icon = null;
            this.btn_back.Location = new System.Drawing.Point(27, 40);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_back.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_back.Name = "btn_back";
            this.btn_back.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_back.Size = new System.Drawing.Size(158, 36);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "BACK";
            this.btn_back.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_back.UseAccentColor = false;
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // POS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "POS_Form";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_back;
    }
}