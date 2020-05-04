using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurntablRoleManager.Client.Model
{
    public class EmployeeModel
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeAddress { get; set; }
        public List<Guid> RoleGuids { get; set; } = new List<Guid>();
    }
}
