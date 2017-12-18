using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    class UseDB
    {
        OleDbConnection connect;
        OleDbCommand oCmd;
        DataSet ds = new DataSet();
        DbCommand cmd;
        string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BuildCompanyDB.accdb";
        public UseDB()
        {
            connect = new OleDbConnection(conString);
        }
        public void OpenConnection()
        {
            connect.Open();
        }

        public DataTable GetTable(string tName)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tName;
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }

        public DataTable GetLogin(string usr, string pass)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT  Count (*) FROM USERS WHERE username = '" + usr + "' AND password = '" + pass + "'";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        //Apps
        public DataTable GetApps()
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Apps.*, RC.Name, RC.PriceAppM2, Type.Type, Type.RoomAm, Type.LiveArea, Type.TotalArea, Type.TotalPrice " +
            "FROM RC INNER JOIN (Type INNER JOIN Apps ON Type.ID = Apps.Type_ID) ON(RC.ID = Type.RC_ID) AND(RC.ID = Apps.RC_ID)";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }

        public DataTable GetAppsSold(bool ch)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Apps.*, RC.Name, RC.PriceAppM2, Type.Type, Type.RoomAm, Type.LiveArea, Type.TotalArea, Type.TotalPrice " +
            "FROM RC INNER JOIN (Type INNER JOIN Apps ON Type.ID = Apps.Type_ID) ON(RC.ID = Type.RC_ID) AND(RC.ID = Apps.RC_ID) " +
            "Where Apps.Sold= " + ch;
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }

        //ComArea
        public DataTable GetComArea()
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Type.Type, Type.RoomAm, Type.TotalArea, RC.PriceComAreaM2, Type.TotalPrice, RC.Name, ComArea.IDd " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN ComArea ON Type.ID = ComArea.Type_ID";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable SearchComArea(int typeS, string Col, string str, int num, double num2, bool bl, int lem)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();

            string lm = " = ";
            if (lem == 0)
                lm = " <= ";
            if (lem == 1)
                lm = " >= ";
            if (lem == 2)
                lm = " = ";

            cmd.CommandText = "SELECT Type.Type, Type.RoomAm, Type.TotalArea, RC.PriceComAreaM2, Type.TotalPrice, RC.Name, RC.ID, ComArea.IDd, ComArea.Sold " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN ComArea ON Type.ID = ComArea.Type_ID " +
            "WHERE " + Col;
            switch (typeS)
            {
                case 0:
                    {
                        cmd.CommandText += " LIKE " + "\'%" + str + "%\'";
                    }
                    break;
                case 1:
                    {
                        cmd.CommandText += lm + num;
                    }
                    break;
                case 2:
                    {
                        cmd.CommandText += lm + num2;
                    }
                    break;
                case 3:
                    {
                        cmd.CommandText += " LIKE " + "\'%" + str + "%\' AND ComArea.Sold = " +bl;
                    }
                    break;
                case 4:
                    {
                        cmd.CommandText += lm + num + " AND ComArea.Sold = " + bl;
                    }
                    break;
                case 5:
                    {
                        cmd.CommandText += lm + num2 + " AND ComArea.Sold = " + bl;
                    }
                    break;
                case 6:
                    {
                        cmd.CommandText += lm + bl;
                    }
                    break;
            }
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        //----
        //Parking
        public DataTable GetParking()
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Type.Type, Type.RoomAm, RC.PriceParking, Type.TotalPrice, RC.Name, Parking.IDd, Parking.Sold " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN Parking ON Type.ID = Parking.Type_ID";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable SearchParking(int typeS, string Col, string str, int num, double num2, bool bl, int lem)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();

            string lm = " = ";
            if (lem == 0)
                lm = " <= ";
            if (lem == 1)
                lm = " >= ";
            if (lem == 2)
                lm = " = ";

            cmd.CommandText = "SELECT Type.Type, Type.RoomAm, RC.PriceParking, Type.TotalPrice, RC.Name, Parking.IDd, Parking.Sold " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN Parking ON Type.ID = Parking.Type_ID "+
            "WHERE " + Col;
            switch (typeS)
            {
                case 0:
                    {
                        cmd.CommandText += " LIKE " + "\'%" + str + "%\'";
                    }
                    break;
                case 1:
                    {
                        cmd.CommandText += lm + num;
                    }
                    break;
                case 2:
                    {
                        cmd.CommandText += lm + num2;
                    }
                    break;
                case 3:
                    {
                        cmd.CommandText += " LIKE " + "\'%" + str + "%\' AND Parking.Sold = " + bl;
                    }
                    break;
                case 4:
                    {
                        cmd.CommandText += lm + num + " AND Parking.Sold = " + bl;
                    }
                    break;
                case 5:
                    {
                        cmd.CommandText += lm + num2 + " AND Parking.Sold = " + bl;
                    }
                    break;
                case 6:
                    {
                        cmd.CommandText += lm + bl;
                    }
                    break;
            }
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        //-------

        //Footer
        public DataTable GetFooter()
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Type.Type, Type.RoomAm, RC.PriceFooterM2, Type.TotalPrice, Type.TotalArea, RC.Name, Footer.IDd, Footer.Sold " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN Footer ON Type.ID = Footer.Type_ID";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable SearchFooter(int typeS, string Col, string str, int num, double num2, bool bl, int lem)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();

            string lm = " = ";
            if (lem == 0)
                lm = " <= ";
            if (lem == 1)
                lm = " >= ";
            if (lem == 2)
                lm = " = ";

            cmd.CommandText = "SELECT Type.Type, Type.RoomAm, RC.PriceFooterM2, Type.TotalPrice, Type.TotalArea, RC.Name, Footer.IDd, Footer.Sold " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN Footer ON Type.ID = Footer.Type_ID " +
            "WHERE " + Col;
            switch (typeS)
            {
                case 0:
                    {
                        cmd.CommandText += " LIKE " + "\'%" + str + "%\'";
                    }
                    break;
                case 1:
                    {
                        cmd.CommandText += lm + num;
                    }
                    break;
                case 2:
                    {
                        cmd.CommandText += lm + num2;
                    }
                    break;
                case 3:
                    {
                        cmd.CommandText += " LIKE " + "\'%" + str + "%\' AND Footer.Sold = " + bl;
                    }
                    break;
                case 4:
                    {
                        cmd.CommandText += lm + num + " AND Footer.Sold = " + bl;
                    }
                    break;
                case 5:
                    {
                        cmd.CommandText += lm + num2 + " AND Footer.Sold = " + bl;
                    }
                    break;
                case 6:
                    {
                        cmd.CommandText += lm + bl;
                    }
                    break;
            }
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        //-------

        //Contract
        public DataTable GetContract()
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Contract.ID, Contract.Data, Contract.TotalPay, Contract.Term, Contract.PayPerPeriod, Contract.LastPayDate, Contract.Payed, Contract.Closed, Clients.Name, Clients.Phone, RC.Name, Type.Type, Apps.Floor, Apps.AppNum " +
            "FROM RC INNER JOIN (Clients INNER JOIN(Type INNER JOIN(Apps INNER JOIN Contract ON Apps.ID = Contract.AppID) ON Type.ID = Apps.Type_ID) ON Clients.ID = Contract.ClientID) ON(RC.ID = Type.RC_ID) AND(RC.ID = Apps.RC_ID)";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable GetContractCom()
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Contract.ID, Contract.Data, Contract.TotalPay, Contract.Term, Contract.PayPerPeriod, Contract.LastPayDate, Contract.Payed, Contract.Closed, Clients.Name, Clients.Phone, RC.Name, Type.Type, ComArea.IDd " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN (ComArea INNER JOIN(Clients INNER JOIN Contract ON Clients.ID = Contract.ClientID) ON ComArea.IDd = Contract.ComArea_ID) ON Type.ID = ComArea.Type_ID";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable GetContractFooter()
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Contract.ID, Contract.Data, Contract.TotalPay, Contract.Term, Contract.PayPerPeriod, Contract.LastPayDate, Contract.Payed, Contract.Closed, Clients.Name, Clients.Phone, RC.Name, Type.Type, Footer.IDd " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN (Footer INNER JOIN(Clients INNER JOIN Contract ON Clients.ID = Contract.ClientID) ON Footer.IDd = Contract.Footer_ID) ON Type.ID = Footer.Type_ID";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable GetContractParking()
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Contract.ID, Contract.Data, Contract.TotalPay, Contract.Term, Contract.PayPerPeriod, Contract.LastPayDate, Contract.Payed, Contract.Closed, Clients.Name, Clients.Phone, RC.Name, Type.Type, Parking.IDd " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN (Parking INNER JOIN(Clients INNER JOIN Contract ON Clients.ID = Contract.ClientID) ON Parking.IDd = Contract.Parking_ID) ON Type.ID = Parking.Type_ID";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable SearchContract(int sType, string Col, string str, int num, double num2)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Contract.ID, Contract.Data, Contract.TotalPay, Contract.Term, Contract.PayPerPeriod, Contract.LastPayDate, Contract.Payed, Contract.Closed, Clients.Name, Clients.Phone, RC.Name, Type.Type, Apps.Floor, Apps.AppNum " +
            "FROM RC INNER JOIN (Clients INNER JOIN(Type INNER JOIN(Apps INNER JOIN Contract ON Apps.ID = Contract.AppID) ON Type.ID = Apps.Type_ID) ON Clients.ID = Contract.ClientID) ON(RC.ID = Type.RC_ID) AND(RC.ID = Apps.RC_ID) " +
            "WHERE " + Col;
            switch (sType)
            {
                case 0:
                    {
                        cmd.CommandText += " LIKE " + "\'%" + str + "%\'";
                    }
                    break;
                case 1:
                    {
                        cmd.CommandText += " = " + num;
                    }
                    break;
                case 2:
                    {
                        cmd.CommandText += " = " + num2;
                    }
                    break;
            }
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }

        public DataTable SearchContractCom(int sType, string Col, string str, int num, double num2)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Contract.ID, Contract.Data, Contract.TotalPay, Contract.Term, Contract.PayPerPeriod, Contract.LastPayDate, Contract.Payed, Contract.Closed, Clients.Name, Clients.Phone, RC.Name, Type.Type, ComArea.IDd " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN (ComArea INNER JOIN(Clients INNER JOIN Contract ON Clients.ID = Contract.ClientID) ON ComArea.IDd = Contract.ComArea_ID) ON Type.ID = ComArea.Type_ID " +
            "WHERE " + Col;
            switch (sType)
            {
                case 0:
                    {
                        cmd.CommandText += " LIKE " + "\'%" + str + "%\'";
                    }
                    break;
                case 1:
                    {
                        cmd.CommandText += " = " + num;
                    }
                    break;
                case 2:
                    {
                        cmd.CommandText += " = " + num2;
                    }
                    break;
            }
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable SearchContractFooter(int sType, string Col, string str, int num, double num2)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Contract.ID, Contract.Data, Contract.TotalPay, Contract.Term, Contract.PayPerPeriod, Contract.LastPayDate, Contract.Payed, Contract.Closed, Clients.Name, Clients.Phone, RC.Name, Type.Type, Footer.IDd " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN (Footer INNER JOIN(Clients INNER JOIN Contract ON Clients.ID = Contract.ClientID) ON Footer.IDd = Contract.Footer_ID) ON Type.ID = Footer.Type_ID " +
            "WHERE " + Col;
            switch (sType)
            {
                case 0:
                    {
                        cmd.CommandText += " LIKE " + "\'%" + str + "%\'";
                    }
                    break;
                case 1:
                    {
                        cmd.CommandText += " = " + num;
                    }
                    break;
                case 2:
                    {
                        cmd.CommandText += " = " + num2;
                    }
                    break;
            }
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable SearchContractParking(int sType, string Col, string str, int num, double num2)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Contract.ID, Contract.Data, Contract.TotalPay, Contract.Term, Contract.PayPerPeriod, Contract.LastPayDate, Contract.Payed, Contract.Closed, Clients.Name, Clients.Phone, RC.Name, Type.Type, Parking.IDd " +
            "FROM(RC INNER JOIN Type ON RC.ID = Type.RC_ID) INNER JOIN (Parking INNER JOIN(Clients INNER JOIN Contract ON Clients.ID = Contract.ClientID) ON Parking.IDd = Contract.Parking_ID) ON Type.ID = Parking.Type_ID " +
            "WHERE " + Col;
            switch (sType)
            {
                case 0:
                    {
                        cmd.CommandText += " LIKE " + "\'%" + str + "%\'";
                    }
                    break;
                case 1:
                    {
                        cmd.CommandText += " = " + num;
                    }
                    break;
                case 2:
                    {
                        cmd.CommandText += " = " + num2;
                    }
                    break;
            }
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        //--------


        public DataTable SearchApps(bool ch, int sb, string col, string str, int num, double num2, int lessMore)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Apps.*, RC.Name, RC.PriceAppM2, Type.Type, Type.RoomAm, Type.LiveArea, Type.TotalArea, Type.TotalPrice " +
            "FROM RC INNER JOIN (Type INNER JOIN Apps ON Type.ID = Apps.Type_ID) ON(RC.ID = Type.RC_ID) AND(RC.ID = Apps.RC_ID) " +
            "Where ";
            switch (sb)
            {
                case 0: { cmd.CommandText += col + " LIKE " + "\'%" + str + "%\'"; }
                    break;
                case 1: {
                        string lM = " = ";
                        if (lessMore == 0)
                            lM = " <= ";
                        if (lessMore == 1)
                            lM = " >= ";
                        if (lessMore == 2)
                            lM = " = ";
                        cmd.CommandText += col + lM + num; }
                    break;
                case 3: {
                        string lM = " = ";
                        if (lessMore == 0)
                            lM = " <= ";
                        if (lessMore == 1)
                            lM = " >= ";
                        if (lessMore == 2)
                            lM = " = ";
                        cmd.CommandText += col + lM + num2; }
                    break;
                case 4: { cmd.CommandText += "Apps.Sold = " + ch + " AND " + col + " LIKE " + "\'%" + str + "%\'"; }
                    break;
                case 5:
                    {
                        string lM = " = ";
                        if (lessMore == 0)
                            lM = " <= ";
                        if (lessMore == 1)
                            lM = " >= ";
                        if (lessMore == 2)
                            lM = " = ";
                        cmd.CommandText += "Apps.Sold = " + ch + " AND " + col + lM + num; }
                    break;
                case 6:
                    {
                        string lM = " = ";
                        if (lessMore == 0)
                            lM = " <= ";
                        if (lessMore == 1)
                            lM = " >= ";
                        if (lessMore == 2)
                            lM = " = ";
                        cmd.CommandText += "Apps.Sold = " + ch + " AND " + col + lM + num2; }
                    break;
            }
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }

        public DataTable SearchSold(string tName, bool bl, int typeID)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * From " + tName + " WHERE Type_ID = " + typeID + " AND Sold = " + bl;
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }

        //-----------------
        //Type--------------
        public DataTable GetTypeToApp(int rcID, string str)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Type.*, RC.Name FROM RC INNER JOIN Type ON RC.ID = Type.RC_ID WHERE(((RC.ID) = "  + rcID +" AND Type.Object= " +"\""+str+ "\"" + "))";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        //-------------------------------------------------------------------------

        //AppsType
        public DataTable GetAppType(string str)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT RC.Name, Type.* FROM RC INNER JOIN Type ON RC.ID = Type.RC_ID WHERE Type.Object = \"" + str + "\"";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        //---------------------
        //SearchLessMore-----------------------------------------------------------------
        public DataTable GetLessMore(string tName, string Col, int num, double num2, int sb, int lessMore)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            string lM = " = ";
            if (lessMore == 0)
                lM = " <= ";
            if (lessMore == 1)
                lM = " >= ";
            if (lessMore == 2)
                lM = " = ";
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tName + " WHERE " + Col + lM;
            switch (sb)
            {
                case 0:
                    {
                        cmd.CommandText += num;
                    }
                    break;
                case 1:
                    {
                        cmd.CommandText += num2;
                    }
                    break;
            }
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }

        public DataTable GetPayment()
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Payment.ID, Clients.Name, Payment.Contract_ID, Contract.Data, Payment.Type, Payment.Data, Payment.Incoming " +
            "FROM(Clients INNER JOIN Contract ON Clients.ID = Contract.ClientID) INNER JOIN Payment ON (Contract.ID = Payment.Contract_ID) AND(Clients.ID = Payment.Client_ID)";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable SearchPayment(int type, string col, string str, int num)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Payment.ID, Clients.Name, Payment.Contract_ID, Contract.Data, Payment.Type, Payment.Data, Payment.Incoming " +
            "FROM(Clients INNER JOIN Contract ON Clients.ID = Contract.ClientID) INNER JOIN Payment ON (Contract.ID = Payment.Contract_ID) AND(Clients.ID = Payment.Client_ID) " +
            "WHERE " + col;
            switch (type)
            {
                case 0: cmd.CommandText += " LIKE " + "\'%" + str + "%\'";
                    break;
                case 1: cmd.CommandText += " = " + num;
                    break;
            }
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable ToPay()
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT Contract.ID, Clients.Name, Clients.Phone, Contract.Data, Contract.LastPayDate " +
            "FROM Clients INNER JOIN Contract ON Clients.ID = Contract.ClientID " +
            "WHERE Contract.LastPayDate <= Date() - 90 AND Contract.Closed = false"; 
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }

        //-------------------------------------------------------------------------

        //SEARCH-------------------------------------------------------------------
        public DataTable SearchByINTNum(string tName, string Col, int num)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tName + " WHERE "+ Col+"="+ num;
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable SearchByString(string tName, string Col, string str)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText= "SELECT * FROM " + tName + " WHERE " + Col + " LIKE " + "\'%" +str+ "%\'";
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        public DataTable SearchByPassPort(string Ser, int Num)
        {
            DbDataReader dr;
            DataTable temp = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM Clients WHERE PassportSer= " +"\'"+ Ser + "\'" + " AND " + "PassportNum= " + Num;
            dr = cmd.ExecuteReader();
            temp.Load(dr);
            return temp;
        }
        //----------------------------------------------------------------------------------------




        //INSERT DATA-----------------------------------------------------------------------------
        public int InsertClient(Client tempClient)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO Clients (Name, Phone, PassportSer, PassportNum) VALUES ('"+tempClient.Name+"', '"+tempClient.Phone+"', '"+tempClient.PassportSer+"', '"+tempClient.PassportNum+"');";
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int InsertApp(App tempApp)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO Apps (RC_ID, Type_ID, Floor, AppNum) VALUES ('"+tempApp.RC_ID+"', '"+tempApp.Type_ID+"', '"+tempApp.Floor+"', '"+tempApp.AppNum+"')";
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int InsertRC(RC tempRC)
        {
            oCmd = connect.CreateCommand();
            oCmd.CommandText = "INSERT INTO RC ([Name], [Address], [Bldgs_am], [Cross], [WallsMat], [Info], [Image]) VALUES " +
            "('"+tempRC.Name+"', '"+tempRC.Address+"', '"+tempRC.Bldgs_am+"', '"+tempRC.Cross+"', '"+tempRC.WallMat+"', '"+tempRC.Info+"', @Image)";
            OleDbParameter oPar = new OleDbParameter("Image", OleDbType.VarBinary);
            MemoryStream ms = new MemoryStream();
            tempRC.Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            oPar.Value = ms.ToArray();
            oCmd.Parameters.Add(oPar);
            int rows = oCmd.ExecuteNonQuery();
            ms.Dispose();
            return rows;
        }
        public Image GetImages(string tName, string col, int id)
        {
            OleDbDataReader dr;
            DataTable temp = new DataTable();
            oCmd = connect.CreateCommand();
            oCmd.CommandText = "SELECT Image FROM " + tName + " WHERE " + col + " = " + id;
            dr = oCmd.ExecuteReader();
            Image Picture = null;
            if (dr.HasRows)
            {
                MemoryStream ms = new MemoryStream();
                foreach (DbDataRecord record in dr)
                    ms.Write((byte[])record["Image"], 0, ((byte[])record["Image"]).Length);
                Picture = Image.FromStream(ms);
                ms.Dispose();
            }
            return Picture;
        }
   
        public int InsertType(Type tempType)
        {
            oCmd = connect.CreateCommand();
            oCmd.CommandText = "INSERT INTO Type ([RC_ID], [Type], [RoomAm], [LiveArea], [TotalArea], [TotalPrice], [Object], [Image]) VALUES ('" + tempType.RC_ID + "', '" + tempType.Typee + "', '" + tempType.RoomAm + "', '" + tempType.LiveArea + "', '" + tempType.TotalArea + "', '" + tempType.TotalPrice + "', '"+tempType.Object+"', @Image)";
            OleDbParameter oPar = new OleDbParameter("Image", OleDbType.VarBinary);
            MemoryStream ms = new MemoryStream();
            tempType.Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            oPar.Value = ms.ToArray();
            oCmd.Parameters.Add(oPar);
            int rows = oCmd.ExecuteNonQuery();
            ms.Dispose();
            return rows;
        }

        public int InsertComArea(Comarea tempComArea)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO ComArea (Type_ID) VALUES ('" + tempComArea.Type_ID + "')";
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int InsertParking(Parkings tempParking)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO Parking (Type_ID) VALUES ('" + tempParking.Type_ID + "')";
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int InsertFooter(Footers tempFooter)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO Footer (Type_ID) VALUES ('" + tempFooter.Type_ID + "')";
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int InsertContractApp(Contract tempContract)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO Contract (ClientID, AppID, Data, TotalPay, Term, PayPerPeriod) VALUES ('"+tempContract.ClientID+"', '"+tempContract.AppID+"', '"+tempContract.Date+"', '"+tempContract.TotalPay+"', '"+tempContract.Term+"', '"+tempContract.PayPerMonth+"')";
            int rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Apps SET Sold= true WHERE ID= " + tempContract.AppID;
            rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int InsertContractCom(Contract tempContract)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO Contract (ClientID, ComArea_ID, Data, TotalPay, Term, PayPerPeriod) VALUES ('" + tempContract.ClientID + "', '" + tempContract.ComArea_ID + "', '" + tempContract.Date + "', '" + tempContract.TotalPay + "', '" + tempContract.Term + "', '" + tempContract.PayPerMonth + "')";
            int rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE ComArea SET Sold= true WHERE IDd= " + tempContract.ComArea_ID;
            rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int InsertContractFooter(Contract tempContract)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO Contract (ClientID, Footer_ID, Data, TotalPay, Term, PayPerPeriod) VALUES ('" + tempContract.ClientID + "', '" + tempContract.Footer_ID + "', '" + tempContract.Date + "', '" + tempContract.TotalPay + "', '" + tempContract.Term + "', '" + tempContract.PayPerMonth + "')";
            int rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Footer SET Sold= true WHERE IDd= " + tempContract.Footer_ID;
            rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int InsertContractParking(Contract tempContract)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO Contract (ClientID, Parking_ID, Data, TotalPay, Term, PayPerPeriod) VALUES ('" + tempContract.ClientID + "', '" + tempContract.Parking_ID + "', '" + tempContract.Date + "', '" + tempContract.TotalPay + "', '" + tempContract.Term + "', '" + tempContract.PayPerMonth + "')";
            int rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Parking SET Sold= true WHERE IDd= " + tempContract.Parking_ID;
            rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int InsertPayment(Payment tempPayment)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO Payment (Client_ID, Contract_ID, Type, Data, Incoming) VALUES ('" + tempPayment.Client_ID + "', '" + tempPayment.Contract_ID + "', '" + tempPayment.Type + "', Date(), '" + tempPayment.incoming +"')";
            int rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Contract SET LastPayDate = Date() WHERE ID= " + tempPayment.Contract_ID;
            rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Contract SET Payed = Payed + " + tempPayment.incoming + " WHERE ID= " + tempPayment.Contract_ID;
            rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Contract SET Closed = true WHERE Payed>=TotalPay";
            rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int UpdateConfig(RC tempRC)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE RC SET DataFinish = " + "#" + tempRC.DataFinish + "#" + " WHERE ID= " + tempRC.ID; 
            int rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE RC SET PeriodsLeft = " + tempRC.PeriodsLeft + " WHERE ID= " + tempRC.ID;
            rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE RC SET FirstPay = " + tempRC.FirstPay + " WHERE ID= " + tempRC.ID;
            rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE RC SET PriceAppM2 = " + tempRC.PriceAppM2 + " WHERE ID= " + tempRC.ID;
            rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE RC SET PriceComAreaM2 = " + tempRC.PriceComAreaM2 + " WHERE ID= " + tempRC.ID;
            rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE RC SET PriceFooterM2 = " + tempRC.PriceFooterM2 + " WHERE ID= " + tempRC.ID;
            rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE RC SET PriceParking = " + tempRC.PriceParking + " WHERE ID= " + tempRC.ID;
            rows = cmd.ExecuteNonQuery();
            //---------------------------
            cmd.CommandText = "UPDATE Type SET TotalPrice = TotalArea * " + tempRC.PriceAppM2 + " WHERE Object = \"App\" AND ID= " + tempRC.ID;
            rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Type SET TotalPrice = TotalArea * " + tempRC.PriceComAreaM2 + " WHERE Object = \"ComArea\" AND ID= " + tempRC.ID;
            rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Type SET TotalPrice = TotalArea * " + tempRC.PriceFooterM2 + " WHERE Object = \"Footer\" AND ID= " + tempRC.ID;
            rows = cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Type SET TotalPrice = RoomAm * " + tempRC.PriceParking + " WHERE Object = \"Parking\" AND ID= " + tempRC.ID;
            rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int UPDATEImage(RC tempRC)
        {
            oCmd = connect.CreateCommand();
            oCmd.CommandText = "UPDATE RC SET [Image] = @Image WHERE ID = " + tempRC.ID;
            OleDbParameter oPar = new OleDbParameter("Image", OleDbType.VarBinary);
            MemoryStream ms = new MemoryStream();
            tempRC.Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            oPar.Value = ms.ToArray();
            oCmd.Parameters.Add(oPar);
            int rows = oCmd.ExecuteNonQuery();
            ms.Dispose();
            return rows;
        }
        public int UPDATEImageType(Type tempType)
        {
            oCmd = connect.CreateCommand();
            oCmd.CommandText = "UPDATE Type SET [Image] = @Image WHERE ID = " + tempType.ID;
            OleDbParameter oPar = new OleDbParameter("Image", OleDbType.VarBinary);
            MemoryStream ms = new MemoryStream();
            tempType.Picture.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            oPar.Value = ms.ToArray();
            oCmd.Parameters.Add(oPar);
            int rows = oCmd.ExecuteNonQuery();
            ms.Dispose();
            return rows;
        }
        //-------------------------------------------------------------------------------------------------



        //DELETE-------------------------------------------------------------------------------------------
        public int DeleteByIntNum(string tName, string Col, int num)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM " + tName + " WHERE " + Col + "=" + num;
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int DeleteByString(string tName, string Col, string str)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM " + tName + " WHERE " + Col + "=" + str;
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }
        public int DeleteByBool(string tName, string Col, bool val)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM " + tName + " WHERE " + Col + "=" + val;
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }

        public int DeleteByPassPort(string Ser, int Num)
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE FROM Clients WHERE PassportSer= " + "\'" + Ser + "\'" + " AND " + "PassportNum= " + Num;
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }

        //-------------------------------------------------------------------------------------------
        public void CloseCon()
        {
            connect.Close();
        }
    }
}
