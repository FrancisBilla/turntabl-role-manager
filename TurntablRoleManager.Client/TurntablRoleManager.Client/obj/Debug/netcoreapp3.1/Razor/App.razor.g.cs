#pragma checksum "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbe8a908e91d1f37b377e2c8e3001b85d79e6734"
// <auto-generated/>
#pragma warning disable 1591
namespace TurntablRoleManager.Client
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
            }
            ));
            __builder.AddAttribute(8, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(10);
                __builder2.AddAttribute(11, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "\\Mac\Home\Documents\Turntabl\Projects\Tutorials\Frontend\ASP.Net Blazor\turntabl-role-manager\TurntablRoleManager.Client\TurntablRoleManager.Client\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\n            ");
                    __builder3.AddMarkupContent(14, "<p>Sorry, there\'s nothing at this address.</p>\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
