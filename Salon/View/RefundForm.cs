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
    public partial class RefundForm : MaterialForm
    {
            
        private readonly MainForm mainForm;

        private InvoiceModel invoiceModel;
        public RefundForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        public RefundForm(MainForm mainForm, InvoiceModel invoiceModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
            this.invoiceModel = invoiceModel;

            lbl_invoice_number.Text = this.invoiceModel.InvoiceNumber;
            lbl_staff.Text = $"{UserSession.CurrentUser.first_Name}, {UserSession.CurrentUser.last_Name}";
            lbl_date.Text = this.invoiceModel.Timestamp.ToString();
            int invoice_id = GetInvoiceNumber(invoiceModel.InvoiceNumber);

            LoadCart(invoice_id);
        }
        public void LoadCart(int invoice_id)
        {
            var repo = new InvoiceServiceRepository();
            var controller = new InvoiceServiceCartController(repo);
            var services = controller.GetInvoiceForVoidAndRefundById(invoice_id);

          

            dgv_products.DataSource = null;
            dgv_products.AutoGenerateColumns = false;

            col_invoice_id.DataPropertyName = "InvoiceId";
            col_product_id.DataPropertyName = "ProductId";
            col_item_name.DataPropertyName = "ItemName";
            col_price.DataPropertyName = "Price";
            col_qty.DataPropertyName = "Quantity";
            col_refund_qty.DataPropertyName = "RefundQty";
            col_total.DataPropertyName = "TotalPrice";
            col_status.DataPropertyName = "Status";

            dgv_products.DataSource = services;
        }

        public int GetInvoiceNumber(string id)
        {
            var repo = new InvoiceRepository();
            var controller = new InvoiceController(repo);
            int invoice_id = controller.GetInvoiceNumber(id);

            return invoice_id;

        }

        private void dgv_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_products.Columns[e.ColumnIndex].Name == "col_btn_refund")
            {
                var details = dgv_products.Rows[e.RowIndex].DataBoundItem as InvoiceServicesCart;

                using (var form = new RefundModalForm(mainForm,this, details))
                {
                    form.ShowDialog();
                }
            }
        }
    }
}
