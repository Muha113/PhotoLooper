#pragma checksum "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Tape.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c890f1980cad9fbff979695cda0a002212beaab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tape), @"mvc.1.0.view", @"/Views/Home/Tape.cshtml")]
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
#line 2 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\_ViewImports.cshtml"
using PhotoLooper.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Tape.cshtml"
using PhotoLooper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c890f1980cad9fbff979695cda0a002212beaab5", @"/Views/Home/Tape.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac8af34965a0a1dcb91b06b2a2e1ca6c68d24af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tape : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PostCollector>>
    {
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
#line 2 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Tape.cshtml"
  
    ViewData["Title"] = "Tape";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<section class=\"main clearfix\">\r\n");
#nullable restore
#line 10 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Tape.cshtml"
     if (Model.Count() != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row-space\">\r\n");
#nullable restore
#line 13 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Tape.cshtml"
             foreach (var x in Model)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-2\">\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c890f1980cad9fbff979695cda0a002212beaab53984", async() => {
                WriteLiteral("\r\n                            <img");
                BeginWriteAttribute("src", " src=", 451, "", 468, 1);
#nullable restore
#line 18 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Tape.cshtml"
WriteAttributeValue("", 456, x.Post.Path, 456, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"300\" height=\"350\" class=\"media\"");
                BeginWriteAttribute("alt", " alt=\"", 507, "\"", 513, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 383, "~/Home/Photo?selected=", 383, 22, true);
#nullable restore
#line 17 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Tape.cshtml"
AddHtmlAttributeValue("", 405, x.Post.Id, 405, 10, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"row-space\">\r\n                        <lable>");
#nullable restore
#line 22 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Tape.cshtml"
                          Write(x.Post.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</lable>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Tape.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 27 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Tape.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section><!-- end main -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PostCollector>> Html { get; private set; }
    }
}
#pragma warning restore 1591
