#pragma checksum "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "269a70361e8cf002a8d1fdb29469dd041d0a2187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FeedbackPosts_Index), @"mvc.1.0.view", @"/Views/FeedbackPosts/Index.cshtml")]
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
#line 1 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\_ViewImports.cshtml"
using industry4._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\_ViewImports.cshtml"
using industry4._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"269a70361e8cf002a8d1fdb29469dd041d0a2187", @"/Views/FeedbackPosts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"762e9ff6291775e2c07b0a2843519391395e07e4", @"/Views/_ViewImports.cshtml")]
    public class Views_FeedbackPosts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<industry4._0.Models.FeedbackPost>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
     if (User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container-fluid p-1\" style=\"margin-bottom:35%;\">\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "269a70361e8cf002a8d1fdb29469dd041d0a21875700", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 19 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 22 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 25 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.HEading));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 28 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.StarRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 31 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Feedback));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 34 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Agree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 37 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Disagree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 40 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.CompanyOrganisationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 43 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.canIncreaseAgree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 46 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.canIncreaseDisagree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 62 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.HEading));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 65 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.StarRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 68 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Feedback));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 71 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Agree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 74 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Disagree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 77 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CompanyOrganisationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 80 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.canIncreaseAgree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 83 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.canIncreaseDisagree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "269a70361e8cf002a8d1fdb29469dd041d0a218717043", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "269a70361e8cf002a8d1fdb29469dd041d0a218719343", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                                                       WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "269a70361e8cf002a8d1fdb29469dd041d0a218721637", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 91 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 95 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"margin:20%;\">\r\n            <h3 style=\"text-align:center\">Access Denied!</h3>\r\n        </div>\r\n");
#nullable restore
#line 101 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
 if (!User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"margin:20%;\">\r\n        <h3 style=\"text-align:center\">Access Denied!</h3>\r\n    </div>\r\n");
#nullable restore
#line 108 "C:\Users\Ali\Documents\Assessments\Bachelor of Software Engineering\Second Year\Semester 2\Web designing and Programming\industry4.0\industry4.0\Views\FeedbackPosts\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<industry4._0.Models.FeedbackPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
