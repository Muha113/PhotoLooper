#pragma checksum "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bde582e3a7a7f3ce022c81910f5ce97730707c38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Photo), @"mvc.1.0.view", @"/Views/Home/Photo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde582e3a7a7f3ce022c81910f5ce97730707c38", @"/Views/Home/Photo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac8af34965a0a1dcb91b06b2a2e1ca6c68d24af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Photo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostCollector>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TypeComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
  
    ViewData["Title"] = "Photo";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde582e3a7a7f3ce022c81910f5ce97730707c384754", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta id=""viewport"" name=""viewport"" content=""width=320; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;"" />
    <style>
        /*#testim {
            top: 100px; 
            left: 100px; 
            bottom: 0; right: 0;
        }*/
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde582e3a7a7f3ce022c81910f5ce97730707c386029", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde582e3a7a7f3ce022c81910f5ce97730707c386287", async() => {
                    WriteLiteral("\r\n    <div class=\"main clearfix position-relative\">\r\n        <div class=\"work\">\r\n            <img");
                    BeginWriteAttribute("src", " src=", 686, "", 707, 1);
#nullable restore
#line 28 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
WriteAttributeValue("", 691, Model.Post.Path, 691, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"media\"");
                    BeginWriteAttribute("alt", " alt=\"", 721, "\"", 727, 0);
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n");
                    WriteLiteral(@"            <div class=""caption"">
                <div class=""work_title"">
                    <h1></h1>
                </div>
            </div>
        </div>
        <div class=""row-space"">
            <div class=""wrap-input100 position-relative"">
                <input type=""text"" size=""40"" name=""com"" />
                <input type=""hidden"" name=""pId""");
                    BeginWriteAttribute("value", " value=", 1171, "", 1192, 1);
#nullable restore
#line 39 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
WriteAttributeValue("", 1178, Model.Post.Id, 1178, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                <input type=\"submit\" icon=\"~/images/send.ico\" />\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
             if (Model.Comments.Count != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                 foreach (var x in Model.Comments)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div>\r\n                        <span>Comment : </span>\r\n                        <a>");
#nullable restore
#line 48 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                      Write(x.comment);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\r\n                    </div>\r\n");
#nullable restore
#line 50 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("        </div>\r\n    </div>\r\n");
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
                WriteLiteral("<!-- end main -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostCollector> Html { get; private set; }
    }
}
#pragma warning restore 1591
