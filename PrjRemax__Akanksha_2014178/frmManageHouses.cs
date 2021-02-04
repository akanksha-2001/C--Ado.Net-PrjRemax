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
    public partial class frmManageHouses : Form
    {
        public frmManageHouses()
        {
            InitializeComponent();
        }
        DataTable tabHouses , tabClients;
        int HouseId;
        int currIndex;
        string mode = "";

        private void frmManageHouses_Load(object sender, EventArgs e)
        {
            tabHouses = clsGlobal.myRemaxSet.Tables["Houses"];
            tabClients = clsGlobal.myRemaxSet.Tables["Clients"];
            foreach (DataRow myRow in tabHouses.Rows)
            {
                if (lstHouseId.Items.Contains(myRow["HouseRefId"]))
                {
                    continue;
                }
                else
                {
                    lstHouseId.Items.Add(myRow["HouseRefId"]);
                }

            }
            var foundClients = from client in tabClients.AsEnumerable()
                               where client.Field<string>("ClientType") == "Seller"
                               select client.Field<string>("ClientId");

            cmbClient.DataSource = foundClients.ToList();
            HouseId = Convert.ToInt32(tabHouses.Rows[0]["HouseRefId"]);
            displayHouse();
            txtAptNo.Enabled = txtCity.Enabled = txtHouseId.Enabled = txtPostal.Enabled = txtPrice.Enabled = txtStreet.Enabled = btnCancel.Enabled = btnSave.Enabled = cmbBoxBath.Enabled = cmbBoxBed.Enabled = cmbClient.Enabled = cmBBoxProvince.Enabled = cmbHouseType.Enabled = false;

        }

        private void lstHouseId_Click(object sender, EventArgs e)
        {
            currIndex = lstHouseId.SelectedIndex;
            if(currIndex != -1)
            {
                HouseId = Convert.ToInt32(lstHouseId.SelectedItem.ToString());
                displayHouse();
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "ADD";
            txtStreet.Text = txtPrice.Text = txtPostal.Text = txtHouseId.Text = txtCity.Text = txtAptNo.Text = cmbClient.Text = cmbBoxBath.Text = cmbBoxBed.Text = cmBBoxProvince.Text = cmbHouseType.Text = "";
            txtAptNo.Enabled = txtCity.Enabled = txtHouseId.Enabled = txtPostal.Enabled = txtPrice.Enabled = txtStreet.Enabled = cmbClient.Enabled =  btnCancel.Enabled = btnSave.Enabled = cmbBoxBath.Enabled = cmbBoxBed.Enabled = cmBBoxProvince.Enabled = cmbHouseType.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            txtAptNo.Enabled = txtCity.Enabled = txtHouseId.Enabled = txtPostal.Enabled = txtPrice.Enabled = txtStreet.Enabled = cmbClient.Enabled = btnCancel.Enabled = btnSave.Enabled = cmbBoxBath.Enabled = cmbBoxBed.Enabled = cmBBoxProvince.Enabled = cmbHouseType.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
            string mes = "Are you sure to delete this House ?";
            string title = "House Deletion Warning";
            if (MessageBox.Show(mes, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabHouses.Rows[currIndex].Delete();
                //we need to save(or synchronize) the contents of the dataset to the database with the commandbuilder
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                clsGlobal.adpHouses.Update(clsGlobal.myRemaxSet, "Houses");
                // clear and reload the datatable from the database
                clsGlobal.myRemaxSet.Tables.Remove("Houses");
                clsGlobal.adpHouses.Fill(clsGlobal.myRemaxSet, "Houses");

                tabHouses = clsGlobal.myRemaxSet.Tables["Houses"];
            }
            lstHouseId.Items.RemoveAt(currIndex);
            lstHouseId.SelectedIndex = 0;
            HouseId = Convert.ToInt32(tabHouses.Rows[0]["HouseRefId"]);
            
            displayHouse();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "ADD";
            txtAptNo.Enabled = txtCity.Enabled = txtHouseId.Enabled = txtPostal.Enabled = txtPrice.Enabled = txtStreet.Enabled = btnCancel.Enabled = btnSave.Enabled = cmbBoxBath.Enabled = cmbBoxBed.Enabled = cmBBoxProvince.Enabled = cmbHouseType.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == "ADD")
            {
                DataRow newHouse = tabHouses.NewRow();
                newHouse["HouseRefId"] = Convert.ToInt32(txtHouseId.Text);
                newHouse["HouseAptNo"] = txtAptNo.Text;

                newHouse["HouseStreetAddress"] = txtStreet.Text;
                newHouse["HouseCity"] = txtCity.Text;
                newHouse["HouseProvince"] = cmBBoxProvince.SelectedItem.ToString();
                newHouse["HousePostalCode"] = txtPostal.Text.ToString();
                newHouse["HouseNbOfBeds"] = Convert.ToInt32(cmbBoxBed.SelectedItem);
                newHouse["HouseNoOfBaths"] = Convert.ToInt32(cmbBoxBath.SelectedItem);
                newHouse["HouseType"] = cmbHouseType.SelectedItem.ToString();
                newHouse["HousePrice"] = Convert.ToSingle(txtPrice.Text);
                newHouse["SellerId"] = cmbClient.SelectedItem.ToString();

                tabHouses.Rows.Add(newHouse);
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                clsGlobal.adpHouses.Update(clsGlobal.myRemaxSet, "Houses");
                lstHouseId.Items.Add(newHouse["HouseRefId"]);

            }


            else if (mode == "EDIT")
            {
                DataRow updateHouse = tabHouses.Rows[currIndex];
                // newHouse["HouseRefId"] = Convert.ToInt32(txtHouseId.Text);
                updateHouse["HouseAptNo"] = txtAptNo.Text;

                updateHouse["HouseStreetAddress"] = txtStreet.Text;
                updateHouse["HouseCity"] = txtCity.Text;
                updateHouse["HouseProvince"] = cmBBoxProvince.SelectedItem.ToString();
                updateHouse["HousePostalCode"] = txtPostal.Text.ToString();
                updateHouse["HouseNbOfBeds"] = Convert.ToInt32(cmbBoxBed.SelectedItem);
                updateHouse["HouseNoOfBaths"] = Convert.ToInt32(cmbBoxBath.SelectedItem);
                updateHouse["HouseType"] = cmbHouseType.SelectedItem.ToString();
                updateHouse["HousePrice"] = Convert.ToSingle(txtPrice.Text);
                

               
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                clsGlobal.adpHouses.Update(clsGlobal.myRemaxSet, "Houses");

            }

            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnBUY_Click(object sender, EventArgs e)
        {
            clsGlobal.currentHouse = txtHouseId.Text;
            frmSales fs = new frmSales();
            fs.Show();
        }

        private void txtHouseId_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayHouse()
        {


            var foundHouses = from House in tabHouses.AsEnumerable()
                              where House.Field<int>("HouseRefId") == HouseId
                               select House;

            txtHouseId.Text = foundHouses.ElementAt(0)["HouseRefId"].ToString();
            txtAptNo.Text = foundHouses.ElementAt(0)["HouseAptNo"].ToString();
            txtCity.Text = foundHouses.ElementAt(0)["HouseCity"].ToString();
            txtPostal.Text = foundHouses.ElementAt(0)["HousePostalCode"].ToString();
            txtPrice.Text = foundHouses.ElementAt(0)["HousePrice"].ToString();
            txtStreet.Text = foundHouses.ElementAt(0)["HouseStreetAddress"].ToString();
            cmbBoxBath.SelectedItem = foundHouses.ElementAt(0)["HouseNoOfBaths"].ToString();
            cmbBoxBed.SelectedItem = foundHouses.ElementAt(0)["HouseNbOfBeds"].ToString();
            if(foundHouses.ElementAt(0)["SellerId"].ToString() != null)
            { 
                cmbClient.SelectedItem = foundHouses.ElementAt(0)["SellerId"].ToString();
            }
            
            cmbHouseType.SelectedItem = foundHouses.ElementAt(0)["HouseType"].ToString();
            cmBBoxProvince.SelectedItem = foundHouses.ElementAt(0)["HouseProvince"].ToString();
        }
    }
}
