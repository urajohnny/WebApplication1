#pragma checksum "/Users/linmengdi/Projects/WebApplication1/WebApplication1/Pages/ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d70aaf75be298daf67cf9b430770a55bed5de0"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/_Imports.razor"
using WebApplication1.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ParentComponent")]
    public partial class ParentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Parent-child example</h1>\r\n\r\n");
            __builder.OpenComponent<WebApplication1.Components.ChildComponent>(1);
            __builder.AddAttribute(2, "Title", "Panel Title from Parent");
            __builder.AddAttribute(3, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/Pages/ParentComponent.razor"
                          ShowMessage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    Content of the child component is supplied\r\n    by the parent component.\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "p");
            __builder.OpenElement(8, "b");
            __builder.AddContent(9, 
#nullable restore
#line 11 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/Pages/ParentComponent.razor"
       messageText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "/Users/linmengdi/Projects/WebApplication1/WebApplication1/Pages/ParentComponent.razor"
       
    private string messageText;

    private void ShowMessage(MouseEventArgs e)
    {
        messageText = $"Blaze a new trail with Blazor! ({e.ScreenX}, {e.ScreenY})";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
