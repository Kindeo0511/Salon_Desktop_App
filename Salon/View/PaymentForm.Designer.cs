namespace Salon.View
{
    partial class PaymentForm
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
            this.lbl_CustomerName = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_Time = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_Date = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Reference = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_amount_paid = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_book_type = new MaterialSkin.Controls.MaterialTextBox();
            this.cb_PaymentMethod = new MaterialSkin.Controls.MaterialComboBox();
            this.lbl_Services = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_discount_type = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_tax_rate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_change_amount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Total = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Vat = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Discount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Subtotal = new MaterialSkin.Controls.MaterialLabel();
            this.btn_confirm_payment = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.cb_discount = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_invoice = new MaterialSkin.Controls.MaterialButton();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.dgv_Table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AnimateReadOnly = false;
            this.lbl_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_CustomerName.Depth = 0;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_CustomerName.Hint = "Customer Name";
            this.lbl_CustomerName.LeadingIcon = null;
            this.lbl_CustomerName.Location = new System.Drawing.Point(47, 96);
            this.lbl_CustomerName.MaxLength = 50;
            this.lbl_CustomerName.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_CustomerName.Multiline = false;
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(300, 50);
            this.lbl_CustomerName.TabIndex = 0;
            this.lbl_CustomerName.Text = "";
            this.lbl_CustomerName.TrailingIcon = null;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AnimateReadOnly = false;
            this.lbl_Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Time.Depth = 0;
            this.lbl_Time.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Time.Hint = "Time";
            this.lbl_Time.LeadingIcon = null;
            this.lbl_Time.Location = new System.Drawing.Point(47, 281);
            this.lbl_Time.MaxLength = 50;
            this.lbl_Time.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Time.Multiline = false;
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(300, 50);
            this.lbl_Time.TabIndex = 1;
            this.lbl_Time.Text = "";
            this.lbl_Time.TrailingIcon = null;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AnimateReadOnly = false;
            this.lbl_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Date.Depth = 0;
            this.lbl_Date.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Date.Hint = "Appointment Date";
            this.lbl_Date.LeadingIcon = null;
            this.lbl_Date.Location = new System.Drawing.Point(47, 184);
            this.lbl_Date.MaxLength = 50;
            this.lbl_Date.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Date.Multiline = false;
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(300, 50);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "";
            this.lbl_Date.TrailingIcon = null;
            // 
            // txt_Reference
            // 
            this.txt_Reference.AnimateReadOnly = false;
            this.txt_Reference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Reference.Depth = 0;
            this.txt_Reference.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Reference.Hint = " Reference No.";
            this.txt_Reference.LeadingIcon = null;
            this.txt_Reference.Location = new System.Drawing.Point(47, 457);
            this.txt_Reference.MaxLength = 50;
            this.txt_Reference.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Reference.Multiline = false;
            this.txt_Reference.Name = "txt_Reference";
            this.txt_Reference.Size = new System.Drawing.Size(300, 50);
            this.txt_Reference.TabIndex = 4;
            this.txt_Reference.Text = "";
            this.txt_Reference.TrailingIcon = null;
            // 
            // txt_amount_paid
            // 
            this.txt_amount_paid.AnimateReadOnly = false;
            this.txt_amount_paid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amount_paid.Depth = 0;
            this.txt_amount_paid.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_amount_paid.Hint = "Amount Paid";
            this.txt_amount_paid.LeadingIcon = null;
            this.txt_amount_paid.Location = new System.Drawing.Point(407, 457);
            this.txt_amount_paid.MaxLength = 50;
            this.txt_amount_paid.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_amount_paid.Multiline = false;
            this.txt_amount_paid.Name = "txt_amount_paid";
            this.txt_amount_paid.Size = new System.Drawing.Size(300, 50);
            this.txt_amount_paid.TabIndex = 5;
            this.txt_amount_paid.Text = "";
            this.txt_amount_paid.TrailingIcon = null;
            this.txt_amount_paid.TextChanged += new System.EventHandler(this.txt_amount_paid_TextChanged);
            // 
            // lbl_book_type
            // 
            this.lbl_book_type.AnimateReadOnly = false;
            this.lbl_book_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_book_type.Depth = 0;
            this.lbl_book_type.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_book_type.Hint = "Booking Type:";
            this.lbl_book_type.LeadingIcon = null;
            this.lbl_book_type.Location = new System.Drawing.Point(407, 95);
            this.lbl_book_type.MaxLength = 50;
            this.lbl_book_type.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_book_type.Multiline = false;
            this.lbl_book_type.Name = "lbl_book_type";
            this.lbl_book_type.Size = new System.Drawing.Size(300, 50);
            this.lbl_book_type.TabIndex = 6;
            this.lbl_book_type.Text = "";
            this.lbl_book_type.TrailingIcon = null;
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
            this.cb_PaymentMethod.Location = new System.Drawing.Point(47, 372);
            this.cb_PaymentMethod.MaxDropDownItems = 4;
            this.cb_PaymentMethod.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_PaymentMethod.Name = "cb_PaymentMethod";
            this.cb_PaymentMethod.Size = new System.Drawing.Size(300, 49);
            this.cb_PaymentMethod.StartIndex = -1;
            this.cb_PaymentMethod.TabIndex = 7;
            // 
            // lbl_Services
            // 
            this.lbl_Services.AnimateReadOnly = false;
            this.lbl_Services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbl_Services.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lbl_Services.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_Services.Depth = 0;
            this.lbl_Services.HideSelection = true;
            this.lbl_Services.Hint = "Services";
            this.lbl_Services.Location = new System.Drawing.Point(407, 175);
            this.lbl_Services.MaxLength = 32767;
            this.lbl_Services.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Services.Name = "lbl_Services";
            this.lbl_Services.PasswordChar = '\0';
            this.lbl_Services.ReadOnly = false;
            this.lbl_Services.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbl_Services.SelectedText = "";
            this.lbl_Services.SelectionLength = 0;
            this.lbl_Services.SelectionStart = 0;
            this.lbl_Services.ShortcutsEnabled = true;
            this.lbl_Services.Size = new System.Drawing.Size(300, 100);
            this.lbl_Services.TabIndex = 8;
            this.lbl_Services.TabStop = false;
            this.lbl_Services.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lbl_Services.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(851, 126);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Subtotal";
            // 
            // lbl_discount_type
            // 
            this.lbl_discount_type.AutoSize = true;
            this.lbl_discount_type.Depth = 0;
            this.lbl_discount_type.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_discount_type.Location = new System.Drawing.Point(851, 197);
            this.lbl_discount_type.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_discount_type.Name = "lbl_discount_type";
            this.lbl_discount_type.Size = new System.Drawing.Size(64, 19);
            this.lbl_discount_type.TabIndex = 10;
            this.lbl_discount_type.Text = "Discount";
            // 
            // lbl_tax_rate
            // 
            this.lbl_tax_rate.AutoSize = true;
            this.lbl_tax_rate.Depth = 0;
            this.lbl_tax_rate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_tax_rate.Location = new System.Drawing.Point(851, 256);
            this.lbl_tax_rate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_tax_rate.Name = "lbl_tax_rate";
            this.lbl_tax_rate.Size = new System.Drawing.Size(25, 19);
            this.lbl_tax_rate.TabIndex = 11;
            this.lbl_tax_rate.Text = "Vat";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(851, 312);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(102, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Total Amount:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(851, 375);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 19);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Change:";
            // 
            // lbl_change_amount
            // 
            this.lbl_change_amount.AutoSize = true;
            this.lbl_change_amount.Depth = 0;
            this.lbl_change_amount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_change_amount.Location = new System.Drawing.Point(1075, 375);
            this.lbl_change_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_change_amount.Name = "lbl_change_amount";
            this.lbl_change_amount.Size = new System.Drawing.Size(31, 19);
            this.lbl_change_amount.TabIndex = 18;
            this.lbl_change_amount.Text = "0,00";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Depth = 0;
            this.lbl_Total.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Total.Location = new System.Drawing.Point(1075, 312);
            this.lbl_Total.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(31, 19);
            this.lbl_Total.TabIndex = 17;
            this.lbl_Total.Text = "0,00";
            // 
            // lbl_Vat
            // 
            this.lbl_Vat.AutoSize = true;
            this.lbl_Vat.Depth = 0;
            this.lbl_Vat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Vat.Location = new System.Drawing.Point(1075, 256);
            this.lbl_Vat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Vat.Name = "lbl_Vat";
            this.lbl_Vat.Size = new System.Drawing.Size(31, 19);
            this.lbl_Vat.TabIndex = 16;
            this.lbl_Vat.Text = "0,00";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Depth = 0;
            this.lbl_Discount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Discount.Location = new System.Drawing.Point(1075, 197);
            this.lbl_Discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(31, 19);
            this.lbl_Discount.TabIndex = 15;
            this.lbl_Discount.Text = "0,00";
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Depth = 0;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Subtotal.Location = new System.Drawing.Point(1075, 127);
            this.lbl_Subtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(31, 19);
            this.lbl_Subtotal.TabIndex = 14;
            this.lbl_Subtotal.Text = "0,00";
            // 
            // btn_confirm_payment
            // 
            this.btn_confirm_payment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm_payment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm_payment.Depth = 0;
            this.btn_confirm_payment.HighEmphasis = true;
            this.btn_confirm_payment.Icon = null;
            this.btn_confirm_payment.Location = new System.Drawing.Point(795, 558);
            this.btn_confirm_payment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm_payment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm_payment.Name = "btn_confirm_payment";
            this.btn_confirm_payment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_confirm_payment.Size = new System.Drawing.Size(159, 36);
            this.btn_confirm_payment.TabIndex = 19;
            this.btn_confirm_payment.Text = "confirm payment";
            this.btn_confirm_payment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm_payment.UseAccentColor = false;
            this.btn_confirm_payment.UseVisualStyleBackColor = true;
            this.btn_confirm_payment.Click += new System.EventHandler(this.btn_confirm_payment_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(1047, 558);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.cb_discount.Location = new System.Drawing.Point(407, 371);
            this.cb_discount.MaxDropDownItems = 4;
            this.cb_discount.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_discount.Name = "cb_discount";
            this.cb_discount.Size = new System.Drawing.Size(300, 49);
            this.cb_discount.StartIndex = 0;
            this.cb_discount.TabIndex = 21;
            this.cb_discount.SelectedIndexChanged += new System.EventHandler(this.cb_discount_SelectedIndexChanged);
            // 
            // btn_invoice
            // 
            this.btn_invoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_invoice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_invoice.Depth = 0;
            this.btn_invoice.Enabled = false;
            this.btn_invoice.HighEmphasis = true;
            this.btn_invoice.Icon = null;
            this.btn_invoice.Location = new System.Drawing.Point(548, 558);
            this.btn_invoice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_invoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_invoice.Size = new System.Drawing.Size(155, 36);
            this.btn_invoice.TabIndex = 22;
            this.btn_invoice.Text = "Generate Invoice";
            this.btn_invoice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_invoice.UseAccentColor = false;
            this.btn_invoice.UseVisualStyleBackColor = true;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // dgv_Table
            // 
            this.dgv_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Table.Location = new System.Drawing.Point(1268, 67);
            this.dgv_Table.Name = "dgv_Table";
            this.dgv_Table.RowHeadersWidth = 51;
            this.dgv_Table.RowTemplate.Height = 24;
            this.dgv_Table.Size = new System.Drawing.Size(16, 17);
            this.dgv_Table.TabIndex = 23;
            this.dgv_Table.Visible = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 628);
            this.Controls.Add(this.dgv_Table);
            this.Controls.Add(this.btn_invoice);
            this.Controls.Add(this.cb_discount);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm_payment);
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
            this.Controls.Add(this.lbl_Services);
            this.Controls.Add(this.cb_PaymentMethod);
            this.Controls.Add(this.lbl_book_type);
            this.Controls.Add(this.txt_amount_paid);
            this.Controls.Add(this.txt_Reference);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_CustomerName);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox lbl_CustomerName;
        private MaterialSkin.Controls.MaterialTextBox lbl_Time;
        private MaterialSkin.Controls.MaterialTextBox lbl_Date;
        private MaterialSkin.Controls.MaterialTextBox txt_Reference;
        private MaterialSkin.Controls.MaterialTextBox txt_amount_paid;
        private MaterialSkin.Controls.MaterialTextBox lbl_book_type;
        private MaterialSkin.Controls.MaterialComboBox cb_PaymentMethod;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 lbl_Services;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_discount_type;
        private MaterialSkin.Controls.MaterialLabel lbl_tax_rate;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lbl_change_amount;
        private MaterialSkin.Controls.MaterialLabel lbl_Total;
        private MaterialSkin.Controls.MaterialLabel lbl_Vat;
        private MaterialSkin.Controls.MaterialLabel lbl_Discount;
        private MaterialSkin.Controls.MaterialLabel lbl_Subtotal;
        private MaterialSkin.Controls.MaterialButton btn_confirm_payment;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialComboBox cb_discount;
        private MaterialSkin.Controls.MaterialButton btn_invoice;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.DataGridView dgv_Table;
    }
}