using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using UTSBlazor_72190322.Models;

namespace UTSBlazor_72190322.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient) 
        {
         _httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees");
           return results;
        }

        public async Task<Employee> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
           return result;
        }
    }
}