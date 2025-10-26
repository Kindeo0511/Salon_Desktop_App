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
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_discount_expiry_date = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel_discount = new MaterialSkin.Controls.MaterialButton();
            this.btn_update_discount = new MaterialSkin.Controls.MaterialButton();
            this.btn_add_discount = new MaterialSkin.Controls.MaterialButton();
            this.txt_promo_code = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_discount_type = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_discount = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_customer_limit = new System.Windows.Forms.NumericUpDown();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sw_send_notif = new MaterialSkin.Controls.MaterialSwitch();
            this.sw_expiry_notif = new MaterialSkin.Controls.MaterialSwitch();
            this.chk_vat_exempt = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_customer_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel29
            // 
            this.materialLabel29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel29.Location = new System.Drawing.Point(660, 245);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(113, 19);
            this.materialLabel29.TabIndex = 17;
            this.materialLabel29.Text = "Expiration Date:";
            // 
            // dtp_discount_expiry_date
            // 
            this.dtp_discount_expiry_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_discount_expiry_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_discount_expiry_date.Location = new System.Drawing.Point(663, 267);
            this.dtp_discount_expiry_date.Name = "dtp_discount_expiry_date";
            this.dtp_discount_expiry_date.Size = new System.Drawing.Size(350, 22);
            this.dtp_discount_expiry_date.TabIndex = 16;
            this.dtp_discount_expiry_date.Visible = false;
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
            this.btn_cancel_discount.Location = new System.Drawing.Point(936, 504);
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
            this.btn_update_discount.Location = new System.Drawing.Point(699, 504);
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
            this.btn_add_discount.Location = new System.Drawing.Point(699, 504);
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
            // txt_promo_code
            // 
            this.txt_promo_code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_promo_code.AnimateReadOnly = false;
            this.txt_promo_code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_promo_code.Depth = 0;
            this.txt_promo_code.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_promo_code.Hint = "Promo Code";
            this.txt_promo_code.LeadingIcon = null;
            this.txt_promo_code.Location = new System.Drawing.Point(60, 237);
            this.txt_promo_code.MaxLength = 50;
            this.txt_promo_code.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_promo_code.Multiline = false;
            this.txt_promo_code.Name = "txt_promo_code";
            this.txt_promo_code.Size = new System.Drawing.Size(350, 50);
            this.txt_promo_code.TabIndex = 12;
            this.txt_promo_code.Text = "";
            this.txt_promo_code.TrailingIcon = null;
            this.txt_promo_code.Visible = false;
            this.txt_promo_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_promo_code_KeyPress);
            // 
            // cmb_discount_type
            // 
            this.cmb_discount_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_discount_type.AutoResize = false;
            this.cmb_discount_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_discount_type.Depth = 0;
            this.cmb_discount_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_discount_type.DropDownHeight = 174;
            this.cmb_discount_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_discount_type.DropDownWidth = 121;
            this.cmb_discount_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_discount_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_discount_type.FormattingEnabled = true;
            this.cmb_discount_type.Hint = "Select Discount Type";
            this.cmb_discount_type.IntegralHeight = false;
            this.cmb_discount_type.ItemHeight = 43;
            this.cmb_discount_type.Items.AddRange(new object[] {
            "Senior/PWD",
            "Promo"});
            this.cmb_discount_type.Location = new System.Drawing.Point(60, 124);
            this.cmb_discount_type.MaxDropDownItems = 4;
            this.cmb_discount_type.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_discount_type.Name = "cmb_discount_type";
            this.cmb_discount_type.Size = new System.Drawing.Size(350, 49);
            this.cmb_discount_type.StartIndex = -1;
            this.cmb_discount_type.TabIndex = 11;
            this.cmb_discount_type.SelectedIndexChanged += new System.EventHandler(this.cmb_discount_type_SelectedIndexChanged);
            // 
            // txt_discount
            // 
            this.txt_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_discount.AnimateReadOnly = false;
            this.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_discount.Depth = 0;
            this.txt_discount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_discount.Hint = "Disocunt (%)";
            this.txt_discount.LeadingIcon = null;
            this.txt_discount.Location = new System.Drawing.Point(663, 126);
            this.txt_discount.MaxLength = 50;
            this.txt_discount.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_discount.Multiline = false;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(350, 50);
            this.txt_discount.TabIndex = 10;
            this.txt_discount.Text = "";
            this.txt_discount.TrailingIcon = null;
            this.txt_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // txt_customer_limit
            // 
            this.txt_customer_limit.Location = new System.Drawing.Point(663, 371);
            this.txt_customer_limit.Name = "txt_customer_limit";
            this.txt_customer_limit.Size = new System.Drawing.Size(350, 22);
            this.txt_customer_limit.TabIndex = 19;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(660, 338);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 21;
            this.materialLabel2.Text = "Customer Limit:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // sw_send_notif
            // 
            this.sw_send_notif.AutoSize = true;
            this.sw_send_notif.Depth = 0;
            this.sw_send_notif.Location = new System.Drawing.Point(60, 428);
            this.sw_send_notif.Margin = new System.Windows.Forms.Padding(0);
            this.sw_send_notif.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sw_send_notif.MouseState = MaterialSkin.MouseState.HOVER;
            this.sw_send_notif.Name = "sw_send_notif";
            this.sw_send_notif.Ripple = true;
            this.sw_send_notif.Size = new System.Drawing.Size(281, 37);
            this.sw_send_notif.TabIndex = 22;
            this.sw_send_notif.Text = "Send Notification when Created";
            this.sw_send_notif.UseVisualStyleBackColor = true;
            // 
            // sw_expiry_notif
            // 
            this.sw_expiry_notif.AutoSize = true;
            this.sw_expiry_notif.Depth = 0;
            this.sw_expiry_notif.Location = new System.Drawing.Point(60, 480);
            this.sw_expiry_notif.Margin = new System.Windows.Forms.Padding(0);
            this.sw_expiry_notif.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sw_expiry_notif.MouseState = MaterialSkin.MouseState.HOVER;
            this.sw_expiry_notif.Name = "sw_expiry_notif";
            this.sw_expiry_notif.Ripple = true;
            this.sw_expiry_notif.Size = new System.Drawing.Size(224, 37);
            this.sw_expiry_notif.TabIndex = 23;
            this.sw_expiry_notif.Text = "Send Expiry Notifcation";
            this.sw_expiry_notif.UseVisualStyleBackColor = true;
            this.sw_expiry_notif.Visible = false;
            // 
            // chk_vat_exempt
            // 
            this.chk_vat_exempt.AutoSize = true;
            this.chk_vat_exempt.Depth = 0;
            this.chk_vat_exempt.Enabled = false;
            this.chk_vat_exempt.Location = new System.Drawing.Point(60, 356);
            this.chk_vat_exempt.Margin = new System.Windows.Forms.Padding(0);
            this.chk_vat_exempt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_vat_exempt.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_vat_exempt.Name = "chk_vat_exempt";
            this.chk_vat_exempt.ReadOnly = false;
            this.chk_vat_exempt.Ripple = true;
            this.chk_vat_exempt.Size = new System.Drawing.Size(187, 37);
            this.chk_vat_exempt.TabIndex = 24;
            this.chk_vat_exempt.Text = "Apply VAT exemption";
            this.chk_vat_exempt.UseVisualStyleBackColor = true;
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.chk_vat_exempt);
            this.Controls.Add(this.sw_expiry_notif);
            this.Controls.Add(this.sw_send_notif);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txt_customer_limit);
            this.Controls.Add(this.materialLabel29);
            this.Controls.Add(this.dtp_discount_expiry_date);
            this.Controls.Add(this.btn_cancel_discount);
            this.Controls.Add(this.btn_update_discount);
            this.Controls.Add(this.btn_add_discount);
            this.Controls.Add(this.txt_promo_code);
            this.Controls.Add(this.cmb_discount_type);
            this.Controls.Add(this.txt_discount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISCOUNT INFORMATION";
            ((System.ComponentModel.ISupportInitialize)(this.txt_customer_limit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel29;
        private System.Windows.Forms.DateTimePicker dtp_discount_expiry_date;
        private MaterialSkin.Controls.MaterialButton btn_cancel_discount;
        private MaterialSkin.Controls.MaterialButton btn_update_discount;
        private MaterialSkin.Controls.MaterialButton btn_add_discount;
        private MaterialSkin.Controls.MaterialTextBox txt_promo_code;
        private MaterialSkin.Controls.MaterialComboBox cmb_discount_type;
        private MaterialSkin.Controls.MaterialTextBox txt_discount;
        private System.Windows.Forms.NumericUpDown txt_customer_limit;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialSwitch sw_send_notif;
        private MaterialSkin.Controls.MaterialSwitch sw_expiry_notif;
        private MaterialSkin.Controls.MaterialCheckbox chk_vat_exempt;
    }
}