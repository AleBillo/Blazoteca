#pragma checksum "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\Shared\CustomMainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d2128d7d8ba83f8fe4d64121b69de4d40204b5d"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazoteca.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using Blazoteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using Blazoteca.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\_Imports.razor"
using Blazoteca.Data;

#line default
#line hidden
#nullable disable
    public partial class CustomMainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazoteca.Shared.CustomNavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "main");
            __builder.AddAttribute(3, "b-z8srr0w22p");
#nullable restore
#line (6,6)-(6,10) 24 "C:\Users\nicho\Desktop\Scuola\5F\Informatica\Laboratorio\Blazoteca\Shared\CustomMainLayout.razor"
__builder.AddContent(4, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Blazoteca.Shared.Footer>(6);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
