#pragma checksum "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "382ea1472cb8d528e651c76c62c5d613d2f38119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MatchesList), @"mvc.1.0.view", @"/Views/Shared/MatchesList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MatchesList.cshtml", typeof(AspNetCore.Views_Shared_MatchesList))]
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
#line 1 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\_ViewImports.cshtml"
using Julio_C_301016383.Components;

#line default
#line hidden
#line 2 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\_ViewImports.cshtml"
using Julio_C_301016383.Models;

#line default
#line hidden
#line 3 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\_ViewImports.cshtml"
using Julio_C_301016383.Models.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\_ViewImports.cshtml"
using Julio_C_301016383.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"382ea1472cb8d528e651c76c62c5d613d2f38119", @"/Views/Shared/MatchesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e419a222b9f40a865d0784f1984a0e175d14e5e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MatchesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Match>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddGoal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FinishMatch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 432, true);
            WriteLiteral(@"
<div>
    <table id=""tournament_table"">
        <thead>
            <tr>
                <th>Match ID</th>
                <th>Name</th>
                <th>Clubs</th>
                <th>Schedules</th>
                <th>Stadium</th>
                <th>Score</th>
                <th>Status</th>
                <th class=""text-center"">Actions</th>
            </tr>
        </thead>
        <tbody>            
");
            EndContext();
#line 18 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
             foreach (Match m in Model)
            {

#line default
#line hidden
            BeginContext(515, 58, true);
            WriteLiteral("            <tr style=\"height:auto\">\r\n                <td>");
            EndContext();
            BeginContext(574, 9, false);
#line 21 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
               Write(m.MatchID);

#line default
#line hidden
            EndContext();
            BeginContext(583, 48, true);
            WriteLiteral("</td>\r\n                <td style=\"width:120px;\">");
            EndContext();
            BeginContext(632, 6, false);
#line 22 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                                    Write(m.Name);

#line default
#line hidden
            EndContext();
            BeginContext(638, 75, true);
            WriteLiteral("</td>\r\n                <td style=\"width:150px;\">\r\n                    Club ");
            EndContext();
            BeginContext(714, 9, false);
#line 24 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                    Write(m.ClubID1);

#line default
#line hidden
            EndContext();
            BeginContext(723, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(727, 11, false);
#line 24 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                                 Write(m.Club1Name);

#line default
#line hidden
            EndContext();
            BeginContext(738, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                     if (m.ClubID2 != 0)
                    {

#line default
#line hidden
            BeginContext(805, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(831, 15, true);
            WriteLiteral("<b>vs</b> Club ");
            EndContext();
            BeginContext(847, 9, false);
#line 27 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                                    Write(m.ClubID2);

#line default
#line hidden
            EndContext();
            BeginContext(856, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(860, 11, false);
#line 27 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                                                 Write(m.Club2Name);

#line default
#line hidden
            EndContext();
            BeginContext(871, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                    }

#line default
#line hidden
            BeginContext(896, 43, true);
            WriteLiteral("                </td>\r\n                <td>");
            EndContext();
            BeginContext(940, 18, false);
#line 30 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
               Write(m.MatchDateAndTime);

#line default
#line hidden
            EndContext();
            BeginContext(958, 47, true);
            WriteLiteral("</td>\r\n                <td style=\"width:80px;\">");
            EndContext();
            BeginContext(1006, 9, false);
#line 31 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                                   Write(m.Stadium);

#line default
#line hidden
            EndContext();
            BeginContext(1015, 31, true);
            WriteLiteral("</td>\r\n\r\n                <td>\r\n");
            EndContext();
#line 34 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                     if (m.ClubID2 != 0)
                    {
                        

#line default
#line hidden
            BeginContext(1136, 12, false);
#line 36 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                   Write(m.Club1Score);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1151, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1154, 12, false);
#line 36 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                                     Write(m.Club2Score);

#line default
#line hidden
            EndContext();
            BeginContext(1166, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                    }

#line default
#line hidden
            BeginContext(1191, 66, true);
            WriteLiteral("                </td>\r\n                <td style=\"width:100px;\">\r\n");
            EndContext();
#line 40 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                     if (m.IsFinished == true && m.ClubID2 != 0)
                    {

#line default
#line hidden
            BeginContext(1346, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1372, 10, true);
            WriteLiteral("Finished\r\n");
            EndContext();
#line 43 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                    }
                    else if (m.ClubID2 == 0 && m.Name != "Round of 1")
                    {

#line default
#line hidden
            BeginContext(1500, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1526, 12, true);
            WriteLiteral("Drew a bye\r\n");
            EndContext();
#line 47 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                    }
                    else if (m.Name == "Round of 1")
                    {

#line default
#line hidden
            BeginContext(1638, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1664, 7, true);
            WriteLiteral("Final\r\n");
            EndContext();
#line 51 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1743, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1769, 10, true);
            WriteLiteral("Stand by\r\n");
            EndContext();
#line 55 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                    }

#line default
#line hidden
            BeginContext(1802, 25, true);
            WriteLiteral("                </td>\r\n\r\n");
            EndContext();
#line 58 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                 if (User.IsInRole("Admins") && @ViewBag.fromTicekt != "fromTicket")
                {

#line default
#line hidden
            BeginContext(1932, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1982, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7960107f7a284282a29226418aacd1c3", async() => {
                BeginContext(2096, 12, true);
                WriteLiteral("Record Score");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-matchID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                                  WriteLiteral(m.MatchID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["matchID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-matchID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["matchID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2112, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2138, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459a510b7de9408382de9031265138ec", async() => {
                BeginContext(2288, 14, true);
                WriteLiteral("End This Match");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-matchID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                                  WriteLiteral(m.MatchID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["matchID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-matchID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["matchID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                                                             WriteLiteral(m.TournamentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2306, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 66 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                }

#line default
#line hidden
            BeginContext(2354, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 67 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                 if (!m.IsFinished)
                {

#line default
#line hidden
            BeginContext(2410, 62, true);
            WriteLiteral("                <td class=\"text-center\">\r\n                    ");
            EndContext();
            BeginContext(2472, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5ea6dc608144dc8a0c46bae16dd54a5", async() => {
                BeginContext(2657, 12, true);
                WriteLiteral("Buy a Ticket");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-matchId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                              WriteLiteral(m.MatchID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["matchId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-matchId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["matchId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                                                               WriteLiteral(ViewContext.HttpContext.Request.PathAndQuery());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2673, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 73 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
                }

#line default
#line hidden
            BeginContext(2717, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 75 "C:\Users\julio\OneDrive\College\3rd Semester\Web Application\Julio_C_301016383\Julio_C_301016383\Views\Shared\MatchesList.cshtml"
            }            

#line default
#line hidden
            BeginContext(2763, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Match>> Html { get; private set; }
    }
}
#pragma warning restore 1591
