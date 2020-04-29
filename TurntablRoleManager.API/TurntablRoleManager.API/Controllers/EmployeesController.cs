using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IMapper _mapper;
        private readonly TurntablDbContext _context;

        public EmployeesController(IEmployeeRepository employeeRepository, IMapper mapper, TurntablDbContext context)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Employee> Employees()
        { 
            var employees = _employeeRepository.GetEmployees();

            if(employees == null)
            {
                return (IEnumerable<Employee>)NotFound();
            }

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
        public async Task<ActionResult<int>> Post(EmployeeTo employee)
        {
            _context.Add(employee);
            await _context.SaveChangesAsync();
            return employee.EmployeeId;
        }
    }
}
