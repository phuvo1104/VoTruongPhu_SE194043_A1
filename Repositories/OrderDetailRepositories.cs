using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepositories : IOrderDetailRepositories
    {
        private readonly OrderDetailDAO dao = new OrderDetailDAO();

        public List<OrderDetails> GetOrderDetailsByOrderId(int orderId)
        {
            return dao.GetOrderDetailsByOrderId(orderId);
        }
        public void DeleteOrderDetail(int orderId, int productId)
        {
            dao.DeleteOrderDetail(orderId, productId);
        }
    }
}
