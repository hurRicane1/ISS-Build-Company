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
    public partial class Types : Form
    {
        public Types()
        {
            InitializeComponent();
        }
        UseDB uDB = new UseDB();
        Type myType = new Type();
        DataTable tType = new DataTable();
        DataTable tRC = new DataTable();
        DataTable tRC2 = new DataTable();
        DataTable tType2 = new DataTable();

        DataTable tRCCom = new DataTable();
        DataTable tTypeCom = new DataTable();
        DataTable tTypeCom2 = new DataTable();

        DataTable tRCFooter = new DataTable();
        DataTable tTypeFooter = new DataTable();
        DataTable tTypeFooter2 = new DataTable();

        DataTable tRCparking = new DataTable();
        DataTable tTypeParking = new DataTable();
        DataTable tTypeParking2 = new DataTable();

        

        int DelAppTypeID;
        int DelComTypeID;
        int DelFooterTypeID;
        int DelParkingTypeID;

        //Appartments
        private void DataGridSourceApp()
        {
            dgvAppTypes.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn rcNameTextBoxColumn = new DataGridViewTextBoxColumn();
            rcNameTextBoxColumn.DataPropertyName = "Name";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rcNameTextBoxColumn.DefaultCellStyle = cellStyle1;
            rcNameTextBoxColumn.FillWeight = 150F;
            rcNameTextBoxColumn.HeaderText = "Житловий комплекс";
            rcNameTextBoxColumn.Width = 150;
            rcNameTextBoxColumn.ReadOnly = true;
            //------
            //------Name
            DataGridViewTextBoxColumn typeTextBoxColumn = new DataGridViewTextBoxColumn();
            typeTextBoxColumn.DataPropertyName = "Type";
            typeTextBoxColumn.DefaultCellStyle = cellStyle1;
            typeTextBoxColumn.FillWeight = 100F;
            typeTextBoxColumn.HeaderText = "Тип";
            typeTextBoxColumn.Width = 100;
            typeTextBoxColumn.ReadOnly = true;
            //------
            //------RoomAm
            DataGridViewTextBoxColumn roomAmTextBoxColumn = new DataGridViewTextBoxColumn();
            roomAmTextBoxColumn.DataPropertyName = "RoomAm";
            roomAmTextBoxColumn.DefaultCellStyle = cellStyle1;
            roomAmTextBoxColumn.FillWeight = 100F;
            roomAmTextBoxColumn.HeaderText = "К-сть кімнат";
            roomAmTextBoxColumn.Width = 100;
            roomAmTextBoxColumn.ReadOnly = true;
            //------
            //------LiveArea
            DataGridViewTextBoxColumn liveAreaTextBoxColumn = new DataGridViewTextBoxColumn();
            liveAreaTextBoxColumn.DataPropertyName = "LiveArea";
            liveAreaTextBoxColumn.DefaultCellStyle = cellStyle1;
            liveAreaTextBoxColumn.FillWeight = 100F;
            liveAreaTextBoxColumn.HeaderText = "Житлова площа";
            liveAreaTextBoxColumn.Width = 100;
            liveAreaTextBoxColumn.ReadOnly = true;
            //------TotalArea
            DataGridViewTextBoxColumn totalAreaTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAreaTextBoxColumn.DataPropertyName = "TotalArea";
            totalAreaTextBoxColumn.DefaultCellStyle = cellStyle1;
            totalAreaTextBoxColumn.FillWeight = 100F;
            totalAreaTextBoxColumn.HeaderText = "Загальна площа";
            totalAreaTextBoxColumn.Width = 100;
            totalAreaTextBoxColumn.ReadOnly = true;
            //------
            //------TotalPrice
            DataGridViewTextBoxColumn totalPriceTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceTextBoxColumn.DefaultCellStyle = cellStyle1;
            totalPriceTextBoxColumn.FillWeight = 130F;
            totalPriceTextBoxColumn.HeaderText = "Ціна (грн)";
            totalPriceTextBoxColumn.Width = 130;
            totalPriceTextBoxColumn.ReadOnly = true;
            //------
            dgvAppTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {rcNameTextBoxColumn, typeTextBoxColumn, roomAmTextBoxColumn, liveAreaTextBoxColumn, totalAreaTextBoxColumn, totalPriceTextBoxColumn,});
            //------
        }
        private void btnAddAppType_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (txtAppTypeName.Text!="" && txtAppRoomAm.Text!="" && txtAppLiveArea.Text!="" && txtAppTotalArea.Text!="")
            {
                myType.RC_ID = Convert.ToInt32(txtAppRcID.Text);
                myType.Typee = txtAppTypeName.Text;
                myType.RoomAm = Convert.ToInt32(txtAppRoomAm.Text);
                myType.LiveArea = Convert.ToDouble(txtAppLiveArea.Text);
                myType.TotalArea = Convert.ToDouble(txtAppTotalArea.Text);
                double m2price = Convert.ToDouble(txtAppM2Price.Text);
                myType.TotalPrice = myType.TotalArea * m2price;
                myType.Object = "App";
                myType.Picture = pbAddImage.Image;
                uDB.InsertType(myType);
                pbAddImage.Image = null;
                tType = uDB.GetAppType("App");
                dgvAppTypes.DataSource = tType;
            }
            uDB.CloseCon();
        }
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "jpg|*.jpg|png|*.png|bmp|*.bmp";
            if (ofdImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbAddImage.Image = Image.FromFile(ofdImage.FileName);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            txtAppTypeDelTypeID.DataBindings.Clear();
            int rcId = Convert.ToInt32(txtAppTypeDelRCID.Text);
            tType2 = uDB.GetTypeToApp(rcId, "App");
            cbAppTypeDelType.DataSource = tType2;
            cbAppTypeDelType.DisplayMember = "Type";
            txtAppTypeDelTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType2, "ID", true));
            uDB.CloseCon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DelAppTypeID = Convert.ToInt32(txtAppTypeDelTypeID.Text);
        }

        private void btnDeleteAppType_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            uDB.DeleteByIntNum("Type", "ID", DelAppTypeID);

            txtAppTypeDelTypeID.DataBindings.Clear();
            int rcId = Convert.ToInt32(txtAppTypeDelRCID.Text);
            tType2 = uDB.GetTypeToApp(rcId, "App");
            cbAppTypeDelType.DataSource = tType2;
            cbAppTypeDelType.DisplayMember = "Type";
            txtAppTypeDelTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType2, "ID", true));

            tType = uDB.GetAppType("App");
            dgvAppTypes.DataSource = tType;
            uDB.CloseCon();
        }
        //-----------

        //ComArea
        private void DataGridSourceComArea()
        {
            dgvComAreaTypes.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn rcNameComTextBoxColumn = new DataGridViewTextBoxColumn();
            rcNameComTextBoxColumn.DataPropertyName = "Name";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rcNameComTextBoxColumn.DefaultCellStyle = cellStyle1;
            rcNameComTextBoxColumn.FillWeight = 220F;
            rcNameComTextBoxColumn.HeaderText = "Житловий комплекс";
            rcNameComTextBoxColumn.Width = 220;
            rcNameComTextBoxColumn.ReadOnly = true;
            //------
            //------Name
            DataGridViewTextBoxColumn typeComTextBoxColumn = new DataGridViewTextBoxColumn();
            typeComTextBoxColumn.DataPropertyName = "Type";
            typeComTextBoxColumn.DefaultCellStyle = cellStyle1;
            typeComTextBoxColumn.FillWeight = 100F;
            typeComTextBoxColumn.HeaderText = "Тип";
            typeComTextBoxColumn.Width = 100;
            typeComTextBoxColumn.ReadOnly = true;
            //------
            //------RoomAm
            DataGridViewTextBoxColumn roomAmComTextBoxColumn = new DataGridViewTextBoxColumn();
            roomAmComTextBoxColumn.DataPropertyName = "RoomAm";
            roomAmComTextBoxColumn.DefaultCellStyle = cellStyle1;
            roomAmComTextBoxColumn.FillWeight = 100F;
            roomAmComTextBoxColumn.HeaderText = "К-сть кімнат";
            roomAmComTextBoxColumn.Width = 100;
            roomAmComTextBoxColumn.ReadOnly = true;
            //------
            //------TotalArea
            DataGridViewTextBoxColumn totalAreaComTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAreaComTextBoxColumn.DataPropertyName = "TotalArea";
            totalAreaComTextBoxColumn.DefaultCellStyle = cellStyle1;
            totalAreaComTextBoxColumn.FillWeight = 100F;
            totalAreaComTextBoxColumn.HeaderText = "Загальна площа";
            totalAreaComTextBoxColumn.Width = 100;
            totalAreaComTextBoxColumn.ReadOnly = true;
            //------
            //------TotalPrice
            DataGridViewTextBoxColumn totalPriceComTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceComTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceComTextBoxColumn.DefaultCellStyle = cellStyle1;
            totalPriceComTextBoxColumn.FillWeight = 170F;
            totalPriceComTextBoxColumn.HeaderText = "Ціна (грн)";
            totalPriceComTextBoxColumn.Width = 170;
            totalPriceComTextBoxColumn.ReadOnly = true;
            dgvComAreaTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { rcNameComTextBoxColumn, typeComTextBoxColumn, roomAmComTextBoxColumn, totalAreaComTextBoxColumn, totalPriceComTextBoxColumn });
            //------
        }
        private void btnComAreaAdd_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (txtComAreaType.Text != "" && txtComAreaRoomAm.Text != "" && txtComAreaTotalArea.Text != "" && pbAddComImage.Image!=null)
            {
                myType.RC_ID = Convert.ToInt32(txtComAreaAddRCID.Text);
                myType.Typee = txtComAreaType.Text;
                myType.RoomAm = Convert.ToInt32(txtComAreaRoomAm.Text);
                myType.LiveArea = 0;
                myType.TotalArea = Convert.ToDouble(txtComAreaTotalArea.Text);
                double m2price = Convert.ToDouble(txtComAreaAddPriceM2.Text);
                myType.TotalPrice = myType.TotalArea * m2price;
                myType.Object = "ComArea";
                myType.Picture = pbAddComImage.Image;
                uDB.InsertType(myType);

                tTypeCom = uDB.GetAppType("ComArea");
                dgvComAreaTypes.DataSource = tTypeCom;
                pbAddComImage.Image = null;
            }
            uDB.CloseCon();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "jpg|*.jpg|png|*.png|bmp|*.bmp";
            if (ofdImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbAddComImage.Image = Image.FromFile(ofdImage.FileName);
            }
        }
        private void btnRCOK_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            txtComAreaDelTypeID.DataBindings.Clear();
            int rcId = Convert.ToInt32(txtComAreaDelRCID.Text);
            tTypeCom2 = uDB.GetTypeToApp(rcId, "ComArea");
            cbCOmAreaTypeDelType.DataSource = tTypeCom2;
            cbCOmAreaTypeDelType.DisplayMember = "Type";
            txtComAreaDelTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tTypeCom2, "ID", true));
            uDB.CloseCon();
        }
        private void btnTypeOK_Click(object sender, EventArgs e)
        {
            DelComTypeID = Convert.ToInt32(txtComAreaDelTypeID.Text);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            uDB.DeleteByIntNum("Type", "ID", DelComTypeID);

            txtComAreaDelTypeID.DataBindings.Clear();
            int rcId = Convert.ToInt32(txtComAreaDelRCID.Text);
            tTypeCom2 = uDB.GetTypeToApp(rcId, "ComArea");
            cbCOmAreaTypeDelType.DataSource = tTypeCom2;
            cbCOmAreaTypeDelType.DisplayMember = "Type";
            txtComAreaDelTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tTypeCom2, "ID", true));

            tTypeCom = uDB.GetAppType("ComArea");
            dgvComAreaTypes.DataSource = tTypeCom;
            uDB.CloseCon();
        }

        //-----------

        //Footer
        private void DataGridSourceFooter()
        {
            dgvFooter.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn rcNameComTextBoxColumn = new DataGridViewTextBoxColumn();
            rcNameComTextBoxColumn.DataPropertyName = "Name";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rcNameComTextBoxColumn.DefaultCellStyle = cellStyle1;
            rcNameComTextBoxColumn.FillWeight = 220F;
            rcNameComTextBoxColumn.HeaderText = "Житловий комплекс";
            rcNameComTextBoxColumn.Width = 220;
            rcNameComTextBoxColumn.ReadOnly = true;
            //------
            //------Name
            DataGridViewTextBoxColumn typeComTextBoxColumn = new DataGridViewTextBoxColumn();
            typeComTextBoxColumn.DataPropertyName = "Type";
            typeComTextBoxColumn.DefaultCellStyle = cellStyle1;
            typeComTextBoxColumn.FillWeight = 100F;
            typeComTextBoxColumn.HeaderText = "Тип";
            typeComTextBoxColumn.Width = 100;
            typeComTextBoxColumn.ReadOnly = true;
            //------
            //------RoomAm
            DataGridViewTextBoxColumn roomAmComTextBoxColumn = new DataGridViewTextBoxColumn();
            roomAmComTextBoxColumn.DataPropertyName = "RoomAm";
            roomAmComTextBoxColumn.DefaultCellStyle = cellStyle1;
            roomAmComTextBoxColumn.FillWeight = 100F;
            roomAmComTextBoxColumn.HeaderText = "К-сть кімнат";
            roomAmComTextBoxColumn.Width = 100;
            roomAmComTextBoxColumn.ReadOnly = true;
            //------
            //------TotalArea
            DataGridViewTextBoxColumn totalAreaComTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAreaComTextBoxColumn.DataPropertyName = "TotalArea";
            totalAreaComTextBoxColumn.DefaultCellStyle = cellStyle1;
            totalAreaComTextBoxColumn.FillWeight = 100F;
            totalAreaComTextBoxColumn.HeaderText = "Загальна площа";
            totalAreaComTextBoxColumn.Width = 100;
            totalAreaComTextBoxColumn.ReadOnly = true;
            //------
            //------TotalPrice
            DataGridViewTextBoxColumn totalPriceComTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceComTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceComTextBoxColumn.DefaultCellStyle = cellStyle1;
            totalPriceComTextBoxColumn.FillWeight = 170F;
            totalPriceComTextBoxColumn.HeaderText = "Ціна (грн)";
            totalPriceComTextBoxColumn.Width = 170;
            totalPriceComTextBoxColumn.ReadOnly = true;
            dgvFooter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { rcNameComTextBoxColumn, typeComTextBoxColumn, roomAmComTextBoxColumn, totalAreaComTextBoxColumn, totalPriceComTextBoxColumn });
            //------
        }
        private void btnAddFooter_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (txtAddFooterType.Text != "" && txtAddFooterRoomAm.Text != "" && txtAddFooterTotalArea.Text != "" && pbAddImageFooter.Image!=null)
            {
                myType.RC_ID = Convert.ToInt32(txtAddFooterRcID.Text);
                myType.Typee = txtAddFooterType.Text;
                myType.RoomAm = Convert.ToInt32(txtAddFooterRoomAm.Text);
                myType.LiveArea = 0;
                myType.TotalArea = Convert.ToDouble(txtAddFooterTotalArea.Text);
                double m2price = Convert.ToDouble(txtAddFooterPriceM2.Text);
                myType.TotalPrice = myType.TotalArea * m2price;
                myType.Object = "Footer";
                myType.Picture = pbAddImageFooter.Image;
                uDB.InsertType(myType);

                tTypeCom = uDB.GetAppType("Footer");
                pbAddImageFooter.Image = null;
                dgvFooter.DataSource = tTypeCom;
            }
            uDB.CloseCon();
        }
        private void btnLoadImageFooter_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "jpg|*.jpg|png|*.png|bmp|*.bmp";
            if (ofdImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbAddImageFooter.Image = Image.FromFile(ofdImage.FileName);
            }
        }
        private void btnDelFooterRcOK_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            txtDelFooterTypeId.DataBindings.Clear();
            int rcId = Convert.ToInt32(txtDelFooterRcID.Text);
            tTypeFooter2 = uDB.GetTypeToApp(rcId, "Footer");
            cbDelFooterType.DataSource = tTypeFooter2;
            cbDelFooterType.DisplayMember = "Type";
            txtDelFooterTypeId.DataBindings.Add(new System.Windows.Forms.Binding("Text", tTypeFooter2, "ID", true));
            uDB.CloseCon();
        }

        private void btnDelFooterTypeOK_Click(object sender, EventArgs e)
        {
            DelFooterTypeID = Convert.ToInt32(txtDelFooterTypeId.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            uDB.DeleteByIntNum("Type", "ID", DelFooterTypeID);

            txtDelFooterTypeId.DataBindings.Clear();
            int rcId = Convert.ToInt32(txtDelFooterRcID.Text);
            tTypeFooter2 = uDB.GetTypeToApp(rcId, "Footer");
            cbDelFooterType.DataSource = tTypeFooter2;
            cbDelFooterType.DisplayMember = "Type";
            txtDelFooterTypeId.DataBindings.Add(new System.Windows.Forms.Binding("Text", tTypeFooter2, "ID", true));

            tTypeFooter = uDB.GetAppType("Footer");
            dgvFooter.DataSource = tTypeCom;
            uDB.CloseCon();
        }

        //-----------

        //Parking
        private void DataGridSourceParking()
        {
            dgvParking.AutoGenerateColumns = false;
            //------ID
            DataGridViewTextBoxColumn rcNameComTextBoxColumn = new DataGridViewTextBoxColumn();
            rcNameComTextBoxColumn.DataPropertyName = "Name";
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            cellStyle1.Font = new System.Drawing.Font("Amazing Grotesk", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rcNameComTextBoxColumn.DefaultCellStyle = cellStyle1;
            rcNameComTextBoxColumn.FillWeight = 270F;
            rcNameComTextBoxColumn.HeaderText = "Житловий комплекс";
            rcNameComTextBoxColumn.Width = 270;
            rcNameComTextBoxColumn.ReadOnly = true;
            //------
            //------Name
            DataGridViewTextBoxColumn typeComTextBoxColumn = new DataGridViewTextBoxColumn();
            typeComTextBoxColumn.DataPropertyName = "Type";
            typeComTextBoxColumn.DefaultCellStyle = cellStyle1;
            typeComTextBoxColumn.FillWeight = 100F;
            typeComTextBoxColumn.HeaderText = "Тип";
            typeComTextBoxColumn.Width = 100;
            typeComTextBoxColumn.ReadOnly = true;
            //------
            //------RoomAm
            DataGridViewTextBoxColumn roomAmComTextBoxColumn = new DataGridViewTextBoxColumn();
            roomAmComTextBoxColumn.DataPropertyName = "RoomAm";
            roomAmComTextBoxColumn.DefaultCellStyle = cellStyle1;
            roomAmComTextBoxColumn.FillWeight = 100F;
            roomAmComTextBoxColumn.HeaderText = "К-сть паркомість";
            roomAmComTextBoxColumn.Width = 100;
            roomAmComTextBoxColumn.ReadOnly = true;
            //------
            //------TotalPrice
            DataGridViewTextBoxColumn totalPriceComTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceComTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceComTextBoxColumn.DefaultCellStyle = cellStyle1;
            totalPriceComTextBoxColumn.FillWeight = 200F;
            totalPriceComTextBoxColumn.HeaderText = "Ціна (грн)";
            totalPriceComTextBoxColumn.Width = 200;
            totalPriceComTextBoxColumn.ReadOnly = true;
            dgvParking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { rcNameComTextBoxColumn, typeComTextBoxColumn, roomAmComTextBoxColumn, totalPriceComTextBoxColumn });
            //------
        }
        private void btnAddParking_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            if (txtAddParkingType.Text != "" && txtAddParkingAmount.Text != "" && pbAddImageParking.Image!=null)
            {
                myType.RC_ID = Convert.ToInt32(txtAddParkingRcID.Text);
                myType.Typee = txtAddParkingType.Text;
                myType.RoomAm = Convert.ToInt32(txtAddParkingAmount.Text);
                myType.LiveArea = 0;
                myType.TotalArea = 0;
                double price = Convert.ToDouble(txtAddParkingPrice.Text);
                myType.TotalPrice = myType.RoomAm * price;
                myType.Object = "Parking";
                myType.Picture = pbAddImageParking.Image;
                uDB.InsertType(myType);

                tTypeParking = uDB.GetAppType("Parking");
                pbAddImageParking.Image = null;
                dgvParking.DataSource = tTypeParking;
            }
            uDB.CloseCon();
        }
        private void btnLoadImageParking_Click(object sender, EventArgs e)
        {
            ofdImage.Filter = "jpg|*.jpg|png|*.png|bmp|*.bmp";
            if (ofdImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbAddImageParking.Image = Image.FromFile(ofdImage.FileName);
            }
        }

        private void btnDelParkingRcOK_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            txtDelParkingTypeId.DataBindings.Clear();
            int rcId = Convert.ToInt32(txtDelParkingRcId.Text);
            tTypeParking2 = uDB.GetTypeToApp(rcId, "Parking");
            cbDelParkingType.DataSource = tTypeParking2;
            cbDelParkingType.DisplayMember = "Type";
            txtDelParkingTypeId.DataBindings.Add(new System.Windows.Forms.Binding("Text", tTypeParking2, "ID", true));
            uDB.CloseCon();
        }

        private void btnDelParkingType_Click(object sender, EventArgs e)
        {
            DelParkingTypeID = Convert.ToInt32(txtDelParkingTypeId.Text);
        }

        private void btnDelParking_Click(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            uDB.DeleteByIntNum("Type", "ID", DelParkingTypeID);

            txtDelParkingTypeId.DataBindings.Clear();
            int rcId = Convert.ToInt32(txtDelParkingRcId.Text);
            tTypeParking2 = uDB.GetTypeToApp(rcId, "Parking");
            cbDelParkingType.DataSource = tTypeParking2;
            cbDelParkingType.DisplayMember = "Type";
            txtDelParkingTypeId.DataBindings.Add(new System.Windows.Forms.Binding("Text", tTypeParking2, "ID", true));

            tTypeParking = uDB.GetAppType("Parking");
            dgvParking.DataSource = tTypeParking;
            uDB.CloseCon();
        }

        //-------
        private void Types_Load(object sender, EventArgs e)
        {
            uDB.OpenConnection();
            //Apps
            tType = uDB.GetAppType("App");
            DataGridSourceApp();
            dgvAppTypes.DataSource = tType;

            tRC = uDB.GetTable("RC");
            cbAddAppTypeRC.DataSource = tRC;
            cbAddAppTypeRC.DisplayMember = "Name";
            txtAppRcID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
            txtAppM2Price.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "PriceAppM2", true));

            tRC2 = uDB.GetTable("RC");
            cbAppTypeDelRC.DataSource = tRC2;
            cbAppTypeDelRC.DisplayMember = "Name";
            txtAppTypeDelRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC2, "ID", true));
            int rcID = Convert.ToInt32(txtAppTypeDelRCID.Text);
            tType2 = uDB.GetTypeToApp(rcID, "App");
            cbAppTypeDelType.DataSource = tType2;
            cbAppTypeDelType.DisplayMember = "Type";
            txtAppTypeDelTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tType2, "ID", true));
            //----
            //ComArea
            tTypeCom = uDB.GetAppType("ComArea");
            DataGridSourceComArea();
            dgvComAreaTypes.DataSource = tTypeCom;

            cbAddComAreaTypeRC.DataSource = tRC;
            cbAddComAreaTypeRC.DisplayMember = "Name";
            txtComAreaAddRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
            txtComAreaAddPriceM2.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "PriceComAreaM2", true));

            cbComAreaTypeDelRC.DataSource = tRC2;
            cbComAreaTypeDelRC.DisplayMember = "Name";
            txtComAreaDelRCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC2, "ID", true));
            tTypeCom2 = uDB.GetTypeToApp(rcID, "ComArea");
            cbCOmAreaTypeDelType.DataSource = tTypeCom2;
            cbCOmAreaTypeDelType.DisplayMember = "Type";
            txtComAreaDelTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tTypeCom2, "ID", true));
            //----
            //Footer
            tTypeFooter = uDB.GetAppType("Footer");
            DataGridSourceFooter();
            dgvFooter.DataSource = tTypeFooter;

            cbAddFooterRC.DataSource = tRC;
            cbAddFooterRC.DisplayMember = "Name";
            txtAddFooterRcID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
            txtAddFooterPriceM2.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "PriceFooterM2", true));

            cbDelFooterRC.DataSource = tRC2;
            cbDelFooterRC.DisplayMember = "Name";
            txtDelFooterRcID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC2, "ID", true));
            tTypeFooter2 = uDB.GetTypeToApp(rcID, "Footer");
            cbDelFooterType.DataSource = tTypeFooter2;
            cbDelFooterType.DisplayMember = "Type";
            txtDelFooterTypeId.DataBindings.Add(new System.Windows.Forms.Binding("Text", tTypeFooter2, "ID", true));
            //----
            //Parking
            tTypeParking = uDB.GetAppType("Parking");
            DataGridSourceParking();
            dgvParking.DataSource = tTypeParking;

            cbAddParkingRC.DataSource = tRC;
            cbAddParkingRC.DisplayMember = "Name";
            txtAddParkingRcID.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "ID", true));
            txtAddParkingPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC, "PriceParking", true));

            cbDelParkingRC.DataSource = tRC2;
            cbDelParkingRC.DisplayMember = "Name";
            txtDelParkingRcId.DataBindings.Add(new System.Windows.Forms.Binding("Text", tRC2, "ID", true));
            tTypeParking2 = uDB.GetTypeToApp(rcID, "Parking");
            cbDelParkingType.DataSource = tTypeParking2;
            cbDelParkingType.DisplayMember = "Type";
            txtDelParkingTypeId.DataBindings.Add(new System.Windows.Forms.Binding("Text", tTypeParking2, "ID", true));
            //----
            uDB.CloseCon();
        }
    }
}
