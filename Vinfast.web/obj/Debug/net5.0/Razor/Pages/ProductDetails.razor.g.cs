#pragma checksum "D:\Vinfast\Vinfast.web\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fe8555ebf3e4dc37a9e8825ff75b398cd84f30b"
// <auto-generated/>
#pragma warning disable 1591
namespace Vinfast.web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Vinfast\Vinfast.web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Vinfast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Vinfast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Vinfast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Vinfast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Vinfast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Vinfast\Vinfast.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Vinfast\Vinfast.web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Vinfast\Vinfast.web\_Imports.razor"
using Vinfast.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Vinfast\Vinfast.web\_Imports.razor"
using Vinfast.web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productdetails/{id}")]
    public partial class ProductDetails : ProductDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row justify-content-center m-3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-sm-8");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header");
            __builder.OpenElement(8, "h1");
            __builder.AddContent(9, 
#nullable restore
#line 7 "D:\Vinfast\Vinfast.web\Pages\ProductDetails.razor"
                     Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body text-center");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", "/");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "class", "card-img-top");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 12 "D:\Vinfast\Vinfast.web\Pages\ProductDetails.razor"
                                                    Product.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\Vinfast\Vinfast.web\Pages\ProductDetails.razor"
                                        Mouse_Move

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "  \r\n                ");
            __builder.OpenElement(20, "h1");
            __builder.AddContent(21, 
#nullable restore
#line 15 "D:\Vinfast\Vinfast.web\Pages\ProductDetails.razor"
                     Coordinates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "h4");
            __builder.AddContent(24, "Product ID : ");
            __builder.AddContent(25, 
#nullable restore
#line 16 "D:\Vinfast\Vinfast.web\Pages\ProductDetails.razor"
                                  Product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n                ");
            __builder.OpenElement(27, "h4");
            __builder.AddContent(28, "Price : ");
            __builder.AddContent(29, 
#nullable restore
#line 18 "D:\Vinfast\Vinfast.web\Pages\ProductDetails.razor"
                             Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\Vinfast\Vinfast.web\Pages\ProductDetails.razor"
                                                           Button_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, 
#nullable restore
#line 19 "D:\Vinfast\Vinfast.web\Pages\ProductDetails.razor"
                                                                          ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n           \r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 22 "D:\Vinfast\Vinfast.web\Pages\ProductDetails.razor"
                                                 CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "<a href=\"https://localhost:44303/allproduct\" class=\"btn btn-primary\">Back</a>\r\n                ");
            __builder.AddMarkupContent(39, "<a href=\"#\" class=\"btn btn-primary\">Edit</a>\r\n                ");
            __builder.AddMarkupContent(40, "<a href=\"#\" class=\"btn btn-danger\">Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591