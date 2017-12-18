using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class Houses : Form
    {
        public Houses()
        {
            InitializeComponent();
        }
        DataTable tRC = new DataTable();
        DataTable tPic = new DataTable();
        DataSet ds = new DataSet();
        UseDB uDB = new UseDB();
        AddHouse pAddHouse = new AddHouse();
        DeleteHouse pDeleteHouse = new DeleteHouse();

        private void DataGridSource()
        {
            dgvRC.AutoGenerateColumns = false;
            //------Name
            DataGridViewTextBoxColumn nameTextBoxColumn = new DataGridViewTextBoxColumn();
            nameTextBoxColumn.DataPropertyName = "Name";
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();
            cellStyle2.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameTextBoxColumn.DefaultCellStyle = cellStyle2;
            nameTextBoxColumn.FillWeight = 150F;
            nameTextBoxColumn.HeaderText = "Назва ЖК";
            nameTextBoxColumn.Width = 150;
            nameTextBoxColumn.ReadOnly = true;
            //------Address
            DataGridViewTextBoxColumn AddressTextBoxColumn = new DataGridViewTextBoxColumn();
            AddressTextBoxColumn.DataPropertyName = "Address";
            AddressTextBoxColumn.DefaultCellStyle = cellStyle2;
            AddressTextBoxColumn.FillWeight = 200F;
            AddressTextBoxColumn.HeaderText = "Адреса";
            AddressTextBoxColumn.Width = 200;
            AddressTextBoxColumn.ReadOnly = true;
            //------Entrance
            DataGridViewTextBoxColumn BldAmTextBoxColumn = new DataGridViewTextBoxColumn();
            BldAmTextBoxColumn.DataPropertyName = "Bldgs_am";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BldAmTextBoxColumn.DefaultCellStyle = cellStyle1;
            BldAmTextBoxColumn.FillWeight = 100F;
            BldAmTextBoxColumn.HeaderText = "Кількість під'їздів";
            BldAmTextBoxColumn.Width = 100;
            BldAmTextBoxColumn.ReadOnly = true;
            //--------
            dgvRC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { nameTextBoxColumn, AddressTextBoxColumn, BldAmTextBoxColumn });
        }

        private void BindingAdd()
        {
            txtbRC.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "Name", true));
            txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "Address", true));
            txtBldngAm.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "Bldgs_am", true));
            rtxtbCross.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "Cross", true));
            rtxtWallMat.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "WallsMat", true));
            rtxtInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "Info", true));
            txtRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
        }
        public void BindingClear()
        {
            txtbRC.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtBldngAm.DataBindings.Clear();
            rtxtbCross.DataBindings.Clear();
            rtxtWallMat.DataBindings.Clear();
            rtxtInfo.DataBindings.Clear();
            txtRCID.DataBindings.Clear();
        }



        private void Houses_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tRC = uDB.GetTable("RC");
            DataGridSource();
            dgvRC.DataSource = tRC;
            BindingAdd();

            uDB.CloseCon();
        }

        private void btnRCS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            switch (cbRcS.SelectedIndex)
            {
                case 0:
                    {
                        string rc = txtbRcS.Text;
                        tRC = uDB.SearchByString("RC", "Name", rc);
                        dgvRC.DataSource = tRC;
                    }
                    break;
                case 1:
                    {
                        string address = txtbRcS.Text;
                        tRC = uDB.SearchByString("RC","Address",address);
                        dgvRC.DataSource = tRC;
                    }
                    break;
                case 2:
                    {
                        int lm = 2;
                        if (rbEqual.Checked) lm = 2;
                        if (rbLess.Checked) lm = 0;
                        if (rbMore.Checked) lm = 1;
                        int bldngAm = Convert.ToInt32(txtbRcS.Text);
                        tRC = uDB.GetLessMore("RC", "Bldgs_am", bldngAm, 0, 0, lm);
                        dgvRC.DataSource = tRC;
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
            tRC = uDB.GetTable("RC");
            BindingClear();
            BindingAdd();
            dgvRC.DataSource = tRC;
            uDB.CloseCon();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pAddHouse.Size = this.Size;
            pAddHouse.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pDeleteHouse.Size = this.Size;
            pDeleteHouse.Show();
            this.Hide();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            gbInfo.Visible = false;
            gbImage.Visible = true;
            int id = Convert.ToInt32(txtRCID.Text);
            uDB.OpenConnection();
            pbImage.Image = uDB.GetImages("RC", "ID", id);   
            uDB.CloseCon();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gbImage.Visible = false;
            gbInfo.Visible = true;
        }

        private void dgvRC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(txtRCID.Text);
            uDB.OpenConnection();
            pbImage.Image = uDB.GetImages("RC", "ID", id);
            uDB.CloseCon();
        }
    }
}
