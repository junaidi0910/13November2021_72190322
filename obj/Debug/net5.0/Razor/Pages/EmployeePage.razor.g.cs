#pragma checksum "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "618c1f6f766e628a14595bbe1d9068cccaf3495c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeepage")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee List</h3>");
#nullable restore
#line 5 "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor"
 if(Employees == null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"spinner\"></div>");
#nullable restore
#line 7 "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck");
#nullable restore
#line 11 "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor"
     foreach (var emp in Employees)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card m-3");
            __builder.AddAttribute(6, "style", "min-width: 18rem; max-width:30%");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor"
                     emp.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor"
                                    emp.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 17 "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor"
                                                               emp.Photopath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-footer text-center");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", 
#nullable restore
#line 19 "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor"
                           $"employeedetail/{emp.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "class", "btn btn-primary m-1");
            __builder.AddContent(23, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 20 "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor"
                           $"editemployee/{emp.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-primary m-1");
            __builder.AddContent(28, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.AddMarkupContent(30, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 26 "C:\ProgramKu\UTSBlazor_72190322\Pages\EmployeePage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591