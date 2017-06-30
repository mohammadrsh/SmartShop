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
    public partial class FrmStockClerk : Form
    {
        public FrmStockClerk()
        {
            InitializeComponent();
        }

        private void FrmStockClerk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartShopDataSet1.Kala' table. You can move, or remove it, as needed.
            this.kalaTableAdapter.Fill(this.smartShopDataSet1.Kala);

        }
    }
}
