#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\FileUploading.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adf6941c4ba9781674601fcdb74d98c9aac624b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.FileUploaders.Pages_FileUploaders_FileUploading), @"mvc.1.0.razor-page", @"/Pages/FileUploaders/FileUploading.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FileUploaders/FileUploading.cshtml", typeof(Esecure2.Pages.FileUploaders.Pages_FileUploaders_FileUploading), null)]
namespace Esecure2.Pages.FileUploaders
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adf6941c4ba9781674601fcdb74d98c9aac624b3", @"/Pages/FileUploaders/FileUploading.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FileUploaders_FileUploading : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jstree/themes/default/style.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FileUpFile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("hidden", new global::Microsoft.AspNetCore.Html.HtmlString("hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("(function () { document.getElementById(\'infoFile\').innerText=document.getElementById(\'FileUpFile\').value; })();return false;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("js-upload-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jstree/jstree.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\FileUploading.cshtml"
  
    ViewData["Title"] = "FileUploading";

#line default
#line hidden
            BeginContext(117, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(221, 27, true);
            WriteLiteral("\r\n<ol class=\"breadcrumb\">\r\n");
            EndContext();
            BeginContext(335, 252, true);
            WriteLiteral("    <li class=\"breadcrumb-item\">\r\n        <a href=\"#\">Empresa</a>\r\n    </li>\r\n    <li class=\"breadcrumb-item\">\r\n        <a href=\"#\">Gestión Documental</a>\r\n    </li>\r\n    <li class=\"breadcrumb-item\">\r\n        <a href=\"#\">Subir Archivos</a>\r\n    </li>\r\n");
            EndContext();
            BeginContext(674, 163, true);
            WriteLiteral("</ol>\r\n<div id=\"content-wrapper\">\r\n    <div class=\"container-fluid\">\r\n        <!-- Breadcrumbs-->\r\n\r\n        <div class=\"card card-header bg-primary text-light\">\r\n");
            EndContext();
            BeginContext(932, 41, true);
            WriteLiteral("            <h4>Gestión Documental</h4>\r\n");
            EndContext();
            BeginContext(1136, 123, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n\r\n        <div class=\"card\">\r\n            <div class=\"col-md-12\">\r\n                <br />\r\n");
            EndContext();
            BeginContext(1358, 129, true);
            WriteLiteral("                <h4 class=\"card card-header bg-primary text-light\">\r\n                    Subir archivos:\r\n                </h4>\r\n");
            EndContext();
            BeginContext(1586, 321, true);
            WriteLiteral(@"                <div class=""container-fluid card card-header bg-light text-dark"">
                    <div class=""row"">
                        <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4 col-xl-4 card card-header bg-primary text-light h6"">
                            Carpetas:
                        </div>
");
            EndContext();
            BeginContext(2108, 295, true);
            WriteLiteral(@"                        <div class=""col-xs-12 col-sm-12 col-md-8  col-lg-8 col-xl-8"">

                            <div class="" card card-header bg-primary text-light h6"">
                                Subir archivo:
                            </div>
                            </div>
");
            EndContext();
            BeginContext(2620, 234, true);
            WriteLiteral("                    </div>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-xs-12 col-sm-12 col-md-4 col-lg-4 col-xl-4 card card-body\" id=\"hdndiv\">\r\n\r\n                                    ");
            EndContext();
            BeginContext(2854, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83491e6df8ff4a7db15a661c4f1ad294", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2928, 254, true);
            WriteLiteral("\r\n                                    <!--agregar hidden-->\r\n                                    <div id=\"jstree\" hidden=\"hidden\" style=\"height:700px;width:100%\">\r\n                                        <ul>\r\n                                            ");
            EndContext();
            BeginContext(3183, 24, false);
#line 68 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\FileUploading.cshtml"
                                       Write(Html.Raw(Model.htmlTree));

#line default
#line hidden
            EndContext();
            BeginContext(3207, 298, true);
            WriteLiteral(@"
                                        </ul>
                                    </div>
                                </div>
                                <div class=""col-xs-12 col-sm-12 col-md-8  col-lg-8 col-xl-8"">

                                    <div class="" card card-body "">
");
            EndContext();
            BeginContext(3677, 452, true);
            WriteLiteral(@"                                        <div class=""alert alert-warning""><strong id=""alertPath"">No hay una ruta seleccionada.</strong></div>
                                        <div class=""alert alert-info""></div>
                                        <h6 class=""card card-body bg-primary text-light"">
                                            Archivo:
                                        </h6>
                                        ");
            EndContext();
            BeginContext(4129, 5442, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e87439e3a97d4292a5dc88ed06c5f6fe", async() => {
                BeginContext(4199, 188, true);
                WriteLiteral("\r\n                                            <div class=\"row\">\r\n\r\n                                                <div class=\"col-6\">\r\n                                                    ");
                EndContext();
                BeginContext(4387, 215, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eab7ac8fb6a74c56a441f5243e9822ab", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 87 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\FileUploading.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Upload);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4602, 1003, true);
                WriteLiteral(@"

                                                    <div class=""alert alert-info toggled"" id=""infoFile"">
                                                        Sin archivo seleccionado.
                                                    </div>
                                                </div>
                                                <div class=""col-6"">
                                                    <button id=""fileSelect"" type=""button"" class=""btn btn-info"" onclick=""(function () { document.getElementById('FileUpFile').click(); })();return false;"">Seleccionar Archivo <i class=""fa fa-search""></i></button>
                                                    <button type=""button"" class=""btn btn-success"" data-toggle=""infoFile"" id=""uploadFile"">Subir <i class=""fa fa-upload""></i> </button>
                                                </div>

                                            </div>


                                            <!-- Standar Form -->
");
                EndContext();
                BeginContext(5691, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(9407, 157, true);
                WriteLiteral("                                            <div class=\"row\">\r\n\r\n                                            </div>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9571, 62, true);
            WriteLiteral("\r\n                                        <!-- Drop Zone -->\r\n");
            EndContext();
            BeginContext(9883, 63, true);
            WriteLiteral("                                        <!-- Progress Bar -->\r\n");
            EndContext();
            BeginContext(10309, 66, true);
            WriteLiteral("                                        <!-- Upload Finished -->\r\n");
            EndContext();
            BeginContext(10967, 158, true);
            WriteLiteral("                                    </div>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n");
            EndContext();
            BeginContext(11232, 88, true);
            WriteLiteral("                    </div>\r\n            <br />\r\n            <p>\r\n                <div>\r\n");
            EndContext();
            BeginContext(11568, 122, true);
            WriteLiteral("                    <br />\r\n                </div>\r\n            </p>\r\n        </div>\r\n        <br />\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(11773, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(11795, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 195 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\FileUploaders\FileUploading.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(11865, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(11869, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd2b838c39b140cd8658065567202a85", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11942, 6929, true);
                WriteLiteral(@"
    <script>
        $(function () {
            // alert(""ready to show"");
            $('#jstree').jstree({
                ""plugins"": [
                    ""wholerow"",
                    ""search""
                ],
                ""core"": {
                    ""multiple"": false
                }
            });
            $('#jstree').removeAttr('hidden');

            // 7 bind to events triggered on the tree
            $('#jstree').on(""select_node.jstree"", function (e, data) {
                // alert(data.node.id);
                putPath(e, data.node);
                var alrt = document.getElementById('alertPath');
                var alrt2 = document.getElementById('NewFileUpFolderUpID');
                alrt.innerText = '';
                //alert(e.getAttribute(""id""));
                var dirty = $('#jstree').jstree().get_path($('#jstree').jstree(""get_selected"", true)[0], '/');
                var cleanPath = $.map(dirty.split(""/""), $.trim);
                alrt.innerTe");
                WriteLiteral(@"xt = '/' + cleanPath.join('/');
                alrt2.innerText = alrt.innerText;
                alrt2.value = data.node.id;
                return;
            });
            // 8 interact with the tree - either way is OK
            $('button').on('click', function () {
                /*
                $('#jstree').jstree(true).select_node('child_node_1');
                $('#jstree').jstree('select_node', 'child_node_1');
                $.jstree.reference('#jstree').select_node('child_node_1');
                */
            });
            function putPath(e) {
                var alrt = document.getElementById('alertPath');

                alrt.innerText = '';
                alrt.innerText = e;
                //var caller = document.getElementById(e.getAttribute('id'));

                //var inrTxt = e.innerText;
                //inrTxt = e.innerText + '<span class=""label label-warning"">(Seleccionado)</span>';
                // e.prepend(""<i class='indicator glyphicon "" +");
                WriteLiteral(@" ""glyphicons-ok-circle"" + ""'></i>"");
                //var mySpans = document.getElementsByTagName(i);

                //$(e).append(""<i class='indicator glyphicon glyphicon-ok'></i>"");
                //alert(e.innerHTML)
                // alert(caller.innerHTML + '\n' + caller.innerText);

                // e.addClass('indicator');
                //e.innerHtml = inrTxt;
                //e.style.backgroundColor = ""yelow"";
                //e.addClass('');
                return;
            }
        });

        'use strict';

        // UPLOAD CLASS DEFINITION
        // ======================

        //var dropZone = document.getElementById('drop-zone');
        //var uploadForm = document.getElementById('js-upload-form');

        //var startUpload = function (files) {
        //    console.log(files);
        //}

        //uploadForm.addEventListener('submit', function (e) {
        //    var uploadFiles = document.getElementById('js-upload-files').files;
        //  ");
                WriteLiteral(@"  e.preventDefault();

        //    startUpload(uploadFiles);
        //})

        //dropZone.ondrop = function (e) {
        //    e.preventDefault();
        //    this.className = 'upload-drop-zone';

        //    startUpload(e.dataTransfer.files)
        //}

        //dropZone.ondragover = function () {
        //    this.className = 'upload-drop-zone drop';
        //    return false;
        //}

        //dropZone.ondragleave = function () {
        //    this.className = 'upload-drop-zone';
        //    return false;
        //}

        /*************  Acción de subir archivo *****************/
        $('#uploadFile').on('click', function () {
            //alert(""procesando archivo"");
            var msgtxt;
            var input, file;
            if (!window.FileReader) {

                msgtxt = ""File API no soportada."";
                return;
            }

            input = document.getElementById('FileUpFile');
            if (!input) {
            ");
                WriteLiteral(@"    msgtxt = ""No se encuentra el archivo."";
            }
            else if (!input.files) {
                msgtxt = ""El navegador no soporta la propiedad 'files'."";
            }
            else if (!input.files[0]) {
                msgtxt = ""Selecciona un archivo antes de presionar el botón 'Load'"";
            }
            else {

                file = input.files[0];

                // alert(file.name + ""-"" + file.size);
                var exten = document.getElementById('FileUpTypeID');
                var dirtyName = file.name.split(""."");
                // TODO: hacer la conversion de tipo de archivo a codigo
                var extension = dirtyName.pop();

                exten.value = 1;
                var size = document.getElementById('FileUpFileSize');
                size.value = file.size;
                var name = document.getElementById('FileUpFileName');
                name.value = file.name;
                //bodyAppend(""p"", ""File "" + file.name + "" is "" + ");
                WriteLiteral(@"file.size + "" bytes in size"");
                msgtxt = ""OK"";
            }
            var msg = document.getElementById(""infoFile"");
            msg.innerText = msgtxt;
            $('#js-upload-form').submit();
            //$('#fileupload').click(); return false;
        });
        $(document).on({
            ajaxStart: function () {
                //alert(""adding class loading"");
                $body.addClass(""loading"");
            },
            ajaxStop: function () {
                $body.removeClass(""loading"");
                //alert(""class loading removed"");
            }
        });
                /*
                function showFileSize() {
                    var input, file;
                    if (!window.FileReader) {
                        bodyAppend(""p"", ""File API no soportada."");
                        return;
                    }

                    input = document.getElementById('fileinput');
                    if (!input) {
                       ");
                WriteLiteral(@" bodyAppend(""p"", ""No se encuentra el archivo."");
                    }
                    else if (!input.files) {
                        bodyAppend(""p"", ""El navegador no soporta la propiedad 'files'."");
                    }
                    else if (!input.files[0]) {
                        bodyAppend(""p"", ""Selecciona un archivo antes de presionar el botón 'Load'"");
                    }
                    else {
                        file = input.files[0];

                        elementUpdate(""FileUpFileSize"", file.size);
                        elementUpdate(""FileUpFileName"", file.name);
                        bodyAppend(""p"", ""File "" + file.name + "" is "" + file.size + "" bytes in size"");
                    }
                }*/
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsecureWebApp.Pages.FileUploaders.FileUploadingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.FileUploaders.FileUploadingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.FileUploaders.FileUploadingModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.FileUploaders.FileUploadingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
