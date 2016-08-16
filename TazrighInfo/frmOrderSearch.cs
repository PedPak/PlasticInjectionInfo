using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmOrderSearch : Form
    {
        DataTable dt = null;
        Order Ord = null;

        public frmOrderSearch()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void frmOrderSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void frmOrderSearch_Load(object sender, EventArgs e)
        {
                  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt.Clear();

            Ord = new Order();

            dt = Ord.Select3ConditionJoinedCustomer("Product.Name", "Customer.Family", "Orders.ProductionCode", txtProduct.Text, txtCustomer.Text, txtProductionCode.Text);            

            if (dt == null) { MessageBox.Show(Ord.ErrorMessage); return; };

            dgwShowResult.DataSource = dt;           

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgwShowResult.CurrentRow == null)
                return;

            long IdEdit = Convert.ToInt64(dgwShowResult.CurrentRow.Cells[0].Value);

            frmOrderEdit frmEdit = new frmOrderEdit();
            //frmEditCustomer.MdiParent = this;
            frmEdit.IdEdit = IdEdit;


            frmEdit.ShowDialog();

            btnSearch_Click(null, null);
        }

        private void btnSearchOrderCode_Click(object sender, EventArgs e)
        {
            dt.Clear();

            Ord = new Order();

            dt = Ord.Select3ConditionJoinedCustomer("NOP", "NOP", "Orders.ID", "", "", txtOrderCode.Text);

            if (dt == null) { MessageBox.Show(Ord.ErrorMessage); return; };

            dgwShowResult.DataSource = dt;      

        }

      

        

        
    }
}
