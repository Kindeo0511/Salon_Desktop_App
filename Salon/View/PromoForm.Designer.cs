namespace Salon.View
{
    partial class PromoForm
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
            this.cmb_promo = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_apply = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // cmb_promo
            // 
            this.cmb_promo.AutoResize = false;
            this.cmb_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_promo.Depth = 0;
            this.cmb_promo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_promo.DropDownHeight = 174;
            this.cmb_promo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_promo.DropDownWidth = 121;
            this.cmb_promo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_promo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_promo.FormattingEnabled = true;
            this.cmb_promo.Hint = "Select Promo Discount";
            this.cmb_promo.IntegralHeight = false;
            this.cmb_promo.ItemHeight = 43;
            this.cmb_promo.Location = new System.Drawing.Point(72, 110);
            this.cmb_promo.MaxDropDownItems = 4;
            this.cmb_promo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_promo.Name = "cmb_promo";
            this.cmb_promo.Size = new System.Drawing.Size(450, 49);
            this.cmb_promo.StartIndex = 0;
            this.cmb_promo.TabIndex = 0;
            this.cmb_promo.SelectionChangeCommitted += new System.EventHandler(this.cmb_promo_SelectionChangeCommitted);
            // 
            // btn_apply
            // 
            this.btn_apply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_apply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_apply.Depth = 0;
            this.btn_apply.HighEmphasis = true;
            this.btn_apply.Icon = null;
            this.btn_apply.Location = new System.Drawing.Point(243, 223);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_apply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_apply.Size = new System.Drawing.Size(67, 36);
            this.btn_apply.TabIndex = 1;
            this.btn_apply.Text = "apply";
            this.btn_apply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_apply.UseAccentColor = false;
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(445, 223);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(68, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Select Promo:";
            // 
            // PromoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cmb_promo);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PromoForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PromoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmb_promo;
        private MaterialSkin.Controls.MaterialButton btn_apply;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}