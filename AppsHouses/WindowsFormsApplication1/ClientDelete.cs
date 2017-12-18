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
    public partial class ClientDelete : Form
    {
        public ClientDelete()
        {
            InitializeComponent();
        }
        UseDB uDB = new UseDB();
        int index;
        string tname = "Clients";
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbClientDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cbClientDel.SelectedIndex;
            switch (index)
            {
                case 0:
                    txtbClientDel2.Visible = false;
                    txtbClientDel2.Enabled = false;
                    break;
                case 1:
                    txtbClientDel2.Visible = false;
                    txtbClientDel2.Enabled = false;
                    break;
                case 2:
                    txtbClientDel2.Visible = false;
                    txtbClientDel2.Enabled = false;
                    break;
                case 3:
                    txtbClientDel2.Visible = true;
                    txtbClientDel2.Enabled = true;
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            switch (index)
            {
                case 0:
                    if (txtbClientDel.Text != "")
                    {
                        int id = Convert.ToInt32(txtbClientDel.Text);
                        uDB.DeleteByIntNum(tname, "ID", id);
                    }
                    break;
                case 1:
                    if (txtbClientDel.Text != "")
                    {
                        string name = txtbClientDel.Text;
                        uDB.DeleteByString(tname, "Name", name);
                    }
                    break;
                case 2:
                    if (txtbClientDel.Text != "")
                    {
                        int phone = Convert.ToInt32(txtbClientDel.Text);
                        uDB.DeleteByIntNum(tname, "Phone", phone);
                    }
                    break;
                case 3:
                    if (txtbClientDel.Text != "")
                    {
                        int num = Convert.ToInt32(txtbClientDel.Text);
                        string ser = txtbClientDel2.Text;
                        uDB.DeleteByPassPort(ser, num);
                    }
                    break;
            }
            uDB.CloseCon();
            txtbClientDel.Text = "";
            cbClientDel.Text = "";
        }
    }
}
