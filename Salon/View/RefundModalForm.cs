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
    public partial class RefundModalForm : MaterialForm
    {
        private readonly InvoiceServicesCart cart;
        private readonly RefundForm refund_form;
        private readonly MainForm main;
        private int qty;
        private decimal price;
        public RefundModalForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        public RefundModalForm(MainForm main,RefundForm refund_form, InvoiceServicesCart cart)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.refund_form = refund_form;
            this.cart = cart;
            this.main = main;
            loadProduct();
        }

        private void loadProduct() 
        {
            lbl_product.Text = cart.ItemName;
            qty = cart.Quantity;
            price = cart.Price;
        }
        private void RefundProduct()
        {
            var repo = new InvoiceServiceRepository();
            var controller = new InvoiceServiceCartController(repo);

            var stock_repo = new StockOutRepository();
            var stock_controller = new StockOutController(stock_repo);

            var inventory_repo = new InventoryRepository();
            var inventory_controller = new InventoryController(inventory_repo);

            var refund_repo = new InvoiceRefundRepository();
            var refund_controller = new RefundController(refund_repo);


            var serviceProductController = new ServiceProductUsageController(new ServiceProductUsageRepository());

         


            int requested_qty = Convert.ToInt32(txt_qty.Value);
            var transactionId = stock_controller.GetTransactionId(cart.ProductId);
            var invoice_service_cart = controller.GetServiceFromInvoiceCart(cart.InvoiceId);
            int already_refunded = refund_controller.CheckRefundQty(invoice_service_cart.service_cart_id);

            int total_refunded = already_refunded + requested_qty;

            if (requested_qty > qty)
            {
                MessageBox.Show("Refund Qty cannot exceed the sold quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (total_refunded > qty)
            { 
                MessageBox.Show("Refund Qty cannot exceed the sold quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         
                controller.RefundProduct(invoice_service_cart.service_cart_id);

                var model = new InvoiceRefundModel
                {
                    service_cart_id = invoice_service_cart.service_cart_id,
                    refund_qty = qty,
                    reason = cmb_reason.Text,
                    refunded_by = $"{UserSession.CurrentUser.first_Name}, {UserSession.CurrentUser.last_Name}",
                    refunded_at = DateTime.Now
                };
                refund_controller.AddRefund(model);

                if (cmb_reason.Text != "Damaged"
                    && cmb_reason.Text != "Expired"
                    && cmb_reason.Text != "Opened")
                {
                    stock_controller.VoidProductTransaction(transactionId.transaction_id, transactionId.product_size_id, qty);
                    inventory_controller.VoidProductInventory(cart.ProductId, transactionId.product_size_id, qty);
                }

                refund_controller.UpdateRefundStatus();



                MessageBox.Show("Refund successfully!",
                                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
          
           
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            RefundProduct();
            refund_form.LoadCart(cart.InvoiceId);
            main.LoadInvoiceTransaction();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
