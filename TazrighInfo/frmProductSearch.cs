using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmProductSearch : Form
    {
        Product Pc;
        DataTable dt = null;

        public frmProductSearch()
        {
            InitializeComponent();

            dt = new DataTable();
        }

        private void frmProductSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            dt.Clear();

            Pc = new Product();
            dt = Pc.Select1Condition("Name", txtName.Text);

            if (dt == null) { MessageBox.Show(Pc.ErrorMessage); return; };

            dgwShowResult.DataSource = dt;    

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwShowResult.CurrentRow == null)
                return;

            long IdEdit = Convert.ToInt64(dgwShowResult.CurrentRow.Cells[0].Value);

            frmProductEdit frmEdit = new frmProductEdit();
            //frmEditCustomer.MdiParent = this;
            frmEdit.IdEdit = IdEdit;


            frmEdit.ShowDialog();

            btnSearch_Click(null, null);
        }
    }
}
