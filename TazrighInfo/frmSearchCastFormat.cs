using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmSearchCastFormat : Form
    {
        DataTable dt = null;
        CastFormat Cf = null;

        public frmSearchCastFormat()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void frmSearchCastFormat_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }
                

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt.Clear();

            Cf = new CastFormat();
            dt = Cf.Select3ConditionJoinedCustomer("CastFormat.Name", "CastFormat.Builder", "Customer.Family", txtName.Text, txtBuilder.Text, txtFamily.Text);

            if (dt == null) { MessageBox.Show(Cf.ErrorMessage); return; };

            dgwShowResult.DataSource = dt;

        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwShowResult.CurrentRow == null)
                return;

            long IdEdit = Convert.ToInt64(dgwShowResult.CurrentRow.Cells[0].Value);

            frmEditCastFormat frmEdit = new frmEditCastFormat();
            //frmEditCustomer.MdiParent = this;
            frmEdit.IdEdit = IdEdit;


            frmEdit.ShowDialog();

            btnSearch_Click(null, null);

        }

        
    }
}
