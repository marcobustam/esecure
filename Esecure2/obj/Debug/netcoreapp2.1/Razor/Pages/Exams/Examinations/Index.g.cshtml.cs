#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f2f65f949bd077eb4b9ededc12d3424e012aadb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Exams.Examinations.Pages_Exams_Examinations_Index), @"mvc.1.0.razor-page", @"/Pages/Exams/Examinations/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Exams/Examinations/Index.cshtml", typeof(Esecure2.Pages.Exams.Examinations.Pages_Exams_Examinations_Index), null)]
namespace Esecure2.Pages.Exams.Examinations
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f2f65f949bd077eb4b9ededc12d3424e012aadb", @"/Pages/Exams/Examinations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Exams_Examinations_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Mantenedores/Empresas/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(108, 25, true);
            WriteLiteral("<ol class=\"breadcrumb\">\r\n");
            EndContext();
            BeginContext(220, 42, true);
            WriteLiteral("    <li class=\"breadcrumb-item\">\r\n        ");
            EndContext();
            BeginContext(262, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa1e804ec7ed4e9b81631b49dca112c1", async() => {
                BeginContext(349, 7, true);
                WriteLiteral("Empresa");
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
#line 10 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                                                       WriteLiteral(Model.MyEmpresa.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(360, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(399, 179, true);
            WriteLiteral("    </li>\r\n    <li class=\"breadcrumb-item\">\r\n        <a href=\"#\">Planificaciones</a>\r\n    </li>\r\n    <li class=\"breadcrumb-item active\">\r\n        Planes de Prevención\r\n    </li>\r\n");
            EndContext();
            BeginContext(665, 161, true);
            WriteLiteral("</ol>\r\n<div id=\"content-wrapper\">\r\n    <div class=\"container-fluid\">\r\n        <!-- Breadcrumbs-->\r\n\r\n        <div class=\"card card-body bg-primary text-light\">\r\n");
            EndContext();
            BeginContext(921, 71, true);
            WriteLiteral("            <h3>Listado de Inspecciones</h3>\r\n            <h4>Empresa: ");
            EndContext();
            BeginContext(993, 30, false);
#line 28 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                    Write(Model.MyEmpresa.NombreFantasia);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 8, true);
            WriteLiteral(" </h4>\r\n");
            EndContext();
            BeginContext(1126, 32, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n");
            EndContext();
            BeginContext(1249, 417, true);
            WriteLiteral(@"        <div class=""container container-fluid respon card card-body bg-light text-dark"">
            <br />

            <table class=""table  table-bordered table-striped table-hover text-dark table-responsive table-responsive-sm table-responsive-md table-responsive-lg table-responsive-xl"" id=""datata"">
                <thead>
                    <tr>
                        <th>
                            ");
            EndContext();
            BeginContext(1667, 64, false);
#line 40 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1823, 68, false);
#line 43 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].ExaminationID));

#line default
#line hidden
            EndContext();
            BeginContext(1891, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1983, 64, false);
#line 46 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(2047, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2139, 61, false);
#line 49 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].PlanID));

#line default
#line hidden
            EndContext();
            BeginContext(2200, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2292, 62, false);
#line 52 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].TareaID));

#line default
#line hidden
            EndContext();
            BeginContext(2354, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2446, 65, false);
#line 55 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].PersonaID1));

#line default
#line hidden
            EndContext();
            BeginContext(2511, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2603, 65, false);
#line 58 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].PersonaID2));

#line default
#line hidden
            EndContext();
            BeginContext(2668, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2760, 61, false);
#line 61 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].Prueba));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2913, 64, false);
#line 64 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(2977, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(3069, 62, false);
#line 67 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].FaenaID));

#line default
#line hidden
            EndContext();
            BeginContext(3131, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(3223, 70, false);
#line 70 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].TotalRespuestas));

#line default
#line hidden
            EndContext();
            BeginContext(3293, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(3385, 76, false);
#line 73 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                       Write(Html.DisplayNameFor(model => Model.ExaminationList[0].RespuestasCompletadas));

#line default
#line hidden
            EndContext();
            BeginContext(3461, 210, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            Acciones\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 81 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                     foreach (var item in Model.ExaminationList)
                    {

#line default
#line hidden
            BeginContext(3760, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3857, 44, false);
#line 85 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(3901, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4005, 48, false);
#line 88 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ExaminationID));

#line default
#line hidden
            EndContext();
            BeginContext(4053, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4157, 44, false);
#line 91 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(4201, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4305, 41, false);
#line 94 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PlanID));

#line default
#line hidden
            EndContext();
            BeginContext(4346, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4450, 42, false);
#line 97 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TareaID));

#line default
#line hidden
            EndContext();
            BeginContext(4492, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4596, 45, false);
#line 100 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PersonaID1));

#line default
#line hidden
            EndContext();
            BeginContext(4641, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4745, 45, false);
#line 103 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PersonaID2));

#line default
#line hidden
            EndContext();
            BeginContext(4790, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4894, 48, false);
#line 106 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Prueba.TestID));

#line default
#line hidden
            EndContext();
            BeginContext(4942, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5046, 44, false);
#line 109 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(5090, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5194, 42, false);
#line 112 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FaenaID));

#line default
#line hidden
            EndContext();
            BeginContext(5236, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5340, 50, false);
#line 115 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TotalRespuestas));

#line default
#line hidden
            EndContext();
            BeginContext(5390, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5494, 56, false);
#line 118 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.RespuestasCompletadas));

#line default
#line hidden
            EndContext();
            BeginContext(5550, 164, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"btn-group\">\r\n                                    ");
            EndContext();
            BeginContext(5714, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbacaf96165c46cf9bd57433a036be3a", async() => {
                BeginContext(5815, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 122 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                                                                                                        WriteLiteral(item.ExaminationID);

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
            BeginContext(5845, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(5883, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac07ea1c41f542be97cfe1c4735ac1ed", async() => {
                BeginContext(6083, 33, true);
                WriteLiteral("<i class=\"fa fa-info-circle\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-emid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 123 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                                                                                                             WriteLiteral(item.EmpresaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 123 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                                                                                                                                              WriteLiteral(item.PlanID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["plid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-plid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["plid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 123 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                                                                                                                                                                            WriteLiteral(item.TareaID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-taid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["taid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 123 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                                                                                                                                                                                                           WriteLiteral(item.ExaminationID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["exid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-exid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["exid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6120, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(6158, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aed45f4eab444e485d96dc719ad697e", async() => {
                BeginContext(6260, 28, true);
                WriteLiteral("<i class=\"fa fa-eraser\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 124 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                                                                                                         WriteLiteral(item.ExaminationID);

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
            BeginContext(6292, 119, true);
            WriteLiteral("\r\n                                    <button type=\"button\" id=\"btnIniciar\" class=\"btn btn-info btn-sm\" title=\"Iniciar\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6411, "\"", 6532, 9);
            WriteAttributeValue("", 6421, "CambiaEstado(", 6421, 13, true);
#line 125 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
WriteAttributeValue("", 6434, item.EmpresaID, 6434, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 6449, ",", 6450, 2, true);
#line 125 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
WriteAttributeValue(" ", 6451, item.PlanID, 6452, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 6464, ",", 6464, 1, true);
#line 125 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
WriteAttributeValue(" ", 6465, item.TareaID, 6466, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 6479, ",", 6479, 1, true);
#line 125 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
WriteAttributeValue(" ", 6480, EsecureModel.Planificacion.EstadoTarea.Cancelada, 6481, 49, false);

#line default
#line hidden
            WriteAttributeValue("", 6530, ");", 6530, 2, true);
            EndWriteAttribute();
            BeginContext(6533, 225, true);
            WriteLiteral(">\r\n                                        <i class=\"fa fa-times\"></i>\r\n                                    </button>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 131 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Exams\Examinations\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(6781, 999, true);
            WriteLiteral(@"                </tbody>
                <tfoot>
                    <tr>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                        <th>
                        </th>
                    </tr>
                </tfoot>
            </table>
            <br />
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.Exams.Examinations.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Exams.Examinations.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Exams.Examinations.IndexModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.Exams.Examinations.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
