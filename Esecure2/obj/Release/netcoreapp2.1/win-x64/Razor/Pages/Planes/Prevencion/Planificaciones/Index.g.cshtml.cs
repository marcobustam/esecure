#pragma checksum "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49e062eddbe5c68da98b61b2ef6d404d72e52aae"
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
#line 1 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\_ViewImports.cshtml"
using Esecure2;

#line default
#line hidden
#line 3 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\_ViewImports.cshtml"
using Esecure2.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e062eddbe5c68da98b61b2ef6d404d72e52aae", @"/Pages/Planes/Prevencion/Planificaciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Planes_Prevencion_Planificaciones_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
  
    ViewData["Title"] = "Planes Prevención";

#line default
#line hidden
            BeginContext(135, 29, true);
            WriteLiteral("<h2>Planes de Prevención - \r\n");
            EndContext();
#line 8 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
     if (!(Model.MyEmpresa == null))
    {
        

#line default
#line hidden
            BeginContext(218, 30, false);
#line 10 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
   Write(Model.MyEmpresa.NombreFantasia);

#line default
#line hidden
            EndContext();
#line 10 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                       
    }

#line default
#line hidden
            BeginContext(257, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(275, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1840d6a244c54e2397dbda58db73bd4b", async() => {
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
#line 15 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
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
            BeginContext(458, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(551, 54, false);
#line 21 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanList[0].PlanID));

#line default
#line hidden
            EndContext();
            BeginContext(605, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(661, 58, false);
#line 24 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanList[0].NombrePlan));

#line default
#line hidden
            EndContext();
            BeginContext(719, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(775, 57, false);
#line 27 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanList[0].PersonaID));

#line default
#line hidden
            EndContext();
            BeginContext(832, 58, true);
            WriteLiteral("\r\n            </th>\r\n            <!--th>\r\n                ");
            EndContext();
            BeginContext(891, 57, false);
#line 30 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanList[0].EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(948, 92, true);
            WriteLiteral("\r\n            </!--th -->\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
 foreach (var item in Model.PlanList) {

#line default
#line hidden
            BeginContext(1081, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1130, 41, false);
#line 39 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlanID));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1227, 45, false);
#line 42 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombrePlan));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                \r\n                ");
            EndContext();
            BeginContext(1346, 44, false);
#line 46 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PersonaID));

#line default
#line hidden
            EndContext();
            BeginContext(1390, 3, true);
            WriteLiteral(";\r\n");
            EndContext();
#line 47 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                  
                    var pe = Model.ListaResponsables.FirstOrDefault(p => p.PersonaID == item.PersonaID);
                

#line default
#line hidden
            BeginContext(1538, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1555, 15, false);
#line 50 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
           Write(pe.PrimerNombre);

#line default
#line hidden
            EndContext();
            BeginContext(1570, 56, true);
            WriteLiteral(";\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1626, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b52863e7a6457eae7357bed8964a7e", async() => {
                BeginContext(1770, 11, true);
                WriteLiteral("Actividades");
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
#line 53 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                            WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
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
            BeginContext(1785, 73, true);
            WriteLiteral("\r\n                \r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1858, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b69e71e04ec04497926686197dc1f4c0", async() => {
                BeginContext(1982, 14, true);
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
#line 57 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                                                      WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
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
            BeginContext(2000, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2018, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a7c62f4f6674c90907454da8652c00c", async() => {
                BeginContext(2140, 25, true);
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
#line 58 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
                                                                    WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
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
            BeginContext(2169, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 61 "C:\Users\marco\source\repos\Esecure2\Esecure2\Pages\Planes\Prevencion\Planificaciones\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2208, 24, true);
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
