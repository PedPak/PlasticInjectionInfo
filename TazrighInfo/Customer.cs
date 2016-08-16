using System;
using System.Collections.Generic;
using System.Text;

using System.Data;

namespace TazrighInfo
{
    class Customer
    {
        public long Id=0;
        public string Name;
        public string Family;
        public string Cellphone;
        public string Phone;
        public string Address;

        public string ErrorMessage="";
        DataAccess md;

        public Customer(){
            md=new DataAccess();
        }

        public bool Update()
        {
            //bool result=true;
            string sql = "Update Customer set Name='{0}',Family='{1}',CellPhone='{2}',Phone='{3}',Address='{4}' where ID={5}";
            sql = string.Format(sql, this.Name, this.Family, this.Cellphone, this.Phone, this.Address, this.Id);
            
            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };
            
            md.DisConnect();
            return true;

        }

        public bool Insert()
        {
            //bool result = true;
            string sql = "insert into Customer (Name,Family,CellPhone,Phone,Address) values ( '{0}', '{1}', '{2}', '{3}', '{4}' ) ";
            sql = string.Format(sql, this.Name, this.Family, this.Cellphone, this.Phone, this.Address);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }

        public bool DeleteById()
        {
            //bool result = true;
            string sql = "delete from Customer where ID={0} ";
            sql = string.Format(sql, this.Id);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }


        public bool GetOne()
        {
            //bool result = true;
            
            string sql = "select * from Customer where ID={0}";
            sql = string.Format(sql, this.Id);
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return false; };
            md.DisConnect();

            this.Name=dt.Rows[0]["Name"].ToString();
            this.Family = dt.Rows[0]["Family"].ToString();
            this.Cellphone = dt.Rows[0]["CellPhone"].ToString();
            this.Phone = dt.Rows[0]["Phone"].ToString();
            this.Address = dt.Rows[0]["Address"].ToString();  

            return true;
        }

        public DataTable Select3Condition(string parameter1, string parameter2, string parameter3, string value1, string value2, string value3)
        {
            //string sql = "select ID AS شناسه, Name AS نام, Family AS [نام خانوادگي],CellPhone AS [شماره همراه],Phone AS [تلفن ثابت],Address AS آدرس from Customer ";
            string sql = "select ID , Name , Family ,CellPhone ,Phone ,Address from Customer ";           
            sql= md.Select3Condition(sql, parameter1, parameter2, parameter3, value1, value2, value3);
            sql += " ORDER BY Family,Name";
           
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();           

            return dt;
        }

        public DataTable GetNamesAll()
        {
            string sql = "select ID , (Name+' '+ Family) AS FullName from Customer ORDER BY Family,Name ";
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }

        public DataTable GetNamebyId()
        {
            string sql = "select ID , (Name+' '+ Family) AS FullName from Customer where ID={0}";
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
