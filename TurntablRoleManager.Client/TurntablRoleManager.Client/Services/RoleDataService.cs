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
    public class RoleDataService : IRoleDataService
    {
        private readonly HttpClient _httpClient;
        public RoleDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<RoleModel> AddRole(RoleModel role)
        {
            var roleJson =
                new StringContent(JsonSerializer.Serialize(role), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/roles", roleJson);
            
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<RoleModel>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public Task DeleteRole(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoleModel>> GetAllRoles()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<RoleModel>>
                (await _httpClient.GetStreamAsync($"api/roles"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<RoleModel> GetRoleDetails(Guid roleId)
        {
            return await JsonSerializer.DeserializeAsync<RoleModel>
                (await _httpClient.GetStreamAsync($"api/roles/{roleId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateRole(RoleModel role)
        {
            var roleJson =
                new StringContent(JsonSerializer.Serialize(role), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/roles", roleJson);
        }
    }
}
