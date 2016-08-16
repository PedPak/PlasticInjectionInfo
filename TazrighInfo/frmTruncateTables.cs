using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmTruncateTables : Form
    {
        string ErrorMessage="";

        public frmTruncateTables()
        {
            InitializeComponent();
        }
        
        private void frmTruncateTables_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            string TableName = "";
            TableName= lbTables.GetItemText(lbTables.SelectedItem);
            DataAccess md = new DataAccess();

            //Access
            //if (!md.doTruncateTableACCESS(TableName)) { MessageBox.Show(md.ErrorMessage); return; };

            //SQL Server
            if (!md.doTruncateTableSQL(TableName)) { MessageBox.Show(md.ErrorMessage); return; };
        }

        

        

        
    }
}
