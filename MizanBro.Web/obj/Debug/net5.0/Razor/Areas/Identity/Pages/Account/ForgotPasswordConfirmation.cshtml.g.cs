#pragma checksum "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9780b33404e9cfa26024690b8072e2a508824c09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
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
#line 2 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\_ViewImports.cshtml"
using MizanBro.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\_ViewImports.cshtml"
using MizanBro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\_ViewImports.cshtml"
using MizanBro.Application.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using MizanBro.Web.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using MizanBro.Web.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using MizanBro.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using MizanBro.Infrastructure.Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using MizanBro.Web.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9780b33404e9cfa26024690b8072e2a508824c09", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b52bbfb010ac35ab6bc1d470fd8dfb742e412b", @"/Areas/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33719e3b730d5d340ced843db454b0a4ecac95f2", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ceca66a86e042c2ca0e5a7f60df0d43fb35fce5", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>\r\n    Please check your email to reset your password.\r\n</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmation> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation>)PageContext?.ViewData;
        public ForgotPasswordConfirmation Model => ViewData.Model;
    }
}
#pragma warning restore 1591