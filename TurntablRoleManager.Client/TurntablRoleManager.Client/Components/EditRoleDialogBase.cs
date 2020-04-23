using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Model;
using TurntablRoleManager.Client.Services;

namespace TurntablRoleManager.Client.Components
{
    public class EditRoleDialogBase : ComponentBase
    {
        public RoleModel RoleModel { get; set; } = new RoleModel();

        [Inject]
        public IRoleDataService RoleDataService { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        public bool ShowDialog { get; set; }

        public bool ShowBackdrop { get; set; }

      
        public void Show(Guid Id)
        {
            ResetDialog(Id);
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

        public async void ResetDialog(Guid Id)
        {
            RoleModel = await RoleDataService.GetRoleDetails(Id);
            StateHasChanged();
        }

        protected async Task HandleValidSubmit()
        {
            //Making API Call here
            await RoleDataService.UpdateRole(RoleModel);
            await CloseEventCallback.InvokeAsync(true);

            ShowDialog = false;
            ShowBackdrop = false;
            StateHasChanged();
        }
    }
}
