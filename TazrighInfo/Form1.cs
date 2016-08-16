using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using AppVerification;

namespace TazrighInfo
{
    public partial class frmMain : Form
    {
        //public static string strConnectionString="";// = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\TazrighDB\Tazrigh.accdb";
        public static bool isFormOpen=false;
        public static long UserID = 0;
        public static string UserName = "";

        public frmMain()
        {
            InitializeComponent();
            isFormOpen = false;
                      
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            CAppVerification appVerify = new CAppVerification();

            // get Registery Info
            appVerify.SetAppProperties("Tazrigh", "V1");
            bool isVerified = appVerify.isVerified();
            if (isVerified == false)
            {
                MessageBox.Show(" برنامه بدرستي نصب نشده است ");
                this.Close();
            };

            //get Connection String and assign it
            DataAccess.ConnectionString = appVerify.GetEncodedConnectionString();           

            //authentication
            frmUserPass frmUsPas = new frmUserPass();
            frmUsPas.ShowDialog();

            if (UserID == 0)
            {
                this.Close();
            }

            if (UserID == 1)  // منوي مديريت كاربران تنها توسط كاربر ادمين با كد 1 فعال است
                manageUsersmenuitemToolStripMenuItem.Enabled = true;
            else
                manageUsersmenuitemToolStripMenuItem.Enabled = false;

        }
              

       

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmRegisterInjectionInfo = new Form2();
                frmRegisterInjectionInfo.MdiParent = this;

                isFormOpen = true;
                frmRegisterInjectionInfo.Show();
            }  

        }
                

        private void customerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmRegisterAddCustomer = new AddCustomerForm();
                frmRegisterAddCustomer.MdiParent = this;

                isFormOpen = true;
                frmRegisterAddCustomer.Show();
            }  

        }

        private void اToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmSearchCustomer = new SearchCustomer();
                frmSearchCustomer.MdiParent = this;

                isFormOpen = true;
                frmSearchCustomer.Show();
            }  

        }

        

        private void addCastMnuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmAddCastFormat();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            }  

        }

        private void searchCastMnuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmSearchCastFormat();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            } 

        }

        private void addMachineMnuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmMachineAdd();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            } 

        }

        private void searchMachineMnuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmMachineSearch();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            } 

        }

        
        private void searchEditProductItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmProductSearch();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            } 

        }

        private void addProductItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmProductAdd();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            } 

        }

        private void searchProductionMnuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmProductionSearch();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            } 

        }

        private void addProductionMnuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmProductionAdd();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            } 

        }

        private void searchEditOrderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmOrderSearch();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            } 
        }

        private void addOrderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmOrderAdd();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            } 

        }

        private void truncateTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmAC = new frmTruncateTables();
                frmAC.MdiParent = this;

                isFormOpen = true;
                frmAC.Show();
            } 

        }

       

        private void managementDatabaseMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmMD = new frmManageDatabase();
                frmMD.MdiParent = this;

                isFormOpen = true;
                frmMD.Show();
            } 

        }

        private void changePasswordmenuitemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormOpen == false)
            {
                Form frmMD = new frmChangePassword();
                frmMD.MdiParent = this;

                isFormOpen = true;
                frmMD.Show();
            } 

        }

       
    }
}
