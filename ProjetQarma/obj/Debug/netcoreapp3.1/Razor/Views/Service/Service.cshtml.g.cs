#pragma checksum "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a39b029c026557484e2b0d481f4def56ca177fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Service), @"mvc.1.0.view", @"/Views/Service/Service.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a39b029c026557484e2b0d481f4def56ca177fc", @"/Views/Service/Service.cshtml")]
    public class Views_Service_Service : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetQarma.ViewModels.ServiceViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
  
    Layout = "_layoutLanding";
    ViewBag.Title = "Service";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""contenu"">
    <div class=""row"">
        <div class=""col-md-5 offset-md-5 "">
            Offres de services
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-10 offset-md-1 bordureAucune"">
        </div>
    </div>
    <div class=""row"" align=""center"">
        <div class=""col-md-4  bordureBleue1"">
            <img src=""/photos/emoji1.png"" width=""40%"" id=""logo"">
            <div style=""color : ghostwhite"">
                <div>
                    <div>
                        Service proposé par :");
#nullable restore
#line 22 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                        Write(Model.Utilisateur.InfosPersos.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 23 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                   Write(Model.Utilisateur.InfosPersos.Prenom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>                    <div> Coordonnées : </div>\r\n                    <div>\r\n                        <div>");
#nullable restore
#line 26 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                        Write(Model.Utilisateur.Adresse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div>Mail : ");
#nullable restore
#line 27 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                               Write(Model.Utilisateur.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div>Téléphone : ");
#nullable restore
#line 28 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                    Write(Model.Utilisateur.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div>Niveau Qarma : ");
#nullable restore
#line 29 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                       Write(Model.Utilisateur.Qarma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                <div>Type de service : ");
#nullable restore
#line 32 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                  Write(Model.Service.TypeService);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div>Cout en bisous :  ");
#nullable restore
#line 33 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                  Write(Model.Service.MontantBisous);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
        </div>
        <div class=""col-md-4  bordureBleue1"">
            <div id=""contenu"">
                <img src=""/photos/emoji2.png"" width=""40%"" id=""logo"">
                <div style=""color : ghostwhite"">
                    <div>
                        <div>
                            Service proposé par :                            ");
#nullable restore
#line 42 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                                                        Write(Model.Utilisateur.InfosPersos.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 43 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                       Write(Model.Utilisateur.InfosPersos.Prenom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>                        <div> Coordonnées : </div>\r\n                        <div>\r\n                            <div>");
#nullable restore
#line 46 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                            Write(Model.Utilisateur.Adresse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>Mail : ");
#nullable restore
#line 47 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                   Write(Model.Utilisateur.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>Téléphone : ");
#nullable restore
#line 48 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                        Write(Model.Utilisateur.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>Niveau Qarma : ");
#nullable restore
#line 49 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                           Write(Model.Utilisateur.Qarma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n                     <div>Type de service : ");
#nullable restore
#line 52 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                       Write(Model.Service.TypeService);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>  \r\n                    <div>Cout en bisous :  ");
#nullable restore
#line 53 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                      Write(Model.Service.MontantBisous);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
            </div>
        </div>
        <div class=""col-md-4  bordureBleue1"">
            <div id=""contenu"">
                <img src=""/photos/emoji3.png"" width=""40%"" id=""logo"">
                <div style=""color : ghostwhite"">
                    <div>
                        <div>
                            Service proposé par :                            ");
#nullable restore
#line 63 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                                                        Write(Model.Utilisateur.InfosPersos.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 64 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                       Write(Model.Utilisateur.InfosPersos.Prenom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>                        <div> Coordonnées : </div>\r\n                        <div>\r\n                            <div>");
#nullable restore
#line 67 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                            Write(Model.Utilisateur.Adresse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>Mail : ");
#nullable restore
#line 68 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                   Write(Model.Utilisateur.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>Téléphone : ");
#nullable restore
#line 69 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                        Write(Model.Utilisateur.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>Niveau Qarma : ");
#nullable restore
#line 70 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                           Write(Model.Utilisateur.Qarma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n                    <div>Type de service : ");
#nullable restore
#line 73 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                      Write(Model.Service.TypeService);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div>Cout en bisous :  ");
#nullable restore
#line 74 "/Users/operateur/git/Qarma/ProjetQarma/Views/Service/Service.cshtml"
                                      Write(Model.Service.MontantBisous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetQarma.ViewModels.ServiceViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
