namespace Salon.View
{
    partial class StockInTransactionForm
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_stock_out = new System.Windows.Forms.DataGridView();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.col_stk_out_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_product_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_product_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_product_unit_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_qty_delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_total_qty_delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_qty_remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_total_remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_unit_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_out_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock_out)).BeginInit();
            this.SuspendLayout();
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1600, 100);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 124);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1600, 673);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_products);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(50, 0, 50, 50);
            this.tabPage1.Size = new System.Drawing.Size(1592, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "STOCK IN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.AllowUserToResizeColumns = false;
            this.dgv_products.AllowUserToResizeRows = false;
            this.dgv_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_supplier_name,
            this.col_product_name,
            this.col_product_type,
            this.col_product_size,
            this.col_product_qty});
            this.dgv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_products.EnableHeadersVisualStyles = false;
            this.dgv_products.Location = new System.Drawing.Point(50, 69);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_products.RowHeadersVisible = false;
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(1492, 525);
            this.dgv_products.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(50, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1492, 69);
            this.materialCard1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_stock_out);
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(50, 0, 50, 50);
            this.tabPage2.Size = new System.Drawing.Size(1592, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "STOCK OUT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_stock_out
            // 
            this.dgv_stock_out.AllowUserToAddRows = false;
            this.dgv_stock_out.AllowUserToDeleteRows = false;
            this.dgv_stock_out.AllowUserToResizeColumns = false;
            this.dgv_stock_out.AllowUserToResizeRows = false;
            this.dgv_stock_out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_stock_out.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_stock_out.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_stock_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock_out.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_stk_out_name,
            this.col_stk_out_product_type,
            this.col_stk_out_product_brand,
            this.col_stk_out_product_unit_type,
            this.col_stk_out_qty_delivered,
            this.col_stk_out_total_qty_delivered,
            this.col_stk_out_qty_remaining,
            this.col_stk_out_total_remaining,
            this.col_stk_out_qty,
            this.col_stk_out_total,
            this.col_stk_out_unit_type,
            this.col_stk_out_out_type,
            this.col_stk_out_created_at});
            this.dgv_stock_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_stock_out.EnableHeadersVisualStyles = false;
            this.dgv_stock_out.Location = new System.Drawing.Point(50, 69);
            this.dgv_stock_out.Name = "dgv_stock_out";
            this.dgv_stock_out.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_stock_out.RowHeadersVisible = false;
            this.dgv_stock_out.RowHeadersWidth = 51;
            this.dgv_stock_out.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_stock_out.RowTemplate.Height = 24;
            this.dgv_stock_out.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stock_out.Size = new System.Drawing.Size(1492, 525);
            this.dgv_stock_out.TabIndex = 2;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(50, 0);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1492, 69);
            this.materialCard2.TabIndex = 3;
            // 
            // col_stk_out_name
            // 
            this.col_stk_out_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_stk_out_name.HeaderText = "Product Name";
            this.col_stk_out_name.MinimumWidth = 6;
            this.col_stk_out_name.Name = "col_stk_out_name";
            // 
            // col_stk_out_product_type
            // 
            this.col_stk_out_product_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_product_type.HeaderText = "Product Type";
            this.col_stk_out_product_type.MinimumWidth = 6;
            this.col_stk_out_product_type.Name = "col_stk_out_product_type";
            this.col_stk_out_product_type.Width = 115;
            // 
            // col_stk_out_product_brand
            // 
            this.col_stk_out_product_brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_product_brand.HeaderText = "Brand";
            this.col_stk_out_product_brand.MinimumWidth = 6;
            this.col_stk_out_product_brand.Name = "col_stk_out_product_brand";
            this.col_stk_out_product_brand.Visible = false;
            this.col_stk_out_product_brand.Width = 70;
            // 
            // col_stk_out_product_unit_type
            // 
            this.col_stk_out_product_unit_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_product_unit_type.HeaderText = "Unit Type";
            this.col_stk_out_product_unit_type.MinimumWidth = 6;
            this.col_stk_out_product_unit_type.Name = "col_stk_out_product_unit_type";
            this.col_stk_out_product_unit_type.Width = 92;
            // 
            // col_stk_out_qty_delivered
            // 
            this.col_stk_out_qty_delivered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_qty_delivered.HeaderText = "Qty Delivered";
            this.col_stk_out_qty_delivered.MinimumWidth = 6;
            this.col_stk_out_qty_delivered.Name = "col_stk_out_qty_delivered";
            this.col_stk_out_qty_delivered.Width = 116;
            // 
            // col_stk_out_total_qty_delivered
            // 
            this.col_stk_out_total_qty_delivered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_total_qty_delivered.HeaderText = "Total Qty Delivered";
            this.col_stk_out_total_qty_delivered.MinimumWidth = 6;
            this.col_stk_out_total_qty_delivered.Name = "col_stk_out_total_qty_delivered";
            this.col_stk_out_total_qty_delivered.Visible = false;
            this.col_stk_out_total_qty_delivered.Width = 150;
            // 
            // col_stk_out_qty_remaining
            // 
            this.col_stk_out_qty_remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_qty_remaining.HeaderText = "Qty Remaining";
            this.col_stk_out_qty_remaining.MinimumWidth = 6;
            this.col_stk_out_qty_remaining.Name = "col_stk_out_qty_remaining";
            this.col_stk_out_qty_remaining.Width = 122;
            // 
            // col_stk_out_total_remaining
            // 
            this.col_stk_out_total_remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_total_remaining.HeaderText = "Total Remaining";
            this.col_stk_out_total_remaining.MinimumWidth = 6;
            this.col_stk_out_total_remaining.Name = "col_stk_out_total_remaining";
            this.col_stk_out_total_remaining.Width = 122;
            // 
            // col_stk_out_qty
            // 
            this.col_stk_out_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_qty.HeaderText = "Qty Used";
            this.col_stk_out_qty.MinimumWidth = 6;
            this.col_stk_out_qty.Name = "col_stk_out_qty";
            this.col_stk_out_qty.Width = 83;
            // 
            // col_stk_out_total
            // 
            this.col_stk_out_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_total.HeaderText = "Total Used";
            this.col_stk_out_total.MinimumWidth = 6;
            this.col_stk_out_total.Name = "col_stk_out_total";
            this.col_stk_out_total.Width = 93;
            // 
            // col_stk_out_unit_type
            // 
            this.col_stk_out_unit_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_stk_out_unit_type.HeaderText = "Unit Type";
            this.col_stk_out_unit_type.MinimumWidth = 6;
            this.col_stk_out_unit_type.Name = "col_stk_out_unit_type";
            // 
            // col_stk_out_out_type
            // 
            this.col_stk_out_out_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_out_type.HeaderText = "Out Type";
            this.col_stk_out_out_type.MinimumWidth = 6;
            this.col_stk_out_out_type.Name = "col_stk_out_out_type";
            this.col_stk_out_out_type.Width = 82;
            // 
            // col_stk_out_created_at
            // 
            this.col_stk_out_created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_created_at.HeaderText = "Created At";
            this.col_stk_out_created_at.MinimumWidth = 6;
            this.col_stk_out_created_at.Name = "col_stk_out_created_at";
            this.col_stk_out_created_at.Width = 90;
            // 
            // col_product_supplier_name
            // 
            this.col_product_supplier_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_supplier_name.HeaderText = "Supplier";
            this.col_product_supplier_name.MinimumWidth = 6;
            this.col_product_supplier_name.Name = "col_product_supplier_name";
            // 
            // col_product_name
            // 
            this.col_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_name.HeaderText = "Product Name";
            this.col_product_name.MinimumWidth = 6;
            this.col_product_name.Name = "col_product_name";
            // 
            // col_product_type
            // 
            this.col_product_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_type.HeaderText = "Product Type";
            this.col_product_type.MinimumWidth = 6;
            this.col_product_type.Name = "col_product_type";
            // 
            // col_product_size
            // 
            this.col_product_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_size.HeaderText = "Size";
            this.col_product_size.MinimumWidth = 6;
            this.col_product_size.Name = "col_product_size";
            // 
            // col_product_qty
            // 
            this.col_product_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_qty.HeaderText = "Quantity";
            this.col_product_qty.MinimumWidth = 6;
            this.col_product_qty.Name = "col_product_qty";
            this.col_product_qty.Width = 82;
            // 
            // StockInTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockInTransactionForm";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockInTransactionForm";
            this.Load += new System.EventHandler(this.StockInTransactionForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock_out)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_products;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView dgv_stock_out;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_product_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_product_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_product_unit_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_qty_delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_total_qty_delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_qty_remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_total_remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_unit_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_out_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_qty;
    }
}