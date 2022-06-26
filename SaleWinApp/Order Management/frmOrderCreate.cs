using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmOrderCreate : Form
    {
        MemberRepository _memberRepository = new MemberRepository();
        OrderRepository _orderRepository = new OrderRepository();
        IEnumerable<Member> _memberList = new List<Member>();
        public frmOrderCreate() {
            InitializeComponent();
            this.AutoLoadDataInto_CB();
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(mTB_OrderId.Text.ToString()));
            if (    mTB_OrderId.Text.ToString().Equals("")
                ||  cB_Member.SelectedIndex < 0
                ||  mTB_Freight.Text.ToString().Equals("")) {
                MessageBox.Show("Invalid Input.");
            } else if (_tempOrder != null) {
                MessageBox.Show("Order Id Cannot be dupplicated.");
            } else {
                var _temp = new Order();
                _temp.OrderId = Int32.Parse(mTB_OrderId.Text.ToString());
                var _tempMember = (Member)cB_Member.SelectedItem;
                _temp.MemberId = _tempMember.MemberId;
                _temp.OrderDate = DateTime.Parse(dTP_OrderDate.Value.ToLongTimeString());
                _temp.RequiredDate = DateTime.Parse(dTP_RequiredDate.Value.ToLongTimeString());
                _temp.ShippedDate = DateTime.Parse(dTP_ShippedDate.Value.ToLongTimeString());
                _temp.Freight = decimal.Parse(mTB_Freight.Text.Trim());
                _orderRepository.AddOrder(_temp);
                this.Close();
                MessageBox.Show("Added succesfully");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Clear_Inputs();
        }

        private void cB_Member_TextChanged(object sender, EventArgs e) {

        }
        public void Clear_Inputs() {
            mTB_OrderId.Clear();
            cB_Member.SelectedIndex = -1;
            dTP_OrderDate.Value = DateTime.Now;
            dTP_RequiredDate.Value = DateTime.Now;
            dTP_ShippedDate.Value = DateTime.Now;
            mTB_Freight.Clear();
        }
        public void AutoLoadDataInto_CB() {
            _memberList = _memberRepository.GetMemberList();
            this.LoadDataInto_CB(_memberList);
        }
        public void LoadDataInto_CB(IEnumerable<Member> _memberList) {
            cB_Member.Items.Clear();
            foreach (var member in _memberList) {
                cB_Member.Items.Add(member);
            }
        }
    }
}
