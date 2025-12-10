namespace Salon.View
{
    partial class Process_Walk_In_Payment_Form
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
            this.cb_discount = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_services = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cb_PaymentMethod = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_amount_paid = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Reference = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_date = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_time = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_walk_in_code = new MaterialSkin.Controls.MaterialTextBox();
            this.sw_exempt_vat = new MaterialSkin.Controls.MaterialSwitch();
            this.lbl_change_amount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Total = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Vat = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Discount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Subtotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_tax_rate = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_discount_type = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_confirm_payment = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // cb_discount
            // 
            this.cb_discount.AutoResize = false;
            this.cb_discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_discount.Depth = 0;
            this.cb_discount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_discount.DropDownHeight = 174;
            this.cb_discount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_discount.DropDownWidth = 121;
            this.cb_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_discount.FormattingEnabled = true;
            this.cb_discount.Hint = "Choose Discount";
            this.cb_discount.IntegralHeight = false;
            this.cb_discount.ItemHeight = 43;
            this.cb_discount.Location = new System.Drawing.Point(392, 381);
            this.cb_discount.MaxDropDownItems = 4;
            this.cb_discount.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_discount.Name = "cb_discount";
            this.cb_discount.Size = new System.Drawing.Size(300, 49);
            this.cb_discount.StartIndex = 0;
            this.cb_discount.TabIndex = 30;
            // 
            // txt_services
            // 
            this.txt_services.AnimateReadOnly = true;
            this.txt_services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_services.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_services.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_services.Depth = 0;
            this.txt_services.HideSelection = true;
            this.txt_services.Hint = "Services";
            this.txt_services.Location = new System.Drawing.Point(379, 106);
            this.txt_services.MaxLength = 32767;
            this.txt_services.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_services.Name = "txt_services";
            this.txt_services.PasswordChar = '\0';
            this.txt_services.ReadOnly = true;
            this.txt_services.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_services.SelectedText = "";
            this.txt_services.SelectionLength = 0;
            this.txt_services.SelectionStart = 0;
            this.txt_services.ShortcutsEnabled = true;
            this.txt_services.Size = new System.Drawing.Size(300, 100);
            this.txt_services.TabIndex = 29;
            this.txt_services.TabStop = false;
            this.txt_services.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_services.UseSystemPasswordChar = false;
            // 
            // cb_PaymentMethod
            // 
            this.cb_PaymentMethod.AutoResize = false;
            this.cb_PaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_PaymentMethod.Depth = 0;
            this.cb_PaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_PaymentMethod.DropDownHeight = 174;
            this.cb_PaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PaymentMethod.DropDownWidth = 121;
            this.cb_PaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_PaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_PaymentMethod.FormattingEnabled = true;
            this.cb_PaymentMethod.Hint = "Choose Payment";
            this.cb_PaymentMethod.IntegralHeight = false;
            this.cb_PaymentMethod.ItemHeight = 43;
            this.cb_PaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Gcash"});
            this.cb_PaymentMethod.Location = new System.Drawing.Point(32, 382);
            this.cb_PaymentMethod.MaxDropDownItems = 4;
            this.cb_PaymentMethod.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_PaymentMethod.Name = "cb_PaymentMethod";
            this.cb_PaymentMethod.Size = new System.Drawing.Size(300, 49);
            this.cb_PaymentMethod.StartIndex = -1;
            this.cb_PaymentMethod.TabIndex = 28;
            this.cb_PaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cb_PaymentMethod_SelectedIndexChanged);
            // 
            // txt_amount_paid
            // 
            this.txt_amount_paid.AnimateReadOnly = true;
            this.txt_amount_paid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amount_paid.Depth = 0;
            this.txt_amount_paid.Enabled = false;
            this.txt_amount_paid.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_amount_paid.Hint = "Amount Paid";
            this.txt_amount_paid.LeadingIcon = null;
            this.txt_amount_paid.Location = new System.Drawing.Point(392, 467);
            this.txt_amount_paid.MaxLength = 50;
            this.txt_amount_paid.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_amount_paid.Multiline = false;
            this.txt_amount_paid.Name = "txt_amount_paid";
            this.txt_amount_paid.Size = new System.Drawing.Size(300, 50);
            this.txt_amount_paid.TabIndex = 26;
            this.txt_amount_paid.Text = "";
            this.txt_amount_paid.TrailingIcon = null;
            this.txt_amount_paid.TextChanged += new System.EventHandler(this.txt_amount_paid_TextChanged);
            // 
            // txt_Reference
            // 
            this.txt_Reference.AnimateReadOnly = false;
            this.txt_Reference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Reference.Depth = 0;
            this.txt_Reference.Enabled = false;
            this.txt_Reference.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Reference.Hint = " Reference No.";
            this.txt_Reference.LeadingIcon = null;
            this.txt_Reference.Location = new System.Drawing.Point(32, 467);
            this.txt_Reference.MaxLength = 13;
            this.txt_Reference.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Reference.Multiline = false;
            this.txt_Reference.Name = "txt_Reference";
            this.txt_Reference.Size = new System.Drawing.Size(300, 50);
            this.txt_Reference.TabIndex = 25;
            this.txt_Reference.Text = "";
            this.txt_Reference.TrailingIcon = null;
            // 
            // txt_date
            // 
            this.txt_date.AnimateReadOnly = true;
            this.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_date.Depth = 0;
            this.txt_date.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_date.Hint = "Appointment Date";
            this.txt_date.LeadingIcon = null;
            this.txt_date.Location = new System.Drawing.Point(32, 194);
            this.txt_date.MaxLength = 50;
            this.txt_date.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_date.Multiline = false;
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(300, 50);
            this.txt_date.TabIndex = 24;
            this.txt_date.Text = "";
            this.txt_date.TrailingIcon = null;
            // 
            // txt_time
            // 
            this.txt_time.AnimateReadOnly = true;
            this.txt_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_time.Depth = 0;
            this.txt_time.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_time.Hint = "Time";
            this.txt_time.LeadingIcon = null;
            this.txt_time.Location = new System.Drawing.Point(32, 291);
            this.txt_time.MaxLength = 50;
            this.txt_time.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_time.Multiline = false;
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(300, 50);
            this.txt_time.TabIndex = 23;
            this.txt_time.Text = "";
            this.txt_time.TrailingIcon = null;
            // 
            // txt_walk_in_code
            // 
            this.txt_walk_in_code.AnimateReadOnly = true;
            this.txt_walk_in_code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_walk_in_code.Depth = 0;
            this.txt_walk_in_code.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_walk_in_code.Hint = "Customer Name";
            this.txt_walk_in_code.LeadingIcon = null;
            this.txt_walk_in_code.Location = new System.Drawing.Point(32, 106);
            this.txt_walk_in_code.MaxLength = 50;
            this.txt_walk_in_code.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_walk_in_code.Multiline = false;
            this.txt_walk_in_code.Name = "txt_walk_in_code";
            this.txt_walk_in_code.ReadOnly = true;
            this.txt_walk_in_code.Size = new System.Drawing.Size(300, 50);
            this.txt_walk_in_code.TabIndex = 22;
            this.txt_walk_in_code.Text = "";
            this.txt_walk_in_code.TrailingIcon = null;
            // 
            // sw_exempt_vat
            // 
            this.sw_exempt_vat.AutoSize = true;
            this.sw_exempt_vat.Depth = 0;
            this.sw_exempt_vat.Location = new System.Drawing.Point(830, 106);
            this.sw_exempt_vat.Margin = new System.Windows.Forms.Padding(0);
            this.sw_exempt_vat.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sw_exempt_vat.MouseState = MaterialSkin.MouseState.HOVER;
            this.sw_exempt_vat.Name = "sw_exempt_vat";
            this.sw_exempt_vat.Ripple = true;
            this.sw_exempt_vat.Size = new System.Drawing.Size(145, 37);
            this.sw_exempt_vat.TabIndex = 41;
            this.sw_exempt_vat.Text = "Exempt VAT";
            this.sw_exempt_vat.UseVisualStyleBackColor = true;
            this.sw_exempt_vat.Visible = false;
            // 
            // lbl_change_amount
            // 
            this.lbl_change_amount.AutoSize = true;
            this.lbl_change_amount.Depth = 0;
            this.lbl_change_amount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_change_amount.Location = new System.Drawing.Point(1067, 407);
            this.lbl_change_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_change_amount.Name = "lbl_change_amount";
            this.lbl_change_amount.Size = new System.Drawing.Size(31, 19);
            this.lbl_change_amount.TabIndex = 40;
            this.lbl_change_amount.Text = "0,00";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Depth = 0;
            this.lbl_Total.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Total.Location = new System.Drawing.Point(1067, 344);
            this.lbl_Total.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(31, 19);
            this.lbl_Total.TabIndex = 39;
            this.lbl_Total.Text = "0,00";
            // 
            // lbl_Vat
            // 
            this.lbl_Vat.AutoSize = true;
            this.lbl_Vat.Depth = 0;
            this.lbl_Vat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Vat.Location = new System.Drawing.Point(1067, 288);
            this.lbl_Vat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Vat.Name = "lbl_Vat";
            this.lbl_Vat.Size = new System.Drawing.Size(31, 19);
            this.lbl_Vat.TabIndex = 38;
            this.lbl_Vat.Text = "0,00";
            this.lbl_Vat.Click += new System.EventHandler(this.lbl_Vat_Click);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Depth = 0;
            this.lbl_Discount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Discount.Location = new System.Drawing.Point(1067, 229);
            this.lbl_Discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(31, 19);
            this.lbl_Discount.TabIndex = 37;
            this.lbl_Discount.Text = "0,00";
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Depth = 0;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Subtotal.Location = new System.Drawing.Point(1067, 159);
            this.lbl_Subtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(31, 19);
            this.lbl_Subtotal.TabIndex = 36;
            this.lbl_Subtotal.Text = "0,00";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(843, 407);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 19);
            this.materialLabel5.TabIndex = 35;
            this.materialLabel5.Text = "Change:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(843, 344);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(102, 19);
            this.materialLabel4.TabIndex = 34;
            this.materialLabel4.Text = "Total Amount:";
            // 
            // lbl_tax_rate
            // 
            this.lbl_tax_rate.AutoSize = true;
            this.lbl_tax_rate.Depth = 0;
            this.lbl_tax_rate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_tax_rate.Location = new System.Drawing.Point(843, 288);
            this.lbl_tax_rate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_tax_rate.Name = "lbl_tax_rate";
            this.lbl_tax_rate.Size = new System.Drawing.Size(25, 19);
            this.lbl_tax_rate.TabIndex = 33;
            this.lbl_tax_rate.Text = "Vat";
            // 
            // lbl_discount_type
            // 
            this.lbl_discount_type.AutoSize = true;
            this.lbl_discount_type.Depth = 0;
            this.lbl_discount_type.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_discount_type.Location = new System.Drawing.Point(843, 229);
            this.lbl_discount_type.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_discount_type.Name = "lbl_discount_type";
            this.lbl_discount_type.Size = new System.Drawing.Size(64, 19);
            this.lbl_discount_type.TabIndex = 32;
            this.lbl_discount_type.Text = "Discount";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(843, 158);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 31;
            this.materialLabel1.Text = "Subtotal";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(1061, 555);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 43;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm_payment
            // 
            this.btn_confirm_payment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm_payment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm_payment.Depth = 0;
            this.btn_confirm_payment.HighEmphasis = true;
            this.btn_confirm_payment.Icon = null;
            this.btn_confirm_payment.Location = new System.Drawing.Point(816, 555);
            this.btn_confirm_payment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm_payment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm_payment.Name = "btn_confirm_payment";
            this.btn_confirm_payment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_confirm_payment.Size = new System.Drawing.Size(159, 36);
            this.btn_confirm_payment.TabIndex = 42;
            this.btn_confirm_payment.Text = "confirm payment";
            this.btn_confirm_payment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm_payment.UseAccentColor = false;
            this.btn_confirm_payment.UseVisualStyleBackColor = true;
            // 
            // Process_Walk_In_Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm_payment);
            this.Controls.Add(this.sw_exempt_vat);
            this.Controls.Add(this.lbl_change_amount);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Vat);
            this.Controls.Add(this.lbl_Discount);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lbl_tax_rate);
            this.Controls.Add(this.lbl_discount_type);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cb_discount);
            this.Controls.Add(this.txt_services);
            this.Controls.Add(this.cb_PaymentMethod);
            this.Controls.Add(this.txt_amount_paid);
            this.Controls.Add(this.txt_Reference);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_walk_in_code);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Process_Walk_In_Payment_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROCESS PAYMENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cb_discount;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_services;
        private MaterialSkin.Controls.MaterialComboBox cb_PaymentMethod;
        private MaterialSkin.Controls.MaterialTextBox txt_amount_paid;
        private MaterialSkin.Controls.MaterialTextBox txt_Reference;
        private MaterialSkin.Controls.MaterialTextBox txt_date;
        private MaterialSkin.Controls.MaterialTextBox txt_time;
        private MaterialSkin.Controls.MaterialTextBox txt_walk_in_code;
        private MaterialSkin.Controls.MaterialSwitch sw_exempt_vat;
        private MaterialSkin.Controls.MaterialLabel lbl_change_amount;
        private MaterialSkin.Controls.MaterialLabel lbl_Total;
        private MaterialSkin.Controls.MaterialLabel lbl_Vat;
        private MaterialSkin.Controls.MaterialLabel lbl_Discount;
        private MaterialSkin.Controls.MaterialLabel lbl_Subtotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lbl_tax_rate;
        private MaterialSkin.Controls.MaterialLabel lbl_discount_type;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_confirm_payment;
    }
}