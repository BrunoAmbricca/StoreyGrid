#pragma checksum "C:\Users\Walter Armando Cruz\Desarrollos\VISUAL STUDIO\StoreyGrid\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "527e76b147eacb2a7918a5deea75d127dc51e7ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Walter Armando Cruz\Desarrollos\VISUAL STUDIO\StoreyGrid\Views\_ViewImports.cshtml"
using Grilla;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Walter Armando Cruz\Desarrollos\VISUAL STUDIO\StoreyGrid\Views\_ViewImports.cshtml"
using Grilla.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"527e76b147eacb2a7918a5deea75d127dc51e7ce", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd191692940e15e620f53a8bfac3e4f97b4cb8d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Measurer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Walter Armando Cruz\Desarrollos\VISUAL STUDIO\StoreyGrid\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
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
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <link href=\"https://cdn.datatables.net/v/dt/dt-1.13.6/datatables.min.css\" rel=\"stylesheet\">\r\n    <script src=\"https://cdn.datatables.net/v/dt/dt-1.13.6/datatables.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "527e76b147eacb2a7918a5deea75d127dc51e7ce4836", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "527e76b147eacb2a7918a5deea75d127dc51e7ce5935", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#datatable\').DataTable({\r\n                \"processing\": true,\r\n                \"serverSide\": true,\r\n                \"ajax\": {\r\n                    \"url\": \"");
#nullable restore
#line 40 "C:\Users\Walter Armando Cruz\Desarrollos\VISUAL STUDIO\StoreyGrid\Views\Home\Index.cshtml"
                       Write(Url.Content("~/Home/GetMeasurers"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""pageLength"": 10,
                ""filter"": false,
                ""responsivePriority"": 1,
                ""data"": null,
                ""columns"": [
                    { ""data"": ""Model"", ""name"": ""Model"", ""autoWidth"": true },
                    { ""data"": ""SerialNumber"", ""name"": ""SerialNumber"", ""autoWidth"": true },
                    { ""data"": ""CustomerNumber"", ""name"": ""CustomerNumber"", ""autoWidth"": true },
                    { ""data"": ""Name"", ""name"": ""Name"", ""autoWidth"": true },
                    { ""data"": ""Address"", ""name"": ""Address"", ""autoWidth"": true },
                    { ""data"": ""City"", ""name"": ""City"", ""autoWidth"": true },
                    { ""data"": ""Notes"", ""name"": ""Notes"", ""autoWidth"": true },
                    { ""data"": ""Status"", ""name"": ""Status"", ""autoWidth"": true },
                    { ""data"": ""LastLecture"", ""name"": ""LastLecture"", ""autoWidth"": true },
   ");
                WriteLiteral("             ]\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Measurer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
