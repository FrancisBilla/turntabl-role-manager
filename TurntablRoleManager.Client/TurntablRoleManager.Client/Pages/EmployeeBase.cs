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
    public class EmployeeBase: ComponentBase
    {
       
        protected AddEmployeeDialogBase AddEmployeeDialog { get; set; }

        public IEnumerable<EmployeeModel> Employees { get; set; }

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            //Make API Call to Get All Employees when component is invoke
            //Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }
        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {   
            //Make API Call to Get All Employees
           // Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }
    }
}
