#pragma checksum "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\Zaposlenici.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a28fc31f3454f3cc1a67e19ecdc1952e898c0a8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DolasciOdlasci_Zaposlenici), @"mvc.1.0.view", @"/Views/DolasciOdlasci/Zaposlenici.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DolasciOdlasci/Zaposlenici.cshtml", typeof(AspNetCore.Views_DolasciOdlasci_Zaposlenici))]
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
#line 1 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\Zaposlenici.cshtml"
using Seminarski_fitness_centar_IB130116.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a28fc31f3454f3cc1a67e19ecdc1952e898c0a8a", @"/Views/DolasciOdlasci/Zaposlenici.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7adf9685225585dc35a44130ea54e1ced4cf2ee5", @"/Views/_ViewImports.cshtml")]
    public class Views_DolasciOdlasci_Zaposlenici : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\Zaposlenici.cshtml"
  
    ViewData["Title"] = "Lista zaposlenika";

#line default
#line hidden
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\Zaposlenici.cshtml"
   User user = Context.GetLoggedUser(); 

#line default
#line hidden
            BeginContext(150, 35, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>");
            EndContext();
            BeginContext(186, 17, false);
#line 10 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\Zaposlenici.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(203, 50, true);
            WriteLiteral("</h1>\r\n    <div class=\"jumbotron\">\r\n        <ul>\r\n");
            EndContext();
#line 13 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\Zaposlenici.cshtml"
         foreach (var zaposlenik in Model)
        {

#line default
#line hidden
            BeginContext(308, 28, true);
            WriteLiteral("            <li>Zaposlenik: ");
            EndContext();
            BeginContext(337, 19, false);
#line 15 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\Zaposlenici.cshtml"
                       Write(zaposlenik.Username);

#line default
#line hidden
            EndContext();
            BeginContext(356, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(360, 155, false);
#line 15 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\Zaposlenici.cshtml"
                                              Write(Html.ActionLink("Pregledaj dolaske", "AdminDolasciDetalji", "DolasciOdlasci", routeValues: new { ZaposlenikId = zaposlenik.UserId }, htmlAttributes: null ));

#line default
#line hidden
            EndContext();
            BeginContext(515, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 16 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\DolasciOdlasci\Zaposlenici.cshtml"
        }

#line default
#line hidden
            BeginContext(533, 39, true);
            WriteLiteral("        </ul>\r\n\r\n    </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
