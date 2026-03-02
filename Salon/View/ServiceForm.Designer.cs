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
            this.dgv_Service_Product = new System.Windows.Forms.DataGridView();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product__size_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_usage_btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_consumption = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.stylist_list_box = new System.Windows.Forms.CheckedListBox();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.txt_service_name = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_sub_category = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_price = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_status = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_duration = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service_Product)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_duration)).BeginInit();
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
            this.groupBox2.Controls.Add(this.dgv_Service_Product);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 515);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1285, 382);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCT CONSUMPTIONS";
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
            this.dgv_Service_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Service_Product.Location = new System.Drawing.Point(3, 80);
            this.dgv_Service_Product.Name = "dgv_Service_Product";
            this.dgv_Service_Product.ReadOnly = true;
            this.dgv_Service_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Service_Product.RowHeadersVisible = false;
            this.dgv_Service_Product.RowHeadersWidth = 51;
            this.dgv_Service_Product.RowTemplate.Height = 24;
            this.dgv_Service_Product.Size = new System.Drawing.Size(1279, 299);
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
            this.col_total_usage.Width = 137;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add_consumption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 50);
            this.panel1.TabIndex = 0;
            // 
            // btn_add_consumption
            // 
            this.btn_add_consumption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_consumption.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_consumption.Depth = 0;
            this.btn_add_consumption.DrawShadows = false;
            this.btn_add_consumption.HighEmphasis = true;
            this.btn_add_consumption.Icon = null;
            this.btn_add_consumption.Location = new System.Drawing.Point(36, 5);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.stylist_list_box);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.txt_service_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_sub_category);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.cmb_status);
            this.groupBox1.Controls.Add(this.txt_duration);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1285, 471);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVICE INFORMATION";
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
            this.btn_cancel.Location = new System.Drawing.Point(1115, 426);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // stylist_list_box
            // 
            this.stylist_list_box.FormattingEnabled = true;
            this.stylist_list_box.Location = new System.Drawing.Point(543, 190);
            this.stylist_list_box.Name = "stylist_list_box";
            this.stylist_list_box.Size = new System.Drawing.Size(624, 149);
            this.stylist_list_box.TabIndex = 33;
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
            this.btn_update.Location = new System.Drawing.Point(908, 426);
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
            this.btn_save.Location = new System.Drawing.Point(908, 426);
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
            // txt_service_name
            // 
            this.txt_service_name.AnimateReadOnly = false;
            this.txt_service_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_service_name.Depth = 0;
            this.txt_service_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_service_name.Hint = "Service Name";
            this.txt_service_name.LeadingIcon = null;
            this.txt_service_name.Location = new System.Drawing.Point(39, 63);
            this.txt_service_name.MaxLength = 50;
            this.txt_service_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_service_name.Multiline = false;
            this.txt_service_name.Name = "txt_service_name";
            this.txt_service_name.Size = new System.Drawing.Size(400, 50);
            this.txt_service_name.TabIndex = 18;
            this.txt_service_name.Text = "";
            this.txt_service_name.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Assign Stylist:";
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
            this.cmb_sub_category.Location = new System.Drawing.Point(39, 158);
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
            this.txt_price.Location = new System.Drawing.Point(39, 256);
            this.txt_price.MaxLength = 50;
            this.txt_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_price.Multiline = false;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(400, 50);
            this.txt_price.TabIndex = 30;
            this.txt_price.Text = "";
            this.txt_price.TrailingIcon = null;
            // 
            // cmb_status
            // 
            this.cmb_status.AutoResize = false;
            this.cmb_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_status.Depth = 0;
            this.cmb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_status.DropDownHeight = 174;
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.DropDownWidth = 121;
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Hint = "Select Status";
            this.cmb_status.IntegralHeight = false;
            this.cmb_status.ItemHeight = 43;
            this.cmb_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmb_status.Location = new System.Drawing.Point(39, 353);
            this.cmb_status.MaxDropDownItems = 4;
            this.cmb_status.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(400, 49);
            this.cmb_status.StartIndex = -1;
            this.cmb_status.TabIndex = 27;
            // 
            // txt_duration
            // 
            this.txt_duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_duration.Location = new System.Drawing.Point(543, 79);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(400, 34);
            this.txt_duration.TabIndex = 28;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(540, 41);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(116, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Duration: (mins)";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1285, 900);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service_Product)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_duration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Service_Product;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btn_add_consumption;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private System.Windows.Forms.CheckedListBox stylist_list_box;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialTextBox txt_service_name;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox cmb_sub_category;
        private MaterialSkin.Controls.MaterialTextBox txt_price;
        private MaterialSkin.Controls.MaterialComboBox cmb_status;
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
    }
}