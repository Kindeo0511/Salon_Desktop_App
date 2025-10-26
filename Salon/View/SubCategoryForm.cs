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
using System.Runtime.InteropServices;
using Salon.Models;

namespace Salon.View
{
    public partial class SubCategoryForm : MaterialForm
    {
        private MainForm mainform;
        private SubCategoryModel subCategoryModel;
        public SubCategoryForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
            LoadCategory();
   
        }

        public SubCategoryForm(MainForm mainform, SubCategoryModel subCategoryModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
            this.subCategoryModel = subCategoryModel;
            LoadCategory();

            if (subCategoryModel != null) 
            {
                txt_subcategory_name.Text = subCategoryModel.subCategoryName;
                cmb_category.SelectedValue = subCategoryModel.category_id;
                btn_save.Visible = false;
                btn_update.Visible = true;
            }

        }
        private bool Validated()
        {

            bool validated = true;
            int excludeId = subCategoryModel?.subCategory_id ?? 0;
            int cat_id = Convert.ToInt32(cmb_category.SelectedValue);


            string subCategoryName = txt_subcategory_name.Text.Trim();
            validated &= Validator.ValidateSubCategoryName(subCategoryName, txt_subcategory_name, errorProvider1);
            validated &= Validator.ValidateSubCategoryType(cmb_category, errorProvider1);

            if (!Validator.IsSubCategoryExists(txt_subcategory_name, errorProvider1, "Sub-Category already exists.",cat_id, excludeId))
            {
                validated = false;
            }



            // EXISTS VALIDATION
            


            return validated;


        }
        private void LoadCategory() 
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);
            var categories = controller.getAllCategoryByService();

            cmb_category.ValueMember = "category_id";
            cmb_category.DisplayMember = "categoryName";
        
            cmb_category.DataSource = categories;
            cmb_category.SelectedIndex = -1;

        }

        private void AddSubCategory() 
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);
            var subCategory = new SubCategoryModel
            {
                category_id = (int)cmb_category.SelectedValue,
                subCategoryName = txt_subcategory_name.Text.Trim()
            };
            controller.addSubCategory(subCategory);
            MessageBox.Show("Sub-Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        private void UpdateSubCategory() 
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);

            subCategoryModel.category_id = (int)cmb_category.SelectedValue;
            subCategoryModel.subCategoryName = txt_subcategory_name.Text.Trim();

            controller.updateSubCategory(subCategoryModel);
            MessageBox.Show("Sub-Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private async  void btn_save_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            AddSubCategory();
            var subCategory = txt_subcategory_name.Text;
            var category = cmb_category.Text;
            Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Sub-Categories", $"Created sub-category '{subCategory}' for ({subCategory}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

            await mainform.RefreshSubCategoryAsync();
            this.Close();
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;
            UpdateSubCategory();

            var subCategory = txt_subcategory_name.Text;
            var category = cmb_category.Text;
            Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Sub-Categories", $"Updated sub-category '{subCategory}' for ({subCategory}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");

            await mainform.RefreshSubCategoryAsync();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_subcategory_name_KeyPress(object sender, KeyPressEventArgs e)
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
