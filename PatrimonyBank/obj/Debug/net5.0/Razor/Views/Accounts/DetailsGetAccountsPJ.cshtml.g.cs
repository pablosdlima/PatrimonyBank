#pragma checksum "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61546c02091901b2fa791ec7f1bb5682d436c3b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_DetailsGetAccountsPJ), @"mvc.1.0.view", @"/Views/Accounts/DetailsGetAccountsPJ.cshtml")]
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
#line 1 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\_ViewImports.cshtml"
using PatrimonyBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\_ViewImports.cshtml"
using PatrimonyBank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61546c02091901b2fa791ec7f1bb5682d436c3b7", @"/Views/Accounts/DetailsGetAccountsPJ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5decd420d5bd012398575bc29e108f06adc8860e", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_DetailsGetAccountsPJ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PatrimonyBank.ViewMoldels.AccountsPJVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn red darken-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:1%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveAccountsPJ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 51, "\"", 59, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <p class=\"tituloLeve fonteLeveM center bordaTxtTitulo\">CNPJ : ");
#nullable restore
#line 3 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                             Write(Html.DisplayFor(model => model.cnpjNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<br>\r\n<div class=\"centralizeDiv larguraPP flex flexEvenly\">\r\n    <div class=\"center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61546c02091901b2fa791ec7f1bb5682d436c3b76718", async() => {
                WriteLiteral("<i class=\"material-icons\">picture_as_pdf</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61546c02091901b2fa791ec7f1bb5682d436c3b78212", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("class", " class=\"", 530, "\"", 538, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"cnpj\"");
                BeginWriteAttribute("value", " value=\"", 551, "\"", 576, 1);
#nullable restore
#line 9 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
WriteAttributeValue("", 559, Model.cnpjNumber, 559, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <button class=\"btn waves-effect waves-light blue darken-2\" type=\"submit\" name=\"action\">\r\n            Salvar\r\n            <i class=\"material-icons right\">save</i>\r\n        </button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<br>
<div class=""centralizeDiv larguraG alturaVHG contornoM"" style=""padding:1%; background-color:snow;"">
    <table class=""striped"">
        <thead style=""color:snow;"" class=""blue darken-2"">
            <tr>
                <td class=""center"" colspan=""12""><strong>");
#nullable restore
#line 21 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong> ");
#nullable restore
#line 21 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                         Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"center\" colspan=\"12\"><strong>");
#nullable restore
#line 22 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.companyCnpjNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong> ");
#nullable restore
#line 22 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                                     Write(Html.DisplayFor(model => model.companyCnpjNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"center\" colspan=\"12\"><strong>");
#nullable restore
#line 23 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.brandName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong> ");
#nullable restore
#line 23 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                             Write(Html.DisplayFor(model => model.brandName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 28 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.partieCivilName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 28 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                   Write(Html.DisplayFor(model => model.partieCivilName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 29 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.dateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 29 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                            Write(Html.DisplayFor(model => model.dateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 30 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.partieSocialName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong> ");
#nullable restore
#line 30 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                     Write(Html.DisplayFor(model => model.partieSocialName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 33 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.partieTradeName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong> ");
#nullable restore
#line 33 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                    Write(Html.DisplayFor(model => model.partieTradeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 34 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.partieShareHolding));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 34 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                      Write(Html.DisplayFor(model => model.partieShareHolding));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 35 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.partieDocumentType));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 35 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                      Write(Html.DisplayFor(model => model.partieDocumentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 38 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.partieDocumentNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 38 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                        Write(Html.DisplayFor(model => model.partieDocumentNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 39 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.partieAdditionalInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 39 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                        Write(Html.DisplayFor(model => model.partieAdditionalInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 40 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.expirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 40 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                  Write(Html.DisplayFor(model => model.expirationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 43 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adress));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 43 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                          Write(Html.DisplayFor(model => model.adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 44 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adressAdditionalInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 44 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                        Write(Html.DisplayFor(model => model.adressAdditionalInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 45 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adressDistrictName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 45 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                      Write(Html.DisplayFor(model => model.adressDistrictName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 48 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adressTownName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 48 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                  Write(Html.DisplayFor(model => model.adressTownName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 49 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adressIbgeTownCode));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 49 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                      Write(Html.DisplayFor(model => model.adressIbgeTownCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 50 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adressCountrySubDivision));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 50 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                            Write(Html.DisplayFor(model => model.adressCountrySubDivision));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 53 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adressPostCode));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 53 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                  Write(Html.DisplayFor(model => model.adressPostCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 54 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adressCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 54 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                 Write(Html.DisplayFor(model => model.adressCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 55 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adressCountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 55 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                     Write(Html.DisplayFor(model => model.adressCountryCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 58 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adressGeographicCoordinatesLatitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 58 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                                       Write(Html.DisplayFor(model => model.adressGeographicCoordinatesLatitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 59 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.adressGeographicCoordinatesLongitude));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 59 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                                        Write(Html.DisplayFor(model => model.adressGeographicCoordinatesLongitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 60 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.phonesType));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 60 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                              Write(Html.DisplayFor(model => model.phonesType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 63 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.phonesAdditionalInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 63 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                        Write(Html.DisplayFor(model => model.phonesAdditionalInfo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 64 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.phonesCountryCallingCode));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 64 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                            Write(Html.DisplayFor(model => model.phonesCountryCallingCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 65 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.phonesAreaCode));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 65 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                  Write(Html.DisplayFor(model => model.phonesAreaCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 68 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.phonesNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 68 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                Write(Html.DisplayFor(model => model.phonesNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 69 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.phonesExtension));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 69 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                                   Write(Html.DisplayFor(model => model.phonesExtension));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td colspan=\"12\"><strong>");
#nullable restore
#line 70 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                    Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral(": </strong>");
#nullable restore
#line 70 "D:\Aplicações\Hackatudo\PatrimonyBank\PatrimonyBank\Views\Accounts\DetailsGetAccountsPJ.cshtml"
                                                                                         Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<br>\r\n<br>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatrimonyBank.ViewMoldels.AccountsPJVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
