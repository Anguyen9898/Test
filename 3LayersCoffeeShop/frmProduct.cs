using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS1;
using DTO;

namespace _3LayersCoffeeShop
{
    public partial class frmProduct : Form
    {
        ProductBus proBus;
        SupplierBus supBus;
        public frmProduct()
        {
            InitializeComponent();
            proBus = new ProductBus();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            List<Product> list = proBus.GetProduct();
            dgvPro.DataSource = list;
            List<Supplier> listSup = supBus.GetSupplier();
            cbBoxNCC.DataSource = listSup;
            cbBoxNCC.DisplayMember = "id";
            cbBoxNCC.ValueMember = "name";
            txtID.Text = cbBoxNCC.SelectedItem.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id, name, supplier;
            float purchase, sellingPrice;
            int categoryId;
            id = txtID.Text;
            name = txtName.Text;
            purchase = float.Parse(txtMua.Text);
            sellingPrice = float.Parse(txtBan.Text);
            categoryId = int.Parse(txtLoai.Text);
            supplier = cbBoxNCC.Text;
            Product pro = new Product(id,name,purchase,sellingPrice,categoryId,supplier);
            try
            {
                int numOfRows = proBus.Add(pro);
                if (numOfRows > 0)
                {
                    dgvPro.DataSource = proBus.GetProduct();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Loi them san pham \n"+ ex.Message, "Add",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
