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
    public partial class frmSearchClients : Form
    {
        private ListBox lstLocation;
        private ListBox lstType;
        private Label label1;
        private Button searchButton;
        private CheckBox chkLoc;
        private CheckBox chkType;
        private DataGridView gridViewResult;

        public frmSearchClients()
        {
            InitializeComponent();
        }
        DataTable tabClients;

        private void InitializeComponent()
        {
            this.gridViewResult = new System.Windows.Forms.DataGridView();
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.lstType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.chkLoc = new System.Windows.Forms.CheckBox();
            this.chkType = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewResult
            // 
            this.gridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewResult.Location = new System.Drawing.Point(12, 260);
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.Size = new System.Drawing.Size(733, 180);
            this.gridViewResult.TabIndex = 0;
            // 
            // lstLocation
            // 
            this.lstLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.ItemHeight = 16;
            this.lstLocation.Location = new System.Drawing.Point(104, 89);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(120, 132);
            this.lstLocation.TabIndex = 2;
            this.lstLocation.Click += new System.EventHandler(this.lstLocation_Click);
            // 
            // lstType
            // 
            this.lstType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstType.FormattingEnabled = true;
            this.lstType.ItemHeight = 16;
            this.lstType.Items.AddRange(new object[] {
            "Buyer",
            "Seller"});
            this.lstType.Location = new System.Drawing.Point(528, 89);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(120, 132);
            this.lstType.TabIndex = 4;
            this.lstType.Click += new System.EventHandler(this.lstType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "SEARCH - CLIENTS";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(334, 203);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 40);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // chkLoc
            // 
            this.chkLoc.AutoSize = true;
            this.chkLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoc.Location = new System.Drawing.Point(104, 66);
            this.chkLoc.Name = "chkLoc";
            this.chkLoc.Size = new System.Drawing.Size(165, 20);
            this.chkLoc.TabIndex = 9;
            this.chkLoc.Text = "Search By Location ";
            this.chkLoc.UseVisualStyleBackColor = true;
            // 
            // chkType
            // 
            this.chkType.AutoSize = true;
            this.chkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkType.Location = new System.Drawing.Point(528, 66);
            this.chkType.Name = "chkType";
            this.chkType.Size = new System.Drawing.Size(138, 20);
            this.chkType.TabIndex = 10;
            this.chkType.Text = "Search By Type";
            this.chkType.UseVisualStyleBackColor = true;
            // 
            // frmSearchClients
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(757, 452);
            this.Controls.Add(this.chkType);
            this.Controls.Add(this.chkLoc);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstType);
            this.Controls.Add(this.lstLocation);
            this.Controls.Add(this.gridViewResult);
            this.Name = "frmSearchClients";
            this.Load += new System.EventHandler(this.frmSearchClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmSearchClients_Load(object sender, EventArgs e)
        {
            tabClients = clsGlobal.myRemaxSet.Tables["Clients"];
            
               
               gridViewResult.DataSource = tabClients;
           
                
                

           
           
            foreach(DataRow myRow in tabClients.Rows)
            {
                if (lstLocation.Items.Contains(myRow["ClientLocation"]))
                {
                    continue;
                }
                else
                {
                    lstLocation.Items.Add(myRow["ClientLocation"]);
                }
                
            }
            

            
           
            
        }

        private void lstLocation_Click(object sender, EventArgs e)
        {
           
            
        }

        private void lstType_Click(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(chkLoc.Checked == true && chkType.Checked == false)
            {
                var foundClients = from Client in tabClients.AsEnumerable()
                                   where Client.Field<string>("ClientLocation") == lstLocation.SelectedItem.ToString()
                                   select Client;
                if (foundClients.Count() != 0)
                //to avoid error of empty collection
                {
                    gridViewResult.DataSource = foundClients.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }

            }

            else if(chkType.Checked == true && chkLoc.Checked == false)
            {
                var foundClients = from Client in tabClients.AsEnumerable()
                                   where Client.Field<string>("ClientType") == lstType.SelectedItem.ToString()
                                   select Client;
                if (foundClients.Count() != 0)
                //to avoid error of empty collection
                {
                    gridViewResult.DataSource = foundClients.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }
            else if(chkType.Checked == true && chkLoc.Checked == true)
            {
                var foundClients = from Client in tabClients.AsEnumerable()
                                   where Client.Field<string>("ClientType") == lstType.SelectedItem.ToString()
                                   where Client.Field<string>("ClientLocation") == lstLocation.SelectedItem.ToString()
                                   select Client;
                if (foundClients.Count() != 0)
                //to avoid error of empty collection
                {
                    gridViewResult.DataSource = foundClients.CopyToDataTable();
                }
                else
                {
                    gridViewResult.DataSource = null;
                }
            }
            else
            {
                gridViewResult.DataSource = tabClients;
            }
        }
    }
}
