#pragma checksum "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d942b45811a2780b0f592d50a6d6a881e84e5cfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index2), @"mvc.1.0.view", @"/Views/Home/Index2.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Escritorio\Programacion\Storey\Grilla\Views\_ViewImports.cshtml"
using Grilla;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Escritorio\Programacion\Storey\Grilla\Views\_ViewImports.cshtml"
using Grilla.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d942b45811a2780b0f592d50a6d6a881e84e5cfb", @"/Views/Home/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd191692940e15e620f53a8bfac3e4f97b4cb8d9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Measurer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\Index2.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\Index2.cshtml"
Write(Html.Partial("_MeasurersList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <link href=""https://cdn.datatables.net/v/dt/dt-1.13.6/datatables.min.css"" rel=""stylesheet"">
    <script src=""https://cdn.datatables.net/v/dt/dt-1.13.6/datatables.min.js""></script>

    <script>
        $(document).ready(function () {
            /*$('#datatable').DataTable()*/

            let table = new DataTable('#dataTable');
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Measurer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591