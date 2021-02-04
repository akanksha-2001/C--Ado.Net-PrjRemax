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
    public partial class frmAgents : Form
    {
        public frmAgents()
        {
            InitializeComponent();
        }
        

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageClients clients = new frmManageClients();
            clients.MdiParent = this;
            clients.Show();
        }

        private void manageHousesMenu_Click(object sender, EventArgs e)
        {
            frmManageHouses houses = new frmManageHouses();
            houses.MdiParent = this;
            houses.Show();
        }

        private void searchClientsMenu_Click(object sender, EventArgs e)
        {
            frmSearchClients clients = new frmSearchClients();
            clients.MdiParent = this;
            clients.Show();
        }

        private void searchHousesMenu_Click(object sender, EventArgs e)
        {
            frmSearchHouses houses = new frmSearchHouses();
            houses.MdiParent = this;
            houses.Show();
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            string info = "Are you sure to want to quit this program ?";
            string title = "Application closing";

            if (MessageBox.Show(info, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmAgents_Load(object sender, EventArgs e)
        {

        }

        private void frmAgents_Load_1(object sender, EventArgs e)
        {

            // add the table Houses in the dataset
            clsGlobal.myRemaxSet.Tables.Remove("Houses");
            SqlCommand myCmd = new SqlCommand("SELECT * FROM Houses JOIN Clients ON Houses.SellerId = Clients.ClientId JOIN Agents ON Clients.AgentNum = Agents.AgentEmpNum WHERE Clients.AgentNum = '"+ clsGlobal.currentAgent +"'", clsGlobal.myCon);
            clsGlobal.adpHouses = new SqlDataAdapter(myCmd);
            clsGlobal.adpHouses.Fill(clsGlobal.myRemaxSet, "Houses"); // mySet contains the table Houses

            // add the table Clients in the dataset
            clsGlobal.myRemaxSet.Tables.Remove("Clients");
            myCmd = new SqlCommand("SELECT * FROM Clients WHERE AgentNum = '"+clsGlobal.currentAgent+"'", clsGlobal.myCon);
            clsGlobal.adpClients = new SqlDataAdapter(myCmd);
            clsGlobal.adpClients.Fill(clsGlobal.myRemaxSet, "Clients");

            myCmd = new SqlCommand("SELECT BuyerId,Sales.HouseRefId,HouseAptNo,HouseCity,HouseNbOfBeds,HouseNoOfBaths,HouseStreetAddress,HousePrice,HouseProvince,HouseType,SellerId FROM Sales JOIN Houses ON Sales.HouseRefId = Houses.HouseRefId;", clsGlobal.myCon);
            clsGlobal.adpSalesReport = new SqlDataAdapter(myCmd);
            clsGlobal.adpSalesReport.Fill(clsGlobal.myRemaxSet, "SalesReport");

            myCmd = new SqlCommand("SELECT * FROM Sales", clsGlobal.myCon);
            clsGlobal.adpSales = new SqlDataAdapter(myCmd);
            clsGlobal.adpSales.Fill(clsGlobal.myRemaxSet, "Sales");
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReport sales = new frmSalesReport();
            sales.MdiParent = this;
            sales.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    
}
