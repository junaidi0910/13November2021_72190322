#pragma checksum "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b923ca39ed6a05b401515c6a113adcce8aaf1b36"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "text-center");
            __builder.OpenElement(2, "h1");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
     Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 4 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                         Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "card-img-top");
            __builder.AddAttribute(9, "style", "width: 200px; height:200px;");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 5 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                                                                    Employee.Photopath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                                                                                                        Mouse_Move

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "h4");
            __builder.AddContent(14, 
#nullable restore
#line 6 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
     Koordinat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.AddMarkupContent(16, "<h3>Detail Employee</h3>\r\n            ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, "Employee Id : ");
            __builder.AddContent(19, 
#nullable restore
#line 8 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                              Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, "Firts Name: ");
            __builder.AddContent(23, 
#nullable restore
#line 9 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                            Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, "Last Name : ");
            __builder.AddContent(27, 
#nullable restore
#line 10 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                            Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, "Email : ");
            __builder.AddContent(31, 
#nullable restore
#line 11 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                        Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, "Date Of Birth: ");
            __builder.AddContent(35, 
#nullable restore
#line 12 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                               Employee.DateOfBirth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "p");
            __builder.AddContent(38, "Gender : ");
            __builder.AddContent(39, 
#nullable restore
#line 13 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                         Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "p");
            __builder.AddContent(42, "Department Id : ");
            __builder.AddContent(43, 
#nullable restore
#line 14 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                                Employee.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "p");
            __builder.AddContent(46, "Photo : ");
            __builder.AddContent(47, 
#nullable restore
#line 15 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                        Employee.Photopath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n\r\n");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                                          Button_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, 
#nullable restore
#line 18 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                                                         ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 20 "C:\ProgramKu\UTSBlazor_72190322\Pages\DetailEmployee.razor"
                                     CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "<a href=\"/employeedtl\"><button class=\"btn btn-primary\">Back</button></a>\r\n            ");
            __builder.AddMarkupContent(57, "<a href=\"#\"><button class=\"btn btn-primary\">Edit</button></a>\r\n            ");
            __builder.AddMarkupContent(58, "<a href=\"#\"><button class=\"btn btn-danger\">Hapus</button></a>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
