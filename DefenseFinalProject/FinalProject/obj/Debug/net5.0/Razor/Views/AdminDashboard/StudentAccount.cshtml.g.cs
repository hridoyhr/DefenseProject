#pragma checksum "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\AdminDashboard\StudentAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb63a219305bc60b7ccec39f7d2bf9e2f1fbf0a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminDashboard_StudentAccount), @"mvc.1.0.view", @"/Views/AdminDashboard/StudentAccount.cshtml")]
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
#line 1 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models.UserAccount.Scholarship;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models.UserDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models.UserAccount.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models.AdminAccount;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Web.Models.AdminDashboard;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb63a219305bc60b7ccec39f7d2bf9e2f1fbf0a3", @"/Views/AdminDashboard/StudentAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2faf5c0bd308aa5232ecf9d030224b1bf52b84e5", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminDashboard_StudentAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentAccountModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProfileDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminDashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeMobileNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\AdminDashboard\StudentAccount.cshtml"
  
    ViewBag.Title = "Student Account Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"body-bg-green register-form-div\">\r\n");
            WriteLiteral(@"    <header>

        <nav class=""navbar navbar-expand-xl navbar-dark bg-dark fixed-top  py-0"">
            <div class=""d-flex justify-content-between mx-2 w-100"">

                <div class=""d-flex justify-content-start mx-2"">
                    <a class=""navbar-brand navbar-text"" href=""/"">
                        <img src=""/images/body.png"" height=""30"" width=""auto"" class=""visible-lg-inline-block mr-1""");
            BeginWriteAttribute("alt", " alt=\"", 577, "\"", 583, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span style=""vertical-align: middle"">Scholarship Monitoring System</span>
                    </a>
                </div>

                <div class=""d-flex justify-content-end mx-2"">

                    <button type=""button"" class=""navbar-toggler"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>

                    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                        <ul class=""navbar-nav"">

                            <li class=""nav-item mr-3"">
                                <h5>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb63a219305bc60b7ccec39f7d2bf9e2f1fbf0a39543", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-user mr-1\"></i>Admin\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </h5>\r\n                            </li>\r\n\r\n                            <li class=\"nav-item mx-1\">\r\n                                <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb63a219305bc60b7ccec39f7d2bf9e2f1fbf0a311282", async() => {
                WriteLiteral("LOGOUT<i class=\"fas fa-sign-out-alt ml-1\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div id=""site-wrapper"" class=""d-flex flex-column justify-content-center container "">

        <div id=""breadbrumbs"" class=""d-flex justify-content-start container mt-4 mb-2 w-80"" aria-label=""breadcrumbs"">
            <div class=""btn-group container p-0"" role=""group"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb63a219305bc60b7ccec39f7d2bf9e2f1fbf0a313329", async() => {
                WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-sm btn-dark btn-arrow-right text-white\">HOME</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb63a219305bc60b7ccec39f7d2bf9e2f1fbf0a314843", async() => {
                WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-sm btn-arrow-right btn-success text-white\">STUDENT\'S ACCOUNT</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </div>
        </div>

        <div class=""d-flex flex-column justify-content-center container w-80"">
            <div class=""border-content "">

                <div class=""d-flex flex-column header-details"">
                    <div class=""d-flex"">
                        <div class=""d-flex pt-1 pl-2 pr-2 pb-2"">
                            <img class=""img-thumbnail float-lg-left header-image p-0""
                                 src=""/images/man.png""");
            BeginWriteAttribute("alt", " alt=\"", 3347, "\"", 3353, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""d-flex flex-column pt-1 pl-2 pr-2 pb-2 w-100"">
                            <h3 class=""text-white-50"">
                                Mahmudul Hasan Hridoy
                                (<a href=""/app/profile/2181""># 2181</a>)
                            </h3>
                            <table class=""table table-sm table-hover table-borderless header-table table-css"">
                                <tbody>

                                    <tr>
                                        <td class=""text-darkgray"">Email Address:</td>
                                        <td>
                                            mahmudul35-205@diu.edu.bd
                                        </td>
                                    </tr>

                                    <tr>
                                        <td class=""text-darkgray"">Profile Type:</td>
                                        <td>Applicant</td>
    ");
            WriteLiteral(@"                                </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                    <div class=""strip-gh""></div>
                </div>

                <div class=""d-flex flex-column pt-4 pl-4 pr-4"">
                    <div class=""d-flex justify-content-between"">
                        <h4 class=""text-greenpigment font-weight-bold"">
                            <i class=""fas fa-user-shield mr-2""></i>Personal
                            Details
                        </h4>

                    </div>
                    <table class=""table table-sm table-hover border table-css"">
                        <tbody>

                            <tr>
                                <td>Mobile Phone #:</td>
                                <th>
                                    01872944289 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb63a219305bc60b7ccec39f7d2bf9e2f1fbf0a318995", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-edit ml-2 mr-1\"></i>Change\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </th>
                            </tr>

                        </tbody>
                    </table>
                </div>

                <div class=""d-flex flex-column pt-4 pl-4 pr-4"">
                    <div class=""d-flex justify-content-between"">

                        <h4 class=""text-greenpigment font-weight-bold"">
                            <i class=""fas fa-user-secret mr-2""></i>Scholarship Fund Details
                        </h4>
                    </div>
                    <br />

                </div>

                <table class=""table table-sm table-hover border table-css"">
                    <tr>
                        <td>Total Amount</td>
                        <th>
                        <th>20000 tk</th>
                        </th>
                    </tr>
                </table>

                <table class=""table table-sm table-hover border table-css"">
                    <thead></thead>

                 ");
            WriteLiteral(@"   <tbody>

                        <tr>
                            <td>Educational Purpose</td>
                            <th>
                                10000 tk
                            </th>

                        </tr>
                        <tr>

                            <td>Health Purpose</td>
                            <th>
                                4000 tk
                            </th>
                        </tr>

                        <tr>
                            <td>Books</td>
                            <th>
                                2000 tk
                            </th>
                        </tr>
                        <tr>
                            <td>Food</td>
                            <th>
                                4000 tk
                            </th>
                        </tr>
                </table>
            </div>

            <div class=""strip-gh mt-4""></div>
            <div class=""st");
            WriteLiteral("rip-dh\"></div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentAccountModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
