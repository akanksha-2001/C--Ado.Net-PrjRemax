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
    public partial class frmManageAgents : Form
    {
        public frmManageAgents()
        {
            InitializeComponent();
        }

        DataTable tabAgents;
        string mode = "";
        int currIndex;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmManageAgents_Load(object sender, EventArgs e)
        {
            tabAgents = clsGlobal.myRemaxSet.Tables["Agents"];
            var AllAgents = from comp in tabAgents.AsEnumerable()
                               select new
                               {
                                   AgentName = comp.Field<string>("AgentName"),
                                   AgentEmpNum = comp.Field<string>("AgentEmpNum")
                               };

            lstAgentEmpNum.DataSource = AllAgents.ToList();
            lstAgentEmpNum.DisplayMember = "AgentName";
            lstAgentEmpNum.ValueMember = "AgentEmpNum";



            //lstAgentEmpNum.SelectedIndex = 0;
            Display();
            txtEmail.Enabled = txtEmpNum.Enabled = txtName.Enabled = txtNum.Enabled = txtPass.Enabled = cmBBoxProvince.Enabled = btnClear.Enabled = btnSave.Enabled =  false;

        }

        private void lstAgentEmpNum_Click(object sender, EventArgs e)
        {
            currIndex = lstAgentEmpNum.SelectedIndex;
            if (lstAgentEmpNum.SelectedIndex != -1)
            {
                Display();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = txtEmpNum.Enabled = txtName.Enabled = txtNum.Enabled = txtPass.Enabled = cmBBoxProvince.Enabled = btnSave.Enabled = btnClear.Enabled = true;
            cmBBoxProvince.Text = "";
            txtEmail.Text = txtEmpNum.Text = txtName.Text = txtNum.Text = txtPass.Text = "";
            mode = "ADD";
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            lblResult.Text = "-----------ADDING MODE-----------";
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Display();

            txtEmail.Enabled = txtName.Enabled = txtNum.Enabled = txtPass.Enabled = cmBBoxProvince.Enabled = btnSave.Enabled = btnClear.Enabled = true;
            mode = "EDIT";
            txtEmpNum.Enabled = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            lblResult.Text = "-----------EDITING MODE-----------";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == "ADD")
            {
                DataRow newClient = tabAgents.NewRow();
                newClient["AgentEmpNum"] = txtEmpNum.Text;
                newClient["AgentName"] = txtName.Text;
                newClient["AgentEmail"] = txtEmail.Text;
                newClient["AgentPhoneNo"] = txtNum.Text;
                newClient["AgentLocation"] = cmBBoxProvince.SelectedItem;
                newClient["AgentPass"] = txtPass.Text;
                tabAgents.Rows.Add(newClient);
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpAgents);
                clsGlobal.adpAgents.Update(clsGlobal.myRemaxSet, "Agents");
                
                var AllAgents = from comp in tabAgents.AsEnumerable()
                                select new
                                {
                                    AgentName = comp.Field<string>("AgentName"),
                                    AgentEmpNum = comp.Field<string>("AgentEmpNum")
                                };

                lstAgentEmpNum.DataSource = AllAgents.ToList();
                lstAgentEmpNum.DisplayMember = "AgentName";
                lstAgentEmpNum.ValueMember = "AgentEmpNum";


            }
            else if (mode == "EDIT")
            {
                DataRow updateClient = tabAgents.Rows[lstAgentEmpNum.SelectedIndex];
                
                updateClient["AgentName"] = txtName.Text;
                updateClient["AgentEmail"] = txtEmail.Text;
                updateClient["AgentPhoneNo"] = txtNum.Text;
                updateClient["AgentLocation"] = cmBBoxProvince.SelectedItem;
                updateClient["AgentPass"] = txtPass.Text;
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpAgents);
                clsGlobal.adpAgents.Update(clsGlobal.myRemaxSet, "Agents");
                txtEmail.Enabled = txtEmpNum.Enabled = txtName.Enabled = txtNum.Enabled = txtPass.Enabled = cmBBoxProvince.Enabled = false;
            }

            btnAdd.Enabled = btnDel.Enabled = btnEdit.Enabled = true;
            btnClear.Enabled = btnSave.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtEmpNum.Enabled = txtName.Enabled = txtEmail.Enabled = txtPass.Enabled = txtNum.Enabled = cmBBoxProvince.Enabled = btnSave.Enabled = btnClear.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            string mes = "Are you sure to delete this Agent ?";
            string title = "Agent Deletion Warning";
            if (MessageBox.Show(mes, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabAgents.Rows[currIndex].Delete();
                //we need to save(or synchronize) the contents of the dataset to the database with the commandbuilder
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpAgents);
                clsGlobal.adpAgents.Update(clsGlobal.myRemaxSet, "Agents");
                // clear and reload the datatable from the database
                clsGlobal.myRemaxSet.Tables.Remove("Agents");
                clsGlobal.adpAgents.Fill(clsGlobal.myRemaxSet, "Agents");

                tabAgents = clsGlobal.myRemaxSet.Tables["Agents"];
            }
            var AllAgents = from comp in tabAgents.AsEnumerable()
                            select new
                            {
                                AgentName = comp.Field<string>("AgentName"),
                                AgentEmpNum = comp.Field<string>("AgentEmpNum")
                            };

            lstAgentEmpNum.DataSource = AllAgents.ToList();
            lstAgentEmpNum.DisplayMember = "AgentName";
            lstAgentEmpNum.ValueMember = "AgentEmpNum";

            lstAgentEmpNum.SelectedIndex = 0;
            Display();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = txtEmpNum.Text = txtName.Text = txtNum.Text = txtPass.Text = cmBBoxProvince.Text = "";
            lstAgentEmpNum.SelectedIndex = 0;
            Display();

            txtEmail.Enabled = txtName.Enabled = txtNum.Enabled = txtPass.Enabled = cmBBoxProvince.Enabled = btnSave.Enabled = btnClear.Enabled = false;
            btnAdd.Enabled = btnDel.Enabled = btnEdit.Enabled = true;
        }
        private void Display()
        {
            var foundCurrAgent = from Agent in tabAgents.AsEnumerable()
                                 where Agent.Field<String>("AgentEmpNum") == lstAgentEmpNum.SelectedValue.ToString()
                                 select Agent;
            txtEmpNum.Text = foundCurrAgent.ElementAt(0)["AgentEmpNum"].ToString();
            txtName.Text = foundCurrAgent.ElementAt(0)["AgentName"].ToString();
            txtEmail.Text = foundCurrAgent.ElementAt(0)["AgentEmail"].ToString();
            txtNum.Text = foundCurrAgent.ElementAt(0)["AgentPhoneNo"].ToString();
            txtPass.Text = foundCurrAgent.ElementAt(0)["AgentPass"].ToString();
            cmBBoxProvince.SelectedItem = foundCurrAgent.ElementAt(0)["AgentLocation"].ToString();
            lblResult.Text = " Agent " + (lstAgentEmpNum.SelectedIndex + 1) + " of Total " + lstAgentEmpNum.Items.Count + " Agents.";
        }
    }
}
