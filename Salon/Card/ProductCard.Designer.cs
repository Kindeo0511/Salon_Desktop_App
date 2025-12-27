namespace Salon.Card
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_remove = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_product = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_price = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.AutoSize = true;
            this.btn_remove.Depth = 0;
            this.btn_remove.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_remove.ForeColor = System.Drawing.Color.Red;
            this.btn_remove.Location = new System.Drawing.Point(536, 0);
            this.btn_remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(11, 19);
            this.btn_remove.TabIndex = 15;
            this.btn_remove.Text = "X";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // cmb_product
            // 
            this.cmb_product.AutoResize = false;
            this.cmb_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_product.Depth = 0;
            this.cmb_product.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_product.DropDownHeight = 174;
            this.cmb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product.DropDownWidth = 121;
            this.cmb_product.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Hint = "Select Product";
            this.cmb_product.IntegralHeight = false;
            this.cmb_product.ItemHeight = 43;
            this.cmb_product.Location = new System.Drawing.Point(18, 35);
            this.cmb_product.MaxDropDownItems = 4;
            this.cmb_product.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(336, 49);
            this.cmb_product.StartIndex = 0;
            this.cmb_product.TabIndex = 14;
            this.cmb_product.SelectedIndexChanged += new System.EventHandler(this.cmb_product_SelectedIndexChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(20, 13);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(56, 19);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Product";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Depth = 0;
            this.lbl_price.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_price.Location = new System.Drawing.Point(471, 64);
            this.lbl_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(32, 19);
            this.lbl_price.TabIndex = 12;
            this.lbl_price.Text = "0.00";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(467, 35);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(36, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Price";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(396, 35);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(25, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Qty";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(391, 64);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(38, 22);
            this.txt_qty.TabIndex = 16;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txt_qty);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.lbl_price);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(550, 100);
            this.materialCard1.TabIndex = 17;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.cmb_product);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialCard1);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(550, 100);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel btn_remove;
        private MaterialSkin.Controls.MaterialComboBox cmb_product;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lbl_price;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txt_qty;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
