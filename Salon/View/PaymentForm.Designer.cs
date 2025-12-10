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
            this.components = new System.ComponentModel.Container();
            this.lbl_Time = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_Date = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Reference = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_amount_paid = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_book_type = new MaterialSkin.Controls.MaterialTextBox();
            this.cb_PaymentMethod = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_discount_type = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_tax_rate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_change_amount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Total = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Vat = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Discount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Subtotal = new MaterialSkin.Controls.MaterialLabel();
            this.btn_confirm_payment = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.cb_discount = new MaterialSkin.Controls.MaterialComboBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.dgv_Table = new System.Windows.Forms.DataGridView();
            this.col_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sw_exempt_vat = new MaterialSkin.Controls.MaterialSwitch();
            this.txt_name = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Time
            // 
            this.lbl_Time.AnimateReadOnly = true;
            this.lbl_Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Time.Depth = 0;
            this.lbl_Time.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Time.Hint = "Time";
            this.lbl_Time.LeadingIcon = null;
            this.lbl_Time.Location = new System.Drawing.Point(539, 123);
            this.lbl_Time.MaxLength = 50;
            this.lbl_Time.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Time.Multiline = false;
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.ReadOnly = true;
            this.lbl_Time.Size = new System.Drawing.Size(400, 50);
            this.lbl_Time.TabIndex = 1;
            this.lbl_Time.Text = "";
            this.lbl_Time.TrailingIcon = null;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AnimateReadOnly = true;
            this.lbl_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Date.Depth = 0;
            this.lbl_Date.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Date.Hint = "Appointment Date";
            this.lbl_Date.LeadingIcon = null;
            this.lbl_Date.Location = new System.Drawing.Point(33, 123);
            this.lbl_Date.MaxLength = 50;
            this.lbl_Date.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_Date.Multiline = false;
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.ReadOnly = true;
            this.lbl_Date.Size = new System.Drawing.Size(400, 50);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "";
            this.lbl_Date.TrailingIcon = null;
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
            this.txt_Reference.Location = new System.Drawing.Point(539, 118);
            this.txt_Reference.MaxLength = 13;
            this.txt_Reference.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Reference.Multiline = false;
            this.txt_Reference.Name = "txt_Reference";
            this.txt_Reference.Size = new System.Drawing.Size(400, 50);
            this.txt_Reference.TabIndex = 4;
            this.txt_Reference.Text = "";
            this.txt_Reference.TrailingIcon = null;
            this.txt_Reference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Reference_KeyPress);
            this.txt_Reference.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Reference_Validating);
            // 
            // txt_amount_paid
            // 
            this.txt_amount_paid.AnimateReadOnly = true;
            this.txt_amount_paid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amount_paid.Depth = 0;
            this.txt_amount_paid.Enabled = false;
            this.txt_amount_paid.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_amount_paid.Hint = "Amount Received";
            this.txt_amount_paid.LeadingIcon = null;
            this.txt_amount_paid.Location = new System.Drawing.Point(47, 118);
            this.txt_amount_paid.MaxLength = 50;
            this.txt_amount_paid.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_amount_paid.Multiline = false;
            this.txt_amount_paid.Name = "txt_amount_paid";
            this.txt_amount_paid.Size = new System.Drawing.Size(400, 50);
            this.txt_amount_paid.TabIndex = 5;
            this.txt_amount_paid.Text = "";
            this.txt_amount_paid.TrailingIcon = null;
            this.txt_amount_paid.TextChanged += new System.EventHandler(this.txt_amount_paid_TextChanged);
            // 
            // lbl_book_type
            // 
            this.lbl_book_type.AnimateReadOnly = true;
            this.lbl_book_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_book_type.Depth = 0;
            this.lbl_book_type.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_book_type.Hint = "Booking Type:";
            this.lbl_book_type.LeadingIcon = null;
            this.lbl_book_type.Location = new System.Drawing.Point(539, 39);
            this.lbl_book_type.MaxLength = 50;
            this.lbl_book_type.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_book_type.Multiline = false;
            this.lbl_book_type.Name = "lbl_book_type";
            this.lbl_book_type.ReadOnly = true;
            this.lbl_book_type.Size = new System.Drawing.Size(400, 50);
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
            this.cb_PaymentMethod.Location = new System.Drawing.Point(47, 38);
            this.cb_PaymentMethod.MaxDropDownItems = 4;
            this.cb_PaymentMethod.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_PaymentMethod.Name = "cb_PaymentMethod";
            this.cb_PaymentMethod.Size = new System.Drawing.Size(400, 49);
            this.cb_PaymentMethod.StartIndex = -1;
            this.cb_PaymentMethod.TabIndex = 7;
            this.cb_PaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cb_PaymentMethod_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(84, 40);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 24);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Subtotal";
            // 
            // lbl_discount_type
            // 
            this.lbl_discount_type.AutoSize = true;
            this.lbl_discount_type.Depth = 0;
            this.lbl_discount_type.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_discount_type.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_discount_type.Location = new System.Drawing.Point(84, 107);
            this.lbl_discount_type.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_discount_type.Name = "lbl_discount_type";
            this.lbl_discount_type.Size = new System.Drawing.Size(79, 24);
            this.lbl_discount_type.TabIndex = 10;
            this.lbl_discount_type.Text = "Discount";
            // 
            // lbl_tax_rate
            // 
            this.lbl_tax_rate.AutoSize = true;
            this.lbl_tax_rate.Depth = 0;
            this.lbl_tax_rate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_tax_rate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_tax_rate.Location = new System.Drawing.Point(84, 72);
            this.lbl_tax_rate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_tax_rate.Name = "lbl_tax_rate";
            this.lbl_tax_rate.Size = new System.Drawing.Size(32, 24);
            this.lbl_tax_rate.TabIndex = 11;
            this.lbl_tax_rate.Text = "Vat";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(43, 203);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(74, 24);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Change:";
            // 
            // lbl_change_amount
            // 
            this.lbl_change_amount.AutoSize = true;
            this.lbl_change_amount.Depth = 0;
            this.lbl_change_amount.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_change_amount.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_change_amount.Location = new System.Drawing.Point(305, 203);
            this.lbl_change_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_change_amount.Name = "lbl_change_amount";
            this.lbl_change_amount.Size = new System.Drawing.Size(38, 24);
            this.lbl_change_amount.TabIndex = 18;
            this.lbl_change_amount.Text = "0,00";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Depth = 0;
            this.lbl_Total.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Total.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Total.Location = new System.Drawing.Point(787, 144);
            this.lbl_Total.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(38, 24);
            this.lbl_Total.TabIndex = 17;
            this.lbl_Total.Text = "0,00";
            this.lbl_Total.Click += new System.EventHandler(this.lbl_Total_Click);
            // 
            // lbl_Vat
            // 
            this.lbl_Vat.AutoSize = true;
            this.lbl_Vat.Depth = 0;
            this.lbl_Vat.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Vat.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Vat.Location = new System.Drawing.Point(787, 72);
            this.lbl_Vat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Vat.Name = "lbl_Vat";
            this.lbl_Vat.Size = new System.Drawing.Size(38, 24);
            this.lbl_Vat.TabIndex = 16;
            this.lbl_Vat.Text = "0,00";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Depth = 0;
            this.lbl_Discount.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Discount.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Discount.Location = new System.Drawing.Point(787, 107);
            this.lbl_Discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(38, 24);
            this.lbl_Discount.TabIndex = 15;
            this.lbl_Discount.Text = "0,00";
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Depth = 0;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Subtotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Subtotal.Location = new System.Drawing.Point(787, 40);
            this.lbl_Subtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(38, 24);
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
            this.btn_confirm_payment.Location = new System.Drawing.Point(174, 19);
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
            this.btn_cancel.Location = new System.Drawing.Point(595, 19);
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
            this.cb_discount.Location = new System.Drawing.Point(539, 38);
            this.cb_discount.MaxDropDownItems = 4;
            this.cb_discount.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_discount.Name = "cb_discount";
            this.cb_discount.Size = new System.Drawing.Size(400, 49);
            this.cb_discount.StartIndex = 0;
            this.cb_discount.TabIndex = 21;
            this.cb_discount.SelectedIndexChanged += new System.EventHandler(this.cb_discount_SelectedIndexChanged);
            // 
            // dgv_Table
            // 
            this.dgv_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service,
            this.col_price,
            this.col_duration,
            this.col_qty});
            this.dgv_Table.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Table.Location = new System.Drawing.Point(3, 18);
            this.dgv_Table.Name = "dgv_Table";
            this.dgv_Table.RowHeadersWidth = 51;
            this.dgv_Table.RowTemplate.Height = 24;
            this.dgv_Table.Size = new System.Drawing.Size(974, 226);
            this.dgv_Table.TabIndex = 23;
            this.dgv_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Table_CellContentClick);
            // 
            // col_service
            // 
            this.col_service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service.HeaderText = "Service";
            this.col_service.MinimumWidth = 6;
            this.col_service.Name = "col_service";
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_price.HeaderText = "Price";
            this.col_price.MinimumWidth = 6;
            this.col_price.Name = "col_price";
            this.col_price.Width = 67;
            // 
            // col_duration
            // 
            this.col_duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_duration.HeaderText = "Duration";
            this.col_duration.MinimumWidth = 6;
            this.col_duration.Name = "col_duration";
            this.col_duration.Width = 86;
            // 
            // col_qty
            // 
            this.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty.HeaderText = "Qty";
            this.col_qty.MinimumWidth = 6;
            this.col_qty.Name = "col_qty";
            this.col_qty.Width = 56;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // sw_exempt_vat
            // 
            this.sw_exempt_vat.AutoSize = true;
            this.sw_exempt_vat.Depth = 0;
            this.sw_exempt_vat.Location = new System.Drawing.Point(57, 818);
            this.sw_exempt_vat.Margin = new System.Windows.Forms.Padding(0);
            this.sw_exempt_vat.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sw_exempt_vat.MouseState = MaterialSkin.MouseState.HOVER;
            this.sw_exempt_vat.Name = "sw_exempt_vat";
            this.sw_exempt_vat.Ripple = true;
            this.sw_exempt_vat.Size = new System.Drawing.Size(145, 37);
            this.sw_exempt_vat.TabIndex = 24;
            this.sw_exempt_vat.Text = "Exempt VAT";
            this.sw_exempt_vat.UseVisualStyleBackColor = true;
            this.sw_exempt_vat.Visible = false;
            this.sw_exempt_vat.CheckedChanged += new System.EventHandler(this.sw_exempt_vat_CheckedChanged);
            // 
            // txt_name
            // 
            this.txt_name.AnimateReadOnly = false;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Depth = 0;
            this.txt_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_name.Hint = "Customer Name";
            this.txt_name.LeadingIcon = null;
            this.txt_name.Location = new System.Drawing.Point(33, 39);
            this.txt_name.MaxLength = 50;
            this.txt_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(400, 50);
            this.txt_name.TabIndex = 26;
            this.txt_name.Text = "";
            this.txt_name.TrailingIcon = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.lbl_book_type);
            this.groupBox1.Controls.Add(this.lbl_Date);
            this.groupBox1.Controls.Add(this.lbl_Time);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 234);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUSTOMER INFORMATION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Table);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 264);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SERVICES";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialLabel2);
            this.groupBox3.Controls.Add(this.lbl_Subtotal);
            this.groupBox3.Controls.Add(this.lbl_Vat);
            this.groupBox3.Controls.Add(this.materialLabel1);
            this.groupBox3.Controls.Add(this.lbl_Discount);
            this.groupBox3.Controls.Add(this.lbl_Total);
            this.groupBox3.Controls.Add(this.lbl_tax_rate);
            this.groupBox3.Controls.Add(this.lbl_discount_type);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(10, 582);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(980, 182);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PAYMENT SUMMARY";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(83, 144);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 24);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Grand Total";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_PaymentMethod);
            this.groupBox4.Controls.Add(this.cb_discount);
            this.groupBox4.Controls.Add(this.txt_amount_paid);
            this.groupBox4.Controls.Add(this.lbl_change_amount);
            this.groupBox4.Controls.Add(this.txt_Reference);
            this.groupBox4.Controls.Add(this.materialLabel5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(10, 779);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(980, 252);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PAYMENT DETAILS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_confirm_payment);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 1031);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 61);
            this.panel1.TabIndex = 31;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 1102);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sw_exempt_vat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.Padding = new System.Windows.Forms.Padding(10, 84, 10, 10);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAYMENT INFORMATION";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox lbl_Time;
        private MaterialSkin.Controls.MaterialTextBox lbl_Date;
        private MaterialSkin.Controls.MaterialTextBox txt_Reference;
        private MaterialSkin.Controls.MaterialTextBox txt_amount_paid;
        private MaterialSkin.Controls.MaterialTextBox lbl_book_type;
        private MaterialSkin.Controls.MaterialComboBox cb_PaymentMethod;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_discount_type;
        private MaterialSkin.Controls.MaterialLabel lbl_tax_rate;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lbl_change_amount;
        private MaterialSkin.Controls.MaterialLabel lbl_Total;
        private MaterialSkin.Controls.MaterialLabel lbl_Vat;
        private MaterialSkin.Controls.MaterialLabel lbl_Discount;
        private MaterialSkin.Controls.MaterialLabel lbl_Subtotal;
        private MaterialSkin.Controls.MaterialButton btn_confirm_payment;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialComboBox cb_discount;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.DataGridView dgv_Table;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialSwitch sw_exempt_vat;
        private MaterialSkin.Controls.MaterialTextBox txt_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
    }
}