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
    public partial class AddApp : Form
    {
        public AddApp()
        {
            InitializeComponent();
        }
        UseDB uDB = new UseDB();
        DataTable tRC = new DataTable();
        DataTable tType = new DataTable();
        App myApp = new App();

        int rcID, typeID;

        private void txtbFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void AddApp_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            tRC = uDB.GetTable("RC");
            cbRC.DataSource = tRC;
            cbRC.DisplayMember = "Name";
            txtRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
            tType = uDB.GetTypeToApp(Convert.ToInt32(txtRCID.Text), "App");
            cbAppType.DataSource = tType;
            cbAppType.DisplayMember = "Type";
            txtTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbFloor.Text != "" && txtbAppNum.Text != "" && txtTypeID.Text !="")
            {
                myApp.RC_ID = rcID;
                myApp.Type_ID = typeID;
                myApp.Floor = Convert.ToInt32(txtbFloor.Text);
                myApp.AppNum = Convert.ToInt32(txtbAppNum.Text);
                uDB.InsertApp(myApp);
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            uDB.CloseCon();
        }

        private void btnOKType_Click(object sender, EventArgs e)
        {
            typeID = Convert.ToInt32(txtTypeID.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTypeID.DataBindings.Clear();
            tType = uDB.GetTypeToApp(Convert.ToInt32(txtRCID.Text), "App");
            cbAppType.DataSource = tType;
            cbAppType.DisplayMember = "Type";
            rcID = Convert.ToInt32(txtRCID.Text);
            txtTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType, "ID", true));
        }
    }
}
