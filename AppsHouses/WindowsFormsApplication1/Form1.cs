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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
 
        }
        string pName;
        //Forms------------------------------
        Clients pClients = new Clients();
        Apps pApps = new Apps();
        Houses pHouses = new Houses();
        Types pTypes = new Types();
        ComArea pComArea = new ComArea();
        Parking pParking = new Parking();
        Footer pFooter = new Footer();
        Sale pSale = new Sale();
        About pAbout = new About();
        Payments pPayment = new Payments();
        //-----------------------------------
        //-----------------------------------

        public void panels_off(string str)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form ff in openForms)
            {
                if (ff.Name != "fMain")
                    if (ff.Name != str)
                        ff.Hide();
            }
        }
        public void panels_on()
        {
             if (mainPanel.Visible == false)
                mainPanel.Visible = true;
        }
        private void FBclose_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 30; i++)
            {
                this.Opacity -= 0.02;
                Thread.Sleep(60);
            }
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form ff in openForms)
            {
                ff.Close();
            }
        }

        private void Bsales_Click(object sender, EventArgs e)
        {
            pSale.Size = mainPanel.Size;
            pName = "Sale";
            panels_off(pName);
            panels_on();
            pSale.Show();
        }

        private void Bclient_Click(object sender, EventArgs e)
        {
            pClients.Size = mainPanel.Size;
            pName = "Clients";
            panels_off(pName);
            panels_on();
            pClients.Show();
        }

        private void Bhouse_Click(object sender, EventArgs e)
        {
            pHouses.Size = mainPanel.Size;
            pName = "Houses";
            panels_off(pName);
            panels_on();
            pHouses.Show();
        }

        private void Bapps_Click(object sender, EventArgs e)
        {
            pApps.Size = mainPanel.Size;
            pName = "Apps";
            panels_off(pName);
            panels_on();
            pApps.Show();
        }

        private void Bsettings_Click(object sender, EventArgs e)
        {
            pPayment.Size = mainPanel.Size;
            pName = "Payments";
            panels_off(pName);
            panels_on();
            pPayment.Show();
        }

        private void Babout_Click(object sender, EventArgs e)
        {
            pAbout.Size = mainPanel.Size;
            pName = "About";
            panels_off(pName);
            panels_on();
            pAbout.Show();
        }

        private void btnComArea_Click(object sender, EventArgs e)
        {
            pComArea.Size = mainPanel.Size;
            pName = "ComArea";
            panels_off(pName);
            panels_on();
            pComArea.Show();
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            pTypes.Size = mainPanel.Size;
            pName = "Types";
            panels_off(pName);
            panels_on();
            pTypes.Show();
        }

        private void btnParking_Click(object sender, EventArgs e)
        {
            pParking.Size = mainPanel.Size;
            pName = "Parking";
            panels_off(pName);
            panels_on();
            pParking.Show();
        }

        private void btnFooter_Click(object sender, EventArgs e)
        {
            pFooter.Size = mainPanel.Size;
            pName = "Footer";
            panels_off(pName);
            panels_on();
            pFooter.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form ff in openForms)
            {
                ff.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
