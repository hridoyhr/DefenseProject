#pragma checksum "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\AdminDashboard\StudentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d02cde3a5100e017f1138dd12a47aaa079b2c35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminDashboard_StudentDetails), @"mvc.1.0.view", @"/Views/AdminDashboard/StudentDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d02cde3a5100e017f1138dd12a47aaa079b2c35", @"/Views/AdminDashboard/StudentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2faf5c0bd308aa5232ecf9d030224b1bf52b84e5", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminDashboard_StudentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserChangeMobile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""border-content "">
    <div class=""d-flex flex-column header-details"">
        <div class=""d-flex"">
            <div class=""d-flex pt-1 pl-2 pr-2 pb-2"">
                <img class=""img-thumbnail float-lg-left header-image p-0""
                     src=""/images/man.png""");
            BeginWriteAttribute("alt", " alt=\"", 310, "\"", 316, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"d-flex flex-column pt-1 pl-2 pr-2 pb-2 w-100\">\r\n                <h3 class=\"text-white-50\">\r\n                    ");
#nullable restore
#line 12 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\AdminDashboard\StudentDetails.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h3>
                <table class=""table table-sm table-hover table-borderless header-table table-css"">
                    <tbody>

                        <tr>
                            <td class=""text-darkgray"">Email Address:</td>
                            <td>
                                ");
#nullable restore
#line 20 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\AdminDashboard\StudentDetails.cshtml"
                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                        </tr>

                        <tr>
                            <td class=""text-darkgray"">Profile Type:</td>
                            <td>Applicant</td>
                        </tr>
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
                        ");
#nullable restore
#line 50 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\AdminDashboard\StudentDetails.cshtml"
                   Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d02cde3a5100e017f1138dd12a47aaa079b2c357902", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-edit ml-2 mr-1\"></i>Change\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        <table class=""table table-sm table-hover border table-css"">
            <thead>
                <tr>
                    <td>Total Amount</td>
                    <th>20000 tk</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 76 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\AdminDashboard\StudentDetails.cshtml"
                 foreach (var item in Model.FundDetails)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 79 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\AdminDashboard\StudentDetails.cshtml"
                       Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 80 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\AdminDashboard\StudentDetails.cshtml"
                       Write(item.Money);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 82 "G:\Final Project All Document\Final Year project\DefenseProject\DefenseFinalProject\FinalProject\Views\AdminDashboard\StudentDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"strip-gh mt-4\"></div>\r\n    <div class=\"strip-dh\"></div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
