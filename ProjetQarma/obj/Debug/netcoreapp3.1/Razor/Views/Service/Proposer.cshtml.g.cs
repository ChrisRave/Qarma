#pragma checksum "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35bb094d74f0a6d92878084bc1ba2b05748bae4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Proposer), @"mvc.1.0.view", @"/Views/Service/Proposer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35bb094d74f0a6d92878084bc1ba2b05748bae4e", @"/Views/Service/Proposer.cshtml")]
    #nullable restore
    public class Views_Service_Proposer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetQarma.Models.Proposition>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
   Layout = "_layoutAccueil";
  ViewBag.Title = "Proposer"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Propositions</h2>
<!-- Icon Divider-->
<div></div> class=""divider-custom"">
    <div class=""divider-custom-line""></div>
    <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
    <div class=""divider-custom-line""></div>
    

<div class=""row justify-content-center"">
    <div class=""col-lg-8 col-xl-7"">

");
#nullable restore
#line 18 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
             using (Html.BeginForm("Proposer", "Service", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-floating mb-3\">\r\n                ");
#nullable restore
#line 22 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.TextBoxFor(model => model.Titre, new { @class = "form-control", placeholder = "Titre " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 23 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.LabelFor(model => model.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 24 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.ValidationMessageFor(model => model.Titre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n                <div class=\"form-floating mb-3\">\r\n                ");
#nullable restore
#line 27 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.DropDownListFor(model => model.TypeService, Html.GetEnumSelectList<ProjetQarma.Models.TypeService>(), new { @class = "form-control", placeholder = "Type de service" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.LabelFor(model => model.TypeService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 29 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.ValidationMessageFor(model => model.TypeService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-floating mb-3\">\r\n                ");
#nullable restore
#line 33 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.TextBoxFor(model => model.MontantBisous, new { @class = "form-control", placeholder = "Cout du service " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 34 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.LabelFor(model => model.MontantBisous));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 35 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.ValidationMessageFor(model => model.MontantBisous));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-floating mb-3\">\r\n                ");
#nullable restore
#line 39 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.TextAreaFor(model => model.Description, new { @class = "form-control", placeholder = "Description" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 40 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 41 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
           Write(Html.HiddenFor(model=>model.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"d-flex flex-row my-3\">\r\n                        <div class=\"mb-3 d-flex\">\r\n                            <div>\r\n                                ");
#nullable restore
#line 48 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
                           Write(Html.LabelFor(model => model.Image, new { id = "imageLabel", @style = "text-align:center;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 49 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
                           Write(Html.TextBoxFor(model => model.Image, new { placeholder = "Description", @type = "file" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                       \r\n                    </div>\r\n");
            WriteLiteral("                <!-- Submit Button-->\r\n");
            WriteLiteral("                    <button class=\"btn btn-primary btn-xl\" type=\"submit\" href=\"~/Home/Landing\">Proposer</button>\r\n");
#nullable restore
#line 61 "C:\Users\ravel\OneDrive\Documents\CDA 18\Projet Copropriété\Qarma\ProjetQarma\Views\Service\Proposer.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetQarma.Models.Proposition> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
