using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FarsiDate;

namespace TazrighInfo
{
    public partial class frmManageDatabase : Form
    {
        public frmManageDatabase()
        {
            InitializeComponent();
        }

        private void frmManageDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblPath.Text=folderBrowserDialog1.SelectedPath;
        }

        private void btnBackupFull_Click(object sender, EventArgs e)
        {
            //create file name for Backup file
            string filename="BK_";
            string CurrentDate = modDate.FDate_(DateTime.Now); //return date in this format:  yyyy_mm_dd
            DateTime CurrentTime = DateTime.Now;

            filename += CurrentDate + "_" + CurrentTime.Hour.ToString() + "_" + CurrentTime.Minute.ToString();
            filename += ".bak";

            // create path for BackUp;
            string strPath = lblPath.Text +"\\"+ filename;

            //make Backup
            DataAccess md = new DataAccess();
            if (!md.doBackUpSQL("Tazrigh", strPath)) { MessageBox.Show(md.ErrorMessage); return; }
            else { MessageBox.Show("پشتيبان گيري با موفقيت انجام پذيرفت"); };
            
        }
    }
}
