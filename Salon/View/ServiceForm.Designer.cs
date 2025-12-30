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
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.txt_service_name = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_sub_category = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_status = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_duration = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_price = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btn_update_prodct_usage = new MaterialSkin.Controls.MaterialButton();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.txt_total_usage = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_brand = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_product = new MaterialSkin.Controls.MaterialComboBox();
            this.dgv_Service_Product = new System.Windows.Forms.DataGridView();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_usage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_usage_btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txt_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service_Product)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_update.Location = new System.Drawing.Point(852, 379);
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
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
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
            this.btn_cancel.Location = new System.Drawing.Point(1154, 379);
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
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.btn_save.Location = new System.Drawing.Point(852, 379);
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
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_service_name
            // 
            this.txt_service_name.AnimateReadOnly = false;
            this.txt_service_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_service_name.Depth = 0;
            this.txt_service_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_service_name.Hint = "Service Name";
            this.txt_service_name.LeadingIcon = null;
            this.txt_service_name.Location = new System.Drawing.Point(42, 67);
            this.txt_service_name.MaxLength = 50;
            this.txt_service_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_service_name.Multiline = false;
            this.txt_service_name.Name = "txt_service_name";
            this.txt_service_name.Size = new System.Drawing.Size(400, 50);
            this.txt_service_name.TabIndex = 18;
            this.txt_service_name.Text = "";
            this.txt_service_name.TrailingIcon = null;
            this.txt_service_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_service_name_KeyPress);
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
            this.cmb_sub_category.Location = new System.Drawing.Point(42, 184);
            this.cmb_sub_category.MaxDropDownItems = 4;
            this.cmb_sub_category.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_sub_category.Name = "cmb_sub_category";
            this.cmb_sub_category.Size = new System.Drawing.Size(400, 49);
            this.cmb_sub_category.StartIndex = 0;
            this.cmb_sub_category.TabIndex = 26;
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
            this.cmb_status.Location = new System.Drawing.Point(543, 68);
            this.cmb_status.MaxDropDownItems = 4;
            this.cmb_status.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(400, 49);
            this.cmb_status.StartIndex = -1;
            this.cmb_status.TabIndex = 27;
            this.cmb_status.SelectedIndexChanged += new System.EventHandler(this.cmb_status_SelectedIndexChanged);
            // 
            // txt_duration
            // 
            this.txt_duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_duration.Location = new System.Drawing.Point(543, 211);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(400, 22);
            this.txt_duration.TabIndex = 28;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(540, 184);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(116, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Duration: (mins)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_price
            // 
            this.txt_price.AnimateReadOnly = false;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Depth = 0;
            this.txt_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_price.Hint = "Price";
            this.txt_price.LeadingIcon = null;
            this.txt_price.Location = new System.Drawing.Point(42, 290);
            this.txt_price.MaxLength = 50;
            this.txt_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_price.Multiline = false;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(400, 50);
            this.txt_price.TabIndex = 30;
            this.txt_price.Text = "";
            this.txt_price.TrailingIcon = null;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 72);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1285, 479);
            this.materialTabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txt_service_name);
            this.tabPage1.Controls.Add(this.txt_price);
            this.tabPage1.Controls.Add(this.btn_cancel);
            this.tabPage1.Controls.Add(this.btn_update);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.cmb_sub_category);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.cmb_status);
            this.tabPage1.Controls.Add(this.txt_duration);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1277, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Service Details";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_Service_Product);
            this.tabPage2.Controls.Add(this.materialCard1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1277, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service Product Consumption";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1285, 48);
            this.materialTabSelector1.TabIndex = 33;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.SystemColors.Control;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = false;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1127, 285);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(77, 36);
            this.materialButton1.TabIndex = 8;
            this.materialButton1.Text = "cancel";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Visible = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btn_update_prodct_usage
            // 
            this.btn_update_prodct_usage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_prodct_usage.BackColor = System.Drawing.SystemColors.Control;
            this.btn_update_prodct_usage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update_prodct_usage.Depth = 0;
            this.btn_update_prodct_usage.DrawShadows = false;
            this.btn_update_prodct_usage.HighEmphasis = true;
            this.btn_update_prodct_usage.Icon = null;
            this.btn_update_prodct_usage.Location = new System.Drawing.Point(882, 285);
            this.btn_update_prodct_usage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update_prodct_usage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update_prodct_usage.Name = "btn_update_prodct_usage";
            this.btn_update_prodct_usage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update_prodct_usage.Size = new System.Drawing.Size(129, 36);
            this.btn_update_prodct_usage.TabIndex = 7;
            this.btn_update_prodct_usage.Text = "save changes";
            this.btn_update_prodct_usage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update_prodct_usage.UseAccentColor = false;
            this.btn_update_prodct_usage.UseVisualStyleBackColor = false;
            this.btn_update_prodct_usage.Visible = false;
            this.btn_update_prodct_usage.Click += new System.EventHandler(this.btn_update_prodct_usage_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add.Depth = 0;
            this.btn_add.DrawShadows = false;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(882, 285);
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
            // txt_total_usage
            // 
            this.txt_total_usage.AnimateReadOnly = false;
            this.txt_total_usage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_usage.Depth = 0;
            this.txt_total_usage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_total_usage.Hint = "Enter quantity";
            this.txt_total_usage.LeadingIcon = null;
            this.txt_total_usage.Location = new System.Drawing.Point(242, 261);
            this.txt_total_usage.MaxLength = 50;
            this.txt_total_usage.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_total_usage.Multiline = false;
            this.txt_total_usage.Name = "txt_total_usage";
            this.txt_total_usage.Size = new System.Drawing.Size(450, 50);
            this.txt_total_usage.TabIndex = 5;
            this.txt_total_usage.Text = "";
            this.txt_total_usage.TrailingIcon = null;
            // 
            // txt_brand
            // 
            this.txt_brand.AnimateReadOnly = true;
            this.txt_brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_brand.Depth = 0;
            this.txt_brand.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_brand.Hint = "Enter brand";
            this.txt_brand.LeadingIcon = null;
            this.txt_brand.Location = new System.Drawing.Point(242, 159);
            this.txt_brand.MaxLength = 50;
            this.txt_brand.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_brand.Multiline = false;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.ReadOnly = true;
            this.txt_brand.Size = new System.Drawing.Size(450, 50);
            this.txt_brand.TabIndex = 1;
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
            this.cmb_product.Location = new System.Drawing.Point(242, 55);
            this.cmb_product.MaxDropDownItems = 4;
            this.cmb_product.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(450, 49);
            this.cmb_product.StartIndex = 0;
            this.cmb_product.TabIndex = 0;
            this.cmb_product.SelectedIndexChanged += new System.EventHandler(this.cmb_product_SelectedIndexChanged);
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
            this.col_product_name,
            this.col_brand,
            this.col_total_usage,
            this.col_usage_btn_update,
            this.btn_delete});
            this.dgv_Service_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Service_Product.Location = new System.Drawing.Point(3, 356);
            this.dgv_Service_Product.Name = "dgv_Service_Product";
            this.dgv_Service_Product.ReadOnly = true;
            this.dgv_Service_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Service_Product.RowHeadersVisible = false;
            this.dgv_Service_Product.RowHeadersWidth = 51;
            this.dgv_Service_Product.RowTemplate.Height = 24;
            this.dgv_Service_Product.Size = new System.Drawing.Size(1271, 91);
            this.dgv_Service_Product.TabIndex = 9;
            this.dgv_Service_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Service_Product_CellClick);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.btn_update_prodct_usage);
            this.materialCard1.Controls.Add(this.btn_add);
            this.materialCard1.Controls.Add(this.txt_total_usage);
            this.materialCard1.Controls.Add(this.txt_brand);
            this.materialCard1.Controls.Add(this.cmb_product);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1271, 353);
            this.materialCard1.TabIndex = 8;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(42, 68);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(60, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Product:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(42, 173);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Brand:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(42, 275);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(65, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Quantity:";
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
            this.col_product_id.Width = 125;
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
            this.col_usage_btn_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            this.btn_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btn_delete.HeaderText = "";
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_delete.MinimumWidth = 6;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ReadOnly = true;
            this.btn_delete.Width = 6;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1285, 554);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceForm";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERVICE INFORMATION";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServiceForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txt_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service_Product)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialTextBox txt_service_name;
        private MaterialSkin.Controls.MaterialComboBox cmb_sub_category;
        private MaterialSkin.Controls.MaterialComboBox cmb_status;
        private System.Windows.Forms.NumericUpDown txt_duration;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialTextBox txt_price;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.DataGridView dgv_Service_Product;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btn_update_prodct_usage;
        private MaterialSkin.Controls.MaterialButton btn_add;
        private MaterialSkin.Controls.MaterialTextBox txt_total_usage;
        private MaterialSkin.Controls.MaterialTextBox txt_brand;
        private MaterialSkin.Controls.MaterialComboBox cmb_product;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_usage;
        private System.Windows.Forms.DataGridViewImageColumn col_usage_btn_update;
        private System.Windows.Forms.DataGridViewImageColumn btn_delete;
    }
}