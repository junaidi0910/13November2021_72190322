#pragma checksum "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "788ae5adeeae525610805f8ffcd4272b88888243"
// <auto-generated/>
#pragma warning disable 1591
namespace UTSBlazor_72190322.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProgramKu\UTSBlazor_72190322\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProgramKu\UTSBlazor_72190322\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProgramKu\UTSBlazor_72190322\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProgramKu\UTSBlazor_72190322\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProgramKu\UTSBlazor_72190322\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProgramKu\UTSBlazor_72190322\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProgramKu\UTSBlazor_72190322\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProgramKu\UTSBlazor_72190322\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProgramKu\UTSBlazor_72190322\_Imports.razor"
using UTSBlazor_72190322;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProgramKu\UTSBlazor_72190322\_Imports.razor"
using UTSBlazor_72190322.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{id}")]
    public partial class DetailEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Detail Employee</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Employee Id : ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                  Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "First Name: ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Last Name : ");
            __builder.AddContent(11, 
#nullable restore
#line 6 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, "Email : ");
            __builder.AddContent(15, 
#nullable restore
#line 7 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
            Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, "Date Of Birth: ");
            __builder.AddContent(19, 
#nullable restore
#line 8 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                   Employee.DateOfBirth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, "Gender : ");
            __builder.AddContent(23, 
#nullable restore
#line 9 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
             Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, "Department Id : ");
            __builder.AddContent(27, 
#nullable restore
#line 10 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                    Employee.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, "Department Name : ");
            __builder.AddContent(31, 
#nullable restore
#line 11 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                      Employee.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, "Photo : ");
            __builder.AddContent(35, 
#nullable restore
#line 12 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
            Employee.Photopath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
