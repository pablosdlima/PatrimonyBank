using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PatrimonyBank.Models
{
    [Table("PessoaJuridica")]
    public class PessoaJuridica
    {
        [Key]
        public int IdPessoaJuridica { get; set; }

        [Display(Name = "Marca")]
        public string BrandName { get; set; }

        [Display(Name = "Compania")]
        public string CompanyName { get; set; }

        public string TradeName { get; set; }
        public DateTime? IncorporationDate { get; set; } //datetime
        public string CnpjNumber { get; set; }
        public string CompanyCnpjNumber { get; set; }
        public string OtherDocumentType { get; set; }
        public string OtherDocumentNumber { get; set; }
        public string OtherDocumentCountry { get; set; }
        public DateTime? ExpirationDate { get; set; } //datetime
        public string PartiesPersonType { get; set; }
        public string PartieType { get; set; }
        public string PartieCivilName { get; set; }
        public string PartieSocialName { get; set; }
        public string PartieTradeName { get; set; }
        public DateTime? DateTime { get; set; }
        public double PartieShareHolding { get; set; }
        public string PartieDocumentType { get; set; }
        public string PartieDocumentNumber { get; set; }
        public string PartieAdditionalInfo { get; set; }
        public string PartieDocumentCountry { get; set; }
        public DateTime? PartieDocumentExpirationOnDate { get; set; } //datetime
        public DateTime? DocumentIssueDate { get; set; } //date time
        public string Adress { get; set; }
        public string AdressAdditionalInfo { get; set; }
        public string AdressDistrictName { get; set; }
        public string AdressTownName { get; set; }
        public string AdressIbgeTownCode { get; set; }
        public string AdressCountrySubDivision { get; set; }
        public string AdressPostCode { get; set; }
        public string AdressCountry { get; set; }
        public string AdressCountryCode { get; set; }
        public string AdressGeographicCoordinatesLatitude { get; set; }
        public string AdressGeographicCoordinatesLongitude { get; set; }
        public string PhonesType { get; set; }
        public string PhonesAdditionalInfo { get; set; }
        public string PhonesCountryCallingCode { get; set; }
        public string PhonesAreaCode { get; set; }
        public string PhonesNumber { get; set; }
        public string PhonesExtension { get; set; }
        public string Email { get; set; }
    }
}
