﻿
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ProductDAO
    {
        private AppDbContext context = new AppDbContext();
        public List<Products> GetAllProducts()
        {
            return context.Products.ToList();
        }
    }
}
