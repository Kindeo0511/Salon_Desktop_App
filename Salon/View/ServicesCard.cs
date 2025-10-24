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

namespace Salon.View
{
    public partial class ServicesCard : UserControl
    {
        public int id { get; set; }
        public string service_name { get; set; }
        public string category_name { get; set; }
        public int duration { get; set; }
        public decimal price { get; set; }

        public event EventHandler<ServicePriceModel> AddToCartClicked;
        public ServicePriceModel BoundService { get; private set; }


        public event EventHandler SelectionChanged;
        public ServicesCard()
        {
            InitializeComponent();


        }
        public void details(ServicePriceModel serviceModel)
        {
            BoundService = serviceModel;

            BoundService.serviceName_id = Convert.ToInt32(serviceModel.serviceName_id.ToString());
            BoundService.duration = Convert.ToInt32(serviceModel.duration.ToString());
            lbl_ServiceName.Text = serviceModel.serviceName;
            category.Text = serviceModel.subCategoryName;

        }




        private void btn_add_to_cart_Click_1(object sender, EventArgs e)
        {
            AddToCartClicked?.Invoke(this, BoundService);
        }

        private void ServicesCard_Load(object sender, EventArgs e)
        {

        }
    }
}
