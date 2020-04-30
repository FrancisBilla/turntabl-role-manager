﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.API.Entities;
using TurntablRoleManager.API.Models;

namespace TurntablRoleManager.API.Services
{
    public interface IEmployeeRepository
    {
        void DeleteEmployee(int id);
        public int CreateEmployee(Employee employee);
        IEnumerable<DetailEmployeeDTO> GetEmployees();
        DetailEmployeeDTO GetEmployeeById(int id);
    }
}
