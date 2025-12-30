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
        private bool _isSaving = false;
        private bool _isUpdating = false;
        public  SupplierForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
            _isSaving = true;
        }
        public SupplierForm(MainForm mainform, SupplierModel model)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isUpdating = true;
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

        private bool AddSupplier() 
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
            return controller.AddSupplier(model);
           
            

        }
        private bool UpdateSupplier()
        {
            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
            supplierModel.supplier_name = txt_supplier_name.Text;
            supplierModel.address = txt_address.Text;
            supplierModel.email = txt_email.Text;
            supplierModel.contact = txt_contact.Text;
            return controller.UpdateSupplier(supplierModel);
         
        }

        private void IsAccountExists()
        {
            var repo = new SupplierRepository();
            var controller = new SupplierController(repo);
            var existingUser = controller.GetEmail(txt_email.Text.Trim());

            if (existingUser != null)
            {

                if (existingUser.is_deleted == 1)
                {
                    var result = MessageBox.Show("This Supplier exists but is deleted. Do you want to restore it?",
                                   "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {



                        if (controller.RestoreSupplier(existingUser.supplier_id))
                        {
                            mainform.DeleteDeletedRecord(existingUser.supplier_id);
                            MessageBox.Show("Supplier restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }



                    }
                }
            }

            else
            {
                if (_isSaving)
                {


                    if (AddSupplier())
                    {
                        MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_supplier_name.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Supplier", $"Created supplier '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdating)
                {
                    if (UpdateSupplier())
                    {
                        MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_supplier_name.Text;
                        Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Supplier", $"Updated supplier '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

        }
        private async  void btn_save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            IsAccountExists();
            await mainform.RefreshSupplierAsync();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            IsAccountExists();

            await mainform.RefreshSupplierAsync();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_supplier_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            if (char.IsWhiteSpace(c) && txt != null && txt.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow letters, space, hyphen, apostrophe
            if (char.IsLetter(c) || char.IsWhiteSpace(c) || c == '-' || c == '\'')
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string allowed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 .,-";

            if (!char.IsControl(c) && !allowed.Contains(c))
                e.Handled = true;
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string allowed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-";

            if (!char.IsControl(c) && !allowed.Contains(c))
                e.Handled = true;
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (char.IsControl(c))
                return;

            if (!char.IsDigit(c))
            {
                e.Handled = true;
                return;
            }

        }
    }
}
