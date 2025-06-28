using BusinessObject;
using Repositories;
using Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService()
        {
            orderRepository = new OrderRepository();
        }

        public void AddOrder(Orders order)
        {
            orderRepository.AddOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            orderRepository.DeleteOrder(orderId);
        }

        public Orders GetOrderById(int orderId)
        {
            return orderRepository.GetOrderById(orderId);
        }

        public List<Orders> GetAllOrders()
        {
            return orderRepository.GetAllOrders();
        }
    }
}
