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
            this.components = new System.ComponentModel.Container();
            this.lbl_appointment_id = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_transaction_date = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_payment_method = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_amount_paid = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_services = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_customer_name = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_refund_amount = new MaterialSkin.Controls.MaterialLabel();
            this.txt_reason = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cmb_refund_method = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancel_refund = new MaterialSkin.Controls.MaterialButton();
            this.btn_refund = new MaterialSkin.Controls.MaterialButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.servicesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_test = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_appointment_id
            // 
            this.lbl_appointment_id.AutoSize = true;
            this.lbl_appointment_id.Depth = 0;
            this.lbl_appointment_id.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_appointment_id.Location = new System.Drawing.Point(43, 41);
            this.lbl_appointment_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_appointment_id.Name = "lbl_appointment_id";
            this.lbl_appointment_id.Size = new System.Drawing.Size(119, 19);
            this.lbl_appointment_id.TabIndex = 0;
            this.lbl_appointment_id.Text = "Appointment ID: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_transaction_date);
            this.groupBox1.Controls.Add(this.lbl_payment_method);
            this.groupBox1.Controls.Add(this.lbl_amount_paid);
            this.groupBox1.Controls.Add(this.lbl_services);
            this.groupBox1.Controls.Add(this.lbl_customer_name);
            this.groupBox1.Controls.Add(this.lbl_appointment_id);
            this.groupBox1.Location = new System.Drawing.Point(6, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1188, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Details";
            // 
            // lbl_transaction_date
            // 
            this.lbl_transaction_date.AutoSize = true;
            this.lbl_transaction_date.Depth = 0;
            this.lbl_transaction_date.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_transaction_date.Location = new System.Drawing.Point(696, 126);
            this.lbl_transaction_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_transaction_date.Name = "lbl_transaction_date";
            this.lbl_transaction_date.Size = new System.Drawing.Size(131, 19);
            this.lbl_transaction_date.TabIndex = 4;
            this.lbl_transaction_date.Text = "Transaction Date: ";
            // 
            // lbl_payment_method
            // 
            this.lbl_payment_method.AutoSize = true;
            this.lbl_payment_method.Depth = 0;
            this.lbl_payment_method.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_payment_method.Location = new System.Drawing.Point(696, 76);
            this.lbl_payment_method.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_payment_method.Name = "lbl_payment_method";
            this.lbl_payment_method.Size = new System.Drawing.Size(130, 19);
            this.lbl_payment_method.TabIndex = 4;
            this.lbl_payment_method.Text = "Payment Method: ";
            // 
            // lbl_amount_paid
            // 
            this.lbl_amount_paid.AutoSize = true;
            this.lbl_amount_paid.Depth = 0;
            this.lbl_amount_paid.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_amount_paid.Location = new System.Drawing.Point(696, 27);
            this.lbl_amount_paid.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_amount_paid.Name = "lbl_amount_paid";
            this.lbl_amount_paid.Size = new System.Drawing.Size(101, 19);
            this.lbl_amount_paid.TabIndex = 3;
            this.lbl_amount_paid.Text = "Amount Paid: ";
            // 
            // lbl_services
            // 
            this.lbl_services.AutoSize = true;
            this.lbl_services.Depth = 0;
            this.lbl_services.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_services.Location = new System.Drawing.Point(43, 115);
            this.lbl_services.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_services.Name = "lbl_services";
            this.lbl_services.Size = new System.Drawing.Size(79, 19);
            this.lbl_services.TabIndex = 2;
            this.lbl_services.Text = "Service(s): ";
            // 
            // lbl_customer_name
            // 
            this.lbl_customer_name.AutoSize = true;
            this.lbl_customer_name.Depth = 0;
            this.lbl_customer_name.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_customer_name.Location = new System.Drawing.Point(43, 76);
            this.lbl_customer_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_customer_name.Name = "lbl_customer_name";
            this.lbl_customer_name.Size = new System.Drawing.Size(123, 19);
            this.lbl_customer_name.TabIndex = 1;
            this.lbl_customer_name.Text = "Customer Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_refund_amount);
            this.groupBox2.Controls.Add(this.txt_reason);
            this.groupBox2.Controls.Add(this.cmb_refund_method);
            this.groupBox2.Controls.Add(this.materialLabel11);
            this.groupBox2.Controls.Add(this.materialLabel12);
            this.groupBox2.Controls.Add(this.materialLabel13);
            this.groupBox2.Location = new System.Drawing.Point(6, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1188, 265);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Refund Options";
            // 
            // lbl_refund_amount
            // 
            this.lbl_refund_amount.AutoSize = true;
            this.lbl_refund_amount.Depth = 0;
            this.lbl_refund_amount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_refund_amount.Location = new System.Drawing.Point(685, 54);
            this.lbl_refund_amount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_refund_amount.Name = "lbl_refund_amount";
            this.lbl_refund_amount.Size = new System.Drawing.Size(116, 19);
            this.lbl_refund_amount.TabIndex = 5;
            this.lbl_refund_amount.Text = "Refund Amount:";
            // 
            // txt_reason
            // 
            this.txt_reason.AnimateReadOnly = false;
            this.txt_reason.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_reason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_reason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reason.Depth = 0;
            this.txt_reason.HideSelection = true;
            this.txt_reason.Location = new System.Drawing.Point(688, 173);
            this.txt_reason.MaxLength = 32767;
            this.txt_reason.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.PasswordChar = '\0';
            this.txt_reason.ReadOnly = false;
            this.txt_reason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_reason.SelectedText = "";
            this.txt_reason.SelectionLength = 0;
            this.txt_reason.SelectionStart = 0;
            this.txt_reason.ShortcutsEnabled = true;
            this.txt_reason.Size = new System.Drawing.Size(400, 86);
            this.txt_reason.TabIndex = 4;
            this.txt_reason.TabStop = false;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_reason.UseSystemPasswordChar = false;
            // 
            // cmb_refund_method
            // 
            this.cmb_refund_method.AutoResize = false;
            this.cmb_refund_method.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_refund_method.Depth = 0;
            this.cmb_refund_method.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_refund_method.DropDownHeight = 174;
            this.cmb_refund_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_refund_method.DropDownWidth = 121;
            this.cmb_refund_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_refund_method.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_refund_method.FormattingEnabled = true;
            this.cmb_refund_method.Hint = "Select Refund Method";
            this.cmb_refund_method.IntegralHeight = false;
            this.cmb_refund_method.ItemHeight = 43;
            this.cmb_refund_method.Items.AddRange(new object[] {
            "Cash",
            "Gcash"});
            this.cmb_refund_method.Location = new System.Drawing.Point(688, 98);
            this.cmb_refund_method.MaxDropDownItems = 4;
            this.cmb_refund_method.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_refund_method.Name = "cmb_refund_method";
            this.cmb_refund_method.Size = new System.Drawing.Size(400, 49);
            this.cmb_refund_method.StartIndex = -1;
            this.cmb_refund_method.TabIndex = 3;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(43, 208);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(113, 19);
            this.materialLabel11.TabIndex = 2;
            this.materialLabel11.Text = "Refund Reason:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(42, 128);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(114, 19);
            this.materialLabel12.TabIndex = 1;
            this.materialLabel12.Text = "Refund Method:";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(46, 54);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(116, 19);
            this.materialLabel13.TabIndex = 0;
            this.materialLabel13.Text = "Refund Amount:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cancel_refund);
            this.groupBox3.Controls.Add(this.btn_refund);
            this.groupBox3.Location = new System.Drawing.Point(6, 778);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1188, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btn_cancel_refund
            // 
            this.btn_cancel_refund.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel_refund.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel_refund.Depth = 0;
            this.btn_cancel_refund.HighEmphasis = true;
            this.btn_cancel_refund.Icon = null;
            this.btn_cancel_refund.Location = new System.Drawing.Point(309, 40);
            this.btn_cancel_refund.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel_refund.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel_refund.Name = "btn_cancel_refund";
            this.btn_cancel_refund.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel_refund.Size = new System.Drawing.Size(137, 36);
            this.btn_cancel_refund.TabIndex = 4;
            this.btn_cancel_refund.Text = "cancel refund";
            this.btn_cancel_refund.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel_refund.UseAccentColor = false;
            this.btn_cancel_refund.UseVisualStyleBackColor = true;
            this.btn_cancel_refund.Click += new System.EventHandler(this.btn_cancel_refund_Click);
            // 
            // btn_refund
            // 
            this.btn_refund.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_refund.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_refund.Depth = 0;
            this.btn_refund.HighEmphasis = true;
            this.btn_refund.Icon = null;
            this.btn_refund.Location = new System.Drawing.Point(46, 40);
            this.btn_refund.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_refund.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_refund.Name = "btn_refund";
            this.btn_refund.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_refund.Size = new System.Drawing.Size(146, 36);
            this.btn_refund.TabIndex = 3;
            this.btn_refund.Text = "Confirm refund";
            this.btn_refund.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_refund.UseAccentColor = false;
            this.btn_refund.UseVisualStyleBackColor = true;
            this.btn_refund.Click += new System.EventHandler(this.btn_refund_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.servicesPanel);
            this.groupBox4.Location = new System.Drawing.Point(6, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1188, 162);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Service Selection";
            // 
            // servicesPanel
            // 
            this.servicesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.servicesPanel.Location = new System.Drawing.Point(3, 18);
            this.servicesPanel.Name = "servicesPanel";
            this.servicesPanel.Padding = new System.Windows.Forms.Padding(10);
            this.servicesPanel.Size = new System.Drawing.Size(1182, 141);
            this.servicesPanel.TabIndex = 0;
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(654, 98);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(44, 16);
            this.lbl_test.TabIndex = 6;
            this.lbl_test.Text = "label1";
            this.lbl_test.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // RefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RefundForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REFUND TRANSACTION";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_appointment_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel lbl_transaction_date;
        private MaterialSkin.Controls.MaterialLabel lbl_payment_method;
        private MaterialSkin.Controls.MaterialLabel lbl_amount_paid;
        private MaterialSkin.Controls.MaterialLabel lbl_services;
        private MaterialSkin.Controls.MaterialLabel lbl_customer_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btn_refund;
        private MaterialSkin.Controls.MaterialButton btn_cancel_refund;
        private MaterialSkin.Controls.MaterialComboBox cmb_refund_method;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_reason;
        private MaterialSkin.Controls.MaterialLabel lbl_refund_amount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel servicesPanel;
        private System.Windows.Forms.Label lbl_test;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}