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
    public partial class FrmAdminMenu : Form
    {
        public FrmAdminMenu()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FrmSignUp frm = new FrmSignUp();
            frm.ShowDialog();
        }
    }
}
