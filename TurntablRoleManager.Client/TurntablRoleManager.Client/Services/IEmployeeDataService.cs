using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Model;

namespace TurntablRoleManager.Client.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<EmployeeModel>> GetAllEmployees();
        Task<EmployeeModel> GetEmployeeDetails(Guid employeeId);
        Task<EmployeeModel> AddEmployee(EmployeeModel employee);
        Task UpdateEmployee(EmployeeModel employee);
    }
}
