#pragma checksum "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13b86f3813c969a1a26f0b293817a227a12f6902"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MSISDN_Index), @"mvc.1.0.view", @"/Views/MSISDN/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13b86f3813c969a1a26f0b293817a227a12f6902", @"/Views/MSISDN/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b337091179cf01434367f2a6b5936203f03c20c0", @"/Views/_ViewImports.cshtml")]
    public class Views_MSISDN_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MsisdnBlockList.Models.MSISDN>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Pretra??ivanje brojeva telefona</h2>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13b86f3813c969a1a26f0b293817a227a12f69025397", async() => {
                WriteLiteral("Kreiraj novi");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13b86f3813c969a1a26f0b293817a227a12f69026732", async() => {
                WriteLiteral(@"
    <div class=""input-group mb-2"">
        <input class=""form-control"" min=""6"" 
               data-val=""true"" data-val-maxlength=""Maksimalno 13 znakova"" data-val-minlength=""Minimalno 6 znakova"" data-val-minlength-min=""6"" data-val-maxlength-max=""13"" data-val-regex=""Potrebno barem 6 znamenki broja za pretra??ivanje"" data-val-regex-pattern=""((?+/[0-9]{6,}))"" data-val-required=""Potrebno je navesti MSISDN""
               style=""border-radius:5px;"" type=""text"" name=""Msisdn"" placeholder=""Pretra??i broj telefona""");
                BeginWriteAttribute("value", " value=\"", 784, "\"", 807, 1);
#nullable restore
#line 15 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
WriteAttributeValue("", 792, ViewBag.MSISDN, 792, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <span class=\"text-danger field-validation-valid\" data-valmsg-for=\"Msisdn\" data-valmsg-replace=\"true\"></span>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Message) || ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\"><span>");
#nullable restore
#line 21 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
                                      Write(Html.Raw(ViewBag.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 22 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.msisdn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.modified));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.msisdn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
               Write(item.modified);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
               Write(item.created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
               Write(item.user.user_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 63 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
                     if (item.status != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-primary\">Blokiran</span>\r\n");
#nullable restore
#line 66 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 69 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
                     if (item.status != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2496, "\"", 2557, 4);
            WriteAttributeValue("", 2503, "/MSISDN/Unblock/", 2503, 16, true);
#nullable restore
#line 71 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
WriteAttributeValue("", 2519, item.msisdn_id, 2519, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2534, "?search=", 2534, 8, true);
#nullable restore
#line 71 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
WriteAttributeValue("", 2542, ViewBag.MSISDN, 2542, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Odblokiraj</a>\r\n");
#nullable restore
#line 72 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2697, "\"", 2756, 4);
            WriteAttributeValue("", 2704, "/MSISDN/Block/", 2704, 14, true);
#nullable restore
#line 75 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
WriteAttributeValue("", 2718, item.msisdn_id, 2718, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2733, "?search=", 2733, 8, true);
#nullable restore
#line 75 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
WriteAttributeValue("", 2741, ViewBag.MSISDN, 2741, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Blokiraj</a>\r\n");
#nullable restore
#line 76 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2886, "\"", 2924, 2);
            WriteAttributeValue("", 2893, "/MSISDN/History/", 2893, 16, true);
#nullable restore
#line 79 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
WriteAttributeValue("", 2909, item.msisdn_id, 2909, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" role=\"button\" asp value=\"Prika??i\">Povijest promjena</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\marksant\OneDrive - Tele2\MsisdnBlockList\MsisdnBlockList\MsisdnBlockList\Views\MSISDN\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MsisdnBlockList.Models.MSISDN>> Html { get; private set; }
    }
}
#pragma warning restore 1591
