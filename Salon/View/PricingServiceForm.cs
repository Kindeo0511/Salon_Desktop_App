using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Salon.View
{
    public partial class PricingServiceForm : MaterialForm
    {
        private MainForm mainForm;
        private ServicePriceModel priceModel;
        private int duration;
        private int total_working_hours;
        private decimal total_daily_wage;
        private decimal total_over_head_cost;
        private decimal vat_rate;
        public PricingServiceForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;

            LoadServices();
        }
        public PricingServiceForm(MainForm mainForm, ServicePriceModel priceModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
            this.priceModel = priceModel;

            LoadServices();

            if (priceModel != null)
            {
                FillData();
            }

        }
        private void FillData() 
        {
            cmb_services.SelectedValue = priceModel.service_product_id;
            txt_product_cost.Text = priceModel.product_cost.ToString("N2");
            txt_stylist_cost.Text = priceModel.stylist_cost.ToString("N2");
            txt_overhead_cost.Text = priceModel.overhead_cost.ToString("N2");
            txt_total_cost.Text = priceModel.total_cost.ToString("N2");
            txt_final_price.Text = priceModel.selling_price.ToString("N2");
            txt_vat.Text = priceModel.vat_amount.ToString("N2");
            txt_net_price.Text = priceModel.net_price.ToString("N2");
            txt_net_profit.Text = priceModel.net_profit.ToString("N2");
            txt_margin_peso.Text = priceModel.gross_profit.ToString("N2"); 
            txt_percent.Text = priceModel.profit_percent.ToString("N2");

            btn_save.Visible = false;
            btn_update.Visible = true;
        }

        private bool Validated()
        {
       
            bool validated = true;
            // REQUIRED FIELD
            validated &= Validator.IsRequired(cmb_services, errorProvider1, "Service is required.");
            validated &= Validator.IsRequired(txt_final_price, errorProvider1, "Selling price is required.");



            // EXISTS VALIDATION
            int excludeId = priceModel?.pricing_id ?? 0;
            int spid = Convert.ToInt32(cmb_services.SelectedValue);
            validated &= Validator.IsProductPriceExists(cmb_services, errorProvider1, "Service price already exists.", spid, excludeId);



            return validated;


        }
        private void LoadServices() 
        {
            var repo = new ServiceProductUsageRepository();
            var controller = new ServiceProductUsageController(repo);
            var products = controller.GetProductCost();

            cmb_services.DisplayMember = "serviceName";
            cmb_services.ValueMember = "service_product_id";
            cmb_services.DataSource = products;
            cmb_services.SelectedIndex = -1;

        }
        private void LoadVat() 
        {
            var repo = new VatRepository();
            var controller = new VatController(repo);
            var vat = controller.LoadLatestTax();

            txt_vat.Hint = $"Vat Amount ({vat.tax}%)";
            vat_rate = vat.tax;
        }

        private void LoadStylistCost() 
        {
            var repo = new StylistRepository();
            var controller = new StylistController(repo);
            var stylistCost = controller.getStylistTotalCost();

            total_daily_wage = stylistCost.stylist_cost;
        }

        private void LoadOverHeadCost() 
        {
            var repo = new OverHeadRepository();
            var controller = new OverHeadController(repo);
            var overHeadCost = controller.GetOverHeadTotal();
            total_over_head_cost = overHeadCost.total_over_head;
            total_working_hours = overHeadCost.total_working_hours;

        }
        private void CalculateVatAmount() 
        {

            if (decimal.TryParse(txt_final_price.Text, out decimal total) &&
                decimal.TryParse(txt_total_cost.Text, out decimal total_cost))
            {

                decimal vat_amount = total * (vat_rate / (100 + vat_rate));
                decimal net_price = total - vat_amount;
                decimal net_profit = net_price - total_cost;
                txt_vat.Text = vat_amount.ToString("N2");
                txt_net_price.Text = net_price.ToString("N2");
                txt_net_profit.Text = net_profit.ToString("N2");

  
            }
            else
            {
                txt_margin_peso.Text = "0.00";
                txt_percent.Text = "0.00 %";
            }



        }
        private void CalculateOverheadForService()
        {
            decimal overhead_rate_per_hour = total_over_head_cost / total_working_hours;
            decimal over_head_cost_for_service = overhead_rate_per_hour * (duration / 60m);
            
            txt_overhead_cost.Text = over_head_cost_for_service.ToString("N2");
        }
        private void CalculateStylistCost()
        {
            decimal stylist_cost = (total_daily_wage / 8) * (duration / 60m);

            txt_stylist_cost.Text = stylist_cost.ToString("N2");
        }
        private void CalculateTotal() 
        {
            decimal product_cost = Convert.ToDecimal(txt_product_cost.Text);
            decimal stylist_cost = Convert.ToDecimal(txt_stylist_cost.Text);
            decimal over_head_cost= Convert.ToDecimal(txt_overhead_cost.Text);
            decimal total = product_cost + stylist_cost + over_head_cost;

            txt_total_cost.Text = total.ToString("N2");
        }
        private void CalculateProfit()
        {
            if (decimal.TryParse(txt_final_price.Text, out decimal selling_price) &&
                decimal.TryParse(txt_total_cost.Text, out decimal total))
            {
                decimal margin_peso = selling_price - total;
                decimal margin_percent = selling_price > 0
                    ? (margin_peso / selling_price) * 100m
                    : 0;

                txt_margin_peso.Text = margin_peso.ToString("N2");
                txt_percent.Text = margin_percent.ToString("N2") + " %";
            }
            else
            {
                txt_margin_peso.Text = "0.00";
                txt_percent.Text = "0.00 %";
            }
        }

        private void cmb_services_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_services.SelectedIndex >= 0)
            {
                var selectedService = cmb_services.SelectedItem as ServiceProductUsageModel;
                if (selectedService != null)
                {
                    txt_product_cost.Text = selectedService.total_cost.ToString("N2");
                    txt_duration.Text = selectedService.duration.ToString();
                    duration = selectedService.duration;
                    LoadStylistCost();
                    LoadOverHeadCost();
                    LoadVat();
                    CalculateStylistCost();
                    CalculateOverheadForService();
                    CalculateTotal();
                    CalculateProfit();
                    CalculateVatAmount();

                }
            }
            else
            {
                txt_stylist_cost.Text = "0.00";
                txt_product_cost.Text = "0.00";
                txt_overhead_cost.Text = "0.00";
                txt_total_cost.Text = "0.00";
                txt_duration.Clear();
                txt_vat.Hint = "Vat Amount";
                txt_vat.Text = "0.00";
                txt_net_price.Text = "0.00";
            }
        }

        private void txt_final_price_TextChanged(object sender, EventArgs e)
        {
            CalculateProfit();
            CalculateVatAmount();
        }

        private void txt_margin_peso_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_percent_TextChanged(object sender, EventArgs e)
        {
            
        }
        decimal CleanDecimal(string input)
        {
            return decimal.TryParse(
                input.Replace("₱", "").Replace("%", "").Trim(),
                out decimal value
            ) ? value : 0m;
        }
        private void AddServicePrice() 
        {
            var repo = new ServicePriceRepository();
            var controller = new ServicePriceController(repo);

            var model = new ServicePriceModel 
            {
                service_product_id = (int)cmb_services.SelectedValue,
                product_cost = CleanDecimal(txt_product_cost.Text),
                stylist_cost = CleanDecimal(txt_stylist_cost.Text),
                overhead_cost = CleanDecimal(txt_overhead_cost.Text),
                total_cost = CleanDecimal(txt_total_cost.Text),
                selling_price = CleanDecimal(txt_final_price.Text),
                vat_amount = CleanDecimal(txt_vat.Text),
                net_price = CleanDecimal(txt_net_price.Text),
                net_profit = CleanDecimal(txt_net_profit.Text),
                gross_profit = CleanDecimal(txt_margin_peso.Text),
                profit_percent = CleanDecimal(txt_percent.Text),
            };

            controller.AddServicePrice(model);
            MessageBox.Show("Added Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm.LoadServicePrices();

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;

            AddServicePrice();
            Audit.AuditLog(
            DateTime.Now,
            "Create",
            UserSession.CurrentUser.first_Name,
            "Service Price",
            $"Created service '{cmb_services.Text}' with a price of ₱{txt_final_price.Text} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
        );
            this.Close();
        }

        private void UpdateServicePrice() 
        {
            var repo = new ServicePriceRepository();
            var controller = new ServicePriceController(repo);

            priceModel.service_product_id = (int)cmb_services.SelectedValue;
            priceModel.product_cost = CleanDecimal(txt_product_cost.Text);
            priceModel.stylist_cost = CleanDecimal(txt_stylist_cost.Text);
            priceModel.overhead_cost = CleanDecimal(txt_overhead_cost.Text);
            priceModel.total_cost = CleanDecimal(txt_total_cost.Text);
            priceModel.selling_price = CleanDecimal(txt_final_price.Text);
            priceModel.vat_amount = CleanDecimal(txt_vat.Text);
            priceModel.net_price = CleanDecimal(txt_net_price.Text);
            priceModel.net_profit = CleanDecimal(txt_net_profit.Text);
            priceModel.gross_profit = CleanDecimal(txt_margin_peso.Text);
            priceModel.profit_percent = CleanDecimal(txt_percent.Text);


            controller.UpdateServicePrice(priceModel);
            MessageBox.Show("Updated Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm.LoadServicePrices();

        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;

            UpdateServicePrice();
            AddServicePrice();
            Audit.AuditLog(
            DateTime.Now,
            "Update",
            UserSession.CurrentUser.first_Name,
            "Service Price",
            $"Updated service '{cmb_services.Text}' with a price of ₱{txt_final_price.Text} on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}"
        );
            this.Close();
        }

        private void txt_overhead_cost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
