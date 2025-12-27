namespace Salon.View
{
    partial class DeliveryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
            this.txt_received_by = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_total = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_price = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_invoice = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_qty = new MaterialSkin.Controls.MaterialTextBox();
            this.cb_supplier_name = new MaterialSkin.Controls.MaterialComboBox();
            this.cb_product_names = new MaterialSkin.Controls.MaterialComboBox();
            this.dtp_delivery_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_expiry = new System.Windows.Forms.DateTimePicker();
            this.txt_notes = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_delete = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.dgv_Items = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmb_product_size = new MaterialSkin.Controls.MaterialComboBox();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_size_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_size_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_delivered_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expiry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_view_delivered_items = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_received_by
            // 
            this.txt_received_by.AnimateReadOnly = true;
            this.txt_received_by.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_received_by.Depth = 0;
            this.txt_received_by.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_received_by.Hint = "Received by";
            this.txt_received_by.LeadingIcon = null;
            this.txt_received_by.Location = new System.Drawing.Point(48, 27);
            this.txt_received_by.MaxLength = 50;
            this.txt_received_by.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_received_by.Multiline = false;
            this.txt_received_by.Name = "txt_received_by";
            this.txt_received_by.ReadOnly = true;
            this.txt_received_by.Size = new System.Drawing.Size(400, 50);
            this.txt_received_by.TabIndex = 0;
            this.txt_received_by.Text = "";
            this.txt_received_by.TrailingIcon = null;
            // 
            // txt_total
            // 
            this.txt_total.AnimateReadOnly = true;
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total.Depth = 0;
            this.txt_total.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_total.Hint = "Total Cost";
            this.txt_total.LeadingIcon = null;
            this.txt_total.Location = new System.Drawing.Point(491, 389);
            this.txt_total.MaxLength = 50;
            this.txt_total.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_total.Multiline = false;
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(400, 50);
            this.txt_total.TabIndex = 1;
            this.txt_total.Text = "";
            this.txt_total.TrailingIcon = null;
            // 
            // txt_price
            // 
            this.txt_price.AnimateReadOnly = false;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Depth = 0;
            this.txt_price.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_price.Hint = "Price";
            this.txt_price.LeadingIcon = null;
            this.txt_price.Location = new System.Drawing.Point(491, 292);
            this.txt_price.MaxLength = 50;
            this.txt_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_price.Multiline = false;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(400, 50);
            this.txt_price.TabIndex = 3;
            this.txt_price.Text = "";
            this.txt_price.TrailingIcon = null;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // txt_invoice
            // 
            this.txt_invoice.AnimateReadOnly = false;
            this.txt_invoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_invoice.Depth = 0;
            this.txt_invoice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_invoice.Hint = "Invoice";
            this.txt_invoice.LeadingIcon = null;
            this.txt_invoice.Location = new System.Drawing.Point(491, 118);
            this.txt_invoice.MaxLength = 16;
            this.txt_invoice.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_invoice.Multiline = false;
            this.txt_invoice.Name = "txt_invoice";
            this.txt_invoice.Size = new System.Drawing.Size(400, 50);
            this.txt_invoice.TabIndex = 4;
            this.txt_invoice.Text = "";
            this.txt_invoice.TrailingIcon = null;
            this.txt_invoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_invoice_KeyPress);
            // 
            // txt_qty
            // 
            this.txt_qty.AnimateReadOnly = false;
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_qty.Depth = 0;
            this.txt_qty.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_qty.Hint = "Quantity Delivered";
            this.txt_qty.LeadingIcon = null;
            this.txt_qty.Location = new System.Drawing.Point(491, 209);
            this.txt_qty.MaxLength = 50;
            this.txt_qty.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_qty.Multiline = false;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(400, 50);
            this.txt_qty.TabIndex = 7;
            this.txt_qty.Text = "";
            this.txt_qty.TrailingIcon = null;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_KeyPress);
            // 
            // cb_supplier_name
            // 
            this.cb_supplier_name.AutoResize = false;
            this.cb_supplier_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_supplier_name.Depth = 0;
            this.cb_supplier_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_supplier_name.DropDownHeight = 174;
            this.cb_supplier_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supplier_name.DropDownWidth = 121;
            this.cb_supplier_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_supplier_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_supplier_name.FormattingEnabled = true;
            this.cb_supplier_name.Hint = "Select Supplier";
            this.cb_supplier_name.IntegralHeight = false;
            this.cb_supplier_name.ItemHeight = 43;
            this.cb_supplier_name.Location = new System.Drawing.Point(48, 116);
            this.cb_supplier_name.MaxDropDownItems = 4;
            this.cb_supplier_name.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_supplier_name.Name = "cb_supplier_name";
            this.cb_supplier_name.Size = new System.Drawing.Size(400, 49);
            this.cb_supplier_name.StartIndex = 0;
            this.cb_supplier_name.TabIndex = 8;
            // 
            // cb_product_names
            // 
            this.cb_product_names.AutoResize = false;
            this.cb_product_names.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_product_names.Depth = 0;
            this.cb_product_names.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_product_names.DropDownHeight = 174;
            this.cb_product_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_product_names.DropDownWidth = 121;
            this.cb_product_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_product_names.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_product_names.FormattingEnabled = true;
            this.cb_product_names.Hint = "Select Product";
            this.cb_product_names.IntegralHeight = false;
            this.cb_product_names.ItemHeight = 43;
            this.cb_product_names.Location = new System.Drawing.Point(48, 199);
            this.cb_product_names.MaxDropDownItems = 4;
            this.cb_product_names.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_product_names.Name = "cb_product_names";
            this.cb_product_names.Size = new System.Drawing.Size(400, 49);
            this.cb_product_names.StartIndex = 0;
            this.cb_product_names.TabIndex = 9;
            this.cb_product_names.SelectedIndexChanged += new System.EventHandler(this.cb_product_names_SelectedIndexChanged);
            // 
            // dtp_delivery_date
            // 
            this.dtp_delivery_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_delivery_date.Location = new System.Drawing.Point(961, 146);
            this.dtp_delivery_date.Name = "dtp_delivery_date";
            this.dtp_delivery_date.Size = new System.Drawing.Size(219, 22);
            this.dtp_delivery_date.TabIndex = 10;
            // 
            // dtp_expiry
            // 
            this.dtp_expiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_expiry.Location = new System.Drawing.Point(1245, 146);
            this.dtp_expiry.Name = "dtp_expiry";
            this.dtp_expiry.Size = new System.Drawing.Size(219, 22);
            this.dtp_expiry.TabIndex = 11;
            // 
            // txt_notes
            // 
            this.txt_notes.AnimateReadOnly = false;
            this.txt_notes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_notes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_notes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_notes.Depth = 0;
            this.txt_notes.HideSelection = true;
            this.txt_notes.Hint = "Notes";
            this.txt_notes.Location = new System.Drawing.Point(961, 226);
            this.txt_notes.MaxLength = 255;
            this.txt_notes.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.PasswordChar = '\0';
            this.txt_notes.ReadOnly = false;
            this.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_notes.SelectedText = "";
            this.txt_notes.SelectionLength = 0;
            this.txt_notes.SelectionStart = 0;
            this.txt_notes.ShortcutsEnabled = true;
            this.txt_notes.Size = new System.Drawing.Size(503, 185);
            this.txt_notes.TabIndex = 12;
            this.txt_notes.TabStop = false;
            this.txt_notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_notes.UseSystemPasswordChar = false;
            this.txt_notes.Click += new System.EventHandler(this.txt_notes_Click);
            this.txt_notes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_notes_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(958, 118);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Delivered Date:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(1242, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Expiration Date:";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.cmb_product_size);
            this.materialCard1.Controls.Add(this.btn_save);
            this.materialCard1.Controls.Add(this.btn_cancel);
            this.materialCard1.Controls.Add(this.btn_delete);
            this.materialCard1.Controls.Add(this.btn_update);
            this.materialCard1.Controls.Add(this.btn_add);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.txt_notes);
            this.materialCard1.Controls.Add(this.dtp_expiry);
            this.materialCard1.Controls.Add(this.dtp_delivery_date);
            this.materialCard1.Controls.Add(this.cb_product_names);
            this.materialCard1.Controls.Add(this.cb_supplier_name);
            this.materialCard1.Controls.Add(this.txt_qty);
            this.materialCard1.Controls.Add(this.txt_invoice);
            this.materialCard1.Controls.Add(this.txt_price);
            this.materialCard1.Controls.Add(this.txt_total);
            this.materialCard1.Controls.Add(this.txt_received_by);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 84);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1560, 568);
            this.materialCard1.TabIndex = 15;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.Enabled = false;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(1118, 512);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(426, 512);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_delete.Depth = 0;
            this.btn_delete.Enabled = false;
            this.btn_delete.HighEmphasis = true;
            this.btn_delete.Icon = null;
            this.btn_delete.Location = new System.Drawing.Point(240, 512);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_delete.Size = new System.Drawing.Size(118, 36);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Remove Item";
            this.btn_delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_delete.UseAccentColor = false;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(57, 512);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(115, 36);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Update item";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add.Depth = 0;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(57, 512);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add.Size = new System.Drawing.Size(88, 36);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add Item";
            this.btn_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add.UseAccentColor = false;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_Items
            // 
            this.dgv_Items.AllowUserToAddRows = false;
            this.dgv_Items.AllowUserToDeleteRows = false;
            this.dgv_Items.AllowUserToResizeColumns = false;
            this.dgv_Items.AllowUserToResizeRows = false;
            this.dgv_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.col_product_name,
            this.col_product_size_id,
            this.col_size_label,
            this.col_qty,
            this.col_content,
            this.col_total_qty,
            this.col_price,
            this.col_total,
            this.col_delivered_date,
            this.col_expiry_date,
            this.col_note,
            this.col_view_delivered_items});
            this.dgv_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Items.Location = new System.Drawing.Point(20, 652);
            this.dgv_Items.Name = "dgv_Items";
            this.dgv_Items.ReadOnly = true;
            this.dgv_Items.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Items.RowHeadersVisible = false;
            this.dgv_Items.RowHeadersWidth = 51;
            this.dgv_Items.RowTemplate.Height = 24;
            this.dgv_Items.Size = new System.Drawing.Size(1560, 197);
            this.dgv_Items.TabIndex = 16;
            this.dgv_Items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Items_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // cmb_product_size
            // 
            this.cmb_product_size.AutoResize = false;
            this.cmb_product_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_product_size.Depth = 0;
            this.cmb_product_size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_product_size.DropDownHeight = 174;
            this.cmb_product_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product_size.DropDownWidth = 121;
            this.cmb_product_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_product_size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_product_size.FormattingEnabled = true;
            this.cmb_product_size.Hint = "Select Product Size";
            this.cmb_product_size.IntegralHeight = false;
            this.cmb_product_size.ItemHeight = 43;
            this.cmb_product_size.Location = new System.Drawing.Point(48, 293);
            this.cmb_product_size.MaxDropDownItems = 4;
            this.cmb_product_size.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_product_size.Name = "cmb_product_size";
            this.cmb_product_size.Size = new System.Drawing.Size(400, 49);
            this.cmb_product_size.StartIndex = 0;
            this.cmb_product_size.TabIndex = 20;
            this.cmb_product_size.SelectedIndexChanged += new System.EventHandler(this.cmb_product_size_SelectedIndexChanged);
            // 
            // product_id
            // 
            this.product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_id.HeaderText = "product_id";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Visible = false;
            // 
            // col_product_name
            // 
            this.col_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_name.HeaderText = "Product ";
            this.col_product_name.MinimumWidth = 6;
            this.col_product_name.Name = "col_product_name";
            this.col_product_name.ReadOnly = true;
            // 
            // col_product_size_id
            // 
            this.col_product_size_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_product_size_id.HeaderText = "product_size_id";
            this.col_product_size_id.MinimumWidth = 6;
            this.col_product_size_id.Name = "col_product_size_id";
            this.col_product_size_id.ReadOnly = true;
            this.col_product_size_id.Width = 130;
            // 
            // col_size_label
            // 
            this.col_size_label.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_size_label.HeaderText = "Size Label";
            this.col_size_label.MinimumWidth = 6;
            this.col_size_label.Name = "col_size_label";
            this.col_size_label.ReadOnly = true;
            // 
            // col_qty
            // 
            this.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_qty.HeaderText = "Qty Delivered";
            this.col_qty.MinimumWidth = 6;
            this.col_qty.Name = "col_qty";
            this.col_qty.ReadOnly = true;
            // 
            // col_content
            // 
            this.col_content.HeaderText = "content";
            this.col_content.MinimumWidth = 6;
            this.col_content.Name = "col_content";
            this.col_content.ReadOnly = true;
            this.col_content.Width = 125;
            // 
            // col_total_qty
            // 
            this.col_total_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_total_qty.HeaderText = "Total Qty";
            this.col_total_qty.MinimumWidth = 6;
            this.col_total_qty.Name = "col_total_qty";
            this.col_total_qty.ReadOnly = true;
            this.col_total_qty.Width = 90;
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_price.HeaderText = "Price";
            this.col_price.MinimumWidth = 6;
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            // 
            // col_total
            // 
            this.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_total.HeaderText = "Total Cost";
            this.col_total.MinimumWidth = 6;
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            // 
            // col_delivered_date
            // 
            this.col_delivered_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_delivered_date.HeaderText = "Delivered Date";
            this.col_delivered_date.MinimumWidth = 6;
            this.col_delivered_date.Name = "col_delivered_date";
            this.col_delivered_date.ReadOnly = true;
            // 
            // col_expiry_date
            // 
            this.col_expiry_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_expiry_date.HeaderText = "Expiration Date";
            this.col_expiry_date.MinimumWidth = 6;
            this.col_expiry_date.Name = "col_expiry_date";
            this.col_expiry_date.ReadOnly = true;
            // 
            // col_note
            // 
            this.col_note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_note.HeaderText = "Notes";
            this.col_note.MinimumWidth = 6;
            this.col_note.Name = "col_note";
            this.col_note.ReadOnly = true;
            this.col_note.Visible = false;
            // 
            // col_view_delivered_items
            // 
            this.col_view_delivered_items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_view_delivered_items.HeaderText = "";
            this.col_view_delivered_items.Image = ((System.Drawing.Image)(resources.GetObject("col_view_delivered_items.Image")));
            this.col_view_delivered_items.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_view_delivered_items.MinimumWidth = 6;
            this.col_view_delivered_items.Name = "col_view_delivered_items";
            this.col_view_delivered_items.ReadOnly = true;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 869);
            this.Controls.Add(this.dgv_Items);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryForm";
            this.Padding = new System.Windows.Forms.Padding(20, 84, 20, 20);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DELIVERY INFORMATION";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_received_by;
        private MaterialSkin.Controls.MaterialTextBox txt_total;
        private MaterialSkin.Controls.MaterialTextBox txt_price;
        private MaterialSkin.Controls.MaterialTextBox txt_invoice;
        private MaterialSkin.Controls.MaterialTextBox txt_qty;
        private MaterialSkin.Controls.MaterialComboBox cb_supplier_name;
        private MaterialSkin.Controls.MaterialComboBox cb_product_names;
        private System.Windows.Forms.DateTimePicker dtp_delivery_date;
        private System.Windows.Forms.DateTimePicker dtp_expiry;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_notes;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_delete;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_add;
        private System.Windows.Forms.DataGridView dgv_Items;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialComboBox cmb_product_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_size_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_size_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_delivered_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expiry_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_note;
        private System.Windows.Forms.DataGridViewImageColumn col_view_delivered_items;
    }
}