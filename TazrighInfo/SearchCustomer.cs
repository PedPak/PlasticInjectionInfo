using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;

namespace TazrighInfo
{
    public partial class SearchCustomer : Form
    {
        /*OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataAdapter da = null;*/
        DataTable dt = null;
        Customer Cs = null;
        

        public SearchCustomer()
        {
            InitializeComponent();

            /*conn = new OleDbConnection();
            cmd = new OleDbCommand();
            da = new OleDbDataAdapter();*/            
            dt = new DataTable();
        }

        private void SearchCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void SearchCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }
        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            dgwShowResult.ReadOnly = true;
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string sqlCommand = "";
            dt.Clear();
            
            Cs = new Customer();
            dt = Cs.Select3Condition("Name", "Family", "CellPhone", txtName.Text, txtFamily.Text, txtCellPhone.Text);

            if (dt == null) { MessageBox.Show(Cs.ErrorMessage); return; };


            /*sqlCommand = "select ID AS شناسه, Name AS نام, Family AS [نام خانوادگي],CellPhone AS [شماره همراه],Phone AS [تلفن ثابت],Address AS آدرس from Customer ";
            if (txtName.Text != "" || txtFamily.Text != "" || txtCellPhone.Text != "")
            {
                bool passedFirstCondition = false;

                sqlCommand += "where ";

                ConditionStringMaker(ref sqlCommand, ref passedFirstCondition, "Name", txtName.Text);
                ConditionStringMaker(ref sqlCommand, ref passedFirstCondition, "Family", txtFamily.Text);

                ConditionStringMaker(ref sqlCommand, ref passedFirstCondition, "CellPhone", txtCellPhone.Text);
            }


            conn.ConnectionString = frmMain.strConnectionString;
            conn.Open();

            cmd.Connection = conn;
            da.SelectCommand = cmd;

            cmd.CommandText = sqlCommand;
            da.Fill(dt);

            conn.Close();*/
            dgwShowResult.DataSource = dt;    

        }

       /* private bool ConditionStringMaker(ref string strSource, ref bool passedFirstCondition, string parameter, string strValue)
        {
            //string StrResult = strSource;
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

        }*/

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwShowResult.CurrentRow == null)
                return;
            
            long IdEdit= Convert.ToInt64(dgwShowResult.CurrentRow.Cells[0].Value);

            EditCustomerForm frmEditCustomer = new EditCustomerForm();
            //frmEditCustomer.MdiParent = this;
            frmEditCustomer.IdEdit = IdEdit;


            frmEditCustomer.ShowDialog();

            btnSearch_Click(null, null);
            //dgwShowResult.Refresh();
            
        }

        


      
        
    }
}
