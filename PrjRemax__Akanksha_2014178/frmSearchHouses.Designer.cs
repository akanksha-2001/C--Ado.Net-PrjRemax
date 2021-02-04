namespace PrjRemax__Akanksha_2014178
{
    partial class frmSearchHouses
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
            this.chkBed = new System.Windows.Forms.CheckBox();
            this.chkHouseType = new System.Windows.Forms.CheckBox();
            this.chkLoc = new System.Windows.Forms.CheckBox();
            this.chkPrice = new System.Windows.Forms.CheckBox();
            this.chkBath = new System.Windows.Forms.CheckBox();
            this.cmbed = new System.Windows.Forms.ComboBox();
            this.cmbBath = new System.Windows.Forms.ComboBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.gridViewResult = new System.Windows.Forms.DataGridView();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            this.lstRefId = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH - HOUSES";
            // 
            // chkBed
            // 
            this.chkBed.AutoSize = true;
            this.chkBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBed.Location = new System.Drawing.Point(159, 93);
            this.chkBed.Name = "chkBed";
            this.chkBed.Size = new System.Drawing.Size(98, 20);
            this.chkBed.TabIndex = 1;
            this.chkBed.Text = "Bedrooms";
            this.chkBed.UseVisualStyleBackColor = true;
            // 
            // chkHouseType
            // 
            this.chkHouseType.AutoSize = true;
            this.chkHouseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHouseType.Location = new System.Drawing.Point(159, 173);
            this.chkHouseType.Name = "chkHouseType";
            this.chkHouseType.Size = new System.Drawing.Size(112, 20);
            this.chkHouseType.TabIndex = 3;
            this.chkHouseType.Text = "House Type";
            this.chkHouseType.UseVisualStyleBackColor = true;
            // 
            // chkLoc
            // 
            this.chkLoc.AutoSize = true;
            this.chkLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoc.Location = new System.Drawing.Point(434, 92);
            this.chkLoc.Name = "chkLoc";
            this.chkLoc.Size = new System.Drawing.Size(86, 20);
            this.chkLoc.TabIndex = 4;
            this.chkLoc.Text = "Location";
            this.chkLoc.UseVisualStyleBackColor = true;
            // 
            // chkPrice
            // 
            this.chkPrice.AutoSize = true;
            this.chkPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrice.Location = new System.Drawing.Point(434, 134);
            this.chkPrice.Name = "chkPrice";
            this.chkPrice.Size = new System.Drawing.Size(63, 20);
            this.chkPrice.TabIndex = 5;
            this.chkPrice.Text = "Price";
            this.chkPrice.UseVisualStyleBackColor = true;
            // 
            // chkBath
            // 
            this.chkBath.AutoSize = true;
            this.chkBath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBath.Location = new System.Drawing.Point(159, 132);
            this.chkBath.Name = "chkBath";
            this.chkBath.Size = new System.Drawing.Size(101, 20);
            this.chkBath.TabIndex = 6;
            this.chkBath.Text = "Bathrooms";
            this.chkBath.UseVisualStyleBackColor = true;
            // 
            // cmbed
            // 
            this.cmbed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbed.FormattingEnabled = true;
            this.cmbed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbed.Location = new System.Drawing.Point(26, 89);
            this.cmbed.Name = "cmbed";
            this.cmbed.Size = new System.Drawing.Size(112, 24);
            this.cmbed.TabIndex = 7;
            // 
            // cmbBath
            // 
            this.cmbBath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBath.FormattingEnabled = true;
            this.cmbBath.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbBath.Location = new System.Drawing.Point(26, 128);
            this.cmbBath.Name = "cmbBath";
            this.cmbBath.Size = new System.Drawing.Size(112, 24);
            this.cmbBath.TabIndex = 8;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxPrice.Location = new System.Drawing.Point(290, 132);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(119, 22);
            this.txtMaxPrice.TabIndex = 10;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Penthouse",
            "Apartment",
            "Loft",
            "Unit"});
            this.cmbType.Location = new System.Drawing.Point(26, 171);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(112, 24);
            this.cmbType.TabIndex = 11;
            // 
            // gridViewResult
            // 
            this.gridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewResult.Location = new System.Drawing.Point(12, 257);
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.Size = new System.Drawing.Size(814, 244);
            this.gridViewResult.TabIndex = 13;
            // 
            // cmbLoc
            // 
            this.cmbLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Items.AddRange(new object[] {
            "Quebec",
            "Sakschetwan",
            "Ontario",
            "Nova Scotia",
            "Prince Edward",
            "New Foundland",
            "British Columbia",
            "Alberta",
            "Winnipeg"});
            this.cmbLoc.Location = new System.Drawing.Point(290, 91);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(119, 24);
            this.cmbLoc.TabIndex = 14;
            // 
            // lstRefId
            // 
            this.lstRefId.FormattingEnabled = true;
            this.lstRefId.Location = new System.Drawing.Point(571, 92);
            this.lstRefId.Name = "lstRefId";
            this.lstRefId.Size = new System.Drawing.Size(93, 95);
            this.lstRefId.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(670, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search By Ref Id ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(737, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSearchHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(838, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstRefId);
            this.Controls.Add(this.cmbLoc);
            this.Controls.Add(this.gridViewResult);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.cmbBath);
            this.Controls.Add(this.cmbed);
            this.Controls.Add(this.chkBath);
            this.Controls.Add(this.chkPrice);
            this.Controls.Add(this.chkLoc);
            this.Controls.Add(this.chkHouseType);
            this.Controls.Add(this.chkBed);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchHouses";
            this.Text = "frmSearchHouses";
            this.Load += new System.EventHandler(this.frmSearchHouses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBed;
        private System.Windows.Forms.CheckBox chkHouseType;
        private System.Windows.Forms.CheckBox chkLoc;
        private System.Windows.Forms.CheckBox chkPrice;
        private System.Windows.Forms.CheckBox chkBath;
        private System.Windows.Forms.ComboBox cmbed;
        private System.Windows.Forms.ComboBox cmbBath;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DataGridView gridViewResult;
        private System.Windows.Forms.ComboBox cmbLoc;
        private System.Windows.Forms.ListBox lstRefId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}