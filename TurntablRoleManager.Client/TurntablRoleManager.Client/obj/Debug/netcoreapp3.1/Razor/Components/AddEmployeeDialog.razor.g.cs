#pragma checksum "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445c8fb8d4ff5e9087458b43484bfae2d2261b3e"
// <auto-generated/>
#pragma warning disable 1591
namespace TurntablRoleManager.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\_Imports.razor"
using TurntablRoleManager.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class AddEmployeeDialog : AddEmployeeDialogBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
 if (ShowDialog)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show d-block");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddAttribute(9, "role", "document");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<h5 class=\"modal-title\" id=\"titleLabel\"><strong>Add New Role</strong></h5>\r\n                    ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "close");
            __builder.AddAttribute(21, "data-dismiss", "modal");
            __builder.AddAttribute(22, "aria-label", "Close");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                                                                          Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "modal-body");
            __builder.AddMarkupContent(30, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(31);
            __builder.AddAttribute(32, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                      EmployeeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                                     HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.AddMarkupContent(39, "<label for=\"firstname\">First Name : </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "id", "firstname");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "placeholder", "Enter firstname");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                                                         EmployeeModel.EmployeeFirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EmployeeModel.EmployeeFirstName = __value, EmployeeModel.EmployeeFirstName))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EmployeeModel.EmployeeFirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __builder2.AddMarkupContent(52, "<label for=\"lastname\">Last Name : </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "id", "lastname");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "placeholder", "Enter lastname");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                                                        EmployeeModel.EmployeeLastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EmployeeModel.EmployeeLastName = __value, EmployeeModel.EmployeeLastName))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EmployeeModel.EmployeeLastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __builder2.AddMarkupContent(64, "\r\n                            ");
                __builder2.AddMarkupContent(65, "<label for=\"email\">Email : </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "id", "email");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "placeholder", "Enter email");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                                                     EmployeeModel.EmployeeEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EmployeeModel.EmployeeEmail = __value, EmployeeModel.EmployeeEmail))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EmployeeModel.EmployeeEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group");
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.AddMarkupContent(78, "<label for=\"address\">Address : </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "id", "address");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "placeholder", "Enter address");
                __builder2.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                                                       EmployeeModel.EmployeeAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EmployeeModel.EmployeeAddress = __value, EmployeeModel.EmployeeAddress))));
                __builder2.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EmployeeModel.EmployeeAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group");
                __builder2.AddMarkupContent(90, "\r\n                            ");
                __builder2.AddMarkupContent(91, "<label for=\"role\">Role(s) : </label>\r\n                            ");
                __builder2.OpenElement(92, "select");
                __builder2.AddAttribute(93, "class", "form-control");
                __builder2.AddAttribute(94, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                                 SelectedRole

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedRole = __value, SelectedRole));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(96, "\r\n");
#nullable restore
#line 38 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                 foreach (var role in Roles)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(97, "                                    ");
                __builder2.OpenElement(98, "option");
                __builder2.AddAttribute(99, "value", 
#nullable restore
#line 40 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                    role.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(100, 
#nullable restore
#line 40 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                              role.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n");
#nullable restore
#line 41 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(102, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                     \r\n                        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "modal-footer");
                __builder2.AddMarkupContent(107, "\r\n                            ");
                __builder2.OpenElement(108, "button");
                __builder2.AddAttribute(109, "type", "submit");
                __builder2.AddAttribute(110, "disabled", 
#nullable restore
#line 46 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                              DisableButton

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(111, "class", "btn btn-primary");
                __builder2.AddContent(112, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n                            ");
                __builder2.OpenElement(114, "button");
                __builder2.AddAttribute(115, "type", "button");
                __builder2.AddAttribute(116, "class", "btn btn-secondary");
                __builder2.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
                                                                                      Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(118, "data-dismiss", "modal");
                __builder2.AddContent(119, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(122, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 56 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 59 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
 if (ShowBackdrop)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(128, "    <div class=\"modal-backdrop fade show\"></div>\r\n");
#nullable restore
#line 62 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\Components\AddEmployeeDialog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
