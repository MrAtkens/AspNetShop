#pragma checksum "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16a2b669e01f3c800ebb9199f5259e0c8b84d722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16a2b669e01f3c800ebb9199f5259e0c8b84d722", @"/Views/Orders/Index.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AspNetShop.Domain.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    <a asp-action=\"Create\">Create New</a>\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsPayed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaymentUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeletedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 37 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 40 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsPayed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 43 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaymentUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 46 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeliveryAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 49 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 52 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 55 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeletedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1550, "\"", 1573, 1);
#nullable restore
#line 58 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1565, item.Id, 1565, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1625, "\"", 1648, 1);
#nullable restore
#line 59 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1640, item.Id, 1640, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1702, "\"", 1725, 1);
#nullable restore
#line 60 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
WriteAttributeValue("", 1717, item.Id, 1717, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n            </td>\n        </tr>\n");
#nullable restore
#line 63 "C:\Users\77077\source\repos\AspNetShop\AspNetShop\Views\Orders\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AspNetShop.Domain.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
