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
    public partial class frmSearchHouses : Form
    {
        public frmSearchHouses()
        {
            InitializeComponent();
        }
    
        DataTable tabHouses;
        private void frmSearchHouses_Load(object sender, EventArgs e)
        {
            tabHouses = clsGlobal.myRemaxSet.Tables["Houses"];

            gridViewResult.DataSource = tabHouses;

            foreach (DataRow myRow in tabHouses.Rows)
            {
                if (lstRefId.Items.Contains(myRow["HouseRefId"].ToString()))
                {
                    continue;
                }
                else
                {
                    lstRefId.Items.Add(myRow["HouseRefId"].ToString());
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkBed.Checked == true && chkBath.Checked == false && chkHouseType.Checked == false && chkLoc.Checked == false && chkPrice.Checked == false)
            {
                var foundHouse = from House in tabHouses.AsEnumerable()
                                 where House.Field<int>("HouseNbOfBeds") == Convert.ToInt16(cmbed.SelectedItem)
                                 select House;



                if (foundHouse.Count() != 0)
                {
                    gridViewResult.DataSource = foundHouse.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }
            else if (chkBed.Checked == false && chkBath.Checked == true && chkHouseType.Checked == false && chkLoc.Checked == false && chkPrice.Checked == false)
            {
                var foundHouse = from House in tabHouses.AsEnumerable()
                                 where House.Field<int>("HouseNoOfBaths") == Convert.ToInt16(cmbBath.SelectedItem)
                                 select House;



                if (foundHouse.Count() != 0)
                {
                    gridViewResult.DataSource = foundHouse.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }
            else if (chkBed.Checked == false && chkBath.Checked == false && chkHouseType.Checked == true && chkLoc.Checked == false && chkPrice.Checked == false)
            {
                var foundHouse = from House in tabHouses.AsEnumerable()
                                 where House.Field<string>("HouseType") == cmbType.SelectedItem.ToString()
                                 select House;



                if (foundHouse.Count() != 0)
                {
                    gridViewResult.DataSource = foundHouse.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }
            else if (chkBed.Checked == false && chkBath.Checked == false && chkHouseType.Checked == false && chkLoc.Checked == true && chkPrice.Checked == false)
            {
                var foundHouse = from House in tabHouses.AsEnumerable()
                                 where House.Field<string>("HouseProvince") == cmbLoc.SelectedItem.ToString()
                                 select House;



                if (foundHouse.Count() != 0)
                {
                    gridViewResult.DataSource = foundHouse.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }
            else if (chkBed.Checked == false && chkBath.Checked == false && chkHouseType.Checked == false && chkLoc.Checked == false && chkPrice.Checked == true)
            {
                var foundHouse = from House in tabHouses.AsEnumerable()
                                 where House.Field<decimal>("HousePrice") <= Convert.ToDecimal(txtMaxPrice.Text)
                                 select House;



                if (foundHouse.Count() != 0)
                {
                    gridViewResult.DataSource = foundHouse.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }

            else if (chkBed.Checked == true && chkBath.Checked == true && chkHouseType.Checked == false && chkLoc.Checked == false && chkPrice.Checked == false)
            {
                var foundHouse = from House in tabHouses.AsEnumerable()
                                 where House.Field<int>("HouseNoOfBaths") == Convert.ToInt16(cmbBath.SelectedItem) && House.Field<int>("HouseNbOfBeds") == Convert.ToInt16(cmbed.SelectedItem)
                                 select House;



                if (foundHouse.Count() != 0)
                {
                    gridViewResult.DataSource = foundHouse.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }
            else if (chkBed.Checked == true && chkBath.Checked == true && chkHouseType.Checked == true && chkLoc.Checked == false && chkPrice.Checked == false)
            {
                var foundHouse = from House in tabHouses.AsEnumerable()
                                 where House.Field<int>("HouseNoOfBaths") == Convert.ToInt16(cmbBath.SelectedItem) && House.Field<int>("HouseNbOfBeds") == Convert.ToInt16(cmbed.SelectedItem) && House.Field<string>("HouseType") == cmbType.SelectedItem.ToString()
                                 select House;



                if (foundHouse.Count() != 0)
                {
                    gridViewResult.DataSource = foundHouse.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }
            else if (chkBed.Checked == true && chkBath.Checked == true && chkHouseType.Checked == true && chkLoc.Checked == true && chkPrice.Checked == false)
            {
                var foundHouse = from House in tabHouses.AsEnumerable()
                                 where House.Field<int>("HouseNoOfBaths") == Convert.ToInt16(cmbBath.SelectedItem) && House.Field<int>("HouseNbOfBeds") == Convert.ToInt16(cmbed.SelectedItem) && House.Field<string>("HouseType") == cmbType.SelectedItem.ToString() && House.Field<string>("HouseProvince") == cmbLoc.SelectedItem.ToString()
                                 select House;



                if (foundHouse.Count() != 0)
                {
                    gridViewResult.DataSource = foundHouse.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }

            else if (chkBed.Checked == true && chkBath.Checked == true && chkHouseType.Checked == true && chkLoc.Checked == true && chkPrice.Checked == true)
            {
                var foundHouse = from House in tabHouses.AsEnumerable()
                                 where House.Field<int>("HouseNoOfBaths") == Convert.ToInt16(cmbBath.SelectedItem) && House.Field<int>("HouseNbOfBeds") == Convert.ToInt16(cmbed.SelectedItem) && House.Field<string>("HouseType") == cmbType.SelectedItem.ToString() && House.Field<string>("HouseProvince") == cmbLoc.SelectedItem.ToString() && House.Field<decimal>("HousePrice") <= Convert.ToDecimal(txtMaxPrice.Text)
                                 select House;



                if (foundHouse.Count() != 0)
                {
                    gridViewResult.DataSource = foundHouse.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }
            else if(chkBed.Checked == false && chkBath.Checked == false && chkHouseType.Checked == false && chkLoc.Checked == false && chkPrice.Checked == false)
            {
                var foundHouse = from House in tabHouses.AsEnumerable()
                                 where House.Field<int>("HouseRefId") == Convert.ToInt32(lstRefId.SelectedItem)
                                 select House;



                if (foundHouse.Count() != 0)
                {
                    gridViewResult.DataSource = foundHouse.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }


        }
    }
}
