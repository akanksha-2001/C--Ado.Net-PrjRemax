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
    public partial class frmManageClients : Form
    {
        public frmManageClients()
        {
            InitializeComponent();
        }

        DataTable tabClients,tabAgents;
        string mode = "";
        int currIndex;

        private void txtPhoneNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "ADD";
            txtId.Enabled = txtClientName.Enabled = txtLoc.Enabled = txtPhoneNo.Enabled = cmbAgentId.Enabled = cmbClientType.Enabled = btnSave.Enabled = btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            if (clsGlobal.currentAgent == "")
            {
                cmbAgentId.Text = "";
            }
           
            cmbClientType.Text = "";
            txtId.Text = txtClientName.Text = txtLoc.Text = txtPhoneNo.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(mode == "ADD")
            {
                DataRow newClient = tabClients.NewRow();
                newClient["ClientId"] = txtId.Text;
                newClient["ClientName"] = txtClientName.Text;
               
                newClient["ClientPhoneNo"] = txtPhoneNo.Text;
                newClient["ClientLocation"] = txtLoc.Text;
                newClient["ClientType"] = cmbClientType.SelectedItem.ToString();
                newClient["AgentNum"] = cmbAgentId.SelectedValue.ToString();
                tabClients.Rows.Add(newClient);

                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClients);
                clsGlobal.adpClients.Update(clsGlobal.myRemaxSet, "Clients");
                lstClientId.Items.Add(newClient["ClientId"]);
                txtId.Text = txtClientName.Text = txtLoc.Text =  txtPhoneNo.Text = "";
                
            }

            else if(mode == "EDIT")
            {
                DataRow updateClient = tabClients.Rows[currIndex];
                updateClient["ClientId"] = txtId.Text;
                updateClient["ClientName"] = txtClientName.Text;
               
                updateClient["ClientPhoneNo"] = txtPhoneNo.Text;
                updateClient["ClientLocation"] = txtLoc.Text;
                updateClient["ClientType"] = cmbClientType.SelectedItem.ToString();
                updateClient["AgentNum"] = cmbAgentId.SelectedValue.ToString();
               
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClients);
                clsGlobal.adpClients.Update(clsGlobal.myRemaxSet, "Clients");
            }

            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "EDIT";
            
           
            txtId.Enabled = txtClientName.Enabled = txtLoc.Enabled = txtPhoneNo.Enabled = cmbAgentId.Enabled = cmbClientType.Enabled = btnSave.Enabled = btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void cmbClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtId.Enabled = txtClientName.Enabled = txtLoc.Enabled = txtPhoneNo.Enabled = cmbAgentId.Enabled = cmbClientType.Enabled = btnSave.Enabled = btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            string mes = "Are you sure to delete this Client ?";
            string title = "Client Deletion Warning";
            if (MessageBox.Show(mes, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabClients.Rows[currIndex].Delete();
                //we need to save(or synchronize) the contents of the dataset to the database with the commandbuilder
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClients);
                clsGlobal.adpClients.Update(clsGlobal.myRemaxSet, "Clients");
                // clear and reload the datatable from the database
                clsGlobal.myRemaxSet.Tables.Remove("Clients");
                clsGlobal.adpClients.Fill(clsGlobal.myRemaxSet, "Clients");

                tabClients = clsGlobal.myRemaxSet.Tables["Clients"];
            }
            lstClientId.Items.RemoveAt(currIndex);
            lstClientId.SelectedIndex = 0;
        }

        private void lstClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            currIndex = lstClientId.SelectedIndex;
            tabClients = clsGlobal.myRemaxSet.Tables["Clients"];
            if(lstClientId.SelectedIndex != -1)
            {
                string currentClientId = lstClientId.SelectedItem.ToString();
             
                foreach (DataRow myRow in tabClients.Rows)
                {
                    if (myRow["ClientId"].ToString() == currentClientId)
                    {

                        txtClientName.Text = myRow["ClientName"].ToString();
                        txtId.Text = currentClientId;
                        txtLoc.Text = myRow["ClientLocation"].ToString();
                        
                        txtPhoneNo.Text = myRow["ClientPhoneNo"].ToString();
                        cmbAgentId.SelectedValue = myRow["AgentNum"].ToString();
                        foreach (DataRow myRow1 in tabAgents.Rows)
                        {
                            if (myRow1["AgentEmpNum"] == cmbAgentId.SelectedValue)
                            {
                                cmbAgentId.SelectedItem = myRow1["AgentName"];
                            }
                        }

                        cmbClientType.SelectedItem = myRow["ClientType"].ToString();
                    }
                }
            }
            
        }

        private void frmManageClients_Load(object sender, EventArgs e)
        {
            txtId.Enabled=txtClientName.Enabled=txtLoc.Enabled=txtPhoneNo.Enabled=cmbAgentId.Enabled=cmbClientType.Enabled=btnSave.Enabled=btnCancel.Enabled = false;
            tabClients = clsGlobal.myRemaxSet.Tables["Clients"];
            tabAgents
                 = clsGlobal.myRemaxSet.Tables["Agents"];
            foreach (DataRow myRow1 in tabClients.Rows)
            {
                lstClientId.Items.Add(myRow1["ClientId"]);
            }

            /* foreach (DataRow myRow1 in tabAgents.Rows)
               {
                   cmbAgentId.Items.Add(myRow1["AgentEmpNum"]);
               }*/
            var AllAgents = from comp in tabAgents.AsEnumerable()
                            select new
                            {
                                AgentName = comp.Field<string>("AgentName"),
                                AgentEmpNum = comp.Field<string>("AgentEmpNum")
                            };

            cmbAgentId.DataSource = AllAgents.ToList();
            cmbAgentId.DisplayMember = "AgentName";
            cmbAgentId.ValueMember = "AgentEmpNum";





            DataRow myRow = tabClients.Rows[0];
            txtId.Text = myRow["ClientId"].ToString();
            txtClientName.Text = myRow["ClientName"].ToString();
            txtLoc.Text = myRow["ClientLocation"].ToString();
            txtPhoneNo.Text = myRow["ClientPhoneNo"].ToString();
            cmbClientType.SelectedItem = myRow["ClientType"];
            cmbAgentId.SelectedValue = myRow["AgentNum"];
            foreach (DataRow myRow1 in tabAgents.Rows)
            {
                if (myRow1["AgentEmpNum"] == cmbAgentId.SelectedValue)
                {
                    cmbAgentId.SelectedItem = myRow1["AgentName"];
                }
            }
            


        }
    }
}
