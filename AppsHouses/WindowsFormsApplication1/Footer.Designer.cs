namespace WindowsFormsApplication1
{
    partial class Footer
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
            this.txtbFooterS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelS = new System.Windows.Forms.Button();
            this.btnFooterS = new System.Windows.Forms.Button();
            this.cbFooterS = new System.Windows.Forms.ComboBox();
            this.dgvFooter = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddFooterType = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFooterRC = new System.Windows.Forms.Button();
            this.cbAddFooterType = new System.Windows.Forms.ComboBox();
            this.cbAddFooterRC = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDelFooterID = new System.Windows.Forms.ComboBox();
            this.btnDelFooter = new System.Windows.Forms.Button();
            this.txtFooterTypeID = new System.Windows.Forms.TextBox();
            this.txtFooterRcID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFooter)).BeginInit();
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
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Green;
            this.tabPage1.Controls.Add(this.gpImage);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvFooter);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1263, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Підвали";
            // 
            // gpImage
            // 
            this.gpImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpImage.Controls.Add(this.btnBack);
            this.gpImage.Controls.Add(this.pbImage);
            this.gpImage.Location = new System.Drawing.Point(120, 6);
            this.gpImage.Name = "gpImage";
            this.gpImage.Size = new System.Drawing.Size(1022, 432);
            this.gpImage.TabIndex = 33;
            this.gpImage.TabStop = false;
            this.gpImage.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.pbImage.Location = new System.Drawing.Point(183, 28);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(656, 368);
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
            this.groupBox2.Controls.Add(this.txtbFooterS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCancelS);
            this.groupBox2.Controls.Add(this.btnFooterS);
            this.groupBox2.Controls.Add(this.cbFooterS);
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
            this.rbMore.CheckedChanged += new System.EventHandler(this.rbSold_CheckedChanged);
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
            // txtbFooterS
            // 
            this.txtbFooterS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbFooterS.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFooterS.Location = new System.Drawing.Point(403, 112);
            this.txtbFooterS.Name = "txtbFooterS";
            this.txtbFooterS.Size = new System.Drawing.Size(266, 27);
            this.txtbFooterS.TabIndex = 15;
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
            // btnFooterS
            // 
            this.btnFooterS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFooterS.BackColor = System.Drawing.Color.White;
            this.btnFooterS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFooterS.FlatAppearance.BorderSize = 0;
            this.btnFooterS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFooterS.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnFooterS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFooterS.Location = new System.Drawing.Point(866, 56);
            this.btnFooterS.Name = "btnFooterS";
            this.btnFooterS.Size = new System.Drawing.Size(138, 35);
            this.btnFooterS.TabIndex = 7;
            this.btnFooterS.Text = "Пошук";
            this.btnFooterS.UseVisualStyleBackColor = false;
            this.btnFooterS.Click += new System.EventHandler(this.btnFooterS_Click);
            // 
            // cbFooterS
            // 
            this.cbFooterS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFooterS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFooterS.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFooterS.FormattingEnabled = true;
            this.cbFooterS.Items.AddRange(new object[] {
            "Житловий комплекс",
            "Тип",
            "К-сть приміщень",
            "Площа",
            "Ціна за м2",
            "Ціна"});
            this.cbFooterS.Location = new System.Drawing.Point(403, 56);
            this.cbFooterS.Name = "cbFooterS";
            this.cbFooterS.Size = new System.Drawing.Size(266, 29);
            this.cbFooterS.TabIndex = 0;
            // 
            // dgvFooter
            // 
            this.dgvFooter.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dgvFooter.AllowUserToAddRows = false;
            this.dgvFooter.AllowUserToDeleteRows = false;
            this.dgvFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFooter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFooter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFooter.Location = new System.Drawing.Point(120, 15);
            this.dgvFooter.Name = "dgvFooter";
            this.dgvFooter.ReadOnly = true;
            this.dgvFooter.Size = new System.Drawing.Size(1022, 422);
            this.dgvFooter.TabIndex = 8;
            this.dgvFooter.DoubleClick += new System.EventHandler(this.dgvFooter_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Green;
            this.tabPage2.Controls.Add(this.btnAddFooterType);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnAddFooterRC);
            this.tabPage2.Controls.Add(this.cbAddFooterType);
            this.tabPage2.Controls.Add(this.cbAddFooterRC);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1263, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додати";
            // 
            // btnAddFooterType
            // 
            this.btnAddFooterType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddFooterType.BackColor = System.Drawing.Color.White;
            this.btnAddFooterType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFooterType.FlatAppearance.BorderSize = 0;
            this.btnAddFooterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFooterType.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAddFooterType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddFooterType.Location = new System.Drawing.Point(750, 310);
            this.btnAddFooterType.Name = "btnAddFooterType";
            this.btnAddFooterType.Size = new System.Drawing.Size(48, 35);
            this.btnAddFooterType.TabIndex = 18;
            this.btnAddFooterType.Text = "ОК";
            this.btnAddFooterType.UseVisualStyleBackColor = false;
            this.btnAddFooterType.Click += new System.EventHandler(this.btnAddFooterType_Click);
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
            // btnAddFooterRC
            // 
            this.btnAddFooterRC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddFooterRC.BackColor = System.Drawing.Color.White;
            this.btnAddFooterRC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFooterRC.FlatAppearance.BorderSize = 0;
            this.btnAddFooterRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFooterRC.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAddFooterRC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddFooterRC.Location = new System.Drawing.Point(750, 175);
            this.btnAddFooterRC.Name = "btnAddFooterRC";
            this.btnAddFooterRC.Size = new System.Drawing.Size(48, 35);
            this.btnAddFooterRC.TabIndex = 11;
            this.btnAddFooterRC.Text = "ОК";
            this.btnAddFooterRC.UseVisualStyleBackColor = false;
            this.btnAddFooterRC.Click += new System.EventHandler(this.btnAddFooterRC_Click);
            // 
            // cbAddFooterType
            // 
            this.cbAddFooterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddFooterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddFooterType.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddFooterType.FormattingEnabled = true;
            this.cbAddFooterType.Items.AddRange(new object[] {
            "Житловий комплекс",
            "Тип",
            "К-сть під-приміщень",
            "Площа",
            "Ціна за м2",
            "Ціна"});
            this.cbAddFooterType.Location = new System.Drawing.Point(464, 310);
            this.cbAddFooterType.Name = "cbAddFooterType";
            this.cbAddFooterType.Size = new System.Drawing.Size(266, 35);
            this.cbAddFooterType.TabIndex = 10;
            // 
            // cbAddFooterRC
            // 
            this.cbAddFooterRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAddFooterRC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddFooterRC.Font = new System.Drawing.Font("Amazing Grotesk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddFooterRC.FormattingEnabled = true;
            this.cbAddFooterRC.Items.AddRange(new object[] {
            "Житловий комплекс",
            "Тип",
            "К-сть під-приміщень",
            "Площа",
            "Ціна за м2",
            "Ціна"});
            this.cbAddFooterRC.Location = new System.Drawing.Point(464, 175);
            this.cbAddFooterRC.Name = "cbAddFooterRC";
            this.cbAddFooterRC.Size = new System.Drawing.Size(266, 35);
            this.cbAddFooterRC.TabIndex = 9;
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
            this.tabPage3.Controls.Add(this.cbDelFooterID);
            this.tabPage3.Controls.Add(this.btnDelFooter);
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
            // cbDelFooterID
            // 
            this.cbDelFooterID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDelFooterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelFooterID.Font = new System.Drawing.Font("Amazing Grotesk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelFooterID.FormattingEnabled = true;
            this.cbDelFooterID.Items.AddRange(new object[] {
            "Житловий комплекс",
            "Тип",
            "К-сть під-приміщень",
            "Площа",
            "Ціна за м2",
            "Ціна"});
            this.cbDelFooterID.Location = new System.Drawing.Point(482, 236);
            this.cbDelFooterID.Name = "cbDelFooterID";
            this.cbDelFooterID.Size = new System.Drawing.Size(298, 42);
            this.cbDelFooterID.TabIndex = 18;
            // 
            // btnDelFooter
            // 
            this.btnDelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelFooter.BackColor = System.Drawing.Color.White;
            this.btnDelFooter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelFooter.FlatAppearance.BorderSize = 0;
            this.btnDelFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelFooter.Font = new System.Drawing.Font("Amazing Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelFooter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelFooter.Location = new System.Drawing.Point(533, 530);
            this.btnDelFooter.Name = "btnDelFooter";
            this.btnDelFooter.Size = new System.Drawing.Size(198, 53);
            this.btnDelFooter.TabIndex = 17;
            this.btnDelFooter.Text = "Видалити";
            this.btnDelFooter.UseVisualStyleBackColor = false;
            this.btnDelFooter.Click += new System.EventHandler(this.btnDelFooter_Click);
            // 
            // txtFooterTypeID
            // 
            this.txtFooterTypeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFooterTypeID.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFooterTypeID.Location = new System.Drawing.Point(68, 694);
            this.txtFooterTypeID.Name = "txtFooterTypeID";
            this.txtFooterTypeID.ReadOnly = true;
            this.txtFooterTypeID.Size = new System.Drawing.Size(46, 27);
            this.txtFooterTypeID.TabIndex = 32;
            // 
            // txtFooterRcID
            // 
            this.txtFooterRcID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFooterRcID.Font = new System.Drawing.Font("Amazing Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFooterRcID.Location = new System.Drawing.Point(16, 694);
            this.txtFooterRcID.Name = "txtFooterRcID";
            this.txtFooterRcID.ReadOnly = true;
            this.txtFooterRcID.Size = new System.Drawing.Size(46, 27);
            this.txtFooterRcID.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(16, 694);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 20;
            // 
            // Footer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1295, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFooterTypeID);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtFooterRcID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(266, 100);
            this.Name = "Footer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.Footer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFooter)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbMore;
        private System.Windows.Forms.RadioButton rbForSell;
        private System.Windows.Forms.RadioButton rbSold;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbFooterS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelS;
        private System.Windows.Forms.Button btnFooterS;
        private System.Windows.Forms.ComboBox cbFooterS;
        private System.Windows.Forms.DataGridView dgvFooter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddFooterType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFooterRC;
        private System.Windows.Forms.ComboBox cbAddFooterType;
        private System.Windows.Forms.ComboBox cbAddFooterRC;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDelFooterID;
        private System.Windows.Forms.Button btnDelFooter;
        private System.Windows.Forms.TextBox txtFooterTypeID;
        private System.Windows.Forms.TextBox txtFooterRcID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gpImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbImage;
    }
}