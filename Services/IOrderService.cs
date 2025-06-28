using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IOrderService
    {
        void AddOrder(Orders order);
        void DeleteOrder(int orderId);
        Orders GetOrderById(int orderId);
        List<Orders> GetAllOrders();
    }
}
