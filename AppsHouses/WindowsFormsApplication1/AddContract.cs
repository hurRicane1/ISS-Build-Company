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
    public partial class AddContract : Form
    {
        public AddContract(int id, string name)
        {
            InitializeComponent();
            txtbName.Text = name;
            txtClientID.Text = Convert.ToString(id);
        }
        int rcId, term;
        UseDB uDB = new UseDB();
        DataTable tRC = new DataTable();
        DataTable tApp = new DataTable();
        DataTable tCom = new DataTable();
        DataTable tFooter = new DataTable();
        DataTable tParking = new DataTable();

        Contract myContract = new Contract();
        private void AddContract_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tRC = uDB.GetTable("RC");
            cbRC.DataSource = tRC;
            cbRC.DisplayMember = "Name";
            txtRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
            txtTerm.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "PeriodsLeft", true));
            uDB.CloseCon();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            rcId = Convert.ToInt32(txtRCID.Text);
            uDB.OpenConnection();
            tApp = uDB.SearchApps(false, 5, "Apps.RC_ID", "", rcId, 0, 2);
            cbAppNum.DataSource = tApp;
            cbAppNum.DisplayMember = "AppNum";
            if (checkbApp.Checked == false) cbAppNum.SelectedIndex = -1;
            txtAppID.DataBindings.Clear();
            txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApp, "ID", true));
            txtAppPrice.DataBindings.Clear();
            txtAppPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApp, "TotalPrice", true));
            //------------------------------------------------------------------------------------
            tCom = uDB.SearchComArea(4, "RC.ID", "", rcId, 0, false, 2);
            cbComNum.DataSource = tCom;
            cbComNum.DisplayMember = "IDd";
            if (checkbComArea.Checked ==false) cbComNum.SelectedIndex = -1;
            txtComPrice.DataBindings.Clear();
            txtComPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tCom, "TotalPrice", true));
            //------------------------------------------------------------------------------------
            tFooter = uDB.SearchFooter(4, "RC.ID", "", rcId, 0, false, 2);
            cbFooterNum.DataSource = tFooter;
            cbFooterNum.DisplayMember = "IDd";
            if (checkbFooter.Checked == false) cbFooterNum.SelectedIndex = -1;
            txtFooterPrice.DataBindings.Clear();
            txtFooterPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tFooter, "TotalPrice", true));
            //------------------------------------------------------------------------------------
            tParking = uDB.SearchParking(4, "RC.ID", "", rcId, 0, false, 2);
            cbParkingNum.DataSource = tParking;
            cbParkingNum.DisplayMember = "IDd";
            if (checkbParking.Checked == false) cbParkingNum.SelectedIndex = -1;
            txtParkingPrice.DataBindings.Clear();
            txtParkingPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tParking, "TotalPrice", true));
            uDB.CloseCon();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkbApp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbApp.Checked == true)
            {
                cbAppNum.Enabled = true;
                rcId = Convert.ToInt32(txtRCID.Text);
                uDB.OpenConnection();
                tApp = uDB.SearchApps(false, 5, "Apps.RC_ID", "", rcId, 0, 2);
                cbAppNum.DataSource = tApp;
                cbAppNum.DisplayMember = "AppNum";
                txtAppID.DataBindings.Clear();
                txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApp, "ID", true));
                txtAppPrice.DataBindings.Clear();
                txtAppPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApp, "TotalPrice", true));
                uDB.CloseCon();
            }
            else
            {
             
                cbAppNum.Enabled = false;
                cbAppNum.SelectedIndex = -1;              
            }
        }

        private void checkbComArea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbComArea.Checked == true)
            {
                cbComNum.Enabled = true;
                rcId = Convert.ToInt32(txtRCID.Text);
                uDB.OpenConnection();
                tCom = uDB.SearchComArea(4, "RC.ID", "", rcId, 0, false, 2);
                cbComNum.DataSource = tCom;
                cbComNum.DisplayMember = "IDd";
                txtComPrice.DataBindings.Clear();
                txtComPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tCom, "TotalPrice", true));
                uDB.CloseCon();
            }
            else
            {
                cbComNum.Enabled = false;
                cbComNum.SelectedIndex = -1;             
            }
        }

        private void checkbFooter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbFooter.Checked == true)
            {
                cbFooterNum.Enabled = true;
                rcId = Convert.ToInt32(txtRCID.Text);
                uDB.OpenConnection();
                tFooter = uDB.SearchFooter(4, "RC.ID", "", rcId, 0, false, 2);
                cbFooterNum.DataSource = tFooter;
                cbFooterNum.DisplayMember = "IDd";
                txtFooterPrice.DataBindings.Clear();
                txtFooterPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tFooter, "TotalPrice", true));
                uDB.CloseCon();
            }
            else
            {
                cbFooterNum.SelectedIndex = -1;
                cbFooterNum.Enabled = false;
              
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            term = Convert.ToInt32(txtTerm.Text);
            if (checkbApp.Checked == true)
            {
                myContract.ClientID = Convert.ToInt32(txtClientID.Text);
                myContract.AppID = Convert.ToInt32(txtAppID.Text);
                myContract.Date = DateTime.Today.ToString("d");
                myContract.TotalPay = Convert.ToDouble(txtAppPrice.Text);
                myContract.Term = term;
                myContract.PayPerMonth = Convert.ToDouble(txtAppPrice.Text) / term;
                uDB.InsertContractApp(myContract);
            }
            if (checkbComArea.Checked == true)
            {
                myContract.ClientID = Convert.ToInt32(txtClientID.Text);
                myContract.ComArea_ID = Convert.ToInt32(cbComNum.Text);
                myContract.Date = DateTime.Today.ToString("d");
                myContract.TotalPay = Convert.ToDouble(txtComPrice.Text);
                myContract.Term = term;
                myContract.PayPerMonth = Convert.ToDouble(txtComPrice.Text) / term;
                uDB.InsertContractCom(myContract);
            }
            if (checkbFooter.Checked == true)
            {
                myContract.ClientID = Convert.ToInt32(txtClientID.Text);
                myContract.Footer_ID = Convert.ToInt32(cbFooterNum.Text);
                myContract.Date = DateTime.Today.ToString("d");
                myContract.TotalPay = Convert.ToDouble(txtFooterPrice.Text);
                myContract.Term = term;
                myContract.PayPerMonth = Convert.ToDouble(txtFooterPrice.Text) / term;
                uDB.InsertContractFooter(myContract);
            }
            if (checkbParking.Checked == true)
            {
                myContract.ClientID = Convert.ToInt32(txtClientID.Text);
                myContract.Parking_ID = Convert.ToInt32(cbParkingNum.Text);
                myContract.Date = DateTime.Today.ToString("d");
                myContract.TotalPay = Convert.ToDouble(txtParkingPrice.Text);
                myContract.Term = term;
                myContract.PayPerMonth = Convert.ToDouble(txtParkingPrice.Text) / term;
                uDB.InsertContractParking(myContract);
            }
            uDB.CloseCon();
        }

        private void checkbParking_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbParking.Checked == true)
            {
                cbParkingNum.Enabled = true;
                rcId = Convert.ToInt32(txtRCID.Text);
                uDB.OpenConnection();
                tParking = uDB.SearchParking(4, "RC.ID", "", rcId, 0, false, 2);
                cbParkingNum.DataSource = tParking;
                cbParkingNum.DisplayMember = "IDd";
                txtParkingPrice.DataBindings.Clear();
                txtParkingPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tParking, "TotalPrice", true));
                uDB.CloseCon();
            }
            else
            {
                cbParkingNum.SelectedIndex = -1;
                cbParkingNum.Enabled = false;
            }
        }
    }
}
