namespace Salon.View
{
    partial class OverHeadAndTotalWorkingHoursForm
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
            this.txt_month_rent = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_total_util = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_total_cost = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_total_working_hours = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txt_month_rent
            // 
            this.txt_month_rent.AnimateReadOnly = false;
            this.txt_month_rent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_month_rent.Depth = 0;
            this.txt_month_rent.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_month_rent.Hint = "Monthly Rent";
            this.txt_month_rent.LeadingIcon = null;
            this.txt_month_rent.Location = new System.Drawing.Point(31, 18);
            this.txt_month_rent.MaxLength = 50;
            this.txt_month_rent.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_month_rent.Multiline = false;
            this.txt_month_rent.Name = "txt_month_rent";
            this.txt_month_rent.Size = new System.Drawing.Size(250, 50);
            this.txt_month_rent.TabIndex = 0;
            this.txt_month_rent.Text = "";
            this.txt_month_rent.TrailingIcon = null;
            // 
            // txt_total_util
            // 
            this.txt_total_util.AnimateReadOnly = false;
            this.txt_total_util.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_util.Depth = 0;
            this.txt_total_util.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_total_util.Hint = "Total Utilities Amount";
            this.txt_total_util.LeadingIcon = null;
            this.txt_total_util.Location = new System.Drawing.Point(31, 104);
            this.txt_total_util.MaxLength = 50;
            this.txt_total_util.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_total_util.Multiline = false;
            this.txt_total_util.Name = "txt_total_util";
            this.txt_total_util.Size = new System.Drawing.Size(250, 50);
            this.txt_total_util.TabIndex = 1;
            this.txt_total_util.Text = "";
            this.txt_total_util.TrailingIcon = null;
            // 
            // txt_total_cost
            // 
            this.txt_total_cost.AnimateReadOnly = false;
            this.txt_total_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_cost.Depth = 0;
            this.txt_total_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_total_cost.Hint = "Total Cost";
            this.txt_total_cost.LeadingIcon = null;
            this.txt_total_cost.Location = new System.Drawing.Point(331, 18);
            this.txt_total_cost.MaxLength = 50;
            this.txt_total_cost.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_total_cost.Multiline = false;
            this.txt_total_cost.Name = "txt_total_cost";
            this.txt_total_cost.Size = new System.Drawing.Size(250, 50);
            this.txt_total_cost.TabIndex = 2;
            this.txt_total_cost.Text = "";
            this.txt_total_cost.TrailingIcon = null;
            // 
            // txt_total_working_hours
            // 
            this.txt_total_working_hours.AnimateReadOnly = false;
            this.txt_total_working_hours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_working_hours.Depth = 0;
            this.txt_total_working_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_total_working_hours.Hint = "Total Working Hours";
            this.txt_total_working_hours.LeadingIcon = null;
            this.txt_total_working_hours.Location = new System.Drawing.Point(331, 104);
            this.txt_total_working_hours.MaxLength = 50;
            this.txt_total_working_hours.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_total_working_hours.Multiline = false;
            this.txt_total_working_hours.Name = "txt_total_working_hours";
            this.txt_total_working_hours.Size = new System.Drawing.Size(250, 50);
            this.txt_total_working_hours.TabIndex = 3;
            this.txt_total_working_hours.Text = "";
            this.txt_total_working_hours.TrailingIcon = null;
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save.Depth = 0;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(396, 243);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save.Size = new System.Drawing.Size(64, 36);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(331, 243);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(129, 36);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "save changes";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(504, 243);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // OverHeadAndTotalWorkingHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_total_working_hours);
            this.Controls.Add(this.txt_total_cost);
            this.Controls.Add(this.txt_total_util);
            this.Controls.Add(this.txt_month_rent);
            this.Name = "OverHeadAndTotalWorkingHoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OverHeadAndTotalWorkingHoursForm";
            this.Load += new System.EventHandler(this.OverHeadAndTotalWorkingHoursForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_month_rent;
        private MaterialSkin.Controls.MaterialTextBox txt_total_util;
        private MaterialSkin.Controls.MaterialTextBox txt_total_cost;
        private MaterialSkin.Controls.MaterialTextBox txt_total_working_hours;
        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
    }
}