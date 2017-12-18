using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Client
    {
        public int ID;
        public string Name;
        public int Phone;
        public string PassportSer;
        public int PassportNum;
    }

    class App
    {
        public int ID;
        public int RC_ID;
        public int Type_ID;
        public int Floor;
        public int AppNum;
        public bool Sold;
                
    }
    class RC
    {
        public int ID;
        public string Name;
        public string Address;
        public int Bldgs_am;
        public string Cross;
        public string WallMat;
        public string Info;
        public string DataFinish;
        public double PriceAppM2;
        public double PriceFooterM2;
        public double PriceComAreaM2;
        public double PriceParking;
        public int FirstPay;
        public int PeriodsLeft;
        public Image Picture;
    }

    class Comarea
    {
        public int ID;
        public int Type_ID;
        public bool Sold;
    }
    class Footers
    {
        public int ID;
        public int Type_ID;
        public bool Sold;
    }
    class Parkings
    {
        public int ID;
        public int Type_ID;
        public bool Sold;
    }

    class Type
    {
        public int ID;
        public int RC_ID;
        public string Typee;
        public int RoomAm;
        public double LiveArea;
        public double TotalArea;
        public double TotalPrice;
        public string Object;
        public Image Picture;
    }
    class Contract
    {
        public int ID;
        public int ClientID;
        public int AppID;
        public int Footer_ID;
        public int ComArea_ID;
        public int Parking_ID;
        public string Date;
        public double TotalPay;
        public int Term;
        public double PayPerMonth;
    }

    class Payment
    {
        public int ID;
        public int Client_ID;
        public int Contract_ID;
        public string Type;
        public int Pay_Num;
        public string Date;
        public double incoming;
    }
}
