namespace WindowsFormsApplication1
{
    partial class Payments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbPaymentS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelS = new System.Windows.Forms.Button();
            this.btnPaymentS = new System.Windows.Forms.Button();
            this.cbPaymentS = new System.Windows.Forms.ComboBox();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOpenToPay = new System.Windows.Forms.Button();
            this.dgvToPay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneToPay = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtIncom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClientID = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAddPaymentContractID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToPay)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1271, 680);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Green;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvPayment);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1263, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Архів платежів";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbPaymentS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCancelS);
            this.groupBox2.Controls.Add(this.btnPaymentS);
            this.groupBox2.Controls.Add(this.cbPaymentS);
            this.groupBox2.Location = new System.Drawing.Point(120, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 196);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(190, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Виберіть критерій:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(199, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Введіть значення:";
            // 
            // txtbPaymentS
            // 
            this.txtbPaymentS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPaymentS.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPaymentS.Location = new System.Drawing.Point(411, 131);
            this.txtbPaymentS.Name = "txtbPaymentS";
            this.txtbPaymentS.Size = new System.Drawing.Size(266, 27);
            this.txtbPaymentS.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(464, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пошук:";
            // 
            // btnCancelS
            // 
            this.btnCancelS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelS.BackColor = System.Drawing.Color.White;
            this.btnCancelS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelS.FlatAppearance.BorderSize = 0;
            this.btnCancelS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelS.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnCancelS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelS.Location = new System.Drawing.Point(695, 125);
            this.btnCancelS.Name = "btnCancelS";
            this.btnCancelS.Size = new System.Drawing.Size(138, 35);
            this.btnCancelS.TabIndex = 8;
            this.btnCancelS.Text = "Показати все";
            this.btnCancelS.UseVisualStyleBackColor = false;
            this.btnCancelS.Click += new System.EventHandler(this.btnCancelS_Click);
            // 
            // btnPaymentS
            // 
            this.btnPaymentS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaymentS.BackColor = System.Drawing.Color.White;
            this.btnPaymentS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentS.FlatAppearance.BorderSize = 0;
            this.btnPaymentS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentS.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnPaymentS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPaymentS.Location = new System.Drawing.Point(695, 75);
            this.btnPaymentS.Name = "btnPaymentS";
            this.btnPaymentS.Size = new System.Drawing.Size(138, 35);
            this.btnPaymentS.TabIndex = 7;
            this.btnPaymentS.Text = "Пошук";
            this.btnPaymentS.UseVisualStyleBackColor = false;
            this.btnPaymentS.Click += new System.EventHandler(this.btnPaymentS_Click);
            // 
            // cbPaymentS
            // 
            this.cbPaymentS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaymentS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentS.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentS.FormattingEnabled = true;
            this.cbPaymentS.Items.AddRange(new object[] {
            "Номер платежу",
            "П.І.Б. Клієнта",
            "Номер договору",
            "Дата договору",
            "Дата платежу"});
            this.cbPaymentS.Location = new System.Drawing.Point(411, 75);
            this.cbPaymentS.Name = "cbPaymentS";
            this.cbPaymentS.Size = new System.Drawing.Size(266, 29);
            this.cbPaymentS.TabIndex = 0;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(75, 10);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.Size = new System.Drawing.Size(1113, 422);
            this.dgvPayment.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Green;
            this.tabPage2.Controls.Add(this.btnOpenToPay);
            this.tabPage2.Controls.Add(this.dgvToPay);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtPhoneToPay);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1263, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "До оплати";
            // 
            // btnOpenToPay
            // 
            this.btnOpenToPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenToPay.BackColor = System.Drawing.Color.White;
            this.btnOpenToPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenToPay.FlatAppearance.BorderSize = 0;
            this.btnOpenToPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenToPay.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenToPay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenToPay.Location = new System.Drawing.Point(532, 547);
            this.btnOpenToPay.Name = "btnOpenToPay";
            this.btnOpenToPay.Size = new System.Drawing.Size(198, 53);
            this.btnOpenToPay.TabIndex = 20;
            this.btnOpenToPay.Text = "Відкрити";
            this.btnOpenToPay.UseVisualStyleBackColor = false;
            this.btnOpenToPay.Click += new System.EventHandler(this.btnOpenToPay_Click);
            // 
            // dgvToPay
            // 
            this.dgvToPay.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvToPay.AllowUserToAddRows = false;
            this.dgvToPay.AllowUserToDeleteRows = false;
            this.dgvToPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvToPay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvToPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToPay.Location = new System.Drawing.Point(163, 15);
            this.dgvToPay.Name = "dgvToPay";
            this.dgvToPay.ReadOnly = true;
            this.dgvToPay.Size = new System.Drawing.Size(937, 422);
            this.dgvToPay.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(481, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Телефон:";
            // 
            // txtPhoneToPay
            // 
            this.txtPhoneToPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneToPay.Font = new System.Drawing.Font("Amazing Grotesk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneToPay.Location = new System.Drawing.Point(617, 465);
            this.txtPhoneToPay.Name = "txtPhoneToPay";
            this.txtPhoneToPay.ReadOnly = true;
            this.txtPhoneToPay.Size = new System.Drawing.Size(164, 37);
            this.txtPhoneToPay.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Green;
            this.tabPage3.Controls.Add(this.cbType);
            this.tabPage3.Controls.Add(this.txtIncom);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnClientID);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cbClient);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cbAddPaymentContractID);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1263, 645);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Додати платіж";
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Перший внесок",
            "Квартальний"});
            this.cbType.Location = new System.Drawing.Point(709, 226);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(266, 35);
            this.cbType.TabIndex = 30;
            // 
            // txtIncom
            // 
            this.txtIncom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIncom.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncom.Location = new System.Drawing.Point(709, 324);
            this.txtIncom.Name = "txtIncom";
            this.txtIncom.Size = new System.Drawing.Size(266, 34);
            this.txtIncom.TabIndex = 29;
            this.txtIncom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIncom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(623, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 36);
            this.label6.TabIndex = 27;
            this.label6.Text = "Виберіть тип платежу::";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(688, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 36);
            this.label7.TabIndex = 26;
            this.label7.Text = "Внесена сума (грн):";
            // 
            // btnClientID
            // 
            this.btnClientID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClientID.BackColor = System.Drawing.Color.White;
            this.btnClientID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientID.FlatAppearance.BorderSize = 0;
            this.btnClientID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientID.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnClientID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClientID.Location = new System.Drawing.Point(508, 226);
            this.btnClientID.Name = "btnClientID";
            this.btnClientID.Size = new System.Drawing.Size(48, 35);
            this.btnClientID.TabIndex = 25;
            this.btnClientID.Text = "ОК";
            this.btnClientID.UseVisualStyleBackColor = false;
            this.btnClientID.Click += new System.EventHandler(this.btnClientID_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(219, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "Виберіть клієнта:";
            // 
            // cbClient
            // 
            this.cbClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Items.AddRange(new object[] {
            "Житловий комплекс"});
            this.cbClient.Location = new System.Drawing.Point(222, 226);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(266, 35);
            this.cbClient.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(105, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Виберіть номер договору:";
            // 
            // cbAddPaymentContractID
            // 
            this.cbAddPaymentContractID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddPaymentContractID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddPaymentContractID.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddPaymentContractID.FormattingEnabled = true;
            this.cbAddPaymentContractID.Items.AddRange(new object[] {
            "Житловий комплекс"});
            this.cbAddPaymentContractID.Location = new System.Drawing.Point(222, 326);
            this.cbAddPaymentContractID.Name = "cbAddPaymentContractID";
            this.cbAddPaymentContractID.Size = new System.Drawing.Size(266, 35);
            this.cbAddPaymentContractID.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(591, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 53);
            this.button1.TabIndex = 19;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientID.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(52, 694);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(41, 34);
            this.txtClientID.TabIndex = 31;
            this.txtClientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(52, 694);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 40);
            this.panel1.TabIndex = 12;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1295, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 100);
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.Payments_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToPay)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbPaymentS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelS;
        private System.Windows.Forms.Button btnPaymentS;
        private System.Windows.Forms.ComboBox cbPaymentS;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridView dgvToPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneToPay;
        private System.Windows.Forms.Button btnOpenToPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAddPaymentContractID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtIncom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClientID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Panel panel1;
    }
}