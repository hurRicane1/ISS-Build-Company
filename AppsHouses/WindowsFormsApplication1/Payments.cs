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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }
        UseDB uDB = new UseDB();
        //Archive----------------------------------------
        DataTable tPayment = new DataTable();
        //ToPAY------------------------------------------
        DataTable tToPay = new DataTable();
        //ADD_PAYMENT------------------------------------
        DataTable tClient = new DataTable();
        DataTable tContract = new DataTable();
        Payment myPay = new Payment();
        //ARCHIVE----------------------------------------
        private void DataSourceArchive()
        {
            dgvPayment.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn idTextBoxColumn = new DataGridViewTextBoxColumn();
            idTextBoxColumn.DataPropertyName = "ID";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idTextBoxColumn.DefaultCellStyle = cellStyle1;
            idTextBoxColumn.FillWeight = 100F;
            idTextBoxColumn.HeaderText = "Номер платежу";
            idTextBoxColumn.Width = 100;
            idTextBoxColumn.ReadOnly = true;
            //------Client
            DataGridViewTextBoxColumn nameTextBoxColumn = new DataGridViewTextBoxColumn();
            nameTextBoxColumn.DataPropertyName = "Name";
            nameTextBoxColumn.DefaultCellStyle = cellStyle1;
            nameTextBoxColumn.FillWeight = 250F;
            nameTextBoxColumn.HeaderText = "П. І. Б. Клієнта";
            nameTextBoxColumn.Width = 250;
            nameTextBoxColumn.ReadOnly = true;
            //------Contract
            DataGridViewTextBoxColumn conTextBoxColumn = new DataGridViewTextBoxColumn();
            conTextBoxColumn.DataPropertyName = "Contract_ID";
            conTextBoxColumn.DefaultCellStyle = cellStyle1;
            conTextBoxColumn.FillWeight = 100F;
            conTextBoxColumn.HeaderText = "Номер договору";
            conTextBoxColumn.Width = 100;
            conTextBoxColumn.ReadOnly = true;
            //------DateOfContract
            DataGridViewTextBoxColumn dateConTextBoxColumn = new DataGridViewTextBoxColumn();
            dateConTextBoxColumn.DataPropertyName = "Contract.Data";
            dateConTextBoxColumn.DefaultCellStyle = cellStyle1;
            dateConTextBoxColumn.FillWeight = 115F;
            dateConTextBoxColumn.HeaderText = "Дата підписання";
            dateConTextBoxColumn.Width = 115;
            dateConTextBoxColumn.ReadOnly = true;
            //-----------
            //------Type
            DataGridViewTextBoxColumn typeTextBoxColumn = new DataGridViewTextBoxColumn();
            typeTextBoxColumn.DataPropertyName = "Type";
            typeTextBoxColumn.DefaultCellStyle = cellStyle1;
            typeTextBoxColumn.FillWeight = 185F;
            typeTextBoxColumn.HeaderText = "Тип платежу";
            typeTextBoxColumn.Width = 185;
            typeTextBoxColumn.ReadOnly = true;
            //-----------
            //------DateOfPay
            DataGridViewTextBoxColumn datePayTextBoxColumn = new DataGridViewTextBoxColumn();
            datePayTextBoxColumn.DataPropertyName = "Payment.Data";
            datePayTextBoxColumn.DefaultCellStyle = cellStyle1;
            datePayTextBoxColumn.FillWeight = 115F;
            datePayTextBoxColumn.HeaderText = "Дата платежу";
            datePayTextBoxColumn.Width = 115;
            datePayTextBoxColumn.ReadOnly = true;
            //-----------
            //------Money
            DataGridViewTextBoxColumn moneyTextBoxColumn = new DataGridViewTextBoxColumn();
            moneyTextBoxColumn.DataPropertyName = "Incoming";
            moneyTextBoxColumn.DefaultCellStyle = cellStyle1;
            moneyTextBoxColumn.FillWeight = 200F;
            moneyTextBoxColumn.HeaderText = "Внесено (грн)";
            moneyTextBoxColumn.Width = 200;
            moneyTextBoxColumn.ReadOnly = true;
            //-----------
            dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idTextBoxColumn, nameTextBoxColumn, conTextBoxColumn, dateConTextBoxColumn, typeTextBoxColumn, datePayTextBoxColumn, moneyTextBoxColumn });
        }
        private void btnPaymentS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (txtbPaymentS.Text!= "")
                switch(cbPaymentS.SelectedIndex)
                {
                    case 0:
                        {
                            int id = Convert.ToInt32(txtbPaymentS.Text);
                            tPayment = uDB.SearchPayment(1, "Payment.ID", "", id);
                        }
                        break;
                    case 1:
                        {
                            string name = txtbPaymentS.Text;
                            tPayment = uDB.SearchPayment(0, "Clients.Name", name, 0);
                        }
                        break;
                    case 2:
                        {
                            int id = Convert.ToInt32(txtbPaymentS.Text);
                            tPayment = uDB.SearchPayment(1, "Contract.ID", "", id);
                        }
                        break;
                    case 3:
                        {
                            string date = txtbPaymentS.Text;
                            tPayment = uDB.SearchPayment(0, "Contract.Data", date, 0);
                        }
                        break;
                    case 4:
                        {
                            string date = txtbPaymentS.Text;
                            tPayment = uDB.SearchPayment(0, "Payment.Data", date, 0);
                        }
                        break;
                }
            dgvPayment.DataSource = tPayment;
            uDB.CloseCon();
        }
        private void btnCancelS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tPayment = uDB.GetPayment();
            dgvPayment.DataSource = tPayment;
            uDB.CloseCon();
            txtbPaymentS.Text = "";
            cbPaymentS.SelectedIndex = -1;
        }
        //-----------------------------------------------

        //ToPAY------------------------------------------
        private void DataSourceToPay()
        {
            dgvToPay.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn idTextBoxColumn = new DataGridViewTextBoxColumn();
            idTextBoxColumn.DataPropertyName = "ID";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idTextBoxColumn.DefaultCellStyle = cellStyle1;
            idTextBoxColumn.FillWeight = 100F;
            idTextBoxColumn.HeaderText = "Номер договору";
            idTextBoxColumn.Width = 100;
            idTextBoxColumn.ReadOnly = true;
            //------Client
            DataGridViewTextBoxColumn nameTextBoxColumn = new DataGridViewTextBoxColumn();
            nameTextBoxColumn.DataPropertyName = "Name";
            nameTextBoxColumn.DefaultCellStyle = cellStyle1;
            nameTextBoxColumn.FillWeight = 300F;
            nameTextBoxColumn.HeaderText = "П. І. Б. Клієнта";
            nameTextBoxColumn.Width = 300;
            nameTextBoxColumn.ReadOnly = true;
            //------DateOfContract
            DataGridViewTextBoxColumn dateConTextBoxColumn = new DataGridViewTextBoxColumn();
            dateConTextBoxColumn.DataPropertyName = "Data";
            dateConTextBoxColumn.DefaultCellStyle = cellStyle1;
            dateConTextBoxColumn.FillWeight = 150F;
            dateConTextBoxColumn.HeaderText = "Дата підписання";
            dateConTextBoxColumn.Width = 150;
            dateConTextBoxColumn.ReadOnly = true;
            //-----------
            //------Phone
            DataGridViewTextBoxColumn phoneTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneTextBoxColumn.DataPropertyName = "Phone";
            phoneTextBoxColumn.DefaultCellStyle = cellStyle1;
            phoneTextBoxColumn.FillWeight = 200F;
            phoneTextBoxColumn.HeaderText = "Номер телефону";
            phoneTextBoxColumn.Width = 200;
            phoneTextBoxColumn.ReadOnly = true;
            //-----------
            //------DateOfPay
            DataGridViewTextBoxColumn datePayTextBoxColumn = new DataGridViewTextBoxColumn();
            datePayTextBoxColumn.DataPropertyName = "LastPayDate";
            datePayTextBoxColumn.DefaultCellStyle = cellStyle1;
            datePayTextBoxColumn.FillWeight = 150F;
            datePayTextBoxColumn.HeaderText = "Дата остайнього платежу";
            datePayTextBoxColumn.Width = 150;
            datePayTextBoxColumn.ReadOnly = true;
            //-----------
            dgvToPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idTextBoxColumn, nameTextBoxColumn, phoneTextBoxColumn, dateConTextBoxColumn, datePayTextBoxColumn});
        }
        private void ToPay()
        {
            uDB.OpenConnection();
            tToPay = uDB.ToPay();
            DataSourceToPay();
            dgvToPay.DataSource = tToPay;
            txtPhoneToPay.DataBindings.Clear();
            txtPhoneToPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", tToPay, "Phone", true));
            uDB.CloseCon();
        }
        private void btnOpenToPay_Click(object sender, EventArgs e)
        {
            ToPay();
        }
        //-----------------------------------------------
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        

        private void Payments_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            //ARCHIVE--------------------------
            tPayment = uDB.GetPayment();
            DataSourceArchive();
            dgvPayment.DataSource = tPayment;
            //---------------------------------
            //ADD_PAYMENT----------------------
            tClient = uDB.GetTable("Clients");
            cbClient.DataSource = tClient;
            cbClient.DisplayMember = "Name";
            txtClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tClient, "ID", true));
            int ClientID = Convert.ToInt32(txtClientID.Text);

            tContract = uDB.SearchByINTNum("Contract", "ClientID", ClientID);
            cbAddPaymentContractID.DataSource = tContract;
            cbAddPaymentContractID.DisplayMember = "ID";
            //---------------------------------
            uDB.CloseCon();
        }

        private void btnClientID_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int ClientID = Convert.ToInt32(txtClientID.Text);

            tContract = uDB.SearchByINTNum("Contract", "ClientID", ClientID);
            cbAddPaymentContractID.DataSource = tContract;
            cbAddPaymentContractID.DisplayMember = "ID";
            uDB.CloseCon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if(cbClient.Text!="" && cbAddPaymentContractID.Text!="" && cbType.Text!="" && txtIncom.Text!="")
            {
                myPay.Client_ID = Convert.ToInt32(txtClientID.Text);
                myPay.Contract_ID = Convert.ToInt32(cbAddPaymentContractID.Text);
                myPay.Type = cbType.Text;
                myPay.incoming = Convert.ToDouble(txtIncom.Text);
                uDB.InsertPayment(myPay);
            }
            uDB.CloseCon();
        }
    }
}
