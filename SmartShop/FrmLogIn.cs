using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShop
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp frm = new FrmSignUp();
            frm.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text.ToString();
            String password = txtPassword.Text.ToString();

            var context = Db.getInstance();

            User user = context.Users.FirstOrDefault(u => u.user1 == username);
            if(user == null)
            {
                MessageBox.Show("User not found!");
                return;
            }
            if(user.pass == password)
            {
                MessageBox.Show("Login successfull!");

                int access = user.access;
                if(access == 0)
                {
                    frmAdminMenu frm = new frmAdminMenu();
                    frm.ShowDialog();
                }
                    
                //else if (access == 1)

                //else 
            } else
            {
                MessageBox.Show("Password is not correct!");
            }
        }
    }
}
