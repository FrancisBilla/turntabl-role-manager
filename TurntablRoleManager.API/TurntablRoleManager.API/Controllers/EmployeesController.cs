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

        // Get all employees and their corresponding roles 
        [HttpGet]  // api/employees
        public IEnumerable<DetailEmployeeDTO> Employees()
        {
            List <DetailEmployeeDTO> detailEmployeeDTOs = new List<DetailEmployeeDTO>();
            List<RoleTo> individualEmployeeRoles = new List<RoleTo>();

            var employeesInDb = _context.Employees.ToList();
           
            foreach (var emp in employeesInDb)
            {
                // fetching roles related to each employee
                var roles = (from e in _context.Employees
                             join er in _context.EmployeeRoles on e.EmployeeId equals er.EmployeeId
                             join r in _context.Roles on er.Id equals r.Id
                             where e.EmployeeId == emp.EmployeeId
                             select r).ToList();

                foreach (var r in roles)
                {
                    // mapping role dto
                    RoleTo roleTo = new RoleTo();
                    roleTo.Id = r.Id;
                    roleTo.Name = r.Name;
                    roleTo.Description = r.Description;
                    roleTo.CreatedAt = r.CreatedAt;
                   
                    individualEmployeeRoles.Add(roleTo);
                }

                // mapping employee dto to corresponding fields 
                DetailEmployeeDTO detailEmployeeDTO = new DetailEmployeeDTO();
                detailEmployeeDTO.EmployeeId = emp.EmployeeId;
                detailEmployeeDTO.EmployeeFirstName = emp.EmployeeFirstName;
                detailEmployeeDTO.EmployeeLastName = emp.EmployeeLastName;
                detailEmployeeDTO.EmployeeEmail = emp.EmployeeEmail;
                detailEmployeeDTO.EmployeeAddress = emp.EmployeeAddress;
                detailEmployeeDTO.Roles = individualEmployeeRoles;

                detailEmployeeDTOs.Add(detailEmployeeDTO);
            };
        
            return detailEmployeeDTOs;
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
