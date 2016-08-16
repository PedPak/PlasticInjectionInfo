using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace TazrighInfo
{
    class Product
    {
        public long Id;
        public string Name;

        public string ErrorMessage = "";
        DataAccess md;

        public Product()
        {
            md=new DataAccess();
        }

        public bool Update()
        {
            //bool result=true;
            string sql = "Update Product set Name='{0}' where ID={1}";
            sql = string.Format(sql, this.Name, this.Id);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;

        }

        public bool Insert()
        {
            //bool result = true;
            string sql = "insert into Product (Name) values ( '{0}' ) ";
            sql = string.Format(sql, this.Name);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }

        public bool DeleteById()
        {
            string sql = "delete from Product where ID={0} ";
            sql = string.Format(sql, this.Id);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }

        public bool GetOne()
        {
            //bool result = true;

            string sql = "select * from Product where ID={0}";
            sql = string.Format(sql, this.Id);
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return false; };
            md.DisConnect();

            this.Name = dt.Rows[0]["Name"].ToString();         

            return true;
        }

        public DataTable Select1Condition(string parameter1,  string value1)
        {
            string sql = "select ID , Name  from Product ";
            sql = md.Select3Condition(sql, parameter1, "", "", value1, "", "");
            sql+=" ORDER BY Name ";
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }

        public DataTable GetNamesAll()
        {
            string sql = "select ID , Name from Product  ORDER BY Name";
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }

        public DataTable GetNameById()
        {
            string sql = "select ID , Name from Product where ID={0}";
            sql = string.Format(sql, this.Id);
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }       
    }
}
