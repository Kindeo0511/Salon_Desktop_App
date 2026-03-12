namespace Salon.View
{
    partial class RefundForm
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
            this.btn_void = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_date = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_staff = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_invoice_number = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.col_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_invoice_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product__size_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_refund_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_over_all_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vat_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_payment_method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ref_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_refund_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_btn_refund = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_void
            // 
            this.btn_void.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_void.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_void.Depth = 0;
            this.btn_void.HighEmphasis = true;
            this.btn_void.Icon = null;
            this.btn_void.Location = new System.Drawing.Point(723, 606);
            this.btn_void.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_void.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_void.Name = "btn_void";
            this.btn_void.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_void.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.btn_void.Size = new System.Drawing.Size(86, 36);
            this.btn_void.TabIndex = 0;
            this.btn_void.Text = "confirm ";
            this.btn_void.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_void.UseAccentColor = false;
            this.btn_void.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(876, 606);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_void);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.dgv_products);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.lbl_staff);
            this.panel1.Controls.Add(this.lbl_invoice_number);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25);
            this.panel1.Size = new System.Drawing.Size(994, 673);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(30, 224);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(118, 24);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "List of Items:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Depth = 0;
            this.lbl_date.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_date.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_date.Location = new System.Drawing.Point(832, 52);
            this.lbl_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(41, 24);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "date";
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_item_id,
            this.col_invoice_id,
            this.col_product_id,
            this.col_product__size_id,
            this.col_item_name,
            this.col_price,
            this.col_qty,
            this.col_refund_qty,
            this.col_over_all_discount,
            this.col_item_discount,
            this.col_vat_amount,
            this.col_total_amount,
            this.col_payment_method,
            this.col_ref_number,
            this.col_refund_amount,
            this.col_total,
            this.col_status,
            this.col_btn_refund});
            this.dgv_products.Location = new System.Drawing.Point(28, 251);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_products.RowHeadersVisible = false;
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(925, 295);
            this.dgv_products.TabIndex = 6;
            this.dgv_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellClick);
            this.dgv_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellContentClick);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(58, 132);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel4.Size = new System.Drawing.Size(55, 24);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Staff: ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(716, 52);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Date:";
            // 
            // lbl_staff
            // 
            this.lbl_staff.AutoSize = true;
            this.lbl_staff.Depth = 0;
            this.lbl_staff.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_staff.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_staff.Location = new System.Drawing.Point(244, 132);
            this.lbl_staff.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_staff.Name = "lbl_staff";
            this.lbl_staff.Size = new System.Drawing.Size(43, 24);
            this.lbl_staff.TabIndex = 10;
            this.lbl_staff.Text = "staff";
            // 
            // lbl_invoice_number
            // 
            this.lbl_invoice_number.AutoSize = true;
            this.lbl_invoice_number.Depth = 0;
            this.lbl_invoice_number.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_invoice_number.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_invoice_number.Location = new System.Drawing.Point(244, 52);
            this.lbl_invoice_number.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_invoice_number.Name = "lbl_invoice_number";
            this.lbl_invoice_number.Size = new System.Drawing.Size(137, 24);
            this.lbl_invoice_number.TabIndex = 8;
            this.lbl_invoice_number.Text = "invoice number";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(56, 52);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Invoice Number:";
            // 
            // col_item_id
            // 
            this.col_item_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_item_id.HeaderText = "Item ID";
            this.col_item_id.MinimumWidth = 6;
            this.col_item_id.Name = "col_item_id";
            this.col_item_id.ReadOnly = true;
            this.col_item_id.Visible = false;
            this.col_item_id.Width = 54;
            // 
            // col_invoice_id
            // 
            this.col_invoice_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_invoice_id.HeaderText = "Invoice ID";
            this.col_invoice_id.MinimumWidth = 6;
            this.col_invoice_id.Name = "col_invoice_id";
            this.col_invoice_id.ReadOnly = true;
            this.col_invoice_id.Visible = false;
            this.col_invoice_id.Width = 72;
            // 
            // col_product_id
            // 
            this.col_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_id.HeaderText = "Product ID";
            this.col_product_id.MinimumWidth = 6;
            this.col_product_id.Name = "col_product_id";
            this.col_product_id.ReadOnly = true;
            this.col_product_id.Visible = false;
            this.col_product_id.Width = 75;
            // 
            // col_product__size_id
            // 
            this.col_product__size_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product__size_id.HeaderText = "size_id";
            this.col_product__size_id.MinimumWidth = 6;
            this.col_product__size_id.Name = "col_product__size_id";
            this.col_product__size_id.ReadOnly = true;
            this.col_product__size_id.Visible = false;
            this.col_product__size_id.Width = 55;
            // 
            // col_item_name
            // 
            this.col_item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_item_name.HeaderText = "Item Name";
            this.col_item_name.MinimumWidth = 6;
            this.col_item_name.Name = "col_item_name";
            this.col_item_name.ReadOnly = true;
            this.col_item_name.Width = 101;
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
            // col_qty
            // 
            this.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty.HeaderText = "Qty";
            this.col_qty.MinimumWidth = 6;
            this.col_qty.Name = "col_qty";
            this.col_qty.ReadOnly = true;
            this.col_qty.Width = 56;
            // 
            // col_refund_qty
            // 
            this.col_refund_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_refund_qty.HeaderText = "Refund Qty";
            this.col_refund_qty.MinimumWidth = 6;
            this.col_refund_qty.Name = "col_refund_qty";
            this.col_refund_qty.ReadOnly = true;
            this.col_refund_qty.Width = 102;
            // 
            // col_over_all_discount
            // 
            this.col_over_all_discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_over_all_discount.HeaderText = "Overall Discount";
            this.col_over_all_discount.MinimumWidth = 6;
            this.col_over_all_discount.Name = "col_over_all_discount";
            this.col_over_all_discount.ReadOnly = true;
            this.col_over_all_discount.Visible = false;
            this.col_over_all_discount.Width = 134;
            // 
            // col_item_discount
            // 
            this.col_item_discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_item_discount.HeaderText = "Item Discount";
            this.col_item_discount.MinimumWidth = 6;
            this.col_item_discount.Name = "col_item_discount";
            this.col_item_discount.ReadOnly = true;
            this.col_item_discount.Visible = false;
            this.col_item_discount.Width = 116;
            // 
            // col_vat_amount
            // 
            this.col_vat_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_vat_amount.HeaderText = "vat_amount";
            this.col_vat_amount.MinimumWidth = 6;
            this.col_vat_amount.Name = "col_vat_amount";
            this.col_vat_amount.ReadOnly = true;
            this.col_vat_amount.Visible = false;
            this.col_vat_amount.Width = 105;
            // 
            // col_total_amount
            // 
            this.col_total_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_total_amount.HeaderText = "total amount";
            this.col_total_amount.MinimumWidth = 6;
            this.col_total_amount.Name = "col_total_amount";
            this.col_total_amount.ReadOnly = true;
            this.col_total_amount.Width = 108;
            // 
            // col_payment_method
            // 
            this.col_payment_method.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_payment_method.HeaderText = "payment method";
            this.col_payment_method.MinimumWidth = 6;
            this.col_payment_method.Name = "col_payment_method";
            this.col_payment_method.ReadOnly = true;
            this.col_payment_method.Width = 125;
            // 
            // col_ref_number
            // 
            this.col_ref_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_ref_number.HeaderText = "reference number";
            this.col_ref_number.MinimumWidth = 6;
            this.col_ref_number.Name = "col_ref_number";
            this.col_ref_number.ReadOnly = true;
            this.col_ref_number.Width = 129;
            // 
            // col_refund_amount
            // 
            this.col_refund_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_refund_amount.HeaderText = "Net Refund";
            this.col_refund_amount.MinimumWidth = 6;
            this.col_refund_amount.Name = "col_refund_amount";
            this.col_refund_amount.ReadOnly = true;
            this.col_refund_amount.Visible = false;
            this.col_refund_amount.Width = 95;
            // 
            // col_total
            // 
            this.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_total.HeaderText = "Total";
            this.col_total.MinimumWidth = 6;
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            this.col_total.Width = 67;
            // 
            // col_status
            // 
            this.col_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_status.HeaderText = "Status";
            this.col_status.MinimumWidth = 6;
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            this.col_status.Width = 73;
            // 
            // col_btn_refund
            // 
            this.col_btn_refund.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_btn_refund.HeaderText = "Action";
            this.col_btn_refund.MinimumWidth = 6;
            this.col_btn_refund.Name = "col_btn_refund";
            this.col_btn_refund.ReadOnly = true;
            this.col_btn_refund.Text = "Refund";
            this.col_btn_refund.Width = 50;
            // 
            // RefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RefundForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_void;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lbl_date;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lbl_staff;
        private MaterialSkin.Controls.MaterialLabel lbl_invoice_number;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridView dgv_products;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_invoice_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product__size_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_refund_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_over_all_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vat_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_payment_method;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ref_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_refund_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewButtonColumn col_btn_refund;
    }
}