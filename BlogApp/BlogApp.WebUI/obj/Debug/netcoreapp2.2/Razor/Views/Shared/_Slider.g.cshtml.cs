#pragma checksum "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31e72727adb7fc91f7f4c903b1a0d5f07e68a701"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Slider), @"mvc.1.0.view", @"/Views/Shared/_Slider.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Slider.cshtml", typeof(AspNetCore.Views_Shared__Slider))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e72727adb7fc91f7f4c903b1a0d5f07e68a701", @"/Views/Shared/_Slider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17871605585b9cacbd9dbdea6982b0a8efc479fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Slider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 124, true);
            WriteLiteral("\r\n\r\n<div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <ol class=\"carousel-indicators\">\r\n");
            EndContext();
#line 6 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
         for (int i = 0; i < Model.Count(); i++)
        {
            if (i == 0)
            {

#line default
#line hidden
            BeginContext(251, 76, true);
            WriteLiteral("                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(328, 1, false);
#line 10 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(329, 24, true);
            WriteLiteral("\" class=\"active\"></li>\r\n");
            EndContext();
#line 11 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(401, 76, true);
            WriteLiteral("                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(478, 1, false);
#line 14 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(479, 9, true);
            WriteLiteral("\"></li>\r\n");
            EndContext();
#line 15 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(514, 64, true);
            WriteLiteral("\r\n    </ol>\r\n    <div class=\"carousel-inner\" role=\"listbox\">\r\n\r\n");
            EndContext();
#line 21 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
           var index = 0;

#line default
#line hidden
            BeginContext(606, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 22 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
         foreach (var item in Model)
        {
            if (index == 0)
            {

#line default
#line hidden
            BeginContext(699, 72, true);
            WriteLiteral("                <div class=\"carousel-item active\">\r\n                    ");
            EndContext();
            BeginContext(771, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31e72727adb7fc91f7f4c903b1a0d5f07e68a7016221", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 807, "~/img/", 807, 6, true);
#line 27 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 813, item.Image, 813, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 27 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 831, item.Title, 831, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(844, 100, true);
            WriteLiteral("\r\n                    <div class=\"carousel-caption d-none d-md-block\">\r\n                        <h3>");
            EndContext();
            BeginContext(945, 10, false);
#line 29 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(955, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(990, 16, false);
#line 30 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 33 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"

                index++;
            }
            else
            {

#line default
#line hidden
            BeginContext(1140, 65, true);
            WriteLiteral("                <div class=\"carousel-item\">\r\n                    ");
            EndContext();
            BeginContext(1205, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31e72727adb7fc91f7f4c903b1a0d5f07e68a7019537", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1241, "~/img/", 1241, 6, true);
#line 39 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 1247, item.Image, 1247, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
AddHtmlAttributeValue("", 1265, item.Title, 1265, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1278, 100, true);
            WriteLiteral("\r\n                    <div class=\"carousel-caption d-none d-md-block\">\r\n                        <h3>");
            EndContext();
            BeginContext(1379, 10, false);
#line 41 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1389, 34, true);
            WriteLiteral("</h3>\r\n                        <p>");
            EndContext();
            BeginContext(1424, 16, false);
#line 42 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1440, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 45 "C:\Users\jemal\source\repos\BlogApp\BlogApp.WebUI\Views\Shared\_Slider.cshtml"
            }

        }

#line default
#line hidden
            BeginContext(1526, 528, true);
            WriteLiteral(@"
    </div>
    <button class=""carousel-control-prev"" type=""button"" data-target=""#carouselExampleIndicators"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </button>
    <button class=""carousel-control-next"" type=""button"" data-target=""#carouselExampleIndicators"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591