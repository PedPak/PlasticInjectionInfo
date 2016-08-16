using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmProductEdit : Form
    {
        Product Pc = null;
        public long IdEdit;

        public frmProductEdit()
        {
            InitializeComponent();
            IdEdit = 0;
        }

        private void frmProductEdit_Load(object sender, EventArgs e)
        {
            Pc = new Product();
            Pc.Id = IdEdit;

            if (!Pc.GetOne()) { MessageBox.Show(Pc.ErrorMessage); return; };
            txtName.Text = Pc.Name;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آيا مايل به ذخيره تغييرات هستيد", "ذخيره سازي", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Pc.Name = txtName.Text;

                if (!Pc.Update()) { MessageBox.Show(Pc.ErrorMessage); return; };

                this.Close();
            }       

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آيا مايل به حذف ركورد هستيد", "حذف", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (!Pc.DeleteById()) { MessageBox.Show(Pc.ErrorMessage); return; };
                this.Close();
            }

        }

        
    }
}
