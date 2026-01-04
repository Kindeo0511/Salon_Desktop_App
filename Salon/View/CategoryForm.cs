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
using System.Windows.Input;
namespace Salon.View
{
    public partial class CategoryForm : MaterialForm
    {
        public event EventHandler CategoryAdded;
        public event EventHandler CategoryUpdated;
        private MainForm mainForm;
        private CategoryModel category;
        private bool _isSaving = false;
        private bool _isUpdating = false;

        public CategoryForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isSaving = true;
            this.mainForm = mainForm;
        }

        public CategoryForm(MainForm mainForm, CategoryModel category)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isUpdating = true;
            this.mainForm = mainForm;
            this.category = category;

            if (category != null)
            {

                txt_category_name.Text = category.categoryName;
                cmb_category_type.Text = category.type;

                btn_save.Visible = false;
                btn_update.Visible = true;
            }

        }

        private async Task<CategoryModel> GetExistingCategory(string category, string type, int id = 0)
        {
            var controller = new CategoryController(new CategoryRepository());
            return await controller.CheckCategoryExistsAsync(category, type, id);
        }
        private async Task<bool> IsValid()
        {
            bool validated = true;
            int excludeId = category?.category_id ?? 0;

            string categoryName = txt_category_name.Text.Trim();

            validated &= Validator.ValidateCategoryName(categoryName, txt_category_name, errorProvider1);
            validated &= Validator.ValidateCategoryType(cmb_category_type, errorProvider1);
            if (!Validator.IsCategoryExists(txt_category_name, errorProvider1, "Category already exists.", cmb_category_type.Text, excludeId))
            {
                validated = false;
            }
            //var existing = await GetExistingCategory(categoryName, cmb_category_type.Text, excludeId);

            //if (existing != null)
            //{
            //    if (existing.is_deleted)
            //    {
            //        var confirm = MessageBox.Show(
            //            $"\"{existing.categoryName}\" exists but is inactive.\nRestore this category?",
            //            "Restore Category",
            //            MessageBoxButtons.YesNo,
            //            MessageBoxIcon.Question
            //        );

            //        if (confirm == DialogResult.Yes)
            //        {
            //            existing.is_deleted = false;
            //            mainForm.RestoreDeletedCategoryRecord(existing.category_id);
            //            mainForm.DeleteDeletedRecord(existing.category_id);
            //            MessageBox.Show("✅ Category restored.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            await mainForm.RefreshCategoryAsync();

            //        }

            //        return false;
            //    }

            //    MessageBox.Show($"❌ Category already exists (ID: {existing.category_id}).", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            return validated;
        }

        private bool addCategory()
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);
            var newCategory = new CategoryModel
            {
                categoryName = txt_category_name.Text,
                type = cmb_category_type.Text
            };
           return controller.addCategory(newCategory);

        }
        private bool updateCategory()
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);

            category.categoryName = txt_category_name.Text;
            category.type = cmb_category_type.Text;
           return controller.updateCategory(category);

        }
        private void IsAccountExists()
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);
            var existingCategory = controller.GetCategoryAndType(txt_category_name.Text.Trim(), cmb_category_type.Text.Trim());

            if (existingCategory != null)
            {

                if (existingCategory.is_deleted == 1)
                {
                    var result = MessageBox.Show("This Category exists but is deleted. Do you want to restore it?",
                                   "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {



                        if (controller.restoreCategory(existingCategory.category_id))
                        {
                            mainForm.DeleteDeletedRecord(existingCategory.category_id);
                            MessageBox.Show("Category restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }



                    }
                }
            }

            else
            {
                if (_isSaving)
                {


                    if (addCategory())
                    {
                        CategoryAdded?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_category_name.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Categories", $"Created category '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdating)
                {
                    if (updateCategory())
                    {
                        CategoryUpdated?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var fullName = txt_category_name.Text;
                        Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Categories", $"Updated category '{fullName}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

        }
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (!await IsValid()) return;


            IsAccountExists();


            //await mainForm.RefreshCategoryAsync(1, 25);

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!await IsValid()) return;

            IsAccountExists();
            //await mainForm.RefreshCategoryAsync();


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_category_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox txt = sender as MaterialTextBox;
            char c = e.KeyChar;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(c))
                return;

            // Block space if it's the first character
            if (char.IsWhiteSpace(c) && txt != null && txt.SelectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            // Allow letters, space, ampersand, hyphen, open and close parentheses
            if (char.IsLetter(c) || char.IsWhiteSpace(c) || c == '&' || c == '-' || c == '(' || c == ')')
                return;

            // Block everything else
            e.Handled = true;
        }
    }
}
