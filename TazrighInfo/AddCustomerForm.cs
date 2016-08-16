using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//using System.Data.OleDb;

namespace TazrighInfo
{
    public partial class AddCustomerForm : Form
    {      
       
        Customer Cs = null;
     
      

        public AddCustomerForm()
        {
            InitializeComponent();
                 
        }

        private void AddCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void AddCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            
            if (txtFamily.Text != "" )
            {
                
                Cs = new Customer();
                Cs.Name=txtName.Text;Cs.Family= txtFamily.Text; Cs.Cellphone=txtCellPhone.Text; Cs.Phone=txtPhone.Text;Cs.Address= txtAddress.Text;

                if (!Cs.Insert()) { MessageBox.Show(Cs.ErrorMessage); return; };

                string msg = "ثبت مشتري {0} {1} با موفقيت انجام پذيرفت";
                lblMsg.Text = string.Format(msg, txtName.Text, txtFamily.Text);
                ClearTextBoxes();
                
                                
            }else{
                MessageBox.Show(" نام خانوادگي بايد تعيين گردد ");                  
            } 
          
          
        }

        private void ClearTextBoxes()
        {            txtName.Text = ""; txtFamily.Text = ""; txtCellPhone.Text = ""; txtPhone.Text = ""; txtAddress.Text = "";

        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }       
    }
}
