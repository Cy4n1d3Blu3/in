#pragma checksum "F:\inj\Pages\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e243901f209ca0c2841df06d4fb18039bdf08b84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FizzBuzzWeb.Pages.Pages_All), @"mvc.1.0.razor-page", @"/Pages/All.cshtml")]
namespace FizzBuzzWeb.Pages
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
#line 1 "F:\inj\Pages\_ViewImports.cshtml"
using FizzBuzzWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e243901f209ca0c2841df06d4fb18039bdf08b84", @"/Pages/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a55e7b37e60312cde3ba1780dc114ace485353c5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_All : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "F:\inj\Pages\All.cshtml"
   ViewData["Title"] = "Wszystkie"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Alldata</h1>

<table class=""table"">
    <thead>
        <tr>
            <th> Birthday: </th>
            <th> Name: </th>
            <th> Surname: </th>
            <th> Database input time: </th>
            <th> Leap: </th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 20 "F:\inj\Pages\All.cshtml"
         foreach (var i in Model.data)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td> ");
#nullable restore
#line 23 "F:\inj\Pages\All.cshtml"
            Write(i.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n            <td> ");
#nullable restore
#line 24 "F:\inj\Pages\All.cshtml"
            Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n            <td> ");
#nullable restore
#line 25 "F:\inj\Pages\All.cshtml"
            Write(i.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n            <td> ");
#nullable restore
#line 26 "F:\inj\Pages\All.cshtml"
            Write(i.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n            <td> ");
#nullable restore
#line 27 "F:\inj\Pages\All.cshtml"
            Write(i.Leap);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n        </tr>\n");
#nullable restore
#line 29 "F:\inj\Pages\All.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FizzBuzzWeb.Pages.WszystkieModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FizzBuzzWeb.Pages.WszystkieModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FizzBuzzWeb.Pages.WszystkieModel>)PageContext?.ViewData;
        public FizzBuzzWeb.Pages.WszystkieModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
