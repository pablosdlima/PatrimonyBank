#pragma checksum "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd9dd9b1c405b11e8f2228542c4c186b17f7bfc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Investidors_Details), @"mvc.1.0.view", @"/Views/Investidors/Details.cshtml")]
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
#line 1 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\_ViewImports.cshtml"
using PatrimonyBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\_ViewImports.cshtml"
using PatrimonyBank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd9dd9b1c405b11e8f2228542c4c186b17f7bfc1", @"/Views/Investidors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5decd420d5bd012398575bc29e108f06adc8860e", @"/Views/_ViewImports.cshtml")]
    public class Views_Investidors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PatrimonyBank.Models.Investidor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Investidor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nacionalidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nacionalidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Naturalidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Naturalidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrgaoEmissor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrgaoEmissor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataEmissao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataEmissao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeMae));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeMae));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomePai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomePai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstadoCivil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstadoCivil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeConjuge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeConjuge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaisDomicilioFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaisDomicilioFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaisDomicilioFiscalOutro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaisDomicilioFiscalOutro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaisCidadania));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaisCidadania));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaisCidadaniaOutro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaisCidadaniaOutro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Complemento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Complemento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 152 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 155 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 158 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 161 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 164 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pais));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 167 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pais));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 170 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OcupacaoProfissional));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 173 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.OcupacaoProfissional));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 176 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 179 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 182 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CNPJEmpregativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 185 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.CNPJEmpregativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 188 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EnderecoEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 191 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.EnderecoEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 194 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 197 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumeroEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 200 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ComplementoEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 203 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.ComplementoEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 206 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BairroEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 209 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.BairroEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 212 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CepEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 215 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.CepEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 218 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CidadeEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 221 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.CidadeEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 224 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstadoEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 227 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstadoEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 230 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaisEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 233 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaisEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd9dd9b1c405b11e8f2228542c4c186b17f7bfc129765", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 238 "C:\Users\Mateus Marques\Source\Repos\PatrimonyBankWeb\PatrimonyBank\Views\Investidors\Details.cshtml"
                           WriteLiteral(Model.IdInvestidor);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd9dd9b1c405b11e8f2228542c4c186b17f7bfc131940", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatrimonyBank.Models.Investidor> Html { get; private set; }
    }
}
#pragma warning restore 1591
