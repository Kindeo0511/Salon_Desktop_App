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
namespace Salon.View
{
    public partial class ProductModalForm : MaterialForm
    {
        private RetailProduct productModel;
        private AddProductForm addProductForm;
        public ProductModalForm(AddProductForm addProductForm, RetailProduct productModel)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.addProductForm = addProductForm;
            this.productModel = productModel;
        }

        private void LoadSelectedProdct(RetailProduct productModel) 
        {
            lbl_product_name.Text = productModel.product_name;
            lbl_brand.Text = productModel.brand;
            lbl_size.Text = productModel.size_label;
            lbl_price.Text = productModel.selling_price.ToString();
        }
        public bool CheckInventoryProducttStock(int product_id, int product_size_id, int qty_required)
        {
            var inventoryRepo = new InventoryRepository();
            var inventoryController = new InventoryController(inventoryRepo);




            var stock = inventoryController.GetStockByProductSize(product_id, product_size_id);
            if (stock < qty_required)
            {
                return false; // insufficient
            }


            return true; // all sufficient
        }
        private void ProductModalForm_Load(object sender, EventArgs e)
        {
            LoadSelectedProdct(this.productModel);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(txt_qty.Value);

            // Validate stock first
            if (!CheckInventoryProducttStock(productModel.product_id,productModel.product_size_id, qty))
            {
                // Show detailed shortages
                MessageBox.Show("Cannot sell product. Insufficient stock.",
                         "Stock Check",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                return; // block adding


            }


     
            addProductForm.SaveProduct(productModel.product_id, productModel.product_size_id, qty, productModel.selling_price);
            MessageBox.Show("Success");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
