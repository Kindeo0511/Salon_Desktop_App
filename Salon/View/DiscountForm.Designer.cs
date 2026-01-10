namespace Salon.View
{
    partial class DiscountForm
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
            this.btn_cancel_discount = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmb_discount_type = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_discount = new System.Windows.Forms.NumericUpDown();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_promo_name = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.rad_percent = new System.Windows.Forms.RadioButton();
            this.rad_fixed = new System.Windows.Forms.RadioButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.chk_vat_exempt = new System.Windows.Forms.CheckBox();
            this.chk_is_active = new System.Windows.Forms.CheckBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.rad_published = new System.Windows.Forms.RadioButton();
            this.rad_draft = new System.Windows.Forms.RadioButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.email_flow_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_optional_message = new System.Windows.Forms.TextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_email_subject = new System.Windows.Forms.TextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update_draft = new MaterialSkin.Controls.MaterialButton();
            this.btn_published = new MaterialSkin.Controls.MaterialButton();
            this.btn_save_draft = new MaterialSkin.Controls.MaterialButton();
            this.email_preview = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.email_flow_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel_discount
            // 
            this.btn_cancel_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_discount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel_discount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel_discount.Depth = 0;
            this.btn_cancel_discount.HighEmphasis = true;
            this.btn_cancel_discount.Icon = null;
            this.btn_cancel_discount.Location = new System.Drawing.Point(734, 18);
            this.btn_cancel_discount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel_discount.Name = "btn_cancel_discount";
            this.btn_cancel_discount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel_discount.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel_discount.TabIndex = 15;
            this.btn_cancel_discount.Text = "cancel";
            this.btn_cancel_discount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel_discount.UseAccentColor = false;
            this.btn_cancel_discount.UseVisualStyleBackColor = true;
            this.btn_cancel_discount.Click += new System.EventHandler(this.btn_cancel_discount_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // cmb_discount_type
            // 
            this.cmb_discount_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_discount_type.FormattingEnabled = true;
            this.cmb_discount_type.Items.AddRange(new object[] {
            "Free",
            "Promo",
            "PWD",
            "Senior"});
            this.cmb_discount_type.Location = new System.Drawing.Point(400, 26);
            this.cmb_discount_type.Name = "cmb_discount_type";
            this.cmb_discount_type.Size = new System.Drawing.Size(389, 24);
            this.cmb_discount_type.Sorted = true;
            this.cmb_discount_type.TabIndex = 25;
            this.cmb_discount_type.SelectedIndexChanged += new System.EventHandler(this.cmb_discount_type_SelectedIndexChanged_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(45, 29);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "Discount Type:";
            // 
            // txt_discount
            // 
            this.txt_discount.DecimalPlaces = 2;
            this.txt_discount.Location = new System.Drawing.Point(397, 155);
            this.txt_discount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(389, 22);
            this.txt_discount.TabIndex = 27;
            this.txt_discount.ValueChanged += new System.EventHandler(this.txt_discount_ValueChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(45, 84);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(98, 19);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "Promo Name:";
            // 
            // txt_promo_name
            // 
            this.txt_promo_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_promo_name.Location = new System.Drawing.Point(400, 81);
            this.txt_promo_name.Name = "txt_promo_name";
            this.txt_promo_name.Size = new System.Drawing.Size(389, 22);
            this.txt_promo_name.TabIndex = 29;
            this.txt_promo_name.TextChanged += new System.EventHandler(this.txt_promo_name_TextChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(45, 158);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 30;
            this.materialLabel4.Text = "Discount:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(45, 229);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Type:";
            // 
            // rad_percent
            // 
            this.rad_percent.AutoSize = true;
            this.rad_percent.BackColor = System.Drawing.Color.Transparent;
            this.rad_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_percent.Location = new System.Drawing.Point(397, 224);
            this.rad_percent.Name = "rad_percent";
            this.rad_percent.Size = new System.Drawing.Size(115, 24);
            this.rad_percent.TabIndex = 32;
            this.rad_percent.TabStop = true;
            this.rad_percent.Text = "Percentage";
            this.rad_percent.UseVisualStyleBackColor = false;
            this.rad_percent.CheckedChanged += new System.EventHandler(this.rad_percent_CheckedChanged);
            // 
            // rad_fixed
            // 
            this.rad_fixed.AutoSize = true;
            this.rad_fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_fixed.Location = new System.Drawing.Point(657, 224);
            this.rad_fixed.Name = "rad_fixed";
            this.rad_fixed.Size = new System.Drawing.Size(132, 24);
            this.rad_fixed.TabIndex = 33;
            this.rad_fixed.TabStop = true;
            this.rad_fixed.Text = "Fixed Amount";
            this.rad_fixed.UseVisualStyleBackColor = true;
            this.rad_fixed.CheckedChanged += new System.EventHandler(this.rad_fixed_CheckedChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(48, 291);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 19);
            this.materialLabel5.TabIndex = 34;
            this.materialLabel5.Text = "Vat Exempt:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(48, 360);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(48, 19);
            this.materialLabel6.TabIndex = 35;
            this.materialLabel6.Text = "Active:";
            // 
            // chk_vat_exempt
            // 
            this.chk_vat_exempt.AutoSize = true;
            this.chk_vat_exempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_vat_exempt.Location = new System.Drawing.Point(400, 293);
            this.chk_vat_exempt.Name = "chk_vat_exempt";
            this.chk_vat_exempt.Size = new System.Drawing.Size(18, 17);
            this.chk_vat_exempt.TabIndex = 37;
            this.chk_vat_exempt.UseVisualStyleBackColor = true;
            // 
            // chk_is_active
            // 
            this.chk_is_active.AutoSize = true;
            this.chk_is_active.Location = new System.Drawing.Point(400, 360);
            this.chk_is_active.Name = "chk_is_active";
            this.chk_is_active.Size = new System.Drawing.Size(18, 17);
            this.chk_is_active.TabIndex = 38;
            this.chk_is_active.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.AutoScrollMargin = new System.Drawing.Size(0, 25);
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel10);
            this.materialCard1.Controls.Add(this.dtp_end);
            this.materialCard1.Controls.Add(this.materialLabel9);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.dtp_start);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.cmb_discount_type);
            this.materialCard1.Controls.Add(this.txt_promo_name);
            this.materialCard1.Controls.Add(this.rad_fixed);
            this.materialCard1.Controls.Add(this.txt_discount);
            this.materialCard1.Controls.Add(this.chk_vat_exempt);
            this.materialCard1.Controls.Add(this.rad_percent);
            this.materialCard1.Controls.Add(this.chk_is_active);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.email_flow_panel);
            this.materialCard1.Controls.Add(this.panel1);
            this.materialCard1.Controls.Add(this.panel2);
            this.materialCard1.Controls.Add(this.panel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(900, 533);
            this.materialCard1.TabIndex = 39;
            // 
            // rad_published
            // 
            this.rad_published.AutoSize = true;
            this.rad_published.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_published.Location = new System.Drawing.Point(249, 20);
            this.rad_published.Name = "rad_published";
            this.rad_published.Size = new System.Drawing.Size(103, 24);
            this.rad_published.TabIndex = 46;
            this.rad_published.TabStop = true;
            this.rad_published.Text = "Published";
            this.rad_published.UseVisualStyleBackColor = true;
            this.rad_published.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rad_draft
            // 
            this.rad_draft.AutoSize = true;
            this.rad_draft.BackColor = System.Drawing.Color.Transparent;
            this.rad_draft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_draft.Location = new System.Drawing.Point(37, 20);
            this.rad_draft.Name = "rad_draft";
            this.rad_draft.Size = new System.Drawing.Size(68, 24);
            this.rad_draft.TabIndex = 45;
            this.rad_draft.Text = "Draft";
            this.rad_draft.UseVisualStyleBackColor = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(48, 522);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(51, 19);
            this.materialLabel10.TabIndex = 44;
            this.materialLabel10.Text = "Status:";
            // 
            // dtp_end
            // 
            this.dtp_end.Checked = false;
            this.dtp_end.Enabled = false;
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(589, 446);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.ShowCheckBox = true;
            this.dtp_end.Size = new System.Drawing.Size(200, 22);
            this.dtp_end.TabIndex = 43;
            this.dtp_end.ValueChanged += new System.EventHandler(this.dtp_end_ValueChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(595, 421);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(32, 19);
            this.materialLabel9.TabIndex = 42;
            this.materialLabel9.Text = "End:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(337, 424);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(39, 19);
            this.materialLabel8.TabIndex = 41;
            this.materialLabel8.Text = "Start:";
            // 
            // dtp_start
            // 
            this.dtp_start.Checked = false;
            this.dtp_start.Enabled = false;
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(340, 446);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.ShowCheckBox = true;
            this.dtp_start.Size = new System.Drawing.Size(200, 22);
            this.dtp_start.TabIndex = 40;
            this.dtp_start.ValueChanged += new System.EventHandler(this.dtp_start_ValueChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(51, 446);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(58, 19);
            this.materialLabel7.TabIndex = 39;
            this.materialLabel7.Text = "Validity:";
            // 
            // email_flow_panel
            // 
            this.email_flow_panel.Controls.Add(this.groupBox1);
            this.email_flow_panel.Location = new System.Drawing.Point(51, 571);
            this.email_flow_panel.Name = "email_flow_panel";
            this.email_flow_panel.Size = new System.Drawing.Size(752, 570);
            this.email_flow_panel.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.email_preview);
            this.groupBox1.Controls.Add(this.materialLabel13);
            this.groupBox1.Controls.Add(this.txt_optional_message);
            this.groupBox1.Controls.Add(this.materialLabel12);
            this.groupBox1.Controls.Add(this.txt_email_subject);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 532);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMAIL NOTIFICATION";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(19, 245);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(100, 19);
            this.materialLabel13.TabIndex = 49;
            this.materialLabel13.Text = "Email Preview";
            // 
            // txt_optional_message
            // 
            this.txt_optional_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_optional_message.Location = new System.Drawing.Point(323, 121);
            this.txt_optional_message.MaxLength = 100;
            this.txt_optional_message.Multiline = true;
            this.txt_optional_message.Name = "txt_optional_message";
            this.txt_optional_message.Size = new System.Drawing.Size(389, 43);
            this.txt_optional_message.TabIndex = 48;
            this.txt_optional_message.TextChanged += new System.EventHandler(this.txt_optional_message_TextChanged);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(19, 121);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(133, 19);
            this.materialLabel12.TabIndex = 47;
            this.materialLabel12.Text = "Optional Message:";
            // 
            // txt_email_subject
            // 
            this.txt_email_subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email_subject.Location = new System.Drawing.Point(323, 52);
            this.txt_email_subject.MaxLength = 100;
            this.txt_email_subject.Name = "txt_email_subject";
            this.txt_email_subject.Size = new System.Drawing.Size(389, 22);
            this.txt_email_subject.TabIndex = 46;
            this.txt_email_subject.Text = "New Salon Offer Just for You!";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(19, 55);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(102, 19);
            this.materialLabel11.TabIndex = 45;
            this.materialLabel11.Text = "Email Subject:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_update_draft);
            this.panel1.Controls.Add(this.btn_published);
            this.panel1.Controls.Add(this.btn_save_draft);
            this.panel1.Controls.Add(this.btn_cancel_discount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(14, 1166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 75);
            this.panel1.TabIndex = 49;
            // 
            // btn_update_draft
            // 
            this.btn_update_draft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_draft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_draft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update_draft.Depth = 0;
            this.btn_update_draft.DrawShadows = false;
            this.btn_update_draft.HighEmphasis = true;
            this.btn_update_draft.Icon = null;
            this.btn_update_draft.Location = new System.Drawing.Point(37, 18);
            this.btn_update_draft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update_draft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update_draft.Name = "btn_update_draft";
            this.btn_update_draft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update_draft.Size = new System.Drawing.Size(126, 36);
            this.btn_update_draft.TabIndex = 18;
            this.btn_update_draft.Text = "update draft";
            this.btn_update_draft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update_draft.UseAccentColor = false;
            this.btn_update_draft.UseVisualStyleBackColor = true;
            this.btn_update_draft.Click += new System.EventHandler(this.btn_update_draft_Click);
            // 
            // btn_published
            // 
            this.btn_published.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_published.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_published.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_published.Depth = 0;
            this.btn_published.HighEmphasis = true;
            this.btn_published.Icon = null;
            this.btn_published.Location = new System.Drawing.Point(252, 18);
            this.btn_published.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_published.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_published.Name = "btn_published";
            this.btn_published.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_published.Size = new System.Drawing.Size(99, 36);
            this.btn_published.TabIndex = 17;
            this.btn_published.Text = "published";
            this.btn_published.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_published.UseAccentColor = false;
            this.btn_published.UseVisualStyleBackColor = true;
            this.btn_published.Click += new System.EventHandler(this.btn_published_Click);
            // 
            // btn_save_draft
            // 
            this.btn_save_draft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_draft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save_draft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save_draft.Depth = 0;
            this.btn_save_draft.DrawShadows = false;
            this.btn_save_draft.HighEmphasis = true;
            this.btn_save_draft.Icon = null;
            this.btn_save_draft.Location = new System.Drawing.Point(37, 18);
            this.btn_save_draft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save_draft.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save_draft.Name = "btn_save_draft";
            this.btn_save_draft.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save_draft.Size = new System.Drawing.Size(107, 36);
            this.btn_save_draft.TabIndex = 16;
            this.btn_save_draft.Text = "save draft";
            this.btn_save_draft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save_draft.UseAccentColor = false;
            this.btn_save_draft.UseVisualStyleBackColor = true;
            this.btn_save_draft.Click += new System.EventHandler(this.btn_save_draft_Click);
            // 
            // email_preview
            // 
            this.email_preview.Location = new System.Drawing.Point(22, 277);
            this.email_preview.MinimumSize = new System.Drawing.Size(20, 20);
            this.email_preview.Name = "email_preview";
            this.email_preview.Size = new System.Drawing.Size(690, 250);
            this.email_preview.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rad_draft);
            this.panel2.Controls.Add(this.rad_published);
            this.panel2.Location = new System.Drawing.Point(340, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 58);
            this.panel2.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(377, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 73);
            this.panel3.TabIndex = 51;
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISCOUNT INFORMATION";
            this.Load += new System.EventHandler(this.DiscountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.email_flow_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn_cancel_discount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmb_discount_type;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.NumericUpDown txt_discount;
        private System.Windows.Forms.TextBox txt_promo_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.RadioButton rad_fixed;
        private System.Windows.Forms.RadioButton rad_percent;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.CheckBox chk_vat_exempt;
        private System.Windows.Forms.CheckBox chk_is_active;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.RadioButton rad_published;
        private System.Windows.Forms.RadioButton rad_draft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_email_subject;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.TextBox txt_optional_message;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.FlowLayoutPanel email_flow_panel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btn_save_draft;
        private MaterialSkin.Controls.MaterialButton btn_published;
        private MaterialSkin.Controls.MaterialButton btn_update_draft;
        private System.Windows.Forms.WebBrowser email_preview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}