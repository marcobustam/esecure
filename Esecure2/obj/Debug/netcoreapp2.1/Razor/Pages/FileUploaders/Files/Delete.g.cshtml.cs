#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50b5669c17c95ea4dca9d3b319eda29a6a4e3188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.FileUploaders.Files.Pages_FileUploaders_Files_Delete), @"mvc.1.0.razor-page", @"/Pages/FileUploaders/Files/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FileUploaders/Files/Delete.cshtml", typeof(Esecure2.Pages.FileUploaders.Files.Pages_FileUploaders_Files_Delete), null)]
namespace Esecure2.Pages.FileUploaders.Files
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50b5669c17c95ea4dca9d3b319eda29a6a4e3188", @"/Pages/FileUploaders/Files/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FileUploaders_Files_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(111, 186, true);
            WriteLiteral("\r\n<h2>Eliminar registro</h2>\r\n\r\n<h3>¿Está seguro que quiere eliminar el registro?</h3>\r\n<div>\r\n    <h4>FileUp</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(298, 51, false);
#line 16 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FileUp.FileName));

#line default
#line hidden
            EndContext();
            BeginContext(349, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(393, 47, false);
#line 19 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FileUp.FileName));

#line default
#line hidden
            EndContext();
            BeginContext(440, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(484, 50, false);
#line 22 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FileUp.FileUid));

#line default
#line hidden
            EndContext();
            BeginContext(534, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(578, 46, false);
#line 25 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FileUp.FileUid));

#line default
#line hidden
            EndContext();
            BeginContext(624, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(668, 53, false);
#line 28 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FileUp.FolderUpID));

#line default
#line hidden
            EndContext();
            BeginContext(721, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(765, 49, false);
#line 31 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FileUp.FolderUpID));

#line default
#line hidden
            EndContext();
            BeginContext(814, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(858, 53, false);
#line 34 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FileUp.FileTypeID));

#line default
#line hidden
            EndContext();
            BeginContext(911, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(955, 49, false);
#line 37 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FileUp.FileTypeID));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1048, 51, false);
#line 40 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FileUp.FileSize));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1143, 47, false);
#line 43 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FileUp.FileSize));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1234, 52, false);
#line 46 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FileUp.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1330, 48, false);
#line 49 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FileUp.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1422, 50, false);
#line 52 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FileUp.LastMod));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1516, 46, false);
#line 55 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FileUp.LastMod));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1600, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ddc2748d779428dbccecad05d44c53c", async() => {
                BeginContext(1620, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1630, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "225e2a623fbe4ffa888592ea8d0fe39e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Files\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FileUp.FileUpID);

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
                BeginContext(1679, 86, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1765, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ffe8ec8cbc946d39fc2066a3a550dae", async() => {
                    BeginContext(1787, 6, true);
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
                BeginContext(1797, 6, true);
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
            BeginContext(1810, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.FileUploaders.Files.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.FileUploaders.Files.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.FileUploaders.Files.DeleteModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.FileUploaders.Files.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
