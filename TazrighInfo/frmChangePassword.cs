using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TazrighInfo
{
    public partial class frmChangePassword : Form
    {
        long UserId = 0;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.isFormOpen = false;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = frmMain.UserName;
            UserId = frmMain.UserID;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            UsersC usr = new UsersC();
            usr.Id = UserId;

            txtUserName.Text = txtUserName.Text.Trim();
            txtOldPassword.Text = txtOldPassword.Text.Trim();
            
            if (! usr.CheckPasswordById(UserId, txtOldPassword.Text))
            {
                MessageBox.Show(" نام كاربر يا كلمه عبور قبلي اشتباه است ");

                if (usr.ErrorMessage != "") MessageBox.Show(usr.ErrorMessage); // if there is Error in connecting to DataBase
                
                return;
            }

            if (txtNewPassword.Text != txtReNewPassword.Text)
            {
                MessageBox.Show(" كلمه عبور جديد و تكرار آن مطابقت ندارد ");
                return;
            }

            if (!usr.UpdatePassById(txtNewPassword.Text)) { MessageBox.Show(usr.ErrorMessage); return; }
            else { MessageBox.Show("كلمه عبور با موفقيت تغيير يافت"); };

        }
    }
}
