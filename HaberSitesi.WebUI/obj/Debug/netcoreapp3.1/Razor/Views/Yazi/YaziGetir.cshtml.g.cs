#pragma checksum "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Yazi\YaziGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "813cf7d6fa85be8c9710ed67d8e37d941637e495"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Yazi_YaziGetir), @"mvc.1.0.view", @"/Views/Yazi/YaziGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813cf7d6fa85be8c9710ed67d8e37d941637e495", @"/Views/Yazi/YaziGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e5c4f70dcbc2ee827ed245c880d8224857e03e", @"/Views/_ViewImports.cshtml")]
    public class Views_Yazi_YaziGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Yazi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Yazi\YaziGetir.cshtml"
  
    ViewData["Title"] = "YaziGetir";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row d-flex justify-content-center\">\r\n    <img class=\"rounded-circle\" style=\"width:400px; height:300px;\"");
            BeginWriteAttribute("src", " src=\"", 176, "\"", 201, 1);
#nullable restore
#line 7 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Yazi\YaziGetir.cshtml"
WriteAttributeValue("", 182, Model.YaziResimUrl, 182, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <h5 class=\"text-center mt-3\">");
#nullable restore
#line 8 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Yazi\YaziGetir.cshtml"
                            Write(Model.YaziBasligi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <p class=\"text-center\" style=\"font-style:italic;\">");
#nullable restore
#line 9 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Yazi\YaziGetir.cshtml"
                                                 Write(Model.Yazari.YazarAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;");
#nullable restore
#line 9 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Yazi\YaziGetir.cshtml"
                                                                             Write(Model.Yazari.YazarSoyadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p class=\"text-center\" style=\"font-style:normal;\">");
#nullable restore
#line 10 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Yazi\YaziGetir.cshtml"
                                                 Write(Model.YaziTarihi.ToString().Substring(0,10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 11 "E:\derscalismalarim\GitHub Ornek Gelistirme Klasoru\HaberSitesi\HaberSitesi\HaberSitesi.WebUI\Views\Yazi\YaziGetir.cshtml"
  Write(Html.Raw(Model.YaziIcerigi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Yazi> Html { get; private set; }
    }
}
#pragma warning restore 1591
