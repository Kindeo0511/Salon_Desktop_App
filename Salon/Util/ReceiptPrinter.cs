using iText.Layout.Renderer;
using Microsoft.Reporting.WinForms;
using Salon.Models;
using Salon.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.Util
{
    public class ReceiptPrinter
    {
        private readonly PrintDocument printDocument;
        private readonly BindingList<ServiceCart> cart;

        private string salonName = "Glamour Salon";
        private string address = "123 Main St, Taguig";
        private string phone = "Tel: (02) 123-4567";
        private string invoiceId = "#INV-2025-001";
        private string cashier = "Cashier: Maria";
        private DateTime date = DateTime.Now;

        private decimal sub_total;
        private decimal total;
        private decimal amount_paid;
        private decimal vat_amount;
        private decimal discount_amount;
        private decimal change_amount;
        private string payment_method;
        
        private int vat_rate;

        public ReceiptPrinter(BindingList<ServiceCart> cart,decimal sub_total, decimal amount_paid, decimal vat_amount, decimal discount_amount, decimal change_amount, string payment_method, int vat_rate)
        {
            this.cart = cart;
            this.sub_total = sub_total;
            this.total = amount_paid;
            this.amount_paid = amount_paid;
            this.vat_amount = vat_amount;
            this.discount_amount = discount_amount;
            this.change_amount = change_amount;
            this.payment_method = payment_method;
            this.vat_rate = vat_rate;
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Set correct paper size for 58mm printer (2.28 inches wide)
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 300, 1000);
            printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
       
        }

        public void Print()
        {
            printDocument.Print();
        }

        public void ShowPreview()
        {
            using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
            {
                previewDialog.Document = printDocument;
                previewDialog.ShowDialog();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font font = new Font("Consolas", 10);
            Font boldFont = new Font("Consolas", 10, FontStyle.Bold);

            float pageWidth = e.MarginBounds.Width;
            float centerX = e.MarginBounds.Left + (pageWidth / 2);

            var renderer = new ReceiptRenderer(g, font, boldFont, centerX);

            // Header
            renderer.DrawHeader("Hair Care Center Salon");

            renderer.DrawCenteredLines(new[]
            {
            $"Invoice #:",
            $"Customer: ",
            $"Date: {date}",
            $"Time: "
        });

            renderer.DrawSeparator();
            renderer.DrawLabelValue("Service", "Qty", "Price");
            renderer.DrawSeparator();

            // Service rows
            foreach (var item in cart)
            {
                renderer.DrawServiceRow(item.ItemName, item.Quantity.ToString(), item.Price.ToString("C2"));
            }

            renderer.DrawSeparator();
            renderer.DrawSeparator();


            // Totals
            renderer.DrawLabelValue("Subtotal:","", sub_total.ToString("C2"));
            renderer.DrawLabelValue("Discount:", "", discount_amount.ToString());
            renderer.DrawLabelValue($"VAT ({vat_rate:N0}%):", "", vat_amount.ToString("C2"));
            renderer.DrawBoldValue("Total:", total.ToString("C2"));
            renderer.DrawBoldValue("Change Amount:", change_amount.ToString("C2"));
            renderer.DrawBoldValue("Payment Method:", payment_method);

            if (payment_method.Equals("GCash", StringComparison.OrdinalIgnoreCase))
            {
                //renderer.DrawBoldValue("Reference No.:", txt_Reference.Text);
            }

            renderer.DrawFooter("Thank you for choosing us!");
        }
    }
}
