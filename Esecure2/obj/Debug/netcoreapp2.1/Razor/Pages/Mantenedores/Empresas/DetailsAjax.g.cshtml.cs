#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Empresas\DetailsAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb5745ac9835dd4581b5985042e8c413cdb159bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Mantenedores.Empresas.Pages_Mantenedores_Empresas_DetailsAjax), @"mvc.1.0.razor-page", @"/Pages/Mantenedores/Empresas/DetailsAjax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Mantenedores/Empresas/DetailsAjax.cshtml", typeof(Esecure2.Pages.Mantenedores.Empresas.Pages_Mantenedores_Empresas_DetailsAjax), null)]
namespace Esecure2.Pages.Mantenedores.Empresas
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb5745ac9835dd4581b5985042e8c413cdb159bb", @"/Pages/Mantenedores/Empresas/DetailsAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mantenedores_Empresas_DetailsAjax : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DetailEmpresaAjax", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Empresas\DetailsAjax.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(119, 93, true);
            WriteLiteral("<div class=\"container\">\r\n    <h1 class=\"alert-warning\">Ajax </h1>\r\n    <h2 class=\"text-info\">");
            EndContext();
            BeginContext(213, 51, false);
#line 9 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Empresas\DetailsAjax.cshtml"
                     Write(Html.DisplayFor(model => model.Empresa.RazonSocial));

#line default
#line hidden
            EndContext();
            BeginContext(264, 49, true);
            WriteLiteral("</h2>\r\n    <div class=\"text-hide\" id=\"EmpresaID\">");
            EndContext();
            BeginContext(314, 49, false);
#line 10 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\Mantenedores\Empresas\DetailsAjax.cshtml"
                                     Write(Html.DisplayFor(model => model.Empresa.EmpresaID));

#line default
#line hidden
            EndContext();
            BeginContext(363, 43, true);
            WriteLiteral("</div>\r\n    <!-- Datos de empresa -->\r\n    ");
            EndContext();
            BeginContext(406, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8bf380ff571444418b569ffb267fb38f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(443, 1069, true);
            WriteLiteral(@"
</div>



<style>
    body {
        font-family: Arial;
    }

    /* Style the tab */
    .tab {
        overflow: hidden;
        border: 1px solid #ccc;
        background-color: #f1f1f1;
    }

        /* Style the buttons inside the tab */
        .tab button {
            background-color: inherit;
            float: left;
            border: none;
            outline: none;
            cursor: pointer;
            padding: 14px 16px;
            transition: 0.3s;
            font-size: 17px;
        }

            /* Change background color of buttons on hover */
            .tab button:hover {
                background-color: #ddd;
            }

            /* Create an active/current tablink class */
            .tab button.active {
                background-color: #ccc;
            }

    /* Style the tab content */
    .tabcontent {
        display: none;
        padding: 6px 12px;
        -webkit-animation: fadeEffect 1s;
        animation: fadeEffe");
            WriteLiteral("ct 1s;\r\n    }\r\n\r\n    /* Fade in tabs */\r\n    ");
            EndContext();
            BeginContext(1513, 150, true);
            WriteLiteral("@-webkit-keyframes fadeEffect {\r\n        from {\r\n            opacity: 0;\r\n        }\r\n\r\n        to {\r\n            opacity: 1;\r\n        }\r\n    }\r\n\r\n    ");
            EndContext();
            BeginContext(1664, 1318, true);
            WriteLiteral(@"@keyframes fadeEffect {
        from {
            opacity: 0;
        }

        to {
            opacity: 1;
        }
    }
</style>

<style>
 /* Se movio al site css*/
 /*  Working !! */
 /*
    .submodal {
        display: none;
        position: fixed;
        z-index: 1000;
        top: 0;
        left: 0;
        height: 100%;
        width: 100%;
        background: rgba( 255, 255, 255, .8 ) url(/images/ajax-loader.gif) 50% 50% no-repeat;
    }
    /* When the body has the loading class, we turn
    the scrollbar off with overflow:hidden 
    body .loading .submodal {
        overflow: hidden;
    }

    /* Anytime the body has the loading class, our
     modal element will be visible 
    body.loading .submodal {
        display: block;
    }*/
</style>
    <div class=""tab"">
        <button class=""tablinks"" onclick=""openAjax(event, 'Planes')"" id=""btnGetPlanes""> Planes</button>
        <button class=""tablinks"" onclick=""openAjax(event, 'Faenas')"" id=""btnGetFaenas");
            WriteLiteral(@"""> Faenas</button>
        <button class=""tablinks"" onclick=""openAjax(event, 'Personas')"" id=""btnGetPersonas"">Personas</button>
    </div>

    <div id=""Planes"" class=""tabcontent""></div>

    <div id=""Faenas"" class=""tabcontent""></div>

    <div id=""Personas"" class=""tabcontent""></div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3013, 3792, true);
                WriteLiteral(@"
        <script type=""text/javascript"" language=""JavaScript"">
           
            function openAjax(evt, partial) {
                var i, tabcontent, tablinks;
                tabcontent = document.getElementsByClassName(""tabcontent"");
                for (i = 0; i < tabcontent.length; i++) {
                    tabcontent[i].style.display = ""none"";
                }
                tablinks = document.getElementsByClassName(""tablinks"");
                for (i = 0; i < tablinks.length; i++) {
                    tablinks[i].className = tablinks[i].className.replace(""active"", """");
                }
                document.getElementById(partial).style.display = ""block"";
                evt.currentTarget.className += ""active"";
            }
        </script>
            
        <script type=""text/javascript"" language=""JavaScript"">
            $(document).ready(function () {
                $('#mod2ttl').html(""<div class='alert-warning'> Información <span class='glyphicon glyphicon-wa");
                WriteLiteral(@"rning-sign'></span> </div>"");
                $('#mod2msg').html(""<div class='alert-warning'> Hola Msg box  </div>"");
                //$('#hdnbtn').click();
                $body = $(""body"");

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
                
                $('#btnGetPlanes').on('click', function () {                   
                    callAjax(""p"");
                });
                $('#btnGetFaenas').on('click', function () {                    
                    callAjax(""f"");                    
                });
                $('#btnGetPersonas').on('click', function () {           ");
                WriteLiteral(@"         
                    callAjax(""h"");                    
                });
            });
            function callAjax(callingType) {
                var empresaID = 1;
                
                $.ajax({
                    type: ""GET"",
                    url: ""/Mantenedores/Empresas/DetailsAjax?handler=List&emid="" + empresaID + ""&tipo="" + callingType,
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader(""XSRF-TOKEN"",
                            $('input:hidden[name=""__RequestVerificationToken""]').val());
                    },
                    contentType: ""application/json"",
                    dataType: ""html"",
                    complete: function () {
                       
                    },
                    success: function (response) {
                        //alert(""success!"");
                        if (callingType == ""p"") {
                            var dvItems = $(""#Planes"");
                      ");
                WriteLiteral(@"  }
                        else if (callingType == ""f"") {
                            var dvItems = $(""#Faenas"");
                        }
                        else if (callingType == ""h"") {
                            var dvItems = $(""#Personas"");
                        }
                        else {
                            ;;
                        }
                        dvItems.empty();
                        dvItems.html(response);                        
                    },
                    failure: function (response) {
                       
                        alert(response);
                    }
                });
            }

        </script>
    ");
                EndContext();
            }
            );
            BeginContext(6808, 68, true);
            WriteLiteral("        <div class=\"submodal\"><!-- Place at bottom of page --></div>");
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Mantenedores.Empresas.DetailsAjaxModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EsecureWebApp.Pages.Mantenedores.Empresas.DetailsAjaxModel>)PageContext?.ViewData;
        public EsecureWebApp.Pages.Mantenedores.Empresas.DetailsAjaxModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
