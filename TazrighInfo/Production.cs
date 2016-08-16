using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace TazrighInfo
{
    class Production
    {
        public long Id = 0;
        public long ProductCode = 0;
        public long CastCode = 0;
        public long MachineCode = 0;
        public string Material = "";
        public Single CoiningWeight = 0;
        public Single InjectionTime = 0;
        public Single WaitTimeAfterInjection = 0;
        public Single HookWaitTime = 0;
        public Single EjectorTime = 0;
        public int HeadTemperature = 0;
        public int MidTemperature = 0;
        public int BackTemperature = 0;
        public Single FullAutomaticTime = 0;
        public Single IntakeTime = 0;
        public Single HeadCarriageTime = 0;
        public Single BackCarriageTime = 0;
        public Single WaitTimeBeforeEjector = 0;
        public Single WaitTimeBetweenEjectors = 0;
        public int EjectorNumber = 0;
        public Single SecondInjectionPressureTime = 0;
        public Single Pressure = 0;
        public Single WorkingTime = 0;
        public Single TotalTimeforCoining = 0;

        public string ErrorMessage = "";
        DataAccess md;

        public Production()
        {
            md=new DataAccess();
        }

        public bool Update()
        {

            string sql = @"Update Production set ProductCode={0},CastCode={1},MachineCode={2},Material='{3}',CoiningWeight={4},InjectionTime={5},WaitTimeAfterInjection={6},HookWaitTime={7},EjectorTime={8},HeadTemperature={9},
                               MidTemperature={10},BackTemperature={11},FullAutomaticTime={12},IntakeTime={13},HeadCarriageTime={14},BackCarriageTime={15},WaitTimeBeforeEjector={16},WaitTimeBetweenEjectors={17},
                               EjectorNumber={18},SecondInjectionPressureTime={19},Pressure={20},WorkingTime={21},TotalTimeforCoining={22}                             
                             where ID={23}";
            sql = string.Format(sql, this.ProductCode, this.CastCode, this.MachineCode, this.Material, this.CoiningWeight, this.InjectionTime, this.WaitTimeAfterInjection, this.HookWaitTime, this.EjectorTime, this.HeadTemperature, this.MidTemperature, this.BackTemperature, this.FullAutomaticTime, this.IntakeTime, this.HeadCarriageTime, this.BackCarriageTime, this.WaitTimeBeforeEjector, this.WaitTimeBetweenEjectors, this.EjectorNumber, this.SecondInjectionPressureTime, this.Pressure, this.WorkingTime, this.TotalTimeforCoining,this.Id);
            
            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;

        }

        public bool Insert()
        {

            string sql = @"insert into Production (ProductCode,CastCode,MachineCode,Material,CoiningWeight,InjectionTime,WaitTimeAfterInjection,HookWaitTime,EjectorTime,HeadTemperature,MidTemperature,BackTemperature,FullAutomaticTime,IntakeTime,HeadCarriageTime,BackCarriageTime,WaitTimeBeforeEjector,WaitTimeBetweenEjectors,EjectorNumber,SecondInjectionPressureTime,Pressure,WorkingTime,TotalTimeforCoining)
                           values ( {0}, {1}, {2}, '{3}', {4},{5}, {6}, {7}, {8}, {9},{10}, {11}, {12},{13}, {14}, {15}, {16}, {17}, {18}, {19},{20}, {21}, {22} ) ";
            sql = string.Format(sql, this.ProductCode, this.CastCode, this.MachineCode, this.Material, this.CoiningWeight, this.InjectionTime, this.WaitTimeAfterInjection, this.HookWaitTime, this.EjectorTime, this.HeadTemperature, this.MidTemperature, this.BackTemperature, this.FullAutomaticTime, this.IntakeTime, this.HeadCarriageTime, this.BackCarriageTime, this.WaitTimeBeforeEjector, this.WaitTimeBetweenEjectors, this.EjectorNumber, this.SecondInjectionPressureTime, this.Pressure, this.WorkingTime, this.TotalTimeforCoining);
            
            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }

        public bool DeleteById()
        {
            //bool result = true;
            string sql = "delete from Production where ID={0} ";
            sql = string.Format(sql, this.Id);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }


        public bool GetOne()
        {
            //bool result = true;

            string sql = "select * from Production where ID={0}";
            sql = string.Format(sql, this.Id);
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return false; };
            md.DisConnect();
                        
            this.ProductCode = Convert.ToInt64(dt.Rows[0]["ProductCode"]);
            this.CastCode = Convert.ToInt64(dt.Rows[0]["CastCode"].ToString());
            this.MachineCode = Convert.ToInt64(dt.Rows[0]["MachineCode"].ToString());
            this.Material = dt.Rows[0]["Material"].ToString();
            this.CoiningWeight = Convert.ToSingle(dt.Rows[0]["CoiningWeight"].ToString());
            this.InjectionTime = Convert.ToSingle(dt.Rows[0]["InjectionTime"].ToString());
            this.WaitTimeAfterInjection = Convert.ToSingle(dt.Rows[0]["WaitTimeAfterInjection"]);
            this.HookWaitTime = Convert.ToSingle(dt.Rows[0]["HookWaitTime"].ToString());
            this.EjectorTime = Convert.ToSingle(dt.Rows[0]["EjectorTime"].ToString());
            this.HeadTemperature = Convert.ToInt32(dt.Rows[0]["HeadTemperature"].ToString());
            this.MidTemperature = Convert.ToInt32(dt.Rows[0]["MidTemperature"].ToString());
            this.BackTemperature = Convert.ToInt32(dt.Rows[0]["BackTemperature"]);
            this.FullAutomaticTime = Convert.ToSingle(dt.Rows[0]["FullAutomaticTime"].ToString());
            this.IntakeTime = Convert.ToSingle(dt.Rows[0]["IntakeTime"].ToString());
            this.HeadCarriageTime = Convert.ToSingle(dt.Rows[0]["HeadCarriageTime"].ToString());
            this.BackCarriageTime = Convert.ToSingle(dt.Rows[0]["BackCarriageTime"].ToString());
            this.WaitTimeBeforeEjector = Convert.ToSingle(dt.Rows[0]["WaitTimeBeforeEjector"]);
            this.WaitTimeBetweenEjectors = Convert.ToSingle(dt.Rows[0]["WaitTimeBetweenEjectors"].ToString());
            this.EjectorNumber = Convert.ToInt32(dt.Rows[0]["EjectorNumber"].ToString());
            this.SecondInjectionPressureTime = Convert.ToSingle(dt.Rows[0]["SecondInjectionPressureTime"].ToString());
            this.Pressure = Convert.ToSingle(dt.Rows[0]["Pressure"].ToString());
            this.WorkingTime = Convert.ToSingle(dt.Rows[0]["WorkingTime"].ToString());
            this.TotalTimeforCoining = Convert.ToSingle(dt.Rows[0]["TotalTimeforCoining"].ToString());        
            
            

            return true;
        }

        public DataTable Select4ConditionJoined(string parameter1, string parameter2, string parameter3, string parameter4, string value1, string value2, string value3, string value4)
        {


            string sql;
            sql = @"SELECT  Production.ID as ID, Product.Name as ProductName, CastFormat.Name as CastFormatName, Machine.Name as MachineName, Production.Material as Material,Production.CoiningWeight as CoiningWeight
                            FROM ( (Production INNER JOIN CastFormat 
                                          ON Production.CastCode = CastFormat.ID )      
                                   INNER JOIN Machine 
                                   ON Production.MachineCode = Machine.ID  )
                            INNER JOIN Product 
                            ON Production.ProductCode = Product.ID ";
            sql= md.Select4Condition(sql, parameter1, parameter2, parameter3, parameter4, value1, value2, value3, value4);
            sql+=" ORDER BY Product.Name,CastFormat.Name, Machine.Name ";

            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }

        public DataTable Select3ConditionNumberedJoined(string parameter1, string parameter2, string parameter3, string value1, string value2, string value3)
        {

            string sql;
            sql = @"SELECT  Production.ID as ID, Product.Name as ProductName, CastFormat.Name as CastFormatName, Machine.Name as MachineName, Production.Material as Material,Production.CoiningWeight as CoiningWeight
                            FROM ( (Production INNER JOIN CastFormat 
                                          ON Production.CastCode = CastFormat.ID )      
                                   INNER JOIN Machine 
                                   ON Production.MachineCode = Machine.ID  )
                            INNER JOIN Product 
                            ON Production.ProductCode = Product.ID ";
            sql = md.Select3Condition_Tx_Tx_Lng(sql, parameter1, parameter2, parameter3, value1, value2, value3);
            sql+=" ORDER BY Product.Name,CastFormat.Name, Machine.Name ";

            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }
        
        
    }
}
