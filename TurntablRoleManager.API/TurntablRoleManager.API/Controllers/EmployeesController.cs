﻿using AutoMapper;
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
            var employee = _employeeRepository.GetEmployee(id);
            return employee;
        }

        [HttpPost]   // api/employees
        public EmployeeTo CreateEmployeeWithRoles(AddEmployeeDTO employeeDTO)
        {
            var employeeDto= _employeeRepository.AssignEmployeeWithRoles(employeeDTO);
            //string result = $"Successfully created employee with employeeId = {employeeIdResponse} ";
            return employeeDto;
        }

        [HttpDelete("{id}")]    // api/employees/1
        public string DeleteEmployee(int id)
        {
            var employeeIdAsResponse = _employeeRepository.DeleteEmployee(id);
            string result = $"Deleted employeeId = {employeeIdAsResponse} successfully";
            return result;
       }
    }
}
