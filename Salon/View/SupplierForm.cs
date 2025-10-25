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
using Salon.Repository;
using Salon.Controller;
using Salon.Models;
namespace Salon.View
{
    public partial class SupplierForm : MaterialForm
    {
        private MainForm mainform;
        private SupplierModel supplierModel;
        public  SupplierForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
        }
        public SupplierForm(MainForm mainform, SupplierModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
            this.supplierModel = model;

            if (supplierModel != null)
            {
                txt_supplier_name.Text = supplierModel.supplier_name;
                txt_address.Text = supplierModel.address;
                txt_email.Text = supplierModel.email;
                txt_contact.Text = supplierModel.contact;
                btn_save.Visible = false;
                btn_update.Visible = true;
            }
          
        }

        private bool IsValid()
        {
           
            int excludeId = supplierModel?.supplier_id ?? 0;

            bool validated = true;

            // REQUIRED AND MIN LENGTH FIELD
            string supplierName = txt_supplier_name.Text.Trim();
            string contact = txt_contact.Text.Trim();
            string email = txt_email.Text.Trim();
            string address = txt_address.Text.Trim();

            validated &= Validator.ValidateSupplierName(supplierName, txt_supplier_name, errorProvider1);
            validated &= Validator.ValidateContactNumber(contact, txt_contact, errorProvider1);
            validated &= Validator.ValidateEmail(email, txt_email, errorProvider1);
            validated &= Validator.ValidateAddress(address, txt_address, errorProvider1);

            if (!Validator.IsSupplierEExists(txt_supplier_name, errorProvider1, "Supplier name already exists.", excludeId))
            {
                validated = false;
            }




            return validated;



        }

        private void AddSupplier() 
        {
            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
            var model = new SupplierModel()
            {
                supplier_name = txt_supplier_name.Text,
                address = txt_address.Text,
                email = txt_email.Text,
                contact = txt_contact.Text
            };
            controller.AddSupplier(model);
           
            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var fullName = txt_supplier_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Supplier", $"Created supplier '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            this.Close();

        }
        private void UpdateSupplier()
        {
            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
            supplierModel.supplier_name = txt_supplier_name.Text;
            supplierModel.address = txt_address.Text;
            supplierModel.email = txt_email.Text;
            supplierModel.contact = txt_contact.Text;
            controller.UpdateSupplier(supplierModel);
            MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var fullName = txt_supplier_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Supplier", $"Updated supplier '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            this.Close();
        }


        private async  void btn_save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            AddSupplier();
            await mainform.RefreshSupplierAsync();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            UpdateSupplier();

            await mainform.RefreshSupplierAsync();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
