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
        private MainForm mainForm;
        private CategoryModel category;
        public CategoryForm(MainForm mainForm)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainForm = mainForm;
        }

        public CategoryForm(MainForm mainForm, CategoryModel category)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
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
            if (!Validator.IsCategoryExists(txt_category_name, errorProvider1, "Category already exists.",cmb_category_type.Text, excludeId))
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

        private void addCategory()
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);
            var newCategory = new CategoryModel
            {
                categoryName = txt_category_name.Text,
                type = cmb_category_type.Text
            };
            controller.addCategory(newCategory);
        
        }
        private void updateCategory()
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);

            category.categoryName = txt_category_name.Text;
            category.type = cmb_category_type.Text;
            controller.updateCategory(category);
      
        }
        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (!await IsValid()) return;


            addCategory();
            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var category = txt_category_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Categories", $"Created category '{category}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            await mainForm.RefreshCategoryAsync();
            this.Close();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!await IsValid()) return;

            updateCategory();
            MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var category = txt_category_name.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Categories", $"Updated category '{category}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            await mainForm.RefreshCategoryAsync();
            this.Close();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
