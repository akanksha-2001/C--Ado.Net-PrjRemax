namespace PrjRemax__Akanksha_2014178
{
    partial class frmSearchAgent
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstLoc = new System.Windows.Forms.ListBox();
            this.gridViewResult = new System.Windows.Forms.DataGridView();
            this.listEmpNum = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLoc = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEmpNum = new System.Windows.Forms.CheckBox();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH - AGENTS";
            // 
            // lstLoc
            // 
            this.lstLoc.FormattingEnabled = true;
            this.lstLoc.ItemHeight = 16;
            this.lstLoc.Location = new System.Drawing.Point(16, 30);
            this.lstLoc.Name = "lstLoc";
            this.lstLoc.Size = new System.Drawing.Size(111, 132);
            this.lstLoc.TabIndex = 1;
            // 
            // gridViewResult
            // 
            this.gridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewResult.Location = new System.Drawing.Point(10, 301);
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.Size = new System.Drawing.Size(778, 177);
            this.gridViewResult.TabIndex = 3;
            // 
            // listEmpNum
            // 
            this.listEmpNum.FormattingEnabled = true;
            this.listEmpNum.ItemHeight = 16;
            this.listEmpNum.Location = new System.Drawing.Point(22, 32);
            this.listEmpNum.Name = "listEmpNum";
            this.listEmpNum.Size = new System.Drawing.Size(118, 132);
            this.listEmpNum.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.chkLoc);
            this.groupBox1.Controls.Add(this.lstLoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Location :";
            // 
            // chkLoc
            // 
            this.chkLoc.Location = new System.Drawing.Point(159, 0);
            this.chkLoc.Name = "chkLoc";
            this.chkLoc.Size = new System.Drawing.Size(14, 19);
            this.chkLoc.TabIndex = 7;
            this.chkLoc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.chkEmpNum);
            this.groupBox2.Controls.Add(this.listEmpNum);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(494, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By EmpNumber";
            // 
            // chkEmpNum
            // 
            this.chkEmpNum.Location = new System.Drawing.Point(177, 0);
            this.chkEmpNum.Name = "chkEmpNum";
            this.chkEmpNum.Size = new System.Drawing.Size(14, 19);
            this.chkEmpNum.TabIndex = 8;
            this.chkEmpNum.UseVisualStyleBackColor = true;
            this.chkEmpNum.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(339, 170);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(90, 32);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // frmSearchAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridViewResult);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchAgent";
            this.Text = "SearchAgent";
            this.Load += new System.EventHandler(this.frmSearchAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLoc;
        private System.Windows.Forms.DataGridView gridViewResult;
        private System.Windows.Forms.ListBox listEmpNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkLoc;
        private System.Windows.Forms.CheckBox chkEmpNum;
        private System.Windows.Forms.Button btnFind;
    }
}