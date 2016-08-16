using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmProductionSearch : Form
    {
        DataTable dt = null;
        Production Prtn = null;

        public frmProductionSearch()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void frmProductionSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt.Clear();

            Prtn = new Production();

            dt = Prtn.Select4ConditionJoined("Product.Name", "CastFormat.Name", "Machine.Name", "Production.Material", txtProduct.Text, txtCastFormat.Text, txtMachine.Text,txtMaterial.Text);

            if (dt == null) { MessageBox.Show(Prtn.ErrorMessage); return; };

            dgwShowResult.DataSource = dt;  
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwShowResult.CurrentRow == null)
                return;

            long IdEdit = Convert.ToInt64(dgwShowResult.CurrentRow.Cells[0].Value);

            frmProductionEdit frmEdit = new frmProductionEdit();
            //frmEditCustomer.MdiParent = this;
            frmEdit.IdEdit = IdEdit;


            frmEdit.ShowDialog();

            btnSearch_Click(null, null);
        }

        private void btnSearchProductionCode_Click(object sender, EventArgs e)
        {
            dt.Clear();

            Prtn = new Production();

            dt = Prtn.Select3ConditionNumberedJoined("NOP", "NOP", "Production.ID", "", "", txtProductionCode.Text);

            if (dt == null) { MessageBox.Show(Prtn.ErrorMessage); return; };

            dgwShowResult.DataSource = dt;    
        }
    }
}
