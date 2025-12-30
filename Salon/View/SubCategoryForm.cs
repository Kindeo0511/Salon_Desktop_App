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
        private bool _isSaving = false;
        private bool _isUpdating = false;
        public SubCategoryForm(MainForm mainform)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.mainform = mainform;
            _isSaving = true;
            LoadCategory();
   
        }

        public SubCategoryForm(MainForm mainform, SubCategoryModel subCategoryModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _isUpdating = true;
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

        private bool AddSubCategory() 
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);
            var subCategory = new SubCategoryModel
            {
                category_id = (int)cmb_category.SelectedValue,
                subCategoryName = txt_subcategory_name.Text.Trim()
            };
            return controller.addSubCategory(subCategory);
           
            
        }
        private bool UpdateSubCategory() 
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);

            subCategoryModel.category_id = (int)cmb_category.SelectedValue;
            subCategoryModel.subCategoryName = txt_subcategory_name.Text.Trim();

            return controller.updateSubCategory(subCategoryModel);

            
        }
        private void IsAccountExists()
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);
            var existingSubCategory = controller.GetSubCategory(txt_subcategory_name.Text.Trim(),Convert.ToInt32(cmb_category.SelectedValue));

            if (existingSubCategory != null)
            {

                if (existingSubCategory.is_deleted == 1)
                {
                    var result = MessageBox.Show("This Sub-Category exists but is deleted. Do you want to restore it?",
                                   "Restore Account",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {



                        if (controller.RestoreSubCategory(existingSubCategory.subCategory_id))
                        {
                            mainform.DeleteDeletedRecord(existingSubCategory.subCategory_id);
                            MessageBox.Show("Sub-Category restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }



                    }
                }
            }

            else
            {
                if (_isSaving)
                {


                    if (AddSubCategory())
                    {
                        MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var subCategory = txt_subcategory_name.Text;
                        var category = cmb_category.Text;
                        Audit.AuditLog(DateTime.Now, "Create", UserSession.CurrentUser.first_Name, "Manage Sub-Categories", $"Created sub-category '{subCategory}' for ({subCategory}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Please check the input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_isUpdating)
                {
                    if (UpdateSubCategory())
                    {
                        MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var subCategory = txt_subcategory_name.Text;
                        var category = cmb_category.Text;
                        Audit.AuditLog(DateTime.Now, "Update", UserSession.CurrentUser.first_Name, "Manage Sub-Categories", $"Updated sub-category '{subCategory}' for ({subCategory}) on {DateTime.Now:yyyy-MM-dd} at {DateTime.Now:HH:mm:ss}");
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
            if (!Validated()) return;

            IsAccountExists();
            await mainform.RefreshSubCategoryAsync();
        
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (!Validated()) return;

            IsAccountExists();

            await mainform.RefreshSubCategoryAsync();
        
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
