using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public EmployeesController(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeTo>> Employees()
        { 
            var employees = _employeeRepository.GetEmployees();

            if(employees == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<EmployeeTo>>(employees));
        }
    }
}
