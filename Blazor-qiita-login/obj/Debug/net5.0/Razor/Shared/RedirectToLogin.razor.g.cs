#pragma checksum "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\Shared\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84b46e102dadaae96317ca19e4d44c40bf99d475"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_qiita_login.Shared
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
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\user\source\repos\Blazor-qiita-login\Blazor-qiita-login\Shared\RedirectToLogin.razor"
      
    [Parameter]
    public string ReturnUrl { get; set; }
    protected override void OnInitialized()
    {
        ReturnUrl = "~/" + ReturnUrl;
        NavigationManager.NavigateTo($"Identity/Account/Login?returnUrl={ ReturnUrl}", forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
