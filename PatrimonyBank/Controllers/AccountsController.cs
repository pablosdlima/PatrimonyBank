using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PatrimonyBank.Data;
using PatrimonyBank.ViewMoldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PatrimonyBank.Controllers
{
    public class AccountsController : Controller
    {
        private readonly PatrimonyContext _context;

        public AccountsController(PatrimonyContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult>GetAccountsPF(string Cpf)
        {
            return RedirectToAction("DetailsGetAccounts", new { cpf = Cpf });
        }

        public async Task<IActionResult> DetailsGetAccounts(string cpf)
        {
            if (cpf == null)
            {
                return NotFound();
            }

            HttpClient http = new();
            http.BaseAddress = new Uri("https://patrimonybank.azurewebsites.net/api/v1/Account/");
            HttpResponseMessage resposta = await http.GetAsync(cpf);
            resposta.EnsureSuccessStatusCode();

            string conteudo = resposta.Content.ReadAsStringAsync().Result;

            dynamic resultado = JsonConvert.DeserializeObject(conteudo);

            AccountPFVm obj = new()
            {
                personalID = resultado.personalID,
                brandName = resultado.brandName,
                civilName = resultado.civilName,
                socialName = resultado.socialName,
                dateTime = resultado.dateTime,
                maritalStatusCode = resultado.maritalStatusCode,
                maritalStatusAdditionalInfo = resultado.maritalStatusAdditionalInfo,
                sex = resultado.sex,
                companyCnpj = resultado.companyCnpj,
                CPF = resultado.CPF,
                otherNationalitiesInfo = resultado.otherNationalitiesInfo,
                typeDocument = resultado.typeDocument,
                typeAdditionalInfo = resultado.typeAdditionalInfo,
                numberDocument = resultado.numberDocument,
                checkDigit = resultado.checkDigit,
                additionalInfo = resultado.additionalInfo,
                expirationDate = resultado.expirationDate,
                issueDate = resultado.issueDate,
                country = resultado.country,
                typeFiliation = resultado.typeFiliation,
                civilNameFiliation = resultado.civilNameFiliation,
                socialNameFiliation = resultado.socialNameFiliation,
                address = resultado.address,
                additionalInfoAdress = resultado.additionalInfoAdress,
                districtName = resultado.districtName,
                townName = resultado.townName,
                ibgeTownCode = resultado.ibgeTownCode,
                countrySubDivision = resultado.countrySubDivision,
                postCode = resultado.postCode,
                countryAdress = resultado.countryAdress,
                countryCode = resultado.countryCode,
                typePhone1 = resultado.typePhone1,
                additionalInfoPhone1 = resultado.additionalInfoPhone1,
                countryCallingCode1 = resultado.countryCallingCode1,
                areaCodePhone1 = resultado.areaCodePhone1,
                numberPhone1 = resultado.numberPhone1,
                phoneExtension1 = resultado.phoneExtension1,
                typePhone2 = resultado.typePhone2,
                additionalInfoPhone2 = resultado.additionalInfoPhone2,
                countryCallingCode2 = resultado.countryCallingCode2,
                areaCodePhone2 = resultado.areaCodePhone2,
                numberPhone2 = resultado.numberPhone2,
                phoneExtension2 = resultado.phoneExtension2,
                email = resultado.email
            };
            return View(obj);
        }
        //[HttpPost]
        //public async Task<IActionResult>GetAccountsPJ(string Cpf)
        //{
        //    return RedirectToAction("DetailsGetAccountsPJ", new { cpf = Cpf });
        //}

        //public async Task<IActionResult> DetailsGetAccountsPJ(string cnpj)
        //{
        //    if (cnpj == null)
        //    {
        //        return NotFound();
        //    }

        //    HttpClient http = new();
        //    http.BaseAddress = new Uri("https://patrimonybank.azurewebsites.net/api/v1/AccountPJ/");
        //    HttpResponseMessage resposta = await http.GetAsync(cnpj);
        //    resposta.EnsureSuccessStatusCode();

        //    string conteudo = resposta.Content.ReadAsStringAsync().Result;
        //    dynamic resultado = JsonConvert.DeserializeObject(conteudo);

        //    AccountsVm contasPJ = new()
        //    {
        //        contas.ID = resultado.ID,
        //        contas.brandName = resultado.brandName,
        //        contas.companyName = resultado.companyName,
        //        contas.tradeName = resultado.tradeName,
        //        contas.IncorporationDate = resultado.IncorporationDate,
        //        contas.CpfNumber = resultado.CpfNumber,
        //        contas.companyCpfNumber = resultado.companyCpfNumber,
        //        contas.otherDocumentType = resultado.otherDocumentType,
        //        contas.otherDocumentNumber = resultado.otherDocumentNumber,
        //        contas.otherDocumentCountry = resultado.otherDocumentCountry,
        //        contas.expirationDate = resultado.expirationDate,
        //        contas.partiesPersonType = resultado.partiesPersonType,
        //        contas.partieType = resultado.partieType,
        //        contas.partieCivilName = resultado.partieCivilName,
        //        contas.partieSocialName = resultado.partieSocialName,
        //        contas.partieTradeName = resultado.partieTradeName,
        //        contas.dateTime = resultado.dateTime,
        //        contas.partieShareHolding = resultado.partieShareHolding,
        //        contas.partieDocumentType = resultado.partieDocumentType,
        //        contas.partieDocumentNumber = resultado.partieDocumentNumber,
        //        contas.partieDocumentNumber = resultado.partieDocumentNumber,
        //        contas.partieDocumentCountry = resultado.partieDocumentCountry,
        //        contas.partieDocumentExpirationOnDate = resultado.partieDocumentExpirationOnDate,
        //        contas.documentIssueDate = resultado.documentIssueDate,
        //        contas.documentIssueDate = resultado.documentIssueDate,
        //        contas.adress = resultado.adress,
        //        contas.adressAdditionalInfo = resultado.adressAdditionalInfo,
        //        contas.adressDistrictName = resultado.adressDistrictName,
        //        contas.adressTownName = resultado.adressTownName,
        //        contas.adressIbgeTownCode = resultado.adressIbgeTownCode,
        //        contas.adressCountrySubDivision = resultado.adressCountrySubDivision,
        //        contas.adressPostCode = resultado.adressPostCode,
        //        contas.adressCountry = resultado.adressCountry,
        //        contas.adressCountryCode = resultado.adressCountryCode,
        //        contas.adressGeographicCoordinatesLatitude = resultado.adressGeographicCoordinatesLatitude,
        //        contas.adressGeographicCoordinatesLongitude = resultado.adressGeographicCoordinatesLongitude,
           
        //    };

            
        //    return View(obj);
        //}
    }
}



