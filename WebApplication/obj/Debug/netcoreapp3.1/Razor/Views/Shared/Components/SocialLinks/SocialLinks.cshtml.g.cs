#pragma checksum "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Shared\Components\SocialLinks\SocialLinks.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3d550073ba8981e93c02e7ac5211a09e65a7c3b5bc93554bbfa6063131df8a7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SocialLinks_SocialLinks), @"mvc.1.0.view", @"/Views/Shared/Components/SocialLinks/SocialLinks.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
using WebApplication.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3d550073ba8981e93c02e7ac5211a09e65a7c3b5bc93554bbfa6063131df8a7d", @"/Views/Shared/Components/SocialLinks/SocialLinks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"826d6d67bfb07340f826fdcd9b017420c34238301f9f067fcbd1af62ab9f1b31", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SocialLinks_SocialLinks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"nk-social-links\">\r\n");
#nullable restore
#line 3 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
     foreach (Option oneOption in Model as List<Option>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a class=\"nk-social-rss\"");
            BeginWriteAttribute("href", " href=\"", 177, "\"", 198, 1);
#nullable restore
#line 6 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
WriteAttributeValue("", 184, oneOption.Key, 184, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 7 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
           Write(Html.Raw(@oneOption.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 10 "C:\Users\landi\OneDrive\Робочий стіл\WebApplication\Views\Shared\Components\SocialLinks\SocialLinks.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
