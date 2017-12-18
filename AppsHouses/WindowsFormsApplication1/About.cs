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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        UseDB uDB = new UseDB();
        DataTable tConfig = new DataTable();
        RC myConfig = new RC();
        DataTable tType = new DataTable();
        Type myType = new Type();

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Convert.ToDateTime(txtbWatchDateFinish.Text);
            upDown.Value = Convert.ToInt32(txtbWatchPeriodsLeft.Text);
            numericUpDown1.Value = Convert.ToInt32(txtbWatchFirstPay.Text);
            txtbEditAppPrice.Text = txtbWatchAppPrice.Text;
            txtbEditComPrice.Text = txtbWatchComPrice.Text;
            txtbEditFooterPrice.Text = txtbWatchFooterPrice.Text;
            txtbEditParkingPrice.Text = txtbWatchParkingPrice.Text;
            cbRC.Enabled = false;
            btnEdit.Enabled = false;
            btnEditImage.Enabled = false;
            txtbWatchAppPrice.Enabled = false;
            txtbWatchComPrice.Enabled = false;
            txtbWatchDateFinish.Enabled = false;
            txtbWatchFirstPay.Enabled = false;
            txtbWatchFooterPrice.Enabled = false;
            txtbWatchParkingPrice.Enabled = false;
            txtbWatchPeriodsLeft.Enabled = false;
            gpEdit.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            myConfig.ID = Convert.ToInt32(txtRCID.Text);
            myConfig.DataFinish = dateTimePicker1.Value.Date.ToString("d");
            myConfig.PeriodsLeft = Convert.ToInt32(upDown.Value);
            myConfig.FirstPay = Convert.ToInt32(numericUpDown1.Value);
            myConfig.PriceAppM2 = Convert.ToDouble(txtbEditAppPrice.Text);
            myConfig.PriceComAreaM2 = Convert.ToDouble(txtbEditComPrice.Text);
            myConfig.PriceFooterM2 = Convert.ToDouble(txtbEditFooterPrice.Text);
            myConfig.PriceParking = Convert.ToDouble(txtbEditParkingPrice.Text);
            uDB.UpdateConfig(myConfig);
            uDB.CloseCon();
            ClearBinding();
            update();          
            gpEdit.Visible = false;
            cbRC.Enabled = true;
            btnEdit.Enabled = true;
            btnEditImage.Enabled = true;
            txtbWatchAppPrice.Enabled = true;
            txtbWatchComPrice.Enabled = true;
            txtbWatchDateFinish.Enabled = true;
            txtbWatchFirstPay.Enabled = true;
            txtbWatchFooterPrice.Enabled = true;
            txtbWatchParkingPrice.Enabled = true;
            txtbWatchPeriodsLeft.Enabled = true;
        }
        private void DataBinding()
        {
            txtbWatchDateFinish.DataBindings.Add(new System.Windows.Forms.Binding("Text", tConfig, "DataFinish", true));
            txtbWatchPeriodsLeft.DataBindings.Add(new System.Windows.Forms.Binding("Text", tConfig, "PeriodsLeft", true));
            txtbWatchFirstPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", tConfig, "FirstPay", true));
            txtbWatchAppPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tConfig, "PriceAppM2", true));
            txtbWatchComPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tConfig, "PriceComAreaM2", true));
            txtbWatchFooterPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tConfig, "PriceFooterM2", true));
            txtbWatchParkingPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tConfig, "PriceParking", true));

        }
        private void ClearBinding()
        {
            txtbWatchDateFinish.DataBindings.Clear();
            txtbWatchPeriodsLeft.DataBindings.Clear();
            txtbWatchFirstPay.DataBindings.Clear();
            txtbWatchAppPrice.DataBindings.Clear();
            txtbWatchComPrice.DataBindings.Clear();
            txtbWatchFooterPrice.DataBindings.Clear();
            txtbWatchParkingPrice.DataBindings.Clear();
        }

        private void update()
        {
            uDB.OpenConnection();
            tConfig = uDB.GetTable("RC");
            cbRC.DataSource = tConfig;
            cbRC.DisplayMember = "Name";
            txtRCID.DataBindings.Clear();
            txtRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tConfig, "ID", true));
            DataBinding();
            uDB.CloseCon();
        }
        private void About_Load(object sender, EventArgs e)
        {
            update();
            uDB.OpenConnection();
            tType = uDB.GetTable("Type");
            cbType.DataSource = tType;
            cbType.DisplayMember = "ID";
            uDB.CloseCon();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbRC.Enabled = true;
            btnEdit.Enabled = true;
            btnEditImage.Enabled = true;
            gpEdit.Visible = false;
            txtbWatchAppPrice.Enabled = true;
            txtbWatchComPrice.Enabled = true;
            txtbWatchDateFinish.Enabled = true;
            txtbWatchFirstPay.Enabled = true;
            txtbWatchFooterPrice.Enabled = true;
            txtbWatchParkingPrice.Enabled = true;
            txtbWatchPeriodsLeft.Enabled = true;
        }

        private void txtbEditFirstPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtbEditAppPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtbEditComPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtbEditFooterPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtbEditParkingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtRCID.Text);
            myConfig.ID = id;
            myConfig.Picture = pbEditImage.Image;
            uDB.OpenConnection();
            if(pbEditImage.Image!=null)
            uDB.UPDATEImage(myConfig);
            uDB.CloseCon();
            btnEdit.Enabled = true;
            btnEditImage.Enabled = true;
            cbRC.Enabled = true;
            gpEditImage.Visible = false;
            
        }

        private void btnEditImage_Click(object sender, EventArgs e)
        {
            
            btnEdit.Enabled = false;
            btnEditImage.Enabled = false;
            gpEditImage.Visible = true;
            cbRC.Enabled = false;
        }

        private void btnCancelImage_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnEditImage.Enabled = true;
            cbRC.Enabled = true;
            gpEditImage.Visible = false;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "jpg|*.jpg|png|*.png|bmp|*.bmp";
            if (ofdImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbEditImage.Image = Image.FromFile(ofdImage.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "jpg|*.jpg|png|*.png|bmp|*.bmp";
            if (ofdImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbTypeImage.Image = Image.FromFile(ofdImage.FileName);
            }
        }

        private void btnDoneImageE_Click(object sender, EventArgs e)
        {
            myType.ID = Convert.ToInt32(cbType.Text);
            myType.Picture = pbTypeImage.Image;
            uDB.OpenConnection();
            if (pbTypeImage.Image != null)
                uDB.UPDATEImageType(myType);
            uDB.CloseCon();
        }
    }
}
