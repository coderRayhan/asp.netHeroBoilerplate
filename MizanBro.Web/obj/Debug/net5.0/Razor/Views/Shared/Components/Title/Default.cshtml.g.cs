#pragma checksum "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Views\Shared\Components\Title\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b7712f1daf03266f5a56d10dea998cfc94c0ea6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Title_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Title/Default.cshtml")]
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
#line 1 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Views\_ViewImports.cshtml"
using MizanBro.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Views\_ViewImports.cshtml"
using MizanBro.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Views\_ViewImports.cshtml"
using MizanBro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Views\_ViewImports.cshtml"
using MizanBro.Infrastructure.Identity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b7712f1daf03266f5a56d10dea998cfc94c0ea6", @"/Views/Shared/Components/Title/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf75121ac9c7442550e8934cf747d871fbe880f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Title_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"d-sm-flex align-items-center justify-content-between\">\r\n    <h1 class=\"h3 mb-0 text-gray-800\">");
#nullable restore
#line 2 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Views\Shared\Components\Title\Default.cshtml"
                                 Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<p></p>\r\n<h6>");
#nullable restore
#line 5 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Views\Shared\Components\Title\Default.cshtml"
Write(ViewBag.Caption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<p></p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; } = default!;
        #nullable disable
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
