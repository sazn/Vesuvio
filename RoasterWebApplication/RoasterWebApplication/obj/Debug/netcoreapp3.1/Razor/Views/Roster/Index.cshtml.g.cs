#pragma checksum "C:\Users\sazn_\source\repos\RoasterWebApplication\RoasterWebApplication\Views\Roster\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b59afed3a56793b111983b7702022bd9f341a6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roster_Index), @"mvc.1.0.view", @"/Views/Roster/Index.cshtml")]
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
#line 1 "C:\Users\sazn_\source\repos\RoasterWebApplication\RoasterWebApplication\Views\_ViewImports.cshtml"
using RoasterWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sazn_\source\repos\RoasterWebApplication\RoasterWebApplication\Views\_ViewImports.cshtml"
using RoasterWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b59afed3a56793b111983b7702022bd9f341a6a", @"/Views/Roster/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e46ea4c97e0d3e355bfcde6ae0556bffecd5b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Roster_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoasterWebApplication.Models.Member>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sazn_\source\repos\RoasterWebApplication\RoasterWebApplication\Views\Roster\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .modal-dialog, modal-sm {\r\n        width: 351px;\r\n    }\r\n</style>\r\n");
            WriteLiteral(@"

<div class=""modal fade"" id=""getCodeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Success</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            </div>
            <div class=""modal-body"" id=""success-message"">

            </div>
        </div>
    </div>
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
           ");
            WriteLiteral(@" <div class=""modal-body"">
                <p>Modal body text goes here.</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<div>
    <h4>Roster List</h4>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Full Name</th>
                <th>Group Name</th>
                <th>Age</th>
            </tr>
        </thead>
        <tbody id=""tableBody"">
");
#nullable restore
#line 61 "C:\Users\sazn_\source\repos\RoasterWebApplication\RoasterWebApplication\Views\Roster\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\sazn_\source\repos\RoasterWebApplication\RoasterWebApplication\Views\Roster\Index.cshtml"
                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\sazn_\source\repos\RoasterWebApplication\RoasterWebApplication\Views\Roster\Index.cshtml"
                   Write(item.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\sazn_\source\repos\RoasterWebApplication\RoasterWebApplication\Views\Roster\Index.cshtml"
                   Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>             \r\n                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\sazn_\source\repos\RoasterWebApplication\RoasterWebApplication\Views\Roster\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoasterWebApplication.Models.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591