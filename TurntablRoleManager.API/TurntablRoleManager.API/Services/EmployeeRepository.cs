using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.API.DbContexts;
using TurntablRoleManager.API.Entities;
using TurntablRoleManager.API.Models;

namespace TurntablRoleManager.API.Services
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly TurntablDbContext _context;

        public EmployeeRepository(TurntablDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Get all employees and their corresponding roles 
        public IEnumerable<DetailEmployeeDTO> GetEmployees()
        {
            List<DetailEmployeeDTO> detailEmployeeDTOs = new List<DetailEmployeeDTO>();

            var employeesInDb = _context.Employees.ToList();

            foreach (var emp in employeesInDb)
            {
                // fetching roles related to each employee
                var rolesInDb = (from e in _context.Employees
                             join er in _context.EmployeeRoles on e.EmployeeId equals er.EmployeeId
                             join r in _context.Roles on er.Id equals r.Id
                             where e.EmployeeId == emp.EmployeeId
                             select r).ToList();
              
                List<RoleTo> individualEmployeeRoles = new List<RoleTo>();

                foreach (var r in rolesInDb)
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


        // Get single employee with assigned roles 
        public DetailEmployeeDTO GetEmployeeById(int id)
        {
            DetailEmployeeDTO detailEmployee = new DetailEmployeeDTO();
            List<RoleTo> soloEmployeeRoles = new List<RoleTo>();

            var querableEmployee = _context.Employees.FirstOrDefault(e => e.EmployeeId == id);
          
            // fetching roles related to employee
            var querableRoles = (from e in _context.Employees
                         join er in _context.EmployeeRoles on e.EmployeeId equals er.EmployeeId
                         join r in _context.Roles on er.Id equals r.Id
                         where e.EmployeeId == querableEmployee.EmployeeId
                         select r).ToList();

            // fetching all roles related to the employee
            foreach (var r in querableRoles)
            {
                RoleTo roleTo = new RoleTo();
                roleTo.Id = r.Id;
                roleTo.Name = r.Name;
                roleTo.Description = r.Description;
                roleTo.CreatedAt = r.CreatedAt;

                soloEmployeeRoles.Add(roleTo);
            }

            // mapping querable data to employee detail 
            detailEmployee.EmployeeId = querableEmployee.EmployeeId;
            detailEmployee.EmployeeFirstName = querableEmployee.EmployeeFirstName;
            detailEmployee.EmployeeLastName = querableEmployee.EmployeeLastName;
            detailEmployee.EmployeeEmail = querableEmployee.EmployeeEmail;
            detailEmployee.EmployeeAddress = querableEmployee.EmployeeAddress;
            detailEmployee.Roles = soloEmployeeRoles;

            return detailEmployee ;
        }

        public int AddEmployeeWithRoles(AddEmployeeDTO employeeDTO)
        {
            Employee employee = new Employee();
            employee.EmployeeFirstName = employeeDTO.EmployeeFirstName;
            employee.EmployeeLastName = employeeDTO.EmployeeLastName;
            employee.EmployeeEmail = employeeDTO.EmployeeEmail;
            employee.EmployeeAddress = employeeDTO.EmployeeAddress;

            _context.Employees.Add(employee);
            _context.SaveChanges();

            List<RoleTo> roleTos = new List<RoleTo>();
            foreach (var r in employeeDTO.Roles)
            {
                roleTos.Add(r);
            }

            EmployeeRole employeeRole = new EmployeeRole();

            foreach (var r in roleTos)
            {
                Role role = new Role()
                {
                    Id = Guid.NewGuid(),
                    Name = r.Name,
                    Description = r.Description,
                    CreatedAt = DateTime.UtcNow
                };
                _context.Roles.Add(role);
                _context.SaveChanges();

                employeeRole.Id = role.Id;
            }

            employeeRole.EmployeeId = employee.EmployeeId;

            _context.EmployeeRoles.Add(employeeRole);
            _context.SaveChanges();

            return employee.EmployeeId;
        }
        //  public int CreateEmployee(Employee employee)
        //  {
        //      if (employee == null)
        //      {
        //          throw new ArgumentNullException(nameof(employee));
        //      }
        //      _context.Employees.Add(employee);
        //      _context.SaveChanges();

        //      return employee.EmployeeId;
        //}

        //  public void DeleteEmployee(int id)
        //  {
        //          var querableEmployee = _context.Employees.FirstOrDefault(e => e.EmployeeId == id);

        //          _context.Employees.Remove(querableEmployee);
        //          _context.SaveChanges();
        //  }



    }
}
