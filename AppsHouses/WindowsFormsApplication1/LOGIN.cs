using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        fMain fm = new fMain();
        UseDB uDB = new UseDB();
        DataTable login = new DataTable();
        private void Bclient_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            login = uDB.GetLogin(textBox1.Text, textBox2.Text);
            if (login.Rows[0][0].ToString() == "1")
            {
                for (int i = 0; i < 30; i++)
                {
                    Thread.Sleep(30);
                }
                fm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorect login or password");
            uDB.CloseCon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                uDB.OpenConnection();
                login = uDB.GetLogin(textBox1.Text, textBox2.Text);
                if (login.Rows[0][0].ToString() == "1")
                {
                    for (int i = 0; i < 30; i++)
                    {
                        Thread.Sleep(30);
                    }
                    fm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Incorect login or password");
                uDB.CloseCon();
            }
        }
    }
}
