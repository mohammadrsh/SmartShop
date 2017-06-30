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
            int dbID = user.id;
                        
            if(user == null)
            {
                MessageBox.Show("User not found!");
                return;
            }
            if(user.pass == password)
            {
                int access = user.access;
                MessageBox.Show("Login successfull!");

                
                if(access == 0)
                {
                    FrmAdminMenu frm = new FrmAdminMenu();
                    frm.dbID = dbID;
                    frm.ShowDialog();
                    
                }
                    
                //else if (access == 1)

                //else 
            } else
            {
                MessageBox.Show("Password is not correct!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void combUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
