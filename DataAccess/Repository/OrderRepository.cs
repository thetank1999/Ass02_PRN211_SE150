using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        void IOrderRepository.AddOrder(Order _Order) => OrderDAO.Instance.AddOrder(_Order);

        IEnumerable<Order> IOrderRepository.FilterOrderList(int MemberId) => OrderDAO.Instance.FilterOrderList(MemberId);

        Order IOrderRepository.GetOrderById(int id) => OrderDAO.Instance.GetOrderById(id);

        IEnumerable<Order> IOrderRepository.GetOrderList() => OrderDAO.Instance.GetOrderList();

        void IOrderRepository.RemoveOrder(Order _Order) => OrderDAO.Instance.RemoveOrder(_Order);

        void IOrderRepository.UpdateOrder(Order _Order) => OrderDAO.Instance.UpdateOrder(_Order);
    }
}
