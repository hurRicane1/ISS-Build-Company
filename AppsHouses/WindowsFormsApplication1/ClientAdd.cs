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
    public partial class ClientAdd : Form
    {
        public ClientAdd()
        {
            InitializeComponent();
        }
        
        private void txtbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Client myClient = new Client();
            UseDB uDB = new UseDB();

            myClient.Name = txtbName.Text;
            myClient.Phone = Convert.ToInt32(txtbPhone.Text);
            myClient.PassportSer = txtbPassSer.Text;
            myClient.PassportNum = Convert.ToInt32(txtbPassNum.Text);
            uDB.OpenConnection();
            uDB.InsertClient(myClient);
            uDB.CloseCon();
            this.Hide();
        }

        private void txtbPassNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
