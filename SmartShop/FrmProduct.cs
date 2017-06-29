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
    public partial class FrmProduct : Form


    {
        SmartShopEntities test;

        public FrmProduct()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            
           // this.kalaTableAdapter.Fill(this.smartShopDataSet.Kala);
            panel.Enabled = false;
            test = new SmartShopEntities();
            kalaBindingSource.DataSource = test.Kalas.ToList();


        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
