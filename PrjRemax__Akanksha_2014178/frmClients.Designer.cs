namespace PrjRemax__Akanksha_2014178
{
    partial class frmClients
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
            System.Windows.Forms.Button btnSearchAgents;
            System.Windows.Forms.Button btnSearchHouses;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            btnSearchAgents = new System.Windows.Forms.Button();
            btnSearchHouses = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchAgents
            // 
            btnSearchAgents.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSearchAgents.ForeColor = System.Drawing.Color.Blue;
            btnSearchAgents.Location = new System.Drawing.Point(72, 37);
            btnSearchAgents.Name = "btnSearchAgents";
            btnSearchAgents.Size = new System.Drawing.Size(210, 46);
            btnSearchAgents.TabIndex = 0;
            btnSearchAgents.Text = "Search Agents";
            btnSearchAgents.UseVisualStyleBackColor = true;
            btnSearchAgents.Click += new System.EventHandler(this.btnSearchAgents_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(btnSearchHouses);
            this.panel1.Controls.Add(btnSearchAgents);
            this.panel1.Location = new System.Drawing.Point(227, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 224);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO REMAX";
            // 
            // btnSearchHouses
            // 
            btnSearchHouses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSearchHouses.ForeColor = System.Drawing.Color.Blue;
            btnSearchHouses.Location = new System.Drawing.Point(72, 128);
            btnSearchHouses.Name = "btnSearchHouses";
            btnSearchHouses.Size = new System.Drawing.Size(210, 46);
            btnSearchHouses.TabIndex = 1;
            btnSearchHouses.Text = "Search Houses";
            btnSearchHouses.UseVisualStyleBackColor = true;
            btnSearchHouses.Click += new System.EventHandler(this.btnSearchHouses_Click);
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(806, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmClients";
            this.Text = "frmClients";
            this.Load += new System.EventHandler(this.frmClients_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}