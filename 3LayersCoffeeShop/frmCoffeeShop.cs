using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3LayersCoffeeShop
{
    public partial class frmCoffeeShop : Form
    {
        public frmCoffeeShop()
        {
            InitializeComponent();
        }

        private void frmCoffeeShop_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;

            frmLogin frm = new frmLogin();
            DialogResult result = frm.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Enabled = true;
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frmPro = new frmProduct();
            frmPro.ShowDialog();
        }
    }
}
