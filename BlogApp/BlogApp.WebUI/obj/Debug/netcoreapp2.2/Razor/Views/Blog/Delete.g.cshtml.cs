#pragma checksum "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc4ad2e6f8fb10f4996d5c5f7bc130a32049cc28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Delete), @"mvc.1.0.view", @"/Views/Blog/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Delete.cshtml", typeof(AspNetCore.Views_Blog_Delete))]
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
#line 1 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.Entity;

#line default
#line hidden
#line 2 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4ad2e6f8fb10f4996d5c5f7bc130a32049cc28", @"/Views/Blog/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17871605585b9cacbd9dbdea6982b0a8efc479fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(107, 15, true);
            WriteLiteral("\r\n<h2>\r\n    <b>");
            EndContext();
            BeginContext(123, 11, false);
#line 8 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Blog\Delete.cshtml"
  Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(134, 236, true);
            WriteLiteral("</b> İsimli Kaydi Silmek İstiyor musunuz?\r\n</h2>\r\n<form asp-controller=\"Blog\" asp-action=\"Delete\" method=\"post\">\r\n    <input type=\"hidden\" asp-for=\"BlogId\" />\r\n    <button type=\"submit\" class=\"btn btn-dager\">Delete</button>\r\n</form>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
