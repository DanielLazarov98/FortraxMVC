#pragma checksum "D:\Projects\web\FortraxMVC\FortraxMVC\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "440b88da241ac883df3f296cd0657450b7d87996"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Details.cshtml", typeof(AspNetCore.Views_Orders_Details))]
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
#line 1 "D:\Projects\web\FortraxMVC\FortraxMVC\Views\_ViewImports.cshtml"
using FortraxMVC;

#line default
#line hidden
#line 2 "D:\Projects\web\FortraxMVC\FortraxMVC\Views\_ViewImports.cshtml"
using FortraxMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"440b88da241ac883df3f296cd0657450b7d87996", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef980e921bf12ade1ca651c06f5ce7ff139e1345", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FortraxMVC.ViewModels.OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\web\FortraxMVC\FortraxMVC\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 22, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n");
            EndContext();
#line 10 "D:\Projects\web\FortraxMVC\FortraxMVC\Views\Orders\Details.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
            BeginContext(199, 15, true);
            WriteLiteral("<div>\r\n    <h3>");
            EndContext();
            BeginContext(215, 17, false);
#line 13 "D:\Projects\web\FortraxMVC\FortraxMVC\Views\Orders\Details.cshtml"
   Write(order.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(232, 15, true);
            WriteLiteral("</h3>\r\n    <h3>");
            EndContext();
            BeginContext(248, 14, false);
#line 14 "D:\Projects\web\FortraxMVC\FortraxMVC\Views\Orders\Details.cshtml"
   Write(order.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(262, 15, true);
            WriteLiteral("</h3>\r\n    <h3>");
            EndContext();
            BeginContext(278, 14, false);
#line 15 "D:\Projects\web\FortraxMVC\FortraxMVC\Views\Orders\Details.cshtml"
   Write(order.IssuedOn);

#line default
#line hidden
            EndContext();
            BeginContext(292, 15, true);
            WriteLiteral("</h3>\r\n</div>\r\n");
            EndContext();
#line 17 "D:\Projects\web\FortraxMVC\FortraxMVC\Views\Orders\Details.cshtml"

}

#line default
#line hidden
            BeginContext(312, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FortraxMVC.ViewModels.OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591