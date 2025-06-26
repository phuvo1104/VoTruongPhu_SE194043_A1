﻿using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeesRepositories employeesRepository;
        public EmployeesService()
        {
            employeesRepository = new EmployeesRepositories();
        }
        public Employees FindByUsernameAndPassword(string username, string password)
        {
            return employeesRepository.FindByUsernameAndPassword(username, password);
        }
    }
}
