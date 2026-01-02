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
    public partial class AddProductForm : MaterialForm
    {
        private PaymentForm paymentForm;
        public AddProductForm(PaymentForm paymentForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.paymentForm = paymentForm;
        }

        private void LoadProducts() 
        {
            var repo = new ProductRepository();
            var productController = new ProductController(repo);
            var products = productController.GetAllRetailProducts();

            dgv_product_list.DataSource = null;
            dgv_product_list.AutoGenerateColumns = false;


            col_product_id.DataPropertyName = "product_id";
            col_product_name.DataPropertyName = "product_name";
            col_brand.DataPropertyName = "brand";
            col_product_size.DataPropertyName = "product_size_id";
            col_size.DataPropertyName = "size_label";
            col_price.DataPropertyName = "selling_price";
            dgv_product_list.DataSource = products;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        public void SaveProduct(int product_id, int product_size, int qty, decimal price) 
        {
          

            var invoiceServiceCart = new ServiceCart
            {
                InvoiceId = paymentForm.invoice_id,
                ProductId = product_id,
                ProductSizeId = product_size,
                ItemType = "Product",
                Quantity = qty,
                Price = price,
            };
            SaveInvoiceServices(invoiceServiceCart);
        }
        private void SaveInvoiceServices(ServiceCart cart)
        {
            var repo = new InvoiceServiceRepository();
            var serviceController = new InvoiceServiceCartController(repo);
            serviceController.AddServiceToInvoiceCart(cart);

        }

        private void dgv_product_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 && dgv_product_list.Columns[e.ColumnIndex].Name == "btn_add") 
            {
                var model = dgv_product_list.Rows[e.RowIndex].DataBoundItem as RetailProduct;

                using (var form = new ProductModalForm(this,model)) 
                {
                    form.ShowDialog();
                }
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            paymentForm.LoadServices(paymentForm.invoice_id);
            paymentForm.CalculateSubTotal();
            this.Close();
        }
    }
}
