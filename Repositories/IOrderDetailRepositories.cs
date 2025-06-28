using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepositories
    {
        List<OrderDetails> GetOrderDetailsByOrderId(int orderId);
        void DeleteOrderDetail(int orderId, int productId);
    }
}
