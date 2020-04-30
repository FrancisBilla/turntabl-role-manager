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


        [HttpGet("{id}")]
        public IActionResult Employee(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return NoContent();
        }


        [HttpPost]
        public  ActionResult<int> Post(Employee employee)
        {
            var employeeId = _employeeRepository.CreateEmployee(employee);
            return employeeId;
        }
    }
}
