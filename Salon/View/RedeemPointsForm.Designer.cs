namespace Salon.View
{
    partial class RedeemPointsForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_points = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(41, 48);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Loyalty Points:";
            // 
            // txt_points
            // 
            this.txt_points.AnimateReadOnly = false;
            this.txt_points.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_points.Depth = 0;
            this.txt_points.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_points.LeadingIcon = null;
            this.txt_points.Location = new System.Drawing.Point(45, 84);
            this.txt_points.MaxLength = 50;
            this.txt_points.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_points.Multiline = false;
            this.txt_points.Name = "txt_points";
            this.txt_points.Size = new System.Drawing.Size(400, 50);
            this.txt_points.TabIndex = 1;
            this.txt_points.Text = "";
            this.txt_points.TrailingIcon = null;
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(45, 199);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_confirm.Size = new System.Drawing.Size(86, 36);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "confirm";
            this.btn_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm.UseAccentColor = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(368, 199);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // RedeemPointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_points);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RedeemPointsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedeemPointsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_points;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
    }
}