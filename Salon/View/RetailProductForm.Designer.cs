namespace Salon.View
{
    partial class RetailProductForm
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
            this.txt_selling_price = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_content = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_cost_price = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_product_size_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_product_size_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_product_size_save = new MaterialSkin.Controls.MaterialButton();
            this.dgv_product_size = new System.Windows.Forms.DataGridView();
            this.col_product_size_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coL_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_sale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_cost_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size_update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_product_size_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_size_label = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.cmb_unit_type = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.productTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_brand = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_product_name = new MaterialSkin.Controls.MaterialTextBox();
            this.productTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_size)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.productTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_selling_price
            // 
            this.txt_selling_price.AnimateReadOnly = false;
            this.txt_selling_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_selling_price.Depth = 0;
            this.txt_selling_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_selling_price.Hint = "Enter Selling Price";
            this.txt_selling_price.LeadingIcon = null;
            this.txt_selling_price.Location = new System.Drawing.Point(231, 206);
            this.txt_selling_price.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.txt_selling_price.MaxLength = 50;
            this.txt_selling_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_selling_price.Multiline = false;
            this.txt_selling_price.Name = "txt_selling_price";
            this.txt_selling_price.Size = new System.Drawing.Size(500, 50);
            this.txt_selling_price.TabIndex = 52;
            this.txt_selling_price.Text = "";
            this.txt_selling_price.TrailingIcon = null;
            // 
            // txt_content
            // 
            this.txt_content.AnimateReadOnly = false;
            this.txt_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_content.Depth = 0;
            this.txt_content.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_content.Hint = "Enter content";
            this.txt_content.LeadingIcon = null;
            this.txt_content.Location = new System.Drawing.Point(231, 121);
            this.txt_content.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.txt_content.MaxLength = 50;
            this.txt_content.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_content.Multiline = false;
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(500, 50);
            this.txt_content.TabIndex = 50;
            this.txt_content.Text = "";
            this.txt_content.TrailingIcon = null;
            // 
            // txt_cost_price
            // 
            this.txt_cost_price.AnimateReadOnly = false;
            this.txt_cost_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cost_price.Depth = 0;
            this.txt_cost_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cost_price.Hint = "Enter cost price";
            this.txt_cost_price.LeadingIcon = null;
            this.txt_cost_price.Location = new System.Drawing.Point(231, 291);
            this.txt_cost_price.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.txt_cost_price.MaxLength = 50;
            this.txt_cost_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_cost_price.Multiline = false;
            this.txt_cost_price.Name = "txt_cost_price";
            this.txt_cost_price.Size = new System.Drawing.Size(500, 50);
            this.txt_cost_price.TabIndex = 49;
            this.txt_cost_price.Text = "";
            this.txt_cost_price.TrailingIcon = null;
            // 
            // btn_product_size_cancel
            // 
            this.btn_product_size_cancel.AutoSize = false;
            this.btn_product_size_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_product_size_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_product_size_cancel.Depth = 0;
            this.btn_product_size_cancel.HighEmphasis = true;
            this.btn_product_size_cancel.Icon = null;
            this.btn_product_size_cancel.Location = new System.Drawing.Point(684, 371);
            this.btn_product_size_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_product_size_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_product_size_cancel.Name = "btn_product_size_cancel";
            this.btn_product_size_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_product_size_cancel.Size = new System.Drawing.Size(129, 36);
            this.btn_product_size_cancel.TabIndex = 47;
            this.btn_product_size_cancel.Text = "cancel";
            this.btn_product_size_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_product_size_cancel.UseAccentColor = false;
            this.btn_product_size_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_product_size_update
            // 
            this.btn_product_size_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_product_size_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_product_size_update.Depth = 0;
            this.btn_product_size_update.DrawShadows = false;
            this.btn_product_size_update.Enabled = false;
            this.btn_product_size_update.HighEmphasis = true;
            this.btn_product_size_update.Icon = null;
            this.btn_product_size_update.Location = new System.Drawing.Point(472, 371);
            this.btn_product_size_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_product_size_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_product_size_update.Name = "btn_product_size_update";
            this.btn_product_size_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_product_size_update.Size = new System.Drawing.Size(129, 36);
            this.btn_product_size_update.TabIndex = 48;
            this.btn_product_size_update.Text = "save changes";
            this.btn_product_size_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_product_size_update.UseAccentColor = false;
            this.btn_product_size_update.UseVisualStyleBackColor = true;
            this.btn_product_size_update.Click += new System.EventHandler(this.btn_product_size_update_Click);
            // 
            // btn_product_size_save
            // 
            this.btn_product_size_save.AutoSize = false;
            this.btn_product_size_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_product_size_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_product_size_save.Depth = 0;
            this.btn_product_size_save.HighEmphasis = true;
            this.btn_product_size_save.Icon = null;
            this.btn_product_size_save.Location = new System.Drawing.Point(231, 372);
            this.btn_product_size_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_product_size_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_product_size_save.Name = "btn_product_size_save";
            this.btn_product_size_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_product_size_save.Size = new System.Drawing.Size(129, 36);
            this.btn_product_size_save.TabIndex = 46;
            this.btn_product_size_save.Text = "save";
            this.btn_product_size_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_product_size_save.UseAccentColor = false;
            this.btn_product_size_save.UseVisualStyleBackColor = true;
            this.btn_product_size_save.Click += new System.EventHandler(this.btn_product_size_save_Click);
            // 
            // dgv_product_size
            // 
            this.dgv_product_size.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product_size.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_size_id,
            this.col_product_id,
            this.coL_product_name,
            this.col_product_size_label,
            this.col_product_content,
            this.col_product_sale_price,
            this.col_product_cost_price,
            this.col_product_size_update,
            this.col_product_size_delete});
            this.dgv_product_size.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_product_size.Location = new System.Drawing.Point(14, 444);
            this.dgv_product_size.Name = "dgv_product_size";
            this.dgv_product_size.RowHeadersWidth = 51;
            this.dgv_product_size.RowTemplate.Height = 24;
            this.dgv_product_size.Size = new System.Drawing.Size(837, 205);
            this.dgv_product_size.TabIndex = 45;
            this.dgv_product_size.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_size_CellClick);
            // 
            // col_product_size_id
            // 
            this.col_product_size_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_size_id.HeaderText = "size_id";
            this.col_product_size_id.MinimumWidth = 6;
            this.col_product_size_id.Name = "col_product_size_id";
            this.col_product_size_id.Visible = false;
            this.col_product_size_id.Width = 125;
            // 
            // col_product_id
            // 
            this.col_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_id.HeaderText = "product_id";
            this.col_product_id.MinimumWidth = 6;
            this.col_product_id.Name = "col_product_id";
            this.col_product_id.Visible = false;
            this.col_product_id.Width = 125;
            // 
            // coL_product_name
            // 
            this.coL_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coL_product_name.HeaderText = "Product Name";
            this.coL_product_name.MinimumWidth = 6;
            this.coL_product_name.Name = "coL_product_name";
            // 
            // col_product_size_label
            // 
            this.col_product_size_label.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_size_label.HeaderText = "Size  Label";
            this.col_product_size_label.MinimumWidth = 6;
            this.col_product_size_label.Name = "col_product_size_label";
            // 
            // col_product_content
            // 
            this.col_product_content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_content.HeaderText = "Content";
            this.col_product_content.MinimumWidth = 6;
            this.col_product_content.Name = "col_product_content";
            this.col_product_content.Width = 81;
            // 
            // col_product_sale_price
            // 
            this.col_product_sale_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_sale_price.HeaderText = "Selling Price";
            this.col_product_sale_price.MinimumWidth = 6;
            this.col_product_sale_price.Name = "col_product_sale_price";
            this.col_product_sale_price.Width = 102;
            // 
            // col_product_cost_price
            // 
            this.col_product_cost_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_cost_price.HeaderText = "Cost Price";
            this.col_product_cost_price.MinimumWidth = 6;
            this.col_product_cost_price.Name = "col_product_cost_price";
            this.col_product_cost_price.Width = 90;
            // 
            // col_product_size_update
            // 
            this.col_product_size_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_size_update.HeaderText = "Update";
            this.col_product_size_update.MinimumWidth = 6;
            this.col_product_size_update.Name = "col_product_size_update";
            this.col_product_size_update.Width = 58;
            // 
            // col_product_size_delete
            // 
            this.col_product_size_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_size_delete.HeaderText = "Delete";
            this.col_product_size_delete.MinimumWidth = 6;
            this.col_product_size_delete.Name = "col_product_size_delete";
            this.col_product_size_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_product_size_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_product_size_delete.Width = 76;
            // 
            // txt_size_label
            // 
            this.txt_size_label.AnimateReadOnly = false;
            this.txt_size_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_size_label.Depth = 0;
            this.txt_size_label.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_size_label.Hint = "Enter size label";
            this.txt_size_label.LeadingIcon = null;
            this.txt_size_label.Location = new System.Drawing.Point(231, 36);
            this.txt_size_label.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.txt_size_label.MaxLength = 50;
            this.txt_size_label.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_size_label.Multiline = false;
            this.txt_size_label.Name = "txt_size_label";
            this.txt_size_label.Size = new System.Drawing.Size(500, 50);
            this.txt_size_label.TabIndex = 37;
            this.txt_size_label.Text = "";
            this.txt_size_label.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(17, 232);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(117, 24);
            this.materialLabel7.TabIndex = 51;
            this.materialLabel7.Text = "Selling Price:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(17, 317);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 24);
            this.materialLabel2.TabIndex = 44;
            this.materialLabel2.Text = "Cost Price:";
            // 
            // materialCard2
            // 
            this.materialCard2.AutoScroll = true;
            this.materialCard2.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.txt_selling_price);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Controls.Add(this.txt_content);
            this.materialCard2.Controls.Add(this.txt_cost_price);
            this.materialCard2.Controls.Add(this.btn_product_size_cancel);
            this.materialCard2.Controls.Add(this.btn_product_size_update);
            this.materialCard2.Controls.Add(this.btn_product_size_save);
            this.materialCard2.Controls.Add(this.dgv_product_size);
            this.materialCard2.Controls.Add(this.txt_size_label);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.materialLabel8);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(3, 3);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(886, 450);
            this.materialCard2.TabIndex = 45;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(17, 62);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(98, 24);
            this.materialLabel8.TabIndex = 41;
            this.materialLabel8.Text = "Size Label:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(17, 146);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(77, 24);
            this.materialLabel5.TabIndex = 42;
            this.materialLabel5.Text = "Content:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = false;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(733, 387);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(129, 36);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.DrawShadows = false;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(453, 387);
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
            // btn_save
            // 
            this.btn_save.AutoSize = false;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(453, 387);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(129, 36);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_unit_type
            // 
            this.cmb_unit_type.AutoResize = false;
            this.cmb_unit_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_unit_type.Depth = 0;
            this.cmb_unit_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_unit_type.DropDownHeight = 174;
            this.cmb_unit_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unit_type.DropDownWidth = 121;
            this.cmb_unit_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_unit_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_unit_type.FormattingEnabled = true;
            this.cmb_unit_type.Hint = "Select Unit Type";
            this.cmb_unit_type.IntegralHeight = false;
            this.cmb_unit_type.ItemHeight = 43;
            this.cmb_unit_type.Items.AddRange(new object[] {
            "ml",
            "g",
            "pcs"});
            this.cmb_unit_type.Location = new System.Drawing.Point(231, 290);
            this.cmb_unit_type.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.cmb_unit_type.MaxDropDownItems = 4;
            this.cmb_unit_type.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_unit_type.Name = "cmb_unit_type";
            this.cmb_unit_type.Size = new System.Drawing.Size(500, 49);
            this.cmb_unit_type.StartIndex = -1;
            this.cmb_unit_type.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Product Size";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(17, 315);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(91, 24);
            this.materialLabel6.TabIndex = 36;
            this.materialLabel6.Text = "Unit Type:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(17, 62);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 24);
            this.materialLabel1.TabIndex = 31;
            this.materialLabel1.Text = "Product Name:";
            // 
            // productTabControl
            // 
            this.productTabControl.Controls.Add(this.tabPage1);
            this.productTabControl.Controls.Add(this.tabPage2);
            this.productTabControl.Depth = 0;
            this.productTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTabControl.Location = new System.Drawing.Point(0, 112);
            this.productTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.productTabControl.Multiline = true;
            this.productTabControl.Name = "productTabControl";
            this.productTabControl.SelectedIndex = 0;
            this.productTabControl.Size = new System.Drawing.Size(900, 485);
            this.productTabControl.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Retail Product Details";
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_cancel);
            this.materialCard1.Controls.Add(this.btn_update);
            this.materialCard1.Controls.Add(this.btn_save);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.cmb_unit_type);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.txt_brand);
            this.materialCard1.Controls.Add(this.txt_product_name);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(886, 450);
            this.materialCard1.TabIndex = 37;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(17, 149);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(59, 24);
            this.materialLabel4.TabIndex = 34;
            this.materialLabel4.Text = "Brand:";
            // 
            // txt_brand
            // 
            this.txt_brand.AnimateReadOnly = false;
            this.txt_brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_brand.Depth = 0;
            this.txt_brand.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_brand.Hint = "Enter Brand";
            this.txt_brand.LeadingIcon = null;
            this.txt_brand.Location = new System.Drawing.Point(231, 166);
            this.txt_brand.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.txt_brand.MaxLength = 50;
            this.txt_brand.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_brand.Multiline = false;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(500, 50);
            this.txt_brand.TabIndex = 19;
            this.txt_brand.Text = "";
            this.txt_brand.TrailingIcon = null;
            // 
            // txt_product_name
            // 
            this.txt_product_name.AnimateReadOnly = false;
            this.txt_product_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_product_name.Depth = 0;
            this.txt_product_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_product_name.Hint = "Enter product name";
            this.txt_product_name.LeadingIcon = null;
            this.txt_product_name.Location = new System.Drawing.Point(231, 36);
            this.txt_product_name.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.txt_product_name.MaxLength = 50;
            this.txt_product_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_product_name.Multiline = false;
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(500, 50);
            this.txt_product_name.TabIndex = 18;
            this.txt_product_name.Text = "";
            this.txt_product_name.TrailingIcon = null;
            // 
            // productTabSelector
            // 
            this.productTabSelector.BaseTabControl = this.productTabControl;
            this.productTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.productTabSelector.Depth = 0;
            this.productTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.productTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productTabSelector.Location = new System.Drawing.Point(0, 64);
            this.productTabSelector.Margin = new System.Windows.Forms.Padding(0);
            this.productTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.productTabSelector.Name = "productTabSelector";
            this.productTabSelector.Size = new System.Drawing.Size(900, 48);
            this.productTabSelector.TabIndex = 41;
            this.productTabSelector.Text = "materialTabSelector1";
            // 
            // RetailProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.productTabControl);
            this.Controls.Add(this.productTabSelector);
            this.Name = "RetailProductForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetailProductForm";
            this.Load += new System.EventHandler(this.RetailProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_size)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.productTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_selling_price;
        private MaterialSkin.Controls.MaterialTextBox txt_content;
        private MaterialSkin.Controls.MaterialTextBox txt_cost_price;
        private MaterialSkin.Controls.MaterialButton btn_product_size_cancel;
        private MaterialSkin.Controls.MaterialButton btn_product_size_update;
        private MaterialSkin.Controls.MaterialButton btn_product_size_save;
        private System.Windows.Forms.DataGridView dgv_product_size;
        private MaterialSkin.Controls.MaterialTextBox txt_size_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialComboBox cmb_unit_type;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialTabControl productTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_brand;
        private MaterialSkin.Controls.MaterialTextBox txt_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coL_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_sale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_cost_price;
        private System.Windows.Forms.DataGridViewButtonColumn col_product_size_update;
        private System.Windows.Forms.DataGridViewButtonColumn col_product_size_delete;
        private MaterialSkin.Controls.MaterialTabSelector productTabSelector;
    }
}