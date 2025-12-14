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
using Microsoft.Reporting.WinForms;
using Org.BouncyCastle.Utilities.IO;
using System.IO;
using Salon.Models;
namespace Salon.View
{
    public partial class InvoiceReportForm : MaterialForm
    {
        private readonly ReportViewer reportViewer;
        public InvoiceReportForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer);


        }

        private void InvoiceReportForm_Load(object sender, EventArgs e)
        {
           
            //var parameters  = new ReportParameter[]
            //{
            //    new ReportParameter("InvoiceID", "Invoice ID: #123456")
               
            //};

            //string reportPath = Path.Combine(Application.StartupPath, "Report", "InvoiceReport.rdlc");
            //using (var fs = new FileStream(reportPath, FileMode.Open))
            //{
            //    reportViewer.LocalReport.LoadReportDefinition(fs);
            //}
            //reportViewer.LocalReport.SetParameters(parameters);
            //reportViewer.LocalReport.DataSources.Clear();
            //reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Items", dataSource));
            //reportViewer.RefreshReport();


        }
    }
}
