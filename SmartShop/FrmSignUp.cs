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
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text.Length == 0 || txtPassword.Text.ToString().Length == 0)
            {
                MessageBox.Show("Please fill the fields!");
            }
            String username = txtUserName.Text.ToString();
            String password = txtPassword.Text.ToString();
            int userType = cbUserType.SelectedIndex;

            var context = Db.getInstance();
            context.Users.Add(new User
            {
                user1 = username,
                pass = password,
                access = userType
            });
            context.SaveChanges();
            MessageBox.Show("Susseccfully Added!");

        }
    }
}
