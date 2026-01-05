namespace Salon.View
{
    partial class DeliveryAddStockForm
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
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.col_DeliveryItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.delivery_items_pagination = new Salon.Util.PaginationControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToAddRows = false;
            this.dgv_items.AllowUserToDeleteRows = false;
            this.dgv_items.AllowUserToResizeColumns = false;
            this.dgv_items.AllowUserToResizeRows = false;
            this.dgv_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DeliveryItemId,
            this.col_DeliveryId,
            this.col_ProductId,
            this.col_Quantity,
            this.col_UnitPrice,
            this.col_TotalPrice,
            this.col_ExpiryDate,
            this.col_notes});
            this.dgv_items.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_items.EnableHeadersVisualStyles = false;
            this.dgv_items.Location = new System.Drawing.Point(25, 25);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.ReadOnly = true;
            this.dgv_items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_items.RowHeadersVisible = false;
            this.dgv_items.RowHeadersWidth = 51;
            this.dgv_items.RowTemplate.Height = 24;
            this.dgv_items.Size = new System.Drawing.Size(944, 415);
            this.dgv_items.TabIndex = 0;
            // 
            // col_DeliveryItemId
            // 
            this.col_DeliveryItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DeliveryItemId.HeaderText = "id";
            this.col_DeliveryItemId.MinimumWidth = 6;
            this.col_DeliveryItemId.Name = "col_DeliveryItemId";
            this.col_DeliveryItemId.ReadOnly = true;
            this.col_DeliveryItemId.Visible = false;
            // 
            // col_DeliveryId
            // 
            this.col_DeliveryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DeliveryId.HeaderText = "Delivery No.";
            this.col_DeliveryId.MinimumWidth = 6;
            this.col_DeliveryId.Name = "col_DeliveryId";
            this.col_DeliveryId.ReadOnly = true;
            this.col_DeliveryId.Visible = false;
            // 
            // col_ProductId
            // 
            this.col_ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ProductId.HeaderText = "Product";
            this.col_ProductId.MinimumWidth = 6;
            this.col_ProductId.Name = "col_ProductId";
            this.col_ProductId.ReadOnly = true;
            // 
            // col_Quantity
            // 
            this.col_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Quantity.HeaderText = "Quantity";
            this.col_Quantity.MinimumWidth = 6;
            this.col_Quantity.Name = "col_Quantity";
            this.col_Quantity.ReadOnly = true;
            // 
            // col_UnitPrice
            // 
            this.col_UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_UnitPrice.HeaderText = "Unit Price";
            this.col_UnitPrice.MinimumWidth = 6;
            this.col_UnitPrice.Name = "col_UnitPrice";
            this.col_UnitPrice.ReadOnly = true;
            // 
            // col_TotalPrice
            // 
            this.col_TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TotalPrice.HeaderText = "Total Price";
            this.col_TotalPrice.MinimumWidth = 6;
            this.col_TotalPrice.Name = "col_TotalPrice";
            this.col_TotalPrice.ReadOnly = true;
            // 
            // col_ExpiryDate
            // 
            this.col_ExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ExpiryDate.HeaderText = "Expiration Date";
            this.col_ExpiryDate.MinimumWidth = 6;
            this.col_ExpiryDate.Name = "col_ExpiryDate";
            this.col_ExpiryDate.ReadOnly = true;
            // 
            // col_notes
            // 
            this.col_notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_notes.HeaderText = "Notes";
            this.col_notes.MinimumWidth = 6;
            this.col_notes.Name = "col_notes";
            this.col_notes.ReadOnly = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.delivery_items_pagination);
            this.materialCard1.Controls.Add(this.dgv_items);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(20);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(25);
            this.materialCard1.Size = new System.Drawing.Size(994, 533);
            this.materialCard1.TabIndex = 1;
            // 
            // delivery_items_pagination
            // 
            this.delivery_items_pagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delivery_items_pagination.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delivery_items_pagination.Location = new System.Drawing.Point(539, 455);
            this.delivery_items_pagination.Name = "delivery_items_pagination";
            this.delivery_items_pagination.Size = new System.Drawing.Size(388, 50);
            this.delivery_items_pagination.TabIndex = 1;
            // 
            // DeliveryAddStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryAddStockForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_items;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DeliveryItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DeliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_notes;
        private Util.PaginationControl delivery_items_pagination;
    }
}