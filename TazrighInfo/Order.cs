using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace TazrighInfo
{
    class Order
    {
        public long Id = 0;
        public long ProductCode = 0;
        public long CustomerCode = 0;
        public long ProductionCode = 0;
        public int NumberofOrder = 0;
        public Single MaterialAmount = 0;
        public string Color = "";
        public Single ColorAmount = 0;
        public string ColorOwner = "";
        public string MaterialOwner = "";
        public string OrderDate = "";
        public string OrderTime = "";
        public string StartDate = "";
        public string EndDate = "";
        public long StartCounter = 0;
        public long StopCounter = 0;
        public string DeliverDate = "";
        public int wastedNumber = 0;
        public Single WaistedWeight = 0;
        public Single WaistedPercent = 0;
        public Single TotalProductWeight = 0;
        public long CoinageNumber = 0;
        public string ExperimentLevel = "";
        public string OperatorName = "";
        public string Comments = "";
        public bool CastFormatDelivered = false;
        public string Purser = "";

        public string ErrorMessage = "";
        DataAccess md;

        public Order()
        {
            md=new DataAccess();
        }         

        public bool Update()
        {           

            string sql = @"Update Orders set ProductCode={0},CustomerCode={1},ProductionCode={2},NumberofOrder={3},MaterialAmount={4},Colorc='{5}',ColorAmount={6},ColorOwner='{7}',MaterialOwner='{8}',OrderDate='{9}'
                             ,OrderTime='{10}',StartDate='{11}',EndDate='{12}',StartCounter={13},StopCounter={14},DeliverDate='{15}',wastedNumber={16},TotalProductWeight={17},CoinageNumber={18},ExperimentLevel='{19}',OperatorName='{20}',Comments='{21}',CastFormatDelivered='{22}',Purser='{23}',WaistedWeight={24},WaistedPercent={25}
                             where ID={26}";
            sql = string.Format(sql, this.ProductCode, this.CustomerCode, this.ProductionCode, this.NumberofOrder, this.MaterialAmount, this.Color, this.ColorAmount, this.ColorOwner, this.MaterialOwner, this.OrderDate, this.OrderTime, this.StartDate, this.EndDate, this.StartCounter, this.StopCounter, this.DeliverDate, this.wastedNumber, this.TotalProductWeight, this.CoinageNumber, this.ExperimentLevel, this.OperatorName, this.Comments, this.CastFormatDelivered, this.Purser, this.WaistedWeight, this.WaistedPercent, this.Id);
            


            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };
            
            md.DisConnect();
            return true;

        }

        public bool Insert()
        {
           
            string sql = @"insert into Orders (ProductCode,CustomerCode,ProductionCode,NumberofOrder,MaterialAmount,Colorc,ColorAmount,ColorOwner,MaterialOwner,OrderDate,OrderTime,StartDate,EndDate,StartCounter,StopCounter,DeliverDate,wastedNumber,TotalProductWeight,CoinageNumber,ExperimentLevel,OperatorName,Comments,CastFormatDelivered,Purser,WaistedWeight,WaistedPercent) 
                           values ( {0}, {1}, {2}, {3}, {4},'{5}', {6}, '{7}', '{8}', '{9}','{10}', '{11}', '{12}',{13}, {14}, '{15}', {16}, {17}, {18}, '{19}','{20}', '{21}', '{22}','{23}',{24},{25} ) ";
             sql = string.Format(sql, this.ProductCode, this.CustomerCode, this.ProductionCode, this.NumberofOrder, this.MaterialAmount, this.Color, this.ColorAmount, this.ColorOwner, this.MaterialOwner, this.OrderDate, this.OrderTime, this.StartDate, this.EndDate, this.StartCounter, this.StopCounter, this.DeliverDate, this.wastedNumber, this.TotalProductWeight, this.CoinageNumber, this.ExperimentLevel, this.OperatorName, this.Comments, this.CastFormatDelivered, this.Purser, this.WaistedWeight, this.WaistedPercent);
             
           

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }

        public bool DeleteById()
        {
            //bool result = true;
            string sql = "delete from Orders where ID={0} ";
            sql = string.Format(sql, this.Id);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }


        public bool GetOne()
        {
            //bool result = true;

            string sql = "select * from Orders where ID={0}";
            sql = string.Format(sql, this.Id);
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return false; };
            md.DisConnect();


            this.ProductCode = Convert.ToInt64(dt.Rows[0]["ProductCode"]);
            this.CustomerCode = Convert.ToInt64(dt.Rows[0]["CustomerCode"].ToString());
            this.ProductionCode = Convert.ToInt64(dt.Rows[0]["ProductionCode"].ToString());
            this.NumberofOrder = Convert.ToInt32(dt.Rows[0]["NumberofOrder"].ToString());
            this.MaterialAmount = Convert.ToSingle(dt.Rows[0]["MaterialAmount"].ToString());
            this.Color = dt.Rows[0]["Colorc"].ToString();
            this.ColorAmount = Convert.ToSingle( dt.Rows[0]["ColorAmount"].ToString());
            this.ColorOwner = dt.Rows[0]["ColorOwner"].ToString();
            this.MaterialOwner = dt.Rows[0]["MaterialOwner"].ToString();
            this.OrderDate = dt.Rows[0]["OrderDate"].ToString();
            this.OrderTime = dt.Rows[0]["OrderTime"].ToString();
            this.StartDate = dt.Rows[0]["StartDate"].ToString();
            this.EndDate = dt.Rows[0]["EndDate"].ToString();
            this.StartCounter = Convert.ToInt64(dt.Rows[0]["StartCounter"].ToString());
            this.StopCounter = Convert.ToInt64(dt.Rows[0]["StopCounter"].ToString());
            this.DeliverDate = dt.Rows[0]["DeliverDate"].ToString();
            this.wastedNumber = Convert.ToInt32(dt.Rows[0]["wastedNumber"].ToString());
            this.WaistedWeight = Convert.ToSingle(dt.Rows[0]["WaistedWeight"].ToString());
            this.WaistedPercent = Convert.ToSingle(dt.Rows[0]["WaistedPercent"].ToString());
            this.TotalProductWeight = Convert.ToSingle(dt.Rows[0]["TotalProductWeight"].ToString());
            this.CoinageNumber = Convert.ToInt32(dt.Rows[0]["CoinageNumber"].ToString());
            this.ExperimentLevel = dt.Rows[0]["ExperimentLevel"].ToString();
            this.OperatorName = dt.Rows[0]["OperatorName"].ToString();
            this.Comments = dt.Rows[0]["Comments"].ToString();
            this.CastFormatDelivered = Convert.ToBoolean(dt.Rows[0]["CastFormatDelivered"].ToString());
            this.Purser = dt.Rows[0]["Purser"].ToString();            

            return true;
        }

        public DataTable Select3Condition(string parameter1, string parameter2, string parameter3, string value1, string value2, string value3)
        {
            string sql = "select * from Orders ";
            sql= md.Select3Condition_Tx_Tx_Lng(sql, parameter1, parameter2, parameter3, value1, value2, value3);
            //sql += " ORDER BY ProductCode";
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql); 
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();           

            return dt;
        }

        public DataTable Select3ConditionJoinedCustomer(string parameter1, string parameter2, string parameter3, string value1, string value2, string value3)
        {


            string sql;
           sql = @"SELECT Orders.ID as ID,Product.Name as ProductName,(Customer.Name+' '+ Customer.Family) as CustomerName,Orders.ProductionCode as ProductionCode,Orders.OrderDate as OrderDate, Orders.NumberofOrder as NumberofOrder
                            FROM ( Orders INNER JOIN Customer 
                            ON Orders.CustomerCode = Customer.ID )
                            INNER JOIN Product 
                            ON Orders.ProductCode = Product.ID ";
            sql = md.Select3Condition_Tx_Tx_Lng(sql, parameter1, parameter2, parameter3, value1, value2, value3);
            sql += " ORDER BY Product.Name,Customer.Family,Customer.Name ";

            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }

       
        
    }
}
