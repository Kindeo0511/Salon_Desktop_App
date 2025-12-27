using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Card
{
    public partial class ServiceCard : UserControl
    {
        public event EventHandler OnRemove;
        public int SelectedServiceID => (int)cmb_services.SelectedValue;
        public string ItemName => cmb_services.Text;
        private decimal _price;
        public decimal Price => _price;
        public int _duration;
        public int Duration => _duration;
        public int Quantity => 1;
    
        public ServiceCard()
        {
            InitializeComponent();
            btn_remove.Click += (s, e) => OnRemove?.Invoke(this, EventArgs.Empty);
        }

        public void SetServices(List<ServiceModel> services)
        {

            cmb_services.DataSource = services;
            cmb_services.DisplayMember = "serviceName";
            cmb_services.ValueMember = "serviceName_id";
            cmb_services.SelectedIndex = -1;
            cmb_services.SelectedIndexChanged += cmb_services_SelectedIndexChanged;

            lbl_duration.Text = "0 mins";
            lbl_price.Text = "0.00";
        }
        // ServiceCard
        public void LoadSelectedProduct(ServiceCart saved)
        {
            cmb_services.SelectedValue = saved.ServiceId;
            _price = saved.Price;
            lbl_price.Text = _price.ToString("C");
            lbl_duration.Text = $"{saved.Duration} mins";
        }


        private void cmb_services_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedService = cmb_services.SelectedItem as ServiceModel;
            if (selectedService == null) return;

           
                _price = selectedService.servicePrice;
                _duration = selectedService.duration;
                lbl_duration.Text = $"{selectedService.duration} mins";
                lbl_price.Text = selectedService.servicePrice.ToString("C");
            
               
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }
    }
}
