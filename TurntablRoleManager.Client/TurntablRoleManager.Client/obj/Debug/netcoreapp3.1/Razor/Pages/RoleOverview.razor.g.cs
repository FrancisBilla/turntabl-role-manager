#pragma checksum "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "621a34fdfd408946a17a380c34c94a63e10beaf5"
// <auto-generated/>
#pragma warning disable 1591
namespace TurntablRoleManager.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/roles")]
    public partial class RoleOverview : RoleBaseOverview
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<div class=\"breadcrubTitle\">\r\n            <h3>Role</h3>\r\n        </div>\r\n");
#nullable restore
#line 8 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
         if (Roles == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "            ");
            __builder.AddMarkupContent(5, "<div class=\"text-center\">\r\n                <div class=\"spinner-border\" role=\"status\">\r\n                    <span class=\"sr-only\">Loading...</span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 15 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
        }
        else
        {


#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-hover");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddMarkupContent(10, @"<thead>
                    <tr>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Description</th>
                        <th scope=""col"">Action</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n              \r\n");
#nullable restore
#line 29 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
                     foreach (var role in Roles)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                        ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 32 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
                                 role.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 33 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
                                 role.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n                      \r\n                                ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
                                                    () => QuickEditRole(role.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "title", "Edit Role?");
            __builder.AddAttribute(27, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(28, "\r\n                                    <i class=\"fas fa-edit\"></i>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 41 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 44 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
                   QuickAddRole

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "btn btn-primary table-btn quick-add-btn");
            __builder.AddContent(40, "  +  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.OpenComponent<TurntablRoleManager.Client.Components.AddRoleDialog>(42);
            __builder.AddAttribute(43, "CloseEventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 48 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
                                                         AddRoleDialog_OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(44, (__value) => {
#nullable restore
#line 48 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
                     AddRoleDialog = (TurntablRoleManager.Client.Components.AddRoleDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.OpenComponent<TurntablRoleManager.Client.Components.EditRoleDialog>(46);
            __builder.AddAttribute(47, "CloseEventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 49 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
                                                           EditRoleDialog_OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(48, (__value) => {
#nullable restore
#line 49 "C:\Users\Mr. Erbynn\dev\TURNTABL\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Pages\RoleOverview.razor"
                      EditRoleDialog = (TurntablRoleManager.Client.Components.EditRoleDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591