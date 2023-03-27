﻿using CrudAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAPI.Services.Employees
{
    public interface IEmployeeRepository
    {
        public List<Employee> AllEmployees();
    }
}