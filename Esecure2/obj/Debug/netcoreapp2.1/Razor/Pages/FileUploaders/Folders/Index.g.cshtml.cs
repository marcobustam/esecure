#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbf65e3d709f2267c6b2390b2112e494ad3a107c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf65e3d709f2267c6b2390b2112e494ad3a107c", @"/Pages/FileUploaders/Folders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FileUploaders_Folders_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/FileUploaders/Folders/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(111, 633, true);
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
<h2>Directorios:</h2>
<div class=""bg-secondary text-dark"">
");
            EndContext();
            BeginContext(828, 226, true);
            WriteLiteral("        <table class=\"table table-bordered table-striped table-hover text-dark table-responsive-md\" style=\"width:100%\" id=\"datata\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1055, 58, false);
#line 30 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FolderUp[0].FolderUpID));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1193, 60, false);
#line 33 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FolderUp[0].FolderUpName));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1333, 62, false);
#line 36 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FolderUp[0].FolderUpParent));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1475, 57, false);
#line 39 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FolderUp[0].TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1612, 55, false);
#line 42 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FolderUp[0].LastMod));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 139, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody id=\"foTable\">\r\n");
            EndContext();
#line 48 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                 foreach (var item in Model.FolderUp)
                {

#line default
#line hidden
            BeginContext(1880, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1965, 45, false);
#line 52 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FolderUpID));

#line default
#line hidden
            EndContext();
            BeginContext(2010, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2102, 47, false);
#line 55 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FolderUpName));

#line default
#line hidden
            EndContext();
            BeginContext(2149, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2241, 49, false);
#line 58 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FolderUpParent));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2382, 44, false);
#line 61 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2426, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2518, 42, false);
#line 64 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastMod));

#line default
#line hidden
            EndContext();
            BeginContext(2560, 148, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"btn-group\">\r\n                                ");
            EndContext();
            BeginContext(2708, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf0d3f0e1ed84867894966fd86e1289c", async() => {
                BeginContext(2803, 6, true);
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
#line 68 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                                                       WriteLiteral(item.FolderUpID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(2813, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2847, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19802a36a5d24255a364e163570436d8", async() => {
                BeginContext(2945, 8, true);
                WriteLiteral("Detalles");
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
#line 69 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                                                          WriteLiteral(item.FolderUpID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(2957, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2991, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019d9e3aa4274456b0bb6500571d82fb", async() => {
                BeginContext(3088, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                                                         WriteLiteral(item.FolderUpID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(3100, 100, true);
            WriteLiteral("\r\n                                </div>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 74 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3219, 726, true);
            WriteLiteral(@"            </tbody>
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
                </tr>
            </tfoot>
        </table>
</div>
<br />
<h2>Archivos:</h2>
<div class=""bg-secondary text-dark"">
    <table class=""table table-bordered table-striped table-hover text-dark table-responsive-md"" style=""width:100%"" id=""datata"">
        <thead>
            <tr>
                <th>
                    ");
            EndContext();
            BeginContext(3946, 58, false);
#line 101 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].FileName));

#line default
#line hidden
            EndContext();
            BeginContext(4004, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(4072, 59, false);
#line 104 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].PersonaID));

#line default
#line hidden
            EndContext();
            BeginContext(4131, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(4199, 60, false);
#line 107 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].FolderUpID));

#line default
#line hidden
            EndContext();
            BeginContext(4259, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(4327, 60, false);
#line 110 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].FileTypeID));

#line default
#line hidden
            EndContext();
            BeginContext(4387, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(4455, 58, false);
#line 113 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].FileSize));

#line default
#line hidden
            EndContext();
            BeginContext(4513, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(4581, 59, false);
#line 116 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(4640, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(4708, 57, false);
#line 119 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FileUpList[0].LastMod));

#line default
#line hidden
            EndContext();
            BeginContext(4765, 167, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Acciones\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"fiTable\">\r\n");
            EndContext();
#line 127 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
             foreach (var item in Model.FileUpList)
            {

#line default
#line hidden
            BeginContext(5000, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5073, 43, false);
#line 131 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FileName));

#line default
#line hidden
            EndContext();
            BeginContext(5116, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5196, 44, false);
#line 134 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PersonaID));

#line default
#line hidden
            EndContext();
            BeginContext(5240, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5320, 45, false);
#line 137 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FolderUpID));

#line default
#line hidden
            EndContext();
            BeginContext(5365, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5445, 45, false);
#line 140 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FileTypeID));

#line default
#line hidden
            EndContext();
            BeginContext(5490, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5570, 43, false);
#line 143 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FileSize));

#line default
#line hidden
            EndContext();
            BeginContext(5613, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5693, 44, false);
#line 146 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(5737, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5817, 42, false);
#line 149 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastMod));

#line default
#line hidden
            EndContext();
            BeginContext(5859, 132, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"btn-group\">\r\n                            ");
            EndContext();
            BeginContext(5991, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fa3217290dc41c680528747366d9ff0", async() => {
                BeginContext(6077, 26, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
            BeginContext(6107, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(6137, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f6060118c9644508e3e91af8bbe0e81", async() => {
                BeginContext(6240, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6270, 462, true);
            WriteLiteral(@"
                            <a class=""btn btn-sm btn-info""><i class=""fa fa-file-download""></i></a>
                            <a class=""btn btn-sm btn-warning""><i class=""fa fa-edit""></i></a>
                            <a class=""btn btn-sm""><i class=""fa fa-arrow-right""></i></a>
                            <a class=""btn btn-sm btn-danger""><i class=""fas fa-times""></i></a>
                        </div>
                    </td>
                </tr>
");
            EndContext();
#line 162 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\Folders\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(6747, 472, true);
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
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7242, 897, true);
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
