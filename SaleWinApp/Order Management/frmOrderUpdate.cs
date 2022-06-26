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
    public partial class frmOrderUpdate : Form
    {
        MemberRepository _memberRepository = new MemberRepository();
        IEnumerable<Member> _memberList= new List<Member>();
        OrderRepository _orderRepository = new OrderRepository();
        public frmOrderUpdate(Order _order) {
            InitializeComponent();
            this.AutoLoadDataInto_CB();
            this.LoadDataInto_Inputs(_order);
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            if (    cB_Member.SelectedIndex < 0
                ||  mTB_Freight.Text.Equals("")) {
                MessageBox.Show("Invalid Input.");
            }else {
                var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(mTB_OrderId.Text.ToString()));
                var _tempMember = (Member)cB_Member.SelectedItem;
                _tempOrder.MemberId = _tempMember.MemberId;
                _tempOrder.OrderDate = DateTime.Parse(dTP_OrderDate.Value.ToString());
                _tempOrder.RequiredDate = DateTime.Parse(dTP_RequiredDate.Value.ToString());
                _tempOrder.ShippedDate = DateTime.Parse(dTP_ShippedDate.Value.ToString());
                _tempOrder.Freight = decimal.Parse(mTB_Freight.Text);
                _orderRepository.UpdateOrder(_tempOrder);
                this.Close();
                MessageBox.Show("Updated successfully.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            //cB_Member.Text = "";
            var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(mTB_OrderId.Text.ToString()));
            this.LoadDataInto_Inputs(_tempOrder);
        }

        private void cB_Member_TextChanged(object sender, EventArgs e) {
            _memberList = _memberRepository.FilterMemberByString(cB_Member.Text);
            this.LoadDataInto_CB(_memberList);
        }
        #region [ Load Data functions ]
        public void LoadDataInto_Inputs(Order _order) {
            var index = GetMemberIndex(_order);
            mTB_OrderId.Text = _order.OrderId.ToString();
            cB_Member.SelectedIndex = index;
            dTP_OrderDate.Text = _order.OrderDate.ToString();
            dTP_RequiredDate.Text = _order.RequiredDate.ToString();
            dTP_ShippedDate.Text = _order.ShippedDate.ToString();
            var _tempFreightString = _order.Freight.ToString();
            mTB_Freight.Text = _tempFreightString.Remove(_tempFreightString.Length-5);
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
        public int GetMemberIndex(Order _order) {
            int count = 0;
            var _tempMember = _memberRepository.GetMemberById(_order.MemberId);
            _memberList = _memberRepository.GetMemberList();
            foreach (var member in _memberList) {
                if (_tempMember.MemberId == member.MemberId) {
                    return count;
                } else {
                    count++;
                }
            } return count;
        }
        #endregion

    }
}
