#pragma checksum "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5de530c17a66a81bb0ef6eb010e6ecc25f9adbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ClubDetailsPage), @"mvc.1.0.view", @"/Views/Home/ClubDetailsPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ClubDetailsPage.cshtml", typeof(AspNetCore.Views_Home_ClubDetailsPage))]
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
#line 1 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\_ViewImports.cshtml"
using Julio_C_301016383.Components;

#line default
#line hidden
#line 2 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\_ViewImports.cshtml"
using Julio_C_301016383.Models;

#line default
#line hidden
#line 3 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\_ViewImports.cshtml"
using Julio_C_301016383.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\_ViewImports.cshtml"
using Julio_C_301016383.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5de530c17a66a81bb0ef6eb010e6ecc25f9adbf", @"/Views/Home/ClubDetailsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e419a222b9f40a865d0784f1984a0e175d14e5e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ClubDetailsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Club>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManagePlayersPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml"
  
    ViewData["Title"] = "ClubDetailsPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(128, 92, true);
            WriteLiteral("\r\n<h1>Club Details Page</h1>\r\n<div id=\"container\">\r\n    <div id=\"conteiner\" class=\"lists\">\r\n");
            EndContext();
#line 12 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml"
         foreach (Club clubTemp in Model)
        {

#line default
#line hidden
            BeginContext(274, 82, true);
            WriteLiteral("            <table>\r\n                <tr><th align=\"left\"><b>Club ID:</b></th><td>");
            EndContext();
            BeginContext(357, 15, false);
#line 15 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml"
                                                        Write(clubTemp.ClubID);

#line default
#line hidden
            EndContext();
            BeginContext(372, 70, true);
            WriteLiteral("</td></tr>\r\n                <tr><th align=\"left\"><b>Name:</b></th><td>");
            EndContext();
            BeginContext(443, 13, false);
#line 16 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml"
                                                     Write(clubTemp.Name);

#line default
#line hidden
            EndContext();
            BeginContext(456, 72, true);
            WriteLiteral("</td></tr>\r\n                <tr><th align=\"left\"><b>Adress:</b></th><td>");
            EndContext();
            BeginContext(529, 16, false);
#line 17 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml"
                                                       Write(clubTemp.Address);

#line default
#line hidden
            EndContext();
            BeginContext(545, 34, true);
            WriteLiteral("</td></tr>\r\n            </table>\r\n");
            EndContext();
            BeginContext(581, 43, true);
            WriteLiteral("            <h2>Players of this Club</h2>\r\n");
            EndContext();
#line 21 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml"
            //@foreach (var pl in clubTemp.Players)
            {
                

#line default
#line hidden
            BeginContext(709, 45, false);
#line 23 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml"
           Write(Html.Partial("PlayersList", clubTemp.Players));

#line default
#line hidden
            EndContext();
#line 23 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml"
                                                              
            }


#line default
#line hidden
            BeginContext(773, 34, true);
            WriteLiteral("            <br>\r\n                ");
            EndContext();
            BeginContext(807, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71340f397d9e4070979e141bc5960c7e", async() => {
                BeginContext(908, 12, true);
                WriteLiteral("Add a Player");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-clubID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml"
                                                                                       WriteLiteral(clubTemp.ClubID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["clubID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-clubID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["clubID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(924, 38, true);
            WriteLiteral("\r\n            <br>\r\n            <hr>\r\n");
            EndContext();
#line 30 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Home\ClubDetailsPage.cshtml"
        }

#line default
#line hidden
            BeginContext(973, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Club>> Html { get; private set; }
    }
}
#pragma warning restore 1591
