using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PatrimonyBank.Data;
using PatrimonyBank.Reader;
using PatrimonyBank.Services;
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

        public async Task<IActionResult> ListarAccountsPF()
        {
            List<AccountPFVm> lista = new();

            HttpClient http = new();
            http.BaseAddress = new Uri("https://patrimonybankapi.azurewebsites.net/api/v1/Account/");
            HttpResponseMessage resposta = await http.GetAsync("?");
            resposta.EnsureSuccessStatusCode();

            string conteudo = resposta.Content.ReadAsStringAsync().Result;

            dynamic resultado = JsonConvert.DeserializeObject(conteudo);

            foreach(var item in resultado)
            {
                AccountPFVm obj = new()
                {
                    personalID = item.personalID,
                    brandName = item.brandName,
                    civilName = item.civilName,
                    socialName = item.socialName,
                    dateTime = item.dateTime,
                    maritalStatusCode = item.maritalStatusCode,
                    maritalStatusAdditionalInfo = item.maritalStatusAdditionalInfo,
                    sex = item.sex,
                    companyCnpj = item.companyCnpj ?? "Não informado",
                    CPF = item.cpf,
                    otherNationalitiesInfo = item.otherNationalitiesInfo,
                    typeDocument = item.typeDocument,
                    typeAdditionalInfo = item.typeAdditionalInfo,
                    numberDocument = item.numberDocument,
                    checkDigit = item.checkDigit,
                    additionalInfo = item.additionalInfo,
                    expirationDate = item.expirationDate,
                    issueDate = item.issueDate,
                    country = item.country,
                    typeFiliation = item.typeFiliation,
                    civilNameFiliation = item.civilNameFiliation,
                    socialNameFiliation = item.socialNameFiliation,
                    address = item.address,
                    additionalInfoAdress = item.additionalInfoAdress,
                    districtName = item.districtName,
                    townName = item.townName,
                    ibgeTownCode = item.ibgeTownCode,
                    countrySubDivision = item.countrySubDivision,
                    postCode = item.postCode,
                    countryAdress = item.countryAdress,
                    countryCode = item.countryCode,
                    typePhone1 = item.typePhone1,
                    additionalInfoPhone1 = item.additionalInfoPhone1,
                    countryCallingCode1 = item.countryCallingCode1,
                    areaCodePhone1 = item.areaCodePhone1,
                    numberPhone1 = item.numberPhone1,
                    phoneExtension1 = item.phoneExtension1,
                    typePhone2 = item.typePhone2,
                    additionalInfoPhone2 = item.additionalInfoPhone2,
                    countryCallingCode2 = item.countryCallingCode2,
                    areaCodePhone2 = item.areaCodePhone2,
                    numberPhone2 = item.numberPhone2,
                    phoneExtension2 = item.phoneExtension2,
                    email = item.email
                };

                lista.Add(obj);
            }
            return View(lista);
        }

        public async Task<IActionResult> DetailsGetAccounts(string cpf)
        {
            try
            {
                Accounts_services objAPI = new();

                if (cpf == null)
                {
                    return NotFound();
                }

                AccountPFVm obj = await objAPI.AccountPF(cpf);

                ReaderPDF readerPDF = new();
                readerPDF.ReadPdf(obj);

                return View(obj);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public async Task<IActionResult> DetailsGetAccountsPJ(string Cnpj)
        {
            try
            {
                Accounts_services objAPI = new();
                AccountsPJVm obj = await objAPI.AccountPJ(Cnpj);

                if (Cnpj == null)
                {
                    return NotFound();
                }

                if (obj == null)
                {
                    return NotFound();
                }

                return View(obj);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }   
    }
}



