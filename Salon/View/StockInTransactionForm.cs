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
            col_stk_in_refund_id.DataPropertyName = "refund_id";
            col_stk_in_stock_out_id.DataPropertyName = "stock_out_id";
            col_stk_in_inventory_id.DataPropertyName = "inventory_id";
            col_stk_in_product_name.DataPropertyName = "product_name";
            col_stk_in_brand.DataPropertyName = "brand";
            col_stk_in_size_label.DataPropertyName = "size_label";
            col_stk_in_qty.DataPropertyName = "qty";
            col_stk_in_qty_volume.DataPropertyName = "qty_volume";
            col_stk_in_unit_price.DataPropertyName = "unit_price";
            col_stk_in_line_total.DataPropertyName = "line_total";
            col_stk_in_prev_remaining.DataPropertyName = "previous_total_remaining";
            col_stk_in_new_remaining.DataPropertyName = "new_total_remaining";
            col_stk_in_prev_qty.DataPropertyName = "previous_qty";
            col_stk_in_new_qty.DataPropertyName = "new_qty";
            col_stk_in_movement_type.DataPropertyName = "movement_type";
            col_stk_in_reason.DataPropertyName = "reason";
            col_stk_in_fullName.DataPropertyName = "fullName";
            col_stk_in_created_at.DataPropertyName = "created_at";

        

            dgv_products.DataSource = controller.GetAll();
        }
        public void LoadStockOutDetails() 
        {
            out_controller = new Stock_Out_Controller(out_repo);

   

             dgv_stock_out.AutoGenerateColumns = false;
            col_stk_out_invoice_number.DataPropertyName = "invoice_number";
            col_stk_out_name.DataPropertyName = "product_name";
            col_stk_out_size.DataPropertyName = "size_label";
            col_stk_out_qty.DataPropertyName = "qty";
            col_stk_out_qty_volume.DataPropertyName = "qty_volume";
            col_stk_out_unit_price.DataPropertyName = "unit_price";
            col_stk_out_line_total.DataPropertyName = "line_total";
            col_stk_out_prev_total_remaining.DataPropertyName = "previous_total_remaining";
            col_stk_out_new_total_remaining.DataPropertyName = "new_total_remaining";
            col_stk_out_prev_qty.DataPropertyName = "previous_qty";
            col_stk_out_new_qty.DataPropertyName = "new_qty";
            col_stk_out_movement_type.DataPropertyName = "movement_type";
            col_stk_out_reason.DataPropertyName = "reason";
            col_stk_out_user_name.DataPropertyName = "fullName";
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
