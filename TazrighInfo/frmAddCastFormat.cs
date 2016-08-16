using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmAddCastFormat : Form
    {
        CastFormat Cf = null;
        Customer Cs = null;

        public frmAddCastFormat()
        {
            InitializeComponent();
        }

        private void frmAddCastFormat_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void frmAddCastFormat_Load(object sender, EventArgs e)
        {
            Cs = new Customer();
            DataTable dt = Cs.GetNamesAll();

            cbOwnerName.DisplayMember = "FullName";
            cbOwnerName.ValueMember = "ID";
            cbOwnerName.DataSource = dt;          

        }        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {

                Cf = new CastFormat();
                Cf.Name = txtName.Text; Cf.Builder = txtBuilder.Text;
                Cf.VenterNumber = Convert.ToInt32(txtVenterNumber.Text);
                Cf.OwnerCode = Convert.ToInt64(cbOwnerName.SelectedValue);

                if (!Cf.Insert()) { MessageBox.Show(Cf.ErrorMessage); return; };

                string msg = "ثبت قالب {0}  با موفقيت انجام پذيرفت";
                lblMsg.Text = string.Format(msg, txtName.Text);
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show(" نام قالب بايد تعيين گردد ");
            } 

           

        }

        private void ClearTextBoxes()
        {
            txtName.Text = ""; txtBuilder.Text = ""; txtVenterNumber.Text = "";      

        }
    }
}
