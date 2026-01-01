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
            this.btn_apply_discount = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.lbl_item_name = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_qty = new System.Windows.Forms.NumericUpDown();
            this.txt_fixed_amount = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_discount_percent = new System.Windows.Forms.TextBox();
            this.btn_discount_senior = new MaterialSkin.Controls.MaterialButton();
            this.btn_discount_pwd = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_apply_discount
            // 
            this.btn_apply_discount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_apply_discount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_apply_discount.Depth = 0;
            this.btn_apply_discount.HighEmphasis = true;
            this.btn_apply_discount.Icon = null;
            this.btn_apply_discount.Location = new System.Drawing.Point(463, 513);
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
            this.materialButton2.Location = new System.Drawing.Point(629, 513);
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
            // lbl_item_name
            // 
            this.lbl_item_name.AutoSize = true;
            this.lbl_item_name.Depth = 0;
            this.lbl_item_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_item_name.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_item_name.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_item_name.Location = new System.Drawing.Point(25, 25);
            this.lbl_item_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_item_name.Name = "lbl_item_name";
            this.lbl_item_name.Size = new System.Drawing.Size(130, 24);
            this.lbl_item_name.TabIndex = 3;
            this.lbl_item_name.Text = "lbl_item_name";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbl_item_name);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 24);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(25);
            this.materialCard1.Size = new System.Drawing.Size(800, 100);
            this.materialCard1.TabIndex = 4;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(62, 158);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Quantity:";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(417, 158);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(280, 22);
            this.txt_qty.TabIndex = 6;
            this.txt_qty.ValueChanged += new System.EventHandler(this.txt_qty_ValueChanged);
            // 
            // txt_fixed_amount
            // 
            this.txt_fixed_amount.Location = new System.Drawing.Point(417, 256);
            this.txt_fixed_amount.Name = "txt_fixed_amount";
            this.txt_fixed_amount.Size = new System.Drawing.Size(280, 22);
            this.txt_fixed_amount.TabIndex = 7;
            this.txt_fixed_amount.TextChanged += new System.EventHandler(this.txt_fixed_amount_TextChanged_1);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(62, 253);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(256, 24);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Discount Amount P(Amount)";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(62, 348);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(99, 24);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Discount %";
            // 
            // txt_discount_percent
            // 
            this.txt_discount_percent.Location = new System.Drawing.Point(417, 348);
            this.txt_discount_percent.Name = "txt_discount_percent";
            this.txt_discount_percent.Size = new System.Drawing.Size(280, 22);
            this.txt_discount_percent.TabIndex = 10;
            this.txt_discount_percent.TextChanged += new System.EventHandler(this.txt_discount_percent_TextChanged);
            // 
            // btn_discount_senior
            // 
            this.btn_discount_senior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_discount_senior.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_discount_senior.Depth = 0;
            this.btn_discount_senior.HighEmphasis = true;
            this.btn_discount_senior.Icon = null;
            this.btn_discount_senior.Location = new System.Drawing.Point(66, 433);
            this.btn_discount_senior.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_discount_senior.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_discount_senior.Name = "btn_discount_senior";
            this.btn_discount_senior.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_discount_senior.Size = new System.Drawing.Size(73, 36);
            this.btn_discount_senior.TabIndex = 11;
            this.btn_discount_senior.Text = "Senior";
            this.btn_discount_senior.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_discount_senior.UseAccentColor = false;
            this.btn_discount_senior.UseVisualStyleBackColor = true;
            // 
            // btn_discount_pwd
            // 
            this.btn_discount_pwd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_discount_pwd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_discount_pwd.Depth = 0;
            this.btn_discount_pwd.HighEmphasis = true;
            this.btn_discount_pwd.Icon = null;
            this.btn_discount_pwd.Location = new System.Drawing.Point(232, 433);
            this.btn_discount_pwd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_discount_pwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_discount_pwd.Name = "btn_discount_pwd";
            this.btn_discount_pwd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_discount_pwd.Size = new System.Drawing.Size(64, 36);
            this.btn_discount_pwd.TabIndex = 12;
            this.btn_discount_pwd.Text = "PWD";
            this.btn_discount_pwd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_discount_pwd.UseAccentColor = false;
            this.btn_discount_pwd.UseVisualStyleBackColor = true;
            // 
            // DiscountModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btn_discount_pwd);
            this.Controls.Add(this.btn_discount_senior);
            this.Controls.Add(this.txt_discount_percent);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txt_fixed_amount);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.btn_apply_discount);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountModelForm";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscountModelForm";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn_apply_discount;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel lbl_item_name;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.NumericUpDown txt_qty;
        private System.Windows.Forms.TextBox txt_fixed_amount;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txt_discount_percent;
        private MaterialSkin.Controls.MaterialButton btn_discount_senior;
        private MaterialSkin.Controls.MaterialButton btn_discount_pwd;
    }
}