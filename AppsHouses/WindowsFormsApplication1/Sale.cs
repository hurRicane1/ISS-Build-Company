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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }
        UseDB uDB = new UseDB();
        //Apps----------------------------------------------
        DataTable tSaleApp = new DataTable();
        //ComArea-------------------------------------------
        DataTable tSaleCom = new DataTable();
        //Footer
        DataTable tSaleFooter = new DataTable();
        //Parking-------------------------------------------
        DataTable tSaleParking = new DataTable();
        //ADD-----------------------------------------------
        DataTable tAppClient = new DataTable();
        DataTable tAppRC = new DataTable();
        DataTable tAppType = new DataTable();
        DataTable tAppApp = new DataTable();
        //--------------------------------------------------
        //DELETE--------------------------------------------
        DataTable tClientDel;
        DataTable tContractNum;
        //--------------------------------------------------
        int term;
        Contract myContract = new Contract();

        //Apps----------------------------------------------
        private void DataSourceApp()
        {
            dgvSaleApp.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn iDTextBoxColumn = new DataGridViewTextBoxColumn();
            iDTextBoxColumn.DataPropertyName = "ID";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDTextBoxColumn.DefaultCellStyle = cellStyle1;
            iDTextBoxColumn.HeaderText = "Номер договору";
            iDTextBoxColumn.ReadOnly = true;
            //------
            //------RC
            DataGridViewTextBoxColumn rcTextBoxColumn = new DataGridViewTextBoxColumn();
            rcTextBoxColumn.DataPropertyName = "RC.Name";
            rcTextBoxColumn.DefaultCellStyle = cellStyle1;
            rcTextBoxColumn.HeaderText = "ЖК";
            rcTextBoxColumn.ReadOnly = true;
            //------
            //------Name
            DataGridViewTextBoxColumn nameTextBoxColumn = new DataGridViewTextBoxColumn();
            nameTextBoxColumn.DataPropertyName = "Clients.Name";
            nameTextBoxColumn.DefaultCellStyle = cellStyle1;
            nameTextBoxColumn.FillWeight = 240F;
            nameTextBoxColumn.HeaderText = "П. І. Б. Клієнта";
            nameTextBoxColumn.Width = 240;
            nameTextBoxColumn.ReadOnly = true;
            //------
            //------Date
            DataGridViewCheckBoxColumn closedCheckBoxColumn = new DataGridViewCheckBoxColumn();
            closedCheckBoxColumn.DataPropertyName = "Closed";
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();
            cellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            closedCheckBoxColumn.DefaultCellStyle = cellStyle2;
            closedCheckBoxColumn.FillWeight = 100F;
            closedCheckBoxColumn.HeaderText = "Закрито";
            closedCheckBoxColumn.Width = 100;
            closedCheckBoxColumn.ReadOnly = true;
            //------
            dgvSaleApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iDTextBoxColumn, rcTextBoxColumn, nameTextBoxColumn, closedCheckBoxColumn });
            //------
        }
        private void BindingAddApp()
        {
            lableIDApp.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "ID", true));
            txtbPhoneApp.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "Phone", true));
            txtbTypeApp.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "Type", true));
            txtbFloorApp.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "Floor", true));
            txtbAppNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "AppNum", true));
            txtbDateApp.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "Data", true));
            txtbTermApp.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "Term", true));
            txtbDateLastPayApp.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "LastPayDate", true));
            txtPayePerPeriodApp.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "PayPerPeriod", true));
            txtbPayedApp.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "Payed", true));
            txtbTotalPayApp.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleApp, "TotalPay", true));
        }
        private void BindingClearApp()
        {
            lableIDApp.DataBindings.Clear();
            txtbPhoneApp.DataBindings.Clear();
            txtbTypeApp.DataBindings.Clear();
            txtbFloorApp.DataBindings.Clear();
            txtbAppNum.DataBindings.Clear();
            txtbDateApp.DataBindings.Clear();
            txtbTermApp.DataBindings.Clear();
            txtbDateLastPayApp.DataBindings.Clear();
            txtPayePerPeriodApp.DataBindings.Clear();
            txtbPayedApp.DataBindings.Clear();
            txtbTotalPayApp.DataBindings.Clear();
        }
        private void btnAppS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (txtbAppS.Text!="")
            switch (cbAppS.SelectedIndex)
            {
                case 0:
                    {
                            int id = Convert.ToInt32(txtbAppS.Text);
                            tSaleApp = uDB.SearchContract(1, "Contract.ID", "", id, 0);
                            dgvSaleApp.DataSource = tSaleApp;
                    }
                    break;
                case 1:
                    {
                            string name = txtbAppS.Text;
                            tSaleApp = uDB.SearchContract(0, "Clients.Name", name, 0, 0);
                            dgvSaleApp.DataSource = tSaleApp;
                    }
                    break;
                case 2:
                    {
                            int phone = Convert.ToInt32(txtbAppS.Text);
                            tSaleApp = uDB.SearchContract(1, "Clients.Phone", "", phone, 0);
                            dgvSaleApp.DataSource = tSaleApp;
                        }
                    break;
                case 3:
                    {
                            string name = txtbAppS.Text;
                            tSaleApp = uDB.SearchContract(0, "RC.Name", name, 0, 0);
                            dgvSaleApp.DataSource = tSaleApp;
                        }
                    break;
                case 4:
                    {
                            string type = txtbAppS.Text;
                            tSaleApp = uDB.SearchContract(0, "Type.Type", type, 0, 0);
                            dgvSaleApp.DataSource = tSaleApp;
                        }
                    break;
                case 5:
                    {
                            string date = txtbAppS.Text;
                            tSaleApp = uDB.SearchContract(0, "Contract.Data", date, 0, 0);
                            dgvSaleApp.DataSource = tSaleApp;
                        }
                    break;
            }
            BindingClearApp();
            BindingAddApp();
            uDB.CloseCon();
        }
        private void btnCancelAppS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tSaleApp = uDB.GetContract();
            BindingClearApp();
            BindingAddApp();
            dgvSaleApp.DataSource = tSaleApp;
            uDB.CloseCon();
            txtbAppS.Clear();
            cbAppS.Text = "";
        }
        //--------------------------------------------------

        //ComArea-------------------------------------------
        private void DataSourceCom()
        {
            dgvSaleCom.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn iDTextBoxColumn = new DataGridViewTextBoxColumn();
            iDTextBoxColumn.DataPropertyName = "ID";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDTextBoxColumn.DefaultCellStyle = cellStyle1;
            iDTextBoxColumn.HeaderText = "Номер договору";
            iDTextBoxColumn.ReadOnly = true;
            //------
            //------RC
            DataGridViewTextBoxColumn rcTextBoxColumn = new DataGridViewTextBoxColumn();
            rcTextBoxColumn.DataPropertyName = "RC.Name";
            rcTextBoxColumn.DefaultCellStyle = cellStyle1;
            rcTextBoxColumn.HeaderText = "ЖК";
            rcTextBoxColumn.ReadOnly = true;
            //------
            //------Name
            DataGridViewTextBoxColumn nameTextBoxColumn = new DataGridViewTextBoxColumn();
            nameTextBoxColumn.DataPropertyName = "Clients.Name";
            nameTextBoxColumn.DefaultCellStyle = cellStyle1;
            nameTextBoxColumn.FillWeight = 240F;
            nameTextBoxColumn.HeaderText = "П. І. Б. Клієнта";
            nameTextBoxColumn.Width = 240;
            nameTextBoxColumn.ReadOnly = true;
            //------
            //------Date
            DataGridViewCheckBoxColumn closedCheckBoxColumn = new DataGridViewCheckBoxColumn();
            closedCheckBoxColumn.DataPropertyName = "Closed";
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();
            cellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            closedCheckBoxColumn.DefaultCellStyle = cellStyle2;
            closedCheckBoxColumn.FillWeight = 100F;
            closedCheckBoxColumn.HeaderText = "Закрито";
            closedCheckBoxColumn.Width = 100;
            closedCheckBoxColumn.ReadOnly = true;
            //------
            dgvSaleCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iDTextBoxColumn, rcTextBoxColumn, nameTextBoxColumn, closedCheckBoxColumn });
            //------
        }
        private void BindingAddCom()
        {
            labelComID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleCom, "ID", true));
            txtbComPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleCom, "Phone", true));
            txtbComType.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleCom, "Type", true));
            txtbComID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleCom, "IDd", true));
            txtbComDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleCom, "Data", true));
            txtbComTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleCom, "Term", true));
            txtbComLastPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleCom, "LastPayDate", true));
            txtbComPayPerPeriod.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleCom, "PayPerPeriod", true));
            txtbPayedCom.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleCom, "Payed", true));
            txtbComTotalPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleCom, "TotalPay", true));
        }
        private void BindingClearCom()
        {
            labelComID.DataBindings.Clear();
            txtbComPhone.DataBindings.Clear();
            txtbComType.DataBindings.Clear();
            txtbComID.DataBindings.Clear();
            txtbComDate.DataBindings.Clear();
            txtbComTerm.DataBindings.Clear();
            txtbComLastPay.DataBindings.Clear();
            txtbComPayPerPeriod.DataBindings.Clear();
            txtbPayedCom.DataBindings.Clear();
            txtbComTotalPay.DataBindings.Clear();
        }
        private void btnComS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (txtbComS.Text != "")
                switch (cbComS.SelectedIndex)
                {
                    case 0:
                        {
                            int id = Convert.ToInt32(txtbComS.Text);
                            tSaleCom = uDB.SearchContractCom(1, "Contract.ID", "", id, 0);
                            dgvSaleCom.DataSource = tSaleCom;
                        }
                        break;
                    case 1:
                        {
                            string name = txtbComS.Text;
                            tSaleCom = uDB.SearchContractCom(0, "Clients.Name", name, 0, 0);
                            dgvSaleCom.DataSource = tSaleCom;
                        }
                        break;
                    case 2:
                        {
                            int phone = Convert.ToInt32(txtbComS.Text);
                            tSaleCom = uDB.SearchContractCom(1, "Clients.Phone", "", phone, 0);
                            dgvSaleCom.DataSource = tSaleCom;
                        }
                        break;
                    case 3:
                        {
                            string name = txtbComS.Text;
                            tSaleCom = uDB.SearchContractCom(0, "RC.Name", name, 0, 0);
                            dgvSaleCom.DataSource = tSaleCom;
                        }
                        break;
                    case 4:
                        {
                            string type = txtbComS.Text;
                            tSaleCom = uDB.SearchContractCom(0, "Type.Type", type, 0, 0);
                            dgvSaleCom.DataSource = tSaleCom;
                        }
                        break;
                    case 5:
                        {
                            string date = txtbComS.Text;
                            tSaleCom = uDB.SearchContractCom(0, "Contract.Data", date, 0, 0);
                            dgvSaleCom.DataSource = tSaleCom;
                        }
                        break;
                }
            BindingClearCom();
            BindingAddCom();
            uDB.CloseCon();
        }

        private void btnCancelComS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tSaleCom = uDB.GetContractCom();
            BindingClearCom();
            BindingAddCom();
            dgvSaleCom.DataSource = tSaleCom;
            uDB.CloseCon();
            txtbComS.Clear();
            cbComS.Text = "";
        }
        //--------------------------------------------------

        //Footer--------------------------------------------
        private void DataSourceFooter()
        {
            dgvSaleFooter.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn iDTextBoxColumn = new DataGridViewTextBoxColumn();
            iDTextBoxColumn.DataPropertyName = "ID";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDTextBoxColumn.DefaultCellStyle = cellStyle1;
            iDTextBoxColumn.HeaderText = "Номер договору";
            iDTextBoxColumn.ReadOnly = true;
            //------
            //------RC
            DataGridViewTextBoxColumn rcTextBoxColumn = new DataGridViewTextBoxColumn();
            rcTextBoxColumn.DataPropertyName = "RC.Name";
            rcTextBoxColumn.DefaultCellStyle = cellStyle1;
            rcTextBoxColumn.HeaderText = "ЖК";
            rcTextBoxColumn.ReadOnly = true;
            //------
            //------Name
            DataGridViewTextBoxColumn nameTextBoxColumn = new DataGridViewTextBoxColumn();
            nameTextBoxColumn.DataPropertyName = "Clients.Name";
            nameTextBoxColumn.DefaultCellStyle = cellStyle1;
            nameTextBoxColumn.FillWeight = 240F;
            nameTextBoxColumn.HeaderText = "П. І. Б. Клієнта";
            nameTextBoxColumn.Width = 240;
            nameTextBoxColumn.ReadOnly = true;
            //------
            //------Date
            DataGridViewCheckBoxColumn closedCheckBoxColumn = new DataGridViewCheckBoxColumn();
            closedCheckBoxColumn.DataPropertyName = "Closed";
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();
            cellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            closedCheckBoxColumn.DefaultCellStyle = cellStyle2;
            closedCheckBoxColumn.FillWeight = 100F;
            closedCheckBoxColumn.HeaderText = "Закрито";
            closedCheckBoxColumn.Width = 100;
            closedCheckBoxColumn.ReadOnly = true;
            //------
            dgvSaleFooter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iDTextBoxColumn, rcTextBoxColumn, nameTextBoxColumn, closedCheckBoxColumn });
            //------
        }
        private void BindingAddFooter()
        {
            labelFooterID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleFooter, "ID", true));
            txtbFooterPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleFooter, "Phone", true));
            txtbFooterType.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleFooter, "Type", true));
            txtbFooterNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleFooter, "IDd", true));
            txtbFooterDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleFooter, "Data", true));
            txtbFooterTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleFooter, "Term", true));
            txtbFooterLastPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleFooter, "LastPayDate", true));
            txtbFooterPayPerPeriod.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleFooter, "PayPerPeriod", true));
            txtbPayedFooter.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleFooter, "Payed", true));
            txtbFooterTotalPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleFooter, "TotalPay", true));
        }
        private void BindingClearFooter()
        {
            labelFooterID.DataBindings.Clear();
            txtbFooterPhone.DataBindings.Clear();
            txtbFooterType.DataBindings.Clear();
            txtbFooterNum.DataBindings.Clear();
            txtbFooterDate.DataBindings.Clear();
            txtbFooterTerm.DataBindings.Clear();
            txtbFooterLastPay.DataBindings.Clear();
            txtbFooterPayPerPeriod.DataBindings.Clear();
            txtbPayedFooter.DataBindings.Clear();
            txtbFooterTotalPay.DataBindings.Clear();
        }
        private void btnFooterS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (txtbFooterS.Text != "")
                switch (cbFooterS.SelectedIndex)
                {
                    case 0:
                        {
                            int id = Convert.ToInt32(txtbFooterS.Text);
                            tSaleFooter = uDB.SearchContractFooter(1, "Contract.ID", "", id, 0);
                            dgvSaleFooter.DataSource = tSaleFooter;
                        }
                        break;
                    case 1:
                        {
                            string name = txtbFooterS.Text;
                            tSaleFooter = uDB.SearchContractFooter(0, "Clients.Name", name, 0, 0);
                            dgvSaleFooter.DataSource = tSaleFooter;
                        }
                        break;
                    case 2:
                        {
                            int phone = Convert.ToInt32(txtbFooterS.Text);
                            tSaleFooter = uDB.SearchContractFooter(1, "Clients.Phone", "", phone, 0);
                            dgvSaleFooter.DataSource = tSaleFooter;
                        }
                        break;
                    case 3:
                        {
                            string name = txtbFooterS.Text;
                            tSaleFooter = uDB.SearchContractFooter(0, "RC.Name", name, 0, 0);
                            dgvSaleFooter.DataSource = tSaleFooter;
                        }
                        break;
                    case 4:
                        {
                            string type = txtbFooterS.Text;
                            tSaleFooter = uDB.SearchContractFooter(0, "Type.Type", type, 0, 0);
                            dgvSaleFooter.DataSource = tSaleFooter;
                        }
                        break;
                    case 5:
                        {
                            string date = txtbFooterS.Text;
                            tSaleFooter = uDB.SearchContractFooter(0, "Contract.Data", date, 0, 0);
                            dgvSaleFooter.DataSource = tSaleFooter;
                        }
                        break;
                }
            BindingClearFooter();
            BindingAddFooter();
            uDB.CloseCon();
        }

        private void btnCancelFooterS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tSaleFooter = uDB.GetContractFooter();
            BindingClearFooter();
            BindingAddFooter();
            dgvSaleFooter.DataSource = tSaleFooter;
            uDB.CloseCon();
            txtbFooterS.Clear();
            cbFooterS.Text = "";
        }
        //--------------------------------------------------
        //Parking-------------------------------------------
        private void DataSourceParking()
        {
            dgvSaleParking.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn iDTextBoxColumn = new DataGridViewTextBoxColumn();
            iDTextBoxColumn.DataPropertyName = "ID";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDTextBoxColumn.DefaultCellStyle = cellStyle1;
            iDTextBoxColumn.HeaderText = "Номер договору";
            iDTextBoxColumn.ReadOnly = true;
            //------
            //------RC
            DataGridViewTextBoxColumn rcTextBoxColumn = new DataGridViewTextBoxColumn();
            rcTextBoxColumn.DataPropertyName = "RC.Name";
            rcTextBoxColumn.DefaultCellStyle = cellStyle1;
            rcTextBoxColumn.HeaderText = "ЖК";
            rcTextBoxColumn.ReadOnly = true;
            //------
            //------Name
            DataGridViewTextBoxColumn nameTextBoxColumn = new DataGridViewTextBoxColumn();
            nameTextBoxColumn.DataPropertyName = "Clients.Name";
            nameTextBoxColumn.DefaultCellStyle = cellStyle1;
            nameTextBoxColumn.FillWeight = 240F;
            nameTextBoxColumn.HeaderText = "П. І. Б. Клієнта";
            nameTextBoxColumn.Width = 240;
            nameTextBoxColumn.ReadOnly = true;
            //------
            //------Date
            DataGridViewCheckBoxColumn closedCheckBoxColumn = new DataGridViewCheckBoxColumn();
            closedCheckBoxColumn.DataPropertyName = "Closed";
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();
            cellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            closedCheckBoxColumn.DefaultCellStyle = cellStyle2;
            closedCheckBoxColumn.FillWeight = 100F;
            closedCheckBoxColumn.HeaderText = "Закрито";
            closedCheckBoxColumn.Width = 100;
            closedCheckBoxColumn.ReadOnly = true;
            //------
            dgvSaleParking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iDTextBoxColumn, rcTextBoxColumn, nameTextBoxColumn, closedCheckBoxColumn });
            //------
        }
        private void BindingAddParking()
        {
            labelParkingID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleParking, "ID", true));
            txtbParkingPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleParking, "Phone", true));
            txtbParkingType.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleParking, "Type", true));
            txtbParkingNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleParking, "IDd", true));
            txtbParkingDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleParking, "Data", true));
            txtbParkingTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleParking, "Term", true));
            txtbParkingLastPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleParking, "LastPayDate", true));
            txtbParkingPayPerPeriod.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleParking, "PayPerPeriod", true));
            txtbPayedParking.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleParking, "Payed", true));
            txtbParkingTotalPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", tSaleParking, "TotalPay", true));
        }
        private void BindingClearParking()
        {
            labelParkingID.DataBindings.Clear();
            txtbParkingPhone.DataBindings.Clear();
            txtbParkingType.DataBindings.Clear();
            txtbParkingNum.DataBindings.Clear();
            txtbParkingDate.DataBindings.Clear();
            txtbParkingTerm.DataBindings.Clear();
            txtbParkingLastPay.DataBindings.Clear();
            txtbParkingPayPerPeriod.DataBindings.Clear();
            txtbPayedParking.DataBindings.Clear();
            txtbParkingTotalPay.DataBindings.Clear();
        }
        private void btnParkingS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (txtbParkingS.Text != "")
                switch (cbParkingS.SelectedIndex)
                {
                    case 0:
                        {
                            int id = Convert.ToInt32(txtbParkingS.Text);
                            tSaleParking = uDB.SearchContractParking(1, "Contract.ID", "", id, 0);
                            dgvSaleParking.DataSource = tSaleParking;
                        }
                        break;
                    case 1:
                        {
                            string name = txtbParkingS.Text;
                            tSaleParking = uDB.SearchContractParking(0, "Clients.Name", name, 0, 0);
                            dgvSaleParking.DataSource = tSaleParking;
                        }
                        break;
                    case 2:
                        {
                            int phone = Convert.ToInt32(txtbParkingS.Text);
                            tSaleParking = uDB.SearchContractParking(1, "Clients.Phone", "", phone, 0);
                            dgvSaleParking.DataSource = tSaleParking;
                        }
                        break;
                    case 3:
                        {
                            string name = txtbParkingS.Text;
                            tSaleParking = uDB.SearchContractParking(0, "RC.Name", name, 0, 0);
                            dgvSaleParking.DataSource = tSaleParking;
                        }
                        break;
                    case 4:
                        {
                            string type = txtbParkingS.Text;
                            tSaleParking = uDB.SearchContractParking(0, "Type.Type", type, 0, 0);
                            dgvSaleParking.DataSource = tSaleParking;
                        }
                        break;
                    case 5:
                        {
                            string date = txtbParkingS.Text;
                            tSaleParking = uDB.SearchContractParking(0, "Contract.Data", date, 0, 0);
                            dgvSaleParking.DataSource = tSaleParking;
                        }
                        break;
                }
            BindingClearParking();
            BindingAddParking();
            uDB.CloseCon();
        }

        private void btnCancelParkingS_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tSaleParking = uDB.GetContractParking();
            BindingClearParking();
            BindingAddParking();
            dgvSaleParking.DataSource = tSaleParking;
            uDB.CloseCon();
            txtbParkingS.Clear();
            cbParkingS.Text = "";
        }
        //--------------------------------------------------
        private void Sale_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            //Apps------------------------------------------
            tSaleApp = uDB.GetContract();
            DataSourceApp();
            dgvSaleApp.DataSource = tSaleApp;

            BindingAddApp();
            //----------------------------------------------

            //ComArea---------------------------------------
            tSaleCom = uDB.GetContractCom();
            DataSourceCom();
            dgvSaleCom.DataSource = tSaleCom;

            BindingAddCom();
            //----------------------------------------------

            //Footer----------------------------------------
            tSaleFooter = uDB.GetContractFooter();
            DataSourceFooter();
            dgvSaleFooter.DataSource = tSaleFooter;

            BindingAddFooter();
            //----------------------------------------------

            //Parking---------------------------------------
            tSaleParking = uDB.GetContractParking();
            DataSourceParking();
            dgvSaleParking.DataSource = tSaleParking;
            BindingAddParking();
            //----------------------------------------------
            uDB.CloseCon();
        }

        private void rbAddApp_CheckedChanged(object sender, EventArgs e)
        {
            gbAppAdd.Visible = true;
            gbComArea.Visible = false;
            gbFooter.Visible = false;
            gbParking.Visible = false;
            //----------------------------
            uDB.OpenConnection();
            tAppClient = uDB.GetTable("Clients");
            cbAddAppClient.DataSource = tAppClient;
            cbAddAppClient.DisplayMember = "Name";
            txtAppClientID.DataBindings.Clear();
            txtAppClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppClient, "ID", true));

            tAppRC = uDB.GetTable("RC");
            cbAddAppRC.DataSource = tAppRC;
            cbAddAppRC.DisplayMember = "Name";
            txtTerm.DataBindings.Clear();
            txtTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppRC, "PeriodsLeft", true));
            txtAppRCID.DataBindings.Clear();
            txtAppRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppRC, "ID", true));
            int rcID = Convert.ToInt32(txtAppRCID.Text);

            tAppType = uDB.GetTypeToApp(rcID, "App");
            cbAddAppType.DataSource = tAppType;
            cbAddAppType.DisplayMember = "Type";
            txtAppTypeID.DataBindings.Clear();
            txtAppTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "ID", true));
            txtAppPrice.DataBindings.Clear();
            txtAppPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "TotalPrice", true));
            int typeID = Convert.ToInt32(txtAppTypeID.Text);

            tAppApp = uDB.SearchApps(false, 5, "Type_ID", "", typeID, 0, 2);
            cbAddAppAppNum.DataSource = tAppApp;
            cbAddAppAppNum.DisplayMember = "AppNum";
            txtAppID.DataBindings.Clear();
            txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "ID", true));
            uDB.CloseCon();
        }

        private void rbAddCom_CheckedChanged(object sender, EventArgs e)
        {
            gbAppAdd.Visible = false;
            gbComArea.Visible = true;
            gbFooter.Visible = false;
            gbParking.Visible = false;
            //----------------------------
            uDB.OpenConnection();
            tAppClient = uDB.GetTable("Clients");
            cbAddComClient.DataSource = tAppClient;
            cbAddComClient.DisplayMember = "Name";
            txtComClientID.DataBindings.Clear();
            txtComClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppClient, "ID", true));

            tAppRC = uDB.GetTable("RC");
            cbAddComRC.DataSource = tAppRC;
            cbAddComRC.DisplayMember = "Name";
            txtComRCID.DataBindings.Clear();
            txtTerm.DataBindings.Clear();
            txtTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppRC, "PeriodsLeft", true));
            txtComRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppRC, "ID", true));
            int rcID = Convert.ToInt32(txtComRCID.Text);

            tAppType = uDB.GetTypeToApp(rcID, "ComArea");
            cbAddComType.DataSource = tAppType;
            cbAddComType.DisplayMember = "Type";
            txtComTypeID.DataBindings.Clear();
            txtComTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "ID", true));
            txtComPrice.DataBindings.Clear();
            txtComPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "TotalPrice", true));
            int typeID = Convert.ToInt32(txtComTypeID.Text);

            tAppApp = uDB.SearchSold("ComArea", false, typeID);
            cbAddComNum.DataSource = tAppApp;
            cbAddComNum.DisplayMember = "IDd";
            txtComID.DataBindings.Clear();
            txtComID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));
            uDB.CloseCon();
        }

        private void rbAddFooter_CheckedChanged(object sender, EventArgs e)
        {
            gbAppAdd.Visible = false;
            gbComArea.Visible = false;
            gbFooter.Visible = true;
            gbParking.Visible = false;
            //----------------------------
            uDB.OpenConnection();
            tAppClient = uDB.GetTable("Clients");
            cbAddFooterClient.DataSource = tAppClient;
            cbAddFooterClient.DisplayMember = "Name";
            txtFooterClientID.DataBindings.Clear();
            txtFooterClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppClient, "ID", true));

            tAppRC = uDB.GetTable("RC");
            cbAddFooterRC.DataSource = tAppRC;
            cbAddFooterRC.DisplayMember = "Name";
            txtTerm.DataBindings.Clear();
            txtTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppRC, "PeriodsLeft", true));
            txtFooterRCID.DataBindings.Clear();
            txtFooterRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppRC, "ID", true));
            int rcID = Convert.ToInt32(txtFooterRCID.Text);

            tAppType = uDB.GetTypeToApp(rcID, "Footer");
            cbAddFooterType.DataSource = tAppType;
            cbAddFooterType.DisplayMember = "Type";
            txtFooterTypeID.DataBindings.Clear();
            txtFooterTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "ID", true));
            txtFooterPrice.DataBindings.Clear();
            txtFooterPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "TotalPrice", true));
            int typeID = Convert.ToInt32(txtFooterTypeID.Text);

            tAppApp = uDB.SearchSold("Footer", false, typeID);
            cbAddFooterNum.DataSource = tAppApp;
            cbAddFooterNum.DisplayMember = "IDd";
            txtFooterID.DataBindings.Clear();
            txtFooterID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));

            uDB.CloseCon();
        }

        private void rbAddParking_CheckedChanged(object sender, EventArgs e)
        {
            gbAppAdd.Visible = false;
            gbComArea.Visible = false;
            gbFooter.Visible = false;
            gbParking.Visible = true;
            //----------------------------
            uDB.OpenConnection();
            tAppClient = uDB.GetTable("Clients");
            cbAddParkingClient.DataSource = tAppClient;
            cbAddParkingClient.DisplayMember = "Name";
            txtParkingClientID.DataBindings.Clear();
            txtParkingClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppClient, "ID", true));

            tAppRC = uDB.GetTable("RC");
            cbAddParkingRC.DataSource = tAppRC;
            cbAddParkingRC.DisplayMember = "Name";
            txtTerm.DataBindings.Clear();
            txtTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppRC, "PeriodsLeft", true));
            txtParkingRCID.DataBindings.Clear();
            txtParkingRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppRC, "ID", true));
            int rcID = Convert.ToInt32(txtParkingRCID.Text);

            tAppType = uDB.GetTypeToApp(rcID, "Parking");
            cbAddParkingType.DataSource = tAppType;
            cbAddParkingType.DisplayMember = "Type";
            txtParkingTypeID.DataBindings.Clear();
            txtParkingTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "ID", true));
            txtParkingPrice.DataBindings.Clear();
            txtParkingPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "TotalPrice", true));
            int typeID = Convert.ToInt32(txtParkingTypeID.Text);

            tAppApp = uDB.SearchSold("Parking", false, typeID);
            cbAddParkingNum.DataSource = tAppApp;
            cbAddParkingNum.DisplayMember = "IDd";
            txtParkingID.DataBindings.Clear();
            txtParkingID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));

            uDB.CloseCon();
        }

        private void btnAddAppOKRC_Click(object sender, EventArgs e)
        {
            int rcID = Convert.ToInt32(txtAppRCID.Text);
            uDB.OpenConnection();
            tAppType = uDB.GetTypeToApp(rcID, "App");
            cbAddAppType.DataSource = tAppType;
            cbAddAppType.DisplayMember = "Type";
            txtAppTypeID.DataBindings.Clear();
            txtAppTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "ID", true));
            txtAppPrice.DataBindings.Clear();
            txtAppPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "TotalPrice", true));
            int typeID = Convert.ToInt32(txtAppTypeID.Text);
            tAppApp = uDB.SearchApps(false, 5, "Type_ID", "", typeID, 0, 2);
            cbAddAppAppNum.DataSource = tAppApp;
            cbAddAppAppNum.DisplayMember = "AppNum";
            txtAppID.DataBindings.Clear();
            txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "ID", true));
            uDB.CloseCon();
        }

        private void btnAddAppOKType_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int typeID = Convert.ToInt32(txtAppTypeID.Text);
            tAppApp = uDB.SearchApps(false, 5, "Type_ID", "", typeID, 0, 2);
            cbAddAppAppNum.DataSource = tAppApp;
            cbAddAppAppNum.DisplayMember = "AppNum";
            txtAppID.DataBindings.Clear();
            txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "ID", true));
            uDB.CloseCon();
        }

        private void btnAddComOKRC_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int rcID = Convert.ToInt32(txtComRCID.Text);

            tAppType = uDB.GetTypeToApp(rcID, "ComArea");
            cbAddComType.DataSource = tAppType;
            cbAddComType.DisplayMember = "Type";
            txtComTypeID.DataBindings.Clear();
            txtComTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "ID", true));
            txtComPrice.DataBindings.Clear();
            txtComPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "TotalPrice", true));
            int typeID = Convert.ToInt32(txtComTypeID.Text);

            tAppApp = uDB.SearchSold("ComArea", false, typeID);
            cbAddComNum.DataSource = tAppApp;
            cbAddComNum.DisplayMember = "IDd";
            txtComID.DataBindings.Clear();
            txtComID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));
            uDB.CloseCon();
        }

        private void btnAddComOKType_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int typeID = Convert.ToInt32(txtComTypeID.Text);

            tAppApp = uDB.SearchSold("ComArea", false, typeID);
            cbAddComNum.DataSource = tAppApp;
            cbAddComNum.DisplayMember = "IDd";
            txtComID.DataBindings.Clear();
            txtComID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));
            uDB.CloseCon();
        }

        private void btnAddFooterRCID_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int rcID = Convert.ToInt32(txtFooterRCID.Text);

            tAppType = uDB.GetTypeToApp(rcID, "Footer");
            cbAddFooterType.DataSource = tAppType;
            cbAddFooterType.DisplayMember = "Type";
            txtFooterTypeID.DataBindings.Clear();
            txtFooterTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "ID", true));
            txtFooterPrice.DataBindings.Clear();
            txtFooterPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "TotalPrice", true));
            int typeID = Convert.ToInt32(txtFooterTypeID.Text);

            tAppApp = uDB.SearchSold("Footer", false, typeID);
            cbAddFooterNum.DataSource = tAppApp;
            cbAddFooterNum.DisplayMember = "IDd";
            txtFooterID.DataBindings.Clear();
            txtFooterID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));

            uDB.CloseCon();
        }

        private void btnAddFooterTypeID_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int typeID = Convert.ToInt32(txtFooterTypeID.Text);

            tAppApp = uDB.SearchSold("Footer", false, typeID);
            cbAddFooterNum.DataSource = tAppApp;
            cbAddFooterNum.DisplayMember = "IDd";
            txtFooterID.DataBindings.Clear();
            txtFooterID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));

            uDB.CloseCon();
        }

        private void btnAddParkingRCID_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int rcID = Convert.ToInt32(txtParkingRCID.Text);

            tAppType = uDB.GetTypeToApp(rcID, "Parking");
            cbAddParkingType.DataSource = tAppType;
            cbAddParkingType.DisplayMember = "Type";
            txtParkingTypeID.DataBindings.Clear();
            txtParkingTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "ID", true));
            txtParkingPrice.DataBindings.Clear();
            txtParkingPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppType, "TotalPrice", true));
            int typeID = Convert.ToInt32(txtParkingTypeID.Text);

            tAppApp = uDB.SearchSold("Parking", false, typeID);
            cbAddParkingNum.DataSource = tAppApp;
            cbAddParkingNum.DisplayMember = "IDd";
            txtParkingID.DataBindings.Clear();
            txtParkingID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));

            uDB.CloseCon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int typeID = Convert.ToInt32(txtParkingTypeID.Text);

            tAppApp = uDB.SearchSold("Parking", false, typeID);
            cbAddParkingNum.DataSource = tAppApp;
            cbAddParkingNum.DisplayMember = "IDd";
            txtParkingID.DataBindings.Clear();
            txtParkingID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));

            uDB.CloseCon();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            term = Convert.ToInt32(txtTerm.Text);
            if (rbAddApp.Checked==true)
            {
                myContract.ClientID = Convert.ToInt32(txtAppClientID.Text);
                myContract.AppID = Convert.ToInt32(txtAppID.Text);
                myContract.Date = DateTime.Today.ToString("d");
                myContract.TotalPay = Convert.ToDouble(txtAppPrice.Text);
                myContract.Term = term;
                myContract.PayPerMonth = Convert.ToDouble(txtAppPrice.Text) / term;
                uDB.InsertContractApp(myContract);

                int typeID = Convert.ToInt32(txtAppTypeID.Text);
                tAppApp = uDB.SearchApps(false, 5, "Type_ID", "", typeID, 0, 2);
                cbAddAppAppNum.DataSource = tAppApp;
                cbAddAppAppNum.DisplayMember = "AppNum";
                txtAppID.DataBindings.Clear();
                txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "ID", true));

                tSaleApp = uDB.GetContract();
                dgvSaleApp.DataSource = tSaleApp;

                BindingClearApp();
                BindingAddApp();
            }
            if (rbAddCom.Checked == true)
            {
                myContract.ClientID = Convert.ToInt32(txtComClientID.Text);
                myContract.ComArea_ID = Convert.ToInt32(txtComID.Text);
                myContract.Date = DateTime.Today.ToString("d");
                myContract.TotalPay = Convert.ToDouble(txtComPrice.Text);
                myContract.Term = term;
                myContract.PayPerMonth = Convert.ToDouble(txtComPrice.Text) / term;
                uDB.InsertContractCom(myContract);

                int typeID = Convert.ToInt32(txtComTypeID.Text);

                tAppApp = uDB.SearchSold("ComArea", false, typeID);
                cbAddComNum.DataSource = tAppApp;
                cbAddComNum.DisplayMember = "IDd";
                txtComID.DataBindings.Clear();
                txtComID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));

                tSaleCom = uDB.GetContractCom();
                dgvSaleCom.DataSource = tSaleCom;

                BindingClearCom();
                BindingAddCom();
            }
            if (rbAddFooter.Checked == true)
            {
                myContract.ClientID = Convert.ToInt32(txtFooterClientID.Text);
                myContract.Footer_ID = Convert.ToInt32(txtFooterID.Text);
                myContract.Date = DateTime.Today.ToString("d");
                myContract.TotalPay = Convert.ToDouble(txtFooterPrice.Text);
                myContract.Term = term;
                myContract.PayPerMonth = Convert.ToDouble(txtFooterPrice.Text) / term;
                uDB.InsertContractFooter(myContract);

                int typeID = Convert.ToInt32(txtFooterTypeID.Text);

                tAppApp = uDB.SearchSold("Footer", false, typeID);
                cbAddFooterNum.DataSource = tAppApp;
                cbAddFooterNum.DisplayMember = "IDd";
                txtFooterID.DataBindings.Clear();
                txtFooterID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));

                tSaleFooter = uDB.GetContractFooter();
                dgvSaleFooter.DataSource = tSaleFooter;

                BindingClearFooter();
                BindingAddFooter();
            }
            if (rbAddParking.Checked == true)
            {
                myContract.ClientID = Convert.ToInt32(txtParkingClientID.Text);
                myContract.Parking_ID = Convert.ToInt32(txtParkingID.Text);
                myContract.Date = DateTime.Today.ToString("d");
                myContract.TotalPay = Convert.ToDouble(txtParkingPrice.Text);
                myContract.Term = term;
                myContract.PayPerMonth = Convert.ToDouble(txtParkingPrice.Text) / term;
                uDB.InsertContractParking(myContract);

                int typeID = Convert.ToInt32(txtParkingTypeID.Text);

                tAppApp = uDB.SearchSold("Parking", false, typeID);
                cbAddParkingNum.DataSource = tAppApp;
                cbAddParkingNum.DisplayMember = "IDd";
                txtParkingID.DataBindings.Clear();
                txtParkingID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tAppApp, "IDd", true));

                tSaleParking = uDB.GetContractParking();
                dgvSaleParking.DataSource = tSaleParking;

                BindingClearParking();
                BindingAddParking();
            }
            uDB.CloseCon();
        }


        //DELETE--------------------------------------------------
        private void rbDelApp_CheckedChanged(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tClientDel = uDB.GetTable("Clients");
            cbDelClient.DataSource = tClientDel;
            cbDelClient.DisplayMember = "Name";
            txtDelClientID.DataBindings.Clear();
            txtDelClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tClientDel, "ID", true));

            int clID = Convert.ToInt32(txtDelClientID.Text);
            tContractNum = uDB.SearchContract(1, "Contract.ClientID", "", clID, 0);
            cbDelID.DataSource = tContractNum;
            cbDelID.DisplayMember = "ID";
            uDB.CloseCon();
            gbDel.Visible = true;
        }

        private void rbDelCom_CheckedChanged(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tClientDel = uDB.GetTable("Clients");
            cbDelClient.DataSource = tClientDel;
            cbDelClient.DisplayMember = "Name";
            txtDelClientID.DataBindings.Clear();
            txtDelClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tClientDel, "ID", true));

            int clID = Convert.ToInt32(txtDelClientID.Text);
            tContractNum = uDB.SearchContractCom(1, "Contract.ClientID", "", clID, 0);
            cbDelID.DataSource = tContractNum;
            cbDelID.DisplayMember = "ID";
            uDB.CloseCon();

            gbDel.Visible = true;
        }

        private void rbDelFooter_CheckedChanged(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tClientDel = uDB.GetTable("Clients");
            cbDelClient.DataSource = tClientDel;
            cbDelClient.DisplayMember = "Name";
            txtDelClientID.DataBindings.Clear();
            txtDelClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tClientDel, "ID", true));

            int clID = Convert.ToInt32(txtDelClientID.Text);
            tContractNum = uDB.SearchContractFooter(1, "Contract.ClientID", "", clID, 0);
            cbDelID.DataSource = tContractNum;
            cbDelID.DisplayMember = "ID";
            uDB.CloseCon();

            gbDel.Visible = true;
        }

        private void rbDelParking_CheckedChanged(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tClientDel = uDB.GetTable("Clients");
            cbDelClient.DataSource = tClientDel;
            cbDelClient.DisplayMember = "Name";
            txtDelClientID.DataBindings.Clear();
            txtDelClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tClientDel, "ID", true));

            int clID = Convert.ToInt32(txtDelClientID.Text);
            tContractNum = uDB.SearchContractParking(1, "Contract.ClientID", "", clID, 0);
            cbDelID.DataSource = tContractNum;
            cbDelID.DisplayMember = "ID";
            uDB.CloseCon();

            gbDel.Visible = true;
        }

        private void btnClientOK_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            int clID = Convert.ToInt32(txtDelClientID.Text);
            if (rbDelApp.Checked==true)
            {
                tContractNum = uDB.SearchContract(1, "Contract.ClientID", "", clID, 0);
            }
            if (rbDelCom.Checked == true)
            {
                tContractNum = uDB.SearchContractCom(1, "Contract.ClientID", "", clID, 0);
            }
            if (rbDelFooter.Checked == true)
            {
                tContractNum = uDB.SearchContractFooter(1, "Contract.ClientID", "", clID, 0);
            }
            if (rbDelParking.Checked ==true)
            {
                tContractNum = uDB.SearchContractParking(1, "Contract.ClientID", "", clID, 0);
            }
            cbDelID.DataSource = tContractNum;
            cbDelID.DisplayMember = "ID";
            uDB.CloseCon();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (cbDelID.Text != "")
            {
                int ID = Convert.ToInt32(cbDelID.Text);
                uDB.DeleteByIntNum("Contract", "ID", ID);

                //Apps------------------------------------------
                tSaleApp = uDB.GetContract();
                dgvSaleApp.DataSource = tSaleApp;

                BindingClearApp();
                BindingAddApp();
                //----------------------------------------------

                //ComArea---------------------------------------
                tSaleCom = uDB.GetContractCom();
                dgvSaleCom.DataSource = tSaleCom;

                BindingClearCom();
                BindingAddCom();
                //----------------------------------------------

                //Footer----------------------------------------
                tSaleFooter = uDB.GetContractFooter();
                dgvSaleFooter.DataSource = tSaleFooter;

                BindingClearFooter();
                BindingAddFooter();
                //----------------------------------------------

                //Parking---------------------------------------
                tSaleParking = uDB.GetContractParking();
                dgvSaleParking.DataSource = tSaleParking;

                BindingClearParking();
                BindingAddParking();
            }
            uDB.CloseCon();
        }


        //--------------------------------------------------------
    }
}
