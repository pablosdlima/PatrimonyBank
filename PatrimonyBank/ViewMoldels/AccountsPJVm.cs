using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatrimonyBank.ViewMoldels
{
    public class AccountsPJVm
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Marca")]
        public string brandName { get; set; }

        [Display(Name = "Compania")]
        public string companyName { get; set; }

        public string tradeName { get; set; }
        public DateTime? IncorporationDate { get; set; } //datetime
        public string cnpjNumber { get; set; }
        public string companyCnpjNumber { get; set; }
        public string otherDocumentType { get; set; }
        public string otherDocumentNumber { get; set; }
        public string otherDocumentCountry { get; set; }
        public DateTime? expirationDate { get; set; } //datetime
        public string partiesPersonType { get; set; }
        public string partieType { get; set; }
        public string partieCivilName { get; set; }
        public string partieSocialName { get; set; }
        public string partieTradeName { get; set; }
        public DateTime? dateTime { get; set; }
        public double partieShareHolding { get; set; }
        public string partieDocumentType { get; set; }
        public string partieDocumentNumber { get; set; }
        public string partieAdditionalInfo { get; set; }
        public string partieDocumentCountry { get; set; }
        public DateTime? partieDocumentExpirationOnDate { get; set; } //datetime
        public DateTime? documentIssueDate { get; set; } //date time
        public string adress { get; set; }
        public string adressAdditionalInfo { get; set; }
        public string adressDistrictName { get; set; }
        public string adressTownName { get; set; }
        public string adressIbgeTownCode { get; set; }
        public string adressCountrySubDivision { get; set; }
        public string adressPostCode { get; set; }
        public string adressCountry { get; set; }
        public string adressCountryCode { get; set; }
        public string adressGeographicCoordinatesLatitude { get; set; }
        public string adressGeographicCoordinatesLongitude { get; set; }
        public string phonesType { get; set; }
        public string phonesAdditionalInfo { get; set; }
        public string phonesCountryCallingCode { get; set; }
        public string phonesAreaCode { get; set; }
        public string phonesNumber { get; set; }
        public string phonesExtension { get; set; }
        public string email { get; set; }
    }
}
