namespace Salon.View
{
    partial class DiscountForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_cancel_discount = new MaterialSkin.Controls.MaterialButton();
            this.btn_update_discount = new MaterialSkin.Controls.MaterialButton();
            this.btn_add_discount = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmb_discount_type = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_discount = new System.Windows.Forms.NumericUpDown();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_promo_name = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.rad_percent = new System.Windows.Forms.RadioButton();
            this.rad_fixed = new System.Windows.Forms.RadioButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.chk_vat_exempt = new System.Windows.Forms.CheckBox();
            this.chk_is_active = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel_discount
            // 
            this.btn_cancel_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_discount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel_discount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel_discount.Depth = 0;
            this.btn_cancel_discount.HighEmphasis = true;
            this.btn_cancel_discount.Icon = null;
            this.btn_cancel_discount.Location = new System.Drawing.Point(759, 505);
            this.btn_cancel_discount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel_discount.Name = "btn_cancel_discount";
            this.btn_cancel_discount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel_discount.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel_discount.TabIndex = 15;
            this.btn_cancel_discount.Text = "cancel";
            this.btn_cancel_discount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel_discount.UseAccentColor = false;
            this.btn_cancel_discount.UseVisualStyleBackColor = true;
            this.btn_cancel_discount.Click += new System.EventHandler(this.btn_cancel_discount_Click);
            // 
            // btn_update_discount
            // 
            this.btn_update_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_discount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_discount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update_discount.Depth = 0;
            this.btn_update_discount.HighEmphasis = true;
            this.btn_update_discount.Icon = null;
            this.btn_update_discount.Location = new System.Drawing.Point(509, 505);
            this.btn_update_discount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update_discount.Name = "btn_update_discount";
            this.btn_update_discount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update_discount.Size = new System.Drawing.Size(152, 36);
            this.btn_update_discount.TabIndex = 14;
            this.btn_update_discount.Text = "Update Discount";
            this.btn_update_discount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update_discount.UseAccentColor = false;
            this.btn_update_discount.UseVisualStyleBackColor = true;
            this.btn_update_discount.Visible = false;
            this.btn_update_discount.Click += new System.EventHandler(this.btn_update_discount_Click);
            // 
            // btn_add_discount
            // 
            this.btn_add_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_discount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_discount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_discount.Depth = 0;
            this.btn_add_discount.HighEmphasis = true;
            this.btn_add_discount.Icon = null;
            this.btn_add_discount.Location = new System.Drawing.Point(509, 505);
            this.btn_add_discount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_discount.Name = "btn_add_discount";
            this.btn_add_discount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_discount.Size = new System.Drawing.Size(126, 36);
            this.btn_add_discount.TabIndex = 13;
            this.btn_add_discount.Text = "Add Discount";
            this.btn_add_discount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_discount.UseAccentColor = false;
            this.btn_add_discount.UseVisualStyleBackColor = true;
            this.btn_add_discount.Click += new System.EventHandler(this.btn_add_discount_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // cmb_discount_type
            // 
            this.cmb_discount_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_discount_type.FormattingEnabled = true;
            this.cmb_discount_type.Items.AddRange(new object[] {
            "Free",
            "Promo",
            "PWD",
            "Senior"});
            this.cmb_discount_type.Location = new System.Drawing.Point(409, 99);
            this.cmb_discount_type.Name = "cmb_discount_type";
            this.cmb_discount_type.Size = new System.Drawing.Size(389, 24);
            this.cmb_discount_type.Sorted = true;
            this.cmb_discount_type.TabIndex = 25;
            this.cmb_discount_type.SelectedIndexChanged += new System.EventHandler(this.cmb_discount_type_SelectedIndexChanged_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(57, 113);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "Discount Type:";
            // 
            // txt_discount
            // 
            this.txt_discount.DecimalPlaces = 2;
            this.txt_discount.Location = new System.Drawing.Point(409, 232);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(389, 22);
            this.txt_discount.TabIndex = 27;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(57, 181);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 19);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "Name:";
            // 
            // txt_promo_name
            // 
            this.txt_promo_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_promo_name.Location = new System.Drawing.Point(409, 158);
            this.txt_promo_name.Name = "txt_promo_name";
            this.txt_promo_name.Size = new System.Drawing.Size(389, 22);
            this.txt_promo_name.TabIndex = 29;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(57, 247);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 30;
            this.materialLabel4.Text = "Discount:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(57, 303);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Type:";
            // 
            // rad_percent
            // 
            this.rad_percent.AutoSize = true;
            this.rad_percent.BackColor = System.Drawing.Color.Transparent;
            this.rad_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_percent.Location = new System.Drawing.Point(409, 301);
            this.rad_percent.Name = "rad_percent";
            this.rad_percent.Size = new System.Drawing.Size(115, 24);
            this.rad_percent.TabIndex = 32;
            this.rad_percent.TabStop = true;
            this.rad_percent.Text = "Percentage";
            this.rad_percent.UseVisualStyleBackColor = false;
            // 
            // rad_fixed
            // 
            this.rad_fixed.AutoSize = true;
            this.rad_fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_fixed.Location = new System.Drawing.Point(666, 301);
            this.rad_fixed.Name = "rad_fixed";
            this.rad_fixed.Size = new System.Drawing.Size(132, 24);
            this.rad_fixed.TabIndex = 33;
            this.rad_fixed.TabStop = true;
            this.rad_fixed.Text = "Fixed Amount";
            this.rad_fixed.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(57, 366);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 19);
            this.materialLabel5.TabIndex = 34;
            this.materialLabel5.Text = "Vat Exempt:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(57, 433);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(48, 19);
            this.materialLabel6.TabIndex = 35;
            this.materialLabel6.Text = "Active:";
            // 
            // chk_vat_exempt
            // 
            this.chk_vat_exempt.AutoSize = true;
            this.chk_vat_exempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_vat_exempt.Location = new System.Drawing.Point(409, 366);
            this.chk_vat_exempt.Name = "chk_vat_exempt";
            this.chk_vat_exempt.Size = new System.Drawing.Size(18, 17);
            this.chk_vat_exempt.TabIndex = 37;
            this.chk_vat_exempt.UseVisualStyleBackColor = true;
            // 
            // chk_is_active
            // 
            this.chk_is_active.AutoSize = true;
            this.chk_is_active.Location = new System.Drawing.Point(409, 434);
            this.chk_is_active.Name = "chk_is_active";
            this.chk_is_active.Size = new System.Drawing.Size(18, 17);
            this.chk_is_active.TabIndex = 38;
            this.chk_is_active.UseVisualStyleBackColor = true;
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.chk_is_active);
            this.Controls.Add(this.chk_vat_exempt);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.rad_fixed);
            this.Controls.Add(this.rad_percent);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txt_promo_name);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmb_discount_type);
            this.Controls.Add(this.btn_cancel_discount);
            this.Controls.Add(this.btn_update_discount);
            this.Controls.Add(this.btn_add_discount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISCOUNT INFORMATION";
            this.Load += new System.EventHandler(this.DiscountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn_cancel_discount;
        private MaterialSkin.Controls.MaterialButton btn_update_discount;
        private MaterialSkin.Controls.MaterialButton btn_add_discount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmb_discount_type;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.NumericUpDown txt_discount;
        private System.Windows.Forms.TextBox txt_promo_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.RadioButton rad_fixed;
        private System.Windows.Forms.RadioButton rad_percent;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.CheckBox chk_vat_exempt;
        private System.Windows.Forms.CheckBox chk_is_active;
    }
}