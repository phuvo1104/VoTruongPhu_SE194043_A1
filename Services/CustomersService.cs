using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Repositories;

namespace Services
{
    public class CustomerService : ICustomersService
    {
        private readonly ICustomersRepositories customerRepository;
        public CustomerService()
        {
            customerRepository = new CustomersRepositories();
        }

        public void AddCustomers(Customers customers)
        {
            customerRepository.AddCustomers(customers);
        }

        public void DeleteCustomers(Customers customers)
        {
            customerRepository.DeleteCustomers(customers);
        }

        public List<Customers> GetAllCustomers()
        {
            return customerRepository.GetAllCustomers();
        }
        public void UpdateCustomers(Customers customers)
        {
            customerRepository.UpdateCustomers(customers);
        }
       
    }
}
