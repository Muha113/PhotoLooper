#pragma checksum "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef5a9a2e03f8364d57a988c8ee59487c1ebc481c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef5a9a2e03f8364d57a988c8ee59487c1ebc481c", @"/Views/Home/Photo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac8af34965a0a1dcb91b06b2a2e1ca6c68d24af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Photo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostCollector>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetUserAvatar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
  
    ViewData["Title"] = "Photo";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5a9a2e03f8364d57a988c8ee59487c1ebc481c5236", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta id=""viewport"" name=""viewport"" content=""width=320; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;"" />
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
        box-shadow: 2px -2px 5px 0 rgba(0,0,0,.1),
        -2px -2px 5px 0 rgba(0,0,0,.1),
        2px 2px 5px 0 rgba(0,0,0,.1),
        -2px 2px 5px 0 rgba(0,0,0,.1);
        font-size: 20px;
        letter-spacing: 2px;
        transition: 0.3s all linear;
        }
        .border li:nth-child(2){border-color: #8bc63e;}
        .border li:nth-child(3){border-color: #fcba30;}
        .border li:nth-child(4){border-color: #1ccfc9;}
        .border li:nth-child(5){border-color: #493224;}
        .border li:hover {border-left: 10px solid transparent;}
       ");
                WriteLiteral(@" .border li:nth-child(1):hover {border-right: 10px solid #f05d22;}
        .border li:nth-child(2):hover {border-right: 10px solid #8bc63e;}
        .border li:nth-child(3):hover {border-right: 10px solid #fcba30;}
        .border li:nth-child(4):hover {border-right: 10px solid #1ccfc9;}
        .border li:nth-child(5):hover {border-right: 10px solid #493224;}
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5a9a2e03f8364d57a988c8ee59487c1ebc481c7657", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    <div class=\"main clearfix position-relative\">\r\n        <div class=\"work\">\r\n            <img");
                BeginWriteAttribute("src", " src=", 1721, "", 1742, 1);
#nullable restore
#line 49 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
WriteAttributeValue("", 1726, Model.Post.Path, 1726, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"media\"");
                BeginWriteAttribute("alt", " alt=\"", 1756, "\"", 1762, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("            <div class=\"caption\">\r\n                <div class=\"work_title\">\r\n                    <h1></h1>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 57 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
         if(StaticUser.GetUserId(User.Identity.Name) == ViewBag.context.GetUserCollector(Model.Post.UserId).User.UserId)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5a9a2e03f8364d57a988c8ee59487c1ebc481c9151", async() => {
                    WriteLiteral("\r\n                <input type=\"hidden\" name=\"path\"");
                    BeginWriteAttribute("value", " value=", 2271, "", 2294, 1);
#nullable restore
#line 60 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
WriteAttributeValue("", 2278, Model.Post.Path, 2278, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n                <input type=\"hidden\" name=\"postId\"");
                    BeginWriteAttribute("value", " value=\"", 2348, "\"", 2370, 1);
#nullable restore
#line 61 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
WriteAttributeValue("", 2356, Model.Post.Id, 2356, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n                <input type=\"submit\" value=\"Set as avatar\"/>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
#line 64 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"col-md-2\">\r\n            <span>Posted By: </span>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 2553, "\"", 2595, 2);
                WriteAttributeValue("", 2560, "/Home/Profile?id=", 2560, 17, true);
#nullable restore
#line 67 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
WriteAttributeValue("", 2577, Model.Post.UserId, 2577, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 67 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                                                     Write(ViewBag.context.GetUserCollector(Model.Post.UserId).User.NickName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n        </div>\r\n        <div class=\"row-space\">\r\n                <div class=\"wrap-input100 position-relative\">\r\n                    <input type=\"text\" size=\"40\" name=\"com\" id=\"message\" />\r\n                    <input type=\"hidden\" name=\"pId\"");
                BeginWriteAttribute("value", " value=", 2909, "", 2930, 1);
#nullable restore
#line 72 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
WriteAttributeValue("", 2916, Model.Post.Id, 2916, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" id=\"sendBtn\" />\r\n                </div>\r\n");
#nullable restore
#line 75 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
             if (Model.Comments.Count != 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <ul class=\"border\">\r\n");
#nullable restore
#line 78 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                     foreach (var x in Model.Comments)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n                            <div id=\"results\" class=\"row-space\">\r\n                                <div>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5a9a2e03f8364d57a988c8ee59487c1ebc481c14565", async() => {
#nullable restore
#line 82 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                                                                      Write(ViewBag.context.GetUserCollector(x.UserId).User.NickName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" : ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3335, "~/Home/Profile?id=", 3335, 18, true);
#nullable restore
#line 82 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
AddHtmlAttributeValue("", 3353, x.UserId, 3353, 9, false);

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
                WriteLiteral("</div>\r\n                                <div><a>");
#nullable restore
#line 83 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                                   Write(x.comment);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></div>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 86 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n");
#nullable restore
#line 88 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <ul class=\"border\" id=\"commentPost\">\r\n            </ul>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5a9a2e03f8364d57a988c8ee59487c1ebc481c17365", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <script>
                const hubConnection = new signalR.HubConnectionBuilder()
                    .withUrl(""/HuHub"")
                    .configureLogging(signalR.LogLevel.Information)
                    .build();

                hubConnection.on(""Send"", function (data, nick, id) {

                    //alert(nick, id);
                    let element = document.createElement(""li"");
                    element.innerHTML = `
                                <div id=""results"" class=""row-space"">
                                    <div><a href=""~/Home/Profile?id=${id}"">${nick} : </a></div>
                                    <div><a>${data}</a></div>
                                </div>`;
                    let firstElem = document.getElementById(""commentPost"").firstElem;
                    document.getElementById(""commentPost"").appendChild(element, firstElem);
                });

                hubConnection.on(""Receive"", function (data, nick, id) {

              ");
                WriteLiteral(@"      //alert(nick, id);
                    let element = document.createElement(""li"");
                    element.innerHTML = `
                                <div id=""results"" class=""row-space"">
                                    <div><a href=""~/Home/Profile?id=${id}"">${nick} : </a></div>
                                    <div><a>${data}</a></div>
                                </div>`;
                    let firstElem = document.getElementById(""commentPost"");
                    document.getElementById(""commentPost"").appendChild(element, firstElem);
                });

                document.getElementById(""sendBtn"").addEventListener(""click"", function (e) {
                    //alert(""djsabkjdba"");
                    
                    let message = document.getElementById(""message"").value;
                    hubConnection.invoke(""Send"", """);
#nullable restore
#line 128 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                                             Write(Model.Post.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", message, \"");
#nullable restore
#line 128 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                                                                        Write(ViewBag.context.GetUserCollector(StaticUser.GetUserId(User.Identity.Name)).User.NickName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", ");
#nullable restore
#line 128 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                                                                                                                                                                    Write(StaticUser.GetUserId(User.Identity.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n                    $.ajax({\r\n                        url:\'");
#nullable restore
#line 130 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                        Write(Url.Action("TypeComment"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                        type: \"POST\",\r\n                        data: { com: message, pId: ");
#nullable restore
#line 132 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                                              Write(Model.Post.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" },\r\n                        dataType: \"text\"\r\n                    });\r\n                });\r\n\r\n                hubConnection.start().then(() => {\r\n                    hubConnection.invoke(\"JoinGroup\", \"");
#nullable restore
#line 138 "C:\Users\danii\source\repos\PhotoLooper\PhotoLooper\Views\Home\Photo.cshtml"
                                                  Write(Model.Post.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\").catch(err => console.error(err.toString()));\r\n                });\r\n            </script>\r\n");
                WriteLiteral("        </div>\r\n    </div>\r\n");
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
