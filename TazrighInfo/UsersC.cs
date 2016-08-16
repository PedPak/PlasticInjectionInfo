using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace TazrighInfo
{
    class UsersC
    {
        public long Id = 0;
        public string uUserName="";
        public string uPassword="";
        public string UserRole="";

        public string ErrorMessage = "";
        DataAccess md;        

        public UsersC()
        {
            md=new DataAccess();
        }

        public bool Update()
        {
            //bool result=true;
            string sql = "Update Users set uUserName='{0}',uPassword='{1}' where ID={2}";
            sql = string.Format(sql, this.uUserName,this.uPassword, this.Id);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;

        }

        public bool UpdatePassById(string PassW)
        {
            //bool result=true;

            this.uPassword = AppVerification.CAppVerification.Hash256(PassW);

            string sql = "Update Users set uPassword='{0}' where ID={1}";
            sql = string.Format(sql,  this.uPassword, this.Id);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;

        }

        public bool Insert()
        {
            //bool result = true;
            string sql = "insert into Users (uUserName,uPassword,UserRole) values ( '{0}','{1}','{2}' ) ";


            sql = string.Format(sql, this.uUserName, this.uPassword, this.UserRole);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }

        public bool DeleteById()
        {
            string sql = "delete from Users where ID={0} ";
            sql = string.Format(sql, this.Id);

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            if (!md.doCommand(sql)) { ErrorMessage = md.ErrorMessage; return false; };

            md.DisConnect();
            return true;
        }

        public bool GetOne()
        {
            //bool result = true;

            string sql = "select * from Users where ID={0}";
            sql = string.Format(sql, this.Id);
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return false; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return false; };
            md.DisConnect();

            this.uUserName = dt.Rows[0]["uUserName"].ToString();
            this.uPassword = dt.Rows[0]["uPassword"].ToString();
            this.uPassword = dt.Rows[0]["UserRole"].ToString();

            return true;
        }

        public DataTable Select1Condition(string parameter1, string value1)
        {
            string sql = "select ID , uUserName,uPassword  from Users ";
            sql=md.Select3Condition(sql, parameter1, "", "", value1, "", "");
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }

        public DataTable GetAllUsers()
        {
            string sql = "select ID , uUserName,uPassword,UserRole from Users ";
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return dt; };
            dt = md.Select(sql);
            if (dt == null) { ErrorMessage = md.ErrorMessage; return dt; };
            md.DisConnect();

            return dt;
        }

        private void Hash(string UserN, string PassW)
        {
            this.uUserName = AppVerification.CAppVerification.Hash256(UserN);
            this.uPassword = AppVerification.CAppVerification.Hash256(PassW);            
        }

        private long IsValidUserPass()
        {
           // long result = 0; // no One

            string sql = "select ID from Users where uUserName='{0}' and uPassword='{1}' ";
            sql = string.Format(sql, this.uUserName, this.uPassword);
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return 0; };
            dt = md.Select(sql);
            if (dt == null || dt.Rows.Count<=0) { ErrorMessage = md.ErrorMessage; return 0; };
            md.DisConnect();

            return ( Convert.ToInt64(dt.Rows[0]["ID"]) );
        }

        public long CheckUsernamePassword(string UserN, string PassW)
        {
            long ID = 0;// No one

            Hash(UserN, PassW);
            ID = IsValidUserPass();

            return ID;
        }

        private string IsValidPassById()
        {
            // long result = 0; // no One

            string sql = "select uPassword from Users where ID='{0}'  ";
            sql = string.Format(sql, this.Id);
            DataTable dt = null;

            if (!md.Connect()) { ErrorMessage = md.ErrorMessage; return ""; };
            dt = md.Select(sql);
            if (dt == null || dt.Rows.Count <= 0) { ErrorMessage = md.ErrorMessage; return ""; };
            md.DisConnect();

            return (dt.Rows[0]["uPassword"].ToString() );
        }

        public bool CheckPasswordById(long uId, string PassW)
        {
            this.Id = uId;
            string HashedPassW=AppVerification.CAppVerification.Hash256(PassW); 
            string RealHashedPassW = IsValidPassById();
            if (HashedPassW == RealHashedPassW)
                return true;

            return false;
        }


    }
}
