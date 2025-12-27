namespace Salon.View
{
    partial class AddProductForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.dgv_product_list = new System.Windows.Forms.DataGridView();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_list)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(45, 99);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Search Product:";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(48, 121);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(649, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // dgv_product_list
            // 
            this.dgv_product_list.AllowUserToAddRows = false;
            this.dgv_product_list.AllowUserToDeleteRows = false;
            this.dgv_product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_id,
            this.col_product_name,
            this.col_brand,
            this.col_product_size,
            this.col_size,
            this.col_price,
            this.btn_add});
            this.dgv_product_list.Location = new System.Drawing.Point(48, 275);
            this.dgv_product_list.Name = "dgv_product_list";
            this.dgv_product_list.ReadOnly = true;
            this.dgv_product_list.RowHeadersWidth = 51;
            this.dgv_product_list.RowTemplate.Height = 24;
            this.dgv_product_list.Size = new System.Drawing.Size(1100, 400);
            this.dgv_product_list.TabIndex = 2;
            this.dgv_product_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_list_CellClick);
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(76, 838);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_confirm.Size = new System.Drawing.Size(167, 36);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "confirm selection";
            this.btn_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm.UseAccentColor = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(327, 838);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(77, 36);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "cancel";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // col_product_id
            // 
            this.col_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_id.HeaderText = "product_id";
            this.col_product_id.MinimumWidth = 6;
            this.col_product_id.Name = "col_product_id";
            this.col_product_id.ReadOnly = true;
            this.col_product_id.Width = 99;
            // 
            // col_product_name
            // 
            this.col_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_name.HeaderText = "Product Name";
            this.col_product_name.MinimumWidth = 6;
            this.col_product_name.Name = "col_product_name";
            this.col_product_name.ReadOnly = true;
            // 
            // col_brand
            // 
            this.col_brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_brand.HeaderText = "Brand";
            this.col_brand.MinimumWidth = 6;
            this.col_brand.Name = "col_brand";
            this.col_brand.ReadOnly = true;
            this.col_brand.Width = 72;
            // 
            // col_product_size
            // 
            this.col_product_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_size.HeaderText = "product_size_id";
            this.col_product_size.MinimumWidth = 6;
            this.col_product_size.Name = "col_product_size";
            this.col_product_size.ReadOnly = true;
            this.col_product_size.Visible = false;
            this.col_product_size.Width = 130;
            // 
            // col_size
            // 
            this.col_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_size.HeaderText = "Size";
            this.col_size.MinimumWidth = 6;
            this.col_size.Name = "col_size";
            this.col_size.ReadOnly = true;
            this.col_size.Width = 62;
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_price.HeaderText = "Price";
            this.col_price.MinimumWidth = 6;
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            this.col_price.Width = 67;
            // 
            // btn_add
            // 
            this.btn_add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_add.HeaderText = "Add";
            this.btn_add.MinimumWidth = 6;
            this.btn_add.Name = "btn_add";
            this.btn_add.ReadOnly = true;
            this.btn_add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_add.Width = 61;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.dgv_product_list);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.DataGridView dgv_product_list;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewButtonColumn btn_add;
    }
}