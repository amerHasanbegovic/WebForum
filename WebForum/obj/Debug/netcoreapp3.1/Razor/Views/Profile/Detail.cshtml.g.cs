#pragma checksum "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3ca82b1c73f46d2a733443ba7ce16148681c68f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Detail), @"mvc.1.0.view", @"/Views/Profile/Detail.cshtml")]
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
#nullable restore
#line 1 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ca82b1c73f46d2a733443ba7ce16148681c68f", @"/Views/Profile/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b71a28f3a7af09787c62261f1cdb0b8d415dc6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebForum.Models.Profile.ProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadProfileImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div>\r\n            <h3>");
#nullable restore
#line 8 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
           Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Profile</h3>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2 col-12 pl-0\">\r\n            <div class=\"profileImage\"");
            BeginWriteAttribute("style", " style=\"", 399, "\"", 453, 4);
            WriteAttributeValue("", 407, "background-image:", 407, 17, true);
            WriteAttributeValue(" ", 424, "url(", 425, 5, true);
#nullable restore
#line 13 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
WriteAttributeValue("", 429, Model.ProfileImageUrl, 429, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 451, ");", 451, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 14 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
             if (User.Identity.Name == Model.Username)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3ca82b1c73f46d2a733443ba7ce16148681c68f6242", async() => {
                WriteLiteral(@"
                    <div id=""upload"" class=""mt-2"">
                        <label class=""btn btn-primary btn-file m-0 btn-sm"">
                            Browse <input type=""file"" name=""file"" style=""display: none;"" />
                        </label>
                        <button type=""submit"" class=""btn btn-primary btn-sm float-right"">Submit</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-10 col-12 userProfileInfo\">\r\n");
#nullable restore
#line 27 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
             if (@Model.IsAdmin)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-danger\">Admin</p>\r\n");
#nullable restore
#line 30 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Username: <span class=\"text-danger\">");
#nullable restore
#line 31 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
                                              Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n            <p>Current rating: <span class=\"text-danger\">");
#nullable restore
#line 32 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
                                                    Write(Model.UserRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n            <p>Email address: <span class=\"text-danger\">");
#nullable restore
#line 33 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
                                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n            <p>Member since: <span class=\"text-danger\">");
#nullable restore
#line 34 "D:\Repos\WebForum\WebForum\Views\Profile\Detail.cshtml"
                                                  Write(Model.MemberSince);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<WebForum.Data.Models.ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebForum.Models.Profile.ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
