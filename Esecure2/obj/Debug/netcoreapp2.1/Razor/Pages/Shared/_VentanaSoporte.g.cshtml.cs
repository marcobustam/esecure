#pragma checksum "C:\Users\marco\source\repos\esecure\Esecure2\Esecure2\Pages\Shared\_VentanaSoporte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5105231f759edec3740c9bffdece8f4feaa26590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Esecure2.Pages.Shared.Pages_Shared__VentanaSoporte), @"mvc.1.0.view", @"/Pages/Shared/_VentanaSoporte.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_VentanaSoporte.cshtml", typeof(Esecure2.Pages.Shared.Pages_Shared__VentanaSoporte))]
namespace Esecure2.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5105231f759edec3740c9bffdece8f4feaa26590", @"/Pages/Shared/_VentanaSoporte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__VentanaSoporte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/API/TicketsController", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 967, true);
            WriteLiteral(@"        <div class=""card card-footer text-center text-black-50"">
            <p class=""text-dark m-0"">
                En caso de cualquier problema contacta con nuestro
                <!-- Trigger the modal with a button -->
                <button type=""button"" class=""btn btn-success btn-sm"" data-toggle=""modal"" data-target=""#modalMsg"" id=""soporte"">
                    Soporte 24/7
                </button>
            </p>
        </div>
    
    
<!-- Modal -->
<div id=""modalMsg"" class=""modal fade bg-light"" role=""dialog"">

    <div class=""modal-dialog bg-transparent"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header bg-success"">
                <div class=""text-white text-center py-2"">
                    <h3><i class=""fa fa-envelope""></i> Contactanos</h3>
                    <p class=""m-0"">Con gusto te ayudaremos</p>
                </div>
            </div>
            ");
            EndContext();
            BeginContext(1097, 2622, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cc5468a8bd7486a8ba51f3a39d5b4ae", async() => {
                BeginContext(1151, 2561, true);
                WriteLiteral(@"
                <div class=""modal-body bg-light"">

                    <!--Form with header-->

                    <div class=""card border-success rounded-0  bg-light"">
                        <div class=""card-header p-0"">

                        </div>
                        <div class=""card-body"">
                            <!--Body-->
                            <div class=""form-group"">
                                <div class=""input-group mb-2"">
                                    <div class=""input-group-prepend"">
                                        <div class=""input-group-text""><i class=""fa fa-user text-success""></i></div>
                                    </div>
                                    <input type=""text"" class=""form-control"" id=""nombre"" name=""nombre"" placeholder=""Nombre y Apellido"" required>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=");
                WriteLiteral(@"""input-group mb-2"">
                                    <div class=""input-group-prepend"">
                                        <div class=""input-group-text""><i class=""fa fa-envelope text-success""></i></div>
                                    </div>
                                    <input type=""email"" class=""form-control"" id=""nombre"" name=""email"" placeholder=""ejemplo@gmail.com"" required>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""input-group mb-2"">
                                    <div class=""input-group-prepend"">
                                        <div class=""input-group-text""><i class=""fa fa-comment text-success""></i></div>
                                    </div>
                                    <textarea class=""form-control"" placeholder=""Envianos tu Mensaje"" required></textarea>
                                </div>
                            </");
                WriteLiteral(@"div>

                        </div>
                    </div>

                    <!--Form with header-->

                </div>
                <div class=""modal-footer bg-success"">
                    <div class=""text-center"">
                        <input type=""submit"" value=""Enviar"" class=""btn btn-default btn-sm"">

                    </div>
                    <button type=""button"" class=""btn btn-default btn-sm"" data-dismiss=""modal"">Cerrar</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3719, 485, true);
            WriteLiteral(@"
        </div>


    </div>
</div>
<div id=""modalMsg"" class=""modal fade"" role=""dialog"">
    <div class=""container"">
        <h2 class=""text-center"">Contact Form</h2>
        <div class=""row justify-content-center"">
            <div class=""col-12 col-md-8 col-lg-6 pb-5"">

            </div>
        </div>
    </div>
    <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cerrar</button>
    </div>
</div>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591