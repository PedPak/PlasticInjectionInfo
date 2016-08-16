using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace TazrighInfo
{
    class DataAccess
    {

        public static string ConnectionString = "";
        // Access Database
         /*OleDbConnection conn = null;
         OleDbCommand cmd = null;
         OleDbDataAdapter da = null;*/


        // SQL Server or Express Database
         SqlConnection conn = null;
         SqlCommand cmd = null;
         SqlDataAdapter da = null;

        public string ErrorMessage="";

        public DataAccess()
        {
            // Access Database
           /* conn = new OleDbConnection();
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter();*/


            // SQL Server or Express Database
            conn = new SqlConnection();
            cmd = new SqlCommand();
            da = new SqlDataAdapter();

            cmd.Connection = conn;
            da.SelectCommand = cmd;
        }

        public bool Connect()
        {
            bool result = false;
            try
            {
                conn.ConnectionString = ConnectionString;
                conn.Open();
                result = true;
            }
            catch(Exception ex)
            {
                ErrorMessage = ex.Message;
                ErrorMessage += "\n";
                ErrorMessage += "خطا در اتصال به بانك اطلاعاتي";
            }
            return result;
        }

        public void DisConnect()
        {
            conn.Close();
        }


        public DataTable Select(string strSql)
        {
            DataTable dt = null;
            try
            {
                dt = new DataTable();
                cmd.CommandText = strSql;
                da.Fill(dt);                
            }
            catch (Exception ex)
            {
                //ErrorMessage = ex.Message;
                ErrorMessage = "خطاي خواندن اطلاعات از بانك اطلاعاتي";
            }     
            
            return dt;
        }

        // n Conditions  (all are test) Text,Text,Text,....
        public string Select3Condition(string strSql,string parameter1,string parameter2,string parameter3,string value1,string value2,string value3)
        {
            string resault= "";

            if (value1 != "" || value2 != "" || value3 != "")
            {
                bool passedFirstCondition = false;

                strSql += "where ";

                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter1, value1);
                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter2, value2);
                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter3, value3);
            }
            resault = strSql;
            return resault;           
          
        }

        public string Select4Condition(string strSql, string parameter1, string parameter2, string parameter3, string parameter4, string value1, string value2, string value3, string value4)
        {
            string resault = "";

            if (value1 != "" || value2 != "" || value3 != "" || value4 != "")
            {
                bool passedFirstCondition = false;

                strSql += "where ";

                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter1, value1);
                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter2, value2);
                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter3, value3);
                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter4, value4);
            }

            resault = strSql;
            return resault; 
           
        }
        
        public string Select5Condition(string strSql, string parameter1, string parameter2, string parameter3, string parameter4, string parameter5, string value1, string value2, string value3, string value4, string value5)
        {
            string resault = "";

            if (value1 != "" || value2 != "" || value3 != "" || value4 != "" || value5 != "")
            {
                bool passedFirstCondition = false;

                strSql += "where ";

                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter1, value1);
                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter2, value2);
                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter3, value3);
                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter4, value4);
                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter5, value5);
            }

            resault = strSql;
            return resault; 
            
        }

        // 3 conditions  Text,Text,Long
        public string Select3Condition_Tx_Tx_Lng(string strSql, string parameter1, string parameter2, string parameter3, string value1, string value2, string value3)
        {
            string resault = "";

            if (value1 != "" || value2 != "" || value3 != "")
            {
                bool passedFirstCondition = false;

                strSql += "where ";

                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter1, value1);
                ConditionStringMaker(ref strSql, ref passedFirstCondition, parameter2, value2);
                ConditionLongNumberMaker(ref strSql, ref passedFirstCondition, parameter3, value3);
            }

            resault = strSql;
            return resault;
        }


        public bool doCommand(string strSql)
        {
            bool result = false;
            try
            {
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                //ErrorMessage = "خطاي نوشتن اطلاعات در بانك اطلاعاتي";
            }
            return result;
           
        }

        private bool ConditionStringMaker(ref string strSource, ref bool passedFirstCondition, string parameter, string strValue)
        {
           
            bool resualt = false;

            if (strValue != "")
            {
                resualt = true;
                if (passedFirstCondition)
                {
                    strSource += "and  ";

                }
                else
                {
                    passedFirstCondition = true;
                }

                strSource += parameter;
                strSource += " like '%{0}%'";
                strSource = String.Format(strSource, strValue);
            }
            return resualt;

        }

        private bool ConditionLongNumberMaker(ref string strSource, ref bool passedFirstCondition, string parameter, string LngValue)
        {
            
            bool resualt = false;

            if (LngValue != "")
            {

                resualt = true;
                long value = Convert.ToInt64(LngValue);

                if (passedFirstCondition)
                {
                    strSource += "and  ";

                }
                else
                {
                    passedFirstCondition = true;
                }

                strSource += parameter;
                strSource += " = {0} ";
                strSource = String.Format(strSource, value);
            }
            return resualt;

        }


        public bool doTruncateTableSQL(string TableName)
        {         

            string sql = "truncate table {0}";
            sql = string.Format(sql, TableName);

            if (!Connect()) { return false; };
            if (!doCommand(sql)) { return false; };

            DisConnect();
            return true;
        }

        private bool doTruncateTableACCESS(string TableName)
        {          

            string sql = "delete from {0}";
            sql = string.Format(sql, TableName);

            if (!Connect()) {return false; };
            if (!doCommand(sql)) {  return false; };

            sql = "ALTER TABLE {0} ALTER Column ID INT";
            sql = string.Format(sql, TableName);
            if (!doCommand(sql)) {  return false; };

            sql = "ALTER TABLE {0} ALTER Column ID AUTOINCREMENT";
            sql = string.Format(sql, TableName);
            if (!doCommand(sql)) {  return false; };

            DisConnect();
            return true;
        }

        public bool doBackUpSQL(string databaseName,string backupname)
        {

            //string sql = @"backup database {0} to DISK='{1}' with compression";  // with compression is not defiend in Express version of SQL
            string sql = @"backup database {0} to DISK='{1}'";
            sql = string.Format(sql, databaseName,backupname);

            if (!Connect()) { return false; };
            if (!doCommand(sql)) { return false; };

            DisConnect();
            return true;
        }

    
    }


}
