#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Informes\InformePlanificacion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b613b126e15355ec44ade69ae216417d99652ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Informes.Pages_Informes_InformePlanificacion), @"mvc.1.0.razor-page", @"/Pages/Informes/InformePlanificacion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Informes/InformePlanificacion.cshtml", typeof(Esecure2.Pages.Informes.Pages_Informes_InformePlanificacion), null)]
namespace Esecure2.Pages.Informes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\_ViewImports.cshtml"
using Esecure2;

#line default
#line hidden
#line 3 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\_ViewImports.cshtml"
using Esecure2.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b613b126e15355ec44ade69ae216417d99652ca", @"/Pages/Informes/InformePlanificacion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Informes_InformePlanificacion : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/Chart.js/Chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Informes\InformePlanificacion.cshtml"
  
    ViewData["Title"] = "InformePlanificacion";

#line default
#line hidden
            BeginContext(126, 1899, true);
            WriteLiteral(@"
<h2>InformePlanificacion</h2>
<div class="" bg-secondary"">
    <table class=""table table-bordered table-striped table-hover text-dark table-responsive-md"" style=""width:100%"" id=""datata"">
        <thead>
            <tr>
                <th style=""width:50%"">
                    Chart 1
                </th>
                <th style=""width:50%"">
                    Chart 2
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <canvas id=""densityChart1"" width=""300"" height=""200""></canvas>
                </td>
                <td>
                    <canvas id=""densityChart2"" width=""300"" height=""200""></canvas>
                </td>
            </tr>
        </tbody>
        <tfoot>
            <tr>
                <th>
                </th>
                <th>
                </th>
            </tr>
        </tfoot>
    </table>
    </div>
<div class="" bg-secondary"">
    <table class=""table table-bo");
            WriteLiteral(@"rdered table-striped table-hover text-dark table-responsive-md"" style=""width:100%"" id=""datata"">

        <thead>
            <tr>
                <th style=""width:50%"">
                    Chart 3
                </th>
                <th style=""width:50%"">
                    Chart 4
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <canvas id=""densityChart3"" width=""300"" height=""200""></canvas>
                </td>
                <td>
                    <canvas id=""densityChart4"" width=""300"" height=""200""></canvas>
                </td>
            </tr>
        </tbody>
        <tfoot>
            <tr>
                <th>
                </th>
                <th>
                </th>
            </tr>
        </tfoot>
    </table>
        </div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2064, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2078, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3b40e1f02b44269d81bddfafc76f49", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2148, 1174, true);
                WriteLiteral(@"
            <script type=""text/javascript"">
                DisplayChart(""densityChart1"");
                DisplayChart(""densityChart2"");
                DisplayChart(""densityChart3"");
                DisplayChart(""densityChart4"");
                function DisplayChart(divName) {
                    // alert(""Display: "" + divName );
                    var densityCanvas = document.getElementById(divName);

                    Chart.defaults.global.defaultFontFamily = ""Lato"";
                    Chart.defaults.global.defaultFontSize = 18;

                    var densityData = {
                        label: 'Density of Planets (kg/m3)',
                        data: [5427, 5243, 5514, 3933, 1326, 687, 1271, 1638]
                    };

                    var barChart = new Chart(densityCanvas, {
                        type: 'bar',
                        data: {
                            labels: [""Mercury"", ""Venus"", ""Earth"", ""Mars"", ""Jupiter"", ""Saturn"", ""Uranus"", ""Neptune""],
     ");
                WriteLiteral("                       datasets: [densityData]\r\n                        }\r\n                    });\r\n                }\r\n            </script>\r\n        ");
                EndContext();
            }
            );
            BeginContext(3325, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.Informes.InformePlanificacionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Informes.InformePlanificacionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Informes.InformePlanificacionModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.Informes.InformePlanificacionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
