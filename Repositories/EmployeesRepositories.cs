using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EmployeesRepostitories : IEmployeesRepositories
    {
        EmployeeDAO employee = new EmployeeDAO();
        public Employees FindByUsernameAndPassword(string username, string password)
        {
            return employee.FindByUsernameAndPassword(username, password);
        }
    }
}
