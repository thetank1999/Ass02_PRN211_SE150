using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmOrderManagement : Form
    {
        OrderRepository _orderRepository = new OrderRepository();
        IEnumerable<Order> _orderList = new List<Order>();
        MemberRepository _memberRepository = new MemberRepository();
        public frmOrderManagement() {
            InitializeComponent();
            this.AutoLoadDataInto_DGV();
            dTP_FromDate.Value= DateTime.Now;
            dTP_ToDate.Value= DateTime.Now;
        }

        private void btn_ReloadData_Click(object sender, EventArgs e) {
            this.AutoLoadDataInto_DGV();
        }

        private void btn_Delete_Click(object sender, EventArgs e) {
            DialogResult _dialogResult;
            _dialogResult = MessageBox.Show("Do you really want to delete chosen Order?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK) {
                var temp = _orderRepository.GetOrderById(Int32.Parse(dgv_Order.SelectedRows[0].Cells[0].Value.ToString()));
                _orderRepository.RemoveOrder(temp);
                this.AutoLoadDataInto_DGV();
                MessageBox.Show("Deleted the chosen order.");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e) {
            var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(dgv_Order.SelectedRows[0].Cells[0].Value.ToString()));
            frmOrderUpdate frmOrderUpdate = new frmOrderUpdate(_tempOrder);
            frmOrderUpdate.ShowDialog();
        }

        private void btn_Create_Click(object sender, EventArgs e) {
            frmOrderCreate frmCreate = new frmOrderCreate();
            frmCreate.ShowDialog();
        }

        private void btn_Report_Click(object sender, EventArgs e) {
            var _fromDateTime = DateTime.Parse(dTP_FromDate.Text);
            var _toDateTime = DateTime.Parse(dTP_ToDate.Text);
            _orderList = _orderRepository.FilterOrderListByDateTime(_fromDateTime, _toDateTime);
            this.LoadDataInto_DGV(_orderList);
        }

        #region [DGV - functions]
        public void AutoLoadDataInto_DGV() {
            _orderList = _orderRepository.GetOrderList();
            
            this.LoadDataInto_DGV(_orderList);
        }

        public void LoadDataInto_DGV(IEnumerable<Order> _orderList) {
            dgv_Order.Rows.Clear();
            foreach (var order in _orderList) {
                var _tempMemberEmail = _memberRepository.GetMemberById(order.MemberId).Email;
                dgv_Order.Rows.Add(order.OrderId, _tempMemberEmail, order.OrderDate.ToString("ddd, dd MMM, yyyy"), order.RequiredDate.ToString("ddd, dd MMM, yyyy"), order.ShippedDate.ToString("ddd, dd MMM, yyyy"), order.Freight);
            }
        }
        private void dgv_Order_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv_Order.SelectedRows.Count == 1) {
                btn_Delete.Enabled = true;
                btn_Update.Enabled = true;
            } else {
                btn_Delete.Enabled = false;
                btn_Update.Enabled = false;
            }
        }
        #endregion
    }
}
