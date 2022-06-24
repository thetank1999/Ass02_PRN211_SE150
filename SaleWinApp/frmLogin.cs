using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin() {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e) {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<DefaultAccountSettings>();
            string AdminEmail = adminDefaultSettings.Email;
            string AdminPassword = adminDefaultSettings.Password;

            if (true) //tB_EmailAddress.Text == AdminEmail && tB_Password.Text == AdminPassword
            {
                this.Hide();
                var formManagement = new frmGeneralManagement();
                formManagement.Show();
            } else {
                MessageBox.Show("Incorrect Email or Password. Please do it again");

                tB_Password.Clear();
            }
        }
    }
}
