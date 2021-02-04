using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjRemax__Akanksha_2014178
{
    public partial class frmSalesReport : Form
    {
        public frmSalesReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            DataTable tabSales = new DataTable();
            clsGlobal.adpSalesReport.Update(clsGlobal.myRemaxSet, "SalesReport");
            tabSales = clsGlobal.myRemaxSet.Tables["SalesReport"];

            gridViewResult.DataSource = tabSales;
        }
    }
}
