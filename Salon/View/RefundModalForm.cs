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

            this.AcceptButton = btn_confirm;
        }

        private void loadProduct()
        {
            lbl_product.Text = cart.ItemName;
            lbl_price.Text = $"₱ {cart.Price:N2}";
            price = cart.Price;

            lbl_item_discount.Text = $"₱ {cart.ItemDiscount:N2}";
            lbl_qty_sold.Text = cart.Quantity.ToString();
            qty = cart.Quantity;
            lbl_payment_method.Text = cart.PaymentMethod;
            lbl_refund_number.Text = cart.ReferenceNumber;
            txt_qty.Text = "1"; // default refund quantity
            int refundQty = Convert.ToInt32(txt_qty.Text);


            // Initial calculation with default refund qty
            UpdateRefundAmount(refundQty);
        }


        private void UpdateRefundAmount(int refundQty)
        {
            decimal invoiceTotalBeforeDiscount = cart.InvoiceTotalBeforeDiscount;
            decimal overallDiscountShare = 0;

            if (invoiceTotalBeforeDiscount > 0)
            {
                overallDiscountShare = (price / invoiceTotalBeforeDiscount) * cart.OverAllDiscount;
            }

            // Per-unit refund
            decimal netRefundPerUnit = price - cart.ItemDiscount - overallDiscountShare;

            // Scale by refund quantity
            decimal netRefund = netRefundPerUnit * refundQty;

            // VAT portion based on header VAT
            decimal refundVAT = 0;
            if (cart.InvoiceTotal > 0)
            {
                refundVAT = (netRefund / cart.InvoiceTotal) * cart.VatAmount;
            }


            // Update labels
            lbl_vat_amount.Text= $"₱ {refundVAT:N2}";
            lbl_item_discount.Text = $"₱ {overallDiscountShare:N2} (per unit)";
            lbl_refund_amount.Text = $"₱ {netRefund:N2}";
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

         


            int requested_qty = Convert.ToInt32(txt_qty.Text);
            //var stock_in_id = stock_controller.GetTransactionId(cart.ProductId);
            var invoice_service_cart = controller.GetServiceFromInvoiceCart(cart.InvoiceId, cart.ProductId);
            int already_refunded = refund_controller.CheckRefundQty(invoice_service_cart.service_cart_id);

            int total_refunded = already_refunded + requested_qty;

            if (requested_qty > qty)
            {
                MessageBox.Show("Refund Qty cannot exceed the sold quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Case 2: Adding this refund would exceed sold quantity when combined with past refunds
            if (total_refunded > qty)
            {
                MessageBox.Show("Total refunded quantity cannot exceed the sold quantity.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            controller.RefundProduct(invoice_service_cart.service_cart_id);

                var model = new InvoiceRefundModel
                {
                    service_cart_id = invoice_service_cart.service_cart_id,
                    refund_qty = requested_qty,
                    refund_amount = Convert.ToDecimal(lbl_refund_amount.Text.Replace("₱ ", "")),
                    refund_vat = Convert.ToDecimal(lbl_refund_amount.Text.Replace("₱ ", "")) * 0.12m, // Assuming 12% VAT
                    status = "Refunded",
                    reason = cmb_reason.Text,
                    refunded_by = $"{UserSession.CurrentUser.first_Name}, {UserSession.CurrentUser.last_Name}",
                    refunded_at = DateTime.Now
                };
               int refund_id =  refund_controller.AddRefund(model);

                if (cmb_reason.Text != "Damaged"
                    && cmb_reason.Text != "Expired"
                    && cmb_reason.Text != "Opened")
                {
                //stock_controller.RefundProduct(stock_in_id.stock_in_id, stock_in_id.product_size_id, requested_qty);
                //inventory_controller.VoidProductInventory(cart.ProductId, stock_in_id.product_size_id, requested_qty);

                stock_controller.RefundProductRetailStock(cart.ProductId, cart.ProductSizeId, requested_qty, cart.InvoiceId,refund_id,cart.Price, cmb_reason.Text);
                }

                refund_controller.UpdateRefundStatus();



                MessageBox.Show("Refund successfully!",
                                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
          
           
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            RefundProduct();
            refund_form.LoadCart(cart.InvoiceId);
            main.FilterTransactionReport(1, 25);
            main.LoadInventory(1,25);
            main.FilterRefund(1, 25);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_qty_ValueChanged(object sender, EventArgs e)
        {
            int refundQty = Convert.ToInt32(txt_qty.Text);
            UpdateRefundAmount(refundQty);


        }

        private void txt_qty_Validated(object sender, EventArgs e)
        {
            int refundQty = Convert.ToInt32(txt_qty.Text);
            UpdateRefundAmount(refundQty);

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_qty.Text, out int refundQty))
            {
                // Prevent exceeding sold quantity
                if (refundQty > cart.Quantity)
                {
                    txt_qty.Text = cart.Quantity.ToString();
                    txt_qty.SelectionStart = txt_qty.Text.Length; // move cursor to end
                    refundQty = cart.Quantity;
                }

                UpdateRefundAmount(refundQty);
            }
            else
            {
                // If empty or invalid, reset to 0 or 1 depending on your logic
                lbl_refund_amount.Text = "₱ 0.00";
            }



        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (Backspace, Delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // block non-numeric input
            }

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
