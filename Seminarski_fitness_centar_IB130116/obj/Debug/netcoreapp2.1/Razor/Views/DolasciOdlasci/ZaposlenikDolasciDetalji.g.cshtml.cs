#pragma checksum "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "177bc7813e07bb5812bb4a1e74cda42a4eeb0d51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DolasciOdlasci_ZaposlenikDolasciDetalji), @"mvc.1.0.view", @"/Views/DolasciOdlasci/ZaposlenikDolasciDetalji.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DolasciOdlasci/ZaposlenikDolasciDetalji.cshtml", typeof(AspNetCore.Views_DolasciOdlasci_ZaposlenikDolasciDetalji))]
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
#line 1 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\_ViewImports.cshtml"
using Seminarski_fitness_centar_IB130116;

#line default
#line hidden
#line 2 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\_ViewImports.cshtml"
using Seminarski_fitness_centar_IB130116.Models;

#line default
#line hidden
#line 2 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
using Seminarski_fitness_centar_IB130116.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"177bc7813e07bb5812bb4a1e74cda42a4eeb0d51", @"/Views/DolasciOdlasci/ZaposlenikDolasciDetalji.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7adf9685225585dc35a44130ea54e1ced4cf2ee5", @"/Views/_ViewImports.cshtml")]
    public class Views_DolasciOdlasci_ZaposlenikDolasciDetalji : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Seminarski_fitness_centar_IB130116.ViewModels.DolasciOdlasciVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
  
    ViewData["Title"] = "Lista dolazaka i odlazaka";

#line default
#line hidden
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
   User user = Context.GetLoggedUser(); 

#line default
#line hidden
            BeginContext(231, 35, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>");
            EndContext();
            BeginContext(267, 17, false);
#line 12 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(284, 22, true);
            WriteLiteral("</h1>\r\n    <br/>\r\n    ");
            EndContext();
            BeginContext(307, 160, false);
#line 14 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
Write(Html.ActionLink("PRIJAVI NOVI DOLAZAK SADA", "SnimiDolazak", "DolasciOdlasci", htmlAttributes: new Dictionary<string, object> { { "class", "btn btn-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(467, 57, true);
            WriteLiteral(";\r\n    <hr/>\r\n    <div class=\"jumbotron\">\r\n        <ul>\r\n");
            EndContext();
#line 18 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
             if (Model.Rows.Count > 0)
            {
                

#line default
#line hidden
#line 20 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
                 foreach (var dolazak_odlazak in Model.Rows)
                 {
                     string dodatni_tekst;
                     
                     if (dolazak_odlazak.VrijemeOdlaska.ToString() == "1/1/0001 12:00:00 AM")
                     {

#line default
#line hidden
            BeginContext(847, 46, true);
            WriteLiteral("                         <li>Vrijeme dolaska: ");
            EndContext();
            BeginContext(894, 30, false);
#line 26 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
                                         Write(dolazak_odlazak.VrijemeDolaska);

#line default
#line hidden
            EndContext();
            BeginContext(924, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(928, 163, false);
#line 26 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
                                                                           Write(Html.ActionLink("PRIJAVI ODLAZAK!", "SnimiOdlazak", "DolasciOdlasci", routeValues: new {DolazakOdlazakId = dolazak_odlazak.DolazakOdlazakId}, htmlAttributes: null));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 8, true);
            WriteLiteral(" </li>\r\n");
            EndContext();
#line 27 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
                     }
                     else
                     {

#line default
#line hidden
            BeginContext(1174, 46, true);
            WriteLiteral("                         <li>Vrijeme dolaska: ");
            EndContext();
            BeginContext(1221, 30, false);
#line 30 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
                                         Write(dolazak_odlazak.VrijemeDolaska);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 20, true);
            WriteLiteral(" | Vrijeme odlaska: ");
            EndContext();
            BeginContext(1272, 30, false);
#line 30 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
                                                                                            Write(dolazak_odlazak.VrijemeOdlaska);

#line default
#line hidden
            EndContext();
            BeginContext(1302, 8, true);
            WriteLiteral(" </li>\r\n");
            EndContext();
#line 31 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
                     }
                 }

#line default
#line hidden
#line 32 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
                  
            }
            else
            {

#line default
#line hidden
            BeginContext(1402, 67, true);
            WriteLiteral("                <span>Nema prijavljenih dolazaka/odlazaka!</span>\r\n");
            EndContext();
#line 37 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\ZaposlenikDolasciDetalji.cshtml"
            }

#line default
#line hidden
            BeginContext(1484, 35, true);
            WriteLiteral("        </ul>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Seminarski_fitness_centar_IB130116.ViewModels.DolasciOdlasciVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
