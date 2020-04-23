using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Model;
using TurntablRoleManager.Client.Services;

namespace TurntablRoleManager.Client.Components
{
    public class AddRoleDialogBase: ComponentBase
    {
        public RoleModel RoleModel { get; set; } = new RoleModel();

        [Inject]
        public IRoleDataService RoleDataService { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        public bool ShowDialog { get; set; }

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

        public void ResetDialog()
        {
            RoleModel = new RoleModel();
        }

        protected async Task HandleValidSubmit()
        {
            //Making API Call here
            await RoleDataService.AddRole(RoleModel);
            await CloseEventCallback.InvokeAsync(true);

            ShowDialog = false;
            ShowBackdrop = false;
            StateHasChanged();
        }
    }
}
