﻿using BussinessObject.Context;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.DAO
{
    public class OrderDAO
    {
        #region [ Using Singleton ]
        private static OrderDAO instance = null;
        public static readonly object instanceLock = new object();
        public static OrderDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        #region [ Get OrderList By MemberId ]
        public IEnumerable<Order> FilterOrderList(int MemberId) {
            var OrderList = new List<Order>();
            try {
                using var context = new FStoreDBContext();
                OrderList = context.Orders.Where(x => x.MemberId==MemberId).ToList(); 
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return OrderList;
        }
        #endregion

        #region [ CRUD ]
        public IEnumerable<Order> GetOrderList() {
            var OrderList = new List<Order>();
            try {
                using var context = new FStoreDBContext();
                OrderList = context.Orders.ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return OrderList;
        }

        public Order GetOrderById(int id) {
            Order _tempOrder = null;
            try {
                using var context = new FStoreDBContext();
                _tempOrder = context.Orders.FirstOrDefault(x => x.OrderId == id);
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempOrder;
        }

        public void AddOrder(Order _Order) {
            try {
                var _tempOrder = this.GetOrderById(_Order.OrderId);
                if (_tempOrder == null) {
                    using var context = new FStoreDBContext();
                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");
                    //context.Database.OpenConnection();
                    context.Orders.Add(_Order);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Order Id is already existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void UpdateOrder(Order _Order) {
            try {
                Order tempOrder = this.GetOrderById(_Order.OrderId);
                if (tempOrder != null) {
                    using var context = new FStoreDBContext();
                    context.Orders.Update(_Order);
                    context.SaveChanges();

                } else {
                    throw new Exception("The Order Id is not existed.");

                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void RemoveOrder(Order _Order) {
            try {
                Order _tempOrder = this.GetOrderById(_Order.OrderId);
                if (_tempOrder != null) {
                    using var context = new FStoreDBContext();
                    context.Orders.Remove(_tempOrder);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Order Id is not existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }
}
