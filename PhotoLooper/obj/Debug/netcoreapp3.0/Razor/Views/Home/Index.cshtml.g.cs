#pragma checksum "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22e52fc6a103f85cf94e1f3d8b7f18d526efe24b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e52fc6a103f85cf94e1f3d8b7f18d526efe24b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac8af34965a0a1dcb91b06b2a2e1ca6c68d24af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserCollector>
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
#line 1 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<section class=\"main clearfix\">\r\n");
#nullable restore
#line 9 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Index.cshtml"
     if (Model.Posts.Count != 0) { 
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Index.cshtml"
         foreach (var x in Model.Posts)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"work\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22e52fc6a103f85cf94e1f3d8b7f18d526efe24b3880", async() => {
                WriteLiteral("\r\n                    <img");
                BeginWriteAttribute("src", " src=", 336, "", 353, 1);
#nullable restore
#line 14 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Index.cshtml"
WriteAttributeValue("", 341, x.Post.Path, 341, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"media\" width=\"400\" height=\"450\"");
                BeginWriteAttribute("alt", " alt=\"", 392, "\"", 398, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"caption\">\r\n                        <div class=\"work_title\">\r\n                            <h1>");
#nullable restore
#line 17 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Index.cshtml"
                           Write(x.Post.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 276, "~/Home/Photo?selected=", 276, 22, true);
#nullable restore
#line 13 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 298, x.Post.Id, 298, 10, false);

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
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Index.cshtml"
          
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserCollector> Html { get; private set; }
    }
}
#pragma warning restore 1591
