#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67bd4d961a655b8ad5e78d9f2ab7a6cc3070730c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Shared.Pages_Shared__ListPlanesAjax), @"mvc.1.0.view", @"/Pages/Shared/_ListPlanesAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_ListPlanesAjax.cshtml", typeof(Esecure2.Pages.Shared.Pages_Shared__ListPlanesAjax))]
namespace Esecure2.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67bd4d961a655b8ad5e78d9f2ab7a6cc3070730c", @"/Pages/Shared/_ListPlanesAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__ListPlanesAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EsecureWebApp.Pages.Mantenedores.Empresas.DetailsAjaxModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Planes/Prevencion/Planificaciones/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Planes/Mitigacion/IssueLists/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Actividades/Verificaciones/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(197, 183, true);
            WriteLiteral("<div id=\"planes\">\r\n    <h4>Detalle de Planes:</h4>\r\n    <table class=\"table table-hover table-striped\" >\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(381, 54, false);
#line 13 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
               Write(Html.DisplayNameFor(model => model.PlanList[0].PlanID));

#line default
#line hidden
            EndContext();
            BeginContext(435, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(503, 58, false);
#line 16 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
               Write(Html.DisplayNameFor(model => model.PlanList[0].NombrePlan));

#line default
#line hidden
            EndContext();
            BeginContext(561, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(629, 57, false);
#line 19 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
               Write(Html.DisplayNameFor(model => model.PlanList[0].PersonaID));

#line default
#line hidden
            EndContext();
            BeginContext(686, 70, true);
            WriteLiteral("\r\n                </th>\r\n                <!--th>\r\n                    ");
            EndContext();
            BeginContext(757, 131, true);
            WriteLiteral("@Html.DisplayNameFor(model => model.PlanList[0].EmpresaID)\r\n                </!--th -->\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(889, 57, false);
#line 25 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
               Write(Html.DisplayNameFor(model => model.PlanList[0].TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(946, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1014, 52, false);
#line 28 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
               Write(Html.DisplayNameFor(model => model.PlanList[0].Umod));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
             foreach (var item in Model.PlanList)
            {

#line default
#line hidden
            BeginContext(1238, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1311, 41, false);
#line 38 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlanID));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1432, 45, false);
#line 41 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NombrePlan));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 81, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n                        ");
            EndContext();
            BeginContext(1559, 44, false);
#line 45 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PersonaID));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                          
                            var pe = Model.ListaResponsables.FirstOrDefault(p => p.PersonaID == item.PersonaID);
                        

#line default
#line hidden
            BeginContext(1774, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1799, 15, false);
#line 49 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                   Write(pe.PrimerNombre);

#line default
#line hidden
            EndContext();
            BeginContext(1814, 80, true);
            WriteLiteral(";\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1895, 44, false);
#line 52 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1939, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2019, 14, false);
#line 55 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                   Write(item.GetUmod());

#line default
#line hidden
            EndContext();
            BeginContext(2033, 27, true);
            WriteLiteral(";\r\n                        ");
            EndContext();
            BeginContext(2061, 39, false);
#line 56 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Umod));

#line default
#line hidden
            EndContext();
            BeginContext(2100, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2179, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb3d15340a4348e5951edf21df40d2f2", async() => {
                BeginContext(2355, 11, true);
                WriteLiteral("Actividades");
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
#line 59 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                                                                                     WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
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
            BeginContext(2370, 152, true);
            WriteLiteral("\r\n                        <span class=\"badge alert-success\">Nuevo!</span>\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2522, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e823d53d7b3947759444675600140e73", async() => {
                BeginContext(2646, 14, true);
                WriteLiteral("Plan de Acción");
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
#line 63 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                                                                              WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
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
            BeginContext(2664, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2690, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31cb1e3b348b4787b148ad0dd9624865", async() => {
                BeginContext(2812, 25, true);
                WriteLiteral("Ver CheckList Disponibles");
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
#line 64 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
                                                                            WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
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
            BeginContext(2841, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 67 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Shared\_ListPlanesAjax.cshtml"
            }

#line default
#line hidden
            BeginContext(2908, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.Mantenedores.Empresas.DetailsAjaxModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
