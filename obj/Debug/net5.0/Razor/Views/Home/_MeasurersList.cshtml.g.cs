#pragma checksum "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bec020da7566e6692eb41d21357a62e7739d11a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__MeasurersList), @"mvc.1.0.view", @"/Views/Home/_MeasurersList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec020da7566e6692eb41d21357a62e7739d11a9", @"/Views/Home/_MeasurersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd191692940e15e620f53a8bfac3e4f97b4cb8d9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home__MeasurersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Grilla.Models.Measurer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Medidores</h1>\r\n\r\n<table class=\"table\" id=\"dataTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayNameFor(model => model.LastLecture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastLecture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 72 "D:\Escritorio\Programacion\Storey\Grilla\Views\Home\_MeasurersList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Grilla.Models.Measurer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591