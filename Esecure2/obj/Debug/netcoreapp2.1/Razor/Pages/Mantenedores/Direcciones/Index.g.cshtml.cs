#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3923e6f663418c02e3e0ed00fc1f9198e5b6fcbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Mantenedores.Direcciones.Pages_Mantenedores_Direcciones_Index), @"mvc.1.0.razor-page", @"/Pages/Mantenedores/Direcciones/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Mantenedores/Direcciones/Index.cshtml", typeof(Esecure2.Pages.Mantenedores.Direcciones.Pages_Mantenedores_Direcciones_Index), null)]
namespace Esecure2.Pages.Mantenedores.Direcciones
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3923e6f663418c02e3e0ed00fc1f9198e5b6fcbd", @"/Pages/Mantenedores/Direcciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mantenedores_Direcciones_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(114, 31, true);
            WriteLiteral("\r\n<h2>Listado</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(145, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ddb3f6e21b84d1296fd00a79e345c25", async() => {
                BeginContext(166, 5, true);
                WriteLiteral("Nuevo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(175, 245, true);
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\" bg-secondary\">\r\n    <table class=\"table table-bordered table-striped table-hover text-dark table-responsive-md\" style=\"width:100%\" id=\"datata\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(421, 58, false);
#line 19 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Direccion[0].EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(479, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(547, 58, false);
#line 22 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Direccion[0].ShortName));

#line default
#line hidden
            EndContext();
            BeginContext(605, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(673, 54, false);
#line 25 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Direccion[0].Calle));

#line default
#line hidden
            EndContext();
            BeginContext(727, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(795, 59, false);
#line 28 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Direccion[0].Numeracion));

#line default
#line hidden
            EndContext();
            BeginContext(854, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(922, 55, false);
#line 31 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Direccion[0].Comuna));

#line default
#line hidden
            EndContext();
            BeginContext(977, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1045, 55, false);
#line 34 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Direccion[0].Region));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1168, 53, false);
#line 37 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Direccion[0].Pais));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
             foreach (var item in Model.Direccion)
            {

#line default
#line hidden
            BeginContext(1394, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1467, 44, false);
#line 47 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1591, 44, false);
#line 50 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ShortName));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1715, 40, false);
#line 53 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Calle));

#line default
#line hidden
            EndContext();
            BeginContext(1755, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1835, 45, false);
#line 56 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Numeracion));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1960, 41, false);
#line 59 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Comuna));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2081, 41, false);
#line 62 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Region));

#line default
#line hidden
            EndContext();
            BeginContext(2122, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2202, 39, false);
#line 65 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Pais));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2320, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f31beea5da4450899fab7b04497ac40", async() => {
                BeginContext(2374, 6, true);
                WriteLiteral("Editar");
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
#line 68 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
                                               WriteLiteral(item.DireccionID);

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
            BeginContext(2384, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2412, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4674ecaaa13f4a44b71608fb24e33842", async() => {
                BeginContext(2469, 8, true);
                WriteLiteral("Detalles");
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
#line 69 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
                                                  WriteLiteral(item.DireccionID);

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
            BeginContext(2481, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2509, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feea63744b504591aec37a394457ebb2", async() => {
                BeginContext(2565, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
                                                 WriteLiteral(item.DireccionID);

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
            BeginContext(2577, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 73 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Direcciones\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2644, 470, true);
            WriteLiteral(@"        </tbody>
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
            </tr>
        </tfoot>
    </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.Mantenedores.Direcciones.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Mantenedores.Direcciones.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Mantenedores.Direcciones.IndexModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.Mantenedores.Direcciones.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
