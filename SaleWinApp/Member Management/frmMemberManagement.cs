using BussinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmMemberManagement : Form
    {
        MemberDAO _memberDAO = new MemberDAO();
        IEnumerable<Member> _memberList = new List<Member>();
        public frmMemberManagement() {
            InitializeComponent();
        }

        private void btn_MemberMana_Add_Click(object sender, EventArgs e) {
                
        }

        private void btn_MemberMana_Update_Click(object sender, EventArgs e) {

        }

        private void btn_MemberMana_Delete_Click(object sender, EventArgs e) {

        }

        private void btn_Reload_Click(object sender, EventArgs e) {
            this.AutoLoadDataInto_DGV();
        }

        #region [ DGV - Functions ]
        public void AutoLoadDataInto_DGV() {
            _memberList = _memberDAO.GetMemberList();
            this.LoadDataInto_DGV(_memberList);
        }

        public void LoadDataInto_DGV(IEnumerable<Member> _memberList) {
            dgv_Members.Rows.Clear();
            foreach (var member in _memberList) {
                dgv_Members.Rows.Add(member.MemberId, member.Email, member.CompanyName, member.City,member.Country);
            }
        }
        #endregion

        
    }
}
