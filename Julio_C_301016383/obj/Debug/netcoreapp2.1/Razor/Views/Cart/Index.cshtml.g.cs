#pragma checksum "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bde1d328e00bcd102137131b4ca90a0df2b8b0ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde1d328e00bcd102137131b4ca90a0df2b8b0ef", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e419a222b9f40a865d0784f1984a0e175d14e5e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(13, 487, true);
            WriteLiteral(@"
<h2>Your cart</h2>
<div id=""container"">
    <div id=""conteiner"" class=""lists"">
        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>

                    <th>Stadium</th>
                    <th>Clubs</th>
                    <th>Date and Time</th>
                    <th>Quantity</th>
                    <th>Price</th>
                    <th>Subtotal</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 19 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                 foreach (var line in Model.Lines)
                {

#line default
#line hidden
            BeginContext(571, 48, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(620, 18, false);
#line 23 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                   Write(line.Match.Stadium);

#line default
#line hidden
            EndContext();
            BeginContext(638, 67, true);
            WriteLiteral("</td>\r\n                    <td style=\"width:150px;\" align=\"center\">");
            EndContext();
            BeginContext(706, 20, false);
#line 24 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                                                       Write(line.Match.Club1Name);

#line default
#line hidden
            EndContext();
            BeginContext(726, 4, true);
            WriteLiteral(" VS ");
            EndContext();
            BeginContext(731, 20, false);
#line 24 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                                                                                Write(line.Match.Club2Name);

#line default
#line hidden
            EndContext();
            BeginContext(751, 32, true);
            WriteLiteral(" </td>\r\n                    <td>");
            EndContext();
            BeginContext(784, 41, false);
#line 25 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                   Write(line.Match.MatchDateAndTime.ToLocalTime());

#line default
#line hidden
            EndContext();
            BeginContext(825, 46, true);
            WriteLiteral("</td>\r\n                    <td align=\"center\">");
            EndContext();
            BeginContext(872, 13, false);
#line 26 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                                  Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(885, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(917, 30, false);
#line 27 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                   Write(line.Match.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(947, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1006, 48, false);
#line 29 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                    Write((line.Quantity * line.Match.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 99, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
            EndContext();
            BeginContext(1154, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86c7037e18fe480a8fb7e51ead7447d1", async() => {
                BeginContext(1287, 6, true);
                WriteLiteral("Remove");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-matchId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                                  WriteLiteral(line.Match.MatchID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["matchId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-matchId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["matchId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1297, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 36 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1368, 202, true);
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(1571, 39, false);
#line 42 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
                   Write(Model.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 129, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n\r\n        <div class=\"text-center\">\r\n");
            EndContext();
#line 49 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
             if (@ViewBag.returnUrl != null)
            {

#line default
#line hidden
            BeginContext(1800, 42, true);
            WriteLiteral("                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1842, "\"", 1867, 1);
#line 51 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1849, ViewBag.returnUrl, 1849, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1868, 24, true);
            WriteLiteral(">Continue shopping</a>\r\n");
            EndContext();
#line 52 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1907, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 53 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
             if (Model.Lines.Count() > 0)
            {

#line default
#line hidden
            BeginContext(1965, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1981, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c63875b30c3047f8b1d41d519edebae6", async() => {
                BeginContext(2053, 8, true);
                WriteLiteral("Checkout");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2065, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "C:\GitHub\WebAppSoccerManagement\Julio_C_301016383\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2082, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
