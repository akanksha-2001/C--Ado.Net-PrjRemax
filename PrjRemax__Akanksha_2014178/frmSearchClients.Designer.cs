namespace PrjRemax_AKANKSHA_2014178
{
    partial class frmSearchClients
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
            this.chckLocation = new System.Windows.Forms.CheckBox();
            this.chckType = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewResult = new System.Windows.Forms.DataGridView();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // chckLocation
            // 
            this.chckLocation.AutoSize = true;
            this.chckLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckLocation.Location = new System.Drawing.Point(51, 92);
            this.chckLocation.Name = "chckLocation";
            this.chckLocation.Size = new System.Drawing.Size(184, 24);
            this.chckLocation.TabIndex = 0;
            this.chckLocation.Text = "Search By Location";
            this.chckLocation.UseVisualStyleBackColor = true;
            // 
            // chckType
            // 
            this.chckType.AutoSize = true;
            this.chckType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckType.Location = new System.Drawing.Point(451, 91);
            this.chckType.Name = "chckType";
            this.chckType.Size = new System.Drawing.Size(153, 24);
            this.chckType.TabIndex = 1;
            this.chckType.Text = "Search By Type";
            this.chckType.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "SEARCH - CLIENTS";
            // 
            // gridViewResult
            // 
            this.gridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewResult.Location = new System.Drawing.Point(25, 184);
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.Size = new System.Drawing.Size(749, 243);
            this.gridViewResult.TabIndex = 3;
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(241, 94);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(131, 20);
            this.txtLoc.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(610, 91);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(131, 20);
            this.txtType.TabIndex = 5;
            // 
            // frmSearchClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.gridViewResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chckType);
            this.Controls.Add(this.chckLocation);
            this.Name = "frmSearchClients";
            this.Text = "frmSearchClients";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckLocation;
        private System.Windows.Forms.CheckBox chckType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewResult;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.TextBox txtType;
    }
}