#pragma checksum "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8e68d8f71ee6ebde606619b2aeea2481e5f5818"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\_ViewImports.cshtml"
using PhotoLooper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\_ViewImports.cshtml"
using PhotoLooper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e68d8f71ee6ebde606619b2aeea2481e5f5818", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac8af34965a0a1dcb91b06b2a2e1ca6c68d24af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserCollector>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
    <style>
        .border {
            list-style: none;
            padding: 0;
        }

            .border li {
                font-family: ""Trebuchet MS"", ""Lucida Sans"";
                padding: 7px 20px;
                margin-bottom: 10px;
                border-radius: 5px;
                border-left: 10px solid #f05d22;
                box-shadow: 2px -2px 5px 0 rgba(0,0,0,.1), -2px -2px 5px 0 rgba(0,0,0,.1), 2px 2px 5px 0 rgba(0,0,0,.1), -2px 2px 5px 0 rgba(0,0,0,.1);
                font-size: 20px;
                letter-spacing: 2px;
                transition: 0.3s all linear;
            }

                .border li:nth-child(2) {
                    border-color: #8bc63e;
                }

                .border li:nth-child(3) {
                    border-color: #fcba30;
                }

                .border li:nth-child(4) {
                    border-color: #1ccfc9;
                }

                .border li:nth-child(5) {
                  ");
            WriteLiteral(@"  border-color: #493224;
                }

                .border li:hover {
                    border-left: 10px solid transparent;
                }

                .border li:nth-child(1):hover {
                    border-right: 10px solid #f05d22;
                }

                .border li:nth-child(2):hover {
                    border-right: 10px solid #8bc63e;
                }

                .border li:nth-child(3):hover {
                    border-right: 10px solid #fcba30;
                }

                .border li:nth-child(4):hover {
                    border-right: 10px solid #1ccfc9;
                }

                .border li:nth-child(5):hover {
                    border-right: 10px solid #493224;
                }
    </style>

<div class=""main row-space"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8e68d8f71ee6ebde606619b2aeea2481e5f58186448", async() => {
                WriteLiteral("\r\n        <input name=\"s\" placeholder=\"Искать здесь...\" type=\"search\">\r\n        <button type=\"submit\">Поиск</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Search.cshtml"
         if (Model != null && Model.Count() != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"border\">\r\n");
#nullable restore
#line 75 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Search.cshtml"
                 foreach(var x in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <img");
            BeginWriteAttribute("src", " src=", 2343, "", 2366, 1);
#nullable restore
#line 78 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Search.cshtml"
WriteAttributeValue("", 2348, x.User.AvatarPath, 2348, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"70\"");
            BeginWriteAttribute("alt", " alt=\"", 2389, "\"", 2395, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8e68d8f71ee6ebde606619b2aeea2481e5f58189565", async() => {
#nullable restore
#line 79 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Search.cshtml"
                                                          Write(x.User.NickName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2434, "~/Home/Profile?id=", 2434, 18, true);
#nullable restore
#line 79 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 2452, x.User.Id, 2452, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <span>     Born date: ");
#nullable restore
#line 80 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Search.cshtml"
                                         Write(x.User.Born.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </li>\r\n");
#nullable restore
#line 82 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 84 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserCollector>> Html { get; private set; }
    }
}
#pragma warning restore 1591
