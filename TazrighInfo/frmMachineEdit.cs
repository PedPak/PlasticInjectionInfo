using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmMachineEdit : Form
    {
        Machine Mc = null;
        public long IdEdit;

        public frmMachineEdit()
        {
            InitializeComponent();
            IdEdit = 0;
        }

        private void frmMachineEdit_Load(object sender, EventArgs e)
        {
            Mc = new Machine();
            Mc.Id = IdEdit;

            if (!Mc.GetOne()) { MessageBox.Show(Mc.ErrorMessage); return; };
            txtName.Text = Mc.Name;
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آيا مايل به ذخيره تغييرات هستيد", "ذخيره سازي", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Mc.Name = txtName.Text;

                if (!Mc.Update()) { MessageBox.Show(Mc.ErrorMessage); return; };

                this.Close();
            }       

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آيا مايل به حذف ركورد هستيد", "حذف", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (!Mc.DeleteById()) { MessageBox.Show(Mc.ErrorMessage); return; };
                this.Close();
            }

        }

        
    }
}
