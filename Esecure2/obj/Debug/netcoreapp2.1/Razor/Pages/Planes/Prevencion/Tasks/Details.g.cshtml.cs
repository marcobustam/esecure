#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6b13aa8cdd765cc5374f9b06ecd7a86c042d409"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Planes.Prevencion.Tasks.Pages_Planes_Prevencion_Tasks_Details), @"mvc.1.0.razor-page", @"/Pages/Planes/Prevencion/Tasks/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Planes/Prevencion/Tasks/Details.cshtml", typeof(Esecure2.Pages.Planes.Prevencion.Tasks.Pages_Planes_Prevencion_Tasks_Details), null)]
namespace Esecure2.Pages.Planes.Prevencion.Tasks
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b13aa8cdd765cc5374f9b06ecd7a86c042d409", @"/Pages/Planes/Prevencion/Tasks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Planes_Prevencion_Tasks_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(117, 121, true);
            WriteLiteral("\r\n<h2>Detalles:</h2>\r\n\r\n<div>\r\n    <h4>Tarea</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(239, 48, false);
#line 15 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.PlanID));

#line default
#line hidden
            EndContext();
            BeginContext(287, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(331, 44, false);
#line 18 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.PlanID));

#line default
#line hidden
            EndContext();
            BeginContext(375, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(419, 51, false);
#line 21 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(470, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(514, 47, false);
#line 24 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(561, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(605, 53, false);
#line 27 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.NombreTarea));

#line default
#line hidden
            EndContext();
            BeginContext(658, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(702, 49, false);
#line 30 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.NombreTarea));

#line default
#line hidden
            EndContext();
            BeginContext(751, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(795, 49, false);
#line 33 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.FaenaID));

#line default
#line hidden
            EndContext();
            BeginContext(844, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(888, 45, false);
#line 36 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.FaenaID));

#line default
#line hidden
            EndContext();
            BeginContext(933, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(977, 58, false);
#line 39 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.FechaPlanificada));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1079, 54, false);
#line 42 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.FechaPlanificada));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1177, 61, false);
#line 45 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.FechaFinPlanificada));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1282, 57, false);
#line 48 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.FechaFinPlanificada));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1383, 60, false);
#line 51 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.FechaEjecucionReal));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1487, 56, false);
#line 54 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.FechaEjecucionReal));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1587, 65, false);
#line 57 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.FechaUltimaModificacion));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1696, 61, false);
#line 60 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.FechaUltimaModificacion));

#line default
#line hidden
            EndContext();
            BeginContext(1757, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1801, 63, false);
#line 63 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.FechaFinEjecucionReal));

#line default
#line hidden
            EndContext();
            BeginContext(1864, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1908, 59, false);
#line 66 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.FechaFinEjecucionReal));

#line default
#line hidden
            EndContext();
            BeginContext(1967, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2011, 50, false);
#line 69 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.EstadoID));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2105, 46, false);
#line 72 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.EstadoID));

#line default
#line hidden
            EndContext();
            BeginContext(2151, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2195, 48, false);
#line 75 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tarea.TestID));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2287, 44, false);
#line 78 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tarea.TestID));

#line default
#line hidden
            EndContext();
            BeginContext(2331, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2378, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2698322b597e42ea94ab4c66206b0759", async() => {
                BeginContext(2435, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Planes\Prevencion\Tasks\Details.cshtml"
                           WriteLiteral(Model.Tarea.TareaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2445, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2453, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62779ed11fd143e6abbeea3ea7dbbcb7", async() => {
                BeginContext(2475, 6, true);
                WriteLiteral("Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2485, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.Planes.Prevencion.Tasks.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Planes.Prevencion.Tasks.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Planes.Prevencion.Tasks.DetailsModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.Planes.Prevencion.Tasks.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
