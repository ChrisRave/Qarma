#pragma checksum "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded0fcd5275aa0690ca33b097387515263ea516a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded0fcd5275aa0690ca33b097387515263ea516a", @"/Views/Login/Index.cshtml")]
    #nullable restore
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetQarma.ViewModels.UtilisateurViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Login\Index.cshtml"
   Layout = "_layoutReseauSocial";
    ViewBag.Title = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"offres\">\r\n\r\n    <h4> Présentation de l\'appartement</h4>\r\n    ");
#nullable restore
#line 9 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Login\Index.cshtml"
Write(Model.Utilisateur.Appartement);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    <br>\r\n    <br>\r\n    <br>\r\n\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetQarma.ViewModels.UtilisateurViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
