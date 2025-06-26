using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace Repositories
{
    public interface ICustomersRepositories
    {
        List<Customers> GetAllCustomers();
        void AddCustomers(Customers customers);
        void UpdateCustomers(Customers customers);
        void DeleteCustomers(Customers customers);
        

    }
}
