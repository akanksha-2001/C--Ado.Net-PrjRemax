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
    public partial class frmSearchAgent : Form
    {
        public frmSearchAgent()
        {
            InitializeComponent();
        }

        DataTable tabAgents;

        private void frmSearchAgent_Load(object sender, EventArgs e)
        {
            tabAgents = clsGlobal.myRemaxSet.Tables["Agents"];
            foreach(DataRow myRow in tabAgents.Rows)
            {
                if (lstLoc.Items.Contains(myRow["AgentLocation"]))
                {
                    continue;
                }
                else
                {
                    lstLoc.Items.Add(myRow["AgentLocation"]);
                }
                
            }
            foreach (DataRow myRow in tabAgents.Rows)
            {
                listEmpNum.Items.Add(myRow["AgentEmpNum"]);
            }
            gridViewResult.DataSource = tabAgents;


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (chkLoc.Checked == true && chkEmpNum.Checked == false)
            {
                var foundAgents = from Agent in tabAgents.AsEnumerable()
                                  where Agent.Field<string>("AgentLocation") == lstLoc.SelectedItem.ToString()
                                  select Agent;
                gridViewResult.DataSource = foundAgents.CopyToDataTable();
            }
            else if (chkEmpNum.Checked == true && chkLoc.Checked == false)
            {
                var foundAgents = from Agent in tabAgents.AsEnumerable()
                                  where Agent.Field<string>("AgentEmpNum") == listEmpNum.SelectedItem.ToString()
                                  select Agent;
                gridViewResult.DataSource = foundAgents.CopyToDataTable();
            }
            else if (chkLoc.Checked == true && chkEmpNum.Checked == true)
            {
                var foundAgents = from Agent in tabAgents.AsEnumerable()
                                  where Agent.Field<string>("AgentLocation") == lstLoc.SelectedItem.ToString() && Agent.Field<string>("AgentEmpNum") == listEmpNum.SelectedItem.ToString()
                                  select Agent;
                gridViewResult.DataSource = foundAgents.CopyToDataTable();
            }
            else
            {
                gridViewResult.DataSource = tabAgents;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
