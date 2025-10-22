namespace Salon.View
{
    partial class ConfigureSettingsForm
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
            this.configureTabControl = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.createAdminTab = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_next = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_show_password = new MaterialSkin.Controls.MaterialCheckbox();
            this.txt_username = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_confirm_password = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_address = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txt_first_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_middle_name = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_last_name = new MaterialSkin.Controls.MaterialTextBox();
            this.dtp_day_of_birth = new System.Windows.Forms.DateTimePicker();
            this.txt_contact = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_email = new MaterialSkin.Controls.MaterialTextBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.txt_vat = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_back = new MaterialSkin.Controls.MaterialButton();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_bill_note = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txt_internet_bill = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_other_bill = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_month_rent = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_water_bill = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_electric_bill = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_working_hours = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_total_cost = new MaterialSkin.Controls.MaterialTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.createAdminTab.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // configureTabControl
            // 
            this.configureTabControl.BaseTabControl = this.materialTabControl1;
            this.configureTabControl.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.configureTabControl.Depth = 0;
            this.configureTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.configureTabControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.configureTabControl.Location = new System.Drawing.Point(0, 24);
            this.configureTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.configureTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.configureTabControl.Name = "configureTabControl";
            this.configureTabControl.Size = new System.Drawing.Size(1582, 100);
            this.configureTabControl.TabIndex = 0;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.createAdminTab);
            this.materialTabControl1.Controls.Add(this.settingsTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 124);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1582, 928);
            this.materialTabControl1.TabIndex = 1;
            this.materialTabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.materialTabControl1_Selecting);
            // 
            // createAdminTab
            // 
            this.createAdminTab.Controls.Add(this.materialCard1);
            this.createAdminTab.Location = new System.Drawing.Point(4, 25);
            this.createAdminTab.Name = "createAdminTab";
            this.createAdminTab.Padding = new System.Windows.Forms.Padding(50, 75, 50, 50);
            this.createAdminTab.Size = new System.Drawing.Size(1574, 899);
            this.createAdminTab.TabIndex = 0;
            this.createAdminTab.Text = "Create Admin";
            this.createAdminTab.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_cancel);
            this.materialCard1.Controls.Add(this.btn_next);
            this.materialCard1.Controls.Add(this.groupBox2);
            this.materialCard1.Controls.Add(this.groupBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(50, 75);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1474, 774);
            this.materialCard1.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(1325, 701);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_next.Depth = 0;
            this.btn_next.HighEmphasis = true;
            this.btn_next.Icon = null;
            this.btn_next.Location = new System.Drawing.Point(1176, 701);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_next.Name = "btn_next";
            this.btn_next.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_next.Size = new System.Drawing.Size(64, 36);
            this.btn_next.TabIndex = 17;
            this.btn_next.Text = "Next";
            this.btn_next.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_next.UseAccentColor = false;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chk_show_password);
            this.groupBox2.Controls.Add(this.txt_username);
            this.groupBox2.Controls.Add(this.txt_password);
            this.groupBox2.Controls.Add(this.txt_confirm_password);
            this.groupBox2.Location = new System.Drawing.Point(957, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.groupBox2.Size = new System.Drawing.Size(500, 475);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACCOUNT";
            // 
            // chk_show_password
            // 
            this.chk_show_password.AutoSize = true;
            this.chk_show_password.Depth = 0;
            this.chk_show_password.Location = new System.Drawing.Point(57, 336);
            this.chk_show_password.Margin = new System.Windows.Forms.Padding(0);
            this.chk_show_password.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_show_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_show_password.Name = "chk_show_password";
            this.chk_show_password.ReadOnly = false;
            this.chk_show_password.Ripple = true;
            this.chk_show_password.Size = new System.Drawing.Size(149, 37);
            this.chk_show_password.TabIndex = 10;
            this.chk_show_password.Text = "Show Password";
            this.chk_show_password.UseVisualStyleBackColor = true;
            this.chk_show_password.CheckedChanged += new System.EventHandler(this.chk_show_password_CheckedChanged);
            // 
            // txt_username
            // 
            this.txt_username.AnimateReadOnly = false;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Depth = 0;
            this.txt_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_username.Hint = "Username";
            this.txt_username.LeadingIcon = null;
            this.txt_username.Location = new System.Drawing.Point(57, 39);
            this.txt_username.MaxLength = 50;
            this.txt_username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(400, 50);
            this.txt_username.TabIndex = 7;
            this.txt_username.Text = "";
            this.txt_username.TrailingIcon = null;
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = true;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.Hint = "Password";
            this.txt_password.LeadingIcon = null;
            this.txt_password.Location = new System.Drawing.Point(57, 131);
            this.txt_password.MaxLength = 50;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(400, 50);
            this.txt_password.TabIndex = 8;
            this.txt_password.Text = "";
            this.txt_password.TrailingIcon = null;
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.AnimateReadOnly = true;
            this.txt_confirm_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirm_password.Depth = 0;
            this.txt_confirm_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_confirm_password.Hint = "Confirm Password";
            this.txt_confirm_password.LeadingIcon = null;
            this.txt_confirm_password.Location = new System.Drawing.Point(57, 225);
            this.txt_confirm_password.MaxLength = 50;
            this.txt_confirm_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_confirm_password.Multiline = false;
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Size = new System.Drawing.Size(400, 50);
            this.txt_confirm_password.TabIndex = 9;
            this.txt_confirm_password.Text = "";
            this.txt_confirm_password.TrailingIcon = null;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_first_name);
            this.groupBox1.Controls.Add(this.txt_middle_name);
            this.groupBox1.Controls.Add(this.txt_last_name);
            this.groupBox1.Controls.Add(this.dtp_day_of_birth);
            this.groupBox1.Controls.Add(this.txt_contact);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Location = new System.Drawing.Point(17, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox1.Size = new System.Drawing.Size(900, 475);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONAL INFORMATION";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(474, 218);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Date of Birth:";
            // 
            // txt_address
            // 
            this.txt_address.AnimateReadOnly = false;
            this.txt_address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.Depth = 0;
            this.txt_address.HideSelection = true;
            this.txt_address.Hint = "Address";
            this.txt_address.Location = new System.Drawing.Point(23, 322);
            this.txt_address.MaxLength = 255;
            this.txt_address.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ReadOnly = false;
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(666, 122);
            this.txt_address.TabIndex = 6;
            this.txt_address.TabStop = false;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_address.UseSystemPasswordChar = false;
            // 
            // txt_first_name
            // 
            this.txt_first_name.AnimateReadOnly = false;
            this.txt_first_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_first_name.Depth = 0;
            this.txt_first_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_first_name.Hint = "First Name";
            this.txt_first_name.LeadingIcon = null;
            this.txt_first_name.Location = new System.Drawing.Point(23, 39);
            this.txt_first_name.MaxLength = 50;
            this.txt_first_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_first_name.Multiline = false;
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(400, 50);
            this.txt_first_name.TabIndex = 0;
            this.txt_first_name.Text = "";
            this.txt_first_name.TrailingIcon = null;
            // 
            // txt_middle_name
            // 
            this.txt_middle_name.AnimateReadOnly = false;
            this.txt_middle_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_middle_name.Depth = 0;
            this.txt_middle_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_middle_name.Hint = "Middle Name";
            this.txt_middle_name.LeadingIcon = null;
            this.txt_middle_name.Location = new System.Drawing.Point(23, 131);
            this.txt_middle_name.MaxLength = 50;
            this.txt_middle_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_middle_name.Multiline = false;
            this.txt_middle_name.Name = "txt_middle_name";
            this.txt_middle_name.Size = new System.Drawing.Size(400, 50);
            this.txt_middle_name.TabIndex = 1;
            this.txt_middle_name.Text = "";
            this.txt_middle_name.TrailingIcon = null;
            // 
            // txt_last_name
            // 
            this.txt_last_name.AnimateReadOnly = false;
            this.txt_last_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_last_name.Depth = 0;
            this.txt_last_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_last_name.Hint = "Last Name";
            this.txt_last_name.LeadingIcon = null;
            this.txt_last_name.Location = new System.Drawing.Point(23, 225);
            this.txt_last_name.MaxLength = 50;
            this.txt_last_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_last_name.Multiline = false;
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.Size = new System.Drawing.Size(400, 50);
            this.txt_last_name.TabIndex = 2;
            this.txt_last_name.Text = "";
            this.txt_last_name.TrailingIcon = null;
            // 
            // dtp_day_of_birth
            // 
            this.dtp_day_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_day_of_birth.Location = new System.Drawing.Point(477, 240);
            this.dtp_day_of_birth.Name = "dtp_day_of_birth";
            this.dtp_day_of_birth.Size = new System.Drawing.Size(400, 22);
            this.dtp_day_of_birth.TabIndex = 5;
            // 
            // txt_contact
            // 
            this.txt_contact.AnimateReadOnly = false;
            this.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contact.Depth = 0;
            this.txt_contact.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contact.Hint = "Contact #";
            this.txt_contact.LeadingIcon = null;
            this.txt_contact.Location = new System.Drawing.Point(477, 39);
            this.txt_contact.MaxLength = 11;
            this.txt_contact.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contact.Multiline = false;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(400, 50);
            this.txt_contact.TabIndex = 3;
            this.txt_contact.Text = "";
            this.txt_contact.TrailingIcon = null;
            // 
            // txt_email
            // 
            this.txt_email.AnimateReadOnly = false;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Depth = 0;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_email.Hint = "Email";
            this.txt_email.LeadingIcon = null;
            this.txt_email.Location = new System.Drawing.Point(477, 131);
            this.txt_email.MaxLength = 50;
            this.txt_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(400, 50);
            this.txt_email.TabIndex = 4;
            this.txt_email.Text = "";
            this.txt_email.TrailingIcon = null;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.materialCard2);
            this.settingsTab.Location = new System.Drawing.Point(4, 25);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(125, 75, 125, 50);
            this.settingsTab.Size = new System.Drawing.Size(1574, 899);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.txt_vat);
            this.materialCard2.Controls.Add(this.btn_back);
            this.materialCard2.Controls.Add(this.btn_save);
            this.materialCard2.Controls.Add(this.groupBox3);
            this.materialCard2.Controls.Add(this.groupBox4);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(125, 75);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1324, 774);
            this.materialCard2.TabIndex = 0;
            // 
            // txt_vat
            // 
            this.txt_vat.AnimateReadOnly = false;
            this.txt_vat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vat.Depth = 0;
            this.txt_vat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_vat.Hint = "Vat (%)";
            this.txt_vat.LeadingIcon = null;
            this.txt_vat.Location = new System.Drawing.Point(941, 86);
            this.txt_vat.MaxLength = 50;
            this.txt_vat.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_vat.Multiline = false;
            this.txt_vat.Name = "txt_vat";
            this.txt_vat.Size = new System.Drawing.Size(272, 50);
            this.txt_vat.TabIndex = 49;
            this.txt_vat.Text = "";
            this.txt_vat.TrailingIcon = null;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_back.Depth = 0;
            this.btn_back.HighEmphasis = true;
            this.btn_back.Icon = null;
            this.btn_back.Location = new System.Drawing.Point(957, 514);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_back.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_back.Name = "btn_back";
            this.btn_back.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_back.Size = new System.Drawing.Size(64, 36);
            this.btn_back.TabIndex = 48;
            this.btn_back.Text = "Back";
            this.btn_back.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_back.UseAccentColor = false;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(1149, 514);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 47;
            this.btn_save.Text = "Save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_bill_note);
            this.groupBox3.Controls.Add(this.txt_internet_bill);
            this.groupBox3.Controls.Add(this.txt_other_bill);
            this.groupBox3.Controls.Add(this.txt_month_rent);
            this.groupBox3.Controls.Add(this.txt_water_bill);
            this.groupBox3.Controls.Add(this.txt_electric_bill);
            this.groupBox3.Location = new System.Drawing.Point(32, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(788, 351);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rent and Bills";
            // 
            // txt_bill_note
            // 
            this.txt_bill_note.AnimateReadOnly = true;
            this.txt_bill_note.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_bill_note.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_bill_note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bill_note.Depth = 0;
            this.txt_bill_note.HideSelection = true;
            this.txt_bill_note.Hint = "Notes";
            this.txt_bill_note.Location = new System.Drawing.Point(448, 248);
            this.txt_bill_note.MaxLength = 32767;
            this.txt_bill_note.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_bill_note.Name = "txt_bill_note";
            this.txt_bill_note.PasswordChar = '\0';
            this.txt_bill_note.ReadOnly = false;
            this.txt_bill_note.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_bill_note.SelectedText = "";
            this.txt_bill_note.SelectionLength = 0;
            this.txt_bill_note.SelectionStart = 0;
            this.txt_bill_note.ShortcutsEnabled = true;
            this.txt_bill_note.Size = new System.Drawing.Size(300, 80);
            this.txt_bill_note.TabIndex = 42;
            this.txt_bill_note.TabStop = false;
            this.txt_bill_note.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_bill_note.UseSystemPasswordChar = false;
            // 
            // txt_internet_bill
            // 
            this.txt_internet_bill.AnimateReadOnly = true;
            this.txt_internet_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_internet_bill.Depth = 0;
            this.txt_internet_bill.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_internet_bill.Hint = "Internet Bill";
            this.txt_internet_bill.LeadingIcon = null;
            this.txt_internet_bill.Location = new System.Drawing.Point(448, 50);
            this.txt_internet_bill.Margin = new System.Windows.Forms.Padding(50);
            this.txt_internet_bill.MaxLength = 50;
            this.txt_internet_bill.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_internet_bill.Multiline = false;
            this.txt_internet_bill.Name = "txt_internet_bill";
            this.txt_internet_bill.Size = new System.Drawing.Size(300, 50);
            this.txt_internet_bill.TabIndex = 23;
            this.txt_internet_bill.Text = "";
            this.txt_internet_bill.TrailingIcon = null;
            this.txt_internet_bill.TextChanged += new System.EventHandler(this.txt_internet_bill_TextChanged);
            // 
            // txt_other_bill
            // 
            this.txt_other_bill.AnimateReadOnly = true;
            this.txt_other_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_other_bill.Depth = 0;
            this.txt_other_bill.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_other_bill.Hint = "Other Bill";
            this.txt_other_bill.LeadingIcon = null;
            this.txt_other_bill.Location = new System.Drawing.Point(448, 150);
            this.txt_other_bill.Margin = new System.Windows.Forms.Padding(50);
            this.txt_other_bill.MaxLength = 50;
            this.txt_other_bill.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_other_bill.Multiline = false;
            this.txt_other_bill.Name = "txt_other_bill";
            this.txt_other_bill.Size = new System.Drawing.Size(300, 50);
            this.txt_other_bill.TabIndex = 24;
            this.txt_other_bill.Text = "";
            this.txt_other_bill.TrailingIcon = null;
            this.txt_other_bill.TextChanged += new System.EventHandler(this.txt_other_bill_TextChanged);
            // 
            // txt_month_rent
            // 
            this.txt_month_rent.AnimateReadOnly = true;
            this.txt_month_rent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_month_rent.Depth = 0;
            this.txt_month_rent.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_month_rent.Hint = "Monthly Rent";
            this.txt_month_rent.LeadingIcon = null;
            this.txt_month_rent.Location = new System.Drawing.Point(39, 50);
            this.txt_month_rent.Margin = new System.Windows.Forms.Padding(50);
            this.txt_month_rent.MaxLength = 50;
            this.txt_month_rent.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_month_rent.Multiline = false;
            this.txt_month_rent.Name = "txt_month_rent";
            this.txt_month_rent.Size = new System.Drawing.Size(300, 50);
            this.txt_month_rent.TabIndex = 15;
            this.txt_month_rent.Text = "";
            this.txt_month_rent.TrailingIcon = null;
            this.txt_month_rent.TextChanged += new System.EventHandler(this.txt_month_rent_TextChanged);
            // 
            // txt_water_bill
            // 
            this.txt_water_bill.AnimateReadOnly = true;
            this.txt_water_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_water_bill.Depth = 0;
            this.txt_water_bill.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_water_bill.Hint = "Water Bill";
            this.txt_water_bill.LeadingIcon = null;
            this.txt_water_bill.Location = new System.Drawing.Point(39, 248);
            this.txt_water_bill.Margin = new System.Windows.Forms.Padding(50);
            this.txt_water_bill.MaxLength = 50;
            this.txt_water_bill.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_water_bill.Multiline = false;
            this.txt_water_bill.Name = "txt_water_bill";
            this.txt_water_bill.Size = new System.Drawing.Size(300, 50);
            this.txt_water_bill.TabIndex = 22;
            this.txt_water_bill.Text = "";
            this.txt_water_bill.TrailingIcon = null;
            this.txt_water_bill.TextChanged += new System.EventHandler(this.txt_water_bill_TextChanged);
            // 
            // txt_electric_bill
            // 
            this.txt_electric_bill.AnimateReadOnly = true;
            this.txt_electric_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_electric_bill.Depth = 0;
            this.txt_electric_bill.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_electric_bill.Hint = "Electricity Bill";
            this.txt_electric_bill.LeadingIcon = null;
            this.txt_electric_bill.Location = new System.Drawing.Point(39, 150);
            this.txt_electric_bill.Margin = new System.Windows.Forms.Padding(50);
            this.txt_electric_bill.MaxLength = 50;
            this.txt_electric_bill.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_electric_bill.Multiline = false;
            this.txt_electric_bill.Name = "txt_electric_bill";
            this.txt_electric_bill.Size = new System.Drawing.Size(300, 50);
            this.txt_electric_bill.TabIndex = 21;
            this.txt_electric_bill.Text = "";
            this.txt_electric_bill.TrailingIcon = null;
            this.txt_electric_bill.TextChanged += new System.EventHandler(this.txt_electric_bill_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_working_hours);
            this.groupBox4.Controls.Add(this.lbl_total_cost);
            this.groupBox4.Location = new System.Drawing.Point(32, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(788, 163);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total";
            // 
            // txt_working_hours
            // 
            this.txt_working_hours.AnimateReadOnly = true;
            this.txt_working_hours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_working_hours.Depth = 0;
            this.txt_working_hours.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_working_hours.Hint = "Total Working Hours";
            this.txt_working_hours.LeadingIcon = null;
            this.txt_working_hours.Location = new System.Drawing.Point(448, 59);
            this.txt_working_hours.Margin = new System.Windows.Forms.Padding(50);
            this.txt_working_hours.MaxLength = 50;
            this.txt_working_hours.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_working_hours.Multiline = false;
            this.txt_working_hours.Name = "txt_working_hours";
            this.txt_working_hours.Size = new System.Drawing.Size(300, 50);
            this.txt_working_hours.TabIndex = 17;
            this.txt_working_hours.Text = "";
            this.txt_working_hours.TrailingIcon = null;
            // 
            // lbl_total_cost
            // 
            this.lbl_total_cost.AnimateReadOnly = true;
            this.lbl_total_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_total_cost.Depth = 0;
            this.lbl_total_cost.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_total_cost.Hint = "Total Cost";
            this.lbl_total_cost.LeadingIcon = null;
            this.lbl_total_cost.Location = new System.Drawing.Point(39, 59);
            this.lbl_total_cost.Margin = new System.Windows.Forms.Padding(50);
            this.lbl_total_cost.MaxLength = 50;
            this.lbl_total_cost.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_total_cost.Multiline = false;
            this.lbl_total_cost.Name = "lbl_total_cost";
            this.lbl_total_cost.ReadOnly = true;
            this.lbl_total_cost.Size = new System.Drawing.Size(300, 50);
            this.lbl_total_cost.TabIndex = 18;
            this.lbl_total_cost.Text = "";
            this.lbl_total_cost.TrailingIcon = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConfigureSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1055);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.configureTabControl);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "ConfigureSettingsForm";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConfigureSettingsForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.createAdminTab.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector configureTabControl;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage createAdminTab;
        private System.Windows.Forms.TabPage settingsTab;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_address;
        private MaterialSkin.Controls.MaterialTextBox txt_first_name;
        private MaterialSkin.Controls.MaterialTextBox txt_middle_name;
        private MaterialSkin.Controls.MaterialTextBox txt_last_name;
        private System.Windows.Forms.DateTimePicker dtp_day_of_birth;
        private MaterialSkin.Controls.MaterialTextBox txt_contact;
        private MaterialSkin.Controls.MaterialTextBox txt_email;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialCheckbox chk_show_password;
        private MaterialSkin.Controls.MaterialTextBox txt_username;
        private MaterialSkin.Controls.MaterialTextBox txt_password;
        private MaterialSkin.Controls.MaterialTextBox txt_confirm_password;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_bill_note;
        private MaterialSkin.Controls.MaterialTextBox txt_internet_bill;
        private MaterialSkin.Controls.MaterialTextBox txt_other_bill;
        private MaterialSkin.Controls.MaterialTextBox txt_month_rent;
        private MaterialSkin.Controls.MaterialTextBox txt_water_bill;
        private MaterialSkin.Controls.MaterialTextBox txt_electric_bill;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialTextBox txt_working_hours;
        private MaterialSkin.Controls.MaterialTextBox lbl_total_cost;
        private MaterialSkin.Controls.MaterialButton btn_back;
        private MaterialSkin.Controls.MaterialTextBox txt_vat;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_next;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}