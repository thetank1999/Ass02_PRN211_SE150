using BussinessObject.Models;
using System;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmGeneralManagement : Form
    {
        public frmGeneralManagement() {
            InitializeComponent();
        }

        public frmGeneralManagement(Member memberDAO) {
            //InitializeComponent();
        }
        private void btn_MemberManagement_Click(object sender, EventArgs e) {
            frmMemberManagement frmMemberManagement = new frmMemberManagement();
            frmMemberManagement.Show();
        }

        private void btn_ProductManagement_Click(object sender, EventArgs e) {

        }

        private void btn_OrderManagement_Click(object sender, EventArgs e) {

        }

        private void btn_CreateReport_Click(object sender, EventArgs e) {

        }
    }
}
