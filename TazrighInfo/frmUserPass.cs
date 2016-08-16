using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmUserPass : Form
    {
        public frmUserPass()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsersC usr=new UsersC();
            long UserId = 0;
            txtUserName.Text=txtUserName.Text.Trim();
            txtPassword.Text = txtPassword.Text.Trim();
            UserId= usr.CheckUsernamePassword(txtUserName.Text, txtPassword.Text);
            if(UserId==0){
                MessageBox.Show(" نام كاربر يا كلمه عبور اشتباه است ");
                
                if (usr.ErrorMessage!="") MessageBox.Show(usr.ErrorMessage); // if there is Error in connecting to DataBase
            }else{
                frmMain.UserID = UserId;
                frmMain.UserName = txtUserName.Text;
                this.Close();
            }           
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
