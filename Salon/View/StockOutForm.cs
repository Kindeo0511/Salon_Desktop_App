using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Repository;
using Salon.Util;
namespace Salon.View
{
    public partial class StockOutForm : MaterialForm
    {
        public StockOutForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

          
        }

        public void LoadTransactionDetails() 
        {
            var repo = new StockOutRepository();
            var controller = new StockOutController(repo);
            var transaction_details = controller.GetAllTransactionDetails();

            dgv_transaction_details.DataSource = null;
            dgv_transaction_details.AutoGenerateColumns = false;

            col_product_name.DataPropertyName = "product_name";
            col_size_label.DataPropertyName = "size_label";
            col_qty_delivered.DataPropertyName = "qty_delivered";
            col_qty_accepted.DataPropertyName = "qty_accepted";
            col_qty_rejected.DataPropertyName = "qty_rejected";
            col_qty_remaining.DataPropertyName = "qty_remaining";
            col_total_remaining.DataPropertyName = "total_remaining";
            col_unit_price.DataPropertyName = "unit_price";
            col_total_price.DataPropertyName = "total";
            col_expiry_date.DataPropertyName = "expiry_date";

            dgv_transaction_details.DataSource = transaction_details;
        }

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            LoadTransactionDetails();
        }
    }
}
