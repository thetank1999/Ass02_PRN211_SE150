using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmLogin : Form
    {
        MemberRepository _memberDAO = new MemberRepository();
        public frmLogin() {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e) {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<DefaultAccountSettings>();
            string AdminEmail = adminDefaultSettings.Email;
            string AdminPassword = adminDefaultSettings.Password;

            var tempMember = _memberDAO.Login(tB_EmailAddress.Text, tB_Password.Text);

            if (tB_EmailAddress.Text == AdminEmail && tB_Password.Text == AdminPassword) //tB_EmailAddress.Text == AdminEmail && tB_Password.Text == AdminPassword
            {
                this.Hide();
                var formManagement = new frmGeneralManagement();
                formManagement.Show();
            } else if (tempMember != null) //tempMember != null
                {
                this.Hide();
                var formManagement = new frmPersonalManagement(tempMember);
                formManagement.Show();
            } else {
                MessageBox.Show("Incorrect Email or Password. Please do it again");

                tB_Password.Clear();
            }
        }

        private void btn_Register_Click(object sender, EventArgs e) {
            frmMemberCreate frmMemberCreate = new frmMemberCreate();
            frmMemberCreate.ShowDialog();
        }
    }
}
