#pragma checksum "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9209fe91f62aba497aa64ddf211ccdae40abc466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Catalog_Views_Brand__ViewAll), @"mvc.1.0.view", @"/Areas/Catalog/Views/Brand/_ViewAll.cshtml")]
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
#line 1 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\_ViewImports.cshtml"
using MizanBro.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\_ViewImports.cshtml"
using MizanBro.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

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
#line 1 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
using MizanBro.Web.Areas.Catalog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9209fe91f62aba497aa64ddf211ccdae40abc466", @"/Areas/Catalog/Views/Brand/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b52bbfb010ac35ab6bc1d470fd8dfb742e412b", @"/Areas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Catalog_Views_Brand__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BrandViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Brand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OnPostDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryModalDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<table id=\"brandTable\" class=\"table table-striped\" width=\"100%\" cellspacing=\"0\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Name</th>\r\n            <th>Tax</th>\r\n            <th>Description</th>\r\n");
#nullable restore
#line 10 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
             if ((AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Delete)).Result.Succeeded
             || (AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Edit)).Result.Succeeded)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>Actions</th>\r\n");
#nullable restore
#line 14 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
         foreach (var brand in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 23 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
           Write(brand.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
           Write(brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
           Write(brand.Tax);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
           Write(brand.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 34 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
             if ((AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Delete)).Result.Succeeded || (AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Edit)).Result.Succeeded)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <td text-right"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Action
                        </button>
                        <div class=""dropdown-menu shadow animated--grow-in"">
");
#nullable restore
#line 42 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
                             if ((AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Edit)).Result.Succeeded)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1728, "\"", 1814, 4);
            WriteAttributeValue("", 1738, "jQueryModalGet(\'/catalog/brand/OnGetCreateOrEdit?id=", 1738, 52, true);
#nullable restore
#line 44 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
WriteAttributeValue("", 1790, brand.Id, 1790, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1799, "\',\'Edit", 1799, 7, true);
            WriteAttributeValue(" ", 1806, "Brand\')", 1807, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\"><i class=\"fas fa-pencil-alt\"></i>  Edit</a>\r\n");
#nullable restore
#line 45 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
                             if ((AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Delete)).Result.Succeeded)

                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9209fe91f62aba497aa64ddf211ccdae40abc46611145", async() => {
                WriteLiteral("\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 2326, "\"", 2381, 3);
                WriteAttributeValue("", 2333, "javascript:$(\'#form_delete_", 2333, 27, true);
#nullable restore
#line 51 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
WriteAttributeValue("", 2360, brand.Id, 2360, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2369, "\').submit();", 2369, 12, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"dropdown-item\"><i class=\"fas fa-trash-alt\"></i>  Delete</a>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2114, "form_delete_", 2114, 12, true);
#nullable restore
#line 50 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
AddHtmlAttributeValue("", 2126, brand.Id, 2126, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
                                                                                                                                                     WriteLiteral(brand.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 53 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </td>\r\n");
#nullable restore
#line 57 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#brandTable\").DataTable();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BrandViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
