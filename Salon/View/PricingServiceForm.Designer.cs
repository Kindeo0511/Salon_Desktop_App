namespace Salon.View
{
    partial class PricingServiceForm
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
            this.cmb_services = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_product_cost = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_stylist_cost = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_overhead_cost = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_total_cost = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_final_price = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_percent = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_margin_peso = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.txt_duration = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_vat = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_net_price = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_net_profit = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // cmb_services
            // 
            this.cmb_services.AutoResize = false;
            this.cmb_services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_services.Depth = 0;
            this.cmb_services.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_services.DropDownHeight = 174;
            this.cmb_services.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_services.DropDownWidth = 121;
            this.cmb_services.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_services.FormattingEnabled = true;
            this.cmb_services.Hint = "Select Service";
            this.cmb_services.IntegralHeight = false;
            this.cmb_services.ItemHeight = 43;
            this.cmb_services.Location = new System.Drawing.Point(73, 118);
            this.cmb_services.MaxDropDownItems = 4;
            this.cmb_services.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_services.Name = "cmb_services";
            this.cmb_services.Size = new System.Drawing.Size(279, 49);
            this.cmb_services.StartIndex = 0;
            this.cmb_services.TabIndex = 0;
            this.cmb_services.SelectedIndexChanged += new System.EventHandler(this.cmb_services_SelectedIndexChanged);
            // 
            // txt_product_cost
            // 
            this.txt_product_cost.AnimateReadOnly = false;
            this.txt_product_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_product_cost.Depth = 0;
            this.txt_product_cost.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_product_cost.Hint = "Product Cost";
            this.txt_product_cost.LeadingIcon = null;
            this.txt_product_cost.Location = new System.Drawing.Point(73, 346);
            this.txt_product_cost.MaxLength = 50;
            this.txt_product_cost.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_product_cost.Multiline = false;
            this.txt_product_cost.Name = "txt_product_cost";
            this.txt_product_cost.Size = new System.Drawing.Size(279, 50);
            this.txt_product_cost.TabIndex = 1;
            this.txt_product_cost.Text = "";
            this.txt_product_cost.TrailingIcon = null;
            // 
            // txt_stylist_cost
            // 
            this.txt_stylist_cost.AnimateReadOnly = false;
            this.txt_stylist_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stylist_cost.Depth = 0;
            this.txt_stylist_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_stylist_cost.Hint = "Stylist Cost";
            this.txt_stylist_cost.LeadingIcon = null;
            this.txt_stylist_cost.Location = new System.Drawing.Point(73, 445);
            this.txt_stylist_cost.MaxLength = 50;
            this.txt_stylist_cost.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_stylist_cost.Multiline = false;
            this.txt_stylist_cost.Name = "txt_stylist_cost";
            this.txt_stylist_cost.Size = new System.Drawing.Size(279, 50);
            this.txt_stylist_cost.TabIndex = 2;
            this.txt_stylist_cost.Text = "";
            this.txt_stylist_cost.TrailingIcon = null;
            // 
            // txt_overhead_cost
            // 
            this.txt_overhead_cost.AnimateReadOnly = false;
            this.txt_overhead_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_overhead_cost.Depth = 0;
            this.txt_overhead_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_overhead_cost.Hint = "OverHeadCost";
            this.txt_overhead_cost.LeadingIcon = null;
            this.txt_overhead_cost.Location = new System.Drawing.Point(491, 117);
            this.txt_overhead_cost.MaxLength = 50;
            this.txt_overhead_cost.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_overhead_cost.Multiline = false;
            this.txt_overhead_cost.Name = "txt_overhead_cost";
            this.txt_overhead_cost.Size = new System.Drawing.Size(279, 50);
            this.txt_overhead_cost.TabIndex = 3;
            this.txt_overhead_cost.Text = "";
            this.txt_overhead_cost.TrailingIcon = null;
            // 
            // txt_total_cost
            // 
            this.txt_total_cost.AnimateReadOnly = false;
            this.txt_total_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_cost.Depth = 0;
            this.txt_total_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_total_cost.Hint = "Total Cost";
            this.txt_total_cost.LeadingIcon = null;
            this.txt_total_cost.Location = new System.Drawing.Point(491, 225);
            this.txt_total_cost.MaxLength = 50;
            this.txt_total_cost.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_total_cost.Multiline = false;
            this.txt_total_cost.Name = "txt_total_cost";
            this.txt_total_cost.Size = new System.Drawing.Size(279, 50);
            this.txt_total_cost.TabIndex = 4;
            this.txt_total_cost.Text = "0.00";
            this.txt_total_cost.TrailingIcon = null;
            // 
            // txt_final_price
            // 
            this.txt_final_price.AnimateReadOnly = false;
            this.txt_final_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_final_price.Depth = 0;
            this.txt_final_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_final_price.Hint = "Selling Price";
            this.txt_final_price.LeadingIcon = null;
            this.txt_final_price.Location = new System.Drawing.Point(491, 346);
            this.txt_final_price.MaxLength = 50;
            this.txt_final_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_final_price.Multiline = false;
            this.txt_final_price.Name = "txt_final_price";
            this.txt_final_price.Size = new System.Drawing.Size(279, 50);
            this.txt_final_price.TabIndex = 5;
            this.txt_final_price.Text = "0.00";
            this.txt_final_price.TrailingIcon = null;
            this.txt_final_price.TextChanged += new System.EventHandler(this.txt_final_price_TextChanged);
            // 
            // txt_percent
            // 
            this.txt_percent.AnimateReadOnly = false;
            this.txt_percent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_percent.Depth = 0;
            this.txt_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_percent.Hint = "Profit Percent (%)";
            this.txt_percent.LeadingIcon = null;
            this.txt_percent.Location = new System.Drawing.Point(863, 445);
            this.txt_percent.MaxLength = 50;
            this.txt_percent.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_percent.Multiline = false;
            this.txt_percent.Name = "txt_percent";
            this.txt_percent.Size = new System.Drawing.Size(279, 50);
            this.txt_percent.TabIndex = 7;
            this.txt_percent.Text = "";
            this.txt_percent.TrailingIcon = null;
            this.txt_percent.TextChanged += new System.EventHandler(this.txt_percent_TextChanged);
            // 
            // txt_margin_peso
            // 
            this.txt_margin_peso.AnimateReadOnly = false;
            this.txt_margin_peso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_margin_peso.Depth = 0;
            this.txt_margin_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_margin_peso.Hint = "Gross Profit";
            this.txt_margin_peso.LeadingIcon = null;
            this.txt_margin_peso.Location = new System.Drawing.Point(863, 346);
            this.txt_margin_peso.MaxLength = 50;
            this.txt_margin_peso.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_margin_peso.Multiline = false;
            this.txt_margin_peso.Name = "txt_margin_peso";
            this.txt_margin_peso.Size = new System.Drawing.Size(279, 50);
            this.txt_margin_peso.TabIndex = 8;
            this.txt_margin_peso.Text = "";
            this.txt_margin_peso.TrailingIcon = null;
            this.txt_margin_peso.TextChanged += new System.EventHandler(this.txt_margin_peso_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(863, 614);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 9;
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
            this.btn_cancel.Location = new System.Drawing.Point(1065, 614);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(863, 614);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Save changes";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_duration
            // 
            this.txt_duration.AnimateReadOnly = false;
            this.txt_duration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_duration.Depth = 0;
            this.txt_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_duration.Hint = "Duration (mins)";
            this.txt_duration.LeadingIcon = null;
            this.txt_duration.Location = new System.Drawing.Point(73, 225);
            this.txt_duration.MaxLength = 50;
            this.txt_duration.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_duration.Multiline = false;
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(279, 50);
            this.txt_duration.TabIndex = 12;
            this.txt_duration.Text = "";
            this.txt_duration.TrailingIcon = null;
            // 
            // txt_vat
            // 
            this.txt_vat.AnimateReadOnly = false;
            this.txt_vat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vat.Depth = 0;
            this.txt_vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_vat.Hint = "Vat Amount";
            this.txt_vat.LeadingIcon = null;
            this.txt_vat.Location = new System.Drawing.Point(491, 445);
            this.txt_vat.MaxLength = 50;
            this.txt_vat.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_vat.Multiline = false;
            this.txt_vat.Name = "txt_vat";
            this.txt_vat.Size = new System.Drawing.Size(279, 50);
            this.txt_vat.TabIndex = 13;
            this.txt_vat.Text = "";
            this.txt_vat.TrailingIcon = null;
            // 
            // txt_net_price
            // 
            this.txt_net_price.AnimateReadOnly = false;
            this.txt_net_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_net_price.Depth = 0;
            this.txt_net_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_net_price.Hint = "Net Price";
            this.txt_net_price.LeadingIcon = null;
            this.txt_net_price.Location = new System.Drawing.Point(863, 118);
            this.txt_net_price.MaxLength = 50;
            this.txt_net_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_net_price.Multiline = false;
            this.txt_net_price.Name = "txt_net_price";
            this.txt_net_price.Size = new System.Drawing.Size(279, 50);
            this.txt_net_price.TabIndex = 14;
            this.txt_net_price.Text = "";
            this.txt_net_price.TrailingIcon = null;
            // 
            // txt_net_profit
            // 
            this.txt_net_profit.AnimateReadOnly = false;
            this.txt_net_profit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_net_profit.Depth = 0;
            this.txt_net_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_net_profit.Hint = "Net Profit";
            this.txt_net_profit.LeadingIcon = null;
            this.txt_net_profit.Location = new System.Drawing.Point(863, 225);
            this.txt_net_profit.MaxLength = 50;
            this.txt_net_profit.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_net_profit.Multiline = false;
            this.txt_net_profit.Name = "txt_net_profit";
            this.txt_net_profit.Size = new System.Drawing.Size(279, 50);
            this.txt_net_profit.TabIndex = 15;
            this.txt_net_profit.Text = "";
            this.txt_net_profit.TrailingIcon = null;
            // 
            // PricingServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 748);
            this.Controls.Add(this.txt_net_profit);
            this.Controls.Add(this.txt_net_price);
            this.Controls.Add(this.txt_vat);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_margin_peso);
            this.Controls.Add(this.txt_percent);
            this.Controls.Add(this.txt_final_price);
            this.Controls.Add(this.txt_total_cost);
            this.Controls.Add(this.txt_overhead_cost);
            this.Controls.Add(this.txt_stylist_cost);
            this.Controls.Add(this.txt_product_cost);
            this.Controls.Add(this.cmb_services);
            this.Name = "PricingServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PricingServiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmb_services;
        private MaterialSkin.Controls.MaterialTextBox txt_product_cost;
        private MaterialSkin.Controls.MaterialTextBox txt_stylist_cost;
        private MaterialSkin.Controls.MaterialTextBox txt_overhead_cost;
        private MaterialSkin.Controls.MaterialTextBox txt_total_cost;
        private MaterialSkin.Controls.MaterialTextBox txt_final_price;
        private MaterialSkin.Controls.MaterialTextBox txt_percent;
        private MaterialSkin.Controls.MaterialTextBox txt_margin_peso;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialTextBox txt_duration;
        private MaterialSkin.Controls.MaterialTextBox txt_vat;
        private MaterialSkin.Controls.MaterialTextBox txt_net_price;
        private MaterialSkin.Controls.MaterialTextBox txt_net_profit;
    }
}