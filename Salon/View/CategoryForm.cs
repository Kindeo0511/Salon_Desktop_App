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
        private bool IsValid()
        {

            bool validated = true;
            int excludeId = category?.category_id ?? 0;
          
  

            // REQUIRED AND MIN LENGTH FIELD
            if (!Validator.IsRequiredTextField(txt_category_name, errorProvider1, "Category is required."))
            {
                validated = false;
            }
            else if (!Validator.IsMinimumLength(txt_category_name, errorProvider1, "Category must be at least 3 characters.", 3))
            {
                validated = false;
            }
            else if (!Validator.Pattern(txt_category_name, errorProvider1, @"^[A-Za-z0-9 _-]{3,50}$", "Category can only contain letters, numbers, spaces, underscores, and hyphens."))
            {
                validated = false;
            }

            else if (!Validator.IsCategoryExists(txt_category_name, errorProvider1, "Category already exits.", cmb_category_type.Text, excludeId))
            {
                validated = false;
            }

            if (!Validator.IsComboBoxSelected(cmb_category_type,errorProvider1, "Category Type is Required")) 
            {
                validated = false;
            }

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
            if (!IsValid()) return;

            addCategory();
            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var category = txt_category_name.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Categories", $"Created category '{category}' on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
            await mainForm.RefreshCategoryAsync();
            this.Close();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
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
