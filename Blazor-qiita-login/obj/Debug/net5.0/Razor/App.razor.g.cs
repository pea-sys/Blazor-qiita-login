#pragma checksum "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "196257240c3405945d8964d881c4cd8d21d73d41"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_qiita_login
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\_Imports.razor"
using Blazor_qiita_login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\_Imports.razor"
using Blazor_qiita_login.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 5 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "PreferExactMatches", 
#nullable restore
#line 5 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(6);
                    __builder3.AddAttribute(7, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 7 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 8 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\App.razor"
                                                typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
#nullable restore
#line 10 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\App.razor"
                      
                        var returnUrl = NavigationManager.ToBaseRelativePath(NavigationManager.Uri);

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Blazor_qiita_login.Shared.RedirectToLogin>(10);
                        __builder4.AddAttribute(11, "ReturnUrl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\App.razor"
                                                     returnUrl

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(12, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "\r\n                    Wait...\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(14, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(15);
                    __builder3.AddAttribute(16, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 21 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(18, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
