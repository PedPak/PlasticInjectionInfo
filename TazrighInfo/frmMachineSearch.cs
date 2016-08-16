using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmMachineSearch : Form
    {
        Machine Mc;
        DataTable dt = null;

        public frmMachineSearch()
        {
            InitializeComponent();
            
            dt = new DataTable();
        }

        private void frmMachineSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt.Clear();

            Mc = new Machine();
            dt = Mc.Select1Condition("Name",  txtName.Text);

            if (dt == null) { MessageBox.Show(Mc.ErrorMessage); return; };
            
            dgwShowResult.DataSource = dt;    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwShowResult.CurrentRow == null)
                return;

            long IdEdit = Convert.ToInt64(dgwShowResult.CurrentRow.Cells[0].Value);

            frmMachineEdit frmEdit = new frmMachineEdit();
            //frmEditCustomer.MdiParent = this;
            frmEdit.IdEdit = IdEdit;


            frmEdit.ShowDialog();

            btnSearch_Click(null, null);
        }
    }
}
