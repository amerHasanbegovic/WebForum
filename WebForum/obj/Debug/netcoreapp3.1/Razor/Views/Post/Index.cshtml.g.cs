#pragma checksum "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4eac4f80497f1a1522520388f508e8c2b7955c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
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
#line 1 "D:\Repos\WebForum\WebForum\Views\_ViewImports.cshtml"
using WebForum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos\WebForum\WebForum\Views\_ViewImports.cshtml"
using WebForum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4eac4f80497f1a1522520388f508e8c2b7955c1", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b71a28f3a7af09787c62261f1cdb0b8d415dc6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebForum.Models.Post.PostIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4eac4f80497f1a1522520388f508e8c2b7955c15555", async() => {
                WriteLiteral("Back to ");
#nullable restore
#line 3 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                                                                        Write(Model.ForumName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 3 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                                         WriteLiteral(Model.ForumId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n<hr class=\"pb-3\" />\r\n<div class=\"d-flex postBg\">\r\n    <div class=\"col-md-2\">\r\n        <div class=\"authorImagePost mx-auto\"");
            BeginWriteAttribute("style", " style=\"", 322, "\"", 375, 4);
            WriteAttributeValue("", 330, "background-image:", 330, 17, true);
            WriteAttributeValue(" ", 347, "url(", 348, 5, true);
#nullable restore
#line 7 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
WriteAttributeValue("", 352, Model.AuthorImageUrl, 352, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 373, ");", 373, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div class=\"text-center\">\r\n            <small>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4eac4f80497f1a1522520388f508e8c2b7955c19057", async() => {
#nullable restore
#line 9 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                                             Write(Model.AuthorName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                     WriteLiteral(Model.AuthorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" (");
#nullable restore
#line 9 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                                                                    Write(Model.AuthorRating);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</small>\r\n");
#nullable restore
#line 10 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
             if (@Model.IsAuthorAdmin)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"small\">Admin</span>\r\n");
#nullable restore
#line 13 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div style=\"border-left: 1px solid black;\" class=\"col-md-10\">\r\n        <h4 class=\"text-danger\">");
#nullable restore
#line 17 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p style=\"font-family: \'Roboto\', serif\" class=\"pt-3 pb-1 border-bottom\">");
#nullable restore
#line 18 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                           Write(Model.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><small>");
#nullable restore
#line 19 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
             Write(Model.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n    </div>\r\n    <div></div>\r\n</div>\r\n\r\n");
#nullable restore
#line 24 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
 if (Model.Replies.Any())
{
    foreach (var reply in Model.Replies)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex mt-3 bg-light\">\r\n            <div class=\"col-md-2 border-right\">\r\n                <div class=\"authorImagePost mx-auto\"");
            BeginWriteAttribute("style", " style=\"", 1250, "\"", 1303, 4);
            WriteAttributeValue("", 1258, "background-image:", 1258, 17, true);
            WriteAttributeValue(" ", 1275, "url(", 1276, 5, true);
#nullable restore
#line 30 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
WriteAttributeValue("", 1280, reply.AuthorImageUrl, 1280, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1301, ");", 1301, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div>\r\n                    <p class=\"text-center\"><small>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4eac4f80497f1a1522520388f508e8c2b7955c114437", async() => {
#nullable restore
#line 32 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                                                                            Write(reply.AuthorName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                                                    WriteLiteral(reply.AuthorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" (");
#nullable restore
#line 32 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                                                                                                   Write(reply.AuthorRating);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</small></p>\r\n                </div>\r\n");
#nullable restore
#line 34 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                 if (reply.IsAuthorAdmin)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"small\">\r\n                        Admin\r\n                    </div>\r\n");
#nullable restore
#line 39 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div sstyle=\"border-left: 1px solid black;\" class=\"col-md-10\">\r\n                <p style=\"font-family: \'Roboto\', serif\" class=\"pt-3 pb-1 border-bottom\">");
#nullable restore
#line 42 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                                   Write(reply.ReplyContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><small>");
#nullable restore
#line 43 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                     Write(reply.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 46 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-flex\">\r\n        <div class=\"col-md-2\"></div>\r\n        <div class=\"col-md-10\">\r\n            <small>There are no replies to this post</small>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 56 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-flex pt-3\">\r\n        <div class=\"col-md-2\">\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4eac4f80497f1a1522520388f508e8c2b7955c119605", async() => {
                WriteLiteral("Reply");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 66 "D:\Repos\WebForum\WebForum\Views\Post\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebForum.Models.Post.PostIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
