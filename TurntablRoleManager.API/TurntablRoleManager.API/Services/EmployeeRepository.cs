using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.API.DbContexts;
using TurntablRoleManager.API.Entities;

namespace TurntablRoleManager.API.Services
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly TurntablDbContext _context;

        public EmployeeRepository(TurntablDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public IEnumerable<Employee> GetEmployees()
        {
            var querable = _context.Employees.ToList<Employee>();
            return querable;
        }

        public Employee GetEmployeeById(int id)
        {
            var employee= _context.Employees.FirstOrDefault(e => e.EmployeeId == id);
            return employee;
        }


        public void DeleteEmployee(int id)
        {
                var querableEmployee = _context.Employees.FirstOrDefault(e => e.EmployeeId == id);

                _context.Employees.Remove(querableEmployee);
                _context.SaveChanges();
        }

        //public Employee CreateEmployee(Employee employee)
        //{
        //    if (employee == null)
        //    {
        //        throw new ArgumentNullException(nameof(employee));
        //    }
            
        //    _context.SaveChanges();
        //    return _context.Employees.Add(employee).Entity;
        //}

    }
}
