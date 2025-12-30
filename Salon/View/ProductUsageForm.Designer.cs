namespace Salon.View
{
    partial class ProductUsageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUsageForm));
            this.cmb_product = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_brand = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_usage_type = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_total_usage = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txt_service = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_update_prodct_usage = new MaterialSkin.Controls.MaterialButton();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.dgv_Service_Product = new System.Windows.Forms.DataGridView();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_usage_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.cmb_product.Hint = "Select Product";
            this.cmb_product.IntegralHeight = false;
            this.cmb_product.ItemHeight = 43;
            this.cmb_product.Location = new System.Drawing.Point(30, 129);
            this.cmb_product.MaxDropDownItems = 4;
            this.cmb_product.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(263, 49);
            this.cmb_product.StartIndex = 0;
            this.cmb_product.TabIndex = 0;
            this.cmb_product.SelectedIndexChanged += new System.EventHandler(this.cmb_product_SelectedIndexChanged);
            // 
            // txt_brand
            // 
            this.txt_brand.AnimateReadOnly = true;
            this.txt_brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_brand.Depth = 0;
            this.txt_brand.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_brand.Hint = "Brand";
            this.txt_brand.LeadingIcon = null;
            this.txt_brand.Location = new System.Drawing.Point(30, 255);
            this.txt_brand.MaxLength = 50;
            this.txt_brand.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_brand.Multiline = false;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.ReadOnly = true;
            this.txt_brand.Size = new System.Drawing.Size(263, 50);
            this.txt_brand.TabIndex = 1;
            this.txt_brand.Text = "";
            this.txt_brand.TrailingIcon = null;
            // 
            // txt_usage_type
            // 
            this.txt_usage_type.AnimateReadOnly = true;
            this.txt_usage_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usage_type.Depth = 0;
            this.txt_usage_type.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_usage_type.Hint = "Usage Type";
            this.txt_usage_type.LeadingIcon = null;
            this.txt_usage_type.Location = new System.Drawing.Point(385, 131);
            this.txt_usage_type.MaxLength = 50;
            this.txt_usage_type.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_usage_type.Multiline = false;
            this.txt_usage_type.Name = "txt_usage_type";
            this.txt_usage_type.ReadOnly = true;
            this.txt_usage_type.Size = new System.Drawing.Size(263, 50);
            this.txt_usage_type.TabIndex = 2;
            this.txt_usage_type.Text = "";
            this.txt_usage_type.TrailingIcon = null;
            // 
            // txt_total_usage
            // 
            this.txt_total_usage.AnimateReadOnly = false;
            this.txt_total_usage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_usage.Depth = 0;
            this.txt_total_usage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_total_usage.Hint = "Quantity";
            this.txt_total_usage.LeadingIcon = null;
            this.txt_total_usage.Location = new System.Drawing.Point(385, 255);
            this.txt_total_usage.MaxLength = 50;
            this.txt_total_usage.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_total_usage.Multiline = false;
            this.txt_total_usage.Name = "txt_total_usage";
            this.txt_total_usage.Size = new System.Drawing.Size(263, 50);
            this.txt_total_usage.TabIndex = 5;
            this.txt_total_usage.Text = "";
            this.txt_total_usage.TrailingIcon = null;
            this.txt_total_usage.TextChanged += new System.EventHandler(this.txt_total_usage_TextChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txt_service);
            this.materialCard1.Controls.Add(this.btn_cancel);
            this.materialCard1.Controls.Add(this.btn_update_prodct_usage);
            this.materialCard1.Controls.Add(this.btn_add);
            this.materialCard1.Controls.Add(this.txt_total_usage);
            this.materialCard1.Controls.Add(this.txt_usage_type);
            this.materialCard1.Controls.Add(this.txt_brand);
            this.materialCard1.Controls.Add(this.cmb_product);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1279, 353);
            this.materialCard1.TabIndex = 6;
            // 
            // txt_service
            // 
            this.txt_service.AnimateReadOnly = true;
            this.txt_service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_service.Depth = 0;
            this.txt_service.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_service.Hint = "Selected Service";
            this.txt_service.LeadingIcon = null;
            this.txt_service.Location = new System.Drawing.Point(30, 30);
            this.txt_service.MaxLength = 50;
            this.txt_service.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_service.Multiline = false;
            this.txt_service.Name = "txt_service";
            this.txt_service.ReadOnly = true;
            this.txt_service.Size = new System.Drawing.Size(618, 50);
            this.txt_service.TabIndex = 9;
            this.txt_service.Text = "";
            this.txt_service.TrailingIcon = null;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(1075, 157);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update_prodct_usage
            // 
            this.btn_update_prodct_usage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_prodct_usage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update_prodct_usage.Depth = 0;
            this.btn_update_prodct_usage.HighEmphasis = true;
            this.btn_update_prodct_usage.Icon = null;
            this.btn_update_prodct_usage.Location = new System.Drawing.Point(1075, 81);
            this.btn_update_prodct_usage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update_prodct_usage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update_prodct_usage.Name = "btn_update_prodct_usage";
            this.btn_update_prodct_usage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update_prodct_usage.Size = new System.Drawing.Size(129, 36);
            this.btn_update_prodct_usage.TabIndex = 7;
            this.btn_update_prodct_usage.Text = "save changes";
            this.btn_update_prodct_usage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update_prodct_usage.UseAccentColor = false;
            this.btn_update_prodct_usage.UseVisualStyleBackColor = true;
            this.btn_update_prodct_usage.Visible = false;
            this.btn_update_prodct_usage.Click += new System.EventHandler(this.btn_update_prodct_usage_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add.Depth = 0;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(1127, 44);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add.Size = new System.Drawing.Size(64, 36);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add.UseAccentColor = false;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.col_product_name,
            this.col_brand,
            this.col_usage_type,
            this.col_total_usage,
            this.btn_update,
            this.btn_delete});
            this.dgv_Service_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Service_Product.Location = new System.Drawing.Point(3, 417);
            this.dgv_Service_Product.Name = "dgv_Service_Product";
            this.dgv_Service_Product.ReadOnly = true;
            this.dgv_Service_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Service_Product.RowHeadersVisible = false;
            this.dgv_Service_Product.RowHeadersWidth = 51;
            this.dgv_Service_Product.RowTemplate.Height = 24;
            this.dgv_Service_Product.Size = new System.Drawing.Size(1279, 299);
            this.dgv_Service_Product.TabIndex = 7;
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
            // col_usage_type
            // 
            this.col_usage_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_usage_type.HeaderText = "Usage Type";
            this.col_usage_type.MinimumWidth = 6;
            this.col_usage_type.Name = "col_usage_type";
            this.col_usage_type.ReadOnly = true;
            this.col_usage_type.Width = 112;
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
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_update.HeaderText = "";
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_update.MinimumWidth = 6;
            this.btn_update.Name = "btn_update";
            this.btn_update.ReadOnly = true;
            this.btn_update.Width = 6;
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
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductUsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 719);
            this.Controls.Add(this.dgv_Service_Product);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductUsageForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCT USAGE INFORMATION";
            this.Load += new System.EventHandler(this.ProductUsageForm_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmb_product;
        private MaterialSkin.Controls.MaterialTextBox txt_brand;
        private MaterialSkin.Controls.MaterialTextBox txt_usage_type;
        private MaterialSkin.Controls.MaterialTextBox txt_total_usage;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView dgv_Service_Product;
        private MaterialSkin.Controls.MaterialButton btn_add;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_update_prodct_usage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_usage_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_usage;
        private System.Windows.Forms.DataGridViewImageColumn btn_update;
        private System.Windows.Forms.DataGridViewImageColumn btn_delete;
        private MaterialSkin.Controls.MaterialTextBox txt_service;
    }
}