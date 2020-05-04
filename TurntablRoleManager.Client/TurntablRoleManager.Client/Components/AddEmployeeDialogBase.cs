using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Model;
using TurntablRoleManager.Client.Services;

namespace TurntablRoleManager.Client.Components
{
    public class AddEmployeeDialogBase: ComponentBase
    {
        public EmployeeModel EmployeeModel { get; set; } = new EmployeeModel();
        public IEnumerable<RoleModel> Roles { get; set; } = new List<RoleModel>();

        public Guid SelectedRole { get; set; }

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        [Inject]
        public IRoleDataService RoleDataService { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        public bool ShowDialog { get; set; }
        public bool DisableButton { get; set; }

        public bool ShowBackdrop { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            ShowBackdrop = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            ShowBackdrop = false;
            StateHasChanged();
        }

        public async void ResetDialog()
        {
            DisableButton = false;
            Roles = (await RoleDataService.GetAllRoles()).ToList();
            StateHasChanged();
        }

        protected async Task HandleValidSubmit()
        {
            //Making API Call to Add Employee here
            DisableButton = true;
            EmployeeModel.RoleGuids.Add(SelectedRole);
            await EmployeeDataService.AddEmployee(EmployeeModel);
            await CloseEventCallback.InvokeAsync(true);

            ShowDialog = false;
            ShowBackdrop = false;
            StateHasChanged();
        }
    }
}
