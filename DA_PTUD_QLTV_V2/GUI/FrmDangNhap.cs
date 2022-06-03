using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "")
                {
                    txtUserName.Text = "Enter User Name";
                    return;
                }
                txtUserName.ForeColor = Color.White;
                pnlWarningUser.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == "")
                {
                    txtPassword.Text = "Enter Password";
                    return;
                }
                txtPassword.ForeColor = Color.White;
                pnlWarningPass.Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.SelectAll();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Enter User Name")
            {
                pnlWarningUser.Visible = true;
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "Enter Password")
            {
                pnlWarningPass.Visible = true;
                txtPassword.Focus();
                return;
            }
        }
    }
}
