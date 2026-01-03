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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.btn_confirm_payment = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Time = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_book_type = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Date = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_name = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_add_on = new MaterialSkin.Controls.MaterialButton();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_cart_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_final_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_discounted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vat_exempt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_discount_applied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_btn_apply_discount = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_change_amount = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbl_products_label = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cash_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_20 = new MaterialSkin.Controls.MaterialButton();
            this.btn_50 = new MaterialSkin.Controls.MaterialButton();
            this.btn_100 = new MaterialSkin.Controls.MaterialButton();
            this.btn_200 = new MaterialSkin.Controls.MaterialButton();
            this.btn_500 = new MaterialSkin.Controls.MaterialButton();
            this.btn_1000 = new MaterialSkin.Controls.MaterialButton();
            this.btn_custom_pay = new MaterialSkin.Controls.MaterialButton();
            this.btn_clear = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_disc_5 = new MaterialSkin.Controls.MaterialButton();
            this.btn_disc_10 = new MaterialSkin.Controls.MaterialButton();
            this.btn_disc_20 = new MaterialSkin.Controls.MaterialButton();
            this.btn_disc_100 = new MaterialSkin.Controls.MaterialButton();
            this.btn_snr = new MaterialSkin.Controls.MaterialButton();
            this.btn_pwd = new MaterialSkin.Controls.MaterialButton();
            this.txt_discount_amount = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_discount_percent = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_reason = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_reference = new MaterialSkin.Controls.MaterialLabel();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_payment_method = new System.Windows.Forms.ComboBox();
            this.txt_amount_paid = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mat = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_tax_rate = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Subtotal = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Vat = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Discount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_point_amount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Total = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_discount_type = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.product_panel = new System.Windows.Forms.Panel();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_cart_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_isc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prod_final_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prod_discounted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_discount_applied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_vat_exempt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prod_btn_discount = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_promo = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cash_flow.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.product_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirm_payment
            // 
            this.btn_confirm_payment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm_payment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm_payment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm_payment.Depth = 0;
            this.btn_confirm_payment.HighEmphasis = true;
            this.btn_confirm_payment.Icon = null;
            this.btn_confirm_payment.Location = new System.Drawing.Point(439, 865);
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
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(680, 865);
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
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel10.Location = new System.Drawing.Point(51, 240);
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
            this.btn_add_on.Location = new System.Drawing.Point(830, 563);
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
            this.dgv_table.AllowUserToResizeColumns = false;
            this.dgv_table.AllowUserToResizeRows = false;
            this.dgv_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service_id,
            this.col_service_cart_id,
            this.col_item_name,
            this.col_category,
            this.col_qty,
            this.col_unit_price,
            this.col_total,
            this.col_final_price,
            this.col_discounted,
            this.col_vat_exempt,
            this.col_discount_applied,
            this.col_status,
            this.col_btn_apply_discount});
            this.dgv_table.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_table.EnableHeadersVisualStyles = false;
            this.dgv_table.Location = new System.Drawing.Point(53, 294);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_table.RowHeadersVisible = false;
            this.dgv_table.RowHeadersWidth = 51;
            this.dgv_table.RowTemplate.Height = 24;
            this.dgv_table.Size = new System.Drawing.Size(955, 250);
            this.dgv_table.TabIndex = 34;
            this.dgv_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellClick);
            // 
            // col_service_id
            // 
            this.col_service_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_service_id.HeaderText = "service_id";
            this.col_service_id.MinimumWidth = 6;
            this.col_service_id.Name = "col_service_id";
            this.col_service_id.ReadOnly = true;
            this.col_service_id.Visible = false;
            this.col_service_id.Width = 125;
            // 
            // col_service_cart_id
            // 
            this.col_service_cart_id.FillWeight = 5F;
            this.col_service_cart_id.HeaderText = "cart_id";
            this.col_service_cart_id.MinimumWidth = 6;
            this.col_service_cart_id.Name = "col_service_cart_id";
            this.col_service_cart_id.ReadOnly = true;
            this.col_service_cart_id.Width = 125;
            // 
            // col_item_name
            // 
            this.col_item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_item_name.HeaderText = "Item Name";
            this.col_item_name.MinimumWidth = 6;
            this.col_item_name.Name = "col_item_name";
            this.col_item_name.ReadOnly = true;
            // 
            // col_category
            // 
            this.col_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_category.HeaderText = "Category";
            this.col_category.MinimumWidth = 6;
            this.col_category.Name = "col_category";
            this.col_category.ReadOnly = true;
            // 
            // col_qty
            // 
            this.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty.HeaderText = "Qty";
            this.col_qty.MinimumWidth = 6;
            this.col_qty.Name = "col_qty";
            this.col_qty.ReadOnly = true;
            this.col_qty.Width = 54;
            // 
            // col_unit_price
            // 
            this.col_unit_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle19.Format = "C2";
            dataGridViewCellStyle19.NullValue = null;
            this.col_unit_price.DefaultCellStyle = dataGridViewCellStyle19;
            this.col_unit_price.HeaderText = "Unit Price";
            this.col_unit_price.MinimumWidth = 6;
            this.col_unit_price.Name = "col_unit_price";
            this.col_unit_price.ReadOnly = true;
            this.col_unit_price.Width = 84;
            // 
            // col_total
            // 
            this.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle20.Format = "C2";
            dataGridViewCellStyle20.NullValue = null;
            this.col_total.DefaultCellStyle = dataGridViewCellStyle20;
            this.col_total.HeaderText = "Total";
            this.col_total.MinimumWidth = 6;
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            this.col_total.Visible = false;
            this.col_total.Width = 125;
            // 
            // col_final_price
            // 
            this.col_final_price.HeaderText = "Total Price";
            this.col_final_price.MinimumWidth = 6;
            this.col_final_price.Name = "col_final_price";
            this.col_final_price.ReadOnly = true;
            this.col_final_price.Width = 125;
            // 
            // col_discounted
            // 
            dataGridViewCellStyle21.Format = "C2";
            dataGridViewCellStyle21.NullValue = null;
            this.col_discounted.DefaultCellStyle = dataGridViewCellStyle21;
            this.col_discounted.HeaderText = "Discounted";
            this.col_discounted.MinimumWidth = 6;
            this.col_discounted.Name = "col_discounted";
            this.col_discounted.ReadOnly = true;
            this.col_discounted.Width = 125;
            // 
            // col_vat_exempt
            // 
            this.col_vat_exempt.HeaderText = "Vat Exempt";
            this.col_vat_exempt.MinimumWidth = 6;
            this.col_vat_exempt.Name = "col_vat_exempt";
            this.col_vat_exempt.ReadOnly = true;
            this.col_vat_exempt.Visible = false;
            this.col_vat_exempt.Width = 125;
            // 
            // col_discount_applied
            // 
            this.col_discount_applied.HeaderText = "Discount Applied";
            this.col_discount_applied.MinimumWidth = 6;
            this.col_discount_applied.Name = "col_discount_applied";
            this.col_discount_applied.ReadOnly = true;
            this.col_discount_applied.Visible = false;
            this.col_discount_applied.Width = 125;
            // 
            // col_status
            // 
            this.col_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_status.HeaderText = "Status";
            this.col_status.MinimumWidth = 6;
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            this.col_status.Width = 71;
            // 
            // col_btn_apply_discount
            // 
            this.col_btn_apply_discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_btn_apply_discount.HeaderText = "Apply Discount";
            this.col_btn_apply_discount.Image = ((System.Drawing.Image)(resources.GetObject("col_btn_apply_discount.Image")));
            this.col_btn_apply_discount.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_btn_apply_discount.MinimumWidth = 6;
            this.col_btn_apply_discount.Name = "col_btn_apply_discount";
            this.col_btn_apply_discount.ReadOnly = true;
            this.col_btn_apply_discount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_btn_apply_discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_btn_apply_discount.Width = 114;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(524, 280);
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
            this.lbl_change_amount.Location = new System.Drawing.Point(686, 280);
            this.lbl_change_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_change_amount.Name = "lbl_change_amount";
            this.lbl_change_amount.Size = new System.Drawing.Size(38, 24);
            this.lbl_change_amount.TabIndex = 18;
            this.lbl_change_amount.Text = "0,00";
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbl_products_label);
            this.materialCard1.Controls.Add(this.panel1);
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Controls.Add(this.btn_add_on);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.txt_name);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.lbl_book_type);
            this.materialCard1.Controls.Add(this.materialLabel10);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.lbl_Date);
            this.materialCard1.Controls.Add(this.lbl_Time);
            this.materialCard1.Controls.Add(this.dgv_table);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 84);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1942, 706);
            this.materialCard1.TabIndex = 37;
            // 
            // lbl_products_label
            // 
            this.lbl_products_label.AutoSize = true;
            this.lbl_products_label.Depth = 0;
            this.lbl_products_label.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_products_label.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_products_label.Location = new System.Drawing.Point(54, 570);
            this.lbl_products_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_products_label.Name = "lbl_products_label";
            this.lbl_products_label.Size = new System.Drawing.Size(234, 29);
            this.lbl_products_label.TabIndex = 41;
            this.lbl_products_label.Text = "PRODUCTS (ADD ON)";
            this.lbl_products_label.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialTabControl1);
            this.panel1.Controls.Add(this.materialTabSelector1);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_confirm_payment);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1054, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 995);
            this.panel1.TabIndex = 40;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 615);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(853, 200);
            this.materialTabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.cash_flow);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 171);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cash";
            // 
            // cash_flow
            // 
            this.cash_flow.Controls.Add(this.btn_20);
            this.cash_flow.Controls.Add(this.btn_50);
            this.cash_flow.Controls.Add(this.btn_100);
            this.cash_flow.Controls.Add(this.btn_200);
            this.cash_flow.Controls.Add(this.btn_500);
            this.cash_flow.Controls.Add(this.btn_1000);
            this.cash_flow.Controls.Add(this.btn_custom_pay);
            this.cash_flow.Controls.Add(this.btn_clear);
            this.cash_flow.Dock = System.Windows.Forms.DockStyle.Left;
            this.cash_flow.Location = new System.Drawing.Point(3, 3);
            this.cash_flow.Name = "cash_flow";
            this.cash_flow.Padding = new System.Windows.Forms.Padding(10);
            this.cash_flow.Size = new System.Drawing.Size(768, 165);
            this.cash_flow.TabIndex = 22;
            this.cash_flow.Paint += new System.Windows.Forms.PaintEventHandler(this.cash_flow_Paint);
            // 
            // btn_20
            // 
            this.btn_20.AutoSize = false;
            this.btn_20.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_20.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_20.Depth = 0;
            this.btn_20.HighEmphasis = true;
            this.btn_20.Icon = null;
            this.btn_20.Location = new System.Drawing.Point(20, 20);
            this.btn_20.Margin = new System.Windows.Forms.Padding(10);
            this.btn_20.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_20.Name = "btn_20";
            this.btn_20.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_20.Size = new System.Drawing.Size(147, 33);
            this.btn_20.TabIndex = 21;
            this.btn_20.Text = "₱20";
            this.btn_20.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_20.UseAccentColor = false;
            this.btn_20.UseVisualStyleBackColor = true;
            this.btn_20.Click += new System.EventHandler(this.btn_20_Click);
            // 
            // btn_50
            // 
            this.btn_50.AutoSize = false;
            this.btn_50.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_50.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_50.Depth = 0;
            this.btn_50.HighEmphasis = true;
            this.btn_50.Icon = null;
            this.btn_50.Location = new System.Drawing.Point(187, 20);
            this.btn_50.Margin = new System.Windows.Forms.Padding(10);
            this.btn_50.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_50.Name = "btn_50";
            this.btn_50.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_50.Size = new System.Drawing.Size(147, 33);
            this.btn_50.TabIndex = 22;
            this.btn_50.Text = "₱50";
            this.btn_50.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_50.UseAccentColor = false;
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // btn_100
            // 
            this.btn_100.AutoSize = false;
            this.btn_100.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_100.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_100.Depth = 0;
            this.btn_100.HighEmphasis = true;
            this.btn_100.Icon = null;
            this.btn_100.Location = new System.Drawing.Point(354, 20);
            this.btn_100.Margin = new System.Windows.Forms.Padding(10);
            this.btn_100.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_100.Name = "btn_100";
            this.btn_100.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_100.Size = new System.Drawing.Size(147, 33);
            this.btn_100.TabIndex = 23;
            this.btn_100.Text = "₱100";
            this.btn_100.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_100.UseAccentColor = false;
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // btn_200
            // 
            this.btn_200.AutoSize = false;
            this.btn_200.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_200.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_200.Depth = 0;
            this.btn_200.HighEmphasis = true;
            this.btn_200.Icon = null;
            this.btn_200.Location = new System.Drawing.Point(521, 20);
            this.btn_200.Margin = new System.Windows.Forms.Padding(10);
            this.btn_200.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_200.Name = "btn_200";
            this.btn_200.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_200.Size = new System.Drawing.Size(147, 33);
            this.btn_200.TabIndex = 24;
            this.btn_200.Text = "₱200";
            this.btn_200.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_200.UseAccentColor = false;
            this.btn_200.UseVisualStyleBackColor = true;
            this.btn_200.Click += new System.EventHandler(this.btn_200_Click);
            // 
            // btn_500
            // 
            this.btn_500.AutoSize = false;
            this.btn_500.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_500.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_500.Depth = 0;
            this.btn_500.HighEmphasis = true;
            this.btn_500.Icon = null;
            this.btn_500.Location = new System.Drawing.Point(20, 73);
            this.btn_500.Margin = new System.Windows.Forms.Padding(10);
            this.btn_500.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_500.Name = "btn_500";
            this.btn_500.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_500.Size = new System.Drawing.Size(147, 33);
            this.btn_500.TabIndex = 25;
            this.btn_500.Text = "₱500";
            this.btn_500.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_500.UseAccentColor = false;
            this.btn_500.UseVisualStyleBackColor = true;
            this.btn_500.Click += new System.EventHandler(this.btn_500_Click);
            // 
            // btn_1000
            // 
            this.btn_1000.AutoSize = false;
            this.btn_1000.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_1000.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_1000.Depth = 0;
            this.btn_1000.HighEmphasis = true;
            this.btn_1000.Icon = null;
            this.btn_1000.Location = new System.Drawing.Point(187, 73);
            this.btn_1000.Margin = new System.Windows.Forms.Padding(10);
            this.btn_1000.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_1000.Name = "btn_1000";
            this.btn_1000.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_1000.Size = new System.Drawing.Size(147, 33);
            this.btn_1000.TabIndex = 26;
            this.btn_1000.Text = "₱1000";
            this.btn_1000.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_1000.UseAccentColor = false;
            this.btn_1000.UseVisualStyleBackColor = true;
            this.btn_1000.Click += new System.EventHandler(this.btn_1000_Click);
            // 
            // btn_custom_pay
            // 
            this.btn_custom_pay.AutoSize = false;
            this.btn_custom_pay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_custom_pay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_custom_pay.Depth = 0;
            this.btn_custom_pay.HighEmphasis = true;
            this.btn_custom_pay.Icon = null;
            this.btn_custom_pay.Location = new System.Drawing.Point(354, 73);
            this.btn_custom_pay.Margin = new System.Windows.Forms.Padding(10);
            this.btn_custom_pay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_custom_pay.Name = "btn_custom_pay";
            this.btn_custom_pay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_custom_pay.Size = new System.Drawing.Size(147, 33);
            this.btn_custom_pay.TabIndex = 27;
            this.btn_custom_pay.Text = "Custom";
            this.btn_custom_pay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_custom_pay.UseAccentColor = false;
            this.btn_custom_pay.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSize = false;
            this.btn_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_clear.Depth = 0;
            this.btn_clear.HighEmphasis = true;
            this.btn_clear.Icon = null;
            this.btn_clear.Location = new System.Drawing.Point(521, 73);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(10);
            this.btn_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_clear.Size = new System.Drawing.Size(147, 33);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_clear.UseAccentColor = false;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 171);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Discount";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn_disc_5);
            this.flowLayoutPanel2.Controls.Add(this.btn_disc_10);
            this.flowLayoutPanel2.Controls.Add(this.btn_disc_20);
            this.flowLayoutPanel2.Controls.Add(this.btn_disc_100);
            this.flowLayoutPanel2.Controls.Add(this.btn_snr);
            this.flowLayoutPanel2.Controls.Add(this.btn_pwd);
            this.flowLayoutPanel2.Controls.Add(this.txt_discount_amount);
            this.flowLayoutPanel2.Controls.Add(this.txt_discount_percent);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(768, 165);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // btn_disc_5
            // 
            this.btn_disc_5.AutoSize = false;
            this.btn_disc_5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_disc_5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_disc_5.Depth = 0;
            this.btn_disc_5.HighEmphasis = true;
            this.btn_disc_5.Icon = null;
            this.btn_disc_5.Location = new System.Drawing.Point(20, 20);
            this.btn_disc_5.Margin = new System.Windows.Forms.Padding(10);
            this.btn_disc_5.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_disc_5.Name = "btn_disc_5";
            this.btn_disc_5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_disc_5.Size = new System.Drawing.Size(147, 33);
            this.btn_disc_5.TabIndex = 21;
            this.btn_disc_5.Text = "5%";
            this.btn_disc_5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_disc_5.UseAccentColor = false;
            this.btn_disc_5.UseVisualStyleBackColor = true;
            this.btn_disc_5.Click += new System.EventHandler(this.btn_disc_5_Click);
            // 
            // btn_disc_10
            // 
            this.btn_disc_10.AutoSize = false;
            this.btn_disc_10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_disc_10.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_disc_10.Depth = 0;
            this.btn_disc_10.HighEmphasis = true;
            this.btn_disc_10.Icon = null;
            this.btn_disc_10.Location = new System.Drawing.Point(187, 20);
            this.btn_disc_10.Margin = new System.Windows.Forms.Padding(10);
            this.btn_disc_10.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_disc_10.Name = "btn_disc_10";
            this.btn_disc_10.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_disc_10.Size = new System.Drawing.Size(147, 33);
            this.btn_disc_10.TabIndex = 22;
            this.btn_disc_10.Text = "10%";
            this.btn_disc_10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_disc_10.UseAccentColor = false;
            this.btn_disc_10.UseVisualStyleBackColor = true;
            this.btn_disc_10.Click += new System.EventHandler(this.btn_disc_10_Click);
            // 
            // btn_disc_20
            // 
            this.btn_disc_20.AutoSize = false;
            this.btn_disc_20.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_disc_20.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_disc_20.Depth = 0;
            this.btn_disc_20.HighEmphasis = true;
            this.btn_disc_20.Icon = null;
            this.btn_disc_20.Location = new System.Drawing.Point(354, 20);
            this.btn_disc_20.Margin = new System.Windows.Forms.Padding(10);
            this.btn_disc_20.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_disc_20.Name = "btn_disc_20";
            this.btn_disc_20.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_disc_20.Size = new System.Drawing.Size(147, 33);
            this.btn_disc_20.TabIndex = 23;
            this.btn_disc_20.Text = "20%";
            this.btn_disc_20.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_disc_20.UseAccentColor = false;
            this.btn_disc_20.UseVisualStyleBackColor = true;
            this.btn_disc_20.Click += new System.EventHandler(this.btn_disc_20_Click);
            // 
            // btn_disc_100
            // 
            this.btn_disc_100.AutoSize = false;
            this.btn_disc_100.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_disc_100.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_disc_100.Depth = 0;
            this.btn_disc_100.HighEmphasis = true;
            this.btn_disc_100.Icon = null;
            this.btn_disc_100.Location = new System.Drawing.Point(521, 20);
            this.btn_disc_100.Margin = new System.Windows.Forms.Padding(10);
            this.btn_disc_100.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_disc_100.Name = "btn_disc_100";
            this.btn_disc_100.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_disc_100.Size = new System.Drawing.Size(147, 33);
            this.btn_disc_100.TabIndex = 24;
            this.btn_disc_100.Text = "100%";
            this.btn_disc_100.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_disc_100.UseAccentColor = false;
            this.btn_disc_100.UseVisualStyleBackColor = true;
            this.btn_disc_100.Click += new System.EventHandler(this.btn_disc_100_Click);
            // 
            // btn_snr
            // 
            this.btn_snr.AutoSize = false;
            this.btn_snr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_snr.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_snr.Depth = 0;
            this.btn_snr.HighEmphasis = true;
            this.btn_snr.Icon = null;
            this.btn_snr.Location = new System.Drawing.Point(20, 73);
            this.btn_snr.Margin = new System.Windows.Forms.Padding(10);
            this.btn_snr.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_snr.Name = "btn_snr";
            this.btn_snr.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_snr.Size = new System.Drawing.Size(147, 33);
            this.btn_snr.TabIndex = 25;
            this.btn_snr.Text = "Senior";
            this.btn_snr.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_snr.UseAccentColor = false;
            this.btn_snr.UseVisualStyleBackColor = true;
            this.btn_snr.Click += new System.EventHandler(this.btn_snr_Click);
            // 
            // btn_pwd
            // 
            this.btn_pwd.AutoSize = false;
            this.btn_pwd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_pwd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_pwd.Depth = 0;
            this.btn_pwd.HighEmphasis = true;
            this.btn_pwd.Icon = null;
            this.btn_pwd.Location = new System.Drawing.Point(187, 73);
            this.btn_pwd.Margin = new System.Windows.Forms.Padding(10);
            this.btn_pwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_pwd.Name = "btn_pwd";
            this.btn_pwd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_pwd.Size = new System.Drawing.Size(147, 33);
            this.btn_pwd.TabIndex = 26;
            this.btn_pwd.Text = "PWD";
            this.btn_pwd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_pwd.UseAccentColor = false;
            this.btn_pwd.UseVisualStyleBackColor = true;
            this.btn_pwd.Click += new System.EventHandler(this.btn_pwd_Click);
            // 
            // txt_discount_amount
            // 
            this.txt_discount_amount.AnimateReadOnly = false;
            this.txt_discount_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_discount_amount.Depth = 0;
            this.txt_discount_amount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_discount_amount.Hint = "P(Amount)";
            this.txt_discount_amount.LeadingIcon = null;
            this.txt_discount_amount.Location = new System.Drawing.Point(354, 73);
            this.txt_discount_amount.Margin = new System.Windows.Forms.Padding(10);
            this.txt_discount_amount.MaxLength = 50;
            this.txt_discount_amount.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_discount_amount.Multiline = false;
            this.txt_discount_amount.Name = "txt_discount_amount";
            this.txt_discount_amount.Size = new System.Drawing.Size(147, 50);
            this.txt_discount_amount.TabIndex = 27;
            this.txt_discount_amount.Text = "";
            this.txt_discount_amount.TrailingIcon = null;
            this.txt_discount_amount.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // txt_discount_percent
            // 
            this.txt_discount_percent.AnimateReadOnly = false;
            this.txt_discount_percent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_discount_percent.Depth = 0;
            this.txt_discount_percent.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_discount_percent.Hint = "%";
            this.txt_discount_percent.LeadingIcon = null;
            this.txt_discount_percent.Location = new System.Drawing.Point(521, 73);
            this.txt_discount_percent.Margin = new System.Windows.Forms.Padding(10);
            this.txt_discount_percent.MaxLength = 50;
            this.txt_discount_percent.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_discount_percent.Multiline = false;
            this.txt_discount_percent.Name = "txt_discount_percent";
            this.txt_discount_percent.Size = new System.Drawing.Size(147, 50);
            this.txt_discount_percent.TabIndex = 28;
            this.txt_discount_percent.Text = "";
            this.txt_discount_percent.TrailingIcon = null;
            this.txt_discount_percent.TextChanged += new System.EventHandler(this.txt_discount_percent_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.txt_reason);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(845, 171);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notes";
            // 
            // txt_reason
            // 
            this.txt_reason.AnimateReadOnly = false;
            this.txt_reason.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_reason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_reason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reason.Depth = 0;
            this.txt_reason.HideSelection = true;
            this.txt_reason.Hint = "Enter a note";
            this.txt_reason.Location = new System.Drawing.Point(34, 46);
            this.txt_reason.MaxLength = 32767;
            this.txt_reason.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.PasswordChar = '\0';
            this.txt_reason.ReadOnly = false;
            this.txt_reason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_reason.SelectedText = "";
            this.txt_reason.SelectionLength = 0;
            this.txt_reason.SelectionStart = 0;
            this.txt_reason.ShortcutsEnabled = true;
            this.txt_reason.Size = new System.Drawing.Size(763, 102);
            this.txt_reason.TabIndex = 0;
            this.txt_reason.TabStop = false;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_reason.UseSystemPasswordChar = false;
            this.txt_reason.Click += new System.EventHandler(this.txt_reason_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 540);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(853, 75);
            this.materialTabSelector1.TabIndex = 23;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_promo);
            this.panel2.Controls.Add(this.lbl_reference);
            this.panel2.Controls.Add(this.txt_reference);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.cmb_payment_method);
            this.panel2.Controls.Add(this.txt_amount_paid);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.lbl_change_amount);
            this.panel2.Controls.Add(this.mat);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.lbl_tax_rate);
            this.panel2.Controls.Add(this.lbl_Subtotal);
            this.panel2.Controls.Add(this.lbl_Vat);
            this.panel2.Controls.Add(this.lbl_Discount);
            this.panel2.Controls.Add(this.lbl_point_amount);
            this.panel2.Controls.Add(this.lbl_Total);
            this.panel2.Controls.Add(this.lbl_discount_type);
            this.panel2.Controls.Add(this.materialLabel9);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 540);
            this.panel2.TabIndex = 25;
            // 
            // lbl_reference
            // 
            this.lbl_reference.AutoSize = true;
            this.lbl_reference.Depth = 0;
            this.lbl_reference.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_reference.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_reference.Location = new System.Drawing.Point(32, 465);
            this.lbl_reference.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_reference.Name = "lbl_reference";
            this.lbl_reference.Size = new System.Drawing.Size(173, 24);
            this.lbl_reference.TabIndex = 31;
            this.lbl_reference.Text = "Reference Number:";
            this.lbl_reference.Visible = false;
            // 
            // txt_reference
            // 
            this.txt_reference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_reference.Location = new System.Drawing.Point(27, 502);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(500, 22);
            this.txt_reference.TabIndex = 30;
            this.txt_reference.Visible = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(32, 377);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(160, 24);
            this.materialLabel4.TabIndex = 29;
            this.materialLabel4.Text = "Payment Method:";
            // 
            // cmb_payment_method
            // 
            this.cmb_payment_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_payment_method.FormattingEnabled = true;
            this.cmb_payment_method.Location = new System.Drawing.Point(27, 415);
            this.cmb_payment_method.MaxDropDownItems = 6;
            this.cmb_payment_method.Name = "cmb_payment_method";
            this.cmb_payment_method.Size = new System.Drawing.Size(500, 24);
            this.cmb_payment_method.Sorted = true;
            this.cmb_payment_method.TabIndex = 28;
            this.cmb_payment_method.SelectedIndexChanged += new System.EventHandler(this.cmb_payment_method_SelectedIndexChanged);
            // 
            // txt_amount_paid
            // 
            this.txt_amount_paid.AutoSize = true;
            this.txt_amount_paid.Depth = 0;
            this.txt_amount_paid.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txt_amount_paid.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.txt_amount_paid.Location = new System.Drawing.Point(226, 280);
            this.txt_amount_paid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_amount_paid.Name = "txt_amount_paid";
            this.txt_amount_paid.Size = new System.Drawing.Size(38, 24);
            this.txt_amount_paid.TabIndex = 27;
            this.txt_amount_paid.Text = "0,00";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(32, 37);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 24);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Subtotal";
            // 
            // mat
            // 
            this.mat.AutoSize = true;
            this.mat.Depth = 0;
            this.mat.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mat.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.mat.Location = new System.Drawing.Point(32, 280);
            this.mat.MouseState = MaterialSkin.MouseState.HOVER;
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(137, 24);
            this.mat.TabIndex = 26;
            this.mat.Text = "Cash Received:";
            // 
            // lbl_tax_rate
            // 
            this.lbl_tax_rate.AutoSize = true;
            this.lbl_tax_rate.Depth = 0;
            this.lbl_tax_rate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_tax_rate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_tax_rate.Location = new System.Drawing.Point(32, 76);
            this.lbl_tax_rate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lbl_tax_rate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_tax_rate.Name = "lbl_tax_rate";
            this.lbl_tax_rate.Size = new System.Drawing.Size(32, 24);
            this.lbl_tax_rate.TabIndex = 11;
            this.lbl_tax_rate.Text = "Vat";
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Depth = 0;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Subtotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Subtotal.Location = new System.Drawing.Point(740, 37);
            this.lbl_Subtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(38, 24);
            this.lbl_Subtotal.TabIndex = 14;
            this.lbl_Subtotal.Text = "0,00";
            // 
            // lbl_Vat
            // 
            this.lbl_Vat.AutoSize = true;
            this.lbl_Vat.Depth = 0;
            this.lbl_Vat.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Vat.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Vat.Location = new System.Drawing.Point(740, 76);
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
            this.lbl_Discount.Location = new System.Drawing.Point(740, 115);
            this.lbl_Discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(38, 24);
            this.lbl_Discount.TabIndex = 15;
            this.lbl_Discount.Text = "0,00";
            // 
            // lbl_point_amount
            // 
            this.lbl_point_amount.AutoSize = true;
            this.lbl_point_amount.Depth = 0;
            this.lbl_point_amount.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_point_amount.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_point_amount.Location = new System.Drawing.Point(740, 157);
            this.lbl_point_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_point_amount.Name = "lbl_point_amount";
            this.lbl_point_amount.Size = new System.Drawing.Size(38, 24);
            this.lbl_point_amount.TabIndex = 19;
            this.lbl_point_amount.Text = "0,00";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Depth = 0;
            this.lbl_Total.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Total.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Total.Location = new System.Drawing.Point(740, 193);
            this.lbl_Total.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(38, 24);
            this.lbl_Total.TabIndex = 17;
            this.lbl_Total.Text = "0,00";
            this.lbl_Total.Click += new System.EventHandler(this.lbl_Total_Click);
            // 
            // lbl_discount_type
            // 
            this.lbl_discount_type.AutoSize = true;
            this.lbl_discount_type.Depth = 0;
            this.lbl_discount_type.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_discount_type.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_discount_type.Location = new System.Drawing.Point(32, 115);
            this.lbl_discount_type.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lbl_discount_type.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_discount_type.Name = "lbl_discount_type";
            this.lbl_discount_type.Size = new System.Drawing.Size(79, 24);
            this.lbl_discount_type.TabIndex = 10;
            this.lbl_discount_type.Text = "Discount";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(32, 154);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
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
            this.materialLabel2.Location = new System.Drawing.Point(32, 193);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 24);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Grand Total";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.product_panel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 615);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(958, 383);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // product_panel
            // 
            this.product_panel.Controls.Add(this.dgv_product);
            this.product_panel.Location = new System.Drawing.Point(3, 3);
            this.product_panel.Name = "product_panel";
            this.product_panel.Size = new System.Drawing.Size(952, 329);
            this.product_panel.TabIndex = 0;
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.AllowUserToResizeColumns = false;
            this.dgv_product.AllowUserToResizeRows = false;
            this.dgv_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_id,
            this.col_product_cart_id,
            this.col_product_isc_id,
            this.col_product_name,
            this.col_product_size,
            this.col_product_qty,
            this.col_product_price,
            this.col_product_total,
            this.col_prod_final_price,
            this.col_prod_discounted,
            this.col_product_discount_applied,
            this.col_product_vat_exempt,
            this.col_product_status,
            this.col_prod_btn_discount,
            this.btn_remove});
            this.dgv_product.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_product.EnableHeadersVisualStyles = false;
            this.dgv_product.Location = new System.Drawing.Point(0, 0);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.Size = new System.Drawing.Size(952, 329);
            this.dgv_product.TabIndex = 37;
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            // 
            // col_product_id
            // 
            this.col_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_id.HeaderText = "product_id";
            this.col_product_id.MinimumWidth = 6;
            this.col_product_id.Name = "col_product_id";
            this.col_product_id.ReadOnly = true;
            this.col_product_id.Visible = false;
            this.col_product_id.Width = 125;
            // 
            // col_product_cart_id
            // 
            this.col_product_cart_id.HeaderText = "cart_id";
            this.col_product_cart_id.MinimumWidth = 6;
            this.col_product_cart_id.Name = "col_product_cart_id";
            this.col_product_cart_id.ReadOnly = true;
            this.col_product_cart_id.Visible = false;
            this.col_product_cart_id.Width = 125;
            // 
            // col_product_isc_id
            // 
            this.col_product_isc_id.HeaderText = "isc_id";
            this.col_product_isc_id.MinimumWidth = 6;
            this.col_product_isc_id.Name = "col_product_isc_id";
            this.col_product_isc_id.ReadOnly = true;
            this.col_product_isc_id.Visible = false;
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
            this.col_product_size.Width = 60;
            // 
            // col_product_qty
            // 
            this.col_product_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_qty.HeaderText = "Qty";
            this.col_product_qty.MinimumWidth = 6;
            this.col_product_qty.Name = "col_product_qty";
            this.col_product_qty.ReadOnly = true;
            this.col_product_qty.Width = 54;
            // 
            // col_product_price
            // 
            this.col_product_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_price.HeaderText = "Unit Price";
            this.col_product_price.MinimumWidth = 6;
            this.col_product_price.Name = "col_product_price";
            this.col_product_price.ReadOnly = true;
            this.col_product_price.Width = 84;
            // 
            // col_product_total
            // 
            this.col_product_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_total.HeaderText = "Total";
            this.col_product_total.MinimumWidth = 6;
            this.col_product_total.Name = "col_product_total";
            this.col_product_total.ReadOnly = true;
            this.col_product_total.Visible = false;
            this.col_product_total.Width = 125;
            // 
            // col_prod_final_price
            // 
            this.col_prod_final_price.HeaderText = "Total Price";
            this.col_prod_final_price.MinimumWidth = 6;
            this.col_prod_final_price.Name = "col_prod_final_price";
            this.col_prod_final_price.ReadOnly = true;
            this.col_prod_final_price.Width = 125;
            // 
            // col_prod_discounted
            // 
            this.col_prod_discounted.HeaderText = "Discounted";
            this.col_prod_discounted.MinimumWidth = 6;
            this.col_prod_discounted.Name = "col_prod_discounted";
            this.col_prod_discounted.ReadOnly = true;
            this.col_prod_discounted.Width = 125;
            // 
            // col_product_discount_applied
            // 
            this.col_product_discount_applied.HeaderText = "Discount Applied";
            this.col_product_discount_applied.MinimumWidth = 6;
            this.col_product_discount_applied.Name = "col_product_discount_applied";
            this.col_product_discount_applied.ReadOnly = true;
            this.col_product_discount_applied.Visible = false;
            this.col_product_discount_applied.Width = 125;
            // 
            // col_product_vat_exempt
            // 
            this.col_product_vat_exempt.HeaderText = "Vat Exempt";
            this.col_product_vat_exempt.MinimumWidth = 6;
            this.col_product_vat_exempt.Name = "col_product_vat_exempt";
            this.col_product_vat_exempt.ReadOnly = true;
            this.col_product_vat_exempt.Visible = false;
            this.col_product_vat_exempt.Width = 125;
            // 
            // col_product_status
            // 
            this.col_product_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_status.HeaderText = "Status";
            this.col_product_status.MinimumWidth = 6;
            this.col_product_status.Name = "col_product_status";
            this.col_product_status.ReadOnly = true;
            this.col_product_status.Width = 71;
            // 
            // col_prod_btn_discount
            // 
            this.col_prod_btn_discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.col_prod_btn_discount.HeaderText = "Apply Discount";
            this.col_prod_btn_discount.Image = ((System.Drawing.Image)(resources.GetObject("col_prod_btn_discount.Image")));
            this.col_prod_btn_discount.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_prod_btn_discount.MinimumWidth = 6;
            this.col_prod_btn_discount.Name = "col_prod_btn_discount";
            this.col_prod_btn_discount.ReadOnly = true;
            this.col_prod_btn_discount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_prod_btn_discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_prod_btn_discount.Width = 6;
            // 
            // btn_remove
            // 
            this.btn_remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btn_remove.HeaderText = "Remove";
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_remove.MinimumWidth = 6;
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.ReadOnly = true;
            this.btn_remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_remove.Width = 86;
            // 
            // btn_promo
            // 
            this.btn_promo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_promo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_promo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_promo.Depth = 0;
            this.btn_promo.HighEmphasis = true;
            this.btn_promo.Icon = null;
            this.btn_promo.Location = new System.Drawing.Point(718, 494);
            this.btn_promo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_promo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_promo.Name = "btn_promo";
            this.btn_promo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_promo.Size = new System.Drawing.Size(122, 36);
            this.btn_promo.TabIndex = 32;
            this.btn_promo.Text = "apply promo";
            this.btn_promo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_promo.UseAccentColor = false;
            this.btn_promo.UseVisualStyleBackColor = true;
            this.btn_promo.Click += new System.EventHandler(this.btn_promo_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1942, 800);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.Padding = new System.Windows.Forms.Padding(0, 84, 0, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAYMENT INFORMATION";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.cash_flow.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.product_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn_confirm_payment;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialLabel txt_name;
        private MaterialSkin.Controls.MaterialLabel lbl_Date;
        private MaterialSkin.Controls.MaterialLabel lbl_book_type;
        private MaterialSkin.Controls.MaterialLabel lbl_Time;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_tax_rate;
        private MaterialSkin.Controls.MaterialLabel lbl_Subtotal;
        private MaterialSkin.Controls.MaterialLabel lbl_Vat;
        private MaterialSkin.Controls.MaterialLabel lbl_Discount;
        private MaterialSkin.Controls.MaterialLabel lbl_point_amount;
        private MaterialSkin.Controls.MaterialLabel lbl_Total;
        private MaterialSkin.Controls.MaterialLabel lbl_discount_type;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.FlowLayoutPanel cash_flow;
        private MaterialSkin.Controls.MaterialButton btn_20;
        private MaterialSkin.Controls.MaterialButton btn_50;
        private MaterialSkin.Controls.MaterialButton btn_100;
        private MaterialSkin.Controls.MaterialButton btn_200;
        private MaterialSkin.Controls.MaterialButton btn_500;
        private MaterialSkin.Controls.MaterialButton btn_1000;
        private MaterialSkin.Controls.MaterialButton btn_custom_pay;
        private MaterialSkin.Controls.MaterialButton btn_clear;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel txt_amount_paid;
        private MaterialSkin.Controls.MaterialLabel mat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton btn_disc_5;
        private MaterialSkin.Controls.MaterialButton btn_disc_10;
        private MaterialSkin.Controls.MaterialButton btn_disc_20;
        private MaterialSkin.Controls.MaterialButton btn_disc_100;
        private MaterialSkin.Controls.MaterialButton btn_snr;
        private MaterialSkin.Controls.MaterialButton btn_pwd;
        private MaterialSkin.Controls.MaterialTextBox txt_discount_amount;
        private MaterialSkin.Controls.MaterialTextBox txt_discount_percent;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_reason;
        private System.Windows.Forms.Panel product_panel;
        private MaterialSkin.Controls.MaterialLabel lbl_products_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_cart_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_isc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prod_final_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prod_discounted;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_discount_applied;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_vat_exempt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_status;
        private System.Windows.Forms.DataGridViewImageColumn col_prod_btn_discount;
        private System.Windows.Forms.DataGridViewImageColumn btn_remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_cart_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_final_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_discounted;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vat_exempt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_discount_applied;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewImageColumn col_btn_apply_discount;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cmb_payment_method;
        private System.Windows.Forms.TextBox txt_reference;
        private MaterialSkin.Controls.MaterialLabel lbl_reference;
        private MaterialSkin.Controls.MaterialButton btn_promo;
    }
}