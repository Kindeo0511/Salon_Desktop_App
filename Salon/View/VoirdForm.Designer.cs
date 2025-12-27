namespace Salon.View
{
    partial class VoirdForm
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_date = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_invoice_number = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_staff = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.col_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_invoice_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_btn_void = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(719, 52);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Date:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Depth = 0;
            this.lbl_date.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_date.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_date.Location = new System.Drawing.Point(835, 52);
            this.lbl_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(41, 24);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "date";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(28, 52);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Invoice Number:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(30, 132);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel4.Size = new System.Drawing.Size(55, 24);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Staff: ";
            // 
            // lbl_invoice_number
            // 
            this.lbl_invoice_number.AutoSize = true;
            this.lbl_invoice_number.Depth = 0;
            this.lbl_invoice_number.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_invoice_number.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_invoice_number.Location = new System.Drawing.Point(216, 52);
            this.lbl_invoice_number.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_invoice_number.Name = "lbl_invoice_number";
            this.lbl_invoice_number.Size = new System.Drawing.Size(137, 24);
            this.lbl_invoice_number.TabIndex = 8;
            this.lbl_invoice_number.Text = "invoice number";
            // 
            // lbl_staff
            // 
            this.lbl_staff.AutoSize = true;
            this.lbl_staff.Depth = 0;
            this.lbl_staff.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_staff.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_staff.Location = new System.Drawing.Point(216, 132);
            this.lbl_staff.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_staff.Name = "lbl_staff";
            this.lbl_staff.Size = new System.Drawing.Size(43, 24);
            this.lbl_staff.TabIndex = 10;
            this.lbl_staff.Text = "staff";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 873);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.lbl_staff);
            this.panel1.Controls.Add(this.lbl_invoice_number);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25);
            this.panel1.Size = new System.Drawing.Size(988, 273);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_products);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 282);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(25);
            this.panel2.Size = new System.Drawing.Size(988, 459);
            this.panel2.TabIndex = 1;
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_item_id,
            this.col_invoice_id,
            this.col_product_id,
            this.col_item_name,
            this.col_price,
            this.col_qty,
            this.col_total,
            this.col_status,
            this.col_btn_void});
            this.dgv_products.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_products.Location = new System.Drawing.Point(25, 52);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.Size = new System.Drawing.Size(938, 382);
            this.dgv_products.TabIndex = 6;
            this.dgv_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellClick);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(28, 25);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(213, 24);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Select Product\'s to Void";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_cancel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 747);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(30);
            this.panel4.Size = new System.Drawing.Size(988, 123);
            this.panel4.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(839, 51);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "exit";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;

            // 
            // col_item_id
            // 
            this.col_item_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_item_id.HeaderText = "Item ID";
            this.col_item_id.MinimumWidth = 6;
            this.col_item_id.Name = "col_item_id";
            this.col_item_id.ReadOnly = true;
            this.col_item_id.Visible = false;
            this.col_item_id.Width = 77;
            // 
            // col_invoice_id
            // 
            this.col_invoice_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_invoice_id.HeaderText = "Invoice ID";
            this.col_invoice_id.MinimumWidth = 6;
            this.col_invoice_id.Name = "col_invoice_id";
            this.col_invoice_id.ReadOnly = true;
            this.col_invoice_id.Visible = false;
            this.col_invoice_id.Width = 95;
            // 
            // col_product_id
            // 
            this.col_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_id.HeaderText = "Product ID";
            this.col_product_id.MinimumWidth = 6;
            this.col_product_id.Name = "col_product_id";
            this.col_product_id.ReadOnly = true;
            this.col_product_id.Visible = false;
            this.col_product_id.Width = 98;
            // 
            // col_item_name
            // 
            this.col_item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_item_name.HeaderText = "Item Name";
            this.col_item_name.MinimumWidth = 6;
            this.col_item_name.Name = "col_item_name";
            this.col_item_name.ReadOnly = true;
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
            // col_btn_void
            // 
            this.col_btn_void.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_btn_void.HeaderText = "Void";
            this.col_btn_void.MinimumWidth = 6;
            this.col_btn_void.Name = "col_btn_void";
            this.col_btn_void.ReadOnly = true;
            this.col_btn_void.Width = 41;
            // 
            // VoirdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 900);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoirdForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lbl_date;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lbl_invoice_number;
        private MaterialSkin.Controls.MaterialLabel lbl_staff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_invoice_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewButtonColumn col_btn_void;
    }
}