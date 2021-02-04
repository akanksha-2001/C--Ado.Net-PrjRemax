using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrjRemax__Akanksha_2014178
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        DataTable tabSales;

        private void frmSales_Load(object sender, EventArgs e)
        {
            tabSales = clsGlobal.myRemaxSet.Tables["Sales"];
            textHouse.Text = clsGlobal.currentHouse;
            textHouse.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            foreach(DataRow myRow in tabSales.Rows)
            {
                if (myRow["HouseRefId"].ToString() != textBuyer.Text)
                {
                    DataRow newSales = tabSales.NewRow();
                    newSales["HouseRefId"] = textHouse.Text;
                    newSales["BuyerId"] = textBuyer.Text;
                    tabSales.Rows.Add(newSales);
                    SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpSales);
                    clsGlobal.adpSales.Update(clsGlobal.myRemaxSet, "Sales");
                    break;
                }
                
               
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string info = "Are you sure to want to quit this program ?";
            string title = "Application closing";

            if (MessageBox.Show(info, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
