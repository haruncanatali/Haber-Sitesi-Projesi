#pragma checksum "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Shared\Components\Harita\HaritaView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27437846daa5304ea804fbb942794c3b015a7da3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Harita_HaritaView), @"mvc.1.0.view", @"/Views/Shared/Components/Harita/HaritaView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27437846daa5304ea804fbb942794c3b015a7da3", @"/Views/Shared/Components/Harita/HaritaView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e5c4f70dcbc2ee827ed245c880d8224857e03e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Harita_HaritaView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card mt-2 border-0"" style=""width: 25rem;"">
    <div class=""card-header"" style=""background-color:darkred;"">
        <span style=""font-weight:bold; color:white;"">??irketimizin Merkezi</span>
    </div>
    <div class=""card-body p-2"">
        <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d2514.5777819379987!2d31.790145208542352!3d41.45324139332379!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1str!2str!4v1619277095507!5m2!1str!2str"" width=""350"" height=""130"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 514, "\"", 532, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n    </div>\r\n</div>");
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
