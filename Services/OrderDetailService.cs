﻿using BusinessObject;
using DataAccessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepositories repo;
        private readonly OrderDetailDAO _dao = new();
        public OrderDetailService()
        {
            repo = new OrderDetailRepositories();
        }

        public List<OrderDetails> GetOrderDetailsByOrderId(int orderId)
        {
            return repo.GetOrderDetailsByOrderId(orderId);
        }
        public void DeleteOrderDetail(int orderId, int productId)
        {
            repo.DeleteOrderDetail(orderId, productId);
        }

    }
}
