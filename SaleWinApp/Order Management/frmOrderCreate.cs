﻿using BussinessObject.Models;
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
        OrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        ProductRepository _productRepository = new ProductRepository();
        IEnumerable<Product> _productList = new List<Product>();
        MemberRepository _memberRepository = new MemberRepository();
        OrderRepository _orderRepository = new OrderRepository();
        IEnumerable<Member> _memberList = new List<Member>();
        List<OrderDetail> _orderDetailList = new List<OrderDetail>();
        public frmOrderCreate() {
            InitializeComponent();
            this.AutoLoadDataInto_CB();
            this.AutoLoadDataInto_CB_Product();
            this.Disable_Inputs_OrderDetail();
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(mTB_OrderId.Text.ToString()));
            if (mTB_OrderId.Text.ToString().Equals("")
                || cB_Member.SelectedIndex < 0
                || mTB_Freight.Text.ToString().Equals("")) {
                MessageBox.Show("Invalid Input.");
            } else if (_tempOrder != null) {
                MessageBox.Show("Order Id Cannot be dupplicated.");
            } else {
                if (_orderDetailList.Count == 0) {
                    MessageBox.Show("Empty Order Detail List");
                } else {
                    // save the order first
                    var _temp = new Order();
                    _temp.OrderId = Int32.Parse(mTB_OrderId.Text.Trim().ToString());
                    var _tempMember = (Member)cB_Member.SelectedItem;
                    _temp.MemberId = _tempMember.MemberId;
                    _temp.OrderDate = DateTime.Parse(dTP_OrderDate.Value.ToLongTimeString());
                    _temp.RequiredDate = DateTime.Parse(dTP_RequiredDate.Value.ToLongTimeString());
                    _temp.ShippedDate = DateTime.Parse(dTP_ShippedDate.Value.ToLongTimeString());
                    _temp.Freight = decimal.Parse(mTB_Freight.Text.Trim());
                    _orderRepository.AddOrder(_temp);

                    // then the order              
                    foreach (var _tempDetail in _orderDetailList) {
                        _tempDetail.OrderId = _temp.OrderId;
                        _orderDetailRepository.AddOrderDetail(_tempDetail);
                    }
                    this.Close();
                    MessageBox.Show("Added succesfully");
                } }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.Clear_Inputs_Order();
        }
        private void btn_AddOrderDetail_Click(object sender, EventArgs e) {
            if (btn_AddOrderDetail.Text.Contains("Add")) {
                this.Enable_Inputs_OrderDetail();
                btn_CancelOrderDetail.Enabled = true;
                btn_AddOrderDetail.Text = "Save";
            } else {
                if (    cb_Product.SelectedIndex < 0
                    ||  mtb_Quantity.Text.Equals("")) {
                    MessageBox.Show("Invalud Input.");
                } else {
                    
                    var _tempOrderDetail = new OrderDetail();
                    var _tempProduct = (Product)cb_Product.SelectedItem;
                    _tempOrderDetail.ProductId = _tempProduct.ProductId;
                    _tempOrderDetail.UnitPrice = _tempProduct.UnitPrice;
                    _tempOrderDetail.Quantity = Int32.Parse(mtb_Quantity.Text.Trim());
                    if (mtb_Discount.Text.Equals("")) {
                        _tempOrderDetail.Discount = (double)0;
                    } else {
                        _tempOrderDetail.Discount = double.Parse(mtb_Discount.Text.Trim());
                    }
                    btn_CancelOrderDetail.Enabled = false;
                    this.Add_DGV_OrderDetailRow(_tempOrderDetail);
                    btn_AddOrderDetail.Text = "Add an Order Detail";
                    this.Disable_Inputs_OrderDetail();
                    this.Clear_Inputs_OrderDetail();
                }
            }
        }
        private void btn_DeleteOrderDetail_Click(object sender, EventArgs e) {
            DialogResult _dialogResult;
            _dialogResult = MessageBox.Show("Do you really want to delete chosen Order?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK) {
                foreach (DataGridViewRow item in dgv_OrderDetails.SelectedRows) {
                    dgv_OrderDetails.Rows.RemoveAt(item.Index);
                }
                this.AutoLoadDataInto_DGV();
                MessageBox.Show("Deleted the chosen order.");
            }
        }
        private void btn_CancelOrderDetail_Click(object sender, EventArgs e) {
            this.Clear_Inputs_OrderDetail();
            this.Disable_Inputs_OrderDetail();
            btn_CancelOrderDetail.Enabled = false;
            btn_AddOrderDetail.Text = "Add an Order Detail";
        }
        private void AutoLoadDataInto_DGV() {
            dgv_OrderDetails.Rows.Clear();
            foreach (var _orderDetail in _orderDetailList) {
                var tempProduct = _productRepository.GetProductById(_orderDetail.ProductId);
                dgv_OrderDetails.Rows.Add(tempProduct, _orderDetail.UnitPrice, _orderDetail.Quantity, _orderDetail.Discount);
            }
        }

        public void Add_DGV_OrderDetailRow(OrderDetail _orderDetail) {
            _orderDetailList.Add(_orderDetail);
            this.AutoLoadDataInto_DGV();
        }

        private void cb_Product_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_Product.SelectedIndex > 0) {
                var _tempProduct = (Product)cb_Product.SelectedItem;
                tb_UnitPrice.Text = _tempProduct.UnitPrice.ToString();
            } else {
                tb_UnitPrice.Clear();
            }
        }
        public void Disable_Inputs_OrderDetail() {
            cb_Product.Enabled = false;
            mtb_Discount.Enabled = false;
            mtb_Quantity.Enabled = false;
        }

        public void Enable_Inputs_OrderDetail() {
            cb_Product.Enabled = true;
            mtb_Discount.Enabled = true;
            mtb_Quantity.Enabled = true;
        }
        public void Clear_Inputs_OrderDetail() {
            cb_Product.SelectedIndex = -1;
            mtb_Discount.Clear();
            mtb_Quantity.Clear();
        }
        public void Clear_Inputs_Order() {
            mTB_OrderId.Clear();
            cB_Member.SelectedIndex = -1;
            dTP_OrderDate.Value = DateTime.Now;
            dTP_RequiredDate.Value = DateTime.Now;
            dTP_ShippedDate.Value = DateTime.Now;
            mTB_Freight.Clear();
        }
        public void AutoLoadDataInto_CB_Product() {
            _productList = _productRepository.GetProductList();
            foreach (var _product in _productList) {
                cb_Product.Items.Add(_product);
            }
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
        // under development
        private void cB_Member_TextChanged(object sender, EventArgs e) {

        }
    }
}
