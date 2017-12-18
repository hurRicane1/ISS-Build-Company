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
    public partial class ComArea : Form
    {
        public ComArea()
        {
            InitializeComponent();
        }
        UseDB uDB = new UseDB();
        DataTable tComArea = new DataTable();
        DataTable tRC = new DataTable();
        DataTable tType = new DataTable();
        DataTable tComArea2 = new DataTable();

        Comarea myComArea = new Comarea();     

        bool bl;

        int rcID =0, typeID=0;

        //ComArea----
        public void DataGridSource()
        {
            dgvComArea.AutoGenerateColumns = false;
            //------RC
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
            priceM2TextBoxColumn.DataPropertyName = "PriceComAreaM2";
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
            dgvComArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idTextBoxColumn, rcTextBoxColumn, typeTextBoxColumn, roomAmTextBoxColumn, tAreaTextBoxColumn, priceM2TextBoxColumn, totalPriceTextBoxColumn });
        }

        private void rbSold_CheckedChanged(object sender, EventArgs e)
        {
            bl = true;
            uDB.OpenConnection();
            tComArea = uDB.SearchComArea(6, "ComArea.Sold", "", 0, 0, bl, 2);
            dgvComArea.DataSource = tComArea;
            uDB.CloseCon();
        }

        private void rbForSell_CheckedChanged(object sender, EventArgs e)
        {
            bl = false;
            uDB.OpenConnection();
            tComArea = uDB.SearchComArea(6, "ComArea.Sold", "", 0, 0, bl, 2);
            dgvComArea.DataSource = tComArea;
            uDB.CloseCon();
        }
        private void btnComAreaS_Click(object sender, EventArgs e)
        {
            int lm = 2;
            if (rbEqual.Checked) lm = 2;
            if (rbLess.Checked) lm = 0;
            if (rbMore.Checked) lm = 1;

            uDB.OpenConnection();

            switch(cbComAreaS.SelectedIndex)
            {
                case 0:
                    {
                        string rc = txtbComAreaS.Text;
                        tComArea = uDB.SearchComArea(0, "RC.Name", rc, 0, 0, false, lm);
                        if (rbAll.Checked)
                            tComArea = uDB.SearchComArea(0, "RC.Name", rc, 0, 0, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tComArea = uDB.SearchComArea(3, "RC.Name", rc, 0, 0, bl, lm);
                        dgvComArea.DataSource = tComArea;
                    }
                    break;
                case 1:
                    {
                        string type = txtbComAreaS.Text;
                        tComArea = uDB.SearchComArea(0, "Type.Type", type, 0, 0, false, lm);
                        if (rbAll.Checked)
                            tComArea = uDB.SearchComArea(0, "Type.Type", type, 0, 0, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tComArea = uDB.SearchComArea(3, "Type.Type", type, 0, 0, bl, lm);
                        dgvComArea.DataSource = tComArea;
                    }
                    break;
                case 2:
                    {
                        int roomAm = Convert.ToInt32(txtbComAreaS.Text);
                        tComArea = uDB.SearchComArea(1, "Type.RoomAm", "", roomAm, 0, false, lm);
                        if (rbAll.Checked)
                            tComArea = uDB.SearchComArea(1, "Type.RoomAm", "", roomAm, 0, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tComArea = uDB.SearchComArea(4, "Type.RoomAm", "", roomAm, 0, bl, lm);
                        dgvComArea.DataSource = tComArea;
                    }
                    break;
                case 3:
                    {
                        double tArea = Convert.ToDouble(txtbComAreaS.Text);
                        tComArea = uDB.SearchComArea(2, "Type.TotalArea", "", 0, tArea, false, lm);
                        if (rbAll.Checked)
                            tComArea = uDB.SearchComArea(2, "Type.TotalArea", "", 0, tArea, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tComArea = uDB.SearchComArea(5, "Type.TotalArea", "", 0, tArea, bl, lm);
                        dgvComArea.DataSource = tComArea;
                    }
                    break;
                case 4:
                    {
                        double priceM2 = Convert.ToDouble(txtbComAreaS.Text);
                        tComArea = uDB.SearchComArea(2, "RC.PriceComAreaM2", "", 0, priceM2, false, lm);
                        if (rbAll.Checked)
                            tComArea = uDB.SearchComArea(2, "RC.PriceComAreaM2", "", 0, priceM2, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tComArea = uDB.SearchComArea(5, "RC.PriceComAreaM2", "", 0, priceM2, bl, lm);
                        dgvComArea.DataSource = tComArea;
                    }
                    break;
                case 5:
                    {
                        double tPrice = Convert.ToDouble(txtbComAreaS.Text);
                        tComArea = uDB.SearchComArea(2, "Type.TotalPrice", "", 0, tPrice, false, lm);
                        if (rbAll.Checked)
                            tComArea = uDB.SearchComArea(2, "Type.TotalPrice", "", 0, tPrice, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tComArea = uDB.SearchComArea(5, "Type.TotalPrice", "", 0, tPrice, bl, lm);
                        dgvComArea.DataSource = tComArea;
                    }
                    break;

            }
            uDB.CloseCon();
        }
        private void btnCancelS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tComArea = uDB.GetComArea();
            dgvComArea.DataSource = tComArea;
            uDB.CloseCon();
        }


        //-----

        //Add--------
        private void btnAddComAreaRC_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            txtTypeID.DataBindings.Clear();
            rcID = Convert.ToInt32(txtRCID.Text);
            tType = uDB.GetTypeToApp(rcID, "ComArea");
            cbAddComAreaType.DataSource = tType;
            cbAddComAreaType.DisplayMember = "Type";
            txtTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
            uDB.CloseCon();
        }

        private void btnAddComAreaType_Click(object sender, EventArgs e)
        {
            typeID = Convert.ToInt32(txtTypeID.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (typeID != 0)
            {
                myComArea.Type_ID = typeID;
                uDB.InsertComArea(myComArea);
                tComArea2 = uDB.GetTable("ComArea");
                cbDelComAreaID.DataSource = tComArea2;
                cbDelComAreaID.DisplayMember = "ID";
            }
            uDB.CloseCon();
        }

        //-----

        //Delete-----
        private void btnDelComArea_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int ComId = Convert.ToInt32(cbDelComAreaID.Text);
            uDB.DeleteByIntNum("ComArea", "IDd", ComId);
            tComArea2 = uDB.GetTable("ComArea");
            cbDelComAreaID.DataSource = tComArea2;
            cbDelComAreaID.DisplayMember = "IDd";
            uDB.CloseCon();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tComArea = uDB.GetComArea();
            DataGridSource();
            dgvComArea.DataSource = tComArea;
            uDB.CloseCon();
        }


        private void dgvComArea_DoubleClick(object sender, EventArgs e)
        {
            gpImage.Visible = true;
            int id = Convert.ToInt32(dgvComArea.CurrentRow.Cells[0].Value);
            uDB.OpenConnection();
            pbImage.Image = uDB.GetImages("Type INNER JOIN ComArea ON Type.ID = ComArea.Type_ID", "ComArea.IDd", id);
            uDB.CloseCon();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gpImage.Visible = false;
        }

        //-----

        private void ComArea_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            //ComArea
            tComArea = uDB.GetComArea();
            DataGridSource();
            dgvComArea.DataSource = tComArea;
            //-------

            //Add----
            tRC = uDB.GetTable("RC");
            cbAddComAreaRC.DataSource = tRC;
            cbAddComAreaRC.DisplayMember = "Name";

            txtRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
            rcID = Convert.ToInt32(txtRCID.Text);
            tType = uDB.GetTypeToApp(rcID, "ComArea");
            cbAddComAreaType.DataSource = tType;
            cbAddComAreaType.DisplayMember = "Type";

            txtTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
            //-------

            //Delete----
            tComArea2 = uDB.GetTable("ComArea");
            cbDelComAreaID.DataSource = tComArea2;
            cbDelComAreaID.DisplayMember = "IDd";
            //----------
            uDB.CloseCon();
        }
    }
}
