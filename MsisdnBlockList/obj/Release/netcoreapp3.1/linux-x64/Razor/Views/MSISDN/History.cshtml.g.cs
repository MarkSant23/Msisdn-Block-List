#pragma checksum "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e26a8a28a7233ad084ba39d9ed6f753c3334873"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MSISDN_History), @"mvc.1.0.view", @"/Views/MSISDN/History.cshtml")]
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
#line 1 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\_ViewImports.cshtml"
using MsisdnBlockList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\_ViewImports.cshtml"
using MsisdnBlockList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e26a8a28a7233ad084ba39d9ed6f753c3334873", @"/Views/MSISDN/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b337091179cf01434367f2a6b5936203f03c20c0", @"/Views/_ViewImports.cshtml")]
    public class Views_MSISDN_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MsisdnBlockList.Models.Log>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Msisdn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("history.go(-1); return false;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
  
    ViewData["Title"] = "History";

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n<div style=\"float:left;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e26a8a28a7233ad084ba39d9ed6f753c33348735157", async() => {
                WriteLiteral("Nazad");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div style=\"float:left; position:relative; left:75px;\"><h3>Povijest broja mobilnog telefona ");
#nullable restore
#line 9 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
                                                                                       Write(ViewBag.MSISDN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></div>    \r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
           Write(Html.DisplayNameFor(model => model.user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>           \r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
           Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
           Write(Html.DisplayNameFor(model => model.created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 31 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
                   Write(item.user.user_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    \r\n                    <td>\r\n");
#nullable restore
#line 35 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
                         if (item.status != 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-primary\">Blokiran</span>\r\n");
#nullable restore
#line 38 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
                   Write(item.created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\History.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MsisdnBlockList.Models.Log>> Html { get; private set; }
    }
}
#pragma warning restore 1591