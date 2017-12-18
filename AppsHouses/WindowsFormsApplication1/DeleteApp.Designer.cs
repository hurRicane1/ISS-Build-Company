namespace WindowsFormsApplication1
{
    partial class DeleteApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOKAppNum = new System.Windows.Forms.Button();
            this.cbAppNum = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.txtRCID = new System.Windows.Forms.TextBox();
            this.btnOKType = new System.Windows.Forms.Button();
            this.btnOKRC = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAppType = new System.Windows.Forms.ComboBox();
            this.cbRC = new System.Windows.Forms.ComboBox();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbForSell = new System.Windows.Forms.RadioButton();
            this.rbSold = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.cbValue2 = new System.Windows.Forms.ComboBox();
            this.cbValue3 = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(486, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Видалення квартири";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Виберіть ЖК:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 36);
            this.label3.TabIndex = 18;
            this.label3.Text = "Виберіть тип:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(133, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 489);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Green;
            this.tabPage1.Controls.Add(this.btnOKAppNum);
            this.tabPage1.Controls.Add(this.cbAppNum);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txtTypeID);
            this.tabPage1.Controls.Add(this.txtRCID);
            this.tabPage1.Controls.Add(this.btnOKType);
            this.tabPage1.Controls.Add(this.btnOKRC);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbAppType);
            this.tabPage1.Controls.Add(this.cbRC);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtAppID);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1021, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Розширене видалення";
            // 
            // btnOKAppNum
            // 
            this.btnOKAppNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOKAppNum.BackColor = System.Drawing.Color.White;
            this.btnOKAppNum.FlatAppearance.BorderSize = 0;
            this.btnOKAppNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKAppNum.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKAppNum.Location = new System.Drawing.Point(848, 214);
            this.btnOKAppNum.Name = "btnOKAppNum";
            this.btnOKAppNum.Size = new System.Drawing.Size(53, 40);
            this.btnOKAppNum.TabIndex = 33;
            this.btnOKAppNum.Text = "ОК";
            this.btnOKAppNum.UseVisualStyleBackColor = false;
            this.btnOKAppNum.Click += new System.EventHandler(this.btnOKAppNum_Click);
            // 
            // cbAppNum
            // 
            this.cbAppNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAppNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppNum.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAppNum.FormattingEnabled = true;
            this.cbAppNum.Location = new System.Drawing.Point(362, 214);
            this.cbAppNum.Name = "cbAppNum";
            this.cbAppNum.Size = new System.Drawing.Size(456, 39);
            this.cbAppNum.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(6, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 31;
            // 
            // txtTypeID
            // 
            this.txtTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTypeID.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.Location = new System.Drawing.Point(69, 382);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(36, 40);
            this.txtTypeID.TabIndex = 30;
            // 
            // txtRCID
            // 
            this.txtRCID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRCID.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRCID.Location = new System.Drawing.Point(16, 382);
            this.txtRCID.Name = "txtRCID";
            this.txtRCID.Size = new System.Drawing.Size(36, 40);
            this.txtRCID.TabIndex = 29;
            // 
            // btnOKType
            // 
            this.btnOKType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOKType.BackColor = System.Drawing.Color.White;
            this.btnOKType.FlatAppearance.BorderSize = 0;
            this.btnOKType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKType.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKType.Location = new System.Drawing.Point(848, 138);
            this.btnOKType.Name = "btnOKType";
            this.btnOKType.Size = new System.Drawing.Size(53, 40);
            this.btnOKType.TabIndex = 28;
            this.btnOKType.Text = "ОК";
            this.btnOKType.UseVisualStyleBackColor = false;
            this.btnOKType.Click += new System.EventHandler(this.btnOKType_Click);
            // 
            // btnOKRC
            // 
            this.btnOKRC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOKRC.BackColor = System.Drawing.Color.White;
            this.btnOKRC.FlatAppearance.BorderSize = 0;
            this.btnOKRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKRC.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKRC.Location = new System.Drawing.Point(848, 65);
            this.btnOKRC.Name = "btnOKRC";
            this.btnOKRC.Size = new System.Drawing.Size(53, 39);
            this.btnOKRC.TabIndex = 27;
            this.btnOKRC.Text = "ОК";
            this.btnOKRC.UseVisualStyleBackColor = false;
            this.btnOKRC.Click += new System.EventHandler(this.btnOKRC_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(520, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(226, 40);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(275, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(226, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(103, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "Виберіть номер:";
            // 
            // cbAppType
            // 
            this.cbAppType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAppType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppType.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAppType.FormattingEnabled = true;
            this.cbAppType.Location = new System.Drawing.Point(362, 138);
            this.cbAppType.Name = "cbAppType";
            this.cbAppType.Size = new System.Drawing.Size(456, 39);
            this.cbAppType.TabIndex = 20;
            // 
            // cbRC
            // 
            this.cbRC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRC.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRC.FormattingEnabled = true;
            this.cbRC.Location = new System.Drawing.Point(362, 65);
            this.cbRC.Name = "cbRC";
            this.cbRC.Size = new System.Drawing.Size(456, 39);
            this.cbRC.TabIndex = 19;
            // 
            // txtAppID
            // 
            this.txtAppID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAppID.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppID.Location = new System.Drawing.Point(125, 382);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(36, 40);
            this.txtAppID.TabIndex = 34;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Green;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.rbForSell);
            this.tabPage2.Controls.Add(this.rbSold);
            this.tabPage2.Controls.Add(this.btnOK);
            this.tabPage2.Controls.Add(this.txtFloor);
            this.tabPage2.Controls.Add(this.txtValue2);
            this.tabPage2.Controls.Add(this.cbValue2);
            this.tabPage2.Controls.Add(this.cbValue3);
            this.tabPage2.Controls.Add(this.txtValue);
            this.tabPage2.Controls.Add(this.cbValue);
            this.tabPage2.Controls.Add(this.btnCancel2);
            this.tabPage2.Controls.Add(this.btnDelete2);
            this.tabPage2.Controls.Add(this.cbCriterio);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1021, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Масове видалення";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(6, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 93);
            this.panel2.TabIndex = 38;
            // 
            // rbForSell
            // 
            this.rbForSell.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbForSell.AutoSize = true;
            this.rbForSell.BackColor = System.Drawing.Color.Black;
            this.rbForSell.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbForSell.ForeColor = System.Drawing.Color.White;
            this.rbForSell.Location = new System.Drawing.Point(695, 208);
            this.rbForSell.Name = "rbForSell";
            this.rbForSell.Size = new System.Drawing.Size(165, 35);
            this.rbForSell.TabIndex = 37;
            this.rbForSell.TabStop = true;
            this.rbForSell.Text = "На продаж";
            this.rbForSell.UseVisualStyleBackColor = false;
            // 
            // rbSold
            // 
            this.rbSold.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbSold.AutoSize = true;
            this.rbSold.BackColor = System.Drawing.Color.Black;
            this.rbSold.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSold.ForeColor = System.Drawing.Color.White;
            this.rbSold.Location = new System.Drawing.Point(507, 208);
            this.rbSold.Name = "rbSold";
            this.rbSold.Size = new System.Drawing.Size(132, 35);
            this.rbSold.TabIndex = 36;
            this.rbSold.TabStop = true;
            this.rbSold.Text = "Продані";
            this.rbSold.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(678, 204);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 40);
            this.btnOK.TabIndex = 35;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFloor
            // 
            this.txtFloor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtFloor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFloor.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloor.Location = new System.Drawing.Point(450, 206);
            this.txtFloor.MaxLength = 2;
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(456, 37);
            this.txtFloor.TabIndex = 34;
            this.txtFloor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFloor_KeyPress);
            // 
            // txtValue2
            // 
            this.txtValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue2.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue2.Location = new System.Drawing.Point(78, 387);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(36, 40);
            this.txtValue2.TabIndex = 33;
            // 
            // cbValue2
            // 
            this.cbValue2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbValue2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue2.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValue2.FormattingEnabled = true;
            this.cbValue2.Location = new System.Drawing.Point(450, 204);
            this.cbValue2.Name = "cbValue2";
            this.cbValue2.Size = new System.Drawing.Size(222, 39);
            this.cbValue2.TabIndex = 32;
            // 
            // cbValue3
            // 
            this.cbValue3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbValue3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue3.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValue3.FormattingEnabled = true;
            this.cbValue3.Location = new System.Drawing.Point(737, 204);
            this.cbValue3.Name = "cbValue3";
            this.cbValue3.Size = new System.Drawing.Size(169, 39);
            this.cbValue3.TabIndex = 31;
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(36, 387);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(36, 40);
            this.txtValue.TabIndex = 30;
            // 
            // cbValue
            // 
            this.cbValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(450, 204);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(456, 39);
            this.cbValue.TabIndex = 28;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel2.BackColor = System.Drawing.Color.White;
            this.btnCancel2.FlatAppearance.BorderSize = 0;
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.Location = new System.Drawing.Point(518, 290);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(226, 49);
            this.btnCancel2.TabIndex = 27;
            this.btnCancel2.Text = "Відмінити";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete2.BackColor = System.Drawing.Color.White;
            this.btnDelete2.FlatAppearance.BorderSize = 0;
            this.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete2.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete2.Location = new System.Drawing.Point(276, 290);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(226, 49);
            this.btnDelete2.TabIndex = 26;
            this.btnDelete2.Text = "Видалити";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // cbCriterio
            // 
            this.cbCriterio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Items.AddRange(new object[] {
            "Житловий комплекс",
            "Тип",
            "Поверх",
            "Продаж"});
            this.cbCriterio.Location = new System.Drawing.Point(450, 115);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(456, 39);
            this.cbCriterio.TabIndex = 24;
            this.cbCriterio.SelectedIndexChanged += new System.EventHandler(this.cbCriterio_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(109, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "Виберіть значення:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "Виберіть критерій:";
            // 
            // DeleteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1295, 704);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 100);
            this.Name = "DeleteApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "я";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.DeleteApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbAppType;
        private System.Windows.Forms.ComboBox cbRC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOKType;
        private System.Windows.Forms.Button btnOKRC;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.TextBox txtRCID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOKAppNum;
        private System.Windows.Forms.ComboBox cbAppNum;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.ComboBox cbValue2;
        private System.Windows.Forms.ComboBox cbValue3;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbForSell;
        private System.Windows.Forms.RadioButton rbSold;
        private System.Windows.Forms.Panel panel2;
    }
}