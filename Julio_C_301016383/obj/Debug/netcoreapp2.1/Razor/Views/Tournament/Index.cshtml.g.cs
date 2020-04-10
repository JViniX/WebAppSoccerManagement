#pragma checksum "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20e733742086d9fb9797fc685062f76b491b1bb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournament_Index), @"mvc.1.0.view", @"/Views/Tournament/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tournament/Index.cshtml", typeof(AspNetCore.Views_Tournament_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e733742086d9fb9797fc685062f76b491b1bb7", @"/Views/Tournament/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e419a222b9f40a865d0784f1984a0e175d14e5e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tournament_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tournament>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TournamentDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTournament", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn_middle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
  
    ViewData["Title"] = "TournamentPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 30, true);
            WriteLiteral("\r\n<h1>Tournament Page</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(187, 336, true);
            WriteLiteral(@"    <table id=""tournament_table"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Period</th>
                <th>Clubs</th>
                <th>Ticket</th>
                <th class=""text-center"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
             foreach (Tournament t in Model)
            {

#line default
#line hidden
            BeginContext(584, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(631, 14, false);
#line 26 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
                   Write(t.TournamentID);

#line default
#line hidden
            EndContext();
            BeginContext(645, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(677, 6, false);
#line 27 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
                   Write(t.Name);

#line default
#line hidden
            EndContext();
            BeginContext(683, 52, true);
            WriteLiteral("</td>\r\n                    <td style=\"width:100px;\">");
            EndContext();
            BeginContext(736, 29, false);
#line 28 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
                                        Write(t.From.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(765, 3, true);
            WriteLiteral(" ~ ");
            EndContext();
            BeginContext(769, 27, false);
#line 28 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
                                                                         Write(t.To.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(796, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(828, 11, false);
#line 29 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
                   Write(t.ClubCount);

#line default
#line hidden
            EndContext();
            BeginContext(839, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(871, 21, false);
#line 30 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
                   Write(t.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(892, 77, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(969, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6880d0053c44483b9961552c27ee95a", async() => {
                BeginContext(1075, 7, true);
                WriteLiteral("Details");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tournamentID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
                                                                                                     WriteLiteral(t.TournamentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tournamentID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tournamentID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tournamentID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1086, 66, true);
            WriteLiteral("\r\n                        <input type=\"hidden\" name=\"TournamentID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1152, "\"", 1175, 1);
#line 33 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
WriteAttributeValue("", 1160, t.TournamentID, 1160, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1176, 55, true);
            WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 36 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1246, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 39 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1281, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
 if (User.IsInRole("Admins"))
{

#line default
#line hidden
            BeginContext(1317, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1321, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "308be32b43c04ee48c687328771f9287", async() => {
                BeginContext(1398, 14, true);
                WriteLiteral("Add Tournament");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1416, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Tournament\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tournament>> Html { get; private set; }
    }
}
#pragma warning restore 1591
