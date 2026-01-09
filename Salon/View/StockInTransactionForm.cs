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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Salon.View
{
    public partial class StockInTransactionForm : MaterialForm
    {
        private Stock_In_Repository repo = new Stock_In_Repository();
        private Stock_In_Controller controller;

        private Stock_Out_Repository out_repo = new Stock_Out_Repository();
        private Stock_Out_Controller out_controller;

        private readonly MainForm mainForm;
        public event EventHandler RefreshData;
        public StockInTransactionForm(MainForm main)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            ThemeManager.StyleDataGridView(dgv_products);
            ThemeManager.StyleDataGridView(dgv_stock_out);
            this.mainForm = main;
         

        }
        public void LoadStockInDetails() 
        {
            controller = new Stock_In_Controller(repo);

            dgv_products.AutoGenerateColumns = false;
            col_product_supplier_name.DataPropertyName = "supplier_name";
            col_product_name.DataPropertyName = "product_name";
            col_product_type.DataPropertyName = "product_type";
            col_product_size.DataPropertyName = "size_label";
            col_product_qty.DataPropertyName = "qty";
  

            dgv_products.DataSource = controller.GetAll();
        }
        public void LoadStockOutDetails() 
        {
            out_controller = new Stock_Out_Controller(out_repo);

            dgv_stock_out.AutoGenerateColumns = false;
            col_stk_out_name.DataPropertyName = "product_name";
            col_stk_out_product_type.DataPropertyName = "product_type";
            col_stk_out_product_brand.DataPropertyName = "brand";
            col_stk_out_product_unit_type.DataPropertyName = "product_unit_type";
            col_stk_out_qty_delivered.DataPropertyName = "qty_delivered";
            col_stk_out_total_qty_delivered.DataPropertyName = "total_qty_delivered";
            col_stk_out_qty_remaining.DataPropertyName = "qty_remaining";
            col_stk_out_total_remaining.DataPropertyName = "total_qty_remaining";
            col_stk_out_qty.DataPropertyName = "quantity";
            col_stk_out_total.DataPropertyName = "total";
            col_stk_out_unit_type.DataPropertyName = "unit_type";
            col_stk_out_out_type.DataPropertyName = "out_type";
            col_stk_out_created_at.DataPropertyName = "created_at";

            dgv_stock_out.DataSource = out_controller.GetAllStockOutLists();
        }
        private void StockInTransactionForm_Load(object sender, EventArgs e)
        {
            LoadStockInDetails();
            LoadStockOutDetails();
        }
    }
}
