﻿using System;
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
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }
        public int dbID = 0;

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            textBox1.Text = dbID.ToString();
        }
    }
}
