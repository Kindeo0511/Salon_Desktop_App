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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.cmb_invoice_number = new System.Windows.Forms.ComboBox();
            this.lbl_date = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_staff_name = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_supplier = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.col_DeliveryItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_invoice_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty_accepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty_rejected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_accepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_rejected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.txt_notes);
            this.materialCard1.Controls.Add(this.dgv_items);
            this.materialCard1.Controls.Add(this.cmb_invoice_number);
            this.materialCard1.Controls.Add(this.lbl_date);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.lbl_staff_name);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.lbl_supplier);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.panel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 24);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(25, 14, 25, 25);
            this.materialCard1.Size = new System.Drawing.Size(1594, 773);
            this.materialCard1.TabIndex = 0;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(718, 109);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 24);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Notes:";
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(722, 136);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(374, 139);
            this.txt_notes.TabIndex = 19;
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToOrderColumns = true;
            this.dgv_items.AllowUserToResizeColumns = false;
            this.dgv_items.AllowUserToResizeRows = false;
            this.dgv_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DeliveryItemId,
            this.col_DeliveryId,
            this.col_invoice_number,
            this.col_ProductName,
            this.col_ProductId,
            this.col_product_size_id,
            this.col_Quantity,
            this.col_qty_accepted,
            this.col_qty_rejected,
            this.col_total_accepted,
            this.col_total_rejected,
            this.col_content,
            this.col_total_qty,
            this.col_UnitPrice,
            this.col_TotalPrice,
            this.col_ExpiryDate,
            this.col_notes,
            this.col_item_status});
            this.dgv_items.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_items.EnableHeadersVisualStyles = false;
            this.dgv_items.Location = new System.Drawing.Point(25, 389);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_items.RowHeadersVisible = false;
            this.dgv_items.RowHeadersWidth = 51;
            this.dgv_items.RowTemplate.Height = 24;
            this.dgv_items.Size = new System.Drawing.Size(1523, 483);
            this.dgv_items.TabIndex = 16;
            this.dgv_items.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_items_CellBeginEdit);
            // 
            // cmb_invoice_number
            // 
            this.cmb_invoice_number.FormattingEnabled = true;
            this.cmb_invoice_number.Location = new System.Drawing.Point(343, 42);
            this.cmb_invoice_number.MaxDropDownItems = 6;
            this.cmb_invoice_number.Name = "cmb_invoice_number";
            this.cmb_invoice_number.Size = new System.Drawing.Size(502, 24);
            this.cmb_invoice_number.TabIndex = 9;
            this.cmb_invoice_number.SelectedIndexChanged += new System.EventHandler(this.cmb_invoice_number_SelectedIndexChanged);
            this.cmb_invoice_number.SelectionChangeCommitted += new System.EventHandler(this.cmb_invoice_number_SelectionChangeCommitted);
            this.cmb_invoice_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_invoice_number_KeyDown);
            this.cmb_invoice_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_invoice_number_KeyPress);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Depth = 0;
            this.lbl_date.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_date.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_date.Location = new System.Drawing.Point(350, 251);
            this.lbl_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(132, 24);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "Supplier Name";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(38, 251);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(53, 24);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "Date: ";
            // 
            // lbl_staff_name
            // 
            this.lbl_staff_name.AutoSize = true;
            this.lbl_staff_name.Depth = 0;
            this.lbl_staff_name.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_staff_name.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_staff_name.Location = new System.Drawing.Point(350, 184);
            this.lbl_staff_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_staff_name.Name = "lbl_staff_name";
            this.lbl_staff_name.Size = new System.Drawing.Size(103, 24);
            this.lbl_staff_name.TabIndex = 5;
            this.lbl_staff_name.Text = "Staff Name";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(36, 184);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 24);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Staff: ";
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Depth = 0;
            this.lbl_supplier.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_supplier.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_supplier.Location = new System.Drawing.Point(350, 109);
            this.lbl_supplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(132, 24);
            this.lbl_supplier.TabIndex = 3;
            this.lbl_supplier.Text = "Supplier Name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(36, 109);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Supplier: ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(36, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Reference #:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(25, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1523, 400);
            this.panel1.TabIndex = 21;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(1372, 310);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(13, 322);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(57, 24);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Items:";
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(1025, 310);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_confirm.Size = new System.Drawing.Size(155, 36);
            this.btn_confirm.TabIndex = 17;
            this.btn_confirm.Text = "confirm stock in";
            this.btn_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm.UseAccentColor = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // col_DeliveryItemId
            // 
            this.col_DeliveryItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DeliveryItemId.HeaderText = "id";
            this.col_DeliveryItemId.MinimumWidth = 6;
            this.col_DeliveryItemId.Name = "col_DeliveryItemId";
            this.col_DeliveryItemId.Visible = false;
            // 
            // col_DeliveryId
            // 
            this.col_DeliveryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DeliveryId.HeaderText = "Delivery No.";
            this.col_DeliveryId.MinimumWidth = 6;
            this.col_DeliveryId.Name = "col_DeliveryId";
            this.col_DeliveryId.Visible = false;
            // 
            // col_invoice_number
            // 
            this.col_invoice_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_invoice_number.HeaderText = "Invoice No.";
            this.col_invoice_number.MinimumWidth = 6;
            this.col_invoice_number.Name = "col_invoice_number";
            this.col_invoice_number.ReadOnly = true;
            // 
            // col_ProductName
            // 
            this.col_ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ProductName.HeaderText = "Product";
            this.col_ProductName.MinimumWidth = 6;
            this.col_ProductName.Name = "col_ProductName";
            this.col_ProductName.ReadOnly = true;
            // 
            // col_ProductId
            // 
            this.col_ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_ProductId.HeaderText = "product_id";
            this.col_ProductId.MinimumWidth = 6;
            this.col_ProductId.Name = "col_ProductId";
            this.col_ProductId.Visible = false;
            this.col_ProductId.Width = 97;
            // 
            // col_product_size_id
            // 
            this.col_product_size_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_size_id.HeaderText = "product_size_id";
            this.col_product_size_id.MinimumWidth = 6;
            this.col_product_size_id.Name = "col_product_size_id";
            this.col_product_size_id.Width = 128;
            // 
            // col_Quantity
            // 
            this.col_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_Quantity.HeaderText = "Qty";
            this.col_Quantity.MinimumWidth = 6;
            this.col_Quantity.Name = "col_Quantity";
            this.col_Quantity.ReadOnly = true;
            this.col_Quantity.Width = 54;
            // 
            // col_qty_accepted
            // 
            this.col_qty_accepted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty_accepted.HeaderText = "Qty Accepted";
            this.col_qty_accepted.MinimumWidth = 6;
            this.col_qty_accepted.Name = "col_qty_accepted";
            this.col_qty_accepted.Width = 115;
            // 
            // col_qty_rejected
            // 
            this.col_qty_rejected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty_rejected.HeaderText = "Qty Rejected";
            this.col_qty_rejected.MinimumWidth = 6;
            this.col_qty_rejected.Name = "col_qty_rejected";
            this.col_qty_rejected.Width = 112;
            // 
            // col_total_accepted
            // 
            this.col_total_accepted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_total_accepted.HeaderText = "Total Accepted";
            this.col_total_accepted.MinimumWidth = 6;
            this.col_total_accepted.Name = "col_total_accepted";
            this.col_total_accepted.ReadOnly = true;
            this.col_total_accepted.Width = 116;
            // 
            // col_total_rejected
            // 
            this.col_total_rejected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_total_rejected.HeaderText = "Total Rejected";
            this.col_total_rejected.MinimumWidth = 6;
            this.col_total_rejected.Name = "col_total_rejected";
            this.col_total_rejected.ReadOnly = true;
            this.col_total_rejected.Width = 113;
            // 
            // col_content
            // 
            this.col_content.HeaderText = "content";
            this.col_content.MinimumWidth = 6;
            this.col_content.Name = "col_content";
            this.col_content.Width = 125;
            // 
            // col_total_qty
            // 
            this.col_total_qty.HeaderText = "Total qty";
            this.col_total_qty.MinimumWidth = 6;
            this.col_total_qty.Name = "col_total_qty";
            this.col_total_qty.Width = 125;
            // 
            // col_UnitPrice
            // 
            this.col_UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_UnitPrice.HeaderText = "Unit Price";
            this.col_UnitPrice.MinimumWidth = 6;
            this.col_UnitPrice.Name = "col_UnitPrice";
            this.col_UnitPrice.Visible = false;
            this.col_UnitPrice.Width = 84;
            // 
            // col_TotalPrice
            // 
            this.col_TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_TotalPrice.HeaderText = "Total Price";
            this.col_TotalPrice.MinimumWidth = 6;
            this.col_TotalPrice.Name = "col_TotalPrice";
            this.col_TotalPrice.Visible = false;
            this.col_TotalPrice.Width = 91;
            // 
            // col_ExpiryDate
            // 
            this.col_ExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ExpiryDate.HeaderText = "Expiration Date";
            this.col_ExpiryDate.MinimumWidth = 6;
            this.col_ExpiryDate.Name = "col_ExpiryDate";
            this.col_ExpiryDate.Visible = false;
            // 
            // col_notes
            // 
            this.col_notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_notes.HeaderText = "Notes";
            this.col_notes.MinimumWidth = 6;
            this.col_notes.Name = "col_notes";
            this.col_notes.Visible = false;
            // 
            // col_item_status
            // 
            this.col_item_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_item_status.HeaderText = "Status";
            this.col_item_status.MinimumWidth = 6;
            this.col_item_status.Name = "col_item_status";
            this.col_item_status.ReadOnly = true;
            // 
            // StockInTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockInTransactionForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockInTransactionForm";
            this.Load += new System.EventHandler(this.StockInTransactionForm_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lbl_supplier;
        private MaterialSkin.Controls.MaterialLabel lbl_staff_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lbl_date;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.ComboBox cmb_invoice_number;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dgv_items;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DeliveryItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DeliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_invoice_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty_accepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty_rejected;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_accepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_rejected;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_status;
    }
}