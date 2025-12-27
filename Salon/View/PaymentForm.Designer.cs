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
            this.txt_Reference = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_amount_paid = new MaterialSkin.Controls.MaterialTextBox();
            this.cb_PaymentMethod = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_discount_type = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_tax_rate = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Total = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Vat = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Discount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Subtotal = new MaterialSkin.Controls.MaterialLabel();
            this.btn_confirm_payment = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_points = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Time = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_book_type = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Date = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_name = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_point_amount = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_redeem_points = new MaterialSkin.Controls.MaterialButton();
            this.btn_discount = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_add_on = new MaterialSkin.Controls.MaterialButton();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_change_amount = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_isc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
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
            this.txt_Reference.Location = new System.Drawing.Point(490, 1242);
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
            this.txt_amount_paid.Location = new System.Drawing.Point(17, 1301);
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
            this.cb_PaymentMethod.Location = new System.Drawing.Point(17, 1246);
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
            this.materialLabel1.Location = new System.Drawing.Point(54, 932);
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
            this.lbl_discount_type.Location = new System.Drawing.Point(51, 1003);
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
            this.lbl_tax_rate.Location = new System.Drawing.Point(54, 967);
            this.lbl_tax_rate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_tax_rate.Name = "lbl_tax_rate";
            this.lbl_tax_rate.Size = new System.Drawing.Size(32, 24);
            this.lbl_tax_rate.TabIndex = 11;
            this.lbl_tax_rate.Text = "Vat";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Depth = 0;
            this.lbl_Total.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Total.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Total.Location = new System.Drawing.Point(724, 1086);
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
            this.lbl_Vat.Location = new System.Drawing.Point(724, 967);
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
            this.lbl_Discount.Location = new System.Drawing.Point(724, 1003);
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
            this.lbl_Subtotal.Location = new System.Drawing.Point(724, 932);
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
            this.btn_confirm_payment.Location = new System.Drawing.Point(475, 19);
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
            this.btn_cancel.Location = new System.Drawing.Point(887, 19);
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
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.Depth = 0;
            this.lbl_points.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_points.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_points.Location = new System.Drawing.Point(802, 109);
            this.lbl_points.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(40, 24);
            this.lbl_points.TabIndex = 36;
            this.lbl_points.Text = "type";
            this.lbl_points.Visible = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(541, 109);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.materialLabel4.Size = new System.Drawing.Size(138, 24);
            this.materialLabel4.TabIndex = 35;
            this.materialLabel4.Text = "Loyalty Points: ";
            this.materialLabel4.Visible = false;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Depth = 0;
            this.lbl_Time.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Time.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Time.Location = new System.Drawing.Point(292, 171);
            this.lbl_Time.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(41, 24);
            this.lbl_Time.TabIndex = 34;
            this.lbl_Time.Text = "time";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(55, 171);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.materialLabel8.Size = new System.Drawing.Size(56, 24);
            this.materialLabel8.TabIndex = 33;
            this.materialLabel8.Text = "Time: ";
            // 
            // lbl_book_type
            // 
            this.lbl_book_type.AutoSize = true;
            this.lbl_book_type.Depth = 0;
            this.lbl_book_type.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_book_type.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_book_type.Location = new System.Drawing.Point(802, 40);
            this.lbl_book_type.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_book_type.Name = "lbl_book_type";
            this.lbl_book_type.Size = new System.Drawing.Size(40, 24);
            this.lbl_book_type.TabIndex = 32;
            this.lbl_book_type.Text = "type";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(544, 40);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.materialLabel7.Size = new System.Drawing.Size(147, 24);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Customer Type: ";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Depth = 0;
            this.lbl_Date.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Date.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Date.Location = new System.Drawing.Point(292, 109);
            this.lbl_Date.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(41, 24);
            this.lbl_Date.TabIndex = 30;
            this.lbl_Date.Text = "date";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(55, 109);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.materialLabel6.Size = new System.Drawing.Size(53, 24);
            this.materialLabel6.TabIndex = 29;
            this.materialLabel6.Text = "Date: ";
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Depth = 0;
            this.txt_name.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_name.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.txt_name.Location = new System.Drawing.Point(292, 40);
            this.txt_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(51, 24);
            this.txt_name.TabIndex = 28;
            this.txt_name.Text = "name";
            this.txt_name.Click += new System.EventHandler(this.txt_name_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(55, 40);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 25, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.materialLabel3.Size = new System.Drawing.Size(151, 24);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "Customer Name:";
            // 
            // lbl_point_amount
            // 
            this.lbl_point_amount.AutoSize = true;
            this.lbl_point_amount.Depth = 0;
            this.lbl_point_amount.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_point_amount.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_point_amount.Location = new System.Drawing.Point(724, 1045);
            this.lbl_point_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_point_amount.Name = "lbl_point_amount";
            this.lbl_point_amount.Size = new System.Drawing.Size(38, 24);
            this.lbl_point_amount.TabIndex = 19;
            this.lbl_point_amount.Text = "0,00";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(49, 1045);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(118, 24);
            this.materialLabel9.TabIndex = 18;
            this.materialLabel9.Text = "Loyalty Point";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(49, 1086);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 24);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Grand Total";
            // 
            // btn_redeem_points
            // 
            this.btn_redeem_points.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_redeem_points.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_redeem_points.Depth = 0;
            this.btn_redeem_points.Enabled = false;
            this.btn_redeem_points.HighEmphasis = true;
            this.btn_redeem_points.Icon = null;
            this.btn_redeem_points.Location = new System.Drawing.Point(692, 1301);
            this.btn_redeem_points.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_redeem_points.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_redeem_points.Name = "btn_redeem_points";
            this.btn_redeem_points.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_redeem_points.Size = new System.Drawing.Size(143, 36);
            this.btn_redeem_points.TabIndex = 20;
            this.btn_redeem_points.Text = "Reedeem points";
            this.btn_redeem_points.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_redeem_points.UseAccentColor = false;
            this.btn_redeem_points.UseVisualStyleBackColor = true;
            this.btn_redeem_points.Click += new System.EventHandler(this.btn_redeem_points_Click);
            // 
            // btn_discount
            // 
            this.btn_discount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_discount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_discount.Depth = 0;
            this.btn_discount.HighEmphasis = true;
            this.btn_discount.Icon = null;
            this.btn_discount.Location = new System.Drawing.Point(456, 1301);
            this.btn_discount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_discount.Size = new System.Drawing.Size(142, 36);
            this.btn_discount.TabIndex = 19;
            this.btn_discount.Text = "apply discount";
            this.btn_discount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_discount.UseAccentColor = false;
            this.btn_discount.UseVisualStyleBackColor = true;
            this.btn_discount.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_confirm_payment);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 816);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 61);
            this.panel1.TabIndex = 31;
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_clear.Depth = 0;
            this.btn_clear.HighEmphasis = true;
            this.btn_clear.Icon = null;
            this.btn_clear.Location = new System.Drawing.Point(728, 19);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_clear.Size = new System.Drawing.Size(66, 36);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "clear";
            this.btn_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_clear.UseAccentColor = false;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel10.Location = new System.Drawing.Point(54, 231);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(110, 29);
            this.materialLabel10.TabIndex = 0;
            this.materialLabel10.Text = "SERVICES";
            // 
            // btn_add_on
            // 
            this.btn_add_on.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_on.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_on.Depth = 0;
            this.btn_add_on.HighEmphasis = true;
            this.btn_add_on.Icon = null;
            this.btn_add_on.Location = new System.Drawing.Point(800, 575);
            this.btn_add_on.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_on.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_on.Name = "btn_add_on";
            this.btn_add_on.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_on.Size = new System.Drawing.Size(121, 36);
            this.btn_add_on.TabIndex = 1;
            this.btn_add_on.Text = "add product";
            this.btn_add_on.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_on.UseAccentColor = false;
            this.btn_add_on.UseVisualStyleBackColor = true;
            this.btn_add_on.Click += new System.EventHandler(this.btn_add_on_Click);
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service_id,
            this.col_item_name,
            this.col_qty,
            this.col_unit_price,
            this.col_total});
            this.dgv_table.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_table.Location = new System.Drawing.Point(53, 263);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersWidth = 51;
            this.dgv_table.RowTemplate.Height = 24;
            this.dgv_table.Size = new System.Drawing.Size(868, 248);
            this.dgv_table.TabIndex = 34;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(32, 1366);
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
            this.lbl_change_amount.Location = new System.Drawing.Point(132, 1366);
            this.lbl_change_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_change_amount.Name = "lbl_change_amount";
            this.lbl_change_amount.Size = new System.Drawing.Size(38, 24);
            this.lbl_change_amount.TabIndex = 18;
            this.lbl_change_amount.Text = "0,00";
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.AutoScrollMargin = new System.Drawing.Size(0, 500);
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel11);
            this.materialCard1.Controls.Add(this.dgv_product);
            this.materialCard1.Controls.Add(this.btn_redeem_points);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.lbl_change_amount);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.txt_name);
            this.materialCard1.Controls.Add(this.btn_discount);
            this.materialCard1.Controls.Add(this.lbl_point_amount);
            this.materialCard1.Controls.Add(this.cb_PaymentMethod);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.txt_amount_paid);
            this.materialCard1.Controls.Add(this.lbl_book_type);
            this.materialCard1.Controls.Add(this.txt_Reference);
            this.materialCard1.Controls.Add(this.materialLabel10);
            this.materialCard1.Controls.Add(this.lbl_Total);
            this.materialCard1.Controls.Add(this.materialLabel9);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.lbl_Discount);
            this.materialCard1.Controls.Add(this.lbl_Vat);
            this.materialCard1.Controls.Add(this.lbl_Subtotal);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.btn_add_on);
            this.materialCard1.Controls.Add(this.lbl_Date);
            this.materialCard1.Controls.Add(this.lbl_Time);
            this.materialCard1.Controls.Add(this.lbl_points);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.dgv_table);
            this.materialCard1.Controls.Add(this.lbl_discount_type);
            this.materialCard1.Controls.Add(this.lbl_tax_rate);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 84);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1021, 732);
            this.materialCard1.TabIndex = 37;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel11.Location = new System.Drawing.Point(53, 575);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(124, 29);
            this.materialLabel11.TabIndex = 38;
            this.materialLabel11.Text = "PRODUCTS";
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_id,
            this.col_product_isc_id,
            this.col_product_name,
            this.col_product_size,
            this.col_product_qty,
            this.col_product_price,
            this.col_product_total,
            this.btn_remove});
            this.dgv_product.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_product.Location = new System.Drawing.Point(53, 629);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.Size = new System.Drawing.Size(868, 248);
            this.dgv_product.TabIndex = 37;
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            // 
            // col_service_id
            // 
            this.col_service_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_service_id.HeaderText = "service_id";
            this.col_service_id.MinimumWidth = 6;
            this.col_service_id.Name = "col_service_id";
            this.col_service_id.ReadOnly = true;
            this.col_service_id.Visible = false;
            this.col_service_id.Width = 98;
            // 
            // col_item_name
            // 
            this.col_item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_item_name.HeaderText = "Item Name";
            this.col_item_name.MinimumWidth = 6;
            this.col_item_name.Name = "col_item_name";
            this.col_item_name.ReadOnly = true;
            // 
            // col_qty
            // 
            this.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty.HeaderText = "Qty";
            this.col_qty.MinimumWidth = 6;
            this.col_qty.Name = "col_qty";
            this.col_qty.ReadOnly = true;
            this.col_qty.Width = 56;
            // 
            // col_unit_price
            // 
            this.col_unit_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_unit_price.HeaderText = "Unit Price";
            this.col_unit_price.MinimumWidth = 6;
            this.col_unit_price.Name = "col_unit_price";
            this.col_unit_price.ReadOnly = true;
            this.col_unit_price.Width = 93;
            // 
            // col_total
            // 
            this.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_total.HeaderText = "Total";
            this.col_total.MinimumWidth = 6;
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            this.col_total.Width = 67;
            // 
            // col_product_id
            // 
            this.col_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_id.HeaderText = "product_id";
            this.col_product_id.MinimumWidth = 6;
            this.col_product_id.Name = "col_product_id";
            this.col_product_id.ReadOnly = true;
            this.col_product_id.Visible = false;
            this.col_product_id.Width = 99;
            // 
            // col_product_isc_id
            // 
            this.col_product_isc_id.HeaderText = "isc_id";
            this.col_product_isc_id.MinimumWidth = 6;
            this.col_product_isc_id.Name = "col_product_isc_id";
            this.col_product_isc_id.ReadOnly = true;
            this.col_product_isc_id.Width = 125;
            // 
            // col_product_name
            // 
            this.col_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_name.HeaderText = "Item Name";
            this.col_product_name.MinimumWidth = 6;
            this.col_product_name.Name = "col_product_name";
            this.col_product_name.ReadOnly = true;
            // 
            // col_product_size
            // 
            this.col_product_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_size.HeaderText = "Size";
            this.col_product_size.MinimumWidth = 6;
            this.col_product_size.Name = "col_product_size";
            this.col_product_size.ReadOnly = true;
            this.col_product_size.Width = 62;
            // 
            // col_product_qty
            // 
            this.col_product_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_qty.HeaderText = "Qty";
            this.col_product_qty.MinimumWidth = 6;
            this.col_product_qty.Name = "col_product_qty";
            this.col_product_qty.ReadOnly = true;
            this.col_product_qty.Width = 56;
            // 
            // col_product_price
            // 
            this.col_product_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_price.HeaderText = "Unit Price";
            this.col_product_price.MinimumWidth = 6;
            this.col_product_price.Name = "col_product_price";
            this.col_product_price.ReadOnly = true;
            this.col_product_price.Width = 93;
            // 
            // col_product_total
            // 
            this.col_product_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_total.HeaderText = "Total";
            this.col_product_total.MinimumWidth = 6;
            this.col_product_total.Name = "col_product_total";
            this.col_product_total.ReadOnly = true;
            this.col_product_total.Width = 67;
            // 
            // btn_remove
            // 
            this.btn_remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_remove.HeaderText = "Remove";
            this.btn_remove.MinimumWidth = 6;
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.ReadOnly = true;
            this.btn_remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_remove.Width = 88;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 887);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.Padding = new System.Windows.Forms.Padding(0, 84, 0, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAYMENT INFORMATION";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txt_Reference;
        private MaterialSkin.Controls.MaterialTextBox txt_amount_paid;
        private MaterialSkin.Controls.MaterialComboBox cb_PaymentMethod;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_discount_type;
        private MaterialSkin.Controls.MaterialLabel lbl_tax_rate;
        private MaterialSkin.Controls.MaterialLabel lbl_Total;
        private MaterialSkin.Controls.MaterialLabel lbl_Vat;
        private MaterialSkin.Controls.MaterialLabel lbl_Discount;
        private MaterialSkin.Controls.MaterialLabel lbl_Subtotal;
        private MaterialSkin.Controls.MaterialButton btn_confirm_payment;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btn_discount;
        private MaterialSkin.Controls.MaterialLabel txt_name;
        private MaterialSkin.Controls.MaterialLabel lbl_Date;
        private MaterialSkin.Controls.MaterialLabel lbl_book_type;
        private MaterialSkin.Controls.MaterialLabel lbl_Time;
        private MaterialSkin.Controls.MaterialLabel lbl_points;
        private MaterialSkin.Controls.MaterialButton btn_redeem_points;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel lbl_point_amount;
        private MaterialSkin.Controls.MaterialButton btn_clear;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton btn_add_on;
        private System.Windows.Forms.DataGridView dgv_table;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lbl_change_amount;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView dgv_product;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_isc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_total;
        private System.Windows.Forms.DataGridViewButtonColumn btn_remove;
    }
}