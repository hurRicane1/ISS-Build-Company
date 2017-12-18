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
    public partial class DeleteHouse : Form
    {
        public DeleteHouse()
        {
            InitializeComponent();
        }
        UseDB uDB = new UseDB();
        DataTable tRC = new DataTable();
        private void DeleteHouse_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            GetData();
            BindingAdd();
        }
        private void BindingAdd()
        {
            txtRcID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
        }

        private void BindingClear()
        {
            txtRcID.DataBindings.Clear();
        }
        private void GetData()
        {
            tRC = uDB.GetTable("RC");
            cbRcDel.DataSource = tRC;
            cbRcDel.DisplayMember = "Name";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            uDB.CloseCon();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rcID;
            rcID = Convert.ToInt32(txtRcID.Text);
            uDB.DeleteByIntNum("RC", "ID", rcID);
            BindingClear();
            GetData();
            BindingAdd();
        }
    }
}
