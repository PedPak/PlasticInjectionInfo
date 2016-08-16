using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class EditCustomerForm : Form
    {

        Customer Cs = null;
        public long IdEdit;

        public EditCustomerForm()
        {
            InitializeComponent();
            IdEdit = 0;
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            Cs = new Customer();
            Cs.Id=IdEdit;
            if( !Cs.GetOne()){MessageBox.Show(Cs.ErrorMessage);return;};
            txtName.Text = Cs.Name;
            txtFamily.Text = Cs.Family;
            txtCellPhone.Text = Cs.Cellphone;
            txtPhone.Text = Cs.Phone;
            txtAddress.Text = Cs.Address;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("آيا مايل به ذخيره تغييرات هستيد", "ذخيره سازي", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Cs.Name = txtName.Text;
                Cs.Family = txtFamily.Text;
                Cs.Cellphone = txtCellPhone.Text;
                Cs.Phone = txtPhone.Text;
                Cs.Address = txtAddress.Text;

                if (!Cs.Update()) { MessageBox.Show(Cs.ErrorMessage); return; };

                this.Close();
            }        


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {          
            DialogResult dr = MessageBox.Show("آيا مايل به حذف ركورد هستيد", "حذف", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            { 
                if (!Cs.DeleteById()) { MessageBox.Show(Cs.ErrorMessage); return; };
                this.Close();
            }
            
        }
    }
}
