#pragma checksum "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "271ebe60f783672628ebc908a384a35b3f0ed16e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Register/Index.cshtml", typeof(AspNetCore.Views_Register_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"271ebe60f783672628ebc908a384a35b3f0ed16e", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7adf9685225585dc35a44130ea54e1ced4cf2ee5", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Register - Fitness centar";
    Layout = "_LayoutNoFooter";

#line default
#line hidden
            BeginContext(94, 59, true);
            WriteLiteral("\r\n<!-- Registration form -->\r\n<div id=\"RegisterForm\">\r\n    ");
            EndContext();
            BeginContext(154, 24, false);
#line 8 "C:\FIT\RS1\Seminarski_fitness_centar_IB130116\Seminarski_fitness_centar_IB130116\Views\Register\Index.cshtml"
Write(Html.Partial("Register"));

#line default
#line hidden
            EndContext();
            BeginContext(178, 15, true);
            WriteLiteral(";\r\n</div>\r\n\r\n\r\n");
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
