using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Footer : Form
    {
        public Footer()
        {
            InitializeComponent();
        }

        UseDB uDB = new UseDB();
        DataTable tFooter = new DataTable();
        DataTable tRC = new DataTable();
        DataTable tType = new DataTable();
        DataTable tFooter2 = new DataTable();

        Footers myFooter = new Footers();

        bool bl;

        int rcID = 0, typeID = 0;

        //Footer----
        public void DataGridSource()
        {
            dgvFooter.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn idTextBoxColumn = new DataGridViewTextBoxColumn();
            idTextBoxColumn.DataPropertyName = "IDd";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idTextBoxColumn.DefaultCellStyle = cellStyle1;
            idTextBoxColumn.FillWeight = 100F;
            idTextBoxColumn.HeaderText = "Номер";
            idTextBoxColumn.Width = 100;
            idTextBoxColumn.ReadOnly = true;
            //------RC
            DataGridViewTextBoxColumn rcTextBoxColumn = new DataGridViewTextBoxColumn();
            rcTextBoxColumn.DataPropertyName = "Name";
            rcTextBoxColumn.DefaultCellStyle = cellStyle1;
            rcTextBoxColumn.FillWeight = 200F;
            rcTextBoxColumn.HeaderText = "Житловий комплекс";
            rcTextBoxColumn.Width = 200;
            rcTextBoxColumn.ReadOnly = true;
            //------Type
            DataGridViewTextBoxColumn typeTextBoxColumn = new DataGridViewTextBoxColumn();
            typeTextBoxColumn.DataPropertyName = "Type";
            typeTextBoxColumn.DefaultCellStyle = cellStyle1;
            typeTextBoxColumn.FillWeight = 150F;
            typeTextBoxColumn.HeaderText = "Тип";
            typeTextBoxColumn.Width = 150;
            typeTextBoxColumn.ReadOnly = true;
            //------RoomAm
            DataGridViewTextBoxColumn roomAmTextBoxColumn = new DataGridViewTextBoxColumn();
            roomAmTextBoxColumn.DataPropertyName = "RoomAm";
            roomAmTextBoxColumn.DefaultCellStyle = cellStyle1;
            roomAmTextBoxColumn.FillWeight = 150F;
            roomAmTextBoxColumn.HeaderText = "К-сть під-приміщень";
            roomAmTextBoxColumn.Width = 150;
            roomAmTextBoxColumn.ReadOnly = true;
            //-----------
            //------TotalArea
            DataGridViewTextBoxColumn tAreaTextBoxColumn = new DataGridViewTextBoxColumn();
            tAreaTextBoxColumn.DataPropertyName = "TotalArea";
            tAreaTextBoxColumn.DefaultCellStyle = cellStyle1;
            tAreaTextBoxColumn.FillWeight = 150F;
            tAreaTextBoxColumn.HeaderText = "Площа";
            tAreaTextBoxColumn.Width = 150;
            tAreaTextBoxColumn.ReadOnly = true;
            //-----------
            //------PriceM2
            DataGridViewTextBoxColumn priceM2TextBoxColumn = new DataGridViewTextBoxColumn();
            priceM2TextBoxColumn.DataPropertyName = "PriceFooterM2";
            priceM2TextBoxColumn.DefaultCellStyle = cellStyle1;
            priceM2TextBoxColumn.FillWeight = 165F;
            priceM2TextBoxColumn.HeaderText = "Ціна за м2 (грн)";
            priceM2TextBoxColumn.Width = 115;
            priceM2TextBoxColumn.ReadOnly = true;
            //-----------
            //------TotalPrice
            DataGridViewTextBoxColumn totalPriceTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceTextBoxColumn.DefaultCellStyle = cellStyle1;
            totalPriceTextBoxColumn.FillWeight = 165F;
            totalPriceTextBoxColumn.HeaderText = "Повна ціна (грн)";
            totalPriceTextBoxColumn.Width = 115;
            totalPriceTextBoxColumn.ReadOnly = true;
            //-----------
            dgvFooter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idTextBoxColumn, rcTextBoxColumn, typeTextBoxColumn, roomAmTextBoxColumn, tAreaTextBoxColumn, priceM2TextBoxColumn, totalPriceTextBoxColumn });
        }

        private void rbSold_CheckedChanged(object sender, EventArgs e)
        {
            bl = true;
            uDB.OpenConnection();
            tFooter = uDB.SearchFooter(6, "Footer.Sold", "", 0, 0, bl, 2);
            dgvFooter.DataSource = tFooter;
            uDB.CloseCon();
        }

        private void rbForSell_CheckedChanged(object sender, EventArgs e)
        {
            bl = false;
            uDB.OpenConnection();
            tFooter = uDB.SearchFooter(6, "Footer.Sold", "", 0, 0, bl, 2);
            dgvFooter.DataSource = tFooter;
            uDB.CloseCon();
        }
        private void btnFooterS_Click(object sender, EventArgs e)
        {
            int lm = 2;
            if (rbEqual.Checked) lm = 2;
            if (rbLess.Checked) lm = 0;
            if (rbMore.Checked) lm = 1;

            uDB.OpenConnection();

            switch (cbFooterS.SelectedIndex)
            {
                case 0:
                    {
                        string rc = txtbFooterS.Text;
                        tFooter = uDB.SearchFooter(0, "RC.Name", rc, 0, 0, false, lm);
                        if (rbAll.Checked)
                            tFooter = uDB.SearchFooter(0, "RC.Name", rc, 0, 0, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tFooter = uDB.SearchFooter(3, "RC.Name", rc, 0, 0, bl, lm);
                        dgvFooter.DataSource = tFooter;
                    }
                    break;
                case 1:
                    {
                        string type = txtbFooterS.Text;
                        tFooter = uDB.SearchFooter(0, "Type.Type", type, 0, 0, false, lm);
                        if (rbAll.Checked)
                            tFooter = uDB.SearchFooter(0, "Type.Type", type, 0, 0, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tFooter = uDB.SearchFooter(3, "Type.Type", type, 0, 0, bl, lm);
                        dgvFooter.DataSource = tFooter;
                    }
                    break;
                case 2:
                    {
                        int roomAm = Convert.ToInt32(txtbFooterS.Text);
                        tFooter = uDB.SearchComArea(1, "Type.RoomAm", "", roomAm, 0, false, lm);
                        if (rbAll.Checked)
                            tFooter = uDB.SearchFooter(1, "Type.RoomAm", "", roomAm, 0, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tFooter = uDB.SearchFooter(4, "Type.RoomAm", "", roomAm, 0, bl, lm);
                        dgvFooter.DataSource = tFooter;
                    }
                    break;
                case 3:
                    {
                        double tArea = Convert.ToDouble(txtbFooterS.Text);
                        tFooter = uDB.SearchFooter(2, "Type.TotalArea", "", 0, tArea, false, lm);
                        if (rbAll.Checked)
                            tFooter = uDB.SearchFooter(2, "Type.TotalArea", "", 0, tArea, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tFooter = uDB.SearchFooter(5, "Type.TotalArea", "", 0, tArea, bl, lm);
                        dgvFooter.DataSource = tFooter;
                    }
                    break;
                case 4:
                    {
                        double priceM2 = Convert.ToDouble(txtbFooterS.Text);
                        tFooter = uDB.SearchFooter(2, "RC.PriceFooterM2", "", 0, priceM2, false, lm);
                        if (rbAll.Checked)
                            tFooter = uDB.SearchComArea(2, "RC.PriceFooterM2", "", 0, priceM2, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tFooter = uDB.SearchComArea(5, "RC.PriceFooterM2", "", 0, priceM2, bl, lm);
                        dgvFooter.DataSource = tFooter;
                    }
                    break;
                case 5:
                    {
                        double tPrice = Convert.ToDouble(txtbFooterS.Text);
                        tFooter = uDB.SearchFooter(2, "Type.TotalPrice", "", 0, tPrice, false, lm);
                        if (rbAll.Checked)
                            tFooter = uDB.SearchFooter(2, "Type.TotalPrice", "", 0, tPrice, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tFooter = uDB.SearchFooter(5, "Type.TotalPrice", "", 0, tPrice, bl, lm);
                        dgvFooter.DataSource = tFooter;
                    }
                    break;

            }
            uDB.CloseCon();
        }
        private void btnCancelS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tFooter = uDB.GetFooter();
            dgvFooter.DataSource = tFooter;
            uDB.CloseCon();
        }


        //-----

        //Add--------
        private void btnAddFooterRC_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            txtFooterTypeID.DataBindings.Clear();
            rcID = Convert.ToInt32(txtFooterRcID.Text);
            tType = uDB.GetTypeToApp(rcID, "Footer");
            cbAddFooterType.DataSource = tType;
            cbAddFooterType.DisplayMember = "Type";
            txtFooterTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
            uDB.CloseCon();
        }

        private void btnAddFooterType_Click(object sender, EventArgs e)
        {
            typeID = Convert.ToInt32(txtFooterTypeID.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (typeID != 0)
            {
                myFooter.Type_ID = typeID;
                uDB.InsertFooter(myFooter);
                tFooter2 = uDB.GetTable("Footer");
                cbDelFooterID.DataSource = tFooter2;
                cbDelFooterID.DisplayMember = "IDd";
            }
            uDB.CloseCon();
        }
        //-----

        //Delete-----
        private void btnDelFooter_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int ComId = Convert.ToInt32(cbDelFooterID.Text);
            uDB.DeleteByIntNum("Footer", "IDd", ComId);
            tFooter2 = uDB.GetTable("Footer");
            cbDelFooterID.DataSource = tFooter2;
            cbDelFooterID.DisplayMember = "IDd";
            uDB.CloseCon();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tFooter = uDB.GetFooter();
            dgvFooter.DataSource = tFooter;
            uDB.CloseCon();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gpImage.Visible = false;
        }

        private void dgvFooter_DoubleClick(object sender, EventArgs e)
        {
            gpImage.Visible = true;
            int id = Convert.ToInt32(dgvFooter.CurrentRow.Cells[0].Value);
            uDB.OpenConnection();
            pbImage.Image = uDB.GetImages("Type INNER JOIN Footer ON Type.ID = Footer.Type_ID", "Footer.IDd", id);
            uDB.CloseCon();
        }

        //-----

        private void Footer_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            //Footer
            tFooter = uDB.GetFooter();
            DataGridSource();
            dgvFooter.DataSource = tFooter;
            //-------

            //Add----
            tRC = uDB.GetTable("RC");
            cbAddFooterRC.DataSource = tRC;
            cbAddFooterRC.DisplayMember = "Name";

            txtFooterRcID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
            rcID = Convert.ToInt32(txtFooterRcID.Text);
            tType = uDB.GetTypeToApp(rcID, "Footer");
            cbAddFooterType.DataSource = tType;
            cbAddFooterType.DisplayMember = "Type";

            txtFooterTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
            //-------

            //Delete----
            tFooter2 = uDB.GetTable("Footer");
            cbDelFooterID.DataSource = tFooter2;
            cbDelFooterID.DisplayMember = "IDd";
            //----------
            uDB.CloseCon();
        }
    }
}
