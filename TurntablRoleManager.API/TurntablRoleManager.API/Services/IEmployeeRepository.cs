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
        //Role CreateEmployee(Employee employee);
        //Role UpdateEmployee(Employee employee);
        //void DeleteEmployee(Guid id);
    }
}
