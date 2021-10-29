using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTSBlazor_72190322.Models;
using UTSBlazor_72190322.Services;
using Microsoft.AspNetCore.Components;

namespace UTSBlazor_72190322.Pages
{
    public partial class EmployeePage
    {
         public List<Employee> Employees { get; set; } = new List<Employee>();

        [Inject]
        public IEmployeeService EmployeeService{ get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAll()).ToList();
        }
    }
}