#pragma checksum "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94ce61bb03e24068599b5761cfe8abff447de5e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94ce61bb03e24068599b5761cfe8abff447de5e4", @"/Views/Service/Index.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProjetQarma.Models.Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Index.cshtml"
   Layout = "_layoutLanding";
    ViewBag.Title = "ListeService"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Offres de services</h2>
<!-- Icon Divider-->
<div class=""divider-custom"">
    <div class=""divider-custom-line""></div>
    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
    <div class=""divider-custom-line""></div>
</div>
<div class=""row justify-content-start"">
");
#nullable restore
#line 16 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Index.cshtml"
     foreach (var service in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card col-6 m-5\" style=\"width: 18rem;\">\r\n    <div class=\"card-body d-flex flex-column justify-content-between\">\r\n        <div>\r\n            <h5 class=\"card-title\"> Identifiant du service : ");
#nullable restore
#line 22 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Index.cshtml"
                                                        Write(service.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n            <h6 class=\"card-subtitle mb-2 text-muted\">Coût du service : ");
#nullable restore
#line 24 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Index.cshtml"
                                                                   Write(service.MontantBisous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 25 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Index.cshtml"
                                                 Write(service.TypeService);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p class=\"card-text\">");
#nullable restore
#line 26 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Index.cshtml"
                            Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>");
#nullable restore
#line 31 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 32 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Index.cshtml"
Write(Html.ActionLink("Créer un nouveau service", "Creer", "Service"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProjetQarma.Models.Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
