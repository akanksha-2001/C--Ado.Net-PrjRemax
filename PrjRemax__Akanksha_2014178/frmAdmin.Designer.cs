namespace PrjRemax__Akanksha_2014178
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClientsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHousesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAgentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClientsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchHousesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.agentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(470, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "WELCMOME TO REMAX !!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.logoutMenu,
            this.salesReportToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 23);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageClientsMenu,
            this.manageHousesMenu,
            this.manageAgentsMenu});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // manageClientsMenu
            // 
            this.manageClientsMenu.Name = "manageClientsMenu";
            this.manageClientsMenu.Size = new System.Drawing.Size(123, 22);
            this.manageClientsMenu.Text = "Clients";
            this.manageClientsMenu.Click += new System.EventHandler(this.manageClientsMenu_Click);
            // 
            // manageHousesMenu
            // 
            this.manageHousesMenu.Name = "manageHousesMenu";
            this.manageHousesMenu.Size = new System.Drawing.Size(123, 22);
            this.manageHousesMenu.Text = "Houses";
            this.manageHousesMenu.Click += new System.EventHandler(this.manageHousesMenu_Click);
            // 
            // manageAgentsMenu
            // 
            this.manageAgentsMenu.Name = "manageAgentsMenu";
            this.manageAgentsMenu.Size = new System.Drawing.Size(123, 22);
            this.manageAgentsMenu.Text = "Agents";
            this.manageAgentsMenu.Click += new System.EventHandler(this.manageAgentsMenu_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchClientsMenu,
            this.searchHousesMenu,
            this.agentsToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchClientsMenu
            // 
            this.searchClientsMenu.Name = "searchClientsMenu";
            this.searchClientsMenu.Size = new System.Drawing.Size(123, 22);
            this.searchClientsMenu.Text = "Clients";
            this.searchClientsMenu.Click += new System.EventHandler(this.searchClientsMenu_Click);
            // 
            // searchHousesMenu
            // 
            this.searchHousesMenu.Name = "searchHousesMenu";
            this.searchHousesMenu.Size = new System.Drawing.Size(123, 22);
            this.searchHousesMenu.Text = "Houses";
            this.searchHousesMenu.Click += new System.EventHandler(this.searchHousesMenu_Click);
            // 
            // agentsToolStripMenuItem
            // 
            this.agentsToolStripMenuItem.Name = "agentsToolStripMenuItem";
            this.agentsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.agentsToolStripMenuItem.Text = "Agents";
            this.agentsToolStripMenuItem.Click += new System.EventHandler(this.agentsToolStripMenuItem_Click);
            // 
            // logoutMenu
            // 
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(68, 19);
            this.logoutMenu.Text = "Logout";
            this.logoutMenu.Click += new System.EventHandler(this.logoutMenu_Click);
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(106, 19);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClientsMenu;
        private System.Windows.Forms.ToolStripMenuItem manageHousesMenu;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchClientsMenu;
        private System.Windows.Forms.ToolStripMenuItem searchHousesMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutMenu;
        private System.Windows.Forms.ToolStripMenuItem manageAgentsMenu;
        private System.Windows.Forms.ToolStripMenuItem agentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
    }
}