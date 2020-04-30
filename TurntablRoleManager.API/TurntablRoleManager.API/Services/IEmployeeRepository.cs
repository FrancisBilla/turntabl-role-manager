using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.API.Entities;

namespace TurntablRoleManager.API.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        void DeleteEmployee(int id);
        public int CreateEmployee(Employee employee);
    }
}
