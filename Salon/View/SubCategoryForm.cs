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

        private void LoadCategory() 
        {
            var repo = new CategoryRepository();
            var controller = new CategoryController(repo);
            var categories = controller.getAllCategory();

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
            mainform.LoadSubCategory();
        }
        private void UpdateSubCategory() 
        {
            var repo = new SubCategoryRepository();
            var controller = new SubCategoryController(repo);

            subCategoryModel.category_id = (int)cmb_category.SelectedValue;
            subCategoryModel.subCategoryName = txt_subcategory_name.Text.Trim();

            controller.updateSubCategory(subCategoryModel);
            MessageBox.Show("Sub-Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainform.LoadSubCategory();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            AddSubCategory();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateSubCategory();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
