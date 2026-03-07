namespace Salon.View
{
    partial class RefundModalForm
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
            this.lbl_product = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_reason = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_price = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_item_discount = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_qty_sold = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbl_vat_amount = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_refund_amount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_refund_number = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_payment_method = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(53, 67);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Product:";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Depth = 0;
            this.lbl_product.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_product.Location = new System.Drawing.Point(333, 67);
            this.lbl_product.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(99, 19);
            this.lbl_product.TabIndex = 1;
            this.lbl_product.Text = "product name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(53, 362);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Qty Sold:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(53, 484);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Reason:";
            // 
            // cmb_reason
            // 
            this.cmb_reason.AutoResize = false;
            this.cmb_reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_reason.Depth = 0;
            this.cmb_reason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_reason.DropDownHeight = 174;
            this.cmb_reason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_reason.DropDownWidth = 121;
            this.cmb_reason.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_reason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_reason.FormattingEnabled = true;
            this.cmb_reason.Hint = "Select a reason";
            this.cmb_reason.IntegralHeight = false;
            this.cmb_reason.ItemHeight = 43;
            this.cmb_reason.Items.AddRange(new object[] {
            "Damaged",
            "Expired",
            "Opened",
            "Wrong Item",
            "Wrong Size",
            "Customer Changed Mind",
            ""});
            this.cmb_reason.Location = new System.Drawing.Point(53, 534);
            this.cmb_reason.MaxDropDownItems = 4;
            this.cmb_reason.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_reason.Name = "cmb_reason";
            this.cmb_reason.Size = new System.Drawing.Size(450, 49);
            this.cmb_reason.StartIndex = -1;
            this.cmb_reason.TabIndex = 5;
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(476, 750);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_confirm.Size = new System.Drawing.Size(86, 36);
            this.btn_confirm.TabIndex = 7;
            this.btn_confirm.Text = "confirm";
            this.btn_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm.UseAccentColor = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(659, 750);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(53, 126);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(95, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Orignal Price:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Depth = 0;
            this.lbl_price.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_price.Location = new System.Drawing.Point(333, 126);
            this.lbl_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(35, 19);
            this.lbl_price.TabIndex = 10;
            this.lbl_price.Text = "price";
            // 
            // lbl_item_discount
            // 
            this.lbl_item_discount.AutoSize = true;
            this.lbl_item_discount.Depth = 0;
            this.lbl_item_discount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_item_discount.Location = new System.Drawing.Point(333, 185);
            this.lbl_item_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_item_discount.Name = "lbl_item_discount";
            this.lbl_item_discount.Size = new System.Drawing.Size(97, 19);
            this.lbl_item_discount.TabIndex = 12;
            this.lbl_item_discount.Text = "item discount";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(53, 185);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(99, 19);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = "Item Discount";
            // 
            // lbl_qty_sold
            // 
            this.lbl_qty_sold.AutoSize = true;
            this.lbl_qty_sold.Depth = 0;
            this.lbl_qty_sold.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_qty_sold.Location = new System.Drawing.Point(333, 362);
            this.lbl_qty_sold.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.lbl_qty_sold.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_qty_sold.Name = "lbl_qty_sold";
            this.lbl_qty_sold.Size = new System.Drawing.Size(57, 19);
            this.lbl_qty_sold.TabIndex = 15;
            this.lbl_qty_sold.Text = "qty sold";
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbl_vat_amount);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.txt_qty);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.lbl_refund_amount);
            this.materialCard1.Controls.Add(this.lbl_refund_number);
            this.materialCard1.Controls.Add(this.materialLabel13);
            this.materialCard1.Controls.Add(this.lbl_payment_method);
            this.materialCard1.Controls.Add(this.materialLabel12);
            this.materialCard1.Controls.Add(this.materialLabel11);
            this.materialCard1.Controls.Add(this.btn_cancel);
            this.materialCard1.Controls.Add(this.btn_confirm);
            this.materialCard1.Controls.Add(this.cmb_reason);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.lbl_qty_sold);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.lbl_product);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.lbl_item_discount);
            this.materialCard1.Controls.Add(this.lbl_price);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(50, 14, 14, 14);
            this.materialCard1.Size = new System.Drawing.Size(794, 533);
            this.materialCard1.TabIndex = 17;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // lbl_vat_amount
            // 
            this.lbl_vat_amount.AutoSize = true;
            this.lbl_vat_amount.Depth = 0;
            this.lbl_vat_amount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_vat_amount.Location = new System.Drawing.Point(333, 244);
            this.lbl_vat_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_vat_amount.Name = "lbl_vat_amount";
            this.lbl_vat_amount.Size = new System.Drawing.Size(85, 19);
            this.lbl_vat_amount.TabIndex = 26;
            this.lbl_vat_amount.Text = "vat_amount";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(53, 244);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(85, 19);
            this.materialLabel6.TabIndex = 25;
            this.materialLabel6.Text = "Vat Amount";
            // 
            // txt_qty
            // 
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.Location = new System.Drawing.Point(313, 424);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(137, 22);
            this.txt_qty.TabIndex = 24;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_KeyPress);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(53, 303);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(84, 19);
            this.materialLabel7.TabIndex = 23;
            this.materialLabel7.Text = "Net Refund:";
            // 
            // lbl_refund_amount
            // 
            this.lbl_refund_amount.AutoSize = true;
            this.lbl_refund_amount.Depth = 0;
            this.lbl_refund_amount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_refund_amount.Location = new System.Drawing.Point(333, 303);
            this.lbl_refund_amount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.lbl_refund_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_refund_amount.Name = "lbl_refund_amount";
            this.lbl_refund_amount.Size = new System.Drawing.Size(76, 19);
            this.lbl_refund_amount.TabIndex = 22;
            this.lbl_refund_amount.Text = "net_refund";
            // 
            // lbl_refund_number
            // 
            this.lbl_refund_number.AutoSize = true;
            this.lbl_refund_number.Depth = 0;
            this.lbl_refund_number.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_refund_number.Location = new System.Drawing.Point(333, 701);
            this.lbl_refund_number.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.lbl_refund_number.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_refund_number.Name = "lbl_refund_number";
            this.lbl_refund_number.Size = new System.Drawing.Size(108, 19);
            this.lbl_refund_number.TabIndex = 21;
            this.lbl_refund_number.Text = "refund_number";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(58, 701);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(103, 19);
            this.materialLabel13.TabIndex = 20;
            this.materialLabel13.Text = "Reference No.:";
            // 
            // lbl_payment_method
            // 
            this.lbl_payment_method.AutoSize = true;
            this.lbl_payment_method.Depth = 0;
            this.lbl_payment_method.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_payment_method.Location = new System.Drawing.Point(325, 642);
            this.lbl_payment_method.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.lbl_payment_method.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_payment_method.Name = "lbl_payment_method";
            this.lbl_payment_method.Size = new System.Drawing.Size(121, 19);
            this.lbl_payment_method.TabIndex = 19;
            this.lbl_payment_method.Text = "payment method";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(58, 642);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(126, 19);
            this.materialLabel12.TabIndex = 18;
            this.materialLabel12.Text = "Payment Method:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(45, 421);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(84, 19);
            this.materialLabel11.TabIndex = 17;
            this.materialLabel11.Text = "Refund Qty:";
            // 
            // RefundModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RefundModalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refund Product";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_product;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmb_reason;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lbl_price;
        private MaterialSkin.Controls.MaterialLabel lbl_item_discount;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lbl_qty_sold;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel lbl_payment_method;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel lbl_refund_number;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lbl_refund_amount;
        private System.Windows.Forms.TextBox txt_qty;
        private MaterialSkin.Controls.MaterialLabel lbl_vat_amount;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}