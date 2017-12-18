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
    public partial class Parking : Form
    {
        public Parking()
        {
            InitializeComponent();
        }
        UseDB uDB = new UseDB();
        DataTable tParking = new DataTable();
        DataTable tRC = new DataTable();
        DataTable tType = new DataTable();
        DataTable tParking2 = new DataTable();

        Parkings myParking = new Parkings();

        bool bl;

        int rcID = 0, typeID = 0;

        //Parking----
        public void DataGridSource()
        {
            dgvParking.AutoGenerateColumns = false;
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
            typeTextBoxColumn.FillWeight = 200F;
            typeTextBoxColumn.HeaderText = "Тип";
            typeTextBoxColumn.Width = 200;
            typeTextBoxColumn.ReadOnly = true;
            //------RoomAm
            DataGridViewTextBoxColumn roomAmTextBoxColumn = new DataGridViewTextBoxColumn();
            roomAmTextBoxColumn.DataPropertyName = "RoomAm";
            roomAmTextBoxColumn.DefaultCellStyle = cellStyle1;
            roomAmTextBoxColumn.FillWeight = 150F;
            roomAmTextBoxColumn.HeaderText = "К-сть паркомісць";
            roomAmTextBoxColumn.Width = 150;
            roomAmTextBoxColumn.ReadOnly = true;
            //-----------
            //------PriceForPlace
            DataGridViewTextBoxColumn priceM2TextBoxColumn = new DataGridViewTextBoxColumn();
            priceM2TextBoxColumn.DataPropertyName = "PriceParking";
            priceM2TextBoxColumn.DefaultCellStyle = cellStyle1;
            priceM2TextBoxColumn.FillWeight = 165F;
            priceM2TextBoxColumn.HeaderText = "Ціна за паркомісце";
            priceM2TextBoxColumn.Width = 165;
            priceM2TextBoxColumn.ReadOnly = true;
            //-----------
            //------TotalPrice
            DataGridViewTextBoxColumn totalPriceTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceTextBoxColumn.DefaultCellStyle = cellStyle1;
            totalPriceTextBoxColumn.FillWeight = 165F;
            totalPriceTextBoxColumn.HeaderText = "Повна ціна (грн)";
            totalPriceTextBoxColumn.Width = 165;
            totalPriceTextBoxColumn.ReadOnly = true;
            //-----------
            dgvParking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idTextBoxColumn, rcTextBoxColumn, typeTextBoxColumn, roomAmTextBoxColumn, priceM2TextBoxColumn, totalPriceTextBoxColumn });
        }
        private void rbSold_CheckedChanged(object sender, EventArgs e)
        {
            bl = true;
            uDB.OpenConnection();
            tParking = uDB.SearchParking(6, "Parking.Sold", "", 0, 0, bl, 2);
            dgvParking.DataSource = tParking;
            uDB.CloseCon();
        }

        private void rbForSell_CheckedChanged(object sender, EventArgs e)
        {
            bl = false;
            uDB.OpenConnection();
            tParking = uDB.SearchParking(6, "Parking.Sold", "", 0, 0, bl, 2);
            dgvParking.DataSource = tParking;
            uDB.CloseCon();
        }

        private void btnParkingS_Click(object sender, EventArgs e)
        {
            int lm = 2;
            if (rbEqual.Checked) lm = 2;
            if (rbLess.Checked) lm = 0;
            if (rbMore.Checked) lm = 1;

            uDB.OpenConnection();

            switch (cbParkingS.SelectedIndex)
            {
                case 0:
                    {
                        string rc = txtbParkingS.Text;
                        tParking = uDB.SearchParking(0, "RC.Name", rc, 0, 0, false, lm);
                        if (rbAll.Checked)
                            tParking = uDB.SearchParking(0, "RC.Name", rc, 0, 0, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tParking = uDB.SearchParking(3, "RC.Name", rc, 0, 0, bl, lm);
                        dgvParking.DataSource = tParking;
                    }
                    break;
                case 1:
                    {
                        string type = txtbParkingS.Text;
                        tParking = uDB.SearchParking(0, "Type.Type", type, 0, 0, false, lm);
                        if (rbAll.Checked)
                            tParking = uDB.SearchParking(0, "Type.Type", type, 0, 0, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tParking = uDB.SearchParking(3, "Type.Type", type, 0, 0, bl, lm);
                        dgvParking.DataSource = tParking;
                    }
                    break;
                case 2:
                    {
                        int roomAm = Convert.ToInt32(txtbParkingS.Text);
                        tParking = uDB.SearchParking(1, "Type.RoomAm", "", roomAm, 0, false, lm);
                        if (rbAll.Checked)
                            tParking = uDB.SearchParking(1, "Type.RoomAm", "", roomAm, 0, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tParking = uDB.SearchParking(4, "Type.RoomAm", "", roomAm, 0, bl, lm);
                        dgvParking.DataSource = tParking;
                    }
                    break;
                case 3:
                    {
                        double priceM2 = Convert.ToDouble(txtbParkingS.Text);
                        tParking = uDB.SearchParking(2, "RC.PriceParking", "", 0, priceM2, false, lm);
                        if (rbAll.Checked)
                            tParking = uDB.SearchParking(2, "RC.PriceParking", "", 0, priceM2, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tParking = uDB.SearchParking(5, "RC.PriceParking", "", 0, priceM2, bl, lm);
                        dgvParking.DataSource = tParking;
                    }
                    break;
                case 4:
                    {
                        double tPrice = Convert.ToDouble(txtbParkingS.Text);
                        tParking = uDB.SearchParking(2, "Type.TotalPrice", "", 0, tPrice, false, lm);
                        if (rbAll.Checked)
                            tParking = uDB.SearchParking(2, "Type.TotalPrice", "", 0, tPrice, false, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tParking = uDB.SearchParking(5, "Type.TotalPrice", "", 0, tPrice, bl, lm);
                        dgvParking.DataSource = tParking;
                    }
                    break;
            }
            uDB.CloseCon();
            }

        private void btnCancelS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tParking = uDB.GetParking();
            dgvParking.DataSource = tParking;
            uDB.CloseCon();
        }
        //---------------------
        //Add--------
        private void btnOKRC_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            txtParkingTypeID.DataBindings.Clear();
            rcID = Convert.ToInt32(txtParkingRcID.Text);
            tType = uDB.GetTypeToApp(rcID, "Parking");
            cbAddParkingType.DataSource = tType;
            cbAddParkingType.DisplayMember = "Type";
            txtParkingTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
            uDB.CloseCon();
        }

        private void btnOKType_Click(object sender, EventArgs e)
        {
            typeID = Convert.ToInt32(txtParkingTypeID.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (typeID != 0)
            {
                myParking.Type_ID = typeID;
                uDB.InsertParking(myParking);
                tParking2 = uDB.GetTable("Parking");
                cbDelParkingID.DataSource = tParking2;
                cbDelParkingID.DisplayMember = "IDd";
            }
            uDB.CloseCon();
        }
        //-----

        //Delete-----
        private void btnDel_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int ParkingId = Convert.ToInt32(cbDelParkingID.Text);
            uDB.DeleteByIntNum("Parking", "IDd", ParkingId);
            tParking2 = uDB.GetTable("Parking");
            cbDelParkingID.DataSource = tParking2;
            cbDelParkingID.DisplayMember = "IDd";
            uDB.CloseCon();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tParking = uDB.GetParking();
            dgvParking.DataSource = tParking;
            uDB.CloseCon();
        }

        private void dgvParking_DoubleClick(object sender, EventArgs e)
        {
            gpImage.Visible = true;
            int id = Convert.ToInt32(dgvParking.CurrentRow.Cells[0].Value);
            uDB.OpenConnection();
            pbImage.Image = uDB.GetImages("Type INNER JOIN Parking ON Type.ID = Parking.Type_ID", "Parking.IDd", id);
            uDB.CloseCon();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gpImage.Visible = false;
        }

        //-----

        private void Parking_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            //Parking
            tParking = uDB.GetParking();
            DataGridSource();
            dgvParking.DataSource = tParking;
            //-------

            //Add----
            tRC = uDB.GetTable("RC");
            cbAddParkingRC.DataSource = tRC;
            cbAddParkingRC.DisplayMember = "Name";

            txtParkingRcID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
            rcID = Convert.ToInt32(txtParkingRcID.Text);
            tType = uDB.GetTypeToApp(rcID, "Parking");
            cbAddParkingType.DataSource = tType;
            cbAddParkingType.DisplayMember = "Type";

            txtParkingTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
            //-------

            //Delete----
            tParking2 = uDB.GetTable("Parking");
            cbDelParkingID.DataSource = tParking2;
            cbDelParkingID.DisplayMember = "IDd";
            //----------

            uDB.CloseCon();
        }
    }
}
