#pragma checksum "C:\Users\lenovo\Desktop\Yeni klasör (2)\Yeni klasör (3)\Polynomtech\Polynomtech\Views\Home\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86e7aa63f915ba8886aac85b44289d02848d8516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Basket), @"mvc.1.0.view", @"/Views/Home/Basket.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Basket.cshtml", typeof(AspNetCore.Views_Home_Basket))]
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
#line 1 "C:\Users\lenovo\Desktop\Yeni klasör (2)\Yeni klasör (3)\Polynomtech\Polynomtech\Views\_ViewImports.cshtml"
using Polynomtech;

#line default
#line hidden
#line 2 "C:\Users\lenovo\Desktop\Yeni klasör (2)\Yeni klasör (3)\Polynomtech\Polynomtech\Views\_ViewImports.cshtml"
using Polynomtech.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86e7aa63f915ba8886aac85b44289d02848d8516", @"/Views/Home/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae256c88850f843b599a4191883f8c0f7b1b3802", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\lenovo\Desktop\Yeni klasör (2)\Yeni klasör (3)\Polynomtech\Polynomtech\Views\Home\Basket.cshtml"
  
    ViewData["Title"] = "Basket";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(91, 546, true);
            WriteLiteral(@"
    <div class=""container"" style=""padding-top:200px"">
        <div class=""row"">
           
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Ürün Adı</th>
                        <th scope=""col"">Marka</th>
                        <th scope=""col"">Fiyat</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody id=""tbodyBasket"">
                </tbody>
            </table>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
