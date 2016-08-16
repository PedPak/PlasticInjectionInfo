using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmMachineAdd : Form
    {
        Machine Mc = null;
        public frmMachineAdd()
        {
            InitializeComponent();
        }

        private void frmMachineAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {

                Mc = new Machine();
                Mc.Name = txtName.Text;

                if (!Mc.Insert()) { MessageBox.Show(Mc.ErrorMessage); return; };

                string msg = "ثبت دستگاه {0}  با موفقيت انجام پذيرفت";
                lblMsg.Text = string.Format(msg, txtName.Text);
                ClearTextBoxes();


            }
            else
            {
                MessageBox.Show(" نام دستگاه بايد تعيين گردد ");
            } 

        }

        private void ClearTextBoxes()
        {
            txtName.Text = ""; 

        }

       
    }
}
