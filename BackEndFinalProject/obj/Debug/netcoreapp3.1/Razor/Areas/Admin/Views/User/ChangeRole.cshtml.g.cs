#pragma checksum "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7f553554bd13f81e7d6093cde0507c5f7a1b8f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_ChangeRole), @"mvc.1.0.view", @"/Areas/Admin/Views/User/ChangeRole.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndFinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndFinalProject.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7f553554bd13f81e7d6093cde0507c5f7a1b8f8", @"/Areas/Admin/Views/User/ChangeRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac601a71bb7caec27c481c4a5d21715690b9fa9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_ChangeRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
  
    ViewData["Title"] = "ChangeRole";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-lg-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f553554bd13f81e7d6093cde0507c5f7a1b8f86324", async() => {
                WriteLiteral(@"
            <div class=""card-body"">
                <h4 class=""card-title"">Users</h4>
                <div class=""table-responsive"">
                    <table class=""table table-striped"">
                        <thead>
                            <tr>
                                <th> Name </th>
                                <th> Surname </th>
                                <th> Email </th>
                                <th> Role </th>
                                <th> IsDeleted </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td> ");
#nullable restore
#line 24 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                                Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 25 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                                Write(Model.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 26 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                                Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                <th> ");
#nullable restore
#line 27 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                                Write(Model.Role);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </th>\r\n");
#nullable restore
#line 28 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                                 if (Model.IsDeleted)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td style=\"color:red\">\r\n                                        Disabled\r\n                                    </td>\r\n");
#nullable restore
#line 33 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td style=\"color:forestgreen\">\r\n                                        Enabled\r\n                                    </td>\r\n");
#nullable restore
#line 39 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n");
#nullable restore
#line 45 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                     foreach (string role in Model.Roles)
                    {
                        if (Model.Role == role)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"mt-3 form-group\">\r\n                                <input type=\"radio\" name=\"role\" checked");
                BeginWriteAttribute("value", " value=\"", 2042, "\"", 2055, 1);
#nullable restore
#line 50 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
WriteAttributeValue("", 2050, role, 2050, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 50 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                                                                                    Write(role);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 52 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"mt-3 form-group\">\r\n                                <input type=\"radio\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 2309, "\"", 2322, 1);
#nullable restore
#line 56 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
WriteAttributeValue("", 2317, role, 2317, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> ");
#nullable restore
#line 56 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                                                                            Write(role);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 58 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"col-md-6\">\r\n");
#nullable restore
#line 63 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                     if (Model.Role == "CourseModerator")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <ul>\r\n\r\n                        </ul>\r\n");
#nullable restore
#line 68 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"mt-3\">\r\n                    <h4 class=\"text-danger\">Are you sure?</h4>\r\n");
#nullable restore
#line 72 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                     if (User.Identity.Name != Model.Username)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f553554bd13f81e7d6093cde0507c5f7a1b8f814371", async() => {
                    WriteLiteral("\r\n                            Change Role\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\HP\Desktop\Code Academy\BackEnd_Final_Project\BackEnd_Final_Project\BackEndFinalProject\Areas\Admin\Views\User\ChangeRole.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7f553554bd13f81e7d6093cde0507c5f7a1b8f817044", async() => {
                    WriteLiteral("Go Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
