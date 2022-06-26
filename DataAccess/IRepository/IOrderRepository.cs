using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> FilterOrderList(int MemberId);
        public IEnumerable<Order> GetOrderList();
        public Order GetOrderById(int id);
        public void AddOrder(Order _Order);
        public void UpdateOrder(Order _Order);
        public void RemoveOrder(Order _Order);
    }
}
