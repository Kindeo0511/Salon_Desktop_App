namespace Salon.View
{
    partial class ProductForm
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_size_label = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_product_size_save = new MaterialSkin.Controls.MaterialButton();
            this.btn_product_size_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_product_size_cancel = new MaterialSkin.Controls.MaterialButton();
            this.txt_cost_price = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_content = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_product_size = new System.Windows.Forms.DataGridView();
            this.col_product_size_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coL_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_cost_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size_update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_product_size_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_size = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_ingredient = new MaterialSkin.Controls.MaterialCheckbox();
            this.chk_retail = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.txt_product_name = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_brand = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_unit_type = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_size)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
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
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(17, 232);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 24);
            this.materialLabel2.TabIndex = 44;
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
            // btn_product_size_save
            // 
            this.btn_product_size_save.AutoSize = false;
            this.btn_product_size_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_product_size_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_product_size_save.Depth = 0;
            this.btn_product_size_save.HighEmphasis = true;
            this.btn_product_size_save.Icon = null;
            this.btn_product_size_save.Location = new System.Drawing.Point(231, 343);
            this.btn_product_size_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_product_size_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_product_size_save.Name = "btn_product_size_save";
            this.btn_product_size_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_product_size_save.Size = new System.Drawing.Size(129, 36);
            this.btn_product_size_save.TabIndex = 46;
            this.btn_product_size_save.Text = "Add";
            this.btn_product_size_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_product_size_save.UseAccentColor = false;
            this.btn_product_size_save.UseVisualStyleBackColor = true;
            this.btn_product_size_save.Click += new System.EventHandler(this.btn_product_size_save_Click);
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
            this.btn_product_size_update.Location = new System.Drawing.Point(445, 343);
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
            // btn_product_size_cancel
            // 
            this.btn_product_size_cancel.AutoSize = false;
            this.btn_product_size_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_product_size_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_product_size_cancel.Depth = 0;
            this.btn_product_size_cancel.HighEmphasis = true;
            this.btn_product_size_cancel.Icon = null;
            this.btn_product_size_cancel.Location = new System.Drawing.Point(686, 343);
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
            this.btn_product_size_cancel.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txt_cost_price
            // 
            this.txt_cost_price.AnimateReadOnly = false;
            this.txt_cost_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cost_price.Depth = 0;
            this.txt_cost_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cost_price.Hint = "Enter cost price";
            this.txt_cost_price.LeadingIcon = null;
            this.txt_cost_price.Location = new System.Drawing.Point(231, 206);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_product_size);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 452);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(1190, 338);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sizes for this Product  ";
            // 
            // dgv_product_size
            // 
            this.dgv_product_size.AllowUserToAddRows = false;
            this.dgv_product_size.AllowUserToDeleteRows = false;
            this.dgv_product_size.AllowUserToResizeColumns = false;
            this.dgv_product_size.AllowUserToResizeRows = false;
            this.dgv_product_size.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_product_size.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_product_size.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_product_size.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product_size.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_size_id,
            this.col_product_id,
            this.coL_product_name,
            this.col_product_size_label,
            this.col_product_content,
            this.col_product_cost_price,
            this.col_product_size_update,
            this.col_product_size_delete});
            this.dgv_product_size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_product_size.Location = new System.Drawing.Point(3, 89);
            this.dgv_product_size.Name = "dgv_product_size";
            this.dgv_product_size.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_product_size.RowHeadersVisible = false;
            this.dgv_product_size.RowHeadersWidth = 51;
            this.dgv_product_size.RowTemplate.Height = 24;
            this.dgv_product_size.Size = new System.Drawing.Size(1184, 246);
            this.dgv_product_size.TabIndex = 45;
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
            this.col_product_content.Width = 117;
            // 
            // col_product_cost_price
            // 
            this.col_product_cost_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_cost_price.HeaderText = "Cost Price";
            this.col_product_cost_price.MinimumWidth = 6;
            this.col_product_cost_price.Name = "col_product_cost_price";
            this.col_product_cost_price.Width = 129;
            // 
            // col_product_size_update
            // 
            this.col_product_size_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_size_update.HeaderText = "Update";
            this.col_product_size_update.MinimumWidth = 6;
            this.col_product_size_update.Name = "col_product_size_update";
            this.col_product_size_update.Text = "Edit";
            this.col_product_size_update.UseColumnTextForButtonValue = true;
            this.col_product_size_update.Width = 87;
            // 
            // col_product_size_delete
            // 
            this.col_product_size_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_size_delete.HeaderText = "Delete";
            this.col_product_size_delete.MinimumWidth = 6;
            this.col_product_size_delete.Name = "col_product_size_delete";
            this.col_product_size_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_product_size_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_product_size_delete.Text = "Delete";
            this.col_product_size_delete.UseColumnTextForButtonValue = true;
            this.col_product_size_delete.Width = 103;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add_size);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 51);
            this.panel1.TabIndex = 46;
            // 
            // btn_add_size
            // 
            this.btn_add_size.AutoSize = false;
            this.btn_add_size.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_size.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_size.Depth = 0;
            this.btn_add_size.DrawShadows = false;
            this.btn_add_size.HighEmphasis = true;
            this.btn_add_size.Icon = null;
            this.btn_add_size.Location = new System.Drawing.Point(24, 6);
            this.btn_add_size.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_size.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_size.Name = "btn_add_size";
            this.btn_add_size.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_size.Size = new System.Drawing.Size(129, 36);
            this.btn_add_size.TabIndex = 24;
            this.btn_add_size.Text = "add new size";
            this.btn_add_size.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_size.UseAccentColor = false;
            this.btn_add_size.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_ingredient);
            this.groupBox1.Controls.Add(this.chk_retail);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.txt_product_name);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txt_brand);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.cmb_unit_type);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.groupBox1.Size = new System.Drawing.Size(1190, 408);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT INFORMATION";
            // 
            // chk_ingredient
            // 
            this.chk_ingredient.AutoSize = true;
            this.chk_ingredient.Depth = 0;
            this.chk_ingredient.Location = new System.Drawing.Point(605, 234);
            this.chk_ingredient.Margin = new System.Windows.Forms.Padding(0);
            this.chk_ingredient.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_ingredient.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_ingredient.Name = "chk_ingredient";
            this.chk_ingredient.ReadOnly = false;
            this.chk_ingredient.Ripple = true;
            this.chk_ingredient.Size = new System.Drawing.Size(105, 37);
            this.chk_ingredient.TabIndex = 40;
            this.chk_ingredient.Text = "Ingredient";
            this.chk_ingredient.UseVisualStyleBackColor = true;
            // 
            // chk_retail
            // 
            this.chk_retail.AutoSize = true;
            this.chk_retail.Depth = 0;
            this.chk_retail.Location = new System.Drawing.Point(830, 234);
            this.chk_retail.Margin = new System.Windows.Forms.Padding(0);
            this.chk_retail.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_retail.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_retail.Name = "chk_retail";
            this.chk_retail.ReadOnly = false;
            this.chk_retail.Ripple = true;
            this.chk_retail.Size = new System.Drawing.Size(75, 37);
            this.chk_retail.TabIndex = 39;
            this.chk_retail.Text = "Retail";
            this.chk_retail.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(601, 200);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(120, 24);
            this.materialLabel3.TabIndex = 38;
            this.materialLabel3.Text = "Product Type";
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = false;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.DrawShadows = false;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(42, 336);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(129, 36);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "save product";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.DrawShadows = false;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(42, 336);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(147, 36);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "update product";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = false;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(342, 336);
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
            // txt_product_name
            // 
            this.txt_product_name.AnimateReadOnly = false;
            this.txt_product_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_product_name.Depth = 0;
            this.txt_product_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_product_name.Hint = "Enter product name";
            this.txt_product_name.LeadingIcon = null;
            this.txt_product_name.Location = new System.Drawing.Point(46, 96);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(43, 60);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 24);
            this.materialLabel1.TabIndex = 31;
            this.materialLabel1.Text = "Product Name:";
            // 
            // txt_brand
            // 
            this.txt_brand.AnimateReadOnly = false;
            this.txt_brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_brand.Depth = 0;
            this.txt_brand.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_brand.Hint = "Enter Brand";
            this.txt_brand.LeadingIcon = null;
            this.txt_brand.Location = new System.Drawing.Point(596, 94);
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
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(43, 200);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(91, 24);
            this.materialLabel6.TabIndex = 36;
            this.materialLabel6.Text = "Unit Type:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(601, 60);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(59, 24);
            this.materialLabel4.TabIndex = 34;
            this.materialLabel4.Text = "Brand:";
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
            this.cmb_unit_type.Location = new System.Drawing.Point(46, 234);
            this.cmb_unit_type.Margin = new System.Windows.Forms.Padding(25, 10, 25, 25);
            this.cmb_unit_type.MaxDropDownItems = 4;
            this.cmb_unit_type.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_unit_type.Name = "cmb_unit_type";
            this.cmb_unit_type.Size = new System.Drawing.Size(500, 49);
            this.cmb_unit_type.StartIndex = -1;
            this.cmb_unit_type.TabIndex = 27;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1190, 800);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.Padding = new System.Windows.Forms.Padding(0, 44, 0, 10);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCT INFORMATION";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_size)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_size_label;
        private MaterialSkin.Controls.MaterialButton btn_product_size_save;
        private MaterialSkin.Controls.MaterialButton btn_product_size_update;
        private MaterialSkin.Controls.MaterialButton btn_product_size_cancel;
        private MaterialSkin.Controls.MaterialTextBox txt_cost_price;
        private MaterialSkin.Controls.MaterialTextBox txt_content;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_product_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coL_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_cost_price;
        private System.Windows.Forms.DataGridViewButtonColumn col_product_size_update;
        private System.Windows.Forms.DataGridViewButtonColumn col_product_size_delete;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btn_add_size;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckbox chk_ingredient;
        private MaterialSkin.Controls.MaterialCheckbox chk_retail;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialTextBox txt_product_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_brand;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cmb_unit_type;
    }
}