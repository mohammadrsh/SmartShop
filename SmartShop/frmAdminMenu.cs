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
        public  int dbID = 0;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FrmSignUp frm = new FrmSignUp();
            frm.ShowDialog();
        }

        private void btnStockClerk_Click(object sender, EventArgs e)
        {
            FrmStockClerk frm = new FrmStockClerk();
            frm.dbID = dbID;
            frm.ShowDialog();
            
        }
    }
}
