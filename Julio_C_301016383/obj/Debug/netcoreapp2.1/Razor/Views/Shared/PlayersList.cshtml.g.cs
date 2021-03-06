#pragma checksum "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Shared\PlayersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dc9b2ca20033860d22ad46456318faa48418caf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PlayersList), @"mvc.1.0.view", @"/Views/Shared/PlayersList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PlayersList.cshtml", typeof(AspNetCore.Views_Shared_PlayersList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dc9b2ca20033860d22ad46456318faa48418caf", @"/Views/Shared/PlayersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e419a222b9f40a865d0784f1984a0e175d14e5e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PlayersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Player>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPlayers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 347, true);
            WriteLiteral(@"

<div id=""conteiner"" class=""lists"">
    <table>
        <thead>
            <tr>
                <th>Player ID</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Age</th>
                <th class=""text-center"">Actions</th>
            </tr>
        </thead>
        <tbody>            
");
            EndContext();
#line 16 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Shared\PlayersList.cshtml"
                 foreach (Player playerTemp in Model)
                {

#line default
#line hidden
            BeginContext(449, 54, true);
            WriteLiteral("            <tr>                \r\n                <td>");
            EndContext();
            BeginContext(504, 19, false);
#line 19 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Shared\PlayersList.cshtml"
               Write(playerTemp.PlayerID);

#line default
#line hidden
            EndContext();
            BeginContext(523, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(551, 20, false);
#line 20 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Shared\PlayersList.cshtml"
               Write(playerTemp.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(571, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(599, 19, false);
#line 21 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Shared\PlayersList.cshtml"
               Write(playerTemp.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(618, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(646, 14, false);
#line 22 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Shared\PlayersList.cshtml"
               Write(playerTemp.Age);

#line default
#line hidden
            EndContext();
            BeginContext(660, 69, true);
            WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n                    ");
            EndContext();
            BeginContext(729, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d0c05bdc0844dfb3e84995143cee6e", async() => {
                BeginContext(775, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(801, 197, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19ef8f9165b9440a806f4f01cacbee9e", async() => {
                    BeginContext(990, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-playerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 26 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Shared\PlayersList.cshtml"
                                   WriteLiteral(playerTemp.PlayerID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["playerId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-playerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["playerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 26 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Shared\PlayersList.cshtml"
                                                                           WriteLiteral(playerTemp.ClubID);

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
                BeginContext(998, 62, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"PlayerID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1060, "\"", 1088, 1);
#line 27 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Shared\PlayersList.cshtml"
WriteAttributeValue("", 1068, playerTemp.PlayerID, 1068, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1089, 118, true);
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1214, 46, true);
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 33 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Shared\PlayersList.cshtml"
                }            

#line default
#line hidden
            BeginContext(1291, 38, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Player>> Html { get; private set; }
    }
}
#pragma warning restore 1591
