#pragma checksum "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d079d9ca1d828e1cfd2a55c88e0c806c847aa175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Planes.Prevencion.Tareas.HistoricoTareas.Pages_Planes_Prevencion_Tareas_HistoricoTareas_Details), @"mvc.1.0.razor-page", @"/Pages/Planes/Prevencion/Tareas/HistoricoTareas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Planes/Prevencion/Tareas/HistoricoTareas/Details.cshtml", typeof(Esecure2.Pages.Planes.Prevencion.Tareas.HistoricoTareas.Pages_Planes_Prevencion_Tareas_HistoricoTareas_Details), null)]
namespace Esecure2.Pages.Planes.Prevencion.Tareas.HistoricoTareas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\_ViewImports.cshtml"
using Esecure2;

#line default
#line hidden
#line 3 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\_ViewImports.cshtml"
using Esecure2.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d079d9ca1d828e1cfd2a55c88e0c806c847aa175", @"/Pages/Planes/Prevencion/Tareas/HistoricoTareas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Planes_Prevencion_Tareas_HistoricoTareas_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(134, 128, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>HistoricoTarea</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(263, 58, false);
#line 15 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HistoricoTarea.TareaID));

#line default
#line hidden
            EndContext();
            BeginContext(321, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(365, 54, false);
#line 18 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml"
       Write(Html.DisplayFor(model => model.HistoricoTarea.TareaID));

#line default
#line hidden
            EndContext();
            BeginContext(419, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(463, 65, false);
#line 21 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HistoricoTarea.EstadoAnterior));

#line default
#line hidden
            EndContext();
            BeginContext(528, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(572, 61, false);
#line 24 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml"
       Write(Html.DisplayFor(model => model.HistoricoTarea.EstadoAnterior));

#line default
#line hidden
            EndContext();
            BeginContext(633, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(677, 62, false);
#line 27 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HistoricoTarea.NuevoEstado));

#line default
#line hidden
            EndContext();
            BeginContext(739, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(783, 58, false);
#line 30 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml"
       Write(Html.DisplayFor(model => model.HistoricoTarea.NuevoEstado));

#line default
#line hidden
            EndContext();
            BeginContext(841, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(885, 60, false);
#line 33 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HistoricoTarea.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(945, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(989, 56, false);
#line 36 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml"
       Write(Html.DisplayFor(model => model.HistoricoTarea.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1092, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73e5cf732b774fdc8f7cd3dfd1f648ab", async() => {
                BeginContext(1167, 4, true);
                WriteLiteral("Edit");
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
#line 41 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Tareas\HistoricoTareas\Details.cshtml"
                           WriteLiteral(Model.HistoricoTarea.HistoricoTareaID);

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
            BeginContext(1175, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1183, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a46d1e994b348c7903cc3090ca676c8", async() => {
                BeginContext(1205, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1221, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.Planes.Prevencion.Tareas.HistoricoTareas.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Planes.Prevencion.Tareas.HistoricoTareas.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Planes.Prevencion.Tareas.HistoricoTareas.DetailsModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.Planes.Prevencion.Tareas.HistoricoTareas.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
