#pragma checksum "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a654595f6f774cb8a9ae5680a6be3204fc10d991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_AuditLog), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AuditLog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a654595f6f774cb8a9ae5680a6be3204fc10d991", @"/Areas/Identity/Pages/Account/AuditLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b52bbfb010ac35ab6bc1d470fd8dfb742e412b", @"/Areas/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33719e3b730d5d340ced843db454b0a4ecac95f2", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ceca66a86e042c2ca0e5a7f60df0d43fb35fce5", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_AuditLog : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
  
    ViewData["Title"] = localizer["Audit Log"];
    ViewData["Caption"] = localizer["View your Recent 250 Logs here"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\r\n    <div id=\"viewAll\" class=\"card-body table-responsive\">\r\n        <table class=\"table table-striped\" id=\"logTable\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 14 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(localizer["Id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 17 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 20 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(localizer["Action"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(localizer["Module"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(localizer["Key"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(localizer["Affected Columns"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(localizer["Old Values"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 35 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(localizer["New Values"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                 foreach (var user in Model.AuditLogResponses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a>\r\n                            <small class=\"badge badge-warning\"><i class=\"far fa-clock\"></i> Universal</small> ");
#nullable restore
#line 48 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                                                                                                         Write(user.DateTime.ToString("dd/MM/yyyy h:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                        <br>\r\n                        <small>\r\n\r\n");
#nullable restore
#line 53 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                              
                                DateTime runtimeKnowsThisIsUtc = DateTime.SpecifyKind(user.DateTime, DateTimeKind.Utc);
                                DateTime localVersion = runtimeKnowsThisIsUtc.ToLocalTime();
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small class=\"badge badge-success\"><i class=\"far fa-clock\"></i> Local</small> ");
#nullable restore
#line 57 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                                                                                                     Write(localVersion.ToString("dd/MM/yyyy h:mm:ss tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </small>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(user.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(user.TableName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(user.PrimaryKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(user.AffectedColumns);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(user.OldValues);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                   Write(user.NewValues);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 79 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Identity\Pages\Account\AuditLog.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a654595f6f774cb8a9ae5680a6be3204fc10d99114016", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"#logTable\").DataTable({\r\n\r\n                \"order\": [[0, \"desc\"]]\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MizanBro.Web.Areas.Identity.Pages.Account.AuditLogModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MizanBro.Web.Areas.Identity.Pages.Account.AuditLogModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MizanBro.Web.Areas.Identity.Pages.Account.AuditLogModel>)PageContext?.ViewData;
        public MizanBro.Web.Areas.Identity.Pages.Account.AuditLogModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
