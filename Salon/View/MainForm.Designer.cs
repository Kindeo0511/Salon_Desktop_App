namespace Salon.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_table_summary = new System.Windows.Forms.DataGridView();
            this.col_db_app_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_stylist_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_stylist_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_payment_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_booking_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_db_assign_staff = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.chart_popular_services = new LiveCharts.WinForms.PieChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_total_services = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_total_product = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_product = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_total_appointment = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.total_sales_card = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_total_sales = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.userTab = new System.Windows.Forms.TabPage();
            this.materialCard11 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_view = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.stylistTab = new System.Windows.Forms.TabPage();
            this.materialCard13 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_stylist = new System.Windows.Forms.DataGridView();
            this.col_stylist_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylist_first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylist_middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylist_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylist_day_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylist_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylist_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylist_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylist_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylist_btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.stylist_btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_view_schedules = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_add_stylist = new MaterialSkin.Controls.MaterialButton();
            this.customerTab = new System.Windows.Forms.TabPage();
            this.materialCard12 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.col_customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer_first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer_middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer_btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_customer_btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.btn_add_customer = new MaterialSkin.Controls.MaterialButton();
            this.supplierTab = new System.Windows.Forms.TabPage();
            this.materialCard25 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_supplier = new System.Windows.Forms.DataGridView();
            this.col_supplier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_supplier_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_supplier_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_supplier_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_supplier_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_supplier_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard24 = new MaterialSkin.Controls.MaterialCard();
            this.btn_add_supplier = new MaterialSkin.Controls.MaterialButton();
            this.categoriesTab = new System.Windows.Forms.TabPage();
            this.materialCard15 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.col_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category_btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_category_btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard14 = new MaterialSkin.Controls.MaterialCard();
            this.btn_add_category = new MaterialSkin.Controls.MaterialButton();
            this.subCategoryTab = new System.Windows.Forms.TabPage();
            this.materialCard17 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_sub_category = new System.Windows.Forms.DataGridView();
            this.col_subcategory_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sub_cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sub_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sub_category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sub_btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.coL_sub_btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard16 = new MaterialSkin.Controls.MaterialCard();
            this.btn_add_subcategory = new MaterialSkin.Controls.MaterialButton();
            this.productsTab = new System.Windows.Forms.TabPage();
            this.materialCard19 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.col_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_unit_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_usage_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_unit_per_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_btn_product_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_btn_product_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard18 = new MaterialSkin.Controls.MaterialCard();
            this.btn_add_product = new MaterialSkin.Controls.MaterialButton();
            this.servicesTab = new System.Windows.Forms.TabPage();
            this.materialCard21 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_service = new System.Windows.Forms.DataGridView();
            this.col_service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_subcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_product_usage = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_service_btn_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_service_btn_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard20 = new MaterialSkin.Controls.MaterialCard();
            this.btn_add_service = new MaterialSkin.Controls.MaterialButton();
            this.deliveryTab = new System.Windows.Forms.TabPage();
            this.materialCard27 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_delivery = new System.Windows.Forms.DataGridView();
            this.col_delivery_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_delivery_supplier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_delivery_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_delivery_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_delivery_invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_delivery_received_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_delivery_view_items = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard26 = new MaterialSkin.Controls.MaterialCard();
            this.btn_add_delivery = new MaterialSkin.Controls.MaterialButton();
            this.priceTab = new System.Windows.Forms.TabPage();
            this.materialCard29 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_service_price = new System.Windows.Forms.DataGridView();
            this.col_price_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_price_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_service_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stylist_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_overhead_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vat_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_net_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_net_profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gross_profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_profit_percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_price_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard28 = new MaterialSkin.Controls.MaterialCard();
            this.btn_add_price = new MaterialSkin.Controls.MaterialButton();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.inventoryTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.inventory = new System.Windows.Forms.TabPage();
            this.dgv_inventory = new System.Windows.Forms.DataGridView();
            this.col_InventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_volume_per_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Critical_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batch_inventory = new System.Windows.Forms.TabPage();
            this.dgv_BatchInventory = new System.Windows.Forms.DataGridView();
            this.col_BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DeliveryItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_volume_per_qtn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DateReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.appointmentTab = new System.Windows.Forms.TabPage();
            this.materialCard23 = new MaterialSkin.Controls.MaterialCard();
            this.dgv_appointment = new System.Windows.Forms.DataGridView();
            this.appointment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylist_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_book_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_assign_staff = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_pay = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_appointment_status = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard22 = new MaterialSkin.Controls.MaterialCard();
            this.btn_add_appointment = new MaterialSkin.Controls.MaterialButton();
            this.reportsTab = new System.Windows.Forms.TabPage();
            this.reportsTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.SalesTabPage = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_report_table = new System.Windows.Forms.DataGridView();
            this.col_transaction_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_report_appointment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_report_vat_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_report_discount_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_report_amount_paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_report_payment_method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_report_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.btn_export_pdf = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_report_clear = new MaterialSkin.Controls.MaterialButton();
            this.btn_report_filter = new MaterialSkin.Controls.MaterialButton();
            this.lbl_report_total_gcash = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_report_total_discount = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_report_total_vat = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_report_total_sales = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_report_total_cash = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_report_total_transaction = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_report_end_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_report_start_date = new System.Windows.Forms.DateTimePicker();
            this.cmb_sales_report_range = new MaterialSkin.Controls.MaterialComboBox();
            this.inventoryTabPage = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv_inventory_report = new System.Windows.Forms.DataGridView();
            this.col_inventory_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inventory_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inventory_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inventory_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inventory_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inventory_total_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inventory_critical_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inventory_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.btn_inventory_export_pdf = new MaterialSkin.Controls.MaterialButton();
            this.btn_inventory_clear = new MaterialSkin.Controls.MaterialButton();
            this.btn_inventory_filter = new MaterialSkin.Controls.MaterialButton();
            this.lbl_inventory_stock_item = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_inventory_total_volume = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_inventory_total_product = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_inventory_low_stock = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_inventory_out_of_stock = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_stock_status = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.auditTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.vatAndDiscount = new System.Windows.Forms.TabPage();
            this.dgv_discount = new System.Windows.Forms.DataGridView();
            this.col_discount_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_discount_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_promo_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_discount_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_discount_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_discount_update = new System.Windows.Forms.DataGridViewImageColumn();
            this.coL_discount_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btn_cancel_discount = new MaterialSkin.Controls.MaterialButton();
            this.btn_update_discount = new MaterialSkin.Controls.MaterialButton();
            this.btn_add_discount = new MaterialSkin.Controls.MaterialButton();
            this.txt_promo_code = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_discount_type = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_discount = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_apply = new MaterialSkin.Controls.MaterialButton();
            this.txt_vat = new MaterialSkin.Controls.MaterialTextBox();
            this.utilityTab = new System.Windows.Forms.TabPage();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.btn_save_changes = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel_bill = new MaterialSkin.Controls.MaterialButton();
            this.btn_edit_bill = new MaterialSkin.Controls.MaterialButton();
            this.btn_add_bill = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_internet_bill = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_other_bill = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_month_rent = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_bill_note = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_water_bill = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_electric_bill = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_working_hours = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_total_cost = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_total_utility = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.expenseTabPage = new System.Windows.Forms.TabPage();
            this.materialCard30 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btn_expense_clear = new MaterialSkin.Controls.MaterialButton();
            this.btn_expense_filter = new MaterialSkin.Controls.MaterialButton();
            this.lbl_expense_inventory_total = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_expense_total = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_expense_supplies = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_expense_utility_total = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_ = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_expense_range = new MaterialSkin.Controls.MaterialComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgv_expense_report = new System.Windows.Forms.DataGridView();
            this.dtp_expense_start_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_expense_end_date = new System.Windows.Forms.DateTimePicker();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.col_expense_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expense_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expense_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expense_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expense_paid_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expense_notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_expense_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.dashboardTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table_summary)).BeginInit();
            this.panel2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.total_sales_card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.userTab.SuspendLayout();
            this.materialCard11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.panel3.SuspendLayout();
            this.stylistTab.SuspendLayout();
            this.materialCard13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stylist)).BeginInit();
            this.panel4.SuspendLayout();
            this.customerTab.SuspendLayout();
            this.materialCard12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.materialCard10.SuspendLayout();
            this.supplierTab.SuspendLayout();
            this.materialCard25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).BeginInit();
            this.materialCard24.SuspendLayout();
            this.categoriesTab.SuspendLayout();
            this.materialCard15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.materialCard14.SuspendLayout();
            this.subCategoryTab.SuspendLayout();
            this.materialCard17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sub_category)).BeginInit();
            this.materialCard16.SuspendLayout();
            this.productsTab.SuspendLayout();
            this.materialCard19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.materialCard18.SuspendLayout();
            this.servicesTab.SuspendLayout();
            this.materialCard21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).BeginInit();
            this.materialCard20.SuspendLayout();
            this.deliveryTab.SuspendLayout();
            this.materialCard27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_delivery)).BeginInit();
            this.materialCard26.SuspendLayout();
            this.priceTab.SuspendLayout();
            this.materialCard29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service_price)).BeginInit();
            this.materialCard28.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            this.inventoryTabControl.SuspendLayout();
            this.inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
            this.batch_inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BatchInventory)).BeginInit();
            this.appointmentTab.SuspendLayout();
            this.materialCard23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointment)).BeginInit();
            this.materialCard22.SuspendLayout();
            this.reportsTab.SuspendLayout();
            this.reportsTabControl.SuspendLayout();
            this.SalesTabPage.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report_table)).BeginInit();
            this.materialCard8.SuspendLayout();
            this.inventoryTabPage.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory_report)).BeginInit();
            this.materialCard9.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.vatAndDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_discount)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.utilityTab.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.expenseTabPage.SuspendLayout();
            this.materialCard30.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expense_report)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.dashboardTab);
            this.materialTabControl1.Controls.Add(this.userTab);
            this.materialTabControl1.Controls.Add(this.stylistTab);
            this.materialTabControl1.Controls.Add(this.customerTab);
            this.materialTabControl1.Controls.Add(this.supplierTab);
            this.materialTabControl1.Controls.Add(this.categoriesTab);
            this.materialTabControl1.Controls.Add(this.subCategoryTab);
            this.materialTabControl1.Controls.Add(this.productsTab);
            this.materialTabControl1.Controls.Add(this.servicesTab);
            this.materialTabControl1.Controls.Add(this.deliveryTab);
            this.materialTabControl1.Controls.Add(this.priceTab);
            this.materialTabControl1.Controls.Add(this.inventoryTab);
            this.materialTabControl1.Controls.Add(this.appointmentTab);
            this.materialTabControl1.Controls.Add(this.reportsTab);
            this.materialTabControl1.Controls.Add(this.auditTab);
            this.materialTabControl1.Controls.Add(this.settingsTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1936, 1035);
            this.materialTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.materialTabControl1.TabIndex = 0;
            // 
            // dashboardTab
            // 
            this.dashboardTab.Controls.Add(this.tableLayoutPanel2);
            this.dashboardTab.Controls.Add(this.panel1);
            this.dashboardTab.Location = new System.Drawing.Point(4, 34);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(50);
            this.dashboardTab.Size = new System.Drawing.Size(1928, 997);
            this.dashboardTab.TabIndex = 2;
            this.dashboardTab.Text = "DashBoard";
            this.dashboardTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.materialCard2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialCard3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(50, 300);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1828, 647);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgv_table_summary);
            this.materialCard2.Controls.Add(this.panel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1147, 619);
            this.materialCard2.TabIndex = 0;
            // 
            // dgv_table_summary
            // 
            this.dgv_table_summary.AllowDrop = true;
            this.dgv_table_summary.AllowUserToAddRows = false;
            this.dgv_table_summary.AllowUserToDeleteRows = false;
            this.dgv_table_summary.AllowUserToResizeColumns = false;
            this.dgv_table_summary.AllowUserToResizeRows = false;
            this.dgv_table_summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_table_summary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_table_summary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_table_summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table_summary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_db_app_id,
            this.col_db_customer_id,
            this.col_db_customer_name,
            this.col_db_stylist_id,
            this.col_db_stylist_name,
            this.col_db_date,
            this.col_db_start_time,
            this.col_db_end_time,
            this.col_db_status,
            this.col_db_payment_status,
            this.col_db_booking_type,
            this.col_db_assign_staff});
            this.dgv_table_summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_table_summary.EnableHeadersVisualStyles = false;
            this.dgv_table_summary.Location = new System.Drawing.Point(14, 60);
            this.dgv_table_summary.Name = "dgv_table_summary";
            this.dgv_table_summary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_table_summary.RowHeadersVisible = false;
            this.dgv_table_summary.RowHeadersWidth = 51;
            this.dgv_table_summary.RowTemplate.Height = 24;
            this.dgv_table_summary.Size = new System.Drawing.Size(1119, 545);
            this.dgv_table_summary.TabIndex = 15;
            this.dgv_table_summary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_summary_CellClick);
            // 
            // col_db_app_id
            // 
            this.col_db_app_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_app_id.HeaderText = "app_id";
            this.col_db_app_id.MinimumWidth = 6;
            this.col_db_app_id.Name = "col_db_app_id";
            this.col_db_app_id.Visible = false;
            // 
            // col_db_customer_id
            // 
            this.col_db_customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_customer_id.HeaderText = "customer_id";
            this.col_db_customer_id.MinimumWidth = 6;
            this.col_db_customer_id.Name = "col_db_customer_id";
            this.col_db_customer_id.Visible = false;
            // 
            // col_db_customer_name
            // 
            this.col_db_customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_customer_name.HeaderText = "Client Name";
            this.col_db_customer_name.MinimumWidth = 6;
            this.col_db_customer_name.Name = "col_db_customer_name";
            // 
            // col_db_stylist_id
            // 
            this.col_db_stylist_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_stylist_id.HeaderText = "stylist_id";
            this.col_db_stylist_id.MinimumWidth = 6;
            this.col_db_stylist_id.Name = "col_db_stylist_id";
            this.col_db_stylist_id.Visible = false;
            // 
            // col_db_stylist_name
            // 
            this.col_db_stylist_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_stylist_name.HeaderText = "Stylist Name";
            this.col_db_stylist_name.MinimumWidth = 6;
            this.col_db_stylist_name.Name = "col_db_stylist_name";
            // 
            // col_db_date
            // 
            this.col_db_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_date.HeaderText = "Date";
            this.col_db_date.MinimumWidth = 6;
            this.col_db_date.Name = "col_db_date";
            // 
            // col_db_start_time
            // 
            this.col_db_start_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_start_time.HeaderText = "Start Time";
            this.col_db_start_time.MinimumWidth = 6;
            this.col_db_start_time.Name = "col_db_start_time";
            // 
            // col_db_end_time
            // 
            this.col_db_end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_end_time.HeaderText = "End TIme";
            this.col_db_end_time.MinimumWidth = 6;
            this.col_db_end_time.Name = "col_db_end_time";
            // 
            // col_db_status
            // 
            this.col_db_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_status.HeaderText = "Status";
            this.col_db_status.MinimumWidth = 6;
            this.col_db_status.Name = "col_db_status";
            this.col_db_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_db_payment_status
            // 
            this.col_db_payment_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_payment_status.HeaderText = "Payment Status";
            this.col_db_payment_status.MinimumWidth = 6;
            this.col_db_payment_status.Name = "col_db_payment_status";
            this.col_db_payment_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_db_booking_type
            // 
            this.col_db_booking_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_booking_type.HeaderText = "Booking Type";
            this.col_db_booking_type.MinimumWidth = 6;
            this.col_db_booking_type.Name = "col_db_booking_type";
            // 
            // col_db_assign_staff
            // 
            this.col_db_assign_staff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_db_assign_staff.HeaderText = "Assign Stylist";
            this.col_db_assign_staff.Image = ((System.Drawing.Image)(resources.GetObject("col_db_assign_staff.Image")));
            this.col_db_assign_staff.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_db_assign_staff.MinimumWidth = 6;
            this.col_db_assign_staff.Name = "col_db_assign_staff";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(14, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 46);
            this.panel2.TabIndex = 17;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel5.Location = new System.Drawing.Point(9, 5);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(182, 29);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "APPOINTMENTS";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.tableLayoutPanel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(1209, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(605, 619);
            this.materialCard3.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.materialLabel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chart_popular_services, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(577, 591);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Black;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(3, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(571, 59);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "POPULAR SERVICES";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart_popular_services
            // 
            this.chart_popular_services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_popular_services.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart_popular_services.Location = new System.Drawing.Point(3, 62);
            this.chart_popular_services.Name = "chart_popular_services";
            this.chart_popular_services.Size = new System.Drawing.Size(571, 526);
            this.chart_popular_services.TabIndex = 0;
            this.chart_popular_services.Text = " ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(50, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1828, 250);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.materialCard6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialCard5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialCard4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.total_sales_card, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1828, 173);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.pictureBox4);
            this.materialCard6.Controls.Add(this.lbl_total_services);
            this.materialCard6.Controls.Add(this.materialLabel4);
            this.materialCard6.Depth = 0;
            this.materialCard6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(1385, 14);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(429, 145);
            this.materialCard6.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(312, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_total_services
            // 
            this.lbl_total_services.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_total_services.AutoSize = true;
            this.lbl_total_services.Depth = 0;
            this.lbl_total_services.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_total_services.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbl_total_services.Location = new System.Drawing.Point(18, 73);
            this.lbl_total_services.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_total_services.Name = "lbl_total_services";
            this.lbl_total_services.Size = new System.Drawing.Size(32, 19);
            this.lbl_total_services.TabIndex = 6;
            this.lbl_total_services.Text = "0.00";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(18, 28);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(128, 24);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Total Services";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.pictureBox3);
            this.materialCard5.Controls.Add(this.lbl_total_product);
            this.materialCard5.Controls.Add(this.lbl_product);
            this.materialCard5.Depth = 0;
            this.materialCard5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(928, 14);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(429, 145);
            this.materialCard5.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(312, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_total_product
            // 
            this.lbl_total_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_total_product.AutoSize = true;
            this.lbl_total_product.Depth = 0;
            this.lbl_total_product.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_total_product.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbl_total_product.Location = new System.Drawing.Point(17, 76);
            this.lbl_total_product.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_total_product.Name = "lbl_total_product";
            this.lbl_total_product.Size = new System.Drawing.Size(32, 19);
            this.lbl_total_product.TabIndex = 4;
            this.lbl_total_product.Text = "0.00";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Depth = 0;
            this.lbl_product.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_product.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_product.Location = new System.Drawing.Point(17, 31);
            this.lbl_product.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(132, 24);
            this.lbl_product.TabIndex = 2;
            this.lbl_product.Text = "Total Products";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.pictureBox2);
            this.materialCard4.Controls.Add(this.lbl_total_appointment);
            this.materialCard4.Controls.Add(this.materialLabel2);
            this.materialCard4.Depth = 0;
            this.materialCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(471, 14);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(20);
            this.materialCard4.Size = new System.Drawing.Size(429, 145);
            this.materialCard4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(306, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_total_appointment
            // 
            this.lbl_total_appointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_total_appointment.AutoSize = true;
            this.lbl_total_appointment.Depth = 0;
            this.lbl_total_appointment.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_total_appointment.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbl_total_appointment.Location = new System.Drawing.Point(33, 76);
            this.lbl_total_appointment.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_total_appointment.Name = "lbl_total_appointment";
            this.lbl_total_appointment.Size = new System.Drawing.Size(32, 19);
            this.lbl_total_appointment.TabIndex = 3;
            this.lbl_total_appointment.Text = "0.00";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(32, 31);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(177, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Total Appointments";
            // 
            // total_sales_card
            // 
            this.total_sales_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.total_sales_card.Controls.Add(this.pictureBox1);
            this.total_sales_card.Controls.Add(this.lbl_total_sales);
            this.total_sales_card.Controls.Add(this.materialLabel1);
            this.total_sales_card.Depth = 0;
            this.total_sales_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total_sales_card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.total_sales_card.Location = new System.Drawing.Point(14, 14);
            this.total_sales_card.Margin = new System.Windows.Forms.Padding(14);
            this.total_sales_card.MouseState = MaterialSkin.MouseState.HOVER;
            this.total_sales_card.Name = "total_sales_card";
            this.total_sales_card.Padding = new System.Windows.Forms.Padding(20);
            this.total_sales_card.Size = new System.Drawing.Size(429, 145);
            this.total_sales_card.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_total_sales
            // 
            this.lbl_total_sales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_total_sales.AutoSize = true;
            this.lbl_total_sales.Depth = 0;
            this.lbl_total_sales.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_total_sales.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lbl_total_sales.Location = new System.Drawing.Point(24, 76);
            this.lbl_total_sales.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_total_sales.Name = "lbl_total_sales";
            this.lbl_total_sales.Size = new System.Drawing.Size(32, 19);
            this.lbl_total_sales.TabIndex = 1;
            this.lbl_total_sales.Text = "0.00";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(23, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Total Sales";
            this.materialLabel1.UseAccent = true;
            // 
            // userTab
            // 
            this.userTab.Controls.Add(this.materialCard11);
            this.userTab.Location = new System.Drawing.Point(4, 34);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(50);
            this.userTab.Size = new System.Drawing.Size(1928, 997);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "Manage User";
            this.userTab.UseVisualStyleBackColor = true;
            // 
            // materialCard11
            // 
            this.materialCard11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard11.Controls.Add(this.dgv_user);
            this.materialCard11.Controls.Add(this.panel3);
            this.materialCard11.Depth = 0;
            this.materialCard11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard11.Location = new System.Drawing.Point(50, 50);
            this.materialCard11.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard11.Name = "materialCard11";
            this.materialCard11.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard11.Size = new System.Drawing.Size(1828, 897);
            this.materialCard11.TabIndex = 5;
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.AllowUserToResizeColumns = false;
            this.dgv_user.AllowUserToResizeRows = false;
            this.dgv_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_first_name,
            this.col_middle_name,
            this.col_last_name,
            this.col_birth_date,
            this.col_phone,
            this.col_email,
            this.col_address,
            this.col_username,
            this.col_password,
            this.col_role,
            this.btn_update,
            this.btn_delete,
            this.col_view});
            this.dgv_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_user.EnableHeadersVisualStyles = false;
            this.dgv_user.Location = new System.Drawing.Point(14, 89);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_user.RowHeadersVisible = false;
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 24;
            this.dgv_user.Size = new System.Drawing.Size(1800, 794);
            this.dgv_user.TabIndex = 2;
            this.dgv_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellClick);
            // 
            // col_id
            // 
            this.col_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_id.HeaderText = "ID";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_first_name
            // 
            this.col_first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_first_name.HeaderText = "First Name";
            this.col_first_name.MinimumWidth = 6;
            this.col_first_name.Name = "col_first_name";
            this.col_first_name.ReadOnly = true;
            // 
            // col_middle_name
            // 
            this.col_middle_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_middle_name.HeaderText = "Middle Name";
            this.col_middle_name.MinimumWidth = 6;
            this.col_middle_name.Name = "col_middle_name";
            this.col_middle_name.ReadOnly = true;
            // 
            // col_last_name
            // 
            this.col_last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_last_name.HeaderText = "Last Name";
            this.col_last_name.MinimumWidth = 6;
            this.col_last_name.Name = "col_last_name";
            this.col_last_name.ReadOnly = true;
            // 
            // col_birth_date
            // 
            this.col_birth_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_birth_date.HeaderText = "Date of Birth";
            this.col_birth_date.MinimumWidth = 6;
            this.col_birth_date.Name = "col_birth_date";
            this.col_birth_date.ReadOnly = true;
            // 
            // col_phone
            // 
            this.col_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_phone.HeaderText = "Contact";
            this.col_phone.MinimumWidth = 6;
            this.col_phone.Name = "col_phone";
            this.col_phone.ReadOnly = true;
            // 
            // col_email
            // 
            this.col_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_email.HeaderText = "Email";
            this.col_email.MinimumWidth = 6;
            this.col_email.Name = "col_email";
            this.col_email.ReadOnly = true;
            // 
            // col_address
            // 
            this.col_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_address.HeaderText = "Address";
            this.col_address.MinimumWidth = 6;
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            this.col_address.Visible = false;
            // 
            // col_username
            // 
            this.col_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_username.HeaderText = "Username";
            this.col_username.MinimumWidth = 6;
            this.col_username.Name = "col_username";
            this.col_username.ReadOnly = true;
            this.col_username.Visible = false;
            // 
            // col_password
            // 
            this.col_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_password.HeaderText = "Password";
            this.col_password.MinimumWidth = 6;
            this.col_password.Name = "col_password";
            this.col_password.ReadOnly = true;
            this.col_password.Visible = false;
            // 
            // col_role
            // 
            this.col_role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_role.HeaderText = "Role";
            this.col_role.MinimumWidth = 6;
            this.col_role.Name = "col_role";
            this.col_role.ReadOnly = true;
            // 
            // btn_update
            // 
            this.btn_update.HeaderText = "Update";
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_update.MinimumWidth = 6;
            this.btn_update.Name = "btn_update";
            this.btn_update.ReadOnly = true;
            this.btn_update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_update.Width = 125;
            // 
            // btn_delete
            // 
            this.btn_delete.HeaderText = "Delete";
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btn_delete.MinimumWidth = 6;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ReadOnly = true;
            this.btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_delete.Width = 125;
            // 
            // col_view
            // 
            this.col_view.HeaderText = "VIew";
            this.col_view.Image = ((System.Drawing.Image)(resources.GetObject("col_view.Image")));
            this.col_view.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_view.MinimumWidth = 6;
            this.col_view.Name = "col_view";
            this.col_view.ReadOnly = true;
            this.col_view.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_view.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_view.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(14, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1800, 75);
            this.panel3.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add.Depth = 0;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(20, 6);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add.Size = new System.Drawing.Size(151, 36);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Create new user";
            this.btn_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add.UseAccentColor = false;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // stylistTab
            // 
            this.stylistTab.Controls.Add(this.materialCard13);
            this.stylistTab.Location = new System.Drawing.Point(4, 34);
            this.stylistTab.Name = "stylistTab";
            this.stylistTab.Padding = new System.Windows.Forms.Padding(50);
            this.stylistTab.Size = new System.Drawing.Size(1928, 997);
            this.stylistTab.TabIndex = 1;
            this.stylistTab.Text = "Manage Stylist";
            this.stylistTab.UseVisualStyleBackColor = true;
            // 
            // materialCard13
            // 
            this.materialCard13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard13.Controls.Add(this.dgv_stylist);
            this.materialCard13.Controls.Add(this.panel4);
            this.materialCard13.Depth = 0;
            this.materialCard13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard13.Location = new System.Drawing.Point(50, 50);
            this.materialCard13.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard13.Name = "materialCard13";
            this.materialCard13.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard13.Size = new System.Drawing.Size(1828, 897);
            this.materialCard13.TabIndex = 7;
            // 
            // dgv_stylist
            // 
            this.dgv_stylist.AllowUserToAddRows = false;
            this.dgv_stylist.AllowUserToDeleteRows = false;
            this.dgv_stylist.AllowUserToResizeColumns = false;
            this.dgv_stylist.AllowUserToResizeRows = false;
            this.dgv_stylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_stylist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_stylist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_stylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_stylist_id,
            this.stylist_first_name,
            this.stylist_middle_name,
            this.stylist_last_name,
            this.stylist_day_of_birth,
            this.stylist_contact,
            this.stylist_email,
            this.stylist_address,
            this.stylist_role,
            this.stylist_btn_update,
            this.stylist_btn_delete,
            this.col_view_schedules});
            this.dgv_stylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_stylist.EnableHeadersVisualStyles = false;
            this.dgv_stylist.Location = new System.Drawing.Point(14, 89);
            this.dgv_stylist.Name = "dgv_stylist";
            this.dgv_stylist.ReadOnly = true;
            this.dgv_stylist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_stylist.RowHeadersVisible = false;
            this.dgv_stylist.RowHeadersWidth = 51;
            this.dgv_stylist.RowTemplate.Height = 24;
            this.dgv_stylist.Size = new System.Drawing.Size(1800, 794);
            this.dgv_stylist.TabIndex = 4;
            this.dgv_stylist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stylist_CellClick);
            // 
            // col_stylist_id
            // 
            this.col_stylist_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_stylist_id.HeaderText = "ID";
            this.col_stylist_id.MinimumWidth = 6;
            this.col_stylist_id.Name = "col_stylist_id";
            this.col_stylist_id.ReadOnly = true;
            // 
            // stylist_first_name
            // 
            this.stylist_first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stylist_first_name.HeaderText = "First Name";
            this.stylist_first_name.MinimumWidth = 6;
            this.stylist_first_name.Name = "stylist_first_name";
            this.stylist_first_name.ReadOnly = true;
            // 
            // stylist_middle_name
            // 
            this.stylist_middle_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stylist_middle_name.HeaderText = "Middle Name";
            this.stylist_middle_name.MinimumWidth = 6;
            this.stylist_middle_name.Name = "stylist_middle_name";
            this.stylist_middle_name.ReadOnly = true;
            // 
            // stylist_last_name
            // 
            this.stylist_last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stylist_last_name.HeaderText = "Last Name";
            this.stylist_last_name.MinimumWidth = 6;
            this.stylist_last_name.Name = "stylist_last_name";
            this.stylist_last_name.ReadOnly = true;
            // 
            // stylist_day_of_birth
            // 
            this.stylist_day_of_birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stylist_day_of_birth.HeaderText = "Date of Birth";
            this.stylist_day_of_birth.MinimumWidth = 6;
            this.stylist_day_of_birth.Name = "stylist_day_of_birth";
            this.stylist_day_of_birth.ReadOnly = true;
            // 
            // stylist_contact
            // 
            this.stylist_contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stylist_contact.HeaderText = "Contact";
            this.stylist_contact.MinimumWidth = 6;
            this.stylist_contact.Name = "stylist_contact";
            this.stylist_contact.ReadOnly = true;
            // 
            // stylist_email
            // 
            this.stylist_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stylist_email.HeaderText = "Email";
            this.stylist_email.MinimumWidth = 6;
            this.stylist_email.Name = "stylist_email";
            this.stylist_email.ReadOnly = true;
            // 
            // stylist_address
            // 
            this.stylist_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stylist_address.HeaderText = "Address";
            this.stylist_address.MinimumWidth = 6;
            this.stylist_address.Name = "stylist_address";
            this.stylist_address.ReadOnly = true;
            this.stylist_address.Visible = false;
            // 
            // stylist_role
            // 
            this.stylist_role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stylist_role.HeaderText = "Role";
            this.stylist_role.MinimumWidth = 6;
            this.stylist_role.Name = "stylist_role";
            this.stylist_role.ReadOnly = true;
            // 
            // stylist_btn_update
            // 
            this.stylist_btn_update.HeaderText = "Update";
            this.stylist_btn_update.Image = ((System.Drawing.Image)(resources.GetObject("stylist_btn_update.Image")));
            this.stylist_btn_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.stylist_btn_update.MinimumWidth = 6;
            this.stylist_btn_update.Name = "stylist_btn_update";
            this.stylist_btn_update.ReadOnly = true;
            this.stylist_btn_update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stylist_btn_update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stylist_btn_update.Width = 125;
            // 
            // stylist_btn_delete
            // 
            this.stylist_btn_delete.HeaderText = "Delete";
            this.stylist_btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("stylist_btn_delete.Image")));
            this.stylist_btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.stylist_btn_delete.MinimumWidth = 6;
            this.stylist_btn_delete.Name = "stylist_btn_delete";
            this.stylist_btn_delete.ReadOnly = true;
            this.stylist_btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stylist_btn_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stylist_btn_delete.Width = 125;
            // 
            // col_view_schedules
            // 
            this.col_view_schedules.HeaderText = "View Schedules";
            this.col_view_schedules.Image = ((System.Drawing.Image)(resources.GetObject("col_view_schedules.Image")));
            this.col_view_schedules.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_view_schedules.MinimumWidth = 6;
            this.col_view_schedules.Name = "col_view_schedules";
            this.col_view_schedules.ReadOnly = true;
            this.col_view_schedules.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_view_schedules.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_view_schedules.Width = 125;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_add_stylist);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(14, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1800, 75);
            this.panel4.TabIndex = 6;
            // 
            // btn_add_stylist
            // 
            this.btn_add_stylist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_stylist.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_stylist.Depth = 0;
            this.btn_add_stylist.HighEmphasis = true;
            this.btn_add_stylist.Icon = null;
            this.btn_add_stylist.Location = new System.Drawing.Point(4, 6);
            this.btn_add_stylist.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_stylist.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_stylist.Name = "btn_add_stylist";
            this.btn_add_stylist.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_stylist.Size = new System.Drawing.Size(172, 36);
            this.btn_add_stylist.TabIndex = 5;
            this.btn_add_stylist.Text = "Create new stylist";
            this.btn_add_stylist.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_stylist.UseAccentColor = false;
            this.btn_add_stylist.UseVisualStyleBackColor = true;
            this.btn_add_stylist.Click += new System.EventHandler(this.btn_add_stylist_Click);
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.materialCard12);
            this.customerTab.Controls.Add(this.materialCard10);
            this.customerTab.Location = new System.Drawing.Point(4, 34);
            this.customerTab.Name = "customerTab";
            this.customerTab.Padding = new System.Windows.Forms.Padding(50);
            this.customerTab.Size = new System.Drawing.Size(1928, 997);
            this.customerTab.TabIndex = 3;
            this.customerTab.Text = "Customer";
            this.customerTab.UseVisualStyleBackColor = true;
            // 
            // materialCard12
            // 
            this.materialCard12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard12.Controls.Add(this.dgv_customer);
            this.materialCard12.Depth = 0;
            this.materialCard12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard12.Location = new System.Drawing.Point(50, 125);
            this.materialCard12.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard12.Name = "materialCard12";
            this.materialCard12.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard12.Size = new System.Drawing.Size(1828, 822);
            this.materialCard12.TabIndex = 9;
            // 
            // dgv_customer
            // 
            this.dgv_customer.AllowUserToAddRows = false;
            this.dgv_customer.AllowUserToDeleteRows = false;
            this.dgv_customer.AllowUserToResizeColumns = false;
            this.dgv_customer.AllowUserToResizeRows = false;
            this.dgv_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_customer_id,
            this.col_customer_first_name,
            this.col_customer_middle_name,
            this.col_customer_last_name,
            this.col_customer_contact,
            this.col_customer_email,
            this.col_customer_btn_update,
            this.col_customer_btn_delete});
            this.dgv_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_customer.EnableHeadersVisualStyles = false;
            this.dgv_customer.Location = new System.Drawing.Point(14, 14);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.ReadOnly = true;
            this.dgv_customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.RowTemplate.Height = 24;
            this.dgv_customer.Size = new System.Drawing.Size(1800, 794);
            this.dgv_customer.TabIndex = 6;
            this.dgv_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellClick);
            // 
            // col_customer_id
            // 
            this.col_customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_customer_id.HeaderText = "ID";
            this.col_customer_id.MinimumWidth = 6;
            this.col_customer_id.Name = "col_customer_id";
            this.col_customer_id.ReadOnly = true;
            // 
            // col_customer_first_name
            // 
            this.col_customer_first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_customer_first_name.HeaderText = "First Name";
            this.col_customer_first_name.MinimumWidth = 6;
            this.col_customer_first_name.Name = "col_customer_first_name";
            this.col_customer_first_name.ReadOnly = true;
            // 
            // col_customer_middle_name
            // 
            this.col_customer_middle_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_customer_middle_name.HeaderText = "Middle Name";
            this.col_customer_middle_name.MinimumWidth = 6;
            this.col_customer_middle_name.Name = "col_customer_middle_name";
            this.col_customer_middle_name.ReadOnly = true;
            // 
            // col_customer_last_name
            // 
            this.col_customer_last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_customer_last_name.HeaderText = "Last Name";
            this.col_customer_last_name.MinimumWidth = 6;
            this.col_customer_last_name.Name = "col_customer_last_name";
            this.col_customer_last_name.ReadOnly = true;
            // 
            // col_customer_contact
            // 
            this.col_customer_contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_customer_contact.HeaderText = "Contact";
            this.col_customer_contact.MinimumWidth = 6;
            this.col_customer_contact.Name = "col_customer_contact";
            this.col_customer_contact.ReadOnly = true;
            // 
            // col_customer_email
            // 
            this.col_customer_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_customer_email.HeaderText = "Email";
            this.col_customer_email.MinimumWidth = 6;
            this.col_customer_email.Name = "col_customer_email";
            this.col_customer_email.ReadOnly = true;
            // 
            // col_customer_btn_update
            // 
            this.col_customer_btn_update.HeaderText = "Update";
            this.col_customer_btn_update.Image = ((System.Drawing.Image)(resources.GetObject("col_customer_btn_update.Image")));
            this.col_customer_btn_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_customer_btn_update.MinimumWidth = 6;
            this.col_customer_btn_update.Name = "col_customer_btn_update";
            this.col_customer_btn_update.ReadOnly = true;
            this.col_customer_btn_update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_customer_btn_update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_customer_btn_update.Width = 125;
            // 
            // col_customer_btn_delete
            // 
            this.col_customer_btn_delete.HeaderText = "Delete";
            this.col_customer_btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("col_customer_btn_delete.Image")));
            this.col_customer_btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_customer_btn_delete.MinimumWidth = 6;
            this.col_customer_btn_delete.Name = "col_customer_btn_delete";
            this.col_customer_btn_delete.ReadOnly = true;
            this.col_customer_btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_customer_btn_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_customer_btn_delete.Width = 125;
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.btn_add_customer);
            this.materialCard10.Depth = 0;
            this.materialCard10.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(50, 50);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard10.Size = new System.Drawing.Size(1828, 75);
            this.materialCard10.TabIndex = 8;
            // 
            // btn_add_customer
            // 
            this.btn_add_customer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_customer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_customer.Depth = 0;
            this.btn_add_customer.HighEmphasis = true;
            this.btn_add_customer.Icon = null;
            this.btn_add_customer.Location = new System.Drawing.Point(18, 6);
            this.btn_add_customer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_customer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_customer.Name = "btn_add_customer";
            this.btn_add_customer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_customer.Size = new System.Drawing.Size(193, 36);
            this.btn_add_customer.TabIndex = 7;
            this.btn_add_customer.Text = "Create new customer";
            this.btn_add_customer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_customer.UseAccentColor = false;
            this.btn_add_customer.UseVisualStyleBackColor = true;
            this.btn_add_customer.Click += new System.EventHandler(this.btn_add_customer_Click);
            // 
            // supplierTab
            // 
            this.supplierTab.Controls.Add(this.materialCard25);
            this.supplierTab.Controls.Add(this.materialCard24);
            this.supplierTab.Location = new System.Drawing.Point(4, 34);
            this.supplierTab.Name = "supplierTab";
            this.supplierTab.Padding = new System.Windows.Forms.Padding(50);
            this.supplierTab.Size = new System.Drawing.Size(1928, 997);
            this.supplierTab.TabIndex = 12;
            this.supplierTab.Text = "Supplier";
            this.supplierTab.UseVisualStyleBackColor = true;
            // 
            // materialCard25
            // 
            this.materialCard25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard25.Controls.Add(this.dgv_supplier);
            this.materialCard25.Depth = 0;
            this.materialCard25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard25.Location = new System.Drawing.Point(50, 125);
            this.materialCard25.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard25.Name = "materialCard25";
            this.materialCard25.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard25.Size = new System.Drawing.Size(1828, 822);
            this.materialCard25.TabIndex = 17;
            // 
            // dgv_supplier
            // 
            this.dgv_supplier.AllowUserToAddRows = false;
            this.dgv_supplier.AllowUserToDeleteRows = false;
            this.dgv_supplier.AllowUserToResizeColumns = false;
            this.dgv_supplier.AllowUserToResizeRows = false;
            this.dgv_supplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_supplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_supplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_supplier_id,
            this.col_supplier_name,
            this.col_supplier_address,
            this.col_supplier_email,
            this.col_supplier_contact,
            this.col_supplier_update,
            this.col_supplier_delete});
            this.dgv_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_supplier.EnableHeadersVisualStyles = false;
            this.dgv_supplier.Location = new System.Drawing.Point(14, 14);
            this.dgv_supplier.Name = "dgv_supplier";
            this.dgv_supplier.ReadOnly = true;
            this.dgv_supplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_supplier.RowHeadersVisible = false;
            this.dgv_supplier.RowHeadersWidth = 51;
            this.dgv_supplier.RowTemplate.Height = 24;
            this.dgv_supplier.Size = new System.Drawing.Size(1800, 794);
            this.dgv_supplier.TabIndex = 14;
            this.dgv_supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplier_CellClick);
            // 
            // col_supplier_id
            // 
            this.col_supplier_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_supplier_id.HeaderText = "ID";
            this.col_supplier_id.MinimumWidth = 6;
            this.col_supplier_id.Name = "col_supplier_id";
            this.col_supplier_id.ReadOnly = true;
            // 
            // col_supplier_name
            // 
            this.col_supplier_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_supplier_name.HeaderText = "Supplier ";
            this.col_supplier_name.MinimumWidth = 6;
            this.col_supplier_name.Name = "col_supplier_name";
            this.col_supplier_name.ReadOnly = true;
            // 
            // col_supplier_address
            // 
            this.col_supplier_address.HeaderText = "Address";
            this.col_supplier_address.MinimumWidth = 6;
            this.col_supplier_address.Name = "col_supplier_address";
            this.col_supplier_address.ReadOnly = true;
            this.col_supplier_address.Width = 125;
            // 
            // col_supplier_email
            // 
            this.col_supplier_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_supplier_email.HeaderText = "Email";
            this.col_supplier_email.MinimumWidth = 6;
            this.col_supplier_email.Name = "col_supplier_email";
            this.col_supplier_email.ReadOnly = true;
            // 
            // col_supplier_contact
            // 
            this.col_supplier_contact.HeaderText = "Contact";
            this.col_supplier_contact.MinimumWidth = 6;
            this.col_supplier_contact.Name = "col_supplier_contact";
            this.col_supplier_contact.ReadOnly = true;
            this.col_supplier_contact.Width = 125;
            // 
            // col_supplier_update
            // 
            this.col_supplier_update.HeaderText = "";
            this.col_supplier_update.Image = ((System.Drawing.Image)(resources.GetObject("col_supplier_update.Image")));
            this.col_supplier_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_supplier_update.MinimumWidth = 6;
            this.col_supplier_update.Name = "col_supplier_update";
            this.col_supplier_update.ReadOnly = true;
            this.col_supplier_update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_supplier_update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_supplier_update.Width = 125;
            // 
            // col_supplier_delete
            // 
            this.col_supplier_delete.HeaderText = "";
            this.col_supplier_delete.Image = ((System.Drawing.Image)(resources.GetObject("col_supplier_delete.Image")));
            this.col_supplier_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_supplier_delete.MinimumWidth = 6;
            this.col_supplier_delete.Name = "col_supplier_delete";
            this.col_supplier_delete.ReadOnly = true;
            this.col_supplier_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_supplier_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_supplier_delete.Width = 125;
            // 
            // materialCard24
            // 
            this.materialCard24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard24.Controls.Add(this.btn_add_supplier);
            this.materialCard24.Depth = 0;
            this.materialCard24.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard24.Location = new System.Drawing.Point(50, 50);
            this.materialCard24.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard24.Name = "materialCard24";
            this.materialCard24.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard24.Size = new System.Drawing.Size(1828, 75);
            this.materialCard24.TabIndex = 16;
            // 
            // btn_add_supplier
            // 
            this.btn_add_supplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_supplier.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_supplier.Depth = 0;
            this.btn_add_supplier.HighEmphasis = true;
            this.btn_add_supplier.Icon = null;
            this.btn_add_supplier.Location = new System.Drawing.Point(18, 6);
            this.btn_add_supplier.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_supplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_supplier.Name = "btn_add_supplier";
            this.btn_add_supplier.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_supplier.Size = new System.Drawing.Size(146, 36);
            this.btn_add_supplier.TabIndex = 15;
            this.btn_add_supplier.Text = "Create Supplier";
            this.btn_add_supplier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_supplier.UseAccentColor = false;
            this.btn_add_supplier.UseVisualStyleBackColor = true;
            this.btn_add_supplier.Click += new System.EventHandler(this.btn_add_supplier_Click);
            // 
            // categoriesTab
            // 
            this.categoriesTab.Controls.Add(this.materialCard15);
            this.categoriesTab.Controls.Add(this.materialCard14);
            this.categoriesTab.Location = new System.Drawing.Point(4, 34);
            this.categoriesTab.Name = "categoriesTab";
            this.categoriesTab.Padding = new System.Windows.Forms.Padding(50);
            this.categoriesTab.Size = new System.Drawing.Size(1928, 997);
            this.categoriesTab.TabIndex = 4;
            this.categoriesTab.Text = "Categories";
            this.categoriesTab.UseVisualStyleBackColor = true;
            // 
            // materialCard15
            // 
            this.materialCard15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard15.Controls.Add(this.dgv_category);
            this.materialCard15.Depth = 0;
            this.materialCard15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard15.Location = new System.Drawing.Point(50, 125);
            this.materialCard15.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard15.Name = "materialCard15";
            this.materialCard15.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard15.Size = new System.Drawing.Size(1828, 822);
            this.materialCard15.TabIndex = 11;
            // 
            // dgv_category
            // 
            this.dgv_category.AllowUserToAddRows = false;
            this.dgv_category.AllowUserToDeleteRows = false;
            this.dgv_category.AllowUserToResizeColumns = false;
            this.dgv_category.AllowUserToResizeRows = false;
            this.dgv_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_category_id,
            this.col_category_name,
            this.col_category_type,
            this.col_category_btn_update,
            this.col_category_btn_delete});
            this.dgv_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_category.EnableHeadersVisualStyles = false;
            this.dgv_category.Location = new System.Drawing.Point(14, 14);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.ReadOnly = true;
            this.dgv_category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_category.RowHeadersVisible = false;
            this.dgv_category.RowHeadersWidth = 51;
            this.dgv_category.RowTemplate.Height = 24;
            this.dgv_category.Size = new System.Drawing.Size(1800, 794);
            this.dgv_category.TabIndex = 8;
            this.dgv_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellClick);
            // 
            // col_category_id
            // 
            this.col_category_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_category_id.HeaderText = "ID";
            this.col_category_id.MinimumWidth = 6;
            this.col_category_id.Name = "col_category_id";
            this.col_category_id.ReadOnly = true;
            // 
            // col_category_name
            // 
            this.col_category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_category_name.HeaderText = "Category";
            this.col_category_name.MinimumWidth = 6;
            this.col_category_name.Name = "col_category_name";
            this.col_category_name.ReadOnly = true;
            // 
            // col_category_type
            // 
            this.col_category_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_category_type.HeaderText = "Type";
            this.col_category_type.MinimumWidth = 6;
            this.col_category_type.Name = "col_category_type";
            this.col_category_type.ReadOnly = true;
            // 
            // col_category_btn_update
            // 
            this.col_category_btn_update.HeaderText = "Update";
            this.col_category_btn_update.Image = ((System.Drawing.Image)(resources.GetObject("col_category_btn_update.Image")));
            this.col_category_btn_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_category_btn_update.MinimumWidth = 6;
            this.col_category_btn_update.Name = "col_category_btn_update";
            this.col_category_btn_update.ReadOnly = true;
            this.col_category_btn_update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_category_btn_update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_category_btn_update.Width = 125;
            // 
            // col_category_btn_delete
            // 
            this.col_category_btn_delete.HeaderText = "Delete";
            this.col_category_btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("col_category_btn_delete.Image")));
            this.col_category_btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_category_btn_delete.MinimumWidth = 6;
            this.col_category_btn_delete.Name = "col_category_btn_delete";
            this.col_category_btn_delete.ReadOnly = true;
            this.col_category_btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_category_btn_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_category_btn_delete.Width = 125;
            // 
            // materialCard14
            // 
            this.materialCard14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard14.Controls.Add(this.btn_add_category);
            this.materialCard14.Depth = 0;
            this.materialCard14.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard14.Location = new System.Drawing.Point(50, 50);
            this.materialCard14.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard14.Name = "materialCard14";
            this.materialCard14.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard14.Size = new System.Drawing.Size(1828, 75);
            this.materialCard14.TabIndex = 10;
            // 
            // btn_add_category
            // 
            this.btn_add_category.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_category.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_category.Depth = 0;
            this.btn_add_category.HighEmphasis = true;
            this.btn_add_category.Icon = null;
            this.btn_add_category.Location = new System.Drawing.Point(18, 6);
            this.btn_add_category.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_category.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_category.Name = "btn_add_category";
            this.btn_add_category.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_category.Size = new System.Drawing.Size(190, 36);
            this.btn_add_category.TabIndex = 9;
            this.btn_add_category.Text = "Create new category";
            this.btn_add_category.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_category.UseAccentColor = false;
            this.btn_add_category.UseVisualStyleBackColor = true;
            this.btn_add_category.Click += new System.EventHandler(this.btn_add_category_Click);
            // 
            // subCategoryTab
            // 
            this.subCategoryTab.Controls.Add(this.materialCard17);
            this.subCategoryTab.Controls.Add(this.materialCard16);
            this.subCategoryTab.Location = new System.Drawing.Point(4, 34);
            this.subCategoryTab.Name = "subCategoryTab";
            this.subCategoryTab.Padding = new System.Windows.Forms.Padding(50);
            this.subCategoryTab.Size = new System.Drawing.Size(1928, 997);
            this.subCategoryTab.TabIndex = 5;
            this.subCategoryTab.Text = "Sub-Categories";
            this.subCategoryTab.UseVisualStyleBackColor = true;
            // 
            // materialCard17
            // 
            this.materialCard17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard17.Controls.Add(this.dgv_sub_category);
            this.materialCard17.Depth = 0;
            this.materialCard17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard17.Location = new System.Drawing.Point(50, 125);
            this.materialCard17.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard17.Name = "materialCard17";
            this.materialCard17.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard17.Size = new System.Drawing.Size(1828, 822);
            this.materialCard17.TabIndex = 13;
            // 
            // dgv_sub_category
            // 
            this.dgv_sub_category.AllowUserToAddRows = false;
            this.dgv_sub_category.AllowUserToDeleteRows = false;
            this.dgv_sub_category.AllowUserToResizeColumns = false;
            this.dgv_sub_category.AllowUserToResizeRows = false;
            this.dgv_sub_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sub_category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_sub_category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_sub_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sub_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_subcategory_id,
            this.col_sub_cid,
            this.col_sub_name,
            this.col_sub_category_name,
            this.col_sub_btn_update,
            this.coL_sub_btn_delete});
            this.dgv_sub_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sub_category.EnableHeadersVisualStyles = false;
            this.dgv_sub_category.Location = new System.Drawing.Point(14, 14);
            this.dgv_sub_category.Name = "dgv_sub_category";
            this.dgv_sub_category.ReadOnly = true;
            this.dgv_sub_category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_sub_category.RowHeadersVisible = false;
            this.dgv_sub_category.RowHeadersWidth = 51;
            this.dgv_sub_category.RowTemplate.Height = 24;
            this.dgv_sub_category.Size = new System.Drawing.Size(1800, 794);
            this.dgv_sub_category.TabIndex = 10;
            this.dgv_sub_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sub_category_CellClick);
            // 
            // col_subcategory_id
            // 
            this.col_subcategory_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_subcategory_id.HeaderText = "ID";
            this.col_subcategory_id.MinimumWidth = 6;
            this.col_subcategory_id.Name = "col_subcategory_id";
            this.col_subcategory_id.ReadOnly = true;
            // 
            // col_sub_cid
            // 
            this.col_sub_cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_sub_cid.HeaderText = "CID";
            this.col_sub_cid.MinimumWidth = 6;
            this.col_sub_cid.Name = "col_sub_cid";
            this.col_sub_cid.ReadOnly = true;
            // 
            // col_sub_name
            // 
            this.col_sub_name.HeaderText = "Sub-Category";
            this.col_sub_name.MinimumWidth = 6;
            this.col_sub_name.Name = "col_sub_name";
            this.col_sub_name.ReadOnly = true;
            this.col_sub_name.Width = 125;
            // 
            // col_sub_category_name
            // 
            this.col_sub_category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_sub_category_name.HeaderText = "Category";
            this.col_sub_category_name.MinimumWidth = 6;
            this.col_sub_category_name.Name = "col_sub_category_name";
            this.col_sub_category_name.ReadOnly = true;
            // 
            // col_sub_btn_update
            // 
            this.col_sub_btn_update.HeaderText = "Update";
            this.col_sub_btn_update.Image = ((System.Drawing.Image)(resources.GetObject("col_sub_btn_update.Image")));
            this.col_sub_btn_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_sub_btn_update.MinimumWidth = 6;
            this.col_sub_btn_update.Name = "col_sub_btn_update";
            this.col_sub_btn_update.ReadOnly = true;
            this.col_sub_btn_update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_sub_btn_update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_sub_btn_update.Width = 125;
            // 
            // coL_sub_btn_delete
            // 
            this.coL_sub_btn_delete.HeaderText = "Delete";
            this.coL_sub_btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("coL_sub_btn_delete.Image")));
            this.coL_sub_btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.coL_sub_btn_delete.MinimumWidth = 6;
            this.coL_sub_btn_delete.Name = "coL_sub_btn_delete";
            this.coL_sub_btn_delete.ReadOnly = true;
            this.coL_sub_btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coL_sub_btn_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.coL_sub_btn_delete.Width = 125;
            // 
            // materialCard16
            // 
            this.materialCard16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard16.Controls.Add(this.btn_add_subcategory);
            this.materialCard16.Depth = 0;
            this.materialCard16.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard16.Location = new System.Drawing.Point(50, 50);
            this.materialCard16.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard16.Name = "materialCard16";
            this.materialCard16.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard16.Size = new System.Drawing.Size(1828, 75);
            this.materialCard16.TabIndex = 12;
            // 
            // btn_add_subcategory
            // 
            this.btn_add_subcategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_subcategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_subcategory.Depth = 0;
            this.btn_add_subcategory.HighEmphasis = true;
            this.btn_add_subcategory.Icon = null;
            this.btn_add_subcategory.Location = new System.Drawing.Point(18, 6);
            this.btn_add_subcategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_subcategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_subcategory.Name = "btn_add_subcategory";
            this.btn_add_subcategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_subcategory.Size = new System.Drawing.Size(186, 36);
            this.btn_add_subcategory.TabIndex = 11;
            this.btn_add_subcategory.Text = "Create sub-category";
            this.btn_add_subcategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_subcategory.UseAccentColor = false;
            this.btn_add_subcategory.UseVisualStyleBackColor = true;
            this.btn_add_subcategory.Click += new System.EventHandler(this.btn_add_subcategory_Click);
            // 
            // productsTab
            // 
            this.productsTab.Controls.Add(this.materialCard19);
            this.productsTab.Controls.Add(this.materialCard18);
            this.productsTab.Location = new System.Drawing.Point(4, 34);
            this.productsTab.Name = "productsTab";
            this.productsTab.Padding = new System.Windows.Forms.Padding(50);
            this.productsTab.Size = new System.Drawing.Size(1928, 997);
            this.productsTab.TabIndex = 6;
            this.productsTab.Text = "Products";
            this.productsTab.UseVisualStyleBackColor = true;
            // 
            // materialCard19
            // 
            this.materialCard19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard19.Controls.Add(this.dgv_product);
            this.materialCard19.Depth = 0;
            this.materialCard19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard19.Location = new System.Drawing.Point(50, 125);
            this.materialCard19.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard19.Name = "materialCard19";
            this.materialCard19.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard19.Size = new System.Drawing.Size(1828, 822);
            this.materialCard19.TabIndex = 15;
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.AllowUserToResizeColumns = false;
            this.dgv_product.AllowUserToResizeRows = false;
            this.dgv_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_id,
            this.col_product_name,
            this.col_product_brand,
            this.col_product_category_id,
            this.col_product_category_name,
            this.col_product_unit_type,
            this.col_product_usage_type,
            this.col_product_unit_per_volume,
            this.col_btn_product_update,
            this.col_btn_product_delete});
            this.dgv_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_product.EnableHeadersVisualStyles = false;
            this.dgv_product.Location = new System.Drawing.Point(14, 14);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.Size = new System.Drawing.Size(1800, 794);
            this.dgv_product.TabIndex = 12;
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            // 
            // col_product_id
            // 
            this.col_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_id.HeaderText = "product_id";
            this.col_product_id.MinimumWidth = 6;
            this.col_product_id.Name = "col_product_id";
            this.col_product_id.ReadOnly = true;
            // 
            // col_product_name
            // 
            this.col_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_name.HeaderText = "Product";
            this.col_product_name.MinimumWidth = 6;
            this.col_product_name.Name = "col_product_name";
            this.col_product_name.ReadOnly = true;
            // 
            // col_product_brand
            // 
            this.col_product_brand.HeaderText = "Brand";
            this.col_product_brand.MinimumWidth = 6;
            this.col_product_brand.Name = "col_product_brand";
            this.col_product_brand.ReadOnly = true;
            this.col_product_brand.Width = 125;
            // 
            // col_product_category_id
            // 
            this.col_product_category_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_category_id.HeaderText = "category_id";
            this.col_product_category_id.MinimumWidth = 6;
            this.col_product_category_id.Name = "col_product_category_id";
            this.col_product_category_id.ReadOnly = true;
            // 
            // col_product_category_name
            // 
            this.col_product_category_name.HeaderText = "Category";
            this.col_product_category_name.MinimumWidth = 6;
            this.col_product_category_name.Name = "col_product_category_name";
            this.col_product_category_name.ReadOnly = true;
            this.col_product_category_name.Width = 125;
            // 
            // col_product_unit_type
            // 
            this.col_product_unit_type.HeaderText = "Unit Type";
            this.col_product_unit_type.MinimumWidth = 6;
            this.col_product_unit_type.Name = "col_product_unit_type";
            this.col_product_unit_type.ReadOnly = true;
            this.col_product_unit_type.Width = 125;
            // 
            // col_product_usage_type
            // 
            this.col_product_usage_type.HeaderText = "Usage Type";
            this.col_product_usage_type.MinimumWidth = 6;
            this.col_product_usage_type.Name = "col_product_usage_type";
            this.col_product_usage_type.ReadOnly = true;
            this.col_product_usage_type.Width = 125;
            // 
            // col_product_unit_per_volume
            // 
            this.col_product_unit_per_volume.HeaderText = "Unit per Volume";
            this.col_product_unit_per_volume.MinimumWidth = 6;
            this.col_product_unit_per_volume.Name = "col_product_unit_per_volume";
            this.col_product_unit_per_volume.ReadOnly = true;
            this.col_product_unit_per_volume.Width = 125;
            // 
            // col_btn_product_update
            // 
            this.col_btn_product_update.HeaderText = "Update";
            this.col_btn_product_update.Image = ((System.Drawing.Image)(resources.GetObject("col_btn_product_update.Image")));
            this.col_btn_product_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_btn_product_update.MinimumWidth = 6;
            this.col_btn_product_update.Name = "col_btn_product_update";
            this.col_btn_product_update.ReadOnly = true;
            this.col_btn_product_update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_btn_product_update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_btn_product_update.Width = 125;
            // 
            // col_btn_product_delete
            // 
            this.col_btn_product_delete.HeaderText = "Delete";
            this.col_btn_product_delete.Image = ((System.Drawing.Image)(resources.GetObject("col_btn_product_delete.Image")));
            this.col_btn_product_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_btn_product_delete.MinimumWidth = 6;
            this.col_btn_product_delete.Name = "col_btn_product_delete";
            this.col_btn_product_delete.ReadOnly = true;
            this.col_btn_product_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_btn_product_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_btn_product_delete.Width = 125;
            // 
            // materialCard18
            // 
            this.materialCard18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard18.Controls.Add(this.btn_add_product);
            this.materialCard18.Depth = 0;
            this.materialCard18.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard18.Location = new System.Drawing.Point(50, 50);
            this.materialCard18.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard18.Name = "materialCard18";
            this.materialCard18.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard18.Size = new System.Drawing.Size(1828, 75);
            this.materialCard18.TabIndex = 14;
            // 
            // btn_add_product
            // 
            this.btn_add_product.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_product.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_product.Depth = 0;
            this.btn_add_product.HighEmphasis = true;
            this.btn_add_product.Icon = null;
            this.btn_add_product.Location = new System.Drawing.Point(18, 6);
            this.btn_add_product.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_product.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_product.Size = new System.Drawing.Size(146, 36);
            this.btn_add_product.TabIndex = 13;
            this.btn_add_product.Text = "Create Product";
            this.btn_add_product.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_product.UseAccentColor = false;
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // servicesTab
            // 
            this.servicesTab.Controls.Add(this.materialCard21);
            this.servicesTab.Controls.Add(this.materialCard20);
            this.servicesTab.Location = new System.Drawing.Point(4, 34);
            this.servicesTab.Name = "servicesTab";
            this.servicesTab.Padding = new System.Windows.Forms.Padding(50);
            this.servicesTab.Size = new System.Drawing.Size(1928, 997);
            this.servicesTab.TabIndex = 7;
            this.servicesTab.Text = "Services";
            this.servicesTab.UseVisualStyleBackColor = true;
            // 
            // materialCard21
            // 
            this.materialCard21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard21.Controls.Add(this.dgv_service);
            this.materialCard21.Depth = 0;
            this.materialCard21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard21.Location = new System.Drawing.Point(50, 125);
            this.materialCard21.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard21.Name = "materialCard21";
            this.materialCard21.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard21.Size = new System.Drawing.Size(1828, 822);
            this.materialCard21.TabIndex = 17;
            // 
            // dgv_service
            // 
            this.dgv_service.AllowUserToAddRows = false;
            this.dgv_service.AllowUserToDeleteRows = false;
            this.dgv_service.AllowUserToResizeColumns = false;
            this.dgv_service.AllowUserToResizeRows = false;
            this.dgv_service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_service.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_service.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_service_id,
            this.col_service_name,
            this.col_service_cid,
            this.col_service_category_name,
            this.col_service_sid,
            this.col_service_subcategory,
            this.col_service_duration,
            this.col_service_status,
            this.col_service_product_usage,
            this.col_service_btn_update,
            this.col_service_btn_delete});
            this.dgv_service.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_service.EnableHeadersVisualStyles = false;
            this.dgv_service.Location = new System.Drawing.Point(14, 14);
            this.dgv_service.Name = "dgv_service";
            this.dgv_service.ReadOnly = true;
            this.dgv_service.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_service.RowHeadersVisible = false;
            this.dgv_service.RowHeadersWidth = 51;
            this.dgv_service.RowTemplate.Height = 24;
            this.dgv_service.Size = new System.Drawing.Size(1800, 794);
            this.dgv_service.TabIndex = 14;
            this.dgv_service.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_service_CellClick);
            // 
            // col_service_id
            // 
            this.col_service_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_id.HeaderText = "service_id";
            this.col_service_id.MinimumWidth = 6;
            this.col_service_id.Name = "col_service_id";
            this.col_service_id.ReadOnly = true;
            // 
            // col_service_name
            // 
            this.col_service_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_name.HeaderText = "Service";
            this.col_service_name.MinimumWidth = 6;
            this.col_service_name.Name = "col_service_name";
            this.col_service_name.ReadOnly = true;
            // 
            // col_service_cid
            // 
            this.col_service_cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_cid.HeaderText = "category_id";
            this.col_service_cid.MinimumWidth = 6;
            this.col_service_cid.Name = "col_service_cid";
            this.col_service_cid.ReadOnly = true;
            this.col_service_cid.Visible = false;
            // 
            // col_service_category_name
            // 
            this.col_service_category_name.HeaderText = "Category";
            this.col_service_category_name.MinimumWidth = 6;
            this.col_service_category_name.Name = "col_service_category_name";
            this.col_service_category_name.ReadOnly = true;
            this.col_service_category_name.Visible = false;
            this.col_service_category_name.Width = 125;
            // 
            // col_service_sid
            // 
            this.col_service_sid.HeaderText = "sub-category_id";
            this.col_service_sid.MinimumWidth = 6;
            this.col_service_sid.Name = "col_service_sid";
            this.col_service_sid.ReadOnly = true;
            this.col_service_sid.Visible = false;
            this.col_service_sid.Width = 125;
            // 
            // col_service_subcategory
            // 
            this.col_service_subcategory.HeaderText = "Sub-Category";
            this.col_service_subcategory.MinimumWidth = 6;
            this.col_service_subcategory.Name = "col_service_subcategory";
            this.col_service_subcategory.ReadOnly = true;
            this.col_service_subcategory.Width = 125;
            // 
            // col_service_duration
            // 
            this.col_service_duration.HeaderText = "Duration";
            this.col_service_duration.MinimumWidth = 6;
            this.col_service_duration.Name = "col_service_duration";
            this.col_service_duration.ReadOnly = true;
            this.col_service_duration.Width = 125;
            // 
            // col_service_status
            // 
            this.col_service_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_status.HeaderText = "Status";
            this.col_service_status.MinimumWidth = 6;
            this.col_service_status.Name = "col_service_status";
            this.col_service_status.ReadOnly = true;
            // 
            // col_service_product_usage
            // 
            this.col_service_product_usage.HeaderText = "Product Usage";
            this.col_service_product_usage.Image = ((System.Drawing.Image)(resources.GetObject("col_service_product_usage.Image")));
            this.col_service_product_usage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_service_product_usage.MinimumWidth = 6;
            this.col_service_product_usage.Name = "col_service_product_usage";
            this.col_service_product_usage.ReadOnly = true;
            this.col_service_product_usage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_service_product_usage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_service_product_usage.Width = 125;
            // 
            // col_service_btn_update
            // 
            this.col_service_btn_update.HeaderText = "Update";
            this.col_service_btn_update.Image = ((System.Drawing.Image)(resources.GetObject("col_service_btn_update.Image")));
            this.col_service_btn_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_service_btn_update.MinimumWidth = 6;
            this.col_service_btn_update.Name = "col_service_btn_update";
            this.col_service_btn_update.ReadOnly = true;
            this.col_service_btn_update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_service_btn_update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_service_btn_update.Width = 125;
            // 
            // col_service_btn_delete
            // 
            this.col_service_btn_delete.HeaderText = "Delete";
            this.col_service_btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("col_service_btn_delete.Image")));
            this.col_service_btn_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_service_btn_delete.MinimumWidth = 6;
            this.col_service_btn_delete.Name = "col_service_btn_delete";
            this.col_service_btn_delete.ReadOnly = true;
            this.col_service_btn_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_service_btn_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_service_btn_delete.Width = 125;
            // 
            // materialCard20
            // 
            this.materialCard20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard20.Controls.Add(this.btn_add_service);
            this.materialCard20.Depth = 0;
            this.materialCard20.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard20.Location = new System.Drawing.Point(50, 50);
            this.materialCard20.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard20.Name = "materialCard20";
            this.materialCard20.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard20.Size = new System.Drawing.Size(1828, 75);
            this.materialCard20.TabIndex = 16;
            // 
            // btn_add_service
            // 
            this.btn_add_service.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_service.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_service.Depth = 0;
            this.btn_add_service.HighEmphasis = true;
            this.btn_add_service.Icon = null;
            this.btn_add_service.Location = new System.Drawing.Point(18, 6);
            this.btn_add_service.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_service.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_service.Name = "btn_add_service";
            this.btn_add_service.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_service.Size = new System.Drawing.Size(137, 36);
            this.btn_add_service.TabIndex = 15;
            this.btn_add_service.Text = "Create Service";
            this.btn_add_service.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_service.UseAccentColor = false;
            this.btn_add_service.UseVisualStyleBackColor = true;
            this.btn_add_service.Click += new System.EventHandler(this.btn_add_service_Click);
            // 
            // deliveryTab
            // 
            this.deliveryTab.Controls.Add(this.materialCard27);
            this.deliveryTab.Controls.Add(this.materialCard26);
            this.deliveryTab.Location = new System.Drawing.Point(4, 34);
            this.deliveryTab.Name = "deliveryTab";
            this.deliveryTab.Padding = new System.Windows.Forms.Padding(50);
            this.deliveryTab.Size = new System.Drawing.Size(1928, 997);
            this.deliveryTab.TabIndex = 13;
            this.deliveryTab.Text = "Delivery";
            this.deliveryTab.UseVisualStyleBackColor = true;
            // 
            // materialCard27
            // 
            this.materialCard27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard27.Controls.Add(this.dgv_delivery);
            this.materialCard27.Depth = 0;
            this.materialCard27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard27.Location = new System.Drawing.Point(50, 125);
            this.materialCard27.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard27.Name = "materialCard27";
            this.materialCard27.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard27.Size = new System.Drawing.Size(1828, 822);
            this.materialCard27.TabIndex = 19;
            // 
            // dgv_delivery
            // 
            this.dgv_delivery.AllowUserToAddRows = false;
            this.dgv_delivery.AllowUserToDeleteRows = false;
            this.dgv_delivery.AllowUserToResizeColumns = false;
            this.dgv_delivery.AllowUserToResizeRows = false;
            this.dgv_delivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_delivery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_delivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_delivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_delivery_id,
            this.col_delivery_supplier_id,
            this.col_delivery_supplier,
            this.col_delivery_date,
            this.col_delivery_invoice,
            this.col_delivery_received_by,
            this.col_delivery_view_items});
            this.dgv_delivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_delivery.EnableHeadersVisualStyles = false;
            this.dgv_delivery.Location = new System.Drawing.Point(14, 14);
            this.dgv_delivery.Name = "dgv_delivery";
            this.dgv_delivery.ReadOnly = true;
            this.dgv_delivery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_delivery.RowHeadersVisible = false;
            this.dgv_delivery.RowHeadersWidth = 51;
            this.dgv_delivery.RowTemplate.Height = 24;
            this.dgv_delivery.Size = new System.Drawing.Size(1800, 794);
            this.dgv_delivery.TabIndex = 16;
            this.dgv_delivery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_delivery_CellClick);
            // 
            // col_delivery_id
            // 
            this.col_delivery_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_delivery_id.HeaderText = "ID";
            this.col_delivery_id.MinimumWidth = 6;
            this.col_delivery_id.Name = "col_delivery_id";
            this.col_delivery_id.ReadOnly = true;
            // 
            // col_delivery_supplier_id
            // 
            this.col_delivery_supplier_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_delivery_supplier_id.HeaderText = "supplier_id";
            this.col_delivery_supplier_id.MinimumWidth = 6;
            this.col_delivery_supplier_id.Name = "col_delivery_supplier_id";
            this.col_delivery_supplier_id.ReadOnly = true;
            this.col_delivery_supplier_id.Visible = false;
            // 
            // col_delivery_supplier
            // 
            this.col_delivery_supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_delivery_supplier.HeaderText = "Supplier ";
            this.col_delivery_supplier.MinimumWidth = 6;
            this.col_delivery_supplier.Name = "col_delivery_supplier";
            this.col_delivery_supplier.ReadOnly = true;
            // 
            // col_delivery_date
            // 
            this.col_delivery_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_delivery_date.HeaderText = "Delivered Date";
            this.col_delivery_date.MinimumWidth = 6;
            this.col_delivery_date.Name = "col_delivery_date";
            this.col_delivery_date.ReadOnly = true;
            // 
            // col_delivery_invoice
            // 
            this.col_delivery_invoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_delivery_invoice.HeaderText = "Invoice";
            this.col_delivery_invoice.MinimumWidth = 6;
            this.col_delivery_invoice.Name = "col_delivery_invoice";
            this.col_delivery_invoice.ReadOnly = true;
            // 
            // col_delivery_received_by
            // 
            this.col_delivery_received_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_delivery_received_by.HeaderText = "Received By";
            this.col_delivery_received_by.MinimumWidth = 6;
            this.col_delivery_received_by.Name = "col_delivery_received_by";
            this.col_delivery_received_by.ReadOnly = true;
            // 
            // col_delivery_view_items
            // 
            this.col_delivery_view_items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_delivery_view_items.HeaderText = "";
            this.col_delivery_view_items.Image = ((System.Drawing.Image)(resources.GetObject("col_delivery_view_items.Image")));
            this.col_delivery_view_items.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_delivery_view_items.MinimumWidth = 6;
            this.col_delivery_view_items.Name = "col_delivery_view_items";
            this.col_delivery_view_items.ReadOnly = true;
            this.col_delivery_view_items.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_delivery_view_items.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // materialCard26
            // 
            this.materialCard26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard26.Controls.Add(this.btn_add_delivery);
            this.materialCard26.Depth = 0;
            this.materialCard26.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard26.Location = new System.Drawing.Point(50, 50);
            this.materialCard26.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard26.Name = "materialCard26";
            this.materialCard26.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard26.Size = new System.Drawing.Size(1828, 75);
            this.materialCard26.TabIndex = 18;
            // 
            // btn_add_delivery
            // 
            this.btn_add_delivery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_delivery.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_delivery.Depth = 0;
            this.btn_add_delivery.HighEmphasis = true;
            this.btn_add_delivery.Icon = null;
            this.btn_add_delivery.Location = new System.Drawing.Point(18, 6);
            this.btn_add_delivery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_delivery.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_delivery.Name = "btn_add_delivery";
            this.btn_add_delivery.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_delivery.Size = new System.Drawing.Size(146, 36);
            this.btn_add_delivery.TabIndex = 17;
            this.btn_add_delivery.Text = "Create Delivery";
            this.btn_add_delivery.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_delivery.UseAccentColor = false;
            this.btn_add_delivery.UseVisualStyleBackColor = true;
            this.btn_add_delivery.Click += new System.EventHandler(this.btn_add_delivery_Click);
            // 
            // priceTab
            // 
            this.priceTab.Controls.Add(this.materialCard29);
            this.priceTab.Controls.Add(this.materialCard28);
            this.priceTab.Location = new System.Drawing.Point(4, 34);
            this.priceTab.Name = "priceTab";
            this.priceTab.Padding = new System.Windows.Forms.Padding(50);
            this.priceTab.Size = new System.Drawing.Size(1928, 997);
            this.priceTab.TabIndex = 15;
            this.priceTab.Text = "Service Price";
            this.priceTab.UseVisualStyleBackColor = true;
            // 
            // materialCard29
            // 
            this.materialCard29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard29.Controls.Add(this.dgv_service_price);
            this.materialCard29.Depth = 0;
            this.materialCard29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard29.Location = new System.Drawing.Point(50, 125);
            this.materialCard29.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard29.Name = "materialCard29";
            this.materialCard29.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard29.Size = new System.Drawing.Size(1828, 822);
            this.materialCard29.TabIndex = 19;
            // 
            // dgv_service_price
            // 
            this.dgv_service_price.AllowDrop = true;
            this.dgv_service_price.AllowUserToAddRows = false;
            this.dgv_service_price.AllowUserToDeleteRows = false;
            this.dgv_service_price.AllowUserToResizeColumns = false;
            this.dgv_service_price.AllowUserToResizeRows = false;
            this.dgv_service_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_service_price.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_service_price.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_service_price.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_service_price.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_price_id,
            this.col_service_price_name,
            this.col_service_product_id,
            this.col_product_cost,
            this.col_stylist_cost,
            this.col_overhead_cost,
            this.col_total_cost,
            this.col_selling_price,
            this.col_vat_amount,
            this.col_net_price,
            this.col_net_profit,
            this.col_gross_profit,
            this.col_profit_percent,
            this.col_price_update,
            this.col_price_delete});
            this.dgv_service_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_service_price.EnableHeadersVisualStyles = false;
            this.dgv_service_price.Location = new System.Drawing.Point(14, 14);
            this.dgv_service_price.Name = "dgv_service_price";
            this.dgv_service_price.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_service_price.RowHeadersVisible = false;
            this.dgv_service_price.RowHeadersWidth = 51;
            this.dgv_service_price.RowTemplate.Height = 24;
            this.dgv_service_price.Size = new System.Drawing.Size(1800, 794);
            this.dgv_service_price.TabIndex = 16;
            this.dgv_service_price.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_service_price_CellClick);
            // 
            // col_price_id
            // 
            this.col_price_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_price_id.HeaderText = "price_id";
            this.col_price_id.MinimumWidth = 6;
            this.col_price_id.Name = "col_price_id";
            this.col_price_id.Visible = false;
            // 
            // col_service_price_name
            // 
            this.col_service_price_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_price_name.HeaderText = "Service";
            this.col_service_price_name.MinimumWidth = 6;
            this.col_service_price_name.Name = "col_service_price_name";
            // 
            // col_service_product_id
            // 
            this.col_service_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_service_product_id.HeaderText = "service_product_id";
            this.col_service_product_id.MinimumWidth = 6;
            this.col_service_product_id.Name = "col_service_product_id";
            this.col_service_product_id.Visible = false;
            // 
            // col_product_cost
            // 
            this.col_product_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product_cost.HeaderText = "Product Cost";
            this.col_product_cost.MinimumWidth = 6;
            this.col_product_cost.Name = "col_product_cost";
            // 
            // col_stylist_cost
            // 
            this.col_stylist_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_stylist_cost.HeaderText = "Stylist Cost";
            this.col_stylist_cost.MinimumWidth = 6;
            this.col_stylist_cost.Name = "col_stylist_cost";
            this.col_stylist_cost.Visible = false;
            // 
            // col_overhead_cost
            // 
            this.col_overhead_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_overhead_cost.HeaderText = "OverHeadCost";
            this.col_overhead_cost.MinimumWidth = 6;
            this.col_overhead_cost.Name = "col_overhead_cost";
            // 
            // col_total_cost
            // 
            this.col_total_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_total_cost.HeaderText = "Total Cost";
            this.col_total_cost.MinimumWidth = 6;
            this.col_total_cost.Name = "col_total_cost";
            // 
            // col_selling_price
            // 
            this.col_selling_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_selling_price.HeaderText = "Selling Price";
            this.col_selling_price.MinimumWidth = 6;
            this.col_selling_price.Name = "col_selling_price";
            // 
            // col_vat_amount
            // 
            this.col_vat_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_vat_amount.HeaderText = "Vat Amount";
            this.col_vat_amount.MinimumWidth = 6;
            this.col_vat_amount.Name = "col_vat_amount";
            // 
            // col_net_price
            // 
            this.col_net_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_net_price.HeaderText = "Net Price";
            this.col_net_price.MinimumWidth = 6;
            this.col_net_price.Name = "col_net_price";
            this.col_net_price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_net_profit
            // 
            this.col_net_profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_net_profit.HeaderText = "Net Profit";
            this.col_net_profit.MinimumWidth = 6;
            this.col_net_profit.Name = "col_net_profit";
            this.col_net_profit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_gross_profit
            // 
            this.col_gross_profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_gross_profit.HeaderText = "Gross Profit";
            this.col_gross_profit.MinimumWidth = 6;
            this.col_gross_profit.Name = "col_gross_profit";
            // 
            // col_profit_percent
            // 
            this.col_profit_percent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_profit_percent.HeaderText = "Profit Percent";
            this.col_profit_percent.MinimumWidth = 6;
            this.col_profit_percent.Name = "col_profit_percent";
            // 
            // col_price_update
            // 
            this.col_price_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_price_update.HeaderText = "";
            this.col_price_update.Image = ((System.Drawing.Image)(resources.GetObject("col_price_update.Image")));
            this.col_price_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_price_update.MinimumWidth = 6;
            this.col_price_update.Name = "col_price_update";
            // 
            // col_price_delete
            // 
            this.col_price_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_price_delete.HeaderText = "";
            this.col_price_delete.Image = ((System.Drawing.Image)(resources.GetObject("col_price_delete.Image")));
            this.col_price_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_price_delete.MinimumWidth = 6;
            this.col_price_delete.Name = "col_price_delete";
            // 
            // materialCard28
            // 
            this.materialCard28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard28.Controls.Add(this.btn_add_price);
            this.materialCard28.Depth = 0;
            this.materialCard28.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard28.Location = new System.Drawing.Point(50, 50);
            this.materialCard28.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard28.Name = "materialCard28";
            this.materialCard28.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard28.Size = new System.Drawing.Size(1828, 75);
            this.materialCard28.TabIndex = 18;
            // 
            // btn_add_price
            // 
            this.btn_add_price.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_price.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_price.Depth = 0;
            this.btn_add_price.HighEmphasis = true;
            this.btn_add_price.Icon = null;
            this.btn_add_price.Location = new System.Drawing.Point(18, 6);
            this.btn_add_price.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_price.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_price.Name = "btn_add_price";
            this.btn_add_price.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_price.Size = new System.Drawing.Size(182, 36);
            this.btn_add_price.TabIndex = 17;
            this.btn_add_price.Text = "Create Service Price";
            this.btn_add_price.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_price.UseAccentColor = false;
            this.btn_add_price.UseVisualStyleBackColor = true;
            this.btn_add_price.Click += new System.EventHandler(this.btn_add_price_Click);
            // 
            // inventoryTab
            // 
            this.inventoryTab.Controls.Add(this.inventoryTabControl);
            this.inventoryTab.Controls.Add(this.materialTabSelector2);
            this.inventoryTab.Location = new System.Drawing.Point(4, 34);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Size = new System.Drawing.Size(1928, 997);
            this.inventoryTab.TabIndex = 14;
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.UseVisualStyleBackColor = true;
            // 
            // inventoryTabControl
            // 
            this.inventoryTabControl.Controls.Add(this.inventory);
            this.inventoryTabControl.Controls.Add(this.batch_inventory);
            this.inventoryTabControl.Depth = 0;
            this.inventoryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryTabControl.Location = new System.Drawing.Point(0, 50);
            this.inventoryTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.inventoryTabControl.Multiline = true;
            this.inventoryTabControl.Name = "inventoryTabControl";
            this.inventoryTabControl.SelectedIndex = 0;
            this.inventoryTabControl.Size = new System.Drawing.Size(1928, 947);
            this.inventoryTabControl.TabIndex = 1;
            // 
            // inventory
            // 
            this.inventory.Controls.Add(this.dgv_inventory);
            this.inventory.Location = new System.Drawing.Point(4, 34);
            this.inventory.Name = "inventory";
            this.inventory.Padding = new System.Windows.Forms.Padding(3);
            this.inventory.Size = new System.Drawing.Size(1920, 909);
            this.inventory.TabIndex = 0;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = true;
            // 
            // dgv_inventory
            // 
            this.dgv_inventory.AllowUserToAddRows = false;
            this.dgv_inventory.AllowUserToDeleteRows = false;
            this.dgv_inventory.AllowUserToResizeColumns = false;
            this.dgv_inventory.AllowUserToResizeRows = false;
            this.dgv_inventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_inventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_InventoryID,
            this.col_ProductID,
            this.col_ProductName,
            this.col_Brand,
            this.col_Category,
            this.col_Unit,
            this.col_volume_per_unit,
            this.col_Volume,
            this.col_Critical_Level,
            this.col_Status});
            this.dgv_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_inventory.EnableHeadersVisualStyles = false;
            this.dgv_inventory.Location = new System.Drawing.Point(3, 3);
            this.dgv_inventory.Name = "dgv_inventory";
            this.dgv_inventory.ReadOnly = true;
            this.dgv_inventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_inventory.RowHeadersVisible = false;
            this.dgv_inventory.RowHeadersWidth = 51;
            this.dgv_inventory.RowTemplate.Height = 24;
            this.dgv_inventory.Size = new System.Drawing.Size(1914, 903);
            this.dgv_inventory.TabIndex = 16;
            // 
            // col_InventoryID
            // 
            this.col_InventoryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_InventoryID.HeaderText = "#";
            this.col_InventoryID.MinimumWidth = 6;
            this.col_InventoryID.Name = "col_InventoryID";
            this.col_InventoryID.ReadOnly = true;
            // 
            // col_ProductID
            // 
            this.col_ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ProductID.HeaderText = "product_id";
            this.col_ProductID.MinimumWidth = 6;
            this.col_ProductID.Name = "col_ProductID";
            this.col_ProductID.ReadOnly = true;
            // 
            // col_ProductName
            // 
            this.col_ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ProductName.HeaderText = "Product Name";
            this.col_ProductName.MinimumWidth = 6;
            this.col_ProductName.Name = "col_ProductName";
            this.col_ProductName.ReadOnly = true;
            this.col_ProductName.Visible = false;
            // 
            // col_Brand
            // 
            this.col_Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Brand.HeaderText = "Brand";
            this.col_Brand.MinimumWidth = 6;
            this.col_Brand.Name = "col_Brand";
            this.col_Brand.ReadOnly = true;
            this.col_Brand.Visible = false;
            // 
            // col_Category
            // 
            this.col_Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Category.HeaderText = "Category";
            this.col_Category.MinimumWidth = 6;
            this.col_Category.Name = "col_Category";
            this.col_Category.ReadOnly = true;
            this.col_Category.Visible = false;
            // 
            // col_Unit
            // 
            this.col_Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Unit.HeaderText = "Unit";
            this.col_Unit.MinimumWidth = 6;
            this.col_Unit.Name = "col_Unit";
            this.col_Unit.ReadOnly = true;
            // 
            // col_volume_per_unit
            // 
            this.col_volume_per_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_volume_per_unit.HeaderText = "Volume per Unit";
            this.col_volume_per_unit.MinimumWidth = 6;
            this.col_volume_per_unit.Name = "col_volume_per_unit";
            this.col_volume_per_unit.ReadOnly = true;
            // 
            // col_Volume
            // 
            this.col_Volume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Volume.HeaderText = "Volume";
            this.col_Volume.MinimumWidth = 6;
            this.col_Volume.Name = "col_Volume";
            this.col_Volume.ReadOnly = true;
            // 
            // col_Critical_Level
            // 
            this.col_Critical_Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Critical_Level.HeaderText = "Critical Level";
            this.col_Critical_Level.MinimumWidth = 6;
            this.col_Critical_Level.Name = "col_Critical_Level";
            this.col_Critical_Level.ReadOnly = true;
            this.col_Critical_Level.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_Status
            // 
            this.col_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Status.HeaderText = "Status";
            this.col_Status.MinimumWidth = 6;
            this.col_Status.Name = "col_Status";
            this.col_Status.ReadOnly = true;
            this.col_Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // batch_inventory
            // 
            this.batch_inventory.Controls.Add(this.dgv_BatchInventory);
            this.batch_inventory.Location = new System.Drawing.Point(4, 34);
            this.batch_inventory.Name = "batch_inventory";
            this.batch_inventory.Padding = new System.Windows.Forms.Padding(3);
            this.batch_inventory.Size = new System.Drawing.Size(1920, 909);
            this.batch_inventory.TabIndex = 1;
            this.batch_inventory.Text = "Batch Inventory";
            this.batch_inventory.UseVisualStyleBackColor = true;
            // 
            // dgv_BatchInventory
            // 
            this.dgv_BatchInventory.AllowUserToAddRows = false;
            this.dgv_BatchInventory.AllowUserToDeleteRows = false;
            this.dgv_BatchInventory.AllowUserToResizeColumns = false;
            this.dgv_BatchInventory.AllowUserToResizeRows = false;
            this.dgv_BatchInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_BatchInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_BatchInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_BatchInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BatchInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BatchID,
            this.col_DeliveryItemID,
            this.col_ProdName,
            this.col_Quantity,
            this.col_volume_per_qtn,
            this.col_vol,
            this.col_price,
            this.col_notes,
            this.col_ExpiryDate,
            this.col_DateReceived});
            this.dgv_BatchInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BatchInventory.EnableHeadersVisualStyles = false;
            this.dgv_BatchInventory.Location = new System.Drawing.Point(3, 3);
            this.dgv_BatchInventory.Name = "dgv_BatchInventory";
            this.dgv_BatchInventory.ReadOnly = true;
            this.dgv_BatchInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_BatchInventory.RowHeadersVisible = false;
            this.dgv_BatchInventory.RowHeadersWidth = 51;
            this.dgv_BatchInventory.RowTemplate.Height = 24;
            this.dgv_BatchInventory.Size = new System.Drawing.Size(1914, 903);
            this.dgv_BatchInventory.TabIndex = 17;
            // 
            // col_BatchID
            // 
            this.col_BatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_BatchID.HeaderText = "#";
            this.col_BatchID.MinimumWidth = 6;
            this.col_BatchID.Name = "col_BatchID";
            this.col_BatchID.ReadOnly = true;
            // 
            // col_DeliveryItemID
            // 
            this.col_DeliveryItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DeliveryItemID.HeaderText = "";
            this.col_DeliveryItemID.MinimumWidth = 6;
            this.col_DeliveryItemID.Name = "col_DeliveryItemID";
            this.col_DeliveryItemID.ReadOnly = true;
            // 
            // col_ProdName
            // 
            this.col_ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ProdName.HeaderText = "Product Name";
            this.col_ProdName.MinimumWidth = 6;
            this.col_ProdName.Name = "col_ProdName";
            this.col_ProdName.ReadOnly = true;
            this.col_ProdName.Visible = false;
            // 
            // col_Quantity
            // 
            this.col_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Quantity.HeaderText = "Quantity";
            this.col_Quantity.MinimumWidth = 6;
            this.col_Quantity.Name = "col_Quantity";
            this.col_Quantity.ReadOnly = true;
            this.col_Quantity.Visible = false;
            // 
            // col_volume_per_qtn
            // 
            this.col_volume_per_qtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_volume_per_qtn.HeaderText = "Volume per Unit";
            this.col_volume_per_qtn.MinimumWidth = 6;
            this.col_volume_per_qtn.Name = "col_volume_per_qtn";
            this.col_volume_per_qtn.ReadOnly = true;
            this.col_volume_per_qtn.Visible = false;
            // 
            // col_vol
            // 
            this.col_vol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_vol.HeaderText = "Volume";
            this.col_vol.MinimumWidth = 6;
            this.col_vol.Name = "col_vol";
            this.col_vol.ReadOnly = true;
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_price.HeaderText = "Price";
            this.col_price.MinimumWidth = 6;
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            // 
            // col_notes
            // 
            this.col_notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_notes.HeaderText = "Notes";
            this.col_notes.MinimumWidth = 6;
            this.col_notes.Name = "col_notes";
            this.col_notes.ReadOnly = true;
            // 
            // col_ExpiryDate
            // 
            this.col_ExpiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ExpiryDate.HeaderText = "Expiration Date";
            this.col_ExpiryDate.MinimumWidth = 6;
            this.col_ExpiryDate.Name = "col_ExpiryDate";
            this.col_ExpiryDate.ReadOnly = true;
            this.col_ExpiryDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_DateReceived
            // 
            this.col_DateReceived.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DateReceived.HeaderText = "Date Received";
            this.col_DateReceived.MinimumWidth = 6;
            this.col_DateReceived.Name = "col_DateReceived";
            this.col_DateReceived.ReadOnly = true;
            this.col_DateReceived.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.inventoryTabControl;
            this.materialTabSelector2.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1928, 50);
            this.materialTabSelector2.TabIndex = 0;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // appointmentTab
            // 
            this.appointmentTab.Controls.Add(this.materialCard23);
            this.appointmentTab.Controls.Add(this.materialCard22);
            this.appointmentTab.Location = new System.Drawing.Point(4, 34);
            this.appointmentTab.Name = "appointmentTab";
            this.appointmentTab.Padding = new System.Windows.Forms.Padding(50);
            this.appointmentTab.Size = new System.Drawing.Size(1928, 997);
            this.appointmentTab.TabIndex = 8;
            this.appointmentTab.Text = "Appointment";
            this.appointmentTab.UseVisualStyleBackColor = true;
            // 
            // materialCard23
            // 
            this.materialCard23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard23.Controls.Add(this.dgv_appointment);
            this.materialCard23.Depth = 0;
            this.materialCard23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard23.Location = new System.Drawing.Point(50, 125);
            this.materialCard23.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard23.Name = "materialCard23";
            this.materialCard23.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard23.Size = new System.Drawing.Size(1828, 822);
            this.materialCard23.TabIndex = 17;
            // 
            // dgv_appointment
            // 
            this.dgv_appointment.AllowDrop = true;
            this.dgv_appointment.AllowUserToAddRows = false;
            this.dgv_appointment.AllowUserToDeleteRows = false;
            this.dgv_appointment.AllowUserToResizeColumns = false;
            this.dgv_appointment.AllowUserToResizeRows = false;
            this.dgv_appointment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_appointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_appointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_appointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointment_id,
            this.customer_id,
            this.customerName,
            this.stylist_id,
            this.stylistName,
            this.date,
            this.startTime,
            this.endTime,
            this.status,
            this.paymentStatus,
            this.col_book_type,
            this.col_assign_staff,
            this.col_pay,
            this.col_appointment_status});
            this.dgv_appointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_appointment.EnableHeadersVisualStyles = false;
            this.dgv_appointment.Location = new System.Drawing.Point(14, 14);
            this.dgv_appointment.Name = "dgv_appointment";
            this.dgv_appointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_appointment.RowHeadersVisible = false;
            this.dgv_appointment.RowHeadersWidth = 51;
            this.dgv_appointment.RowTemplate.Height = 24;
            this.dgv_appointment.Size = new System.Drawing.Size(1800, 794);
            this.dgv_appointment.TabIndex = 14;
            this.dgv_appointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_appointment_CellClick);
            // 
            // appointment_id
            // 
            this.appointment_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appointment_id.HeaderText = "app_id";
            this.appointment_id.MinimumWidth = 6;
            this.appointment_id.Name = "appointment_id";
            this.appointment_id.Visible = false;
            // 
            // customer_id
            // 
            this.customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_id.HeaderText = "customer_id";
            this.customer_id.MinimumWidth = 6;
            this.customer_id.Name = "customer_id";
            this.customer_id.Visible = false;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerName.HeaderText = "Client Name";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            // 
            // stylist_id
            // 
            this.stylist_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stylist_id.HeaderText = "stylist_id";
            this.stylist_id.MinimumWidth = 6;
            this.stylist_id.Name = "stylist_id";
            this.stylist_id.Visible = false;
            // 
            // stylistName
            // 
            this.stylistName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stylistName.HeaderText = "Stylist Name";
            this.stylistName.MinimumWidth = 6;
            this.stylistName.Name = "stylistName";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // startTime
            // 
            this.startTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startTime.HeaderText = "Start Time";
            this.startTime.MinimumWidth = 6;
            this.startTime.Name = "startTime";
            // 
            // endTime
            // 
            this.endTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endTime.HeaderText = "End TIme";
            this.endTime.MinimumWidth = 6;
            this.endTime.Name = "endTime";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // paymentStatus
            // 
            this.paymentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paymentStatus.HeaderText = "Payment Status";
            this.paymentStatus.MinimumWidth = 6;
            this.paymentStatus.Name = "paymentStatus";
            this.paymentStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_book_type
            // 
            this.col_book_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_book_type.HeaderText = "Booking Type";
            this.col_book_type.MinimumWidth = 6;
            this.col_book_type.Name = "col_book_type";
            // 
            // col_assign_staff
            // 
            this.col_assign_staff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_assign_staff.HeaderText = "Assign Stylist";
            this.col_assign_staff.Image = ((System.Drawing.Image)(resources.GetObject("col_assign_staff.Image")));
            this.col_assign_staff.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_assign_staff.MinimumWidth = 6;
            this.col_assign_staff.Name = "col_assign_staff";
            // 
            // col_pay
            // 
            this.col_pay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_pay.HeaderText = "Process Payment";
            this.col_pay.Image = ((System.Drawing.Image)(resources.GetObject("col_pay.Image")));
            this.col_pay.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_pay.MinimumWidth = 6;
            this.col_pay.Name = "col_pay";
            // 
            // col_appointment_status
            // 
            this.col_appointment_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_appointment_status.HeaderText = "Mark Status";
            this.col_appointment_status.Image = ((System.Drawing.Image)(resources.GetObject("col_appointment_status.Image")));
            this.col_appointment_status.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_appointment_status.MinimumWidth = 6;
            this.col_appointment_status.Name = "col_appointment_status";
            this.col_appointment_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_appointment_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // materialCard22
            // 
            this.materialCard22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard22.Controls.Add(this.btn_add_appointment);
            this.materialCard22.Depth = 0;
            this.materialCard22.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard22.Location = new System.Drawing.Point(50, 50);
            this.materialCard22.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard22.Name = "materialCard22";
            this.materialCard22.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard22.Size = new System.Drawing.Size(1828, 75);
            this.materialCard22.TabIndex = 16;
            // 
            // btn_add_appointment
            // 
            this.btn_add_appointment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_appointment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_appointment.Depth = 0;
            this.btn_add_appointment.HighEmphasis = true;
            this.btn_add_appointment.Icon = null;
            this.btn_add_appointment.Location = new System.Drawing.Point(18, 6);
            this.btn_add_appointment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_appointment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_appointment.Name = "btn_add_appointment";
            this.btn_add_appointment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_appointment.Size = new System.Drawing.Size(182, 36);
            this.btn_add_appointment.TabIndex = 15;
            this.btn_add_appointment.Text = "Create Appointment";
            this.btn_add_appointment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_appointment.UseAccentColor = false;
            this.btn_add_appointment.UseVisualStyleBackColor = true;
            this.btn_add_appointment.Click += new System.EventHandler(this.btn_add_appointment_Click);
            // 
            // reportsTab
            // 
            this.reportsTab.Controls.Add(this.reportsTabControl);
            this.reportsTab.Controls.Add(this.materialTabSelector3);
            this.reportsTab.Location = new System.Drawing.Point(4, 34);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Padding = new System.Windows.Forms.Padding(50);
            this.reportsTab.Size = new System.Drawing.Size(1928, 997);
            this.reportsTab.TabIndex = 9;
            this.reportsTab.Text = "Reports";
            this.reportsTab.UseVisualStyleBackColor = true;
            // 
            // reportsTabControl
            // 
            this.reportsTabControl.Controls.Add(this.SalesTabPage);
            this.reportsTabControl.Controls.Add(this.inventoryTabPage);
            this.reportsTabControl.Controls.Add(this.expenseTabPage);
            this.reportsTabControl.Depth = 0;
            this.reportsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsTabControl.Location = new System.Drawing.Point(50, 100);
            this.reportsTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.reportsTabControl.Multiline = true;
            this.reportsTabControl.Name = "reportsTabControl";
            this.reportsTabControl.SelectedIndex = 0;
            this.reportsTabControl.Size = new System.Drawing.Size(1828, 847);
            this.reportsTabControl.TabIndex = 1;
            // 
            // SalesTabPage
            // 
            this.SalesTabPage.Controls.Add(this.panel5);
            this.SalesTabPage.Controls.Add(this.materialCard8);
            this.SalesTabPage.Location = new System.Drawing.Point(4, 34);
            this.SalesTabPage.Name = "SalesTabPage";
            this.SalesTabPage.Padding = new System.Windows.Forms.Padding(25);
            this.SalesTabPage.Size = new System.Drawing.Size(1820, 809);
            this.SalesTabPage.TabIndex = 0;
            this.SalesTabPage.Text = "Sales";
            this.SalesTabPage.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgv_report_table);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(25, 381);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panel5.Size = new System.Drawing.Size(1770, 403);
            this.panel5.TabIndex = 1;
            // 
            // dgv_report_table
            // 
            this.dgv_report_table.AllowUserToAddRows = false;
            this.dgv_report_table.AllowUserToDeleteRows = false;
            this.dgv_report_table.AllowUserToResizeColumns = false;
            this.dgv_report_table.AllowUserToResizeRows = false;
            this.dgv_report_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_report_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_report_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_report_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_transaction_id,
            this.col_report_appointment_id,
            this.col_report_vat_amount,
            this.col_report_discount_amount,
            this.col_report_amount_paid,
            this.col_report_payment_method,
            this.col_report_date});
            this.dgv_report_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_report_table.EnableHeadersVisualStyles = false;
            this.dgv_report_table.Location = new System.Drawing.Point(0, 25);
            this.dgv_report_table.Name = "dgv_report_table";
            this.dgv_report_table.ReadOnly = true;
            this.dgv_report_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_report_table.RowHeadersVisible = false;
            this.dgv_report_table.RowHeadersWidth = 51;
            this.dgv_report_table.RowTemplate.Height = 24;
            this.dgv_report_table.Size = new System.Drawing.Size(1770, 378);
            this.dgv_report_table.TabIndex = 0;
            // 
            // col_transaction_id
            // 
            this.col_transaction_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_transaction_id.HeaderText = "transaction_id";
            this.col_transaction_id.MinimumWidth = 6;
            this.col_transaction_id.Name = "col_transaction_id";
            this.col_transaction_id.ReadOnly = true;
            // 
            // col_report_appointment_id
            // 
            this.col_report_appointment_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_report_appointment_id.HeaderText = "appointment_id";
            this.col_report_appointment_id.MinimumWidth = 6;
            this.col_report_appointment_id.Name = "col_report_appointment_id";
            this.col_report_appointment_id.ReadOnly = true;
            this.col_report_appointment_id.Visible = false;
            // 
            // col_report_vat_amount
            // 
            this.col_report_vat_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_report_vat_amount.HeaderText = "Vat Amount";
            this.col_report_vat_amount.MinimumWidth = 6;
            this.col_report_vat_amount.Name = "col_report_vat_amount";
            this.col_report_vat_amount.ReadOnly = true;
            // 
            // col_report_discount_amount
            // 
            this.col_report_discount_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_report_discount_amount.HeaderText = "Discount Amount";
            this.col_report_discount_amount.MinimumWidth = 6;
            this.col_report_discount_amount.Name = "col_report_discount_amount";
            this.col_report_discount_amount.ReadOnly = true;
            // 
            // col_report_amount_paid
            // 
            this.col_report_amount_paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_report_amount_paid.HeaderText = "Amount Paid";
            this.col_report_amount_paid.MinimumWidth = 6;
            this.col_report_amount_paid.Name = "col_report_amount_paid";
            this.col_report_amount_paid.ReadOnly = true;
            // 
            // col_report_payment_method
            // 
            this.col_report_payment_method.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_report_payment_method.HeaderText = "Payment Method";
            this.col_report_payment_method.MinimumWidth = 6;
            this.col_report_payment_method.Name = "col_report_payment_method";
            this.col_report_payment_method.ReadOnly = true;
            // 
            // col_report_date
            // 
            this.col_report_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_report_date.HeaderText = "Date";
            this.col_report_date.MinimumWidth = 6;
            this.col_report_date.Name = "col_report_date";
            this.col_report_date.ReadOnly = true;
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.btn_export_pdf);
            this.materialCard8.Controls.Add(this.materialLabel13);
            this.materialCard8.Controls.Add(this.btn_report_clear);
            this.materialCard8.Controls.Add(this.btn_report_filter);
            this.materialCard8.Controls.Add(this.lbl_report_total_gcash);
            this.materialCard8.Controls.Add(this.lbl_report_total_discount);
            this.materialCard8.Controls.Add(this.lbl_report_total_vat);
            this.materialCard8.Controls.Add(this.lbl_report_total_sales);
            this.materialCard8.Controls.Add(this.lbl_report_total_cash);
            this.materialCard8.Controls.Add(this.lbl_report_total_transaction);
            this.materialCard8.Controls.Add(this.materialLabel12);
            this.materialCard8.Controls.Add(this.materialLabel11);
            this.materialCard8.Controls.Add(this.materialLabel10);
            this.materialCard8.Controls.Add(this.materialLabel9);
            this.materialCard8.Controls.Add(this.materialLabel8);
            this.materialCard8.Controls.Add(this.materialLabel7);
            this.materialCard8.Controls.Add(this.materialLabel6);
            this.materialCard8.Controls.Add(this.dtp_report_end_date);
            this.materialCard8.Controls.Add(this.dtp_report_start_date);
            this.materialCard8.Controls.Add(this.cmb_sales_report_range);
            this.materialCard8.Depth = 0;
            this.materialCard8.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(25, 25);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(1770, 356);
            this.materialCard8.TabIndex = 0;
            // 
            // btn_export_pdf
            // 
            this.btn_export_pdf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export_pdf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_export_pdf.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_export_pdf.Depth = 0;
            this.btn_export_pdf.HighEmphasis = true;
            this.btn_export_pdf.Icon = null;
            this.btn_export_pdf.Location = new System.Drawing.Point(1474, 300);
            this.btn_export_pdf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_export_pdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_export_pdf.Name = "btn_export_pdf";
            this.btn_export_pdf.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_export_pdf.Size = new System.Drawing.Size(108, 36);
            this.btn_export_pdf.TabIndex = 19;
            this.btn_export_pdf.Text = "Export PDF";
            this.btn_export_pdf.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_export_pdf.UseAccentColor = false;
            this.btn_export_pdf.UseVisualStyleBackColor = true;
            // 
            // materialLabel13
            // 
            this.materialLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel13.Location = new System.Drawing.Point(1143, 35);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(24, 24);
            this.materialLabel13.TabIndex = 18;
            this.materialLabel13.Text = "To";
            // 
            // btn_report_clear
            // 
            this.btn_report_clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_report_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_report_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_report_clear.Depth = 0;
            this.btn_report_clear.HighEmphasis = true;
            this.btn_report_clear.Icon = null;
            this.btn_report_clear.Location = new System.Drawing.Point(1619, 32);
            this.btn_report_clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_report_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_report_clear.Name = "btn_report_clear";
            this.btn_report_clear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_report_clear.Size = new System.Drawing.Size(66, 36);
            this.btn_report_clear.TabIndex = 17;
            this.btn_report_clear.Text = "Clear";
            this.btn_report_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_report_clear.UseAccentColor = false;
            this.btn_report_clear.UseVisualStyleBackColor = true;
            this.btn_report_clear.Click += new System.EventHandler(this.btn_report_clear_Click);
            // 
            // btn_report_filter
            // 
            this.btn_report_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_report_filter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_report_filter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_report_filter.Depth = 0;
            this.btn_report_filter.HighEmphasis = true;
            this.btn_report_filter.Icon = null;
            this.btn_report_filter.Location = new System.Drawing.Point(1514, 31);
            this.btn_report_filter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_report_filter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_report_filter.Name = "btn_report_filter";
            this.btn_report_filter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_report_filter.Size = new System.Drawing.Size(68, 36);
            this.btn_report_filter.TabIndex = 16;
            this.btn_report_filter.Text = "Filter";
            this.btn_report_filter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_report_filter.UseAccentColor = false;
            this.btn_report_filter.UseVisualStyleBackColor = true;
            this.btn_report_filter.Click += new System.EventHandler(this.btn_report_filter_Click);
            // 
            // lbl_report_total_gcash
            // 
            this.lbl_report_total_gcash.AutoSize = true;
            this.lbl_report_total_gcash.Depth = 0;
            this.lbl_report_total_gcash.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_report_total_gcash.Location = new System.Drawing.Point(390, 317);
            this.lbl_report_total_gcash.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_report_total_gcash.Name = "lbl_report_total_gcash";
            this.lbl_report_total_gcash.Size = new System.Drawing.Size(32, 19);
            this.lbl_report_total_gcash.TabIndex = 15;
            this.lbl_report_total_gcash.Text = "0.00";
            // 
            // lbl_report_total_discount
            // 
            this.lbl_report_total_discount.AutoSize = true;
            this.lbl_report_total_discount.Depth = 0;
            this.lbl_report_total_discount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_report_total_discount.Location = new System.Drawing.Point(390, 134);
            this.lbl_report_total_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_report_total_discount.Name = "lbl_report_total_discount";
            this.lbl_report_total_discount.Size = new System.Drawing.Size(32, 19);
            this.lbl_report_total_discount.TabIndex = 14;
            this.lbl_report_total_discount.Text = "0.00";
            // 
            // lbl_report_total_vat
            // 
            this.lbl_report_total_vat.AutoSize = true;
            this.lbl_report_total_vat.Depth = 0;
            this.lbl_report_total_vat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_report_total_vat.Location = new System.Drawing.Point(390, 74);
            this.lbl_report_total_vat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_report_total_vat.Name = "lbl_report_total_vat";
            this.lbl_report_total_vat.Size = new System.Drawing.Size(32, 19);
            this.lbl_report_total_vat.TabIndex = 13;
            this.lbl_report_total_vat.Text = "0.00";
            // 
            // lbl_report_total_sales
            // 
            this.lbl_report_total_sales.AutoSize = true;
            this.lbl_report_total_sales.Depth = 0;
            this.lbl_report_total_sales.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_report_total_sales.Location = new System.Drawing.Point(390, 19);
            this.lbl_report_total_sales.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_report_total_sales.Name = "lbl_report_total_sales";
            this.lbl_report_total_sales.Size = new System.Drawing.Size(32, 19);
            this.lbl_report_total_sales.TabIndex = 12;
            this.lbl_report_total_sales.Text = "0.00";
            // 
            // lbl_report_total_cash
            // 
            this.lbl_report_total_cash.AutoSize = true;
            this.lbl_report_total_cash.Depth = 0;
            this.lbl_report_total_cash.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_report_total_cash.Location = new System.Drawing.Point(390, 280);
            this.lbl_report_total_cash.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_report_total_cash.Name = "lbl_report_total_cash";
            this.lbl_report_total_cash.Size = new System.Drawing.Size(32, 19);
            this.lbl_report_total_cash.TabIndex = 11;
            this.lbl_report_total_cash.Text = "0.00";
            // 
            // lbl_report_total_transaction
            // 
            this.lbl_report_total_transaction.AutoSize = true;
            this.lbl_report_total_transaction.Depth = 0;
            this.lbl_report_total_transaction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_report_total_transaction.Location = new System.Drawing.Point(390, 194);
            this.lbl_report_total_transaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_report_total_transaction.Name = "lbl_report_total_transaction";
            this.lbl_report_total_transaction.Size = new System.Drawing.Size(32, 19);
            this.lbl_report_total_transaction.TabIndex = 10;
            this.lbl_report_total_transaction.Text = "0.00";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel12.Location = new System.Drawing.Point(174, 281);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(51, 24);
            this.materialLabel12.TabIndex = 9;
            this.materialLabel12.Text = "Cash:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel11.Location = new System.Drawing.Point(174, 318);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(69, 24);
            this.materialLabel11.TabIndex = 8;
            this.materialLabel11.Text = "G-cash:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(95, 243);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(191, 24);
            this.materialLabel10.TabIndex = 7;
            this.materialLabel10.Text = "Payment Breakdown:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(95, 195);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(117, 24);
            this.materialLabel9.TabIndex = 6;
            this.materialLabel9.Text = "Transactions";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(95, 135);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(150, 24);
            this.materialLabel8.TabIndex = 5;
            this.materialLabel8.Text = "Discounts Given:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(95, 75);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(126, 24);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "Vat Collected:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(95, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(111, 24);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "Total Sales: ";
            // 
            // dtp_report_end_date
            // 
            this.dtp_report_end_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_report_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_report_end_date.Location = new System.Drawing.Point(1191, 37);
            this.dtp_report_end_date.Name = "dtp_report_end_date";
            this.dtp_report_end_date.Size = new System.Drawing.Size(195, 30);
            this.dtp_report_end_date.TabIndex = 2;
            // 
            // dtp_report_start_date
            // 
            this.dtp_report_start_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_report_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_report_start_date.Location = new System.Drawing.Point(916, 37);
            this.dtp_report_start_date.Name = "dtp_report_start_date";
            this.dtp_report_start_date.Size = new System.Drawing.Size(195, 30);
            this.dtp_report_start_date.TabIndex = 1;
            // 
            // cmb_sales_report_range
            // 
            this.cmb_sales_report_range.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_sales_report_range.AutoResize = false;
            this.cmb_sales_report_range.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_sales_report_range.Depth = 0;
            this.cmb_sales_report_range.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_sales_report_range.DropDownHeight = 174;
            this.cmb_sales_report_range.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sales_report_range.DropDownWidth = 121;
            this.cmb_sales_report_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_sales_report_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_sales_report_range.FormattingEnabled = true;
            this.cmb_sales_report_range.Hint = "Select Range";
            this.cmb_sales_report_range.IntegralHeight = false;
            this.cmb_sales_report_range.ItemHeight = 43;
            this.cmb_sales_report_range.Items.AddRange(new object[] {
            "Today",
            "Weekly",
            "Monthly"});
            this.cmb_sales_report_range.Location = new System.Drawing.Point(1086, 114);
            this.cmb_sales_report_range.MaxDropDownItems = 4;
            this.cmb_sales_report_range.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_sales_report_range.Name = "cmb_sales_report_range";
            this.cmb_sales_report_range.Size = new System.Drawing.Size(300, 49);
            this.cmb_sales_report_range.StartIndex = -1;
            this.cmb_sales_report_range.TabIndex = 0;
            this.cmb_sales_report_range.SelectedIndexChanged += new System.EventHandler(this.cmb_sales_report_range_SelectedIndexChanged);
            // 
            // inventoryTabPage
            // 
            this.inventoryTabPage.Controls.Add(this.panel6);
            this.inventoryTabPage.Controls.Add(this.materialCard9);
            this.inventoryTabPage.Location = new System.Drawing.Point(4, 34);
            this.inventoryTabPage.Name = "inventoryTabPage";
            this.inventoryTabPage.Padding = new System.Windows.Forms.Padding(25);
            this.inventoryTabPage.Size = new System.Drawing.Size(1820, 809);
            this.inventoryTabPage.TabIndex = 1;
            this.inventoryTabPage.Text = "Inventory";
            this.inventoryTabPage.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgv_inventory_report);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(25, 381);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panel6.Size = new System.Drawing.Size(1770, 403);
            this.panel6.TabIndex = 3;
            // 
            // dgv_inventory_report
            // 
            this.dgv_inventory_report.AllowUserToAddRows = false;
            this.dgv_inventory_report.AllowUserToDeleteRows = false;
            this.dgv_inventory_report.AllowUserToResizeColumns = false;
            this.dgv_inventory_report.AllowUserToResizeRows = false;
            this.dgv_inventory_report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_inventory_report.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_inventory_report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_inventory_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventory_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_inventory_id,
            this.col_inventory_product_id,
            this.col_inventory_product_name,
            this.col_inventory_unit,
            this.col_inventory_volume,
            this.col_inventory_total_volume,
            this.col_inventory_critical_level,
            this.col_inventory_status});
            this.dgv_inventory_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_inventory_report.EnableHeadersVisualStyles = false;
            this.dgv_inventory_report.Location = new System.Drawing.Point(0, 25);
            this.dgv_inventory_report.Name = "dgv_inventory_report";
            this.dgv_inventory_report.ReadOnly = true;
            this.dgv_inventory_report.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_inventory_report.RowHeadersVisible = false;
            this.dgv_inventory_report.RowHeadersWidth = 51;
            this.dgv_inventory_report.RowTemplate.Height = 24;
            this.dgv_inventory_report.Size = new System.Drawing.Size(1770, 378);
            this.dgv_inventory_report.TabIndex = 0;
            // 
            // col_inventory_id
            // 
            this.col_inventory_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_inventory_id.HeaderText = "inventory_id";
            this.col_inventory_id.MinimumWidth = 6;
            this.col_inventory_id.Name = "col_inventory_id";
            this.col_inventory_id.ReadOnly = true;
            // 
            // col_inventory_product_id
            // 
            this.col_inventory_product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_inventory_product_id.HeaderText = "product_id";
            this.col_inventory_product_id.MinimumWidth = 6;
            this.col_inventory_product_id.Name = "col_inventory_product_id";
            this.col_inventory_product_id.ReadOnly = true;
            this.col_inventory_product_id.Visible = false;
            // 
            // col_inventory_product_name
            // 
            this.col_inventory_product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_inventory_product_name.HeaderText = "Product";
            this.col_inventory_product_name.MinimumWidth = 6;
            this.col_inventory_product_name.Name = "col_inventory_product_name";
            this.col_inventory_product_name.ReadOnly = true;
            // 
            // col_inventory_unit
            // 
            this.col_inventory_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_inventory_unit.HeaderText = "Unit";
            this.col_inventory_unit.MinimumWidth = 6;
            this.col_inventory_unit.Name = "col_inventory_unit";
            this.col_inventory_unit.ReadOnly = true;
            // 
            // col_inventory_volume
            // 
            this.col_inventory_volume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_inventory_volume.HeaderText = "Volume/Unit";
            this.col_inventory_volume.MinimumWidth = 6;
            this.col_inventory_volume.Name = "col_inventory_volume";
            this.col_inventory_volume.ReadOnly = true;
            // 
            // col_inventory_total_volume
            // 
            this.col_inventory_total_volume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_inventory_total_volume.HeaderText = "Total Volume";
            this.col_inventory_total_volume.MinimumWidth = 6;
            this.col_inventory_total_volume.Name = "col_inventory_total_volume";
            this.col_inventory_total_volume.ReadOnly = true;
            // 
            // col_inventory_critical_level
            // 
            this.col_inventory_critical_level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_inventory_critical_level.HeaderText = "Critical Level";
            this.col_inventory_critical_level.MinimumWidth = 6;
            this.col_inventory_critical_level.Name = "col_inventory_critical_level";
            this.col_inventory_critical_level.ReadOnly = true;
            // 
            // col_inventory_status
            // 
            this.col_inventory_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_inventory_status.HeaderText = "Status";
            this.col_inventory_status.MinimumWidth = 6;
            this.col_inventory_status.Name = "col_inventory_status";
            this.col_inventory_status.ReadOnly = true;
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.btn_inventory_export_pdf);
            this.materialCard9.Controls.Add(this.btn_inventory_clear);
            this.materialCard9.Controls.Add(this.btn_inventory_filter);
            this.materialCard9.Controls.Add(this.lbl_inventory_stock_item);
            this.materialCard9.Controls.Add(this.lbl_inventory_total_volume);
            this.materialCard9.Controls.Add(this.lbl_inventory_total_product);
            this.materialCard9.Controls.Add(this.lbl_inventory_low_stock);
            this.materialCard9.Controls.Add(this.lbl_inventory_out_of_stock);
            this.materialCard9.Controls.Add(this.materialLabel23);
            this.materialCard9.Controls.Add(this.materialLabel24);
            this.materialCard9.Controls.Add(this.materialLabel25);
            this.materialCard9.Controls.Add(this.materialLabel26);
            this.materialCard9.Controls.Add(this.materialLabel27);
            this.materialCard9.Controls.Add(this.cmb_stock_status);
            this.materialCard9.Depth = 0;
            this.materialCard9.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(25, 25);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(1770, 356);
            this.materialCard9.TabIndex = 2;
            // 
            // btn_inventory_export_pdf
            // 
            this.btn_inventory_export_pdf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inventory_export_pdf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_inventory_export_pdf.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_inventory_export_pdf.Depth = 0;
            this.btn_inventory_export_pdf.HighEmphasis = true;
            this.btn_inventory_export_pdf.Icon = null;
            this.btn_inventory_export_pdf.Location = new System.Drawing.Point(1474, 300);
            this.btn_inventory_export_pdf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_inventory_export_pdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_inventory_export_pdf.Name = "btn_inventory_export_pdf";
            this.btn_inventory_export_pdf.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_inventory_export_pdf.Size = new System.Drawing.Size(108, 36);
            this.btn_inventory_export_pdf.TabIndex = 19;
            this.btn_inventory_export_pdf.Text = "Export PDF";
            this.btn_inventory_export_pdf.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_inventory_export_pdf.UseAccentColor = false;
            this.btn_inventory_export_pdf.UseVisualStyleBackColor = true;
            // 
            // btn_inventory_clear
            // 
            this.btn_inventory_clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inventory_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_inventory_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_inventory_clear.Depth = 0;
            this.btn_inventory_clear.HighEmphasis = true;
            this.btn_inventory_clear.Icon = null;
            this.btn_inventory_clear.Location = new System.Drawing.Point(1619, 32);
            this.btn_inventory_clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_inventory_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_inventory_clear.Name = "btn_inventory_clear";
            this.btn_inventory_clear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_inventory_clear.Size = new System.Drawing.Size(66, 36);
            this.btn_inventory_clear.TabIndex = 17;
            this.btn_inventory_clear.Text = "Clear";
            this.btn_inventory_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_inventory_clear.UseAccentColor = false;
            this.btn_inventory_clear.UseVisualStyleBackColor = true;
            this.btn_inventory_clear.Click += new System.EventHandler(this.btn_inventory_clear_Click);
            // 
            // btn_inventory_filter
            // 
            this.btn_inventory_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inventory_filter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_inventory_filter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_inventory_filter.Depth = 0;
            this.btn_inventory_filter.HighEmphasis = true;
            this.btn_inventory_filter.Icon = null;
            this.btn_inventory_filter.Location = new System.Drawing.Point(1514, 31);
            this.btn_inventory_filter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_inventory_filter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_inventory_filter.Name = "btn_inventory_filter";
            this.btn_inventory_filter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_inventory_filter.Size = new System.Drawing.Size(68, 36);
            this.btn_inventory_filter.TabIndex = 16;
            this.btn_inventory_filter.Text = "Filter";
            this.btn_inventory_filter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_inventory_filter.UseAccentColor = false;
            this.btn_inventory_filter.UseVisualStyleBackColor = true;
            this.btn_inventory_filter.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // lbl_inventory_stock_item
            // 
            this.lbl_inventory_stock_item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_inventory_stock_item.AutoSize = true;
            this.lbl_inventory_stock_item.Depth = 0;
            this.lbl_inventory_stock_item.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_inventory_stock_item.Location = new System.Drawing.Point(445, 139);
            this.lbl_inventory_stock_item.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_inventory_stock_item.Name = "lbl_inventory_stock_item";
            this.lbl_inventory_stock_item.Size = new System.Drawing.Size(32, 19);
            this.lbl_inventory_stock_item.TabIndex = 14;
            this.lbl_inventory_stock_item.Text = "0.00";
            // 
            // lbl_inventory_total_volume
            // 
            this.lbl_inventory_total_volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_inventory_total_volume.AutoSize = true;
            this.lbl_inventory_total_volume.Depth = 0;
            this.lbl_inventory_total_volume.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_inventory_total_volume.Location = new System.Drawing.Point(445, 80);
            this.lbl_inventory_total_volume.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_inventory_total_volume.Name = "lbl_inventory_total_volume";
            this.lbl_inventory_total_volume.Size = new System.Drawing.Size(32, 19);
            this.lbl_inventory_total_volume.TabIndex = 13;
            this.lbl_inventory_total_volume.Text = "0.00";
            // 
            // lbl_inventory_total_product
            // 
            this.lbl_inventory_total_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_inventory_total_product.AutoSize = true;
            this.lbl_inventory_total_product.Depth = 0;
            this.lbl_inventory_total_product.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_inventory_total_product.Location = new System.Drawing.Point(445, 19);
            this.lbl_inventory_total_product.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_inventory_total_product.Name = "lbl_inventory_total_product";
            this.lbl_inventory_total_product.Size = new System.Drawing.Size(32, 19);
            this.lbl_inventory_total_product.TabIndex = 12;
            this.lbl_inventory_total_product.Text = "0.00";
            // 
            // lbl_inventory_low_stock
            // 
            this.lbl_inventory_low_stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_inventory_low_stock.AutoSize = true;
            this.lbl_inventory_low_stock.Depth = 0;
            this.lbl_inventory_low_stock.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_inventory_low_stock.Location = new System.Drawing.Point(445, 248);
            this.lbl_inventory_low_stock.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_inventory_low_stock.Name = "lbl_inventory_low_stock";
            this.lbl_inventory_low_stock.Size = new System.Drawing.Size(32, 19);
            this.lbl_inventory_low_stock.TabIndex = 11;
            this.lbl_inventory_low_stock.Text = "0.00";
            // 
            // lbl_inventory_out_of_stock
            // 
            this.lbl_inventory_out_of_stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_inventory_out_of_stock.AutoSize = true;
            this.lbl_inventory_out_of_stock.Depth = 0;
            this.lbl_inventory_out_of_stock.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_inventory_out_of_stock.Location = new System.Drawing.Point(445, 200);
            this.lbl_inventory_out_of_stock.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_inventory_out_of_stock.Name = "lbl_inventory_out_of_stock";
            this.lbl_inventory_out_of_stock.Size = new System.Drawing.Size(32, 19);
            this.lbl_inventory_out_of_stock.TabIndex = 10;
            this.lbl_inventory_out_of_stock.Text = "0.00";
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel23.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel23.Location = new System.Drawing.Point(95, 243);
            this.materialLabel23.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel23.Size = new System.Drawing.Size(154, 24);
            this.materialLabel23.TabIndex = 7;
            this.materialLabel23.Text = "Low Stock Items:";
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel24.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel24.Location = new System.Drawing.Point(95, 195);
            this.materialLabel24.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel24.Size = new System.Drawing.Size(172, 24);
            this.materialLabel24.TabIndex = 6;
            this.materialLabel24.Text = "Out of Stock Items:";
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel25.Location = new System.Drawing.Point(95, 135);
            this.materialLabel25.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel25.Size = new System.Drawing.Size(134, 24);
            this.materialLabel25.TabIndex = 5;
            this.materialLabel25.Text = "In Stock Items:";
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel26.Location = new System.Drawing.Point(95, 75);
            this.materialLabel26.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel26.Size = new System.Drawing.Size(120, 24);
            this.materialLabel26.TabIndex = 4;
            this.materialLabel26.Text = "Total Volume";
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel27.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel27.Location = new System.Drawing.Point(95, 14);
            this.materialLabel27.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel27.Size = new System.Drawing.Size(142, 24);
            this.materialLabel27.TabIndex = 3;
            this.materialLabel27.Text = "Total Products: ";
            // 
            // cmb_stock_status
            // 
            this.cmb_stock_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_stock_status.AutoResize = false;
            this.cmb_stock_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_stock_status.Depth = 0;
            this.cmb_stock_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_stock_status.DropDownHeight = 174;
            this.cmb_stock_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stock_status.DropDownWidth = 121;
            this.cmb_stock_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_stock_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_stock_status.FormattingEnabled = true;
            this.cmb_stock_status.Hint = "Select Stock Status";
            this.cmb_stock_status.IntegralHeight = false;
            this.cmb_stock_status.ItemHeight = 43;
            this.cmb_stock_status.Items.AddRange(new object[] {
            "In Stock",
            "Out of Stock",
            "Low Stock"});
            this.cmb_stock_status.Location = new System.Drawing.Point(1132, 20);
            this.cmb_stock_status.MaxDropDownItems = 4;
            this.cmb_stock_status.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_stock_status.Name = "cmb_stock_status";
            this.cmb_stock_status.Size = new System.Drawing.Size(300, 49);
            this.cmb_stock_status.StartIndex = -1;
            this.cmb_stock_status.TabIndex = 0;
            this.cmb_stock_status.SelectedIndexChanged += new System.EventHandler(this.cmb_stock_status_SelectedIndexChanged);
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.BaseTabControl = this.reportsTabControl;
            this.materialTabSelector3.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector3.Location = new System.Drawing.Point(50, 50);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(1828, 50);
            this.materialTabSelector3.TabIndex = 0;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // auditTab
            // 
            this.auditTab.Location = new System.Drawing.Point(4, 34);
            this.auditTab.Name = "auditTab";
            this.auditTab.Size = new System.Drawing.Size(1928, 997);
            this.auditTab.TabIndex = 10;
            this.auditTab.Text = "Audit Trail";
            this.auditTab.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.materialTabControl2);
            this.settingsTab.Controls.Add(this.materialTabSelector1);
            this.settingsTab.Location = new System.Drawing.Point(4, 34);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(1928, 997);
            this.settingsTab.TabIndex = 11;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.vatAndDiscount);
            this.materialTabControl2.Controls.Add(this.utilityTab);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl2.Location = new System.Drawing.Point(0, 77);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(1928, 920);
            this.materialTabControl2.TabIndex = 1;
            // 
            // vatAndDiscount
            // 
            this.vatAndDiscount.Controls.Add(this.dgv_discount);
            this.vatAndDiscount.Controls.Add(this.materialCard1);
            this.vatAndDiscount.Location = new System.Drawing.Point(4, 34);
            this.vatAndDiscount.Name = "vatAndDiscount";
            this.vatAndDiscount.Size = new System.Drawing.Size(1920, 882);
            this.vatAndDiscount.TabIndex = 0;
            this.vatAndDiscount.Text = "Vat/Discount";
            this.vatAndDiscount.UseVisualStyleBackColor = true;
            // 
            // dgv_discount
            // 
            this.dgv_discount.AllowUserToAddRows = false;
            this.dgv_discount.AllowUserToDeleteRows = false;
            this.dgv_discount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_discount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_discount_id,
            this.col_discount_type,
            this.col_promo_code,
            this.col_discount_rate,
            this.col_discount_status,
            this.col_discount_update,
            this.coL_discount_delete});
            this.dgv_discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_discount.Location = new System.Drawing.Point(0, 277);
            this.dgv_discount.Name = "dgv_discount";
            this.dgv_discount.ReadOnly = true;
            this.dgv_discount.RowHeadersWidth = 51;
            this.dgv_discount.RowTemplate.Height = 24;
            this.dgv_discount.Size = new System.Drawing.Size(1920, 605);
            this.dgv_discount.TabIndex = 1;
            this.dgv_discount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_discount_CellClick);
            // 
            // col_discount_id
            // 
            this.col_discount_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_discount_id.HeaderText = "ID";
            this.col_discount_id.MinimumWidth = 6;
            this.col_discount_id.Name = "col_discount_id";
            this.col_discount_id.ReadOnly = true;
            // 
            // col_discount_type
            // 
            this.col_discount_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_discount_type.HeaderText = "Discount Type";
            this.col_discount_type.MinimumWidth = 6;
            this.col_discount_type.Name = "col_discount_type";
            this.col_discount_type.ReadOnly = true;
            // 
            // col_promo_code
            // 
            this.col_promo_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_promo_code.HeaderText = "Promo Code";
            this.col_promo_code.MinimumWidth = 6;
            this.col_promo_code.Name = "col_promo_code";
            this.col_promo_code.ReadOnly = true;
            // 
            // col_discount_rate
            // 
            this.col_discount_rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_discount_rate.HeaderText = "Discount (%)";
            this.col_discount_rate.MinimumWidth = 6;
            this.col_discount_rate.Name = "col_discount_rate";
            this.col_discount_rate.ReadOnly = true;
            // 
            // col_discount_status
            // 
            this.col_discount_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_discount_status.HeaderText = "Status";
            this.col_discount_status.MinimumWidth = 6;
            this.col_discount_status.Name = "col_discount_status";
            this.col_discount_status.ReadOnly = true;
            // 
            // col_discount_update
            // 
            this.col_discount_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_discount_update.HeaderText = "";
            this.col_discount_update.Image = ((System.Drawing.Image)(resources.GetObject("col_discount_update.Image")));
            this.col_discount_update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_discount_update.MinimumWidth = 6;
            this.col_discount_update.Name = "col_discount_update";
            this.col_discount_update.ReadOnly = true;
            // 
            // coL_discount_delete
            // 
            this.coL_discount_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coL_discount_delete.HeaderText = "";
            this.coL_discount_delete.Image = ((System.Drawing.Image)(resources.GetObject("coL_discount_delete.Image")));
            this.coL_discount_delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.coL_discount_delete.MinimumWidth = 6;
            this.coL_discount_delete.Name = "coL_discount_delete";
            this.coL_discount_delete.ReadOnly = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_cancel_discount);
            this.materialCard1.Controls.Add(this.btn_update_discount);
            this.materialCard1.Controls.Add(this.btn_add_discount);
            this.materialCard1.Controls.Add(this.txt_promo_code);
            this.materialCard1.Controls.Add(this.cmb_discount_type);
            this.materialCard1.Controls.Add(this.txt_discount);
            this.materialCard1.Controls.Add(this.btn_apply);
            this.materialCard1.Controls.Add(this.txt_vat);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1920, 277);
            this.materialCard1.TabIndex = 0;
            // 
            // btn_cancel_discount
            // 
            this.btn_cancel_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_discount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel_discount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel_discount.Depth = 0;
            this.btn_cancel_discount.HighEmphasis = true;
            this.btn_cancel_discount.Icon = null;
            this.btn_cancel_discount.Location = new System.Drawing.Point(1756, 130);
            this.btn_cancel_discount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel_discount.Name = "btn_cancel_discount";
            this.btn_cancel_discount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel_discount.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel_discount.TabIndex = 7;
            this.btn_cancel_discount.Text = "cancel";
            this.btn_cancel_discount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel_discount.UseAccentColor = false;
            this.btn_cancel_discount.UseVisualStyleBackColor = true;
            this.btn_cancel_discount.Visible = false;
            this.btn_cancel_discount.Click += new System.EventHandler(this.btn_cancel_discount_Click);
            // 
            // btn_update_discount
            // 
            this.btn_update_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_discount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update_discount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update_discount.Depth = 0;
            this.btn_update_discount.HighEmphasis = true;
            this.btn_update_discount.Icon = null;
            this.btn_update_discount.Location = new System.Drawing.Point(1750, 57);
            this.btn_update_discount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_update_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update_discount.Name = "btn_update_discount";
            this.btn_update_discount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update_discount.Size = new System.Drawing.Size(152, 36);
            this.btn_update_discount.TabIndex = 6;
            this.btn_update_discount.Text = "Update Discount";
            this.btn_update_discount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update_discount.UseAccentColor = false;
            this.btn_update_discount.UseVisualStyleBackColor = true;
            this.btn_update_discount.Visible = false;
            this.btn_update_discount.Click += new System.EventHandler(this.btn_update_discount_Click);
            // 
            // btn_add_discount
            // 
            this.btn_add_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_discount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_discount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_discount.Depth = 0;
            this.btn_add_discount.HighEmphasis = true;
            this.btn_add_discount.Icon = null;
            this.btn_add_discount.Location = new System.Drawing.Point(1750, 57);
            this.btn_add_discount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_discount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_discount.Name = "btn_add_discount";
            this.btn_add_discount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_discount.Size = new System.Drawing.Size(126, 36);
            this.btn_add_discount.TabIndex = 5;
            this.btn_add_discount.Text = "Add Discount";
            this.btn_add_discount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_discount.UseAccentColor = false;
            this.btn_add_discount.UseVisualStyleBackColor = true;
            this.btn_add_discount.Click += new System.EventHandler(this.btn_add_discount_Click);
            // 
            // txt_promo_code
            // 
            this.txt_promo_code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_promo_code.AnimateReadOnly = false;
            this.txt_promo_code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_promo_code.Depth = 0;
            this.txt_promo_code.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_promo_code.Hint = "Promo Code";
            this.txt_promo_code.LeadingIcon = null;
            this.txt_promo_code.Location = new System.Drawing.Point(1062, 162);
            this.txt_promo_code.MaxLength = 50;
            this.txt_promo_code.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_promo_code.Multiline = false;
            this.txt_promo_code.Name = "txt_promo_code";
            this.txt_promo_code.Size = new System.Drawing.Size(255, 50);
            this.txt_promo_code.TabIndex = 4;
            this.txt_promo_code.Text = "";
            this.txt_promo_code.TrailingIcon = null;
            this.txt_promo_code.Visible = false;
            // 
            // cmb_discount_type
            // 
            this.cmb_discount_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_discount_type.AutoResize = false;
            this.cmb_discount_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_discount_type.Depth = 0;
            this.cmb_discount_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_discount_type.DropDownHeight = 174;
            this.cmb_discount_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_discount_type.DropDownWidth = 121;
            this.cmb_discount_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_discount_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_discount_type.FormattingEnabled = true;
            this.cmb_discount_type.Hint = "Select Discount Type";
            this.cmb_discount_type.IntegralHeight = false;
            this.cmb_discount_type.ItemHeight = 43;
            this.cmb_discount_type.Items.AddRange(new object[] {
            "Promo",
            "Senior/PWD"});
            this.cmb_discount_type.Location = new System.Drawing.Point(1062, 44);
            this.cmb_discount_type.MaxDropDownItems = 4;
            this.cmb_discount_type.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_discount_type.Name = "cmb_discount_type";
            this.cmb_discount_type.Size = new System.Drawing.Size(255, 49);
            this.cmb_discount_type.StartIndex = -1;
            this.cmb_discount_type.TabIndex = 3;
            this.cmb_discount_type.SelectedIndexChanged += new System.EventHandler(this.cmb_discount_type_SelectedIndexChanged);
            // 
            // txt_discount
            // 
            this.txt_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_discount.AnimateReadOnly = false;
            this.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_discount.Depth = 0;
            this.txt_discount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_discount.Hint = "Disocunt (%)";
            this.txt_discount.LeadingIcon = null;
            this.txt_discount.Location = new System.Drawing.Point(1421, 43);
            this.txt_discount.MaxLength = 50;
            this.txt_discount.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_discount.Multiline = false;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(255, 50);
            this.txt_discount.TabIndex = 2;
            this.txt_discount.Text = "";
            this.txt_discount.TrailingIcon = null;
            // 
            // btn_apply
            // 
            this.btn_apply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_apply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_apply.Depth = 0;
            this.btn_apply.HighEmphasis = true;
            this.btn_apply.Icon = null;
            this.btn_apply.Location = new System.Drawing.Point(376, 71);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_apply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_apply.Size = new System.Drawing.Size(67, 36);
            this.btn_apply.TabIndex = 1;
            this.btn_apply.Text = "Apply";
            this.btn_apply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_apply.UseAccentColor = false;
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // txt_vat
            // 
            this.txt_vat.AnimateReadOnly = false;
            this.txt_vat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_vat.Depth = 0;
            this.txt_vat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_vat.Hint = "Vat (%)";
            this.txt_vat.LeadingIcon = null;
            this.txt_vat.Location = new System.Drawing.Point(67, 57);
            this.txt_vat.MaxLength = 50;
            this.txt_vat.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_vat.Multiline = false;
            this.txt_vat.Name = "txt_vat";
            this.txt_vat.Size = new System.Drawing.Size(272, 50);
            this.txt_vat.TabIndex = 0;
            this.txt_vat.Text = "";
            this.txt_vat.TrailingIcon = null;
            // 
            // utilityTab
            // 
            this.utilityTab.Controls.Add(this.materialCard7);
            this.utilityTab.Location = new System.Drawing.Point(4, 34);
            this.utilityTab.Name = "utilityTab";
            this.utilityTab.Size = new System.Drawing.Size(1920, 882);
            this.utilityTab.TabIndex = 1;
            this.utilityTab.Text = "Utilities";
            this.utilityTab.UseVisualStyleBackColor = true;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.btn_save_changes);
            this.materialCard7.Controls.Add(this.btn_cancel_bill);
            this.materialCard7.Controls.Add(this.btn_edit_bill);
            this.materialCard7.Controls.Add(this.btn_add_bill);
            this.materialCard7.Controls.Add(this.groupBox1);
            this.materialCard7.Controls.Add(this.groupBox2);
            this.materialCard7.Depth = 0;
            this.materialCard7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(0, 0);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(1920, 882);
            this.materialCard7.TabIndex = 0;
            // 
            // btn_save_changes
            // 
            this.btn_save_changes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save_changes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_save_changes.Depth = 0;
            this.btn_save_changes.HighEmphasis = true;
            this.btn_save_changes.Icon = null;
            this.btn_save_changes.Location = new System.Drawing.Point(727, 66);
            this.btn_save_changes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save_changes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save_changes.Name = "btn_save_changes";
            this.btn_save_changes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_save_changes.Size = new System.Drawing.Size(129, 36);
            this.btn_save_changes.TabIndex = 41;
            this.btn_save_changes.Text = "Save Changes";
            this.btn_save_changes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save_changes.UseAccentColor = false;
            this.btn_save_changes.UseVisualStyleBackColor = true;
            this.btn_save_changes.Visible = false;
            this.btn_save_changes.Click += new System.EventHandler(this.btn_save_changes_Click);
            // 
            // btn_cancel_bill
            // 
            this.btn_cancel_bill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel_bill.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel_bill.Depth = 0;
            this.btn_cancel_bill.HighEmphasis = true;
            this.btn_cancel_bill.Icon = null;
            this.btn_cancel_bill.Location = new System.Drawing.Point(1237, 66);
            this.btn_cancel_bill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel_bill.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel_bill.Name = "btn_cancel_bill";
            this.btn_cancel_bill.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel_bill.Size = new System.Drawing.Size(77, 36);
            this.btn_cancel_bill.TabIndex = 40;
            this.btn_cancel_bill.Text = "Cancel";
            this.btn_cancel_bill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel_bill.UseAccentColor = false;
            this.btn_cancel_bill.UseVisualStyleBackColor = true;
            this.btn_cancel_bill.Visible = false;
            this.btn_cancel_bill.Click += new System.EventHandler(this.btn_cancel_bill_Click_1);
            // 
            // btn_edit_bill
            // 
            this.btn_edit_bill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_edit_bill.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_edit_bill.Depth = 0;
            this.btn_edit_bill.HighEmphasis = true;
            this.btn_edit_bill.Icon = null;
            this.btn_edit_bill.Location = new System.Drawing.Point(1075, 66);
            this.btn_edit_bill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_edit_bill.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_edit_bill.Name = "btn_edit_bill";
            this.btn_edit_bill.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_edit_bill.Size = new System.Drawing.Size(86, 36);
            this.btn_edit_bill.TabIndex = 39;
            this.btn_edit_bill.Text = "Edit Bill";
            this.btn_edit_bill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_edit_bill.UseAccentColor = false;
            this.btn_edit_bill.UseVisualStyleBackColor = true;
            this.btn_edit_bill.Click += new System.EventHandler(this.btn_edit_bill_Click_1);
            // 
            // btn_add_bill
            // 
            this.btn_add_bill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add_bill.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add_bill.Depth = 0;
            this.btn_add_bill.HighEmphasis = true;
            this.btn_add_bill.Icon = null;
            this.btn_add_bill.Location = new System.Drawing.Point(883, 66);
            this.btn_add_bill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add_bill.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add_bill.Name = "btn_add_bill";
            this.btn_add_bill.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add_bill.Size = new System.Drawing.Size(109, 36);
            this.btn_add_bill.TabIndex = 38;
            this.btn_add_bill.Text = "Create bill";
            this.btn_add_bill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add_bill.UseAccentColor = false;
            this.btn_add_bill.UseVisualStyleBackColor = true;
            this.btn_add_bill.Click += new System.EventHandler(this.btn_add_bill_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_internet_bill);
            this.groupBox1.Controls.Add(this.txt_other_bill);
            this.groupBox1.Controls.Add(this.txt_month_rent);
            this.groupBox1.Controls.Add(this.txt_bill_note);
            this.groupBox1.Controls.Add(this.txt_water_bill);
            this.groupBox1.Controls.Add(this.txt_electric_bill);
            this.groupBox1.Location = new System.Drawing.Point(566, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 351);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent and Bills";
            // 
            // txt_internet_bill
            // 
            this.txt_internet_bill.AnimateReadOnly = false;
            this.txt_internet_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_internet_bill.Depth = 0;
            this.txt_internet_bill.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_internet_bill.Hint = "Internet Bill";
            this.txt_internet_bill.LeadingIcon = null;
            this.txt_internet_bill.Location = new System.Drawing.Point(448, 50);
            this.txt_internet_bill.Margin = new System.Windows.Forms.Padding(50);
            this.txt_internet_bill.MaxLength = 50;
            this.txt_internet_bill.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_internet_bill.Multiline = false;
            this.txt_internet_bill.Name = "txt_internet_bill";
            this.txt_internet_bill.Size = new System.Drawing.Size(300, 50);
            this.txt_internet_bill.TabIndex = 23;
            this.txt_internet_bill.Text = "";
            this.txt_internet_bill.TrailingIcon = null;
            this.txt_internet_bill.TextChanged += new System.EventHandler(this.txt_internet_bill_TextChanged);
            // 
            // txt_other_bill
            // 
            this.txt_other_bill.AnimateReadOnly = false;
            this.txt_other_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_other_bill.Depth = 0;
            this.txt_other_bill.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_other_bill.Hint = "Other Bill";
            this.txt_other_bill.LeadingIcon = null;
            this.txt_other_bill.Location = new System.Drawing.Point(448, 150);
            this.txt_other_bill.Margin = new System.Windows.Forms.Padding(50);
            this.txt_other_bill.MaxLength = 50;
            this.txt_other_bill.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_other_bill.Multiline = false;
            this.txt_other_bill.Name = "txt_other_bill";
            this.txt_other_bill.Size = new System.Drawing.Size(300, 50);
            this.txt_other_bill.TabIndex = 24;
            this.txt_other_bill.Text = "";
            this.txt_other_bill.TrailingIcon = null;
            this.txt_other_bill.TextChanged += new System.EventHandler(this.txt_other_bill_TextChanged);
            // 
            // txt_month_rent
            // 
            this.txt_month_rent.AnimateReadOnly = false;
            this.txt_month_rent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_month_rent.Depth = 0;
            this.txt_month_rent.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_month_rent.Hint = "Monthly Rent";
            this.txt_month_rent.LeadingIcon = null;
            this.txt_month_rent.Location = new System.Drawing.Point(39, 50);
            this.txt_month_rent.Margin = new System.Windows.Forms.Padding(50);
            this.txt_month_rent.MaxLength = 50;
            this.txt_month_rent.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_month_rent.Multiline = false;
            this.txt_month_rent.Name = "txt_month_rent";
            this.txt_month_rent.Size = new System.Drawing.Size(300, 50);
            this.txt_month_rent.TabIndex = 15;
            this.txt_month_rent.Text = "";
            this.txt_month_rent.TrailingIcon = null;
            this.txt_month_rent.TextChanged += new System.EventHandler(this.txt_month_rent_TextChanged_1);
            // 
            // txt_bill_note
            // 
            this.txt_bill_note.AnimateReadOnly = false;
            this.txt_bill_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bill_note.Depth = 0;
            this.txt_bill_note.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_bill_note.Hint = "Notes";
            this.txt_bill_note.LeadingIcon = null;
            this.txt_bill_note.Location = new System.Drawing.Point(448, 248);
            this.txt_bill_note.Margin = new System.Windows.Forms.Padding(50);
            this.txt_bill_note.MaxLength = 50;
            this.txt_bill_note.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_bill_note.Multiline = false;
            this.txt_bill_note.Name = "txt_bill_note";
            this.txt_bill_note.Size = new System.Drawing.Size(300, 50);
            this.txt_bill_note.TabIndex = 25;
            this.txt_bill_note.Text = "";
            this.txt_bill_note.TrailingIcon = null;
            // 
            // txt_water_bill
            // 
            this.txt_water_bill.AnimateReadOnly = false;
            this.txt_water_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_water_bill.Depth = 0;
            this.txt_water_bill.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_water_bill.Hint = "Water Bill";
            this.txt_water_bill.LeadingIcon = null;
            this.txt_water_bill.Location = new System.Drawing.Point(39, 248);
            this.txt_water_bill.Margin = new System.Windows.Forms.Padding(50);
            this.txt_water_bill.MaxLength = 50;
            this.txt_water_bill.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_water_bill.Multiline = false;
            this.txt_water_bill.Name = "txt_water_bill";
            this.txt_water_bill.Size = new System.Drawing.Size(300, 50);
            this.txt_water_bill.TabIndex = 22;
            this.txt_water_bill.Text = "";
            this.txt_water_bill.TrailingIcon = null;
            this.txt_water_bill.TextChanged += new System.EventHandler(this.txt_water_bill_TextChanged);
            // 
            // txt_electric_bill
            // 
            this.txt_electric_bill.AnimateReadOnly = false;
            this.txt_electric_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_electric_bill.Depth = 0;
            this.txt_electric_bill.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_electric_bill.Hint = "Electricity Bill";
            this.txt_electric_bill.LeadingIcon = null;
            this.txt_electric_bill.Location = new System.Drawing.Point(39, 150);
            this.txt_electric_bill.Margin = new System.Windows.Forms.Padding(50);
            this.txt_electric_bill.MaxLength = 50;
            this.txt_electric_bill.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_electric_bill.Multiline = false;
            this.txt_electric_bill.Name = "txt_electric_bill";
            this.txt_electric_bill.Size = new System.Drawing.Size(300, 50);
            this.txt_electric_bill.TabIndex = 21;
            this.txt_electric_bill.Text = "";
            this.txt_electric_bill.TrailingIcon = null;
            this.txt_electric_bill.TextChanged += new System.EventHandler(this.txt_electric_bill_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_working_hours);
            this.groupBox2.Controls.Add(this.lbl_total_cost);
            this.groupBox2.Controls.Add(this.txt_total_utility);
            this.groupBox2.Location = new System.Drawing.Point(566, 487);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 250);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // txt_working_hours
            // 
            this.txt_working_hours.AnimateReadOnly = false;
            this.txt_working_hours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_working_hours.Depth = 0;
            this.txt_working_hours.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_working_hours.Hint = "Total Working Hours";
            this.txt_working_hours.LeadingIcon = null;
            this.txt_working_hours.Location = new System.Drawing.Point(448, 59);
            this.txt_working_hours.Margin = new System.Windows.Forms.Padding(50);
            this.txt_working_hours.MaxLength = 50;
            this.txt_working_hours.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_working_hours.Multiline = false;
            this.txt_working_hours.Name = "txt_working_hours";
            this.txt_working_hours.Size = new System.Drawing.Size(300, 50);
            this.txt_working_hours.TabIndex = 17;
            this.txt_working_hours.Text = "";
            this.txt_working_hours.TrailingIcon = null;
            // 
            // lbl_total_cost
            // 
            this.lbl_total_cost.AnimateReadOnly = true;
            this.lbl_total_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_total_cost.Depth = 0;
            this.lbl_total_cost.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_total_cost.Hint = "Total Cost";
            this.lbl_total_cost.LeadingIcon = null;
            this.lbl_total_cost.Location = new System.Drawing.Point(39, 59);
            this.lbl_total_cost.Margin = new System.Windows.Forms.Padding(50);
            this.lbl_total_cost.MaxLength = 50;
            this.lbl_total_cost.MouseState = MaterialSkin.MouseState.OUT;
            this.lbl_total_cost.Multiline = false;
            this.lbl_total_cost.Name = "lbl_total_cost";
            this.lbl_total_cost.ReadOnly = true;
            this.lbl_total_cost.Size = new System.Drawing.Size(300, 50);
            this.lbl_total_cost.TabIndex = 18;
            this.lbl_total_cost.Text = "";
            this.lbl_total_cost.TrailingIcon = null;
            // 
            // txt_total_utility
            // 
            this.txt_total_utility.AnimateReadOnly = true;
            this.txt_total_utility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_utility.Depth = 0;
            this.txt_total_utility.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_total_utility.Hint = "Utilities Amount";
            this.txt_total_utility.LeadingIcon = null;
            this.txt_total_utility.Location = new System.Drawing.Point(39, 167);
            this.txt_total_utility.Margin = new System.Windows.Forms.Padding(50);
            this.txt_total_utility.MaxLength = 50;
            this.txt_total_utility.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_total_utility.Multiline = false;
            this.txt_total_utility.Name = "txt_total_utility";
            this.txt_total_utility.ReadOnly = true;
            this.txt_total_utility.Size = new System.Drawing.Size(300, 50);
            this.txt_total_utility.TabIndex = 16;
            this.txt_total_utility.Text = "";
            this.txt_total_utility.TrailingIcon = null;
            this.txt_total_utility.TextChanged += new System.EventHandler(this.txt_total_utility_TextChanged_1);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1928, 77);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // expenseTabPage
            // 
            this.expenseTabPage.Controls.Add(this.panel7);
            this.expenseTabPage.Controls.Add(this.materialCard30);
            this.expenseTabPage.Location = new System.Drawing.Point(4, 34);
            this.expenseTabPage.Name = "expenseTabPage";
            this.expenseTabPage.Size = new System.Drawing.Size(1820, 809);
            this.expenseTabPage.TabIndex = 2;
            this.expenseTabPage.Text = "Expense";
            this.expenseTabPage.UseVisualStyleBackColor = true;
            // 
            // materialCard30
            // 
            this.materialCard30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard30.Controls.Add(this.materialLabel14);
            this.materialCard30.Controls.Add(this.dtp_expense_end_date);
            this.materialCard30.Controls.Add(this.dtp_expense_start_date);
            this.materialCard30.Controls.Add(this.materialButton1);
            this.materialCard30.Controls.Add(this.btn_expense_clear);
            this.materialCard30.Controls.Add(this.btn_expense_filter);
            this.materialCard30.Controls.Add(this.lbl_expense_inventory_total);
            this.materialCard30.Controls.Add(this.lbl_expense_total);
            this.materialCard30.Controls.Add(this.lbl_expense_supplies);
            this.materialCard30.Controls.Add(this.lbl_expense_utility_total);
            this.materialCard30.Controls.Add(this.materialLabel19);
            this.materialCard30.Controls.Add(this.materialLabel20);
            this.materialCard30.Controls.Add(this.materialLabel21);
            this.materialCard30.Controls.Add(this.materialLabel22);
            this.materialCard30.Controls.Add(this.lbl_);
            this.materialCard30.Controls.Add(this.cmb_expense_range);
            this.materialCard30.Depth = 0;
            this.materialCard30.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard30.Location = new System.Drawing.Point(0, 0);
            this.materialCard30.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard30.Name = "materialCard30";
            this.materialCard30.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard30.Size = new System.Drawing.Size(1820, 356);
            this.materialCard30.TabIndex = 3;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1524, 300);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(108, 36);
            this.materialButton1.TabIndex = 19;
            this.materialButton1.Text = "Export PDF";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // btn_expense_clear
            // 
            this.btn_expense_clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_expense_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_expense_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_expense_clear.Depth = 0;
            this.btn_expense_clear.HighEmphasis = true;
            this.btn_expense_clear.Icon = null;
            this.btn_expense_clear.Location = new System.Drawing.Point(1669, 32);
            this.btn_expense_clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_expense_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_expense_clear.Name = "btn_expense_clear";
            this.btn_expense_clear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_expense_clear.Size = new System.Drawing.Size(66, 36);
            this.btn_expense_clear.TabIndex = 17;
            this.btn_expense_clear.Text = "Clear";
            this.btn_expense_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_expense_clear.UseAccentColor = false;
            this.btn_expense_clear.UseVisualStyleBackColor = true;
            this.btn_expense_clear.Click += new System.EventHandler(this.btn_expense_clear_Click);
            // 
            // btn_expense_filter
            // 
            this.btn_expense_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_expense_filter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_expense_filter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_expense_filter.Depth = 0;
            this.btn_expense_filter.HighEmphasis = true;
            this.btn_expense_filter.Icon = null;
            this.btn_expense_filter.Location = new System.Drawing.Point(1564, 31);
            this.btn_expense_filter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_expense_filter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_expense_filter.Name = "btn_expense_filter";
            this.btn_expense_filter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_expense_filter.Size = new System.Drawing.Size(68, 36);
            this.btn_expense_filter.TabIndex = 16;
            this.btn_expense_filter.Text = "Filter";
            this.btn_expense_filter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_expense_filter.UseAccentColor = false;
            this.btn_expense_filter.UseVisualStyleBackColor = true;
            this.btn_expense_filter.Click += new System.EventHandler(this.btn_expense_filter_Click);
            // 
            // lbl_expense_inventory_total
            // 
            this.lbl_expense_inventory_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_expense_inventory_total.AutoSize = true;
            this.lbl_expense_inventory_total.Depth = 0;
            this.lbl_expense_inventory_total.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_expense_inventory_total.Location = new System.Drawing.Point(445, 168);
            this.lbl_expense_inventory_total.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_expense_inventory_total.Name = "lbl_expense_inventory_total";
            this.lbl_expense_inventory_total.Size = new System.Drawing.Size(32, 19);
            this.lbl_expense_inventory_total.TabIndex = 14;
            this.lbl_expense_inventory_total.Text = "0.00";
            // 
            // lbl_expense_total
            // 
            this.lbl_expense_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_expense_total.AutoSize = true;
            this.lbl_expense_total.Depth = 0;
            this.lbl_expense_total.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_expense_total.Location = new System.Drawing.Point(445, 48);
            this.lbl_expense_total.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_expense_total.Name = "lbl_expense_total";
            this.lbl_expense_total.Size = new System.Drawing.Size(32, 19);
            this.lbl_expense_total.TabIndex = 12;
            this.lbl_expense_total.Text = "0.00";
            // 
            // lbl_expense_supplies
            // 
            this.lbl_expense_supplies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_expense_supplies.AutoSize = true;
            this.lbl_expense_supplies.Depth = 0;
            this.lbl_expense_supplies.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_expense_supplies.Location = new System.Drawing.Point(445, 277);
            this.lbl_expense_supplies.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_expense_supplies.Name = "lbl_expense_supplies";
            this.lbl_expense_supplies.Size = new System.Drawing.Size(32, 19);
            this.lbl_expense_supplies.TabIndex = 11;
            this.lbl_expense_supplies.Text = "0.00";
            // 
            // lbl_expense_utility_total
            // 
            this.lbl_expense_utility_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_expense_utility_total.AutoSize = true;
            this.lbl_expense_utility_total.Depth = 0;
            this.lbl_expense_utility_total.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_expense_utility_total.Location = new System.Drawing.Point(445, 229);
            this.lbl_expense_utility_total.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_expense_utility_total.Name = "lbl_expense_utility_total";
            this.lbl_expense_utility_total.Size = new System.Drawing.Size(32, 19);
            this.lbl_expense_utility_total.TabIndex = 10;
            this.lbl_expense_utility_total.Text = "0.00";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel19.Location = new System.Drawing.Point(119, 270);
            this.materialLabel19.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel19.Size = new System.Drawing.Size(94, 24);
            this.materialLabel19.TabIndex = 7;
            this.materialLabel19.Text = "- Supplies:";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel20.Location = new System.Drawing.Point(119, 222);
            this.materialLabel20.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel20.Size = new System.Drawing.Size(86, 24);
            this.materialLabel20.TabIndex = 6;
            this.materialLabel20.Text = "- Utilities:";
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel21.Location = new System.Drawing.Point(119, 162);
            this.materialLabel21.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel21.Size = new System.Drawing.Size(191, 24);
            this.materialLabel21.TabIndex = 5;
            this.materialLabel21.Text = "- Inventory Purchase:";
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel22.Location = new System.Drawing.Point(95, 104);
            this.materialLabel22.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.materialLabel22.Size = new System.Drawing.Size(177, 24);
            this.materialLabel22.TabIndex = 4;
            this.materialLabel22.Text = "Category Summary:";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Depth = 0;
            this.lbl_.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_.Location = new System.Drawing.Point(95, 43);
            this.lbl_.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.lbl_.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_.Name = "lbl_";
            this.lbl_.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.lbl_.Size = new System.Drawing.Size(147, 24);
            this.lbl_.TabIndex = 3;
            this.lbl_.Text = "Total Expenses: ";
            // 
            // cmb_expense_range
            // 
            this.cmb_expense_range.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_expense_range.AutoResize = false;
            this.cmb_expense_range.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_expense_range.Depth = 0;
            this.cmb_expense_range.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_expense_range.DropDownHeight = 174;
            this.cmb_expense_range.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_expense_range.DropDownWidth = 121;
            this.cmb_expense_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_expense_range.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_expense_range.FormattingEnabled = true;
            this.cmb_expense_range.Hint = "Select Range";
            this.cmb_expense_range.IntegralHeight = false;
            this.cmb_expense_range.ItemHeight = 43;
            this.cmb_expense_range.Items.AddRange(new object[] {
            "Today",
            "Weekly",
            "Monthly"});
            this.cmb_expense_range.Location = new System.Drawing.Point(1213, 127);
            this.cmb_expense_range.MaxDropDownItems = 4;
            this.cmb_expense_range.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_expense_range.Name = "cmb_expense_range";
            this.cmb_expense_range.Size = new System.Drawing.Size(300, 49);
            this.cmb_expense_range.StartIndex = -1;
            this.cmb_expense_range.TabIndex = 0;
            this.cmb_expense_range.SelectedIndexChanged += new System.EventHandler(this.cmb_expense_range_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgv_expense_report);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 356);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panel7.Size = new System.Drawing.Size(1820, 453);
            this.panel7.TabIndex = 4;
            // 
            // dgv_expense_report
            // 
            this.dgv_expense_report.AllowUserToAddRows = false;
            this.dgv_expense_report.AllowUserToDeleteRows = false;
            this.dgv_expense_report.AllowUserToResizeColumns = false;
            this.dgv_expense_report.AllowUserToResizeRows = false;
            this.dgv_expense_report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_expense_report.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_expense_report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_expense_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_expense_report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_expense_id,
            this.col_expense_category,
            this.col_expense_description,
            this.col_expense_amount,
            this.col_expense_paid_by,
            this.col_expense_notes,
            this.col_expense_date});
            this.dgv_expense_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_expense_report.EnableHeadersVisualStyles = false;
            this.dgv_expense_report.Location = new System.Drawing.Point(0, 25);
            this.dgv_expense_report.Name = "dgv_expense_report";
            this.dgv_expense_report.ReadOnly = true;
            this.dgv_expense_report.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_expense_report.RowHeadersVisible = false;
            this.dgv_expense_report.RowHeadersWidth = 51;
            this.dgv_expense_report.RowTemplate.Height = 24;
            this.dgv_expense_report.Size = new System.Drawing.Size(1820, 428);
            this.dgv_expense_report.TabIndex = 0;
            // 
            // dtp_expense_start_date
            // 
            this.dtp_expense_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_expense_start_date.Location = new System.Drawing.Point(991, 36);
            this.dtp_expense_start_date.Name = "dtp_expense_start_date";
            this.dtp_expense_start_date.Size = new System.Drawing.Size(200, 30);
            this.dtp_expense_start_date.TabIndex = 20;
            // 
            // dtp_expense_end_date
            // 
            this.dtp_expense_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_expense_end_date.Location = new System.Drawing.Point(1313, 36);
            this.dtp_expense_end_date.Name = "dtp_expense_end_date";
            this.dtp_expense_end_date.Size = new System.Drawing.Size(200, 30);
            this.dtp_expense_end_date.TabIndex = 21;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel14.Location = new System.Drawing.Point(1239, 36);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(29, 29);
            this.materialLabel14.TabIndex = 22;
            this.materialLabel14.Text = "To";
            // 
            // col_expense_id
            // 
            this.col_expense_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_expense_id.HeaderText = "id";
            this.col_expense_id.MinimumWidth = 6;
            this.col_expense_id.Name = "col_expense_id";
            this.col_expense_id.ReadOnly = true;
            // 
            // col_expense_category
            // 
            this.col_expense_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_expense_category.HeaderText = "category";
            this.col_expense_category.MinimumWidth = 6;
            this.col_expense_category.Name = "col_expense_category";
            this.col_expense_category.ReadOnly = true;
            // 
            // col_expense_description
            // 
            this.col_expense_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_expense_description.HeaderText = "Description";
            this.col_expense_description.MinimumWidth = 6;
            this.col_expense_description.Name = "col_expense_description";
            this.col_expense_description.ReadOnly = true;
            // 
            // col_expense_amount
            // 
            this.col_expense_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_expense_amount.HeaderText = "Amount";
            this.col_expense_amount.MinimumWidth = 6;
            this.col_expense_amount.Name = "col_expense_amount";
            this.col_expense_amount.ReadOnly = true;
            // 
            // col_expense_paid_by
            // 
            this.col_expense_paid_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_expense_paid_by.HeaderText = "Paid By";
            this.col_expense_paid_by.MinimumWidth = 6;
            this.col_expense_paid_by.Name = "col_expense_paid_by";
            this.col_expense_paid_by.ReadOnly = true;
            // 
            // col_expense_notes
            // 
            this.col_expense_notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_expense_notes.HeaderText = "Notes";
            this.col_expense_notes.MinimumWidth = 6;
            this.col_expense_notes.Name = "col_expense_notes";
            this.col_expense_notes.ReadOnly = true;
            // 
            // col_expense_date
            // 
            this.col_expense_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_expense_date.HeaderText = "Date";
            this.col_expense_date.MinimumWidth = 6;
            this.col_expense_date.Name = "col_expense_date";
            this.col_expense_date.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.dashboardTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table_summary)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.total_sales_card.ResumeLayout(false);
            this.total_sales_card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.userTab.ResumeLayout(false);
            this.materialCard11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.stylistTab.ResumeLayout(false);
            this.materialCard13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stylist)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.customerTab.ResumeLayout(false);
            this.materialCard12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.materialCard10.ResumeLayout(false);
            this.materialCard10.PerformLayout();
            this.supplierTab.ResumeLayout(false);
            this.materialCard25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier)).EndInit();
            this.materialCard24.ResumeLayout(false);
            this.materialCard24.PerformLayout();
            this.categoriesTab.ResumeLayout(false);
            this.materialCard15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.materialCard14.ResumeLayout(false);
            this.materialCard14.PerformLayout();
            this.subCategoryTab.ResumeLayout(false);
            this.materialCard17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sub_category)).EndInit();
            this.materialCard16.ResumeLayout(false);
            this.materialCard16.PerformLayout();
            this.productsTab.ResumeLayout(false);
            this.materialCard19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.materialCard18.ResumeLayout(false);
            this.materialCard18.PerformLayout();
            this.servicesTab.ResumeLayout(false);
            this.materialCard21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).EndInit();
            this.materialCard20.ResumeLayout(false);
            this.materialCard20.PerformLayout();
            this.deliveryTab.ResumeLayout(false);
            this.materialCard27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_delivery)).EndInit();
            this.materialCard26.ResumeLayout(false);
            this.materialCard26.PerformLayout();
            this.priceTab.ResumeLayout(false);
            this.materialCard29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service_price)).EndInit();
            this.materialCard28.ResumeLayout(false);
            this.materialCard28.PerformLayout();
            this.inventoryTab.ResumeLayout(false);
            this.inventoryTabControl.ResumeLayout(false);
            this.inventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).EndInit();
            this.batch_inventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BatchInventory)).EndInit();
            this.appointmentTab.ResumeLayout(false);
            this.materialCard23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointment)).EndInit();
            this.materialCard22.ResumeLayout(false);
            this.materialCard22.PerformLayout();
            this.reportsTab.ResumeLayout(false);
            this.reportsTabControl.ResumeLayout(false);
            this.SalesTabPage.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report_table)).EndInit();
            this.materialCard8.ResumeLayout(false);
            this.materialCard8.PerformLayout();
            this.inventoryTabPage.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory_report)).EndInit();
            this.materialCard9.ResumeLayout(false);
            this.materialCard9.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.vatAndDiscount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_discount)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.utilityTab.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.expenseTabPage.ResumeLayout(false);
            this.materialCard30.ResumeLayout(false);
            this.materialCard30.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_expense_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.TabPage stylistTab;
        private MaterialSkin.Controls.MaterialButton btn_add;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_middle_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_birth_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_role;
        private System.Windows.Forms.DataGridViewImageColumn btn_update;
        private System.Windows.Forms.DataGridViewImageColumn btn_delete;
        private System.Windows.Forms.DataGridViewImageColumn col_view;
        private MaterialSkin.Controls.MaterialButton btn_add_stylist;
        private System.Windows.Forms.DataGridView dgv_stylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stylist_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylist_first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylist_middle_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylist_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylist_day_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylist_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylist_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylist_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylist_role;
        private System.Windows.Forms.DataGridViewImageColumn stylist_btn_update;
        private System.Windows.Forms.DataGridViewImageColumn stylist_btn_delete;
        private System.Windows.Forms.DataGridViewImageColumn col_view_schedules;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.TabPage customerTab;
        private System.Windows.Forms.TabPage categoriesTab;
        private System.Windows.Forms.TabPage subCategoryTab;
        private System.Windows.Forms.TabPage productsTab;
        private System.Windows.Forms.TabPage servicesTab;
        private System.Windows.Forms.TabPage appointmentTab;
        private System.Windows.Forms.TabPage reportsTab;
        private System.Windows.Forms.TabPage auditTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.TabPage supplierTab;
        private System.Windows.Forms.TabPage deliveryTab;
        private System.Windows.Forms.TabPage inventoryTab;
        private MaterialSkin.Controls.MaterialButton btn_add_customer;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_middle_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_email;
        private System.Windows.Forms.DataGridViewImageColumn col_customer_btn_update;
        private System.Windows.Forms.DataGridViewImageColumn col_customer_btn_delete;
        private MaterialSkin.Controls.MaterialButton btn_add_category;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category_type;
        private System.Windows.Forms.DataGridViewImageColumn col_category_btn_update;
        private System.Windows.Forms.DataGridViewImageColumn col_category_btn_delete;
        private MaterialSkin.Controls.MaterialButton btn_add_subcategory;
        private System.Windows.Forms.DataGridView dgv_sub_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_subcategory_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sub_cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sub_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sub_category_name;
        private System.Windows.Forms.DataGridViewImageColumn col_sub_btn_update;
        private System.Windows.Forms.DataGridViewImageColumn coL_sub_btn_delete;
        private MaterialSkin.Controls.MaterialButton btn_add_product;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_unit_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_usage_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_unit_per_volume;
        private System.Windows.Forms.DataGridViewImageColumn col_btn_product_update;
        private System.Windows.Forms.DataGridViewImageColumn col_btn_product_delete;
        private MaterialSkin.Controls.MaterialButton btn_add_service;
        private System.Windows.Forms.DataGridView dgv_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_subcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_status;
        private System.Windows.Forms.DataGridViewImageColumn col_service_product_usage;
        private System.Windows.Forms.DataGridViewImageColumn col_service_btn_update;
        private System.Windows.Forms.DataGridViewImageColumn col_service_btn_delete;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage vatAndDiscount;
        private System.Windows.Forms.TabPage utilityTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txt_vat;
        private MaterialSkin.Controls.MaterialButton btn_apply;
        private MaterialSkin.Controls.MaterialTextBox txt_discount;
        private MaterialSkin.Controls.MaterialComboBox cmb_discount_type;
        private MaterialSkin.Controls.MaterialTextBox txt_promo_code;
        private MaterialSkin.Controls.MaterialButton btn_add_discount;
        private MaterialSkin.Controls.MaterialButton btn_cancel_discount;
        private MaterialSkin.Controls.MaterialButton btn_update_discount;
        private System.Windows.Forms.DataGridView dgv_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_discount_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_discount_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_promo_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_discount_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_discount_status;
        private System.Windows.Forms.DataGridViewImageColumn col_discount_update;
        private System.Windows.Forms.DataGridViewImageColumn coL_discount_delete;
        private MaterialSkin.Controls.MaterialButton btn_add_supplier;
        private System.Windows.Forms.DataGridView dgv_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_supplier_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_supplier_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_supplier_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_supplier_contact;
        private System.Windows.Forms.DataGridViewImageColumn col_supplier_update;
        private System.Windows.Forms.DataGridViewImageColumn col_supplier_delete;
        private MaterialSkin.Controls.MaterialButton btn_add_delivery;
        private System.Windows.Forms.DataGridView dgv_delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_delivery_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_delivery_supplier_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_delivery_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_delivery_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_delivery_invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_delivery_received_by;
        private System.Windows.Forms.DataGridViewImageColumn col_delivery_view_items;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl inventoryTabControl;
        private System.Windows.Forms.TabPage inventory;
        private System.Windows.Forms.TabPage batch_inventory;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_InventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_volume_per_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Critical_Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Status;
        private System.Windows.Forms.DataGridView dgv_BatchInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DeliveryItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_volume_per_qtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DateReceived;
        private MaterialSkin.Controls.MaterialButton btn_add_appointment;
        private System.Windows.Forms.DataGridView dgv_appointment;
        private System.Windows.Forms.TabPage priceTab;
        private MaterialSkin.Controls.MaterialButton btn_add_price;
        private System.Windows.Forms.DataGridView dgv_service_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_price_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_service_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stylist_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_overhead_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vat_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_net_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_net_profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gross_profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_profit_percent;
        private System.Windows.Forms.DataGridViewImageColumn col_price_update;
        private System.Windows.Forms.DataGridViewImageColumn col_price_delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard total_sales_card;
        private MaterialSkin.Controls.MaterialLabel lbl_product;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lbl_total_sales;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel lbl_total_appointment;
        private MaterialSkin.Controls.MaterialLabel lbl_total_product;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialLabel lbl_total_services;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.DataGridView dgv_table_summary;
        private LiveCharts.WinForms.PieChart chart_popular_services;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialTabControl reportsTabControl;
        private System.Windows.Forms.TabPage SalesTabPage;
        private System.Windows.Forms.TabPage inventoryTabPage;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private System.Windows.Forms.DateTimePicker dtp_report_end_date;
        private System.Windows.Forms.DateTimePicker dtp_report_start_date;
        private MaterialSkin.Controls.MaterialComboBox cmb_sales_report_range;
        private MaterialSkin.Controls.MaterialLabel lbl_report_total_gcash;
        private MaterialSkin.Controls.MaterialLabel lbl_report_total_discount;
        private MaterialSkin.Controls.MaterialLabel lbl_report_total_vat;
        private MaterialSkin.Controls.MaterialLabel lbl_report_total_sales;
        private MaterialSkin.Controls.MaterialLabel lbl_report_total_cash;
        private MaterialSkin.Controls.MaterialLabel lbl_report_total_transaction;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton btn_report_clear;
        private MaterialSkin.Controls.MaterialButton btn_report_filter;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgv_report_table;
        private MaterialSkin.Controls.MaterialButton btn_export_pdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_transaction_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_report_appointment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_report_vat_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_report_discount_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_report_amount_paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_report_payment_method;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_report_date;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgv_inventory_report;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialButton btn_inventory_export_pdf;
        private MaterialSkin.Controls.MaterialButton btn_inventory_clear;
        private MaterialSkin.Controls.MaterialButton btn_inventory_filter;
        private MaterialSkin.Controls.MaterialLabel lbl_inventory_stock_item;
        private MaterialSkin.Controls.MaterialLabel lbl_inventory_total_volume;
        private MaterialSkin.Controls.MaterialLabel lbl_inventory_total_product;
        private MaterialSkin.Controls.MaterialLabel lbl_inventory_low_stock;
        private MaterialSkin.Controls.MaterialLabel lbl_inventory_out_of_stock;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialLabel materialLabel27;
        private MaterialSkin.Controls.MaterialComboBox cmb_stock_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inventory_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inventory_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inventory_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inventory_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inventory_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inventory_total_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inventory_critical_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inventory_status;
        private MaterialSkin.Controls.MaterialCard materialCard11;
        private MaterialSkin.Controls.MaterialCard materialCard13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private MaterialSkin.Controls.MaterialCard materialCard12;
        private MaterialSkin.Controls.MaterialCard materialCard14;
        private MaterialSkin.Controls.MaterialCard materialCard15;
        private MaterialSkin.Controls.MaterialCard materialCard16;
        private MaterialSkin.Controls.MaterialCard materialCard17;
        private MaterialSkin.Controls.MaterialCard materialCard18;
        private MaterialSkin.Controls.MaterialCard materialCard19;
        private MaterialSkin.Controls.MaterialCard materialCard20;
        private MaterialSkin.Controls.MaterialCard materialCard21;
        private MaterialSkin.Controls.MaterialCard materialCard22;
        private MaterialSkin.Controls.MaterialCard materialCard23;
        private MaterialSkin.Controls.MaterialCard materialCard24;
        private MaterialSkin.Controls.MaterialCard materialCard25;
        private MaterialSkin.Controls.MaterialCard materialCard26;
        private MaterialSkin.Controls.MaterialCard materialCard27;
        private MaterialSkin.Controls.MaterialCard materialCard28;
        private MaterialSkin.Controls.MaterialCard materialCard29;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylist_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_book_type;
        private System.Windows.Forms.DataGridViewImageColumn col_assign_staff;
        private System.Windows.Forms.DataGridViewImageColumn col_pay;
        private System.Windows.Forms.DataGridViewImageColumn col_appointment_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_app_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_stylist_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_stylist_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_payment_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_db_booking_type;
        private System.Windows.Forms.DataGridViewImageColumn col_db_assign_staff;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialButton btn_save_changes;
        private MaterialSkin.Controls.MaterialButton btn_cancel_bill;
        private MaterialSkin.Controls.MaterialButton btn_edit_bill;
        private MaterialSkin.Controls.MaterialButton btn_add_bill;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox txt_internet_bill;
        private MaterialSkin.Controls.MaterialTextBox txt_other_bill;
        private MaterialSkin.Controls.MaterialTextBox txt_month_rent;
        private MaterialSkin.Controls.MaterialTextBox txt_bill_note;
        private MaterialSkin.Controls.MaterialTextBox txt_water_bill;
        private MaterialSkin.Controls.MaterialTextBox txt_electric_bill;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox txt_working_hours;
        private MaterialSkin.Controls.MaterialTextBox lbl_total_cost;
        private MaterialSkin.Controls.MaterialTextBox txt_total_utility;
        private System.Windows.Forms.TabPage expenseTabPage;
        private MaterialSkin.Controls.MaterialCard materialCard30;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btn_expense_clear;
        private MaterialSkin.Controls.MaterialButton btn_expense_filter;
        private MaterialSkin.Controls.MaterialLabel lbl_expense_inventory_total;
        private MaterialSkin.Controls.MaterialLabel lbl_expense_total;
        private MaterialSkin.Controls.MaterialLabel lbl_expense_supplies;
        private MaterialSkin.Controls.MaterialLabel lbl_expense_utility_total;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialLabel lbl_;
        private MaterialSkin.Controls.MaterialComboBox cmb_expense_range;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgv_expense_report;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private System.Windows.Forms.DateTimePicker dtp_expense_end_date;
        private System.Windows.Forms.DateTimePicker dtp_expense_start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expense_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expense_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expense_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expense_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expense_paid_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expense_notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_expense_date;
    }
}