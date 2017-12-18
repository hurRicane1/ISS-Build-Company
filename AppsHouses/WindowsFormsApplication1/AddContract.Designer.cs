namespace WindowsFormsApplication1
{
    partial class AddContract
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
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbRC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkbParking = new System.Windows.Forms.CheckBox();
            this.checkbFooter = new System.Windows.Forms.CheckBox();
            this.checkbComArea = new System.Windows.Forms.CheckBox();
            this.checkbApp = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAppNum = new System.Windows.Forms.ComboBox();
            this.cbComNum = new System.Windows.Forms.ComboBox();
            this.cbFooterNum = new System.Windows.Forms.ComboBox();
            this.cbParkingNum = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtRCID = new System.Windows.Forms.TextBox();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtAppPrice = new System.Windows.Forms.TextBox();
            this.txtComPrice = new System.Windows.Forms.TextBox();
            this.txtFooterPrice = new System.Windows.Forms.TextBox();
            this.txtParkingPrice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdImage
            // 
            this.ofdImage.Title = "Відкрити зображення";
            // 
            // txtbName
            // 
            this.txtbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtbName.BackColor = System.Drawing.SystemColors.Control;
            this.txtbName.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbName.Location = new System.Drawing.Point(267, 202);
            this.txtbName.Name = "txtbName";
            this.txtbName.ReadOnly = true;
            this.txtbName.Size = new System.Drawing.Size(373, 28);
            this.txtbName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(262, 151);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(178, 28);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "П. І. Б. Клієнта:";
            // 
            // cbRC
            // 
            this.cbRC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRC.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRC.FormattingEnabled = true;
            this.cbRC.Items.AddRange(new object[] {
            "Номер клієнта",
            "Ім\'я клієнта",
            "Номер телефону",
            "Паспортні дані"});
            this.cbRC.Location = new System.Drawing.Point(267, 297);
            this.cbRC.Name = "cbRC";
            this.cbRC.Size = new System.Drawing.Size(329, 28);
            this.cbRC.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Виберіть ЖК:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.checkbParking);
            this.groupBox1.Controls.Add(this.checkbFooter);
            this.groupBox1.Controls.Add(this.checkbComArea);
            this.groupBox1.Controls.Add(this.checkbApp);
            this.groupBox1.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(267, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 104);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // checkbParking
            // 
            this.checkbParking.AutoSize = true;
            this.checkbParking.BackColor = System.Drawing.Color.Black;
            this.checkbParking.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbParking.ForeColor = System.Drawing.Color.White;
            this.checkbParking.Location = new System.Drawing.Point(206, 60);
            this.checkbParking.Name = "checkbParking";
            this.checkbParking.Size = new System.Drawing.Size(110, 29);
            this.checkbParking.TabIndex = 3;
            this.checkbParking.Text = "Паркінг";
            this.checkbParking.UseVisualStyleBackColor = false;
            this.checkbParking.CheckedChanged += new System.EventHandler(this.checkbParking_CheckedChanged);
            // 
            // checkbFooter
            // 
            this.checkbFooter.AutoSize = true;
            this.checkbFooter.BackColor = System.Drawing.Color.Black;
            this.checkbFooter.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbFooter.ForeColor = System.Drawing.Color.White;
            this.checkbFooter.Location = new System.Drawing.Point(40, 60);
            this.checkbFooter.Name = "checkbFooter";
            this.checkbFooter.Size = new System.Drawing.Size(101, 29);
            this.checkbFooter.TabIndex = 2;
            this.checkbFooter.Text = "Підвал";
            this.checkbFooter.UseVisualStyleBackColor = false;
            this.checkbFooter.CheckedChanged += new System.EventHandler(this.checkbFooter_CheckedChanged);
            // 
            // checkbComArea
            // 
            this.checkbComArea.AutoSize = true;
            this.checkbComArea.BackColor = System.Drawing.Color.Black;
            this.checkbComArea.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbComArea.ForeColor = System.Drawing.Color.White;
            this.checkbComArea.Location = new System.Drawing.Point(206, 16);
            this.checkbComArea.Name = "checkbComArea";
            this.checkbComArea.Size = new System.Drawing.Size(126, 29);
            this.checkbComArea.TabIndex = 1;
            this.checkbComArea.Text = "Комерція";
            this.checkbComArea.UseVisualStyleBackColor = false;
            this.checkbComArea.CheckedChanged += new System.EventHandler(this.checkbComArea_CheckedChanged);
            // 
            // checkbApp
            // 
            this.checkbApp.AutoSize = true;
            this.checkbApp.BackColor = System.Drawing.Color.Black;
            this.checkbApp.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbApp.ForeColor = System.Drawing.Color.White;
            this.checkbApp.Location = new System.Drawing.Point(40, 16);
            this.checkbApp.Name = "checkbApp";
            this.checkbApp.Size = new System.Drawing.Size(129, 29);
            this.checkbApp.TabIndex = 0;
            this.checkbApp.Text = "Квартира";
            this.checkbApp.UseVisualStyleBackColor = false;
            this.checkbApp.CheckedChanged += new System.EventHandler(this.checkbApp_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(504, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Укладення договору";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(808, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Номер квартири:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(808, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер комерції:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(808, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Номер паркінгу:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(808, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Номер підвалу:";
            // 
            // cbAppNum
            // 
            this.cbAppNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAppNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppNum.Enabled = false;
            this.cbAppNum.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAppNum.FormattingEnabled = true;
            this.cbAppNum.Items.AddRange(new object[] {
            "Номер клієнта",
            "Ім\'я клієнта",
            "Номер телефону",
            "Паспортні дані"});
            this.cbAppNum.Location = new System.Drawing.Point(813, 185);
            this.cbAppNum.Name = "cbAppNum";
            this.cbAppNum.Size = new System.Drawing.Size(219, 25);
            this.cbAppNum.TabIndex = 17;
            // 
            // cbComNum
            // 
            this.cbComNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbComNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComNum.Enabled = false;
            this.cbComNum.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComNum.FormattingEnabled = true;
            this.cbComNum.Items.AddRange(new object[] {
            "Номер клієнта",
            "Ім\'я клієнта",
            "Номер телефону",
            "Паспортні дані"});
            this.cbComNum.Location = new System.Drawing.Point(813, 264);
            this.cbComNum.Name = "cbComNum";
            this.cbComNum.Size = new System.Drawing.Size(219, 25);
            this.cbComNum.TabIndex = 18;
            // 
            // cbFooterNum
            // 
            this.cbFooterNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFooterNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFooterNum.Enabled = false;
            this.cbFooterNum.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFooterNum.FormattingEnabled = true;
            this.cbFooterNum.Items.AddRange(new object[] {
            "Номер клієнта",
            "Ім\'я клієнта",
            "Номер телефону",
            "Паспортні дані"});
            this.cbFooterNum.Location = new System.Drawing.Point(813, 345);
            this.cbFooterNum.Name = "cbFooterNum";
            this.cbFooterNum.Size = new System.Drawing.Size(219, 25);
            this.cbFooterNum.TabIndex = 19;
            // 
            // cbParkingNum
            // 
            this.cbParkingNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbParkingNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParkingNum.Enabled = false;
            this.cbParkingNum.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParkingNum.FormattingEnabled = true;
            this.cbParkingNum.Items.AddRange(new object[] {
            "Номер клієнта",
            "Ім\'я клієнта",
            "Номер телефону",
            "Паспортні дані"});
            this.cbParkingNum.Location = new System.Drawing.Point(813, 426);
            this.cbParkingNum.Name = "cbParkingNum";
            this.cbParkingNum.Size = new System.Drawing.Size(219, 25);
            this.cbParkingNum.TabIndex = 20;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(602, 297);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(38, 28);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtRCID
            // 
            this.txtRCID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRCID.BackColor = System.Drawing.SystemColors.Control;
            this.txtRCID.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRCID.Location = new System.Drawing.Point(428, 256);
            this.txtRCID.Name = "txtRCID";
            this.txtRCID.ReadOnly = true;
            this.txtRCID.Size = new System.Drawing.Size(34, 24);
            this.txtRCID.TabIndex = 28;
            // 
            // txtAppID
            // 
            this.txtAppID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppID.BackColor = System.Drawing.SystemColors.Control;
            this.txtAppID.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppID.Location = new System.Drawing.Point(998, 149);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.ReadOnly = true;
            this.txtAppID.Size = new System.Drawing.Size(34, 24);
            this.txtAppID.TabIndex = 29;
            // 
            // txtClientID
            // 
            this.txtClientID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClientID.BackColor = System.Drawing.SystemColors.Control;
            this.txtClientID.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(446, 155);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(34, 24);
            this.txtClientID.TabIndex = 33;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(658, 557);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 31);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Відміна";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(461, 557);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 31);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Добавити";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTerm
            // 
            this.txtTerm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTerm.BackColor = System.Drawing.SystemColors.Control;
            this.txtTerm.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerm.Location = new System.Drawing.Point(473, 256);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.ReadOnly = true;
            this.txtTerm.Size = new System.Drawing.Size(34, 24);
            this.txtTerm.TabIndex = 36;
            // 
            // txtAppPrice
            // 
            this.txtAppPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtAppPrice.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppPrice.Location = new System.Drawing.Point(1038, 148);
            this.txtAppPrice.Name = "txtAppPrice";
            this.txtAppPrice.ReadOnly = true;
            this.txtAppPrice.Size = new System.Drawing.Size(34, 24);
            this.txtAppPrice.TabIndex = 37;
            // 
            // txtComPrice
            // 
            this.txtComPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtComPrice.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComPrice.Location = new System.Drawing.Point(986, 225);
            this.txtComPrice.Name = "txtComPrice";
            this.txtComPrice.ReadOnly = true;
            this.txtComPrice.Size = new System.Drawing.Size(34, 24);
            this.txtComPrice.TabIndex = 38;
            // 
            // txtFooterPrice
            // 
            this.txtFooterPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFooterPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtFooterPrice.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFooterPrice.Location = new System.Drawing.Point(980, 305);
            this.txtFooterPrice.Name = "txtFooterPrice";
            this.txtFooterPrice.ReadOnly = true;
            this.txtFooterPrice.Size = new System.Drawing.Size(34, 24);
            this.txtFooterPrice.TabIndex = 39;
            // 
            // txtParkingPrice
            // 
            this.txtParkingPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParkingPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtParkingPrice.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParkingPrice.Location = new System.Drawing.Point(989, 387);
            this.txtParkingPrice.Name = "txtParkingPrice";
            this.txtParkingPrice.ReadOnly = true;
            this.txtParkingPrice.Size = new System.Drawing.Size(34, 24);
            this.txtParkingPrice.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Location = new System.Drawing.Point(446, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 31);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.Location = new System.Drawing.Point(428, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 31);
            this.panel2.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(998, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(74, 31);
            this.panel3.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Location = new System.Drawing.Point(986, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 31);
            this.panel4.TabIndex = 44;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Location = new System.Drawing.Point(980, 304);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(48, 31);
            this.panel5.TabIndex = 45;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Location = new System.Drawing.Point(989, 387);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(48, 31);
            this.panel6.TabIndex = 46;
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1295, 704);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtParkingPrice);
            this.Controls.Add(this.txtFooterPrice);
            this.Controls.Add(this.txtComPrice);
            this.Controls.Add(this.txtAppPrice);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtAppID);
            this.Controls.Add(this.txtRCID);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbParkingNum);
            this.Controls.Add(this.cbFooterNum);
            this.Controls.Add(this.cbComNum);
            this.Controls.Add(this.cbAppNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRC);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 100);
            this.Name = "AddContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.AddContract_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbRC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkbParking;
        private System.Windows.Forms.CheckBox checkbFooter;
        private System.Windows.Forms.CheckBox checkbComArea;
        private System.Windows.Forms.CheckBox checkbApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAppNum;
        private System.Windows.Forms.ComboBox cbComNum;
        private System.Windows.Forms.ComboBox cbFooterNum;
        private System.Windows.Forms.ComboBox cbParkingNum;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtRCID;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtAppPrice;
        private System.Windows.Forms.TextBox txtComPrice;
        private System.Windows.Forms.TextBox txtFooterPrice;
        private System.Windows.Forms.TextBox txtParkingPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}