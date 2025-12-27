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
using MaterialSkin.Controls;
using Salon.Models;
using Salon.Repository;
using Salon.Controller;
namespace Salon.View
{
    public partial class VoidModalForm : MaterialForm
    {
        private readonly InvoiceServicesCart cart;
        private readonly VoirdForm void_form;
        public VoidModalForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        public VoidModalForm(VoirdForm void_form, InvoiceServicesCart cart)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.void_form = void_form;
            this.cart = cart;

            LoadDetails(this.cart);
        }
        private void LoadDetails(InvoiceServicesCart cart) 
        {
            lbl_product.Text = cart.ItemName;
            lbl_qty.Text = cart.Quantity.ToString(); 
        }
        private void VoidProduct() 
        {
            var repo = new InvoiceServiceRepository();
            var controller = new InvoiceServiceCartController(repo);

            var stock_repo = new StockOutRepository();
            var stock_controller = new StockOutController(stock_repo);

            var inventory_repo = new InventoryRepository();
            var inventory_controller = new InventoryController(inventory_repo);

            var serviceProductController = new ServiceProductUsageController(new ServiceProductUsageRepository());



         
            int qty = Convert.ToInt32(lbl_qty.Text);

            var transactionId = stock_controller.GetTransactionId(cart.ProductId);
            var invoice_service_cart = controller.GetServiceFromInvoiceCart(cart.InvoiceId);

            controller.VoidProductByInvoiceId(invoice_service_cart.service_cart_id, "Voided");
            if (transactionId.transaction_id > 0)
            {
               
                stock_controller.VoidProductTransaction(transactionId.transaction_id, transactionId.product_size_id, qty);



                inventory_controller.VoidProductInventory(cart.ProductId, transactionId.product_size_id, qty);
            }
       
                MessageBox.Show("Void successfully!",
                                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            VoidProduct();
            void_form.LoadCart(cart.InvoiceId);
            this.Close();
            
        }
    }
}
