using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form_Design_Example
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı ve şifre boş olamaz!");
            }
            else
            {
                if (txtUserName.Text == "mesut" && txtPassword.Text == "123")
                {
                    if (cbxRemember.Checked)
                    {
                        Properties.Settings.Default.UserName = txtUserName.Text;
                        Properties.Settings.Default.Password = txtPassword.Text;
                        Properties.Settings.Default.CheckBox = cbxRemember.Checked;
                        Properties.Settings.Default.Save();
                    }
                    StockControlForm stfrm = new StockControlForm();
                    stfrm.Show();
                    this.Hide();
                }
                else
                {
                    //
                    lblErrorMessage.ForeColor = Color.Red;

                    lblErrorMessage.Text = "Kullanıcı veya şifre yanlış!";
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            cbxRemember.Checked = Properties.Settings.Default.CheckBox;
            txtUserName.Text = Properties.Settings.Default.UserName;
            txtPassword.Text = Properties.Settings.Default.Password;

        }
    }
}
