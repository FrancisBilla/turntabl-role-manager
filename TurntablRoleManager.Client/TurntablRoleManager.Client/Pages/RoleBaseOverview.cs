using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Components;
using TurntablRoleManager.Client.Model;
using TurntablRoleManager.Client.Services;


namespace TurntablRoleManager.Client.Pages
{
    public class RoleBaseOverview: ComponentBase

    {
        protected AddRoleDialogBase AddRoleDialog { get; set; }

        protected  EditRoleDialogBase EditRoleDialog { get; set; }

        [Inject]
        public IRoleDataService RoleDataService { get; set; }

        public IEnumerable<RoleModel> Roles { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Roles = (await RoleDataService.GetAllRoles()).ToList();
        }

        protected void QuickAddRole()
        {
            AddRoleDialog.Show();
        }

        protected void QuickEditRole(Guid id)
        {
            EditRoleDialog.Show(id);
        }



       public async void AddRoleDialog_OnDialogClose()
        {
            Roles = (await RoleDataService.GetAllRoles()).ToList();
            StateHasChanged();
        }

        
        public async void EditRoleDialog_OnDialogClose()
        {
            Roles = (await RoleDataService.GetAllRoles()).ToList();
            StateHasChanged();
        }
    }
}
