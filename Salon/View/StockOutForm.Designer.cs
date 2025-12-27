namespace Salon.View
{
    partial class StockOutForm
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
            this.dgv_transaction_details = new System.Windows.Forms.DataGridView();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_size_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty_delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty_accepted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty_rejected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty_remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expiry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction_details)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_transaction_details
            // 
            this.dgv_transaction_details.AllowUserToAddRows = false;
            this.dgv_transaction_details.AllowUserToDeleteRows = false;
            this.dgv_transaction_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaction_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_name,
            this.col_size_label,
            this.col_qty_delivered,
            this.col_qty_accepted,
            this.col_qty_rejected,
            this.col_qty_remaining,
            this.col_total_remaining,
            this.col_unit_price,
            this.col_total_price,
            this.col_expiry_date});
            this.dgv_transaction_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_transaction_details.Location = new System.Drawing.Point(25, 85);
            this.dgv_transaction_details.Name = "dgv_transaction_details";
            this.dgv_transaction_details.ReadOnly = true;
            this.dgv_transaction_details.RowHeadersVisible = false;
            this.dgv_transaction_details.RowHeadersWidth = 51;
            this.dgv_transaction_details.RowTemplate.Height = 24;
            this.dgv_transaction_details.Size = new System.Drawing.Size(1550, 690);
            this.dgv_transaction_details.TabIndex = 0;
            // 
            // col_product_name
            // 
            this.col_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_name.HeaderText = "Product Name";
            this.col_product_name.MinimumWidth = 6;
            this.col_product_name.Name = "col_product_name";
            this.col_product_name.ReadOnly = true;
            // 
            // col_size_label
            // 
            this.col_size_label.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_size_label.HeaderText = "Size Label";
            this.col_size_label.MinimumWidth = 6;
            this.col_size_label.Name = "col_size_label";
            this.col_size_label.ReadOnly = true;
            this.col_size_label.Width = 92;
            // 
            // col_qty_delivered
            // 
            this.col_qty_delivered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty_delivered.HeaderText = "Qty Delivered";
            this.col_qty_delivered.MinimumWidth = 6;
            this.col_qty_delivered.Name = "col_qty_delivered";
            this.col_qty_delivered.ReadOnly = true;
            this.col_qty_delivered.Width = 109;
            // 
            // col_qty_accepted
            // 
            this.col_qty_accepted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty_accepted.HeaderText = "Qty Accepted";
            this.col_qty_accepted.MinimumWidth = 6;
            this.col_qty_accepted.Name = "col_qty_accepted";
            this.col_qty_accepted.ReadOnly = true;
            this.col_qty_accepted.Width = 108;
            // 
            // col_qty_rejected
            // 
            this.col_qty_rejected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty_rejected.HeaderText = "Qty Rejected";
            this.col_qty_rejected.MinimumWidth = 6;
            this.col_qty_rejected.Name = "col_qty_rejected";
            this.col_qty_rejected.ReadOnly = true;
            this.col_qty_rejected.Width = 105;
            // 
            // col_qty_remaining
            // 
            this.col_qty_remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_qty_remaining.HeaderText = "Qty Remaining";
            this.col_qty_remaining.MinimumWidth = 6;
            this.col_qty_remaining.Name = "col_qty_remaining";
            this.col_qty_remaining.ReadOnly = true;
            this.col_qty_remaining.Width = 114;
            // 
            // col_total_remaining
            // 
            this.col_total_remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_total_remaining.HeaderText = "Total Remaining";
            this.col_total_remaining.MinimumWidth = 6;
            this.col_total_remaining.Name = "col_total_remaining";
            this.col_total_remaining.ReadOnly = true;
            this.col_total_remaining.Width = 124;
            // 
            // col_unit_price
            // 
            this.col_unit_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_unit_price.HeaderText = "Price";
            this.col_unit_price.MinimumWidth = 6;
            this.col_unit_price.Name = "col_unit_price";
            this.col_unit_price.ReadOnly = true;
            this.col_unit_price.Width = 67;
            // 
            // col_total_price
            // 
            this.col_total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_total_price.HeaderText = "Total Price";
            this.col_total_price.MinimumWidth = 6;
            this.col_total_price.Name = "col_total_price";
            this.col_total_price.ReadOnly = true;
            this.col_total_price.Width = 93;
            // 
            // col_expiry_date
            // 
            this.col_expiry_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_expiry_date.HeaderText = "Expiration Date";
            this.col_expiry_date.MinimumWidth = 6;
            this.col_expiry_date.Name = "col_expiry_date";
            this.col_expiry_date.ReadOnly = true;
            this.col_expiry_date.Width = 117;
            // 
            // StockOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.dgv_transaction_details);
            this.Name = "StockOutForm";
            this.Padding = new System.Windows.Forms.Padding(25, 85, 25, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockOutForm";
            this.Load += new System.EventHandler(this.StockOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction_details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transaction_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_size_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty_delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty_accepted;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty_rejected;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty_remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expiry_date;
    }
}