#pragma checksum "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersListDataTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74eae3bf164773330540f8e84cefaa041f4215d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__MeasurersListDataTable), @"mvc.1.0.view", @"/Views/Home/_MeasurersListDataTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eae3bf164773330540f8e84cefaa041f4215d0", @"/Views/Home/_MeasurersListDataTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd191692940e15e620f53a8bfac3e4f97b4cb8d9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home__MeasurersListDataTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersListDataTable.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Medidores</h1>

<table class=""table"" id=""dataTable"">
    <thead>
        <tr>
            <th>Model</th>
            <th>SerialNumber</th>
            <th>CustomerNumber</th>
            <th>Name</th>
            <th>Address</th>
            <th>City</th>
            <th>Notes</th>
            <th>Status</th>
            <th>LastLecture</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
