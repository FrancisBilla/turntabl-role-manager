using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Model;

namespace TurntablRoleManager.Client.Services
{
    public interface IRoleDataService
    {
        Task<IEnumerable<RoleModel>> GetAllRoles();
        Task<RoleModel> GetRoleDetails(Guid roleId);
        Task<RoleModel> AddRole(RoleModel role);
        Task UpdateRole(RoleModel role);
        Task DeleteRole(Guid roleId);
    }
}
