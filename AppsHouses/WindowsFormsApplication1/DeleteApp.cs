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
    public partial class DeleteApp : Form
    {
        public DeleteApp()
        {
            InitializeComponent();
        }
        UseDB uDB = new UseDB();
        DataTable tRC = new DataTable();
        DataTable tRC2 = new DataTable();
        DataTable tType = new DataTable();
        DataTable tApp = new DataTable();

        int rcID = 0, typeID = 0, appID = 0;
        int index;

        private void GetAllData()
        {
            txtRCID.DataBindings.Clear();
            txtTypeID.DataBindings.Clear();
            txtAppID.DataBindings.Clear();
            tRC = uDB.GetTable("RC");
            cbRC.DataSource = tRC;
            cbRC.DisplayMember = "Name";
            txtRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
            tType = uDB.GetTypeToApp(Convert.ToInt32(txtRCID.Text), "App");
            cbAppType.DataSource = tType;
            cbAppType.DisplayMember = "Type";
            txtTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
            typeID = Convert.ToInt32(txtTypeID.Text);
            tApp = uDB.SearchByINTNum("Apps", "Type_ID", typeID);
            cbAppNum.DataSource = tApp;
            cbAppNum.DisplayMember = "AppNum";
            txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApp, "ID", true));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (cbAppNum.Text != "")
            {
                if (appID != 0 && typeID != 0 && rcID != 0)
                {
                    uDB.DeleteByIntNum("Apps", "ID", appID);
                }
            }
            uDB.CloseCon();
        }
        private void txtFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOKRC_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            txtTypeID.DataBindings.Clear();
            tType = uDB.GetTypeToApp(Convert.ToInt32(txtRCID.Text), "App");
            cbAppType.DataSource = tType;
            cbAppType.DisplayMember = "Type";
            rcID = Convert.ToInt32(txtRCID.Text);
            txtTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
            uDB.CloseCon();
        }

        private void btnOKAppNum_Click(object sender, EventArgs e)
        {
            appID = Convert.ToInt32(txtAppID.Text);
        }

        private void cbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            index = cbCriterio.SelectedIndex;
            switch (index)
            {
                case 0:
                    {
                        cbValue.Visible = true;
                        cbValue2.Visible = false;
                        cbValue3.Visible = false;
                        btnOK.Visible = false;
                        txtFloor.Visible = false;
                        rbForSell.Visible = false;
                        rbSold.Visible = false;
                        txtValue.DataBindings.Clear();
                        tRC = uDB.GetTable("RC");
                        cbValue.DataSource = tRC;
                        cbValue.DisplayMember = "Name";
                        txtValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
                    }
                    break;
                case 1:
                    {
                        cbValue.Visible = false;
                        cbValue2.Visible = true;
                        cbValue3.Visible = true;
                        btnOK.Visible = true;
                        txtFloor.Visible = false;
                        rbForSell.Visible = false;
                        rbSold.Visible = false;
                        txtValue.DataBindings.Clear();
                        txtValue2.DataBindings.Clear();
                        tRC2 = uDB.GetTable("RC");
                        cbValue2.DataSource = tRC2;
                        cbValue2.DisplayMember = "Name";
                        txtValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC2, "ID", true));
                        tType = uDB.GetTypeToApp(Convert.ToInt32(txtValue.Text), "App");
                        cbValue3.DataSource = tType;
                        cbValue3.DisplayMember = "Type";
                        txtValue2.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
                    }
                    break;
                case 2:
                    {
                        cbValue.Visible = false;
                        cbValue2.Visible = false;
                        cbValue3.Visible = false;
                        btnOK.Visible = false;
                        txtFloor.Visible = true;
                        rbForSell.Visible = false;
                        rbSold.Visible = false;
                    }
                    break;
                case 3:
                    {
                        
                        cbValue.Visible = false;
                        cbValue2.Visible = false;
                        cbValue3.Visible = false;
                        btnOK.Visible = false;
                        txtFloor.Visible = false;
                        rbForSell.Visible = true;
                        rbSold.Visible = true;
                    }
                    break;
            }
            uDB.CloseCon();
        }

        private void txtbFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            txtValue2.DataBindings.Clear();
            tType = uDB.GetTypeToApp(Convert.ToInt32(txtValue.Text), "App");
            cbValue3.DataSource = tType;
            cbValue3.DisplayMember = "Type";
            txtValue2.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
            uDB.CloseCon();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            switch (index)
            {
                case 0:
                    {
                        int appRcId = Convert.ToInt32(txtValue.Text);
                        uDB.DeleteByIntNum("Apps", "RC_ID",appRcId);
                    }
                    break;
                case 1:
                    {
                        int appTypeID = Convert.ToInt32(txtValue2.Text);
                        uDB.DeleteByIntNum("Apps", "Type_ID", appTypeID);
                    }
                    break;
                case 2:
                    {
                        if (txtFloor.Text != "")
                        {
                            int floor = Convert.ToInt32(txtFloor.Text);
                            uDB.DeleteByIntNum("Apps", "Floor", floor);
                        }
                    }
                    break;
                case 3:
                    {
                        if (rbSold.Checked == true)
                        {
                            uDB.DeleteByBool("Apps", "Sold", true);
                        }
                        else
                            if (rbForSell.Checked == true)
                        {
                            uDB.DeleteByBool("Apps", "Sold", false);
                        }
                    }
                    break;
            }
            uDB.CloseCon();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            uDB.DeleteByIntNum("Apps", "ID", appID);
            GetAllData();
            uDB.CloseCon();
        }

        private void btnOKType_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            txtAppID.DataBindings.Clear();
            typeID = Convert.ToInt32(txtTypeID.Text);
            tApp = uDB.SearchByINTNum("Apps", "Type_ID", typeID);
            cbAppNum.DataSource = tApp;
            cbAppNum.DisplayMember = "AppNum";
            txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tApp, "ID", true));
            uDB.CloseCon();
        }

        private void DeleteApp_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            //TabAdvancedDelete---------------------------------------------------------------------------
            GetAllData();
            uDB.CloseCon();
            //TabMassiveDelete----------------------------------------------------------------------------
            cbCriterio.SelectedIndex = 0;
            
        }
    }
}
