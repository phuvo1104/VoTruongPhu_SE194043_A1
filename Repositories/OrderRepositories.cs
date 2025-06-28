using BusinessObject;
using DataAccessObject;
using Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDAO orderDAO = new OrderDAO();

        public void AddOrder(Orders order)
        {
            orderDAO.AddOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            orderDAO.DeleteOrder(orderId);
        }

        public Orders GetOrderById(int orderId)
        {
            return orderDAO.GetOrderById(orderId);
        }

        public List<Orders> GetAllOrders()
        {
            return orderDAO.GetAllOrders();
        }
    }
}
