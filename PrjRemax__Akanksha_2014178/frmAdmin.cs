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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void manageClientsMenu_Click(object sender, EventArgs e)
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

        private void manageAgentsMenu_Click(object sender, EventArgs e)
        {
            frmManageAgents agents = new frmManageAgents();
            agents.MdiParent = this;
            agents.Show();
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

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchAgent agents = new frmSearchAgent();
            agents.MdiParent = this;
            agents.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReport sales= new frmSalesReport();
            sales.MdiParent = this;
            sales.Show();
        }
    }
}
