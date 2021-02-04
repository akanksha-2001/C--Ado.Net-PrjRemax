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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        DataTable tabHouses,tabClients,tabAgents;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGuest_Click(object sender, EventArgs e)
        {
            frmClients fc = new frmClients();
            fc.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxUser.SelectedItem.ToString() == "Admin")
            {
                if ((txtUser.Text == "admin") && (txtPass.Text == "admin"))
                {
                    frmAdmin admin = new frmAdmin();
                    admin.Show();
                    clsGlobal.currentUser = "Admin";
                }
                else
                {
                    if (MessageBox.Show("Your Username or Password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        txtUser.Focus();

                    }


                }
            }
            else if (comboBoxUser.SelectedItem.ToString() == "Client")
            {
                foreach (DataRow myRow in tabClients.Rows)
                {
                    if ((txtUser.Text == myRow["ClientName"].ToString()) && txtPass.Text == myRow["ClientPass"].ToString())
                    {
                        clsGlobal.currentClient = myRow["ClientId"].ToString();

                        frmClients client = new frmClients();
                        client.Show();

                    }

                }

            }

            else
            {
                foreach (DataRow myRow in tabAgents.Rows)
                {
                    if ((txtUser.Text == myRow["AgentName"].ToString()) && txtPass.Text == myRow["AgentPass"].ToString())
                    {
                        clsGlobal.currentAgent = myRow["AgentEmpNum"].ToString();
                        clsGlobal.currentUser = "Agent";
                        frmAgents agent = new frmAgents();
                        agent.Show();

                    }

                }
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            // Create the dataset 
            clsGlobal.myRemaxSet = new DataSet();
            // Create the connection
            clsGlobal.myCon = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=DBRemax;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            clsGlobal.myCon.Open();

            // add the table Houses in the dataset
            SqlCommand myCmd = new SqlCommand("SELECT * FROM Houses", clsGlobal.myCon);
            clsGlobal.adpHouses = new SqlDataAdapter(myCmd);
            clsGlobal.adpHouses.Fill(clsGlobal.myRemaxSet, "Houses"); // mySet contains the table Houses

            // add the table Clients in the dataset
            myCmd = new SqlCommand("SELECT * FROM Clients", clsGlobal.myCon);
            clsGlobal.adpClients = new SqlDataAdapter(myCmd);
            clsGlobal.adpClients.Fill(clsGlobal.myRemaxSet, "Clients"); // mySet contains the table Clients

            // add the table Agents in the dataset
            myCmd = new SqlCommand("SELECT * FROM Agents", clsGlobal.myCon);
            clsGlobal.adpAgents = new SqlDataAdapter(myCmd);
            clsGlobal.adpAgents.Fill(clsGlobal.myRemaxSet, "Agents");// mySet contains the table Agents

            //my set contains salesReport table
            myCmd = new SqlCommand("SELECT BuyerId,Sales.HouseRefId,HouseAptNo,HouseCity,HouseNbOfBeds,HouseNoOfBaths,HouseStreetAddress,HousePrice,HouseProvince,HouseType,SellerId FROM Sales JOIN Houses ON Sales.HouseRefId = Houses.HouseRefId;", clsGlobal.myCon);
            clsGlobal.adpSalesReport = new SqlDataAdapter(myCmd);
            clsGlobal.adpSalesReport.Fill(clsGlobal.myRemaxSet, "SalesReport");

            myCmd = new SqlCommand("SELECT * FROM Sales", clsGlobal.myCon);
            clsGlobal.adpSales = new SqlDataAdapter(myCmd);
            clsGlobal.adpSales.Fill(clsGlobal.myRemaxSet, "Sales");

            tabHouses = clsGlobal.myRemaxSet.Tables["Houses"];
            tabClients = clsGlobal.myRemaxSet.Tables["Clients"];
            tabAgents = clsGlobal.myRemaxSet.Tables["Agents"];

           

        }
    }
}
