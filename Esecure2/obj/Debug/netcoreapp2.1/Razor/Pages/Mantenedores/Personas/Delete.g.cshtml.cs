#pragma checksum "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c099bfaad7ab190cda0cf1c16bcca0b229a4c9eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Mantenedores.Personas.Pages_Mantenedores_Personas_Delete), @"mvc.1.0.razor-page", @"/Pages/Mantenedores/Personas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Mantenedores/Personas/Delete.cshtml", typeof(Esecure2.Pages.Mantenedores.Personas.Pages_Mantenedores_Personas_Delete), null)]
namespace Esecure2.Pages.Mantenedores.Personas
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c099bfaad7ab190cda0cf1c16bcca0b229a4c9eb", @"/Pages/Mantenedores/Personas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mantenedores_Personas_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(113, 49, true);
            WriteLiteral("\r\n<h2>Listado de Trabajadores</h2>\r\n<h4>Empresa: ");
            EndContext();
            BeginContext(163, 30, false);
#line 9 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
        Write(Model.MyEmpresa.NombreFantasia);

#line default
#line hidden
            EndContext();
            BeginContext(193, 173, true);
            WriteLiteral(" </h4>\r\n<hr />\r\n\r\n<h3>¿Está seguro que quiere eliminar el registro?</h3>\r\n<div>\r\n    <h4>Persona</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(367, 53, false);
#line 18 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(420, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(464, 49, false);
#line 21 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(513, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(557, 49, false);
#line 24 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(606, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(650, 45, false);
#line 27 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Alias));

#line default
#line hidden
            EndContext();
            BeginContext(695, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(739, 56, false);
#line 30 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.PrimerNombre));

#line default
#line hidden
            EndContext();
            BeginContext(795, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(839, 52, false);
#line 33 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Persona.PrimerNombre));

#line default
#line hidden
            EndContext();
            BeginContext(891, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(935, 57, false);
#line 36 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.SegundoNombre));

#line default
#line hidden
            EndContext();
            BeginContext(992, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1036, 53, false);
#line 39 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Persona.SegundoNombre));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1133, 59, false);
#line 42 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.ApellidoPaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1236, 55, false);
#line 45 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Persona.ApellidoPaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1335, 59, false);
#line 48 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.ApellidoMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1438, 55, false);
#line 51 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Persona.ApellidoMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1537, 59, false);
#line 54 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1640, 55, false);
#line 57 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Persona.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1729, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e55a2818f6ed4a7986fa1dcc362ff486", async() => {
                BeginContext(1749, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1759, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "272c04e86baf4774ac22d989738bbd1b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 62 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Mantenedores\Personas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Persona.PersonaID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1810, 86, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1896, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e55148a7381d48a98d075d225d8404d7", async() => {
                    BeginContext(1918, 6, true);
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
                BeginContext(1928, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1941, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.Mantenedores.Personas.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Mantenedores.Personas.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Mantenedores.Personas.DeleteModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.Mantenedores.Personas.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591