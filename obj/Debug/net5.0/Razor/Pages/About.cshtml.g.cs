#pragma checksum "C:\Users\theco\source\repos\CookieUniversity\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f2fbc93a86b46ee8e8a6083c6e2d021594a13e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CookieUniversity.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
namespace CookieUniversity.Pages
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
#line 1 "C:\Users\theco\source\repos\CookieUniversity\Pages\_ViewImports.cshtml"
using CookieUniversity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2fbc93a86b46ee8e8a6083c6e2d021594a13e6", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25068416ee44f87af59f458e8b1e1c3425096d42", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\theco\source\repos\CookieUniversity\Pages\About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Student Body Statistics</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <th>\r\n            Enrollment Date\r\n        </th>\r\n        <th>\r\n            Students\r\n        </th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\theco\source\repos\CookieUniversity\Pages\About.cshtml"
     foreach (var item in Model.Students)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\theco\source\repos\CookieUniversity\Pages\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\theco\source\repos\CookieUniversity\Pages\About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\theco\source\repos\CookieUniversity\Pages\About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CookieUniversity.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CookieUniversity.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CookieUniversity.Pages.AboutModel>)PageContext?.ViewData;
        public CookieUniversity.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591