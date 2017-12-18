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
    public partial class Apps : Form
    {
        public Apps()
        {
            InitializeComponent();
        }

        AddApp pAddApp = new AddApp();
        DeleteApp pDeleteApp = new DeleteApp();
        UseDB uDB = new UseDB();
        App myApp = new App();
        DataTable tApps = new DataTable();
        bool bl;
        

        public void DataGridSource()
        {
            dgvApps.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn iDTextBoxColumn = new DataGridViewTextBoxColumn();
            iDTextBoxColumn.DataPropertyName = "AppNum";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDTextBoxColumn.DefaultCellStyle = cellStyle1;
            iDTextBoxColumn.HeaderText = "Номер квартири";
            iDTextBoxColumn.ReadOnly = true;
            //------Name
            DataGridViewTextBoxColumn nameTextBoxColumn = new DataGridViewTextBoxColumn();
            nameTextBoxColumn.DataPropertyName = "Name";
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();
            cellStyle2.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameTextBoxColumn.DefaultCellStyle = cellStyle2;
            nameTextBoxColumn.FillWeight = 200F;
            nameTextBoxColumn.HeaderText = "Житловий комплекс";
            nameTextBoxColumn.Width = 200;
            nameTextBoxColumn.ReadOnly = true;
            //------Price
            DataGridViewTextBoxColumn priceTextBoxColumn = new DataGridViewTextBoxColumn();
            priceTextBoxColumn.DataPropertyName = "TotalPrice";
            priceTextBoxColumn.DefaultCellStyle = cellStyle2;
            priceTextBoxColumn.FillWeight = 150F;
            priceTextBoxColumn.HeaderText = "Ціна (грн)";
            priceTextBoxColumn.Width = 150;
            priceTextBoxColumn.ReadOnly = true;
            //-----------
            dgvApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iDTextBoxColumn, nameTextBoxColumn, priceTextBoxColumn });
        }

        private void BindingAdd()
        {
            txtbRC.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApps, "Name", true));
            txtbAppType.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApps, "Type", true));
            txtbFloor.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApps, "Floor", true));
            txtbAppNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApps, "AppNum", true));
            txtbLArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApps, "LiveArea", true));
            txtbTArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApps, "TotalArea", true));
            txtbRoomAm.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApps, "RoomAm", true));
            txtbPriceM2.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApps, "PriceAppM2", true));
            txtbTPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApps, "TotalPrice", true));
            txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApps, "Type_ID", true));

        }
        private void BindingClear()
        {
            txtbRC.DataBindings.Clear();
            txtbAppType.DataBindings.Clear();
            txtbFloor.DataBindings.Clear();
            txtbAppNum.DataBindings.Clear();
            txtbLArea.DataBindings.Clear();
            txtbTArea.DataBindings.Clear();
            txtbRoomAm.DataBindings.Clear();
            txtbPriceM2.DataBindings.Clear();
            txtbTPrice.DataBindings.Clear();
            txtAppID.DataBindings.Clear();
        }

        private void Apps_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tApps = uDB.GetApps();
            DataGridSource();
            dgvApps.DataSource = tApps;
            BindingAdd();
            uDB.CloseCon();
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pAddApp.Size = this.Size;
            pAddApp.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pDeleteApp.Size = this.Size;
            pDeleteApp.Show();
            this.Hide();
        }

        private void btnAppS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            switch (cbClientS.SelectedIndex)
            {
                case 0:
                    {
                        string rc = txtbAppS.Text;
                        tApps = uDB.SearchApps(bl, 0, "RC.Name", rc, 0, 0, 0);
                        if (rbAll.Checked)
                            tApps =uDB.SearchApps(bl, 0, "RC.Name", rc, 0, 0, 0);
                        if (rbSold.Checked || rbForSell.Checked)
                            tApps = uDB.SearchApps(bl, 4, "RC.Name", rc, 0, 0, 0);
                        dgvApps.DataSource = tApps;
                    }
                    break;
                case 1:
                    {
                        string type = txtbAppS.Text;
                        tApps = uDB.SearchApps(bl, 0, "Type.Type", type, 0, 0, 0);
                        if (rbAll.Checked)
                            tApps = uDB.SearchApps(bl, 0, "Type.Type", type, 0, 0, 0);
                        if (rbSold.Checked || rbForSell.Checked)
                            tApps = uDB.SearchApps(bl, 4, "Type.Type", type, 0, 0, 0);
                        dgvApps.DataSource = tApps;
                    }
                    break;
                case 2:
                    {
                        int lm = 2;
                        if (rbEqual.Checked) lm = 2;
                        if (rbLess.Checked) lm = 0;
                        if (rbMore.Checked) lm = 1;
                        int floor = Convert.ToInt32(txtbAppS.Text);
                        tApps = uDB.SearchApps(bl, 1, "Apps.Floor", "", floor, 0, lm);
                        if (rbAll.Checked)
                            tApps = uDB.SearchApps(bl, 1, "Apps.Floor", "", floor, 0, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tApps = uDB.SearchApps(bl, 5, "Apps.Floor", "", floor, 0, lm);
                        dgvApps.DataSource = tApps;
                    }
                    break;
                case 3:
                    {
                        int lm = 2;
                        if (rbEqual.Checked) lm = 2;
                        if (rbLess.Checked) lm = 0;
                        if (rbMore.Checked) lm = 1;
                        int roomAm = Convert.ToInt32(txtbAppS.Text);
                        tApps = uDB.SearchApps(bl, 1, "Type.RoomAm", "", roomAm, 0, lm);
                        if (rbAll.Checked)
                            tApps = uDB.SearchApps(bl, 1, "Type.RoomAm", "", roomAm, 0, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tApps = uDB.SearchApps(bl, 5, "Type.RoomAm", "", roomAm, 0, lm);
                        dgvApps.DataSource = tApps;
                    }
                    break;
                case 4:
                    {
                        int lm=2;
                        if (rbEqual.Checked) lm = 2;
                        if (rbLess.Checked) lm = 0;
                        if (rbMore.Checked) lm = 1;
                        double liveArea = Convert.ToDouble(txtbAppS.Text);
                        tApps = uDB.SearchApps(bl, 3, "Type.LiveArea", "", 0, liveArea, lm);
                        if (rbAll.Checked)
                            tApps = uDB.SearchApps(bl, 3, "Type.LiveArea", "", 0, liveArea, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tApps = uDB.SearchApps(bl, 6, "Type.LiveArea", "", 0, liveArea, lm);
                        dgvApps.DataSource = tApps;
                    }
                    break;
                case 5:
                    {
                        int lm = 2;
                        if (rbEqual.Checked) lm = 2;
                        if (rbLess.Checked) lm = 0;
                        if (rbMore.Checked) lm = 1;
                        double totalArea = Convert.ToDouble(txtbAppS.Text);
                        tApps = uDB.SearchApps(bl, 3, "Type.TotalArea", "", 0, totalArea, lm);
                        if (rbAll.Checked)
                            tApps = uDB.SearchApps(bl, 3, "Type.TotalArea", "", 0, totalArea, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tApps = uDB.SearchApps(bl, 6, "Type.TotalArea", "", 0, totalArea, lm);
                        dgvApps.DataSource = tApps;
                    }
                    break;
                case 6:
                    {
                        int lm = 2;
                        if (rbEqual.Checked) lm = 2;
                        if (rbLess.Checked) lm = 0;
                        if (rbMore.Checked) lm = 1;
                        double totalPrice = Convert.ToDouble(txtbAppS.Text);
                        tApps = uDB.SearchApps(bl, 3, "Type.TotalPrice", "", 0, totalPrice, lm);
                        if (rbAll.Checked)
                            tApps = uDB.SearchApps(bl, 3, "Type.TotalPrice", "", 0, totalPrice, lm);
                        if (rbSold.Checked || rbForSell.Checked)
                            tApps = uDB.SearchApps(bl, 6, "Type.TotalPrice", "", 0, totalPrice, lm);
                        dgvApps.DataSource = tApps;
                    }
                    break;
            }
            BindingClear();
            BindingAdd();
            uDB.CloseCon();
        }

        private void btnCancelS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tApps = uDB.GetApps();
            BindingClear();
            BindingAdd();
            dgvApps.DataSource = tApps;
            uDB.CloseCon();
        }

        private void chBAll_CheckedChanged(object sender, EventArgs e)
        {
            
            uDB.OpenConnection();
            tApps = uDB.GetApps();
            BindingClear();
            BindingAdd();
            dgvApps.DataSource = tApps;
            uDB.CloseCon();
        }

        private void chbSold_CheckedChanged(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tApps = uDB.GetAppsSold(true);
            BindingClear();
            BindingAdd();
            dgvApps.DataSource = tApps;
            uDB.CloseCon();
            bl = true;
        }

        private void rbForSell_CheckedChanged(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tApps = uDB.GetAppsSold(false);
            BindingClear();
            BindingAdd();
            dgvApps.DataSource = tApps;
            uDB.CloseCon();
            bl = false;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            gpInfo.Visible = false;
            gpImage.Visible = true;
            int id = Convert.ToInt32(txtAppID.Text);
            uDB.OpenConnection();
            pbImage.Image = uDB.GetImages("Type", "ID", id);
            uDB.CloseCon();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            gpInfo.Visible = true;
            gpImage.Visible = false;
        }

        private void dgvApps_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtAppID.Text);
            uDB.OpenConnection();
            pbImage.Image = uDB.GetImages("Type", "ID", id);
            uDB.CloseCon();
        }
    }
}
