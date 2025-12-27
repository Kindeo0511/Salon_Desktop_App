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
    public partial class SummaryServiceCard : UserControl
    {
        public SummaryServiceCard()
        {
            InitializeComponent();
        }

        public void SetServiceDetails(string itemName)
        {
            lbl_service_name.Text = itemName;
      
        }
    }
}
