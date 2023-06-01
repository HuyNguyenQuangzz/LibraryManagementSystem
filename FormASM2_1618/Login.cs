using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormASM2_1618
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lbStatus.Visible = false;
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lbStatus.Visible = false;
        }
        private void ckShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowpassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            ckShowpassword.Checked = false;
            lbStatus.Visible = false;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("12345"))
            {
                // Logged in successfully. open a new form
                Home one = new Home();
                this.Hide();
                // Do not interact with the old form
                one.ShowDialog();
                this.Close();
            }
            else
            {
                // Fail Login          
                lbStatus.Visible = true;
            }
        }
    }
}
