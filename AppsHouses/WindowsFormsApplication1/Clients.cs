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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }
        ClientAdd pClientAdd = new ClientAdd();
        ClientDelete pClientDel = new ClientDelete();

        UseDB uDB = new UseDB();
        Client myClient = new Client();
        DataTable tClient = new DataTable();
        string tname = "Clients";
        int index;

        private void dataGridSource()
        {
            dgvClients.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn iDTextBoxColumn = new DataGridViewTextBoxColumn();
            iDTextBoxColumn.DataPropertyName = "ID";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDTextBoxColumn.DefaultCellStyle = cellStyle1;
            iDTextBoxColumn.HeaderText = "Номер клієнта";
            iDTextBoxColumn.ReadOnly = true;
            //------
            //------Name
            DataGridViewTextBoxColumn nameTextBoxColumn = new DataGridViewTextBoxColumn();
            nameTextBoxColumn.DataPropertyName = "Name";
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();
            cellStyle2.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameTextBoxColumn.DefaultCellStyle = cellStyle2;
            nameTextBoxColumn.FillWeight = 500F;
            nameTextBoxColumn.HeaderText = "П. І. Б. Клієнта";
            nameTextBoxColumn.Width = 500;
            nameTextBoxColumn.ReadOnly = true;
            //------
            dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iDTextBoxColumn, nameTextBoxColumn });
            //------
        }
        private void BindingAdd()
        {
            lableID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tClient, "ID", true));
            txtbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", tClient, "Name", true));
            txtbPassSer.DataBindings.Add(new System.Windows.Forms.Binding("Text", tClient, "PassportSer", true));
            txtbPassNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", tClient, "PassportNum", true));
            txtbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", tClient, "Phone", true));
        }
        private void BindingClear()
        {
            lableID.DataBindings.Clear();
            txtbName.DataBindings.Clear();
            txtbPassSer.DataBindings.Clear();
            txtbPassNum.DataBindings.Clear();
            txtbPhone.DataBindings.Clear();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tClient = uDB.GetTable(tname);
            dataGridSource();
            dgvClients.DataSource = tClient;
            BindingAdd();
            uDB.CloseCon();
        }

        private void btnCancelS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tClient = uDB.GetTable(tname);
            BindingClear();
            BindingAdd();
            dgvClients.DataSource = tClient;
            uDB.CloseCon();
            txtbClientS.Clear();
            txtbClientS2.Clear();
            cbClientS.Text = "";
        }

        private void cbClientS_SelectedIndexChanged(object sender, EventArgs e)
        {

            index = cbClientS.SelectedIndex;
            switch (index)
            {
                case 0:
                    txtbClientS2.Visible = false;
                    txtbClientS2.Enabled = false;
                    break;
                case 1:
                    txtbClientS2.Visible = false;
                    txtbClientS2.Enabled = false;
                    break;
                case 2:
                    txtbClientS2.Visible = false;
                    txtbClientS2.Enabled = false;
                    break;
                case 3:
                    txtbClientS2.Visible = true;
                    txtbClientS2.Enabled = true;
                    break;
            }
        }

        private void btnClientS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            switch (index)
            {
                case 0:
                    if (txtbClientS.Text != "")
                    {
                        int id = Convert.ToInt32(txtbClientS.Text);
                        tClient = uDB.SearchByINTNum(tname, "ID", id);
                        dgvClients.DataSource = tClient;
                    }
                    break;
                case 1:
                    if (txtbClientS.Text != "")
                    {
                        string name = txtbClientS.Text;
                        tClient = uDB.SearchByString(tname, "Name", name);
                        dgvClients.DataSource = tClient;
                    }
                    break;
                case 2:
                    if (txtbClientS.Text != "")
                    {
                        int phone = Convert.ToInt32(txtbClientS.Text);
                        tClient = uDB.SearchByINTNum(tname, "Phone", phone);
                        dgvClients.DataSource = tClient;
                    }
                    break;
                case 3:
                    if (txtbClientS.Text != "" && txtbClientS2.Text != "")
                    {
                        int num = Convert.ToInt32(txtbClientS.Text);
                        string ser = txtbClientS2.Text;
                        tClient = uDB.SearchByPassPort(ser, num);
                        dgvClients.DataSource = tClient;
                    }
                    break;
            }
            BindingClear();
            BindingAdd();
            uDB.CloseCon();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pClientAdd.Size = this.Size;
            pClientAdd.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pClientDel.Size = this.Size;
            this.Hide();
            pClientDel.Show();
        }

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(lableID.Text);
            AddContract pAddContract = new AddContract(id, txtbName.Text);
            pAddContract.Size = this.Size;
            this.Hide();
            pAddContract.Show();
        }
    }
}
