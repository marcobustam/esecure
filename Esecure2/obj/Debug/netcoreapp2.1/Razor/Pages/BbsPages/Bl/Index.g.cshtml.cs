#pragma checksum "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f90b2d033774a90e610be38b229a85cf75b99e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Bbs.Pages.Bl.Pages_BbsPages_Bl_Index), @"mvc.1.0.razor-page", @"/Pages/BbsPages/Bl/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/BbsPages/Bl/Index.cshtml", typeof(Bbs.Pages.Bl.Pages_BbsPages_Bl_Index), null)]
namespace Bbs.Pages.Bl
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
#line 1 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\_ViewImports.cshtml"
using bbs;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f90b2d033774a90e610be38b229a85cf75b99e9", @"/Pages/BbsPages/Bl/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8c6dca070808383fdca8b9428cb392b6dc96e5", @"/Pages/BbsPages/_ViewImports.cshtml")]
    public class Pages_BbsPages_Bl_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(82, 193, true);
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"col-md-12\">\r\n        <br />\r\n        <h4 class=\"card card-body bg-primary text-light\">\r\n            Inspecciones realizadas:\r\n        </h4>\r\n        <hr />\r\n");
            EndContext();
            BeginContext(457, 356, true);
            WriteLiteral(@"        <div class=""container-fluid card bg-light text-dark"">
            <table class=""table table-bordered table-striped table-hover text-dark table-responsive table-responsive-sm  table-responsive-md table-responsive-lg table-responsive-xl"" id=""datata"">
                <thead>
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(814, 64, false);
#line 21 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].InspectionDate));

#line default
#line hidden
            EndContext();
            BeginContext(878, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(958, 60, false);
#line 24 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].MyProperty));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1098, 59, false);
#line 27 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].PersonID1));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1237, 59, false);
#line 30 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].PersonID2));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1376, 59, false);
#line 33 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].PersonID3));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1515, 60, false);
#line 36 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].DivisionID));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1655, 56, false);
#line 39 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].SiteID));

#line default
#line hidden
            EndContext();
            BeginContext(1711, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1791, 60, false);
#line 42 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].WorkSiteID));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1931, 63, false);
#line 45 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].ObsCategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2074, 59, false);
#line 48 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].ObsItemID));

#line default
#line hidden
            EndContext();
            BeginContext(2133, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2213, 62, false);
#line 51 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inspection[0].IsSafeAction));

#line default
#line hidden
            EndContext();
            BeginContext(2275, 134, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 57 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                     foreach (var item in Model.Inspection)
                    {

#line default
#line hidden
            BeginContext(2493, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2590, 49, false);
#line 61 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.InspectionDate));

#line default
#line hidden
            EndContext();
            BeginContext(2639, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2743, 45, false);
#line 64 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MyProperty));

#line default
#line hidden
            EndContext();
            BeginContext(2788, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2892, 44, false);
#line 67 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PersonID1));

#line default
#line hidden
            EndContext();
            BeginContext(2936, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3040, 44, false);
#line 70 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PersonID2));

#line default
#line hidden
            EndContext();
            BeginContext(3084, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3188, 44, false);
#line 73 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PersonID3));

#line default
#line hidden
            EndContext();
            BeginContext(3232, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3336, 45, false);
#line 76 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DivisionID));

#line default
#line hidden
            EndContext();
            BeginContext(3381, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3485, 41, false);
#line 79 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SiteID));

#line default
#line hidden
            EndContext();
            BeginContext(3526, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3630, 45, false);
#line 82 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.WorkSiteID));

#line default
#line hidden
            EndContext();
            BeginContext(3675, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3779, 48, false);
#line 85 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ObsCategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(3827, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3931, 44, false);
#line 88 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ObsItemID));

#line default
#line hidden
            EndContext();
            BeginContext(3975, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4079, 47, false);
#line 91 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.IsSafeAction));

#line default
#line hidden
            EndContext();
            BeginContext(4126, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4229, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6fcba5f62f94f8b8e4fb11e38079eaa", async() => {
                BeginContext(4284, 4, true);
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
#line 94 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                                                       WriteLiteral(item.InspectionID);

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
            BeginContext(4292, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(4328, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da124449ae07466d95c029fe6cafb675", async() => {
                BeginContext(4386, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                                                          WriteLiteral(item.InspectionID);

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
            BeginContext(4397, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(4433, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04fe0e63b19340b3b4f5f6a613ded4ce", async() => {
                BeginContext(4490, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                                                         WriteLiteral(item.InspectionID);

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
            BeginContext(4500, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 99 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4591, 92, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr />\r\n");
            EndContext();
            BeginContext(4683, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc32e2d8a553481ead7b00335779f3c9", async() => {
                BeginContext(4725, 6, true);
                WriteLiteral("Volver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4735, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4845, 484, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            // alert(""ready"");
            $('#datata').DataTable({
                ""paging"": true,
                ""ordering"": true,
                ""info"": true,
                ""language"": {
                    //""url"": ""//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json""
                    ""url"": ""/lib/datatables/json/Spanish.json""
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bbs.Pages.Bl.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bbs.Pages.Bl.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bbs.Pages.Bl.IndexModel>)PageContext?.ViewData;
        public Bbs.Pages.Bl.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
