namespace WindowsFormsApplication1
{
    partial class ComArea
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpImage = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
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
            this.txtbComAreaS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelS = new System.Windows.Forms.Button();
            this.btnComAreaS = new System.Windows.Forms.Button();
            this.cbComAreaS = new System.Windows.Forms.ComboBox();
            this.dgvComArea = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddComAreaType = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddComAreaRC = new System.Windows.Forms.Button();
            this.cbAddComAreaType = new System.Windows.Forms.ComboBox();
            this.cbAddComAreaRC = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDelComAreaID = new System.Windows.Forms.ComboBox();
            this.btnDelComArea = new System.Windows.Forms.Button();
            this.txtRCID = new System.Windows.Forms.TextBox();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComArea)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.gpImage);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvComArea);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1263, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Комерційні приміщення";
            // 
            // gpImage
            // 
            this.gpImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpImage.Controls.Add(this.btnBack);
            this.gpImage.Controls.Add(this.pbImage);
            this.gpImage.Location = new System.Drawing.Point(120, 5);
            this.gpImage.Name = "gpImage";
            this.gpImage.Size = new System.Drawing.Size(1022, 432);
            this.gpImage.TabIndex = 29;
            this.gpImage.TabStop = false;
            this.gpImage.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(435, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 25);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackColor = System.Drawing.Color.DimGray;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Location = new System.Drawing.Point(203, 28);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(616, 368);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 27;
            this.pbImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.rbForSell);
            this.groupBox2.Controls.Add(this.rbSold);
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbComAreaS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCancelS);
            this.groupBox2.Controls.Add(this.btnComAreaS);
            this.groupBox2.Controls.Add(this.cbComAreaS);
            this.groupBox2.Location = new System.Drawing.Point(120, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 196);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.rbEqual);
            this.panel1.Controls.Add(this.rbLess);
            this.panel1.Controls.Add(this.rbMore);
            this.panel1.Location = new System.Drawing.Point(678, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 174);
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
            this.rbEqual.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEqual.ForeColor = System.Drawing.Color.White;
            this.rbEqual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbEqual.Location = new System.Drawing.Point(68, 69);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbEqual.Size = new System.Drawing.Size(51, 34);
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
            this.rbLess.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLess.ForeColor = System.Drawing.Color.White;
            this.rbLess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbLess.Location = new System.Drawing.Point(62, 107);
            this.rbLess.Name = "rbLess";
            this.rbLess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbLess.Size = new System.Drawing.Size(63, 34);
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
            this.rbMore.Font = new System.Drawing.Font("Amazing Grotesk", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMore.ForeColor = System.Drawing.Color.White;
            this.rbMore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbMore.Location = new System.Drawing.Point(61, 31);
            this.rbMore.Name = "rbMore";
            this.rbMore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbMore.Size = new System.Drawing.Size(65, 34);
            this.rbMore.TabIndex = 19;
            this.rbMore.TabStop = true;
            this.rbMore.Text = "Більше";
            this.rbMore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbMore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbMore.UseVisualStyleBackColor = false;
            // 
            // rbForSell
            // 
            this.rbForSell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbForSell.AutoSize = true;
            this.rbForSell.BackColor = System.Drawing.Color.Black;
            this.rbForSell.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbForSell.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbForSell.ForeColor = System.Drawing.Color.White;
            this.rbForSell.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbForSell.Location = new System.Drawing.Point(35, 129);
            this.rbForSell.Name = "rbForSell";
            this.rbForSell.Size = new System.Drawing.Size(96, 37);
            this.rbForSell.TabIndex = 20;
            this.rbForSell.TabStop = true;
            this.rbForSell.Text = "На дродаж";
            this.rbForSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbForSell.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbForSell.UseVisualStyleBackColor = false;
            this.rbForSell.CheckedChanged += new System.EventHandler(this.rbForSell_CheckedChanged);
            // 
            // rbSold
            // 
            this.rbSold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSold.AutoSize = true;
            this.rbSold.BackColor = System.Drawing.Color.Black;
            this.rbSold.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbSold.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSold.ForeColor = System.Drawing.Color.White;
            this.rbSold.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbSold.Location = new System.Drawing.Point(44, 88);
            this.rbSold.Name = "rbSold";
            this.rbSold.Size = new System.Drawing.Size(76, 37);
            this.rbSold.TabIndex = 19;
            this.rbSold.TabStop = true;
            this.rbSold.Text = "Продані";
            this.rbSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSold.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbSold.UseVisualStyleBackColor = false;
            this.rbSold.CheckedChanged += new System.EventHandler(this.rbSold_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAll.AutoSize = true;
            this.rbAll.BackColor = System.Drawing.Color.Black;
            this.rbAll.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbAll.Font = new System.Drawing.Font("Amazing Grotesk", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.ForeColor = System.Drawing.Color.White;
            this.rbAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbAll.Location = new System.Drawing.Point(61, 47);
            this.rbAll.Name = "rbAll";
            this.rbAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbAll.Size = new System.Drawing.Size(36, 37);
            this.rbAll.TabIndex = 18;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Всі";
            this.rbAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbAll.UseVisualStyleBackColor = false;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
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
            this.label8.Location = new System.Drawing.Point(182, 60);
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
            this.label4.Location = new System.Drawing.Point(191, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Введіть значення:";
            // 
            // txtbComAreaS
            // 
            this.txtbComAreaS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbComAreaS.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbComAreaS.Location = new System.Drawing.Point(403, 112);
            this.txtbComAreaS.Name = "txtbComAreaS";
            this.txtbComAreaS.Size = new System.Drawing.Size(266, 27);
            this.txtbComAreaS.TabIndex = 15;
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
            this.btnCancelS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelS.BackColor = System.Drawing.Color.White;
            this.btnCancelS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelS.FlatAppearance.BorderSize = 0;
            this.btnCancelS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelS.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnCancelS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelS.Location = new System.Drawing.Point(866, 106);
            this.btnCancelS.Name = "btnCancelS";
            this.btnCancelS.Size = new System.Drawing.Size(138, 35);
            this.btnCancelS.TabIndex = 8;
            this.btnCancelS.Text = "Показати все";
            this.btnCancelS.UseVisualStyleBackColor = false;
            this.btnCancelS.Click += new System.EventHandler(this.btnCancelS_Click);
            // 
            // btnComAreaS
            // 
            this.btnComAreaS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComAreaS.BackColor = System.Drawing.Color.White;
            this.btnComAreaS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComAreaS.FlatAppearance.BorderSize = 0;
            this.btnComAreaS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComAreaS.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnComAreaS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnComAreaS.Location = new System.Drawing.Point(866, 56);
            this.btnComAreaS.Name = "btnComAreaS";
            this.btnComAreaS.Size = new System.Drawing.Size(138, 35);
            this.btnComAreaS.TabIndex = 7;
            this.btnComAreaS.Text = "Пошук";
            this.btnComAreaS.UseVisualStyleBackColor = false;
            this.btnComAreaS.Click += new System.EventHandler(this.btnComAreaS_Click);
            // 
            // cbComAreaS
            // 
            this.cbComAreaS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbComAreaS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComAreaS.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComAreaS.FormattingEnabled = true;
            this.cbComAreaS.Items.AddRange(new object[] {
            "Житловий комплекс",
            "Тип",
            "К-сть під-приміщень",
            "Площа",
            "Ціна за м2",
            "Ціна"});
            this.cbComAreaS.Location = new System.Drawing.Point(403, 56);
            this.cbComAreaS.Name = "cbComAreaS";
            this.cbComAreaS.Size = new System.Drawing.Size(266, 29);
            this.cbComAreaS.TabIndex = 0;
            // 
            // dgvComArea
            // 
            this.dgvComArea.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvComArea.AllowUserToAddRows = false;
            this.dgvComArea.AllowUserToDeleteRows = false;
            this.dgvComArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComArea.Location = new System.Drawing.Point(120, 15);
            this.dgvComArea.Name = "dgvComArea";
            this.dgvComArea.ReadOnly = true;
            this.dgvComArea.Size = new System.Drawing.Size(1022, 422);
            this.dgvComArea.TabIndex = 8;
            this.dgvComArea.DoubleClick += new System.EventHandler(this.dgvComArea_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Green;
            this.tabPage2.Controls.Add(this.btnAddComAreaType);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnAddComAreaRC);
            this.tabPage2.Controls.Add(this.cbAddComAreaType);
            this.tabPage2.Controls.Add(this.cbAddComAreaRC);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1263, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додати";
            // 
            // btnAddComAreaType
            // 
            this.btnAddComAreaType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddComAreaType.BackColor = System.Drawing.Color.White;
            this.btnAddComAreaType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddComAreaType.FlatAppearance.BorderSize = 0;
            this.btnAddComAreaType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComAreaType.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAddComAreaType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddComAreaType.Location = new System.Drawing.Point(750, 310);
            this.btnAddComAreaType.Name = "btnAddComAreaType";
            this.btnAddComAreaType.Size = new System.Drawing.Size(48, 35);
            this.btnAddComAreaType.TabIndex = 18;
            this.btnAddComAreaType.Text = "ОК";
            this.btnAddComAreaType.UseVisualStyleBackColor = false;
            this.btnAddComAreaType.Click += new System.EventHandler(this.btnAddComAreaType_Click);
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
            this.label2.Location = new System.Drawing.Point(519, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "Виберіть тип:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(526, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Виберіть ЖК:";
            // 
            // btnAddComAreaRC
            // 
            this.btnAddComAreaRC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddComAreaRC.BackColor = System.Drawing.Color.White;
            this.btnAddComAreaRC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddComAreaRC.FlatAppearance.BorderSize = 0;
            this.btnAddComAreaRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComAreaRC.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAddComAreaRC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddComAreaRC.Location = new System.Drawing.Point(750, 175);
            this.btnAddComAreaRC.Name = "btnAddComAreaRC";
            this.btnAddComAreaRC.Size = new System.Drawing.Size(48, 35);
            this.btnAddComAreaRC.TabIndex = 11;
            this.btnAddComAreaRC.Text = "ОК";
            this.btnAddComAreaRC.UseVisualStyleBackColor = false;
            this.btnAddComAreaRC.Click += new System.EventHandler(this.btnAddComAreaRC_Click);
            // 
            // cbAddComAreaType
            // 
            this.cbAddComAreaType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddComAreaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddComAreaType.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddComAreaType.FormattingEnabled = true;
            this.cbAddComAreaType.Items.AddRange(new object[] {
            "Житловий комплекс",
            "Тип",
            "К-сть під-приміщень",
            "Площа",
            "Ціна за м2",
            "Ціна"});
            this.cbAddComAreaType.Location = new System.Drawing.Point(464, 310);
            this.cbAddComAreaType.Name = "cbAddComAreaType";
            this.cbAddComAreaType.Size = new System.Drawing.Size(266, 35);
            this.cbAddComAreaType.TabIndex = 10;
            // 
            // cbAddComAreaRC
            // 
            this.cbAddComAreaRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddComAreaRC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddComAreaRC.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddComAreaRC.FormattingEnabled = true;
            this.cbAddComAreaRC.Items.AddRange(new object[] {
            "Житловий комплекс",
            "Тип",
            "К-сть під-приміщень",
            "Площа",
            "Ціна за м2",
            "Ціна"});
            this.cbAddComAreaRC.Location = new System.Drawing.Point(464, 175);
            this.cbAddComAreaRC.Name = "cbAddComAreaRC";
            this.cbAddComAreaRC.Size = new System.Drawing.Size(266, 35);
            this.cbAddComAreaRC.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(532, 471);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 53);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Green;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cbDelComAreaID);
            this.tabPage3.Controls.Add(this.btnDelComArea);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1263, 645);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Видалити";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Amazing Grotesk", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(482, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 42);
            this.label5.TabIndex = 19;
            this.label5.Text = "Виберіть номер:";
            // 
            // cbDelComAreaID
            // 
            this.cbDelComAreaID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDelComAreaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelComAreaID.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelComAreaID.FormattingEnabled = true;
            this.cbDelComAreaID.Items.AddRange(new object[] {
            "Житловий комплекс",
            "Тип",
            "К-сть під-приміщень",
            "Площа",
            "Ціна за м2",
            "Ціна"});
            this.cbDelComAreaID.Location = new System.Drawing.Point(482, 236);
            this.cbDelComAreaID.Name = "cbDelComAreaID";
            this.cbDelComAreaID.Size = new System.Drawing.Size(298, 42);
            this.cbDelComAreaID.TabIndex = 18;
            // 
            // btnDelComArea
            // 
            this.btnDelComArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelComArea.BackColor = System.Drawing.Color.White;
            this.btnDelComArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelComArea.FlatAppearance.BorderSize = 0;
            this.btnDelComArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelComArea.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelComArea.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelComArea.Location = new System.Drawing.Point(533, 530);
            this.btnDelComArea.Name = "btnDelComArea";
            this.btnDelComArea.Size = new System.Drawing.Size(198, 53);
            this.btnDelComArea.TabIndex = 17;
            this.btnDelComArea.Text = "Видалити";
            this.btnDelComArea.UseVisualStyleBackColor = false;
            this.btnDelComArea.Click += new System.EventHandler(this.btnDelComArea_Click);
            // 
            // txtRCID
            // 
            this.txtRCID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRCID.BackColor = System.Drawing.SystemColors.Control;
            this.txtRCID.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRCID.Location = new System.Drawing.Point(0, 694);
            this.txtRCID.Name = "txtRCID";
            this.txtRCID.Size = new System.Drawing.Size(29, 36);
            this.txtRCID.TabIndex = 21;
            this.txtRCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTypeID
            // 
            this.txtTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeID.BackColor = System.Drawing.SystemColors.Control;
            this.txtTypeID.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.Location = new System.Drawing.Point(47, 694);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(29, 36);
            this.txtTypeID.TabIndex = 22;
            this.txtTypeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(0, 694);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 19;
            // 
            // ComArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1295, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.txtRCID);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 100);
            this.Name = "ComArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.ComArea_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComArea)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvComArea;
        private System.Windows.Forms.ComboBox cbComAreaS;
        private System.Windows.Forms.Button btnComAreaS;
        private System.Windows.Forms.Button btnCancelS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbComAreaS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbSold;
        private System.Windows.Forms.RadioButton rbForSell;
        private System.Windows.Forms.RadioButton rbMore;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddComAreaType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddComAreaRC;
        private System.Windows.Forms.ComboBox cbAddComAreaType;
        private System.Windows.Forms.ComboBox cbAddComAreaRC;
        private System.Windows.Forms.TextBox txtRCID;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDelComAreaID;
        private System.Windows.Forms.Button btnDelComArea;
        private System.Windows.Forms.GroupBox gpImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbImage;
    }
}