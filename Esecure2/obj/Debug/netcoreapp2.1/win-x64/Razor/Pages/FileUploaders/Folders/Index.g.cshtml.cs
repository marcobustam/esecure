#pragma checksum "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2c804d5cf6beb387d508515052554b6b8fac17d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.FileUploaders.Folders.Pages_FileUploaders_Folders_Index), @"mvc.1.0.razor-page", @"/Pages/FileUploaders/Folders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FileUploaders/Folders/Index.cshtml", typeof(Esecure2.Pages.FileUploaders.Folders.Pages_FileUploaders_Folders_Index), null)]
namespace Esecure2.Pages.FileUploaders.Folders
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2c804d5cf6beb387d508515052554b6b8fac17d", @"/Pages/FileUploaders/Folders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FileUploaders_Folders_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/FileUploaders/Folders/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Planes/Prevencion/Tareas/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(111, 706, true);
            WriteLiteral(@"
<h2>Buscador</h2>

<div class=""row"">
    <div class=""col-md-4"">
        <label> Buscar en Directorios:</label>
        <!----------------------Lista de archivos--------------------------------->
        <input class=""form-control"" id=""myFolder"" type=""text"" placeholder=""Search.."">
    </div>
    <div class=""col-md-2"">
        <label>Buscar en Archivos:</label>
        <!----------------------Lista de archivos--------------------------------->
        <input class=""form-control"" id=""myFile"" type=""text"" placeholder=""Search.."">
    </div>
</div>
<br />
    <table class=""table table-bordered table-striped"" >
        <thead>
            <tr>
                <th>
                    ");
            EndContext();
            BeginContext(818, 58, false);
#line 27 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FolderUp[0].FolderUpID));

#line default
#line hidden
            EndContext();
            BeginContext(876, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(944, 60, false);
#line 30 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FolderUp[0].FolderUpName));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1072, 62, false);
#line 33 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FolderUp[0].FolderUpParent));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1202, 57, false);
#line 36 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FolderUp[0].TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1327, 55, false);
#line 39 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FolderUp[0].LastMod));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 119, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"foTable\">\r\n");
            EndContext();
#line 45 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
             foreach (var item in Model.FolderUp)
            {

#line default
#line hidden
            BeginContext(1567, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1640, 45, false);
#line 49 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FolderUpID));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1765, 47, false);
#line 52 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FolderUpName));

#line default
#line hidden
            EndContext();
            BeginContext(1812, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1892, 49, false);
#line 55 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FolderUpParent));

#line default
#line hidden
            EndContext();
            BeginContext(1941, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2021, 44, false);
#line 58 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2145, 42, false);
#line 61 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastMod));

#line default
#line hidden
            EndContext();
            BeginContext(2187, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2266, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c70befe8f74baba96bf115ce7423c4", async() => {
                BeginContext(2319, 4, true);
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
#line 64 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                                               WriteLiteral(item.FolderUpID);

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
            BeginContext(2327, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2355, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82dc9a9766464445833803b42f84b60f", async() => {
                BeginContext(2411, 7, true);
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
#line 65 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                                                  WriteLiteral(item.FolderUpID);

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
            BeginContext(2422, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2450, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77ac061edc474c1aad1898ba45ecde2f", async() => {
                BeginContext(2505, 6, true);
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
#line 66 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                                                 WriteLiteral(item.FolderUpID);

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
            BeginContext(2515, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 69 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2582, 168, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <table class=\"table table-bordered table-striped\" >\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2751, 58, false);
#line 77 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].FileName));

#line default
#line hidden
            EndContext();
            BeginContext(2809, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2877, 59, false);
#line 80 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].PersonaID));

#line default
#line hidden
            EndContext();
            BeginContext(2936, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(3004, 60, false);
#line 83 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].FolderUpID));

#line default
#line hidden
            EndContext();
            BeginContext(3064, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(3132, 60, false);
#line 86 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].FileTypeID));

#line default
#line hidden
            EndContext();
            BeginContext(3192, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(3260, 58, false);
#line 89 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].FileSize));

#line default
#line hidden
            EndContext();
            BeginContext(3318, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(3386, 59, false);
#line 92 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(3445, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(3513, 57, false);
#line 95 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].LastMod));

#line default
#line hidden
            EndContext();
            BeginContext(3570, 167, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Acciones\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"fiTable\">\r\n");
            EndContext();
#line 103 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
             foreach (var item in Model.FileUpList)
            {

#line default
#line hidden
            BeginContext(3805, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3878, 43, false);
#line 107 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FileName));

#line default
#line hidden
            EndContext();
            BeginContext(3921, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4001, 44, false);
#line 110 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PersonaID));

#line default
#line hidden
            EndContext();
            BeginContext(4045, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4125, 45, false);
#line 113 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FolderUpID));

#line default
#line hidden
            EndContext();
            BeginContext(4170, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4250, 45, false);
#line 116 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FileTypeID));

#line default
#line hidden
            EndContext();
            BeginContext(4295, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4375, 43, false);
#line 119 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FileSize));

#line default
#line hidden
            EndContext();
            BeginContext(4418, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4498, 44, false);
#line 122 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(4542, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4622, 42, false);
#line 125 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastMod));

#line default
#line hidden
            EndContext();
            BeginContext(4664, 132, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"btn-group\">\r\n                            ");
            EndContext();
            BeginContext(4796, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d988035f68dd45f7884f9784c12ac210", async() => {
                BeginContext(4882, 27, true);
                WriteLiteral("<i class=\"fa fa-plus\"> </i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4913, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4943, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2754e339d56408f876c17cdfa0d962f", async() => {
                BeginContext(5046, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5076, 462, true);
            WriteLiteral(@"
                            <a class=""btn btn-xs btn-info""><i class=""fa fa-file-download""></i></a>
                            <a class=""btn btn-xs btn-warning""><i class=""fa fa-edit""></i></a>
                            <a class=""btn btn-xs""><i class=""fa fa-arrow-right""></i></a>
                            <a class=""btn btn-xs btn-danger""><i class=""fas fa-times""></i></a>
                        </div>
                    </td>
                </tr>
");
            EndContext();
#line 138 "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5553, 34, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5618, 985, true);
                WriteLiteral(@"
        <script>
            $(document).ready(function () {
                $(""#myFolder"").on(""keyup"", function () {
                    //alert(""asdas"");
                    var value = $(this).val().toLowerCase();
                    $(""#foTable tr"").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                    $(""#fiTable tr"").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
                $(""#myFile"").on(""keyup"", function () {
                    //alert(""asdas"");
                    var value = $(this).val().toLowerCase();
                    $(""#fiTable tr"").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.FileUploaders.Folders.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.FileUploaders.Folders.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.FileUploaders.Folders.IndexModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.FileUploaders.Folders.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
