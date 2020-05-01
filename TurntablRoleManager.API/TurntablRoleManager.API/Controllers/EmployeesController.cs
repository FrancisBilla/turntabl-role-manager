using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.API.DbContexts;
using TurntablRoleManager.API.Entities;
using TurntablRoleManager.API.Models;
using TurntablRoleManager.API.Services;

namespace TurntablRoleManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly TurntablDbContext _context;

        public EmployeesController(IEmployeeRepository employeeRepository, IMapper mapper, TurntablDbContext context)
        {
            _employeeRepository = employeeRepository ??
                throw new ArgumentNullException(nameof(employeeRepository)); 
            _context = context ??
                throw new ArgumentNullException(nameof(context)); 
        }

        [HttpGet]  // api/employees
        public IEnumerable<DetailEmployeeDTO> Employees()
        {
            var employees = _employeeRepository.GetEmployees();
            return employees;
        }


        [HttpGet("{id}")]   // api/employees/1
        public DetailEmployeeDTO Employee(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            return employee;
        }

        [HttpPost]   // api/employees
        public int CreateEmployeeWithRoles(AddEmployeeDTO employeeDTO)
        {
            var employeeIdResponse= _employeeRepository.AssignEmployeeWithRoles(employeeDTO);
            return employeeIdResponse;
        }

        [HttpDelete("{id}")]
        public string DeleteEmployee(int id)
        {
                 var querableEmployee = _context.Employees.FirstOrDefault(e => e.EmployeeId == id);

               _context.Employees.Remove(querableEmployee);
                _context.SaveChanges();
            return $"Deleted employeeId = {querableEmployee.EmployeeId} successfully";
       }
    }
}
