using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTSBlazor_72190322.Models;
using UTSBlazor_72190322.Services;
using Microsoft.AspNetCore.Components;

namespace UTSBlazor_72190322.Pages
{
    public partial class DetailEmployee
    {
        [Parameter]
        public string id { get; set; }
       
        [Inject]
        public IEmployeeService EmployeeService{ get; set; }


        public Employee Employee { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Employee = await EmployeeService.GetById(int.Parse(id));
        }
    }
}