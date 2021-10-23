using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PatrimonyBank.Data;
using PatrimonyBank.Models;
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

        [HttpGet]
        public async Task<IActionResult> ListarAccountsPF()
        {
            var resultado = await _context.PessoaFisica.ToListAsync();
            return View(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> ListarAccountsPJ()
        {
            var resultado = await _context.PessoaJuridica.ToListAsync();
            return View(resultado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveAcccountsPF(string cpf)
        {
            try
            {
                Accounts_services objAPI = new();
                AccountPFVm obj = await objAPI.AccountPF(cpf);

                PessoaFisica model = new()
                {
                    BrandName = obj.brandName,
                    CivilName = obj.civilName,
                    SocialName = obj.socialName,
                    DateTime = obj.dateTime,
                    MaritalStatusCode = obj.maritalStatusCode,
                    MaritalStatusAdditionalInfo = obj.maritalStatusAdditionalInfo,
                    Sex = obj.sex,
                    CompanyCnpj = obj.companyCnpj,
                    CPF = obj.CPF,
                    HasBrazilianNationality = obj.hasBrazilianNationality,
                    OtherNationalitiesInfo = obj.otherNationalitiesInfo,
                    TypeDocument = obj.typeDocument,
                    TypeAdditionalInfo = obj.typeAdditionalInfo,
                    NumberDocument = obj.numberDocument,
                    CheckDigit = obj.checkDigit,
                    AdditionalInfo = obj.additionalInfo,
                    ExpirationDate = obj.expirationDate,
                    IssueDate = obj.issueDate,
                    Country = obj.country,
                    TypeFiliation = obj.typeFiliation,
                    CivilNameFiliation = obj.civilNameFiliation,
                    SocialNameFiliation = obj.socialNameFiliation,
                    Address = obj.address,
                    AdditionalInfoAdress = obj.additionalInfoAdress,
                    DistrictName = obj.districtName,
                    TownName = obj.townName,
                    IbgeTownCode = obj.ibgeTownCode,
                    CountryAdress = obj.countryAdress,
                    CountryCode = obj.countryCode,
                    TypePhone1 = obj.typePhone1,
                    AdditionalInfoPhone1 = obj.additionalInfoPhone1,
                    CountryCallingCode1 = obj.countryCallingCode1,
                    AreaCodePhone1 = obj.areaCodePhone1,
                    NumberPhone1 = obj.numberPhone1,
                    PhoneExtension1 = obj.phoneExtension1,
                    NumberPhone2 = obj.numberPhone2,
                    TypePhone2 = obj.typePhone2,
                    AdditionalInfoPhone2 = obj.additionalInfoPhone2,
                    CountryCallingCode2 = obj.countryCallingCode2,
                    AreaCodePhone2 = obj.areaCodePhone2,
                    PhoneExtension2 = obj.phoneExtension2,
                    Email = obj.email
                };
                await _context.AddAsync(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("ListarAccountsPF");
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveAccountsPJ(string cnpj)
        {
            try
            {
                Accounts_services objAPI = new();
                AccountsPJVm obj = await objAPI.AccountPJ(cnpj);

                PessoaJuridica model = new()
                {
                    BrandName = obj.brandName,
                    CompanyName = obj.companyName,
                    TradeName = obj.tradeName,
                    IncorporationDate = obj.IncorporationDate,
                    CnpjNumber = obj.cnpjNumber,
                    CompanyCnpjNumber = obj.companyCnpjNumber,
                    OtherDocumentType = obj.otherDocumentType,
                    OtherDocumentNumber = obj.otherDocumentNumber,
                    OtherDocumentCountry = obj.otherDocumentCountry,
                    ExpirationDate = obj.expirationDate,
                    PartiesPersonType = obj.partiesPersonType,
                    PartieType = obj.partieType,
                    PartieCivilName = obj.partieCivilName,
                    PartieSocialName = obj.partieSocialName,
                    PartieTradeName = obj.partieTradeName,
                    DateTime = obj.dateTime,
                    PartieShareHolding = obj.partieShareHolding,
                    PartieDocumentType = obj.partieDocumentType,
                    PartieDocumentNumber = obj.partieDocumentNumber,
                    PartieDocumentCountry = obj.partieDocumentCountry,
                    PartieDocumentExpirationOnDate = obj.partieDocumentExpirationOnDate,
                    DocumentIssueDate = obj.documentIssueDate,
                    Adress = obj.adress,
                    AdressAdditionalInfo = obj.adressAdditionalInfo,
                    AdressDistrictName = obj.adressDistrictName,
                    AdressTownName = obj.adressTownName,
                    AdressIbgeTownCode = obj.adressIbgeTownCode,
                    AdressCountrySubDivision = obj.adressCountrySubDivision,
                    AdressPostCode = obj.adressPostCode,
                    AdressCountry = obj.adressCountry,
                    AdressCountryCode = obj.adressCountryCode,
                    AdressGeographicCoordinatesLatitude = obj.adressGeographicCoordinatesLatitude,
                    AdressGeographicCoordinatesLongitude = obj.adressGeographicCoordinatesLongitude,
                    PhonesType = obj.phonesType,
                    PhonesAdditionalInfo = obj.phonesAdditionalInfo,
                    PhonesCountryCallingCode = obj.phonesCountryCallingCode,
                    PhonesAreaCode = obj.phonesAreaCode,
                    PhonesNumber = obj.phonesNumber,
                    PhonesExtension = obj.phonesExtension,
                    Email = obj.email
                };
                _context.Add(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("ListarAccountsPF");

            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public IActionResult CreateAccountsPF()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAccountsPF(PessoaFisica model)
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("ListarAccountsPF");
        }

        public IActionResult CreateAccountsPJ()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAccountsPJ(PessoaJuridica model)
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("ListarAccountsPJ");
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
            catch (Exception)
            {
                return RedirectToAction("GerenciaInvestidor", "Investidors", new {msg = 1});
                
                // throw new Exception(erro.Message);
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
            catch (Exception)
            {
                return RedirectToAction("GerenciaInvestidor", "Investidors", new { msg = 2 });
                //throw new Exception(erro.Message);
            }
        }


        public async Task<IActionResult> PdfAccountsPF(string cpf)
        {
            Accounts_services objAPI = new();
            AccountPFVm obj = await objAPI.AccountPF(cpf);

            ReaderPDF objPdf = new();
            bool result =  objPdf.ReadPdf(obj);

            if (result is true) return RedirectToAction(nameof(ListarAccountsPF));
            if (result is false) return NotFound();

            return View();

        }

    }
}



