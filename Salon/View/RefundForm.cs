using MaterialSkin.Controls;
using Salon.Controller;
using Salon.Models;
using Salon.Repository;
using Salon.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Salon.View
{
    public partial class RefundForm : MaterialForm
    {
        private MainForm mainForm;
        private TransactionModel model;

        public RefundForm(MainForm mainForm, TransactionModel model)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.model = model;
            ThemeManager.ApplyTheme(this);

            lbl_appointment_id.Text = $"Appointment ID: {model.appointment_id}";
            lbl_customer_name.Text = $"Customer Name:  {model.ClientName}";
            lbl_services.Text = $"Service(s):  {model.Services}";
            lbl_amount_paid.Text = $"Amount Paid:  {model.amount_paid:N2}";
            lbl_payment_method.Text = $"Payment Method:  {model.payment_method}";
            lbl_transaction_date.Text = $"Transaction Date:  {model.timestamp}";

            lbl_refund_amount.Text = model.amount_paid.ToString("N2");
            LoadRefundableServices();
        }

        private void LoadRefundableServices()
        {
            var repo = new RefundRepository();
            var controller = new RefundController(repo);
            var services = controller.GetSelectedServices(model.appointment_id);
            servicesPanel.Controls.Clear();

            foreach (var service in services)
            {
                var checkbox = new MaterialCheckbox
                {
                    Text = $"{service.Services} - ₱{service.selling_price:N2}",
                    Tag = service, // Store full model for later use
                    AutoSize = true,
                    Margin = new Padding(10)
                };
                checkbox.CheckedChanged += ServiceCheckbox_CheckedChanged;
                servicesPanel.Controls.Add(checkbox);
            }
        }

        private void ServiceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            decimal totalRefund = 0;
            decimal totalServiceValue = model.sub_total;
            decimal totalPaid = model.amount_paid;

            foreach (var cb in servicesPanel.Controls.OfType<MaterialCheckbox>())
            {
                if (cb.Checked && cb.Tag is RefundModel service)
                {
                    totalRefund += (service.selling_price / totalServiceValue) * totalPaid;
                }
            }

            lbl_refund_amount.Text = Math.Round(totalRefund, 2).ToString("N2");
        }

        private bool Refund_Inventory()
        {
            var inventoryController = new InventoryController(new InventoryRepository());
            var serviceProductController = new ServiceProductUsageController(new ServiceProductUsageRepository());
            var appointmentService = new AppointmentServiceController(new AppointmentServiceRepository());

            int appointmentId = model.appointment_id;
            var serviceList = appointmentService.GetServicesByAppointmentId(appointmentId)?.ToList();
            if (serviceList == null || !serviceList.Any()) return true;

            var inventoryProductList = inventoryController.GetAllInventory().ToList();

            // Get selected service names
            var selectedServiceNames = servicesPanel.Controls
                .OfType<MaterialCheckbox>()
                .Where(cb => cb.Checked && cb.Tag is RefundModel)
                .Select(cb => ((RefundModel)cb.Tag).Services)
                .ToList();

            foreach (var service in serviceList)
            {
                if (!selectedServiceNames.Contains(service.ServiceName)) continue;

                var serviceProducts = serviceProductController.GetAllServiceProducts(service.ServiceId)?.ToList();
                if (serviceProducts == null || !serviceProducts.Any()) continue;

                foreach (var product in serviceProducts)
                {
                    var inventoryItem = inventoryProductList
                        .FirstOrDefault(inv => inv.product_id == product.product_id);

                    if (inventoryItem == null) continue;

                    double unitVolume = (double)inventoryItem.volume / inventoryItem.unit;
                    double usedVolume = product.total_usage_amount;

                    double restoredVolume = inventoryItem.volume + usedVolume;
                    double restoredUnitCount = restoredVolume / unitVolume;

                    inventoryController.UpdateInventoryByVolume(product.product_id, restoredUnitCount, -usedVolume);
                }
            }

            mainForm.LoadInventory();
            return true;
        }
        private void AddRefund() 
        {
            var repo = new RefundRepository();
            var controller = new RefundController(repo);

            var refund = new RefundModel
            {
                transaction_id = model.transaction_id,
                appointment_id = model.appointment_id,
                refund_amount = Convert.ToDecimal(lbl_refund_amount.Text),
                refund_method = model.payment_method,
                refunded_by = UserSession.CurrentUser.first_Name,
                refund_reason = txt_reason.Text.Trim(),
                refund_timestamp = DateTime.Now
            };

            controller.AddRefund(refund);
        }
        private void UpdateTransactionByItsStatus() 
        {
            var repo = new TransactionRepository();
            var controller = new TransactionController(repo);

            var transaction = new TransactionModel
            {
                transaction_id = model.transaction_id,
                payment_status = "Refunded"
            };

            controller.UpdateTransactionStatus(transaction);
        }
        private void btn_refund_Click(object sender, EventArgs e)
        {
            AddRefund();
            UpdateTransactionByItsStatus();
            Refund_Inventory();

            MessageBox.Show("Refund Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Audit.AuditLog(
               DateTime.Now,
               "Refund",
               UserSession.CurrentUser.first_Name,
               "Transaction History",
               $"Refunded services on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

            mainForm.LoadAllTransactions();
            mainForm.LoadInventory();
            mainForm.LoadRefund();
           this.Close();
        }
    }
}
