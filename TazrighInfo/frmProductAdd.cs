using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmProductAdd : Form
    {
        Product Pc = null;
        public frmProductAdd()
        {
            InitializeComponent();
        }

        private void frmProductAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {

                Pc = new Product();
                Pc.Name = txtName.Text;

                if (!Pc.Insert()) { MessageBox.Show(Pc.ErrorMessage); return; };

                string msg = "ثبت قطعه {0}  با موفقيت انجام پذيرفت";
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
