#pragma checksum "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f367aca30aed6b7d1aee75c5edb02752da5c6200"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\_ViewImports.cshtml"
using HaberSitesi.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\_ViewImports.cshtml"
using HaberSitesi.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\_ViewImports.cshtml"
using HaberSitesi.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\_ViewImports.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f367aca30aed6b7d1aee75c5edb02752da5c6200", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e5c4f70dcbc2ee827ed245c880d8224857e03e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Haber>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Haber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HaberGetir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white; text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 7 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <p class=\"h3 alert-danger\">Ekli haber yok!</p>\r\n        </div>\r\n");
#nullable restore
#line 12 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-8"">
                <div id=""carouselExampleDark"" style=""width:800px; height:480px;"" class=""carousel carousel-dark slide"" data-bs-ride=""carousel"">
                    <div class=""carousel-indicators"">
");
#nullable restore
#line 19 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                         for (int i = 0; i < Model.Count; i++)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" data-bs-target=\"#carouselExampleDark\" data-bs-slide-to=\"");
#nullable restore
#line 23 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\" aria-current=\"true\" aria-label=\"Slide 1\"></button>\r\n");
#nullable restore
#line 24 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" data-bs-target=\"#carouselExampleDark\" data-bs-slide-to=\"");
#nullable restore
#line 27 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-label=\"Slide 2\"></button>\r\n");
#nullable restore
#line 28 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 32 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                         for (int i = 0; i < Model.Count; i++)
                        {

                            int sure = (i + 1) * 1000;

                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item active\" data-bs-interval=\"");
#nullable restore
#line 39 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                                                                               Write(sure);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1603, "\"", 1635, 1);
#nullable restore
#line 40 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1609, Model[i].HaberAnaResimUrl, 1609, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" alt=\"...\">\r\n                                    <div class=\"carousel-caption d-none d-md-block\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f367aca30aed6b7d1aee75c5edb02752da5c620010877", async() => {
                WriteLiteral("<h5 style=\"color:darkred; font-weight:bold;\">");
#nullable restore
#line 42 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                                                                                                                                                                                              Write(Model[i].HaberBasligi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                                                                                            WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 45 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item\" data-bs-interval=\"");
#nullable restore
#line 48 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                                                                        Write(sure);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2291, "\"", 2323, 1);
#nullable restore
#line 49 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2297, Model[i].HaberAnaResimUrl, 2297, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" alt=\"...\">\r\n                                    <div class=\"carousel-caption d-none d-md-block mt-5\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f367aca30aed6b7d1aee75c5edb02752da5c620015358", async() => {
                WriteLiteral("<h5 style=\"color:darkred; font-weight:bold;\">");
#nullable restore
#line 51 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                                                                                                                                                                                              Write(Model[i].HaberBasligi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                                                                                            WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 54 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                    <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleDark"" data-bs-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""visually-hidden"">Previous</span>
                    </button>
                    <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleDark"" data-bs-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""visually-hidden"">Next</span>
                    </button>
                </div>
            </div>
            <div class=""col-md-4"" style=""margin-left:-40px;"">
                <div class=""row"">");
#nullable restore
#line 70 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                            Write(await Component.InvokeAsync("Yorumlar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"row\">");
#nullable restore
#line 71 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
                            Write(await Component.InvokeAsync("Harita"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 74 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n</div>\r\n<div class=\"row\">\r\n    <h1 class=\"display-3 text-center\">Güncel Yazılar</h1>\r\n    <div class=\"row mt-3\">\r\n        ");
#nullable restore
#line 80 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("GuncelYazilar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>
<div class=""row mt-5"" style=""height:100px; background-color:#c0392b;"">
    <div class=""col-md-6 d-flex justify-content-end mt-5"">
        <p style=""color:white;"">Bu sitenin tüm hakları saklıdır.&reg;</p>
    </div>
    <div class=""col-md-6 d-flex justify-content-end mt-5"">
        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f367aca30aed6b7d1aee75c5edb02752da5c620021332", async() => {
                WriteLiteral("Editör veya Yazar mısınız?");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Haber>> Html { get; private set; }
    }
}
#pragma warning restore 1591
