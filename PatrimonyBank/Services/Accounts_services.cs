using Newtonsoft.Json;
using PatrimonyBank.ViewMoldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PatrimonyBank.Services
{
    public class Accounts_services
    {
        public async Task<AccountPFVm> AccountPF(string cpf)
        {
            HttpClient http = new();
            http.BaseAddress = new Uri("https://patrimonybankapi.azurewebsites.net/api/v1/Account/");
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
                CPF = resultado.cpf,
                otherNationalitiesInfo = resultado.otherNationalitiesInfo,
                typeDocument = resultado.typeDocument,
                typeAdditionalInfo = resultado.typeAdditionalInfo ?? "Vazio",
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
            return obj;
        }
        
        public async Task<AccountPFVm> ListarAccountPF()
        {
            HttpClient http = new();
            http.BaseAddress = new Uri("https://patrimonybankapi.azurewebsites.net/api/v1/Account/");
            HttpResponseMessage resposta = await http.GetAsync("?");
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
                CPF = resultado.cpf,
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
            return obj;
        }

        public async Task<AccountsPJVm> AccountPJ(string cnpj)
        {
            try
            {
                HttpClient http = new();
                http.BaseAddress = new Uri("https://patrimonybankapi.azurewebsites.net/api/v1/AccountPJ/");
                HttpResponseMessage resposta = await http.GetAsync(cnpj);
                resposta.EnsureSuccessStatusCode();

                string conteudo = resposta.Content.ReadAsStringAsync().Result;
                dynamic resultado = JsonConvert.DeserializeObject(conteudo);

                AccountsPJVm obj = new()
                {
                    id = resultado.id,
                    brandName = resultado.brandName,
                    companyName = resultado.companyName,
                    tradeName = resultado.tradeName,
                    IncorporationDate = resultado.incorporationDate,
                    cnpjNumber = resultado.cnpjNumber,
                    companyCnpjNumber = resultado.companyCpfNumber,
                    otherDocumentType = resultado.otherDocumentType,
                    otherDocumentNumber = resultado.otherDocumentNumber,
                    otherDocumentCountry = resultado.otherDocumentCountry,
                    expirationDate = resultado.expirationDate,
                    partiesPersonType = resultado.partiesPersonType,
                    partieType = resultado.partieType,
                    partieCivilName = resultado.partieCivilName,
                    partieSocialName = resultado.partieSocialName,
                    partieTradeName = resultado.partieTradeName,
                    dateTime = resultado.dateTime,
                    partieShareHolding = resultado.partieShareHolding,
                    partieDocumentType = resultado.partieDocumentType,
                    partieDocumentNumber = resultado.partieDocumentNumber,
                    partieDocumentCountry = resultado.partieDocumentCountry,
                    partieDocumentExpirationOnDate = resultado.partieDocumentExpirationOnDate,
                    documentIssueDate = resultado.documentIssueDate,
                    adress = resultado.adress,
                    adressAdditionalInfo = resultado.adressAdditionalInfo,
                    adressDistrictName = resultado.adressDistrictName,
                    adressTownName = resultado.adressTownName,
                    adressIbgeTownCode = resultado.adressIbgeTownCode,
                    adressCountrySubDivision = resultado.adressCountrySubDivision,
                    adressPostCode = resultado.adressPostCode,
                    adressCountry = resultado.adressCountry,
                    adressCountryCode = resultado.adressCountryCode,
                    adressGeographicCoordinatesLatitude = resultado.adressGeographicCoordinatesLatitude,
                    adressGeographicCoordinatesLongitude = resultado.adressGeographicCoordinatesLongitude,
                    phonesType = resultado.phonesType,
                    phonesAdditionalInfo = resultado.phonesAdditionalInfo,
                    phonesCountryCallingCode = resultado.phonesCountryCallingCode,
                    phonesAreaCode = resultado.phonesAreaCode,
                    phonesNumber = resultado.phonesNumber,
                    phonesExtension = resultado.phonesExtension,
                    email = resultado.email
                };

                return obj;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
