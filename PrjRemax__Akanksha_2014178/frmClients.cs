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
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            clsGlobal.myRemaxSet.Clear();
            SqlCommand myCmd = new SqlCommand("SELECT AgentEmpNum,AgentName,AgentEmail,AgentPhoneNo,AgentLocation FROM Agents", clsGlobal.myCon);
            clsGlobal.adpAgents = new SqlDataAdapter(myCmd);
            clsGlobal.adpAgents.Fill(clsGlobal.myRemaxSet, "Agents");
        }

        private void btnSearchAgents_Click(object sender, EventArgs e)
        {
            frmSearchAgent agent = new frmSearchAgent();
            agent.Show();
        }

        private void btnSearchHouses_Click(object sender, EventArgs e)
        {
            frmSearchHouses houses = new frmSearchHouses();
            houses.Show();
        }
    }
}
