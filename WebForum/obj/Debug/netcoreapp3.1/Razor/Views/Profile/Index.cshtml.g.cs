#pragma checksum "D:\Repos\WebForum\WebForum\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63ab4f2d67862b0a216222f4da792fab0bd70074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63ab4f2d67862b0a216222f4da792fab0bd70074", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b71a28f3a7af09787c62261f1cdb0b8d415dc6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebForum.Models.Profile.ProfileListingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <h4>Users</h4>
    </div>
    <div class=""row"">
        <table class=""table table-hover"" id=""userIndexTable"">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>Username</th>
                    <th>Email</th>
                    <th>Member Since</th>
                    <th>Rating</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 19 "D:\Repos\WebForum\WebForum\Views\Profile\Index.cshtml"
                 foreach (var profile in Model.Profiles)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <div class=\"userImage\"");
            BeginWriteAttribute("style", " style=\"", 707, "\"", 762, 4);
            WriteAttributeValue("", 715, "background-image:", 715, 17, true);
            WriteAttributeValue(" ", 732, "url(", 733, 5, true);
#nullable restore
#line 23 "D:\Repos\WebForum\WebForum\Views\Profile\Index.cshtml"
WriteAttributeValue("", 737, profile.ProfileImageUrl, 737, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 761, ")", 761, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 25 "D:\Repos\WebForum\WebForum\Views\Profile\Index.cshtml"
                       Write(profile.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "D:\Repos\WebForum\WebForum\Views\Profile\Index.cshtml"
                       Write(profile.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "D:\Repos\WebForum\WebForum\Views\Profile\Index.cshtml"
                       Write(profile.MemberSince);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\Repos\WebForum\WebForum\Views\Profile\Index.cshtml"
                       Write(profile.UserRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 30 "D:\Repos\WebForum\WebForum\Views\Profile\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebForum.Models.Profile.ProfileListingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
