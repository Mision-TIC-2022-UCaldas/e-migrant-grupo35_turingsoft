#pragma checksum "C:\HACKATON\e-migrant-grupo35_turingsoft\ProyectoE_Migrantv2\E_Migrant.App\E_Migrant.App.Frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae54c3bfa2369ed35a3bfcff3ae73cc3029372c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(E_Migrant.App.Frontend.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace E_Migrant.App.Frontend.Pages
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
#line 1 "C:\HACKATON\e-migrant-grupo35_turingsoft\ProyectoE_Migrantv2\E_Migrant.App\E_Migrant.App.Frontend\Pages\_ViewImports.cshtml"
using E_Migrant.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae54c3bfa2369ed35a3bfcff3ae73cc3029372c1", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b064261e4a6778155f5e1d205d3aeef257a1477", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\HACKATON\e-migrant-grupo35_turingsoft\ProyectoE_Migrantv2\E_Migrant.App\E_Migrant.App.Frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Bienvenido a E-Migrant</h1>
    <p>Con la construcción de esta aplicación se busca contribuir a la creación de canales de
        comunicación y apoyo efectivos para la gran cantidad de inmigrantes que están llegando
        al país y que en los últimos años se ha venido incrementado, en parte por la migración
        de ciudadanos venezolanos. Esto ha generado la necesidad de ofrecer apoyo a los
        diferentes problemas a los que se enfrentan al llegar al país, entre ellos: a) satisfacer sus
        necesidades básicas (comida, alojamiento, transporte), b) desempleo, c) acceder a los
        servicios de salud, d) integración social y cultural, e) comunicación con sus familias en el
        país de origen.
        Específicamente se busca el análisis, diseño y desarrollo de un prototipo computacional
        para crear redes de comunicación y apoyo a los inmigrantes residentes en Colombia (no
        solo de Venezuela). La idea es conectar");
            WriteLiteral(" a la población inmigrante más vulnerable con:\r\n        entidades del estado, organizaciones no gubernamentales, inmigrantes con capacidad\r\n        económica que estén dispuestos a ayudar, grupos de apoyo, etc.</p>\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591