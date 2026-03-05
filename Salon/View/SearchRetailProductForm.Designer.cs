namespace Salon.View
{
    partial class SearchRetailProductForm
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
            this.txt_search_box = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_retails = new System.Windows.Forms.DataGridView();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_to_cart = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_retails)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search_box
            // 
            this.txt_search_box.AnimateReadOnly = false;
            this.txt_search_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search_box.Depth = 0;
            this.txt_search_box.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search_box.LeadingIcon = null;
            this.txt_search_box.Location = new System.Drawing.Point(36, 125);
            this.txt_search_box.MaxLength = 50;
            this.txt_search_box.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_search_box.Multiline = false;
            this.txt_search_box.Name = "txt_search_box";
            this.txt_search_box.Size = new System.Drawing.Size(1111, 50);
            this.txt_search_box.TabIndex = 0;
            this.txt_search_box.Text = "";
            this.txt_search_box.TrailingIcon = null;
            this.txt_search_box.TextChanged += new System.EventHandler(this.txt_search_box_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(6, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "SEARCH:";
            // 
            // dgv_retails
            // 
            this.dgv_retails.AllowUserToAddRows = false;
            this.dgv_retails.AllowUserToDeleteRows = false;
            this.dgv_retails.AllowUserToResizeColumns = false;
            this.dgv_retails.AllowUserToResizeRows = false;
            this.dgv_retails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_retails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_retails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_retails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_retails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_id,
            this.col_product_name,
            this.col_product_size_id,
            this.col_brand,
            this.col_size,
            this.col_price,
            this.btn_add_to_cart});
            this.dgv_retails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_retails.Location = new System.Drawing.Point(3, 195);
            this.dgv_retails.Name = "dgv_retails";
            this.dgv_retails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_retails.RowHeadersVisible = false;
            this.dgv_retails.RowHeadersWidth = 51;
            this.dgv_retails.RowTemplate.Height = 24;
            this.dgv_retails.Size = new System.Drawing.Size(1194, 402);
            this.dgv_retails.TabIndex = 2;
            this.dgv_retails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_retails_CellClick);
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
            // col_product_name
            // 
            this.col_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_name.HeaderText = "Product Name";
            this.col_product_name.MinimumWidth = 6;
            this.col_product_name.Name = "col_product_name";
            // 
            // col_product_size_id
            // 
            this.col_product_size_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_size_id.HeaderText = "product_size_id";
            this.col_product_size_id.MinimumWidth = 6;
            this.col_product_size_id.Name = "col_product_size_id";
            this.col_product_size_id.Visible = false;
            this.col_product_size_id.Width = 125;
            // 
            // col_brand
            // 
            this.col_brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_brand.HeaderText = "Brand";
            this.col_brand.MinimumWidth = 6;
            this.col_brand.Name = "col_brand";
            // 
            // col_size
            // 
            this.col_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_size.HeaderText = "Size";
            this.col_size.MinimumWidth = 6;
            this.col_size.Name = "col_size";
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_price.HeaderText = "Price";
            this.col_price.MinimumWidth = 6;
            this.col_price.Name = "col_price";
            // 
            // btn_add_to_cart
            // 
            this.btn_add_to_cart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_add_to_cart.HeaderText = "Cart";
            this.btn_add_to_cart.MinimumWidth = 6;
            this.btn_add_to_cart.Name = "btn_add_to_cart";
            this.btn_add_to_cart.Text = "Add To Cart";
            this.btn_add_to_cart.UseColumnTextForButtonValue = true;
            this.btn_add_to_cart.Width = 37;
            // 
            // SearchRetailProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.dgv_retails);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_search_box);
            this.Name = "SearchRetailProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchRetailProductForm";
            this.Load += new System.EventHandler(this.SearchRetailProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_retails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_search_box;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgv_retails;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewButtonColumn btn_add_to_cart;
    }
}