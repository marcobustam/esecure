#pragma checksum "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da0745d6e25624d2331b6f963ae52bf3f615df7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Planes.Prevencion.Planificaciones.Pages_Planes_Prevencion_Planificaciones_Index), @"mvc.1.0.razor-page", @"/Pages/Planes/Prevencion/Planificaciones/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Planes/Prevencion/Planificaciones/Index.cshtml", typeof(Esecure2.Pages.Planes.Prevencion.Planificaciones.Pages_Planes_Prevencion_Planificaciones_Index), null)]
namespace Esecure2.Pages.Planes.Prevencion.Planificaciones
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0745d6e25624d2331b6f963ae52bf3f615df7f", @"/Pages/Planes/Prevencion/Planificaciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Planes_Prevencion_Planificaciones_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Planes/Prevencion/Planificaciones/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Planes/Mitigacion/IssueLists/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Actividades/Verificaciones/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
  
    ViewData["Title"] = "Planes Prevención";

#line default
#line hidden
            BeginContext(135, 29, true);
            WriteLiteral("<h2>Planes de Prevención - \r\n");
            EndContext();
#line 8 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
     if (!(Model.MyEmpresa == null))
    {
        

#line default
#line hidden
            BeginContext(218, 30, false);
#line 10 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
   Write(Model.MyEmpresa.NombreFantasia);

#line default
#line hidden
            EndContext();
#line 10 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                       
    }

#line default
#line hidden
            BeginContext(257, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(275, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e2694b4779a4bfcbd7ba06bdde4b098", async() => {
                BeginContext(387, 67, true);
                WriteLiteral("Agregar Plan <span class=\"glyphicon glyphicon-plus-sign\"></span>   ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-emid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                               WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(458, 140, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" style=\"text-align:left\">\r\n    <thead style=\"text-align:left\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(599, 54, false);
#line 21 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanList[0].PlanID));

#line default
#line hidden
            EndContext();
            BeginContext(653, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(709, 58, false);
#line 24 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanList[0].NombrePlan));

#line default
#line hidden
            EndContext();
            BeginContext(767, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(823, 57, false);
#line 27 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanList[0].PersonaID));

#line default
#line hidden
            EndContext();
            BeginContext(880, 58, true);
            WriteLiteral("\r\n            </th>\r\n            <!--th>\r\n                ");
            EndContext();
            BeginContext(939, 57, false);
#line 30 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanList[0].EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(996, 116, true);
            WriteLiteral("\r\n            </!--th -->\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody style=\"text-align:left\">\r\n");
            EndContext();
#line 36 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
 foreach (var item in Model.PlanList) {

#line default
#line hidden
            BeginContext(1153, 72, true);
            WriteLiteral("        <tr>\r\n            <td style=\"text-align:left\">\r\n                ");
            EndContext();
            BeginContext(1226, 41, false);
#line 39 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlanID));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 79, true);
            WriteLiteral("\r\n            </td>\r\n            <td style=\"text-align:left\">\r\n                ");
            EndContext();
            BeginContext(1347, 45, false);
#line 42 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombrePlan));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 97, true);
            WriteLiteral("\r\n            </td>\r\n            <td style=\"text-align:left\">\r\n                \r\n                ");
            EndContext();
            BeginContext(1490, 44, false);
#line 46 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PersonaID));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 3, true);
            WriteLiteral(";\r\n");
            EndContext();
#line 47 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                  
                    var pe = Model.ListaResponsables.FirstOrDefault(p => p.PersonaID == item.PersonaID);
                

#line default
#line hidden
            BeginContext(1682, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1699, 15, false);
#line 50 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(pe.PrimerNombre);

#line default
#line hidden
            EndContext();
            BeginContext(1714, 80, true);
            WriteLiteral(";\r\n            </td>\r\n            <td style=\"text-align:left\">\r\n                ");
            EndContext();
            BeginContext(1794, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6c1cbced2c34cb39e712728efdd898d", async() => {
                BeginContext(1971, 33, true);
                WriteLiteral("Tareas<i class=\"fa fa-tasks\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-emid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                                                             WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                                                                                                          WriteLiteral(item.PlanID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["plid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-plid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["plid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2008, 95, true);
            WriteLiteral("                \r\n            </td>\r\n            <td style=\"text-align:left\">\r\n                ");
            EndContext();
            BeginContext(2103, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04930b8039094ef5bcbe78f05ebafeda", async() => {
                BeginContext(2227, 14, true);
                WriteLiteral("Plan de Acción");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-emid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                                                      WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                                                                                                  WriteLiteral(item.PlanID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["plid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-plid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["plid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2245, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2263, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3c2120fc3cc44659dcd20b48d32ba04", async() => {
                BeginContext(2385, 25, true);
                WriteLiteral("Ver CheckList Disponibles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-emid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                                                    WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                                                                                                WriteLiteral(item.PlanID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["plid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-plid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["plid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2414, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 60 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2453, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.Planes.Prevencion.Planificaciones.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Planes.Prevencion.Planificaciones.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Planes.Prevencion.Planificaciones.IndexModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.Planes.Prevencion.Planificaciones.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
