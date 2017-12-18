namespace WindowsFormsApplication1
{
    partial class Apps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apps));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvApps = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.rbMore = new System.Windows.Forms.RadioButton();
            this.rbForSell = new System.Windows.Forms.RadioButton();
            this.rbSold = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbAppS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelS = new System.Windows.Forms.Button();
            this.btnAppS = new System.Windows.Forms.Button();
            this.cbClientS = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtbTPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbPriceM2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbRoomAm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbAppNum = new System.Windows.Forms.TextBox();
            this.txtbFloor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbTArea = new System.Windows.Forms.TextBox();
            this.txtbLArea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbAppType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbRC = new System.Windows.Forms.TextBox();
            this.rcLbl = new System.Windows.Forms.Label();
            this.gpImage = new System.Windows.Forms.GroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpInfo.SuspendLayout();
            this.gpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApps
            // 
            this.dgvApps.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvApps.AllowUserToAddRows = false;
            this.dgvApps.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgvApps, "dgvApps");
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApps.Name = "dgvApps";
            this.dgvApps.ReadOnly = true;
            this.dgvApps.Click += new System.EventHandler(this.dgvApps_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.rbForSell);
            this.groupBox2.Controls.Add(this.rbSold);
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbAppS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCancelS);
            this.groupBox2.Controls.Add(this.btnAppS);
            this.groupBox2.Controls.Add(this.cbClientS);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.rbEqual);
            this.panel1.Controls.Add(this.rbLess);
            this.panel1.Controls.Add(this.rbMore);
            this.panel1.Name = "panel1";
            // 
            // rbEqual
            // 
            resources.ApplyResources(this.rbEqual, "rbEqual");
            this.rbEqual.BackColor = System.Drawing.Color.Black;
            this.rbEqual.ForeColor = System.Drawing.Color.White;
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.TabStop = true;
            this.rbEqual.UseVisualStyleBackColor = false;
            // 
            // rbLess
            // 
            resources.ApplyResources(this.rbLess, "rbLess");
            this.rbLess.BackColor = System.Drawing.Color.Black;
            this.rbLess.ForeColor = System.Drawing.Color.White;
            this.rbLess.Name = "rbLess";
            this.rbLess.TabStop = true;
            this.rbLess.UseVisualStyleBackColor = false;
            // 
            // rbMore
            // 
            resources.ApplyResources(this.rbMore, "rbMore");
            this.rbMore.BackColor = System.Drawing.Color.Black;
            this.rbMore.ForeColor = System.Drawing.Color.White;
            this.rbMore.Name = "rbMore";
            this.rbMore.TabStop = true;
            this.rbMore.UseVisualStyleBackColor = false;
            // 
            // rbForSell
            // 
            resources.ApplyResources(this.rbForSell, "rbForSell");
            this.rbForSell.BackColor = System.Drawing.Color.Black;
            this.rbForSell.ForeColor = System.Drawing.Color.White;
            this.rbForSell.Name = "rbForSell";
            this.rbForSell.TabStop = true;
            this.rbForSell.UseVisualStyleBackColor = false;
            this.rbForSell.CheckedChanged += new System.EventHandler(this.rbForSell_CheckedChanged);
            // 
            // rbSold
            // 
            resources.ApplyResources(this.rbSold, "rbSold");
            this.rbSold.BackColor = System.Drawing.Color.Black;
            this.rbSold.ForeColor = System.Drawing.Color.White;
            this.rbSold.Name = "rbSold";
            this.rbSold.TabStop = true;
            this.rbSold.UseVisualStyleBackColor = false;
            this.rbSold.CheckedChanged += new System.EventHandler(this.chbSold_CheckedChanged);
            // 
            // rbAll
            // 
            resources.ApplyResources(this.rbAll, "rbAll");
            this.rbAll.BackColor = System.Drawing.Color.Black;
            this.rbAll.ForeColor = System.Drawing.Color.White;
            this.rbAll.Name = "rbAll";
            this.rbAll.TabStop = true;
            this.rbAll.UseVisualStyleBackColor = false;
            this.rbAll.CheckedChanged += new System.EventHandler(this.chBAll_CheckedChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // txtbAppS
            // 
            resources.ApplyResources(this.txtbAppS, "txtbAppS");
            this.txtbAppS.Name = "txtbAppS";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // btnCancelS
            // 
            resources.ApplyResources(this.btnCancelS, "btnCancelS");
            this.btnCancelS.BackColor = System.Drawing.Color.White;
            this.btnCancelS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelS.FlatAppearance.BorderSize = 0;
            this.btnCancelS.Name = "btnCancelS";
            this.btnCancelS.UseVisualStyleBackColor = false;
            this.btnCancelS.Click += new System.EventHandler(this.btnCancelS_Click);
            // 
            // btnAppS
            // 
            resources.ApplyResources(this.btnAppS, "btnAppS");
            this.btnAppS.BackColor = System.Drawing.Color.White;
            this.btnAppS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppS.FlatAppearance.BorderSize = 0;
            this.btnAppS.Name = "btnAppS";
            this.btnAppS.UseVisualStyleBackColor = false;
            this.btnAppS.Click += new System.EventHandler(this.btnAppS_Click);
            // 
            // cbClientS
            // 
            resources.ApplyResources(this.cbClientS, "cbClientS");
            this.cbClientS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientS.FormattingEnabled = true;
            this.cbClientS.Items.AddRange(new object[] {
            resources.GetString("cbClientS.Items"),
            resources.GetString("cbClientS.Items1"),
            resources.GetString("cbClientS.Items2"),
            resources.GetString("cbClientS.Items3"),
            resources.GetString("cbClientS.Items4"),
            resources.GetString("cbClientS.Items5"),
            resources.GetString("cbClientS.Items6")});
            this.cbClientS.Name = "cbClientS";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gpInfo
            // 
            resources.ApplyResources(this.gpInfo, "gpInfo");
            this.gpInfo.Controls.Add(this.btnImage);
            this.gpInfo.Controls.Add(this.txtbTPrice);
            this.gpInfo.Controls.Add(this.label13);
            this.gpInfo.Controls.Add(this.txtbPriceM2);
            this.gpInfo.Controls.Add(this.label12);
            this.gpInfo.Controls.Add(this.txtbRoomAm);
            this.gpInfo.Controls.Add(this.label10);
            this.gpInfo.Controls.Add(this.txtbAppNum);
            this.gpInfo.Controls.Add(this.txtbFloor);
            this.gpInfo.Controls.Add(this.label9);
            this.gpInfo.Controls.Add(this.label7);
            this.gpInfo.Controls.Add(this.txtbTArea);
            this.gpInfo.Controls.Add(this.txtbLArea);
            this.gpInfo.Controls.Add(this.label6);
            this.gpInfo.Controls.Add(this.label5);
            this.gpInfo.Controls.Add(this.txtbAppType);
            this.gpInfo.Controls.Add(this.label2);
            this.gpInfo.Controls.Add(this.txtbRC);
            this.gpInfo.Controls.Add(this.rcLbl);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.TabStop = false;
            // 
            // btnImage
            // 
            resources.ApplyResources(this.btnImage, "btnImage");
            this.btnImage.BackColor = System.Drawing.Color.White;
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.Name = "btnImage";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtbTPrice
            // 
            resources.ApplyResources(this.txtbTPrice, "txtbTPrice");
            this.txtbTPrice.Name = "txtbTPrice";
            this.txtbTPrice.ReadOnly = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Name = "label13";
            // 
            // txtbPriceM2
            // 
            resources.ApplyResources(this.txtbPriceM2, "txtbPriceM2");
            this.txtbPriceM2.Name = "txtbPriceM2";
            this.txtbPriceM2.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Name = "label12";
            // 
            // txtbRoomAm
            // 
            resources.ApplyResources(this.txtbRoomAm, "txtbRoomAm");
            this.txtbRoomAm.Name = "txtbRoomAm";
            this.txtbRoomAm.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            // 
            // txtbAppNum
            // 
            resources.ApplyResources(this.txtbAppNum, "txtbAppNum");
            this.txtbAppNum.Name = "txtbAppNum";
            this.txtbAppNum.ReadOnly = true;
            // 
            // txtbFloor
            // 
            resources.ApplyResources(this.txtbFloor, "txtbFloor");
            this.txtbFloor.Name = "txtbFloor";
            this.txtbFloor.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // txtbTArea
            // 
            resources.ApplyResources(this.txtbTArea, "txtbTArea");
            this.txtbTArea.Name = "txtbTArea";
            this.txtbTArea.ReadOnly = true;
            // 
            // txtbLArea
            // 
            resources.ApplyResources(this.txtbLArea, "txtbLArea");
            this.txtbLArea.Name = "txtbLArea";
            this.txtbLArea.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // txtbAppType
            // 
            resources.ApplyResources(this.txtbAppType, "txtbAppType");
            this.txtbAppType.Name = "txtbAppType";
            this.txtbAppType.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // txtbRC
            // 
            resources.ApplyResources(this.txtbRC, "txtbRC");
            this.txtbRC.BackColor = System.Drawing.SystemColors.Control;
            this.txtbRC.Name = "txtbRC";
            this.txtbRC.ReadOnly = true;
            // 
            // rcLbl
            // 
            resources.ApplyResources(this.rcLbl, "rcLbl");
            this.rcLbl.BackColor = System.Drawing.Color.Black;
            this.rcLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rcLbl.ForeColor = System.Drawing.Color.White;
            this.rcLbl.Name = "rcLbl";
            // 
            // gpImage
            // 
            resources.ApplyResources(this.gpImage, "gpImage");
            this.gpImage.Controls.Add(this.pbImage);
            this.gpImage.Controls.Add(this.btnInfo);
            this.gpImage.Name = "gpImage";
            this.gpImage.TabStop = false;
            // 
            // pbImage
            // 
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.BackColor = System.Drawing.Color.DimGray;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // btnInfo
            // 
            resources.ApplyResources(this.btnInfo, "btnInfo");
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // txtAppID
            // 
            resources.ApplyResources(this.txtAppID, "txtAppID");
            this.txtAppID.Name = "txtAppID";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Apps
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.gpImage);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtAppID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvApps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Apps";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.Apps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.gpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvApps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbAppS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelS;
        private System.Windows.Forms.Button btnAppS;
        private System.Windows.Forms.ComboBox cbClientS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.Label rcLbl;
        private System.Windows.Forms.TextBox txtbRC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbAppType;
        private System.Windows.Forms.TextBox txtbTArea;
        private System.Windows.Forms.TextBox txtbLArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbAppNum;
        private System.Windows.Forms.TextBox txtbFloor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbRoomAm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbTPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbPriceM2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbForSell;
        private System.Windows.Forms.RadioButton rbSold;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbMore;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.GroupBox gpImage;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.Panel panel2;
    }
}