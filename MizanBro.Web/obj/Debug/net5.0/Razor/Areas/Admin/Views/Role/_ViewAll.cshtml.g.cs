#pragma checksum "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11a10139392860e55da71985e972371f2ef94122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role__ViewAll), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/_ViewAll.cshtml")]
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
#line 1 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
using MizanBro.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11a10139392860e55da71985e972371f2ef94122", @"/Areas/Admin/Views/Role/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b52bbfb010ac35ab6bc1d470fd8dfb742e412b", @"/Areas/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Role__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoleViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OnPostDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryModalDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:16px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Permission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-striped\" id=\"roleTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
           Write(localizer["Role"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
           Write(localizer["Id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th style=\"width:10%\">\r\n                ");
#nullable restore
#line 14 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
           Write(localizer["Actions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
         foreach (var role in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
               Write(role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
               Write(role.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
                <td text-right"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Action
                        </button>
                        <div class=""dropdown-menu shadow animated--grow-in"">
                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1069, "\"", 1144, 4);
            WriteAttributeValue("", 1079, "jQueryModalGet(\'/admin/role/OnGetCreate?id=", 1079, 43, true);
#nullable restore
#line 35 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
WriteAttributeValue("", 1122, role.Id, 1122, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1130, "\',\'Edit", 1130, 7, true);
            WriteAttributeValue(" ", 1137, "Role\')", 1138, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\">\r\n                                <i class=\"fas fa-pencil-alt\"></i> ");
#nullable restore
#line 36 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
                                                             Write(localizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11a10139392860e55da71985e972371f2ef9412211107", async() => {
                WriteLiteral("\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1531, "\"", 1585, 3);
                WriteAttributeValue("", 1538, "javascript:$(\'#form_delete_", 1538, 27, true);
#nullable restore
#line 39 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
WriteAttributeValue("", 1565, role.Id, 1565, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1573, "\').submit();", 1573, 12, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"dropdown-item\"><i class=\"fas fa-trash-alt\"></i> ");
#nullable restore
#line 39 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
                                                                                                                                            Write(localizer["Delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1328, "form_delete_", 1328, 12, true);
#nullable restore
#line 38 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
AddHtmlAttributeValue("", 1340, role.Id, 1340, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
                                                                                                                            WriteLiteral(role.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
#line 41 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
                             if (role.Name != "SuperAdmin")
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11a10139392860e55da71985e972371f2ef9412216136", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-wrench\"></i> ");
#nullable restore
#line 45 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
                                                             Write(localizer["Manage Permissions"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
                                                                                                                  WriteLiteral(role.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\ADDIE Soft Ltd\Desktop\MizanBro\MizanBro.Web\Areas\Admin\Views\Role\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#roleTable\").DataTable();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoleViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
