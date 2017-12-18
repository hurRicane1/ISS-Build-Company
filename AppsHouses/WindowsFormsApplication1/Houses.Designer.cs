namespace WindowsFormsApplication1
{
    partial class Houses
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
            this.dgvRC = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtWallMat = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtbCross = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBldngAm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbRC = new System.Windows.Forms.TextBox();
            this.rcLbl = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.rbMore = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbRcS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelS = new System.Windows.Forms.Button();
            this.btnRCS = new System.Windows.Forms.Button();
            this.cbRcS = new System.Windows.Forms.ComboBox();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRCID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRC)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRC
            // 
            this.dgvRC.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvRC.AllowUserToAddRows = false;
            this.dgvRC.AllowUserToDeleteRows = false;
            this.dgvRC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRC.Location = new System.Drawing.Point(12, 12);
            this.dgvRC.Name = "dgvRC";
            this.dgvRC.ReadOnly = true;
            this.dgvRC.Size = new System.Drawing.Size(495, 469);
            this.dgvRC.TabIndex = 7;
            this.dgvRC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRC_CellClick);
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.btnImage);
            this.gbInfo.Controls.Add(this.rtxtInfo);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.rtxtWallMat);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.rtxtbCross);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.txtBldngAm);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtAddress);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.txtbRC);
            this.gbInfo.Controls.Add(this.rcLbl);
            this.gbInfo.Location = new System.Drawing.Point(513, 6);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(770, 686);
            this.gbInfo.TabIndex = 11;
            this.gbInfo.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImage.BackColor = System.Drawing.Color.White;
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnImage.Location = new System.Drawing.Point(324, 635);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(123, 34);
            this.btnImage.TabIndex = 22;
            this.btnImage.Text = "Фото";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtInfo.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInfo.Location = new System.Drawing.Point(154, 549);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.ReadOnly = true;
            this.rtxtInfo.Size = new System.Drawing.Size(468, 63);
            this.rtxtInfo.TabIndex = 21;
            this.rtxtInfo.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(267, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Додаткова інформація:";
            // 
            // rtxtWallMat
            // 
            this.rtxtWallMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtWallMat.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtWallMat.Location = new System.Drawing.Point(154, 430);
            this.rtxtWallMat.Name = "rtxtWallMat";
            this.rtxtWallMat.ReadOnly = true;
            this.rtxtWallMat.Size = new System.Drawing.Size(468, 63);
            this.rtxtWallMat.TabIndex = 19;
            this.rtxtWallMat.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(302, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Матеріали стін:";
            // 
            // rtxtbCross
            // 
            this.rtxtbCross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtbCross.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbCross.Location = new System.Drawing.Point(154, 318);
            this.rtxtbCross.Name = "rtxtbCross";
            this.rtxtbCross.ReadOnly = true;
            this.rtxtbCross.Size = new System.Drawing.Size(468, 63);
            this.rtxtbCross.TabIndex = 17;
            this.rtxtbCross.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(319, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Перекриття:";
            // 
            // txtBldngAm
            // 
            this.txtBldngAm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBldngAm.BackColor = System.Drawing.SystemColors.Control;
            this.txtBldngAm.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtBldngAm.Location = new System.Drawing.Point(357, 236);
            this.txtBldngAm.Name = "txtBldngAm";
            this.txtBldngAm.ReadOnly = true;
            this.txtBldngAm.Size = new System.Drawing.Size(265, 28);
            this.txtBldngAm.TabIndex = 15;
            this.txtBldngAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(149, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Кількість під\'їздів:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(154, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(468, 28);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(344, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Адреса:";
            // 
            // txtbRC
            // 
            this.txtbRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRC.BackColor = System.Drawing.SystemColors.Control;
            this.txtbRC.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtbRC.Location = new System.Drawing.Point(154, 112);
            this.txtbRC.Name = "txtbRC";
            this.txtbRC.ReadOnly = true;
            this.txtbRC.Size = new System.Drawing.Size(468, 28);
            this.txtbRC.TabIndex = 7;
            this.txtbRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rcLbl
            // 
            this.rcLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rcLbl.AutoSize = true;
            this.rcLbl.BackColor = System.Drawing.Color.Black;
            this.rcLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rcLbl.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold);
            this.rcLbl.ForeColor = System.Drawing.Color.White;
            this.rcLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rcLbl.Location = new System.Drawing.Point(273, 75);
            this.rcLbl.Name = "rcLbl";
            this.rcLbl.Size = new System.Drawing.Size(230, 25);
            this.rcLbl.TabIndex = 6;
            this.rcLbl.Text = "Житловий комплекс:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(141, 487);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 34);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(12, 487);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 34);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Добавити";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbRcS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCancelS);
            this.groupBox2.Controls.Add(this.btnRCS);
            this.groupBox2.Controls.Add(this.cbRcS);
            this.groupBox2.Location = new System.Drawing.Point(12, 520);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 172);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rbEqual);
            this.panel1.Controls.Add(this.rbLess);
            this.panel1.Controls.Add(this.rbMore);
            this.panel1.Location = new System.Drawing.Point(12, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 38);
            this.panel1.TabIndex = 28;
            // 
            // rbEqual
            // 
            this.rbEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbEqual.AutoSize = true;
            this.rbEqual.BackColor = System.Drawing.Color.Black;
            this.rbEqual.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbEqual.Font = new System.Drawing.Font("Amazing Grotesk", 8.25F);
            this.rbEqual.ForeColor = System.Drawing.Color.White;
            this.rbEqual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbEqual.Location = new System.Drawing.Point(67, 3);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbEqual.Size = new System.Drawing.Size(44, 32);
            this.rbEqual.TabIndex = 21;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "Рівно";
            this.rbEqual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbEqual.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbEqual.UseVisualStyleBackColor = false;
            // 
            // rbLess
            // 
            this.rbLess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLess.AutoSize = true;
            this.rbLess.BackColor = System.Drawing.Color.Black;
            this.rbLess.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbLess.Font = new System.Drawing.Font("Amazing Grotesk", 8.25F);
            this.rbLess.ForeColor = System.Drawing.Color.White;
            this.rbLess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbLess.Location = new System.Drawing.Point(117, 3);
            this.rbLess.Name = "rbLess";
            this.rbLess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbLess.Size = new System.Drawing.Size(55, 32);
            this.rbLess.TabIndex = 20;
            this.rbLess.TabStop = true;
            this.rbLess.Text = "Менше";
            this.rbLess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbLess.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbLess.UseVisualStyleBackColor = false;
            // 
            // rbMore
            // 
            this.rbMore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMore.AutoSize = true;
            this.rbMore.BackColor = System.Drawing.Color.Black;
            this.rbMore.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbMore.Font = new System.Drawing.Font("Amazing Grotesk", 8.25F);
            this.rbMore.ForeColor = System.Drawing.Color.White;
            this.rbMore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbMore.Location = new System.Drawing.Point(3, 3);
            this.rbMore.Name = "rbMore";
            this.rbMore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbMore.Size = new System.Drawing.Size(58, 32);
            this.rbMore.TabIndex = 19;
            this.rbMore.TabStop = true;
            this.rbMore.Text = "Більше";
            this.rbMore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbMore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbMore.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(26, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
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
            this.label4.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(34, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Введіть значення:";
            // 
            // txtbRcS
            // 
            this.txtbRcS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRcS.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtbRcS.Location = new System.Drawing.Point(217, 82);
            this.txtbRcS.Name = "txtbRcS";
            this.txtbRcS.Size = new System.Drawing.Size(260, 24);
            this.txtbRcS.TabIndex = 15;
            this.txtbRcS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(215, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пошук:";
            // 
            // btnCancelS
            // 
            this.btnCancelS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelS.BackColor = System.Drawing.Color.White;
            this.btnCancelS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelS.FlatAppearance.BorderSize = 0;
            this.btnCancelS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelS.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnCancelS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelS.Location = new System.Drawing.Point(372, 127);
            this.btnCancelS.Name = "btnCancelS";
            this.btnCancelS.Size = new System.Drawing.Size(105, 22);
            this.btnCancelS.TabIndex = 8;
            this.btnCancelS.Text = "Показати все";
            this.btnCancelS.UseVisualStyleBackColor = false;
            this.btnCancelS.Click += new System.EventHandler(this.btnCancelS_Click);
            // 
            // btnRCS
            // 
            this.btnRCS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRCS.BackColor = System.Drawing.Color.White;
            this.btnRCS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRCS.FlatAppearance.BorderSize = 0;
            this.btnRCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRCS.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnRCS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRCS.Location = new System.Drawing.Point(217, 127);
            this.btnRCS.Name = "btnRCS";
            this.btnRCS.Size = new System.Drawing.Size(105, 22);
            this.btnRCS.TabIndex = 7;
            this.btnRCS.Text = "Пошук";
            this.btnRCS.UseVisualStyleBackColor = false;
            this.btnRCS.Click += new System.EventHandler(this.btnRCS_Click);
            // 
            // cbRcS
            // 
            this.cbRcS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRcS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRcS.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F);
            this.cbRcS.FormattingEnabled = true;
            this.cbRcS.Items.AddRange(new object[] {
            "Житловий комплекс",
            "Адреса",
            "Кількість під\'їздів"});
            this.cbRcS.Location = new System.Drawing.Point(217, 51);
            this.cbRcS.Name = "cbRcS";
            this.cbRcS.Size = new System.Drawing.Size(260, 25);
            this.cbRcS.TabIndex = 0;
            // 
            // gbImage
            // 
            this.gbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbImage.Controls.Add(this.pbImage);
            this.gbImage.Controls.Add(this.btnBack);
            this.gbImage.Location = new System.Drawing.Point(513, 6);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(770, 686);
            this.gbImage.TabIndex = 23;
            this.gbImage.TabStop = false;
            this.gbImage.Visible = false;
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackColor = System.Drawing.Color.DimGray;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Location = new System.Drawing.Point(21, 81);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(729, 408);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 23;
            this.pbImage.TabStop = false;
            this.pbImage.WaitOnLoad = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(324, 571);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 34);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Інфо";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRCID
            // 
            this.txtRCID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRCID.Location = new System.Drawing.Point(373, 494);
            this.txtRCID.Name = "txtRCID";
            this.txtRCID.ReadOnly = true;
            this.txtRCID.Size = new System.Drawing.Size(38, 20);
            this.txtRCID.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Location = new System.Drawing.Point(364, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 34);
            this.panel2.TabIndex = 25;
            // 
            // Houses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1295, 704);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtRCID);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvRC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 100);
            this.Name = "Houses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Houses";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.Houses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRC)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRC;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtbRC;
        private System.Windows.Forms.Label rcLbl;
        private System.Windows.Forms.ComboBox cbRcS;
        private System.Windows.Forms.Button btnRCS;
        private System.Windows.Forms.Button btnCancelS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbRcS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbMore;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBldngAm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtbCross;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtWallMat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtRCID;
        private System.Windows.Forms.Panel panel2;
    }
}