#pragma checksum "D:\GitHub\Ticket System\Ticket System\Views\BUG\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ec6299fe0e865a2a4fcb1d39f2c0e69a90080a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BUG_Index), @"mvc.1.0.view", @"/Views/BUG/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BUG/Index.cshtml", typeof(AspNetCore.Views_BUG_Index))]
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
#line 1 "D:\GitHub\Ticket System\Ticket System\Views\_ViewImports.cshtml"
using Ticket_System;

#line default
#line hidden
#line 2 "D:\GitHub\Ticket System\Ticket System\Views\_ViewImports.cshtml"
using Ticket_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec6299fe0e865a2a4fcb1d39f2c0e69a90080a6", @"/Views/BUG/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"555ada6b69b64d1c7cafa5a44c0c6f8d8b197b8b", @"/Views/_ViewImports.cshtml")]
    public class Views_BUG_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ticket_System.Models.bug_report>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatables-simple-demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 59, true);
            WriteLiteral("\r\n<div class=\"container-fluid px-4\">\r\n    <h1 class=\"mt-4\">");
            EndContext();
            BeginContext(113, 21, false);
#line 4 "D:\GitHub\Ticket System\Ticket System\Views\BUG\Index.cshtml"
                Write(ViewData["Page_Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(134, 250, true);
            WriteLiteral("</h1>\r\n    <ol class=\"breadcrumb mb-4\">\r\n        <li class=\"breadcrumb-item active\"><a href=\"https://\">新增</a></li>\r\n    </ol>\r\n    <div class=\"card mb-4\">\r\n        <div class=\"card-header\">\r\n            <i class=\"fas fa-table me-1\"></i>\r\n            ");
            EndContext();
            BeginContext(385, 26, false);
#line 11 "D:\GitHub\Ticket System\Ticket System\Views\BUG\Index.cshtml"
       Write(ViewData["DataTable_Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(411, 783, true);
            WriteLiteral(@"
        </div>
        <div class=""card-body"">
            <table id=""datatablesSimple"">
                <thead>
                    <tr>
                        <th>功能</th>
                        <th>標題</th>
                        <th>處理狀態</th>
                        <th>優先度</th>
                        <th>新增者</th>
                        <th>處理人員</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>功能</th>
                        <th>標題</th>
                        <th>處理狀態</th>
                        <th>優先度</th>
                        <th>新增者</th>
                        <th>處理人員</th>
                    </tr>
                </tfoot>
                <tbody>
");
            EndContext();
#line 36 "D:\GitHub\Ticket System\Ticket System\Views\BUG\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1267, 153, true);
            WriteLiteral("                        <tr>\r\n                            <td><a href=\"https://\">編輯 </a><a href=\"https://\"> 刪除</a></td>\r\n                            <td>");
            EndContext();
            BeginContext(1421, 9, false);
#line 40 "D:\GitHub\Ticket System\Ticket System\Views\BUG\Index.cshtml"
                           Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1430, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1470, 10, false);
#line 41 "D:\GitHub\Ticket System\Ticket System\Views\BUG\Index.cshtml"
                           Write(item.state);

#line default
#line hidden
            EndContext();
            BeginContext(1480, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1520, 13, false);
#line 42 "D:\GitHub\Ticket System\Ticket System\Views\BUG\Index.cshtml"
                           Write(item.priority);

#line default
#line hidden
            EndContext();
            BeginContext(1533, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1573, 13, false);
#line 43 "D:\GitHub\Ticket System\Ticket System\Views\BUG\Index.cshtml"
                           Write(item.add_user);

#line default
#line hidden
            EndContext();
            BeginContext(1586, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1626, 11, false);
#line 44 "D:\GitHub\Ticket System\Ticket System\Views\BUG\Index.cshtml"
                           Write(item.finish);

#line default
#line hidden
            EndContext();
            BeginContext(1637, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 46 "D:\GitHub\Ticket System\Ticket System\Views\BUG\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1698, 88, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1803, 136, true);
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" crossorigin=\"anonymous\"></script>\r\n    ");
                EndContext();
                BeginContext(1939, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3ddd9eb5fda4c15929121b1ecbe35a7", async() => {
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
                EndContext();
                BeginContext(1977, 233, true);
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js\" crossorigin=\"anonymous\"></script>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/simple-datatables@latest\" crossorigin=\"anonymous\"></script>\r\n    ");
                EndContext();
                BeginContext(2210, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "577a96aa93764eadb3e41d7e7a4c864a", async() => {
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
                EndContext();
                BeginContext(2264, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ticket_System.Models.bug_report>> Html { get; private set; }
    }
}
#pragma warning restore 1591
