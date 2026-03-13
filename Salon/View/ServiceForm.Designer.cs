namespace Salon.View
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_unit_type = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_update_consumption = new MaterialSkin.Controls.MaterialButton();
            this.lbl_usage_id = new MaterialSkin.Controls.MaterialLabel();
            this.btn_add_consumption = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_brand = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_product = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_total_usage = new MaterialSkin.Controls.MaterialTextBox();
            this.dgv_Service_Product = new System.Windows.Forms.DataGridView();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product__size_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_usage_btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_service_name = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_sub_category = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_price = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_duration = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service_Product)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_duration)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialLabel9);
            this.groupBox2.Controls.Add(this.txt_unit_type);
            this.groupBox2.Controls.Add(this.btn_update_consumption);
            this.groupBox2.Controls.Add(this.lbl_usage_id);
            this.groupBox2.Controls.Add(this.btn_add_consumption);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.txt_brand);
            this.groupBox2.Controls.Add(this.cmb_product);
            this.groupBox2.Controls.Add(this.txt_total_usage);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1236, 333);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCT CONSUMPTIONS";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(748, 70);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(86, 24);
            this.materialLabel9.TabIndex = 74;
            this.materialLabel9.Text = "Unit Type";
            // 
            // txt_unit_type
            // 
            this.txt_unit_type.AnimateReadOnly = true;
            this.txt_unit_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_unit_type.Depth = 0;
            this.txt_unit_type.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_unit_type.Hint = "Unit Type";
            this.txt_unit_type.LeadingIcon = null;
            this.txt_unit_type.Location = new System.Drawing.Point(743, 97);
            this.txt_unit_type.MaxLength = 50;
            this.txt_unit_type.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_unit_type.Multiline = false;
            this.txt_unit_type.Name = "txt_unit_type";
            this.txt_unit_type.ReadOnly = true;
            this.txt_unit_type.Size = new System.Drawing.Size(350, 50);
            this.txt_unit_type.TabIndex = 73;
            this.txt_unit_type.Text = "";
            this.txt_unit_type.TrailingIcon = null;
            // 
            // btn_update_consumption
            // 
            this.btn_update_consumption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_consumption.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update_consumption.Depth = 0;
            this.btn_update_consumption.DrawShadows = false;
            this.btn_update_consumption.HighEmphasis = true;
            this.btn_update_consumption.Icon = null;
            this.btn_update_consumption.Location = new System.Drawing.Point(6, 272);
            this.btn_update_consumption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update_consumption.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update_consumption.Name = "btn_update_consumption";
            this.btn_update_consumption.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update_consumption.Size = new System.Drawing.Size(256, 36);
            this.btn_update_consumption.TabIndex = 72;
            this.btn_update_consumption.Text = "update product consumption";
            this.btn_update_consumption.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update_consumption.UseAccentColor = false;
            this.btn_update_consumption.UseVisualStyleBackColor = true;
            this.btn_update_consumption.Visible = false;
            this.btn_update_consumption.Click += new System.EventHandler(this.btn_update_consumption_Click);
            // 
            // lbl_usage_id
            // 
            this.lbl_usage_id.AutoSize = true;
            this.lbl_usage_id.Depth = 0;
            this.lbl_usage_id.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_usage_id.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_usage_id.Location = new System.Drawing.Point(51, 45);
            this.lbl_usage_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_usage_id.Name = "lbl_usage_id";
            this.lbl_usage_id.Size = new System.Drawing.Size(12, 24);
            this.lbl_usage_id.TabIndex = 71;
            this.lbl_usage_id.Text = "0";
            this.lbl_usage_id.Visible = false;
            // 
            // btn_add_consumption
            // 
            this.btn_add_consumption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_consumption.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_consumption.Depth = 0;
            this.btn_add_consumption.DrawShadows = false;
            this.btn_add_consumption.HighEmphasis = true;
            this.btn_add_consumption.Icon = null;
            this.btn_add_consumption.Location = new System.Drawing.Point(12, 272);
            this.btn_add_consumption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_consumption.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_consumption.Name = "btn_add_consumption";
            this.btn_add_consumption.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_consumption.Size = new System.Drawing.Size(229, 36);
            this.btn_add_consumption.TabIndex = 25;
            this.btn_add_consumption.Text = "Add product consumption";
            this.btn_add_consumption.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_consumption.UseAccentColor = false;
            this.btn_add_consumption.UseVisualStyleBackColor = true;
            this.btn_add_consumption.Click += new System.EventHandler(this.btn_add_consumption_Click_1);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(42, 172);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 24);
            this.materialLabel3.TabIndex = 69;
            this.materialLabel3.Text = "Brand:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(748, 172);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(194, 24);
            this.materialLabel4.TabIndex = 70;
            this.materialLabel4.Text = "Product Consumption";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(40, 69);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 24);
            this.materialLabel2.TabIndex = 68;
            this.materialLabel2.Text = "Product:";
            // 
            // txt_brand
            // 
            this.txt_brand.AnimateReadOnly = true;
            this.txt_brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_brand.Depth = 0;
            this.txt_brand.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_brand.Hint = "Brand";
            this.txt_brand.LeadingIcon = null;
            this.txt_brand.Location = new System.Drawing.Point(46, 200);
            this.txt_brand.MaxLength = 50;
            this.txt_brand.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_brand.Multiline = false;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.ReadOnly = true;
            this.txt_brand.Size = new System.Drawing.Size(350, 50);
            this.txt_brand.TabIndex = 66;
            this.txt_brand.Text = "";
            this.txt_brand.TrailingIcon = null;
            // 
            // cmb_product
            // 
            this.cmb_product.AutoResize = false;
            this.cmb_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_product.Depth = 0;
            this.cmb_product.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_product.DropDownHeight = 174;
            this.cmb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product.DropDownWidth = 121;
            this.cmb_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Hint = "Select product";
            this.cmb_product.IntegralHeight = false;
            this.cmb_product.ItemHeight = 43;
            this.cmb_product.Location = new System.Drawing.Point(40, 95);
            this.cmb_product.MaxDropDownItems = 4;
            this.cmb_product.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(350, 49);
            this.cmb_product.StartIndex = 0;
            this.cmb_product.TabIndex = 65;
            this.cmb_product.SelectedValueChanged += new System.EventHandler(this.cmb_product_SelectedValueChanged);
            // 
            // txt_total_usage
            // 
            this.txt_total_usage.AnimateReadOnly = false;
            this.txt_total_usage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_usage.Depth = 0;
            this.txt_total_usage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_total_usage.Hint = "Enter consumption";
            this.txt_total_usage.LeadingIcon = null;
            this.txt_total_usage.Location = new System.Drawing.Point(743, 200);
            this.txt_total_usage.MaxLength = 3;
            this.txt_total_usage.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_total_usage.Multiline = false;
            this.txt_total_usage.Name = "txt_total_usage";
            this.txt_total_usage.Size = new System.Drawing.Size(350, 50);
            this.txt_total_usage.TabIndex = 67;
            this.txt_total_usage.Text = "";
            this.txt_total_usage.TrailingIcon = null;
            this.txt_total_usage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_total_usage_KeyPress);
            // 
            // dgv_Service_Product
            // 
            this.dgv_Service_Product.AllowUserToAddRows = false;
            this.dgv_Service_Product.AllowUserToDeleteRows = false;
            this.dgv_Service_Product.AllowUserToResizeColumns = false;
            this.dgv_Service_Product.AllowUserToResizeRows = false;
            this.dgv_Service_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Service_Product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Service_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Service_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Service_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service_id,
            this.col_product_id,
            this.col_product__size_id,
            this.col_product_name,
            this.col_brand,
            this.col_total_usage,
            this.col_usage_btn_update,
            this.btn_delete});
            this.dgv_Service_Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_Service_Product.Location = new System.Drawing.Point(14, 673);
            this.dgv_Service_Product.Name = "dgv_Service_Product";
            this.dgv_Service_Product.ReadOnly = true;
            this.dgv_Service_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Service_Product.RowHeadersVisible = false;
            this.dgv_Service_Product.RowHeadersWidth = 51;
            this.dgv_Service_Product.RowTemplate.Height = 24;
            this.dgv_Service_Product.Size = new System.Drawing.Size(1236, 300);
            this.dgv_Service_Product.TabIndex = 9;
            this.dgv_Service_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Service_Product_CellClick);
            // 
            // col_service_id
            // 
            this.col_service_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_id.HeaderText = "Service ID";
            this.col_service_id.MinimumWidth = 6;
            this.col_service_id.Name = "col_service_id";
            this.col_service_id.ReadOnly = true;
            this.col_service_id.Visible = false;
            // 
            // col_product_id
            // 
            this.col_product_id.HeaderText = "product_id";
            this.col_product_id.MinimumWidth = 6;
            this.col_product_id.Name = "col_product_id";
            this.col_product_id.ReadOnly = true;
            this.col_product_id.Visible = false;
            this.col_product_id.Width = 125;
            // 
            // col_product__size_id
            // 
            this.col_product__size_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product__size_id.HeaderText = "product_size_id";
            this.col_product__size_id.MinimumWidth = 6;
            this.col_product__size_id.Name = "col_product__size_id";
            this.col_product__size_id.ReadOnly = true;
            this.col_product__size_id.Visible = false;
            this.col_product__size_id.Width = 125;
            // 
            // col_product_name
            // 
            this.col_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_name.HeaderText = "Product";
            this.col_product_name.MinimumWidth = 6;
            this.col_product_name.Name = "col_product_name";
            this.col_product_name.ReadOnly = true;
            // 
            // col_brand
            // 
            this.col_brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_brand.HeaderText = "Brand";
            this.col_brand.MinimumWidth = 6;
            this.col_brand.Name = "col_brand";
            this.col_brand.ReadOnly = true;
            // 
            // col_total_usage
            // 
            this.col_total_usage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_total_usage.HeaderText = "Quantity";
            this.col_total_usage.MinimumWidth = 6;
            this.col_total_usage.Name = "col_total_usage";
            this.col_total_usage.ReadOnly = true;
            this.col_total_usage.Width = 84;
            // 
            // col_usage_btn_update
            // 
            this.col_usage_btn_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_usage_btn_update.HeaderText = "";
            this.col_usage_btn_update.Image = ((System.Drawing.Image)(resources.GetObject("col_usage_btn_update.Image")));
            this.col_usage_btn_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_usage_btn_update.MinimumWidth = 6;
            this.col_usage_btn_update.Name = "col_usage_btn_update";
            this.col_usage_btn_update.ReadOnly = true;
            this.col_usage_btn_update.Width = 6;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_delete.HeaderText = "";
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_delete.MinimumWidth = 6;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ReadOnly = true;
            this.btn_delete.Width = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.txt_service_name);
            this.groupBox1.Controls.Add(this.cmb_sub_category);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_duration);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1236, 326);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVICE INFORMATION";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(36, 69);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(72, 24);
            this.materialLabel8.TabIndex = 72;
            this.materialLabel8.Text = "Service ";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(36, 180);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(82, 24);
            this.materialLabel7.TabIndex = 71;
            this.materialLabel7.Text = "Category";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(748, 69);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 24);
            this.materialLabel6.TabIndex = 70;
            this.materialLabel6.Text = "Price";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(748, 194);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(144, 24);
            this.materialLabel5.TabIndex = 69;
            this.materialLabel5.Text = "Duration: (mins)";
            // 
            // txt_service_name
            // 
            this.txt_service_name.AnimateReadOnly = false;
            this.txt_service_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_service_name.Depth = 0;
            this.txt_service_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_service_name.Hint = "Service Name";
            this.txt_service_name.LeadingIcon = null;
            this.txt_service_name.Location = new System.Drawing.Point(40, 96);
            this.txt_service_name.MaxLength = 50;
            this.txt_service_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_service_name.Multiline = false;
            this.txt_service_name.Name = "txt_service_name";
            this.txt_service_name.Size = new System.Drawing.Size(400, 50);
            this.txt_service_name.TabIndex = 18;
            this.txt_service_name.Text = "";
            this.txt_service_name.TrailingIcon = null;
            // 
            // cmb_sub_category
            // 
            this.cmb_sub_category.AutoResize = false;
            this.cmb_sub_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_sub_category.Depth = 0;
            this.cmb_sub_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_sub_category.DropDownHeight = 174;
            this.cmb_sub_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sub_category.DropDownWidth = 121;
            this.cmb_sub_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_sub_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_sub_category.FormattingEnabled = true;
            this.cmb_sub_category.Hint = "Select Category";
            this.cmb_sub_category.IntegralHeight = false;
            this.cmb_sub_category.ItemHeight = 43;
            this.cmb_sub_category.Location = new System.Drawing.Point(40, 207);
            this.cmb_sub_category.MaxDropDownItems = 4;
            this.cmb_sub_category.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_sub_category.Name = "cmb_sub_category";
            this.cmb_sub_category.Size = new System.Drawing.Size(400, 49);
            this.cmb_sub_category.StartIndex = 0;
            this.cmb_sub_category.TabIndex = 26;
            // 
            // txt_price
            // 
            this.txt_price.AnimateReadOnly = false;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Depth = 0;
            this.txt_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_price.Hint = "Price";
            this.txt_price.LeadingIcon = null;
            this.txt_price.Location = new System.Drawing.Point(743, 96);
            this.txt_price.MaxLength = 7;
            this.txt_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_price.Multiline = false;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(400, 50);
            this.txt_price.TabIndex = 30;
            this.txt_price.Text = "";
            this.txt_price.TrailingIcon = null;
            // 
            // txt_duration
            // 
            this.txt_duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_duration.Location = new System.Drawing.Point(752, 222);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(400, 34);
            this.txt_duration.TabIndex = 28;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(749, 200);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1, 0);
            this.materialLabel1.TabIndex = 29;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.DrawShadows = false;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(1075, 44);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "close";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.DrawShadows = false;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(32, 44);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "save changes";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.DrawShadows = false;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(35, 44);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.panel1);
            this.materialCard1.Controls.Add(this.dgv_Service_Product);
            this.materialCard1.Controls.Add(this.groupBox2);
            this.materialCard1.Controls.Add(this.groupBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 44);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1285, 853);
            this.materialCard1.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(14, 973);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 100);
            this.panel1.TabIndex = 37;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(1285, 900);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceForm";
            this.Padding = new System.Windows.Forms.Padding(0, 44, 0, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERVICE INFORMATION";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServiceForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service_Product)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_duration)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Service_Product;
        private MaterialSkin.Controls.MaterialButton btn_add_consumption;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialTextBox txt_service_name;
        private MaterialSkin.Controls.MaterialComboBox cmb_sub_category;
        private MaterialSkin.Controls.MaterialTextBox txt_price;
        private System.Windows.Forms.NumericUpDown txt_duration;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product__size_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_usage;
        private System.Windows.Forms.DataGridViewImageColumn col_usage_btn_update;
        private System.Windows.Forms.DataGridViewImageColumn btn_delete;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_total_usage;
        private MaterialSkin.Controls.MaterialTextBox txt_brand;
        private MaterialSkin.Controls.MaterialComboBox cmb_product;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lbl_usage_id;
        private MaterialSkin.Controls.MaterialButton btn_update_consumption;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txt_unit_type;
    }
}