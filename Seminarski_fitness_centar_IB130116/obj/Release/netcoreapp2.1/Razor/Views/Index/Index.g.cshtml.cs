#pragma checksum "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4b2b24cac0801a37f9f6dc9d08b38083d99f2fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index_Index), @"mvc.1.0.view", @"/Views/Index/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Index/Index.cshtml", typeof(AspNetCore.Views_Index_Index))]
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
#line 2 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
using Seminarski_fitness_centar_IB130116.Models;

#line default
#line hidden
#line 1 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
using Seminarski_fitness_centar_IB130116.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4b2b24cac0801a37f9f6dc9d08b38083d99f2fa", @"/Views/Index/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7adf9685225585dc35a44130ea54e1ced4cf2ee5", @"/Views/_ViewImports.cshtml")]
    public class Views_Index_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(100, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
  
    ViewData["Title"] = "Dobrodošli u fitness centar";

#line default
#line hidden
            BeginContext(167, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
   User user = Context.GetLoggedUser(); 

#line default
#line hidden
            BeginContext(212, 35, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>");
            EndContext();
            BeginContext(248, 17, false);
#line 12 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(265, 112, true);
            WriteLiteral("</h1>\r\n    <div class=\"jumbotron\">\r\n        <div class=\"row\">\r\n            <h2>Opcije:</h2>\r\n            <b><li>");
            EndContext();
            BeginContext(378, 56, false);
#line 16 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
              Write(Html.ActionLink("Obavjestenja", "Index", "Obavjestenja"));

#line default
#line hidden
            EndContext();
            BeginContext(434, 11, true);
            WriteLiteral("</li></b>\r\n");
            EndContext();
#line 17 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
             if (user.Role >= 1)
            {

#line default
#line hidden
            BeginContext(494, 23, true);
            WriteLiteral("                <b><li>");
            EndContext();
            BeginContext(518, 90, false);
#line 19 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
                  Write(Html.ActionLink("Pregledaj dolaske i odlaske zaposlenih", "Zaposlenici", "DolasciOdlasci"));

#line default
#line hidden
            EndContext();
            BeginContext(608, 11, true);
            WriteLiteral("</li></b>\r\n");
            EndContext();
#line 20 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(667, 23, true);
            WriteLiteral("                <b><li>");
            EndContext();
            BeginContext(691, 102, false);
#line 23 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
                  Write(Html.ActionLink("Prijavi i pregledaj odlaske i dolaske", "ZaposlenikDolasciDetalji", "DolasciOdlasci"));

#line default
#line hidden
            EndContext();
            BeginContext(793, 11, true);
            WriteLiteral("</li></b>\r\n");
            EndContext();
#line 24 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(819, 163, true);
            WriteLiteral("        </div>\r\n        <br />\r\n        <br />\r\n        <div class=\"row\">\r\n            <h2><b>Samo za testiranje: </b></h2>\r\n            <ul>\r\n                <li>");
            EndContext();
            BeginContext(983, 68, false);
#line 31 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
               Write(Html.ActionLink("Uloguj se kao master Admin", "LogAsAdmin", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(1079, 71, false);
#line 32 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Index\Index.cshtml"
               Write(Html.ActionLink("Uloguj se kao zaposlenik", "LogAsZaposlenik", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 156, true);
            WriteLiteral("</li>\r\n            </ul>\r\n            <span>Odmah prebacuje izmedju razlicitih tipova korisnika bez logovanja</span>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>");
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
