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
            mainform.LoadSuppliers();
            MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            mainform.LoadSuppliers();
            MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            AddSupplier();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateSupplier();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
