#pragma checksum "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ae4079eb77a4431c08bb97b48af461cba5b66db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Editor_HaberEkle), @"mvc.1.0.view", @"/Views/Editor/HaberEkle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ae4079eb77a4431c08bb97b48af461cba5b66db", @"/Views/Editor/HaberEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e5c4f70dcbc2ee827ed245c880d8224857e03e", @"/Views/_ViewImports.cshtml")]
    public class Views_Editor_HaberEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HaberInputModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Editor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HaberEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
  
    ViewData["Title"] = "HaberEkle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae4079eb77a4431c08bb97b48af461cba5b66db7212", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae4079eb77a4431c08bb97b48af461cba5b66db8251", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://cdn.ckeditor.com/ckeditor5/27.1.0/classic/ckeditor.js\"></script>\r\n\r\n<style>\r\n    .ck-editor__editable {\r\n        min-width: 1300px;\r\n        min-height: 200px;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae4079eb77a4431c08bb97b48af461cba5b66db9511", async() => {
                WriteLiteral("\r\n    <div class=\"row mt-2\">\r\n        <div class=\"col-md-6\">\r\n            ");
#nullable restore
#line 20 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
       Write(Html.LabelFor(c => c.EditorId, "Editörü", new { @style = "font-weight:bold; font-size:20px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 21 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
       Write(Html.DropDownListFor(c => c.EditorId, (List<SelectListItem>)ViewBag._editor, new { @class = "form-control mt-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            ");
#nullable restore
#line 24 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
       Write(Html.LabelFor(c => c.KategoriId, "Kategorisi", new { @style = "font-weight:bold; font-size:20px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 25 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
       Write(Html.DropDownListFor(c => c.KategoriId, (List<SelectListItem>)ViewBag.kategoriListesi, new { @class = "form-control mt-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row mt-2\">\r\n        <div class=\"col-md-6\">\r\n            ");
#nullable restore
#line 30 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
       Write(Html.LabelFor(c => c.HaberBasligi, "Haber Başlığı", new { @style = "font-weight:bold; font-size:20px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 31 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
       Write(Html.TextBoxFor(c => c.HaberBasligi, new { @class = "form-control mt-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            ");
#nullable restore
#line 34 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
       Write(Html.LabelFor(c => c.HaberAnaResimUrl, "Haber Ana Fotoğrafı", new { @style = "font-weight:bold; font-size:20px;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 35 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
       Write(Html.TextBoxFor(c => c.HaberAnaResimUrl, new { @class = "form-control mt-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row mt-1 d-flex justify-content-center\">\r\n        <label class=\"text-center mt-2 mb-2\" style=\"font-weight:bold; font-size:20px;\">Haber İçeriği</label>\r\n        ");
#nullable restore
#line 40 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
   Write(Html.TextAreaFor(c => c.HaberIcerik, new { @id = "editor1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <script>
            ClassicEditor.create(document.querySelector('#editor1'))
                .then(editor => {
                    editor.ui.view.editable.element.style.width = '1300px';
                    editor.ui.view.editable.element.style.height = '200px';
                })
                .catch(error => {
                    console.error(error);
                });
        </script>
    </div>
    <div class=""row d-flex justify-content-center mt-2"">
        <button class=""btn btn-primary btn-sm"" type=""submit"" style=""width:100px;"">Kaydet</button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae4079eb77a4431c08bb97b48af461cba5b66db15837", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 57 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Editor\HaberEkle.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HaberInputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
