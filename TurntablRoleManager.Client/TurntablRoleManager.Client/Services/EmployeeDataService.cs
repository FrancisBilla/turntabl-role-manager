using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Model;

namespace TurntablRoleManager.Client.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient _httpClient;
        public EmployeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<EmployeeModel> AddEmployee(EmployeeModel employee)
        {
            var employeeJson =
                new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/employees", employeeJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<EmployeeModel>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public Task<IEnumerable<EmployeeModel>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetEmployeeDetails(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
