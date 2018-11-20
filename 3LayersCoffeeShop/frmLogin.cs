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
    public partial class frmLogin : Form
    {
        LoginBus loginBUS;

        public frmLogin()
        {
            InitializeComponent();
            loginBUS=new LoginBus();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUser.Text.Trim();
            pass = txtPass.Text;
            bool b =false;

            //if (txtUser.Text == "admin" || txtPass.Text== "123")
            //bool b = false; 
            //try
            //{
            //    b = loginBUS.Login(user, pass);
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Loi dang nhap!\n" + ex.Message, "dang nhap");
            //}

            try
            {
                Account acc = new Account(user, pass);
                b = loginBUS.Login(acc);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Loi dang nhap!\n" + ex.Message, "Dang nhap");
            }
            if (b)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            { 
                DialogResult result=MessageBox.Show("User hoac pass khong dung", "Thong bao", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    txtPass.Text = "";
                    txtUser.Focus();
                }
                
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
