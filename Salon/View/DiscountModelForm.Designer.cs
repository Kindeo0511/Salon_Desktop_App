namespace Salon.View
{
    partial class DiscountModelForm
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
            this.cmb_discount = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_apply_discount = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // cmb_discount
            // 
            this.cmb_discount.AutoResize = false;
            this.cmb_discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_discount.Depth = 0;
            this.cmb_discount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_discount.DropDownHeight = 174;
            this.cmb_discount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_discount.DropDownWidth = 121;
            this.cmb_discount.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_discount.FormattingEnabled = true;
            this.cmb_discount.Hint = "Select Discount";
            this.cmb_discount.IntegralHeight = false;
            this.cmb_discount.ItemHeight = 43;
            this.cmb_discount.Location = new System.Drawing.Point(86, 93);
            this.cmb_discount.MaxDropDownItems = 4;
            this.cmb_discount.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_discount.Name = "cmb_discount";
            this.cmb_discount.Size = new System.Drawing.Size(377, 49);
            this.cmb_discount.StartIndex = 0;
            this.cmb_discount.TabIndex = 0;
            // 
            // btn_apply_discount
            // 
            this.btn_apply_discount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_apply_discount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_apply_discount.Depth = 0;
            this.btn_apply_discount.HighEmphasis = true;
            this.btn_apply_discount.Icon = null;
            this.btn_apply_discount.Location = new System.Drawing.Point(300, 187);
            this.btn_apply_discount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_apply_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_apply_discount.Name = "btn_apply_discount";
            this.btn_apply_discount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_apply_discount.Size = new System.Drawing.Size(86, 36);
            this.btn_apply_discount.TabIndex = 1;
            this.btn_apply_discount.Text = "Confirm";
            this.btn_apply_discount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_apply_discount.UseAccentColor = false;
            this.btn_apply_discount.UseVisualStyleBackColor = true;
            this.btn_apply_discount.Click += new System.EventHandler(this.btn_apply_discount_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(457, 187);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(77, 36);
            this.materialButton2.TabIndex = 2;
            this.materialButton2.Text = "cancel";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(83, 71);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Discount";
            // 
            // DiscountModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(541, 232);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.btn_apply_discount);
            this.Controls.Add(this.cmb_discount);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountModelForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscountModelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmb_discount;
        private MaterialSkin.Controls.MaterialButton btn_apply_discount;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}