#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Faenas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db9afa226bc9069eae67cd2d776b099f654a5696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Mantenedores.Faenas.Pages_Mantenedores_Faenas_Details), @"mvc.1.0.razor-page", @"/Pages/Mantenedores/Faenas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Mantenedores/Faenas/Details.cshtml", typeof(Esecure2.Pages.Mantenedores.Faenas.Pages_Mantenedores_Faenas_Details), null)]
namespace Esecure2.Pages.Mantenedores.Faenas
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db9afa226bc9069eae67cd2d776b099f654a5696", @"/Pages/Mantenedores/Faenas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mantenedores_Faenas_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Faenas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(113, 125, true);
            WriteLiteral("<div id=\"content-wrapper\">\r\n    <div class=\"container-fluid\">\r\n        <!-- Breadcrumbs-->\r\n        <ol class=\"breadcrumb\">\r\n");
            EndContext();
            BeginContext(333, 370, true);
            WriteLiteral(@"            <li class=""breadcrumb-item"">
                <a href=""#"">Empresa</a>
            </li>
            <li class=""breadcrumb-item"">
                <a href=""#"">Mantenedores</a>
            </li>
            <li class=""breadcrumb-item"">
                <a href=""#"">Faenas</a>
            </li>
            <li class=""breadcrumb-item active"">Editar</li>
");
            EndContext();
            BeginContext(798, 50, true);
            WriteLiteral("        </ol>\r\n        <div class=\"card-footer\">\r\n");
            EndContext();
            BeginContext(943, 33, true);
            WriteLiteral("            <h2>Detalles Faena # ");
            EndContext();
            BeginContext(977, 19, false);
#line 26 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Faenas\Details.cshtml"
                            Write(Model.Faena.FaenaID);

#line default
#line hidden
            EndContext();
            BeginContext(996, 32, true);
            WriteLiteral("</h2>\r\n            <h4>Empresa: ");
            EndContext();
            BeginContext(1029, 30, false);
#line 27 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Faenas\Details.cshtml"
                    Write(Model.MyEmpresa.NombreFantasia);

#line default
#line hidden
            EndContext();
            BeginContext(1059, 8, true);
            WriteLiteral(" </h4>\r\n");
            EndContext();
            BeginContext(1162, 122, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n\r\n        <div class=\"card\">\r\n            <div class=\"col-md-4\">\r\n                <br />\r\n");
            EndContext();
            BeginContext(1383, 193, true);
            WriteLiteral("                <div>\r\n                    <h4>Faena</h4>\r\n                    <hr />\r\n                    <dl class=\"dl-horizontal\">\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(1577, 53, false);
#line 41 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Faenas\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Faena.NombreFaena));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(1722, 49, false);
#line 44 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Faenas\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Faena.NombreFaena));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 127, true);
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(1898, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4afe37981f4463f9a796e6c4d5ed062", async() => {
                BeginContext(1955, 6, true);
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
#line 49 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Faenas\Details.cshtml"
                                           WriteLiteral(Model.Faena.FaenaID);

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
            BeginContext(1965, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1989, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c155fd68a44a5e953888acbde1325c", async() => {
                BeginContext(2011, 6, true);
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
            BeginContext(2021, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
            BeginContext(2146, 84, true);
            WriteLiteral("                <br />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.Mantenedores.Faenas.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Mantenedores.Faenas.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Mantenedores.Faenas.DetailsModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.Mantenedores.Faenas.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
