#pragma checksum "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\BbsPages\Bl\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f656c38ef5d17f96e512737f21691b88881a11c"
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
#line 1 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\BbsPages\_ViewImports.cshtml"
using bbs;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f656c38ef5d17f96e512737f21691b88881a11c", @"/Pages/BbsPages/Bl/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1cd25188c6d7242c1cac5df14ef4406522acdb", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8c6dca070808383fdca8b9428cb392b6dc96e5", @"/Pages/BbsPages/_ViewImports.cshtml")]
    public class Pages_BbsPages_Bl_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\marco\source\repos\esecure\esecure\Esecure2\Pages\BbsPages\Bl\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(4743, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4851, 484, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_BbsPages_Bl_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_BbsPages_Bl_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_BbsPages_Bl_Index>)PageContext?.ViewData;
        public Pages_BbsPages_Bl_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
