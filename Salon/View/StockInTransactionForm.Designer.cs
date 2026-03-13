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
            this.col_stk_in_refund_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_stock_out_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_inventory_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_size_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_qty_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_line_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_prev_remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_new_remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_prev_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_new_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_movement_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_in_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_stock_out = new System.Windows.Forms.DataGridView();
            this.col_stk_out_invoice_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_qty_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_line_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_prev_total_remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_new_total_remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_prev_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_new_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_movement_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stk_out_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
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
            this.col_stk_in_refund_id,
            this.col_stk_in_stock_out_id,
            this.col_stk_in_inventory_id,
            this.col_stk_in_product_name,
            this.col_stk_in_brand,
            this.col_stk_in_size_label,
            this.col_stk_in_qty,
            this.col_stk_in_qty_volume,
            this.col_stk_in_unit_price,
            this.col_stk_in_line_total,
            this.col_stk_in_prev_remaining,
            this.col_stk_in_new_remaining,
            this.col_stk_in_prev_qty,
            this.col_stk_in_new_qty,
            this.col_stk_in_movement_type,
            this.col_stk_in_reason,
            this.col_stk_in_fullName,
            this.col_stk_in_created_at});
            this.dgv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_products.EnableHeadersVisualStyles = false;
            this.dgv_products.Location = new System.Drawing.Point(0, 69);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_products.RowHeadersVisible = false;
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(1592, 525);
            this.dgv_products.TabIndex = 0;
            // 
            // col_stk_in_refund_id
            // 
            this.col_stk_in_refund_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_refund_id.HeaderText = "refund_id";
            this.col_stk_in_refund_id.MinimumWidth = 6;
            this.col_stk_in_refund_id.Name = "col_stk_in_refund_id";
            this.col_stk_in_refund_id.Visible = false;
            this.col_stk_in_refund_id.Width = 125;
            // 
            // col_stk_in_stock_out_id
            // 
            this.col_stk_in_stock_out_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_stock_out_id.HeaderText = "stock_out_id";
            this.col_stk_in_stock_out_id.MinimumWidth = 6;
            this.col_stk_in_stock_out_id.Name = "col_stk_in_stock_out_id";
            this.col_stk_in_stock_out_id.Visible = false;
            this.col_stk_in_stock_out_id.Width = 125;
            // 
            // col_stk_in_inventory_id
            // 
            this.col_stk_in_inventory_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_inventory_id.HeaderText = "inventory_id";
            this.col_stk_in_inventory_id.MinimumWidth = 6;
            this.col_stk_in_inventory_id.Name = "col_stk_in_inventory_id";
            this.col_stk_in_inventory_id.Visible = false;
            this.col_stk_in_inventory_id.Width = 125;
            // 
            // col_stk_in_product_name
            // 
            this.col_stk_in_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_stk_in_product_name.HeaderText = "Product Name";
            this.col_stk_in_product_name.MinimumWidth = 6;
            this.col_stk_in_product_name.Name = "col_stk_in_product_name";
            // 
            // col_stk_in_brand
            // 
            this.col_stk_in_brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_brand.HeaderText = "Brand";
            this.col_stk_in_brand.MinimumWidth = 6;
            this.col_stk_in_brand.Name = "col_stk_in_brand";
            this.col_stk_in_brand.Width = 70;
            // 
            // col_stk_in_size_label
            // 
            this.col_stk_in_size_label.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_size_label.HeaderText = "Size";
            this.col_stk_in_size_label.MinimumWidth = 6;
            this.col_stk_in_size_label.Name = "col_stk_in_size_label";
            this.col_stk_in_size_label.Width = 60;
            // 
            // col_stk_in_qty
            // 
            this.col_stk_in_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_qty.HeaderText = "Qty";
            this.col_stk_in_qty.MinimumWidth = 6;
            this.col_stk_in_qty.Name = "col_stk_in_qty";
            this.col_stk_in_qty.Width = 54;
            // 
            // col_stk_in_qty_volume
            // 
            this.col_stk_in_qty_volume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_qty_volume.HeaderText = "Qty Volume";
            this.col_stk_in_qty_volume.MinimumWidth = 6;
            this.col_stk_in_qty_volume.Name = "col_stk_in_qty_volume";
            this.col_stk_in_qty_volume.Width = 95;
            // 
            // col_stk_in_unit_price
            // 
            this.col_stk_in_unit_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_unit_price.HeaderText = "Unit Price";
            this.col_stk_in_unit_price.MinimumWidth = 6;
            this.col_stk_in_unit_price.Name = "col_stk_in_unit_price";
            this.col_stk_in_unit_price.Width = 84;
            // 
            // col_stk_in_line_total
            // 
            this.col_stk_in_line_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_line_total.HeaderText = "Total";
            this.col_stk_in_line_total.MinimumWidth = 6;
            this.col_stk_in_line_total.Name = "col_stk_in_line_total";
            this.col_stk_in_line_total.Width = 65;
            // 
            // col_stk_in_prev_remaining
            // 
            this.col_stk_in_prev_remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_prev_remaining.HeaderText = "Previous Remaining";
            this.col_stk_in_prev_remaining.MinimumWidth = 6;
            this.col_stk_in_prev_remaining.Name = "col_stk_in_prev_remaining";
            this.col_stk_in_prev_remaining.Width = 142;
            // 
            // col_stk_in_new_remaining
            // 
            this.col_stk_in_new_remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_new_remaining.HeaderText = "New Total Remaining";
            this.col_stk_in_new_remaining.MinimumWidth = 6;
            this.col_stk_in_new_remaining.Name = "col_stk_in_new_remaining";
            this.col_stk_in_new_remaining.Width = 149;
            // 
            // col_stk_in_prev_qty
            // 
            this.col_stk_in_prev_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_prev_qty.HeaderText = "Previous Qty";
            this.col_stk_in_prev_qty.MinimumWidth = 6;
            this.col_stk_in_prev_qty.Name = "col_stk_in_prev_qty";
            this.col_stk_in_prev_qty.Width = 101;
            // 
            // col_stk_in_new_qty
            // 
            this.col_stk_in_new_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_new_qty.HeaderText = "New Qty";
            this.col_stk_in_new_qty.MinimumWidth = 6;
            this.col_stk_in_new_qty.Name = "col_stk_in_new_qty";
            this.col_stk_in_new_qty.Width = 78;
            // 
            // col_stk_in_movement_type
            // 
            this.col_stk_in_movement_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_movement_type.HeaderText = "Movement Type";
            this.col_stk_in_movement_type.MinimumWidth = 6;
            this.col_stk_in_movement_type.Name = "col_stk_in_movement_type";
            this.col_stk_in_movement_type.Width = 121;
            // 
            // col_stk_in_reason
            // 
            this.col_stk_in_reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_reason.HeaderText = "Reason";
            this.col_stk_in_reason.MinimumWidth = 6;
            this.col_stk_in_reason.Name = "col_stk_in_reason";
            this.col_stk_in_reason.Width = 82;
            // 
            // col_stk_in_fullName
            // 
            this.col_stk_in_fullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_fullName.HeaderText = "Created by";
            this.col_stk_in_fullName.MinimumWidth = 6;
            this.col_stk_in_fullName.Name = "col_stk_in_fullName";
            this.col_stk_in_fullName.Width = 92;
            // 
            // col_stk_in_created_at
            // 
            this.col_stk_in_created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_in_created_at.HeaderText = "Created At";
            this.col_stk_in_created_at.MinimumWidth = 6;
            this.col_stk_in_created_at.Name = "col_stk_in_created_at";
            this.col_stk_in_created_at.Width = 90;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1592, 69);
            this.materialCard1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_stock_out);
            this.tabPage2.Controls.Add(this.materialCard2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
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
            this.col_stk_out_invoice_number,
            this.col_stk_out_name,
            this.col_stk_out_size,
            this.col_stk_out_qty,
            this.col_stk_out_qty_volume,
            this.col_stk_out_unit_price,
            this.col_stk_out_line_total,
            this.col_stk_out_prev_total_remaining,
            this.col_stk_out_new_total_remaining,
            this.col_stk_out_prev_qty,
            this.col_stk_out_new_qty,
            this.col_stk_out_movement_type,
            this.col_stk_out_reason,
            this.col_stk_out_user_name,
            this.col_stk_out_created_at});
            this.dgv_stock_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_stock_out.EnableHeadersVisualStyles = false;
            this.dgv_stock_out.Location = new System.Drawing.Point(0, 69);
            this.dgv_stock_out.Name = "dgv_stock_out";
            this.dgv_stock_out.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_stock_out.RowHeadersVisible = false;
            this.dgv_stock_out.RowHeadersWidth = 51;
            this.dgv_stock_out.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_stock_out.RowTemplate.Height = 24;
            this.dgv_stock_out.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stock_out.Size = new System.Drawing.Size(1592, 525);
            this.dgv_stock_out.TabIndex = 2;
            // 
            // col_stk_out_invoice_number
            // 
            this.col_stk_out_invoice_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_invoice_number.HeaderText = "Invoice Number";
            this.col_stk_out_invoice_number.MinimumWidth = 6;
            this.col_stk_out_invoice_number.Name = "col_stk_out_invoice_number";
            this.col_stk_out_invoice_number.Width = 117;
            // 
            // col_stk_out_name
            // 
            this.col_stk_out_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_name.HeaderText = "Product Name";
            this.col_stk_out_name.MinimumWidth = 6;
            this.col_stk_out_name.Name = "col_stk_out_name";
            this.col_stk_out_name.Width = 110;
            // 
            // col_stk_out_size
            // 
            this.col_stk_out_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_size.HeaderText = "Size";
            this.col_stk_out_size.MinimumWidth = 6;
            this.col_stk_out_size.Name = "col_stk_out_size";
            this.col_stk_out_size.Width = 60;
            // 
            // col_stk_out_qty
            // 
            this.col_stk_out_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_qty.HeaderText = "Qty";
            this.col_stk_out_qty.MinimumWidth = 6;
            this.col_stk_out_qty.Name = "col_stk_out_qty";
            this.col_stk_out_qty.Width = 54;
            // 
            // col_stk_out_qty_volume
            // 
            this.col_stk_out_qty_volume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_qty_volume.HeaderText = "Qty Volume";
            this.col_stk_out_qty_volume.MinimumWidth = 6;
            this.col_stk_out_qty_volume.Name = "col_stk_out_qty_volume";
            this.col_stk_out_qty_volume.Width = 95;
            // 
            // col_stk_out_unit_price
            // 
            this.col_stk_out_unit_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_unit_price.HeaderText = "Unit Price";
            this.col_stk_out_unit_price.MinimumWidth = 6;
            this.col_stk_out_unit_price.Name = "col_stk_out_unit_price";
            this.col_stk_out_unit_price.Width = 84;
            // 
            // col_stk_out_line_total
            // 
            this.col_stk_out_line_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_line_total.HeaderText = "Total";
            this.col_stk_out_line_total.MinimumWidth = 6;
            this.col_stk_out_line_total.Name = "col_stk_out_line_total";
            this.col_stk_out_line_total.Width = 65;
            // 
            // col_stk_out_prev_total_remaining
            // 
            this.col_stk_out_prev_total_remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_prev_total_remaining.HeaderText = "Previous Total Remaining";
            this.col_stk_out_prev_total_remaining.MinimumWidth = 6;
            this.col_stk_out_prev_total_remaining.Name = "col_stk_out_prev_total_remaining";
            this.col_stk_out_prev_total_remaining.Width = 172;
            // 
            // col_stk_out_new_total_remaining
            // 
            this.col_stk_out_new_total_remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_new_total_remaining.HeaderText = "New Total Remaining";
            this.col_stk_out_new_total_remaining.MinimumWidth = 6;
            this.col_stk_out_new_total_remaining.Name = "col_stk_out_new_total_remaining";
            this.col_stk_out_new_total_remaining.Width = 149;
            // 
            // col_stk_out_prev_qty
            // 
            this.col_stk_out_prev_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_prev_qty.HeaderText = "Previous Qty";
            this.col_stk_out_prev_qty.MinimumWidth = 6;
            this.col_stk_out_prev_qty.Name = "col_stk_out_prev_qty";
            this.col_stk_out_prev_qty.Width = 101;
            // 
            // col_stk_out_new_qty
            // 
            this.col_stk_out_new_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_new_qty.HeaderText = "New Qty";
            this.col_stk_out_new_qty.MinimumWidth = 6;
            this.col_stk_out_new_qty.Name = "col_stk_out_new_qty";
            this.col_stk_out_new_qty.Width = 78;
            // 
            // col_stk_out_movement_type
            // 
            this.col_stk_out_movement_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_movement_type.HeaderText = "Movement Type";
            this.col_stk_out_movement_type.MinimumWidth = 6;
            this.col_stk_out_movement_type.Name = "col_stk_out_movement_type";
            this.col_stk_out_movement_type.Width = 121;
            // 
            // col_stk_out_reason
            // 
            this.col_stk_out_reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_reason.HeaderText = "Reason";
            this.col_stk_out_reason.MinimumWidth = 6;
            this.col_stk_out_reason.Name = "col_stk_out_reason";
            this.col_stk_out_reason.Width = 82;
            // 
            // col_stk_out_user_name
            // 
            this.col_stk_out_user_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_user_name.HeaderText = "Name";
            this.col_stk_out_user_name.MinimumWidth = 6;
            this.col_stk_out_user_name.Name = "col_stk_out_user_name";
            this.col_stk_out_user_name.Width = 71;
            // 
            // col_stk_out_created_at
            // 
            this.col_stk_out_created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stk_out_created_at.HeaderText = "Created At";
            this.col_stk_out_created_at.MinimumWidth = 6;
            this.col_stk_out_created_at.Name = "col_stk_out_created_at";
            this.col_stk_out_created_at.Width = 90;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(0, 0);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1592, 69);
            this.materialCard2.TabIndex = 3;
            // 
            // StockInTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_invoice_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_qty_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_line_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_prev_total_remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_new_total_remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_prev_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_new_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_movement_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_out_created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_refund_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_stock_out_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_inventory_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_size_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_qty_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_line_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_prev_remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_new_remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_prev_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_new_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_movement_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stk_in_created_at;
    }
}