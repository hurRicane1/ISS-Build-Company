using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class AddHouse : Form
    {
        public AddHouse()
        {
            InitializeComponent();
        }

        public About About
        {
            get => default(About);
            set
            {
            }
        }

        RC myRC = new RC();
        UseDB uDB = new UseDB();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (txtbName.Text != "" && txtAddress.Text != "" && txtbBldgsAmm.Text != "" && pbAddImage.Image != null)
            {
                if (rtxtbCross.Text != "" && rtxtWallMat.Text != "" && rtxtInfo.Text != "")
                {
                    myRC.Name = txtbName.Text;
                    myRC.Address = txtAddress.Text;
                    myRC.Bldgs_am = Convert.ToInt32(txtbBldgsAmm.Text);
                    myRC.Cross = rtxtbCross.Text;
                    myRC.WallMat = rtxtWallMat.Text;
                    myRC.Info = rtxtInfo.Text;
                    myRC.Picture = pbAddImage.Image;
                    uDB.InsertRC(myRC);
                }
            }
            uDB.CloseCon();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "jpg|*.jpg|png|*.png|bmp|*.bmp";
            if (ofdImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbAddImage.Image = Image.FromFile(ofdImage.FileName);
            }
        }
    }
}
