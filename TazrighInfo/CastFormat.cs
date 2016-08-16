using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace TazrighInfo
{
    class CastFormat
    {
        public long Id = 0;
        public string Name;
        public int VenterNumber;
        public string Builder;
        public long OwnerCode;       

        public string ErrorMessage = "";
        DataAccess md;

        public CastFormat()
        {
            md=new DataAccess();
        }

        public bool Update()
        {
            //bool result=true;
            string sql = "Update CastFormat set Name='{0}',VenterNumber={1},Builder='{2}', OwnerCode={3} where ID={4}";
            sql = string.Format(sql, this.Name, this.VenterNumber, this.Builder, this.OwnerCode, this.Id);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;

        }

        public bool Insert()
        {
            //bool result = true;
            string sql = "insert into CastFormat (Name,VenterNumber,Builder,OwnerCode) values ( '{0}', {1}, '{2}', {3} ) ";
            sql = string.Format(sql, this.Name, this.VenterNumber, this.Builder, this.OwnerCode);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }

        public bool DeleteById()
        {
            //bool result = true;
            string sql = "delete from CastFormat where ID={0} ";
            sql = string.Format(sql, this.Id);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }
        
        public bool GetOne()
        {
            //bool result = true;

            string sql = "select * from CastFormat where ID={0}";
            sql = string.Format(sql, this.Id);
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return false; };
            md.DisConnect();

            this.Name = dt.Rows[0]["Name"].ToString();
            this.VenterNumber = Convert.ToInt32(dt.Rows[0]["VenterNumber"]);
            this.Builder = dt.Rows[0]["Builder"].ToString();
            this.OwnerCode = Convert.ToInt64(dt.Rows[0]["OwnerCode"]);
           

            return true;
        }

        public DataTable GetNamesAll()
        {
            string sql = "select ID , Name from CastFormat ORDER BY Name";
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }

        public DataTable Select3Condition(string parameter1, string parameter2, string parameter3, string value1, string value2, string value3)
        {


            string sql = "select ID AS شناسه, Name AS نام, VenterNumber AS [تعداد بطن],Builder AS [سازنده],OwnerCode AS [كد مشتري] from CastFormat ";
            sql = md.Select3Condition(sql, parameter1, parameter2, parameter3, value1, value2, value3);
            sql += " ORDER BY Name";

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
            sql = @"SELECT CastFormat.ID as ID,CastFormat.Name as Name,CastFormat.VenterNumber as VenterNumber,CastFormat.Builder as Builder,(Customer.Name+' '+ Customer.Family) as FullName 
                            FROM CastFormat INNER JOIN Customer 
                            ON CastFormat.OwnerCode = Customer.ID ";
            sql=md.Select3Condition(sql, parameter1, parameter2, parameter3, value1, value2, value3);
            sql += " ORDER BY CastFormat.Name,Customer.Family,Customer.Name";
            
            DataTable dt = null;            
            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }

    }
}
