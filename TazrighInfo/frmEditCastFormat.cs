using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmEditCastFormat : Form
    {
        CastFormat Cf = null;
        public long IdEdit;

        public frmEditCastFormat()
        {
            InitializeComponent();
            IdEdit = 0;
        }

        private void frmEditCastFormat_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            Cf = new CastFormat();
            Cf.Id = IdEdit;
            
            if (!Cf.GetOne()) { MessageBox.Show(Cf.ErrorMessage); return; };            

            txtName.Text = Cf.Name;
            txtBuilder.Text = Cf.Builder;
            txtVenterNumber.Text = Cf.VenterNumber.ToString();

            // ComboBox
            Customer Cs = new Customer();           
            DataTable dt = Cs.GetNamesAll();

            if (dt == null) { MessageBox.Show(Cf.ErrorMessage); return; };

            cbOwnerName.DisplayMember = "FullName";
            cbOwnerName.ValueMember = "ID";
            cbOwnerName.DataSource = dt;
            cbOwnerName.SelectedValue = Cf.OwnerCode;
                        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آيا مايل به ذخيره تغييرات هستيد", "ذخيره سازي", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Cf.Name = txtName.Text;
                Cf.Builder = txtBuilder.Text;
                Cf.VenterNumber = Convert.ToInt32(txtVenterNumber.Text);
                Cf.OwnerCode = Convert.ToInt64(cbOwnerName.SelectedValue);                

                if (!Cf.Update()) { MessageBox.Show(Cf.ErrorMessage); return; };

                this.Close();
            }    

        }
    }
}
