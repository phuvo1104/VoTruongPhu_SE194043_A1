using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CustomerDAO
    {
        private AppDbContext context = new AppDbContext();
        public List<Customers> GetAllCustomers()
        {
            return context.Customers.ToList();
        }
        public void AddCustomers(Customers customers)
        {
            context.Customers.Add(customers);
        }
        public void UpdateCustomers(Customers customers)
        {
            context.Customers.Update(customers);
            context.SaveChanges();
        }
        public Customers GetCustomerById(int id)
        {
            return context.Customers.FirstOrDefault(c => c.CustomerID == id);
        }
        public void DeleteCustomers(Customers customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
    }
}
