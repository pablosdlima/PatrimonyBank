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

        [Display(Name = "Nome Comercial")]
        public string TradeName { get; set; }

        [Display(Name = "Data Incorporação")]
        public DateTime? IncorporationDate { get; set; } //datetime

        [Display(Name = "Cnpj")]
        public string CnpjNumber { get; set; }

        [Display(Name = "CNPJ Compania")]
        public string CompanyCnpjNumber { get; set; }

        [Display(Name = "Outro Tipo de Documento")]
        public string OtherDocumentType { get; set; }

        [Display(Name = "Outro Número de Documento")]
        public string OtherDocumentNumber { get; set; }

        [Display(Name = "Outro país do documento")]
        public string OtherDocumentCountry { get; set; }

        [Display(Name = "Data de validade")]
        public DateTime? ExpirationDate { get; set; } //datetime

        [Display(Name = "Tipo de pessoa")]
        public string PartiesPersonType { get; set; }

        [Display(Name = "Tipo de pessoa 2")]
        public string PartieType { get; set; }

        [Display(Name = "Nome Civil")]
        public string PartieCivilName { get; set; }

        [Display(Name = "Nome Social")]
        public string PartieSocialName { get; set; }

        [Display(Name = "Nome Comercial da Partie")]
        public string PartieTradeName { get; set; }

        [Display(Name = "Data e hora")]
        [DataType(DataType.Date)]
        public DateTime? DateTime { get; set; }

        [Display(Name = "Segurado")]
        public double PartieShareHolding { get; set; }

        [Display(Name = "Parte Tipo de Documento")]
        public string PartieDocumentType { get; set; }

        [Display(Name = "Parte Nº documento")]
        public string PartieDocumentNumber { get; set; }

        [Display(Name = "Parte de info Adicional")]
        public string PartieAdditionalInfo { get; set; }

        [Display(Name = "Parte Doc País")]
        public string PartieDocumentCountry { get; set; }

        [Display(Name = "Doc expiração")]
        public DateTime? PartieDocumentExpirationOnDate { get; set; } //datetime

        [Display(Name = "Data de Emissão do Documento")]
        public DateTime? DocumentIssueDate { get; set; } //date time

        [Display(Name = "Endereço")]
        public string Adress { get; set; }

        [Display(Name = "Info Endereço")]
        public string AdressAdditionalInfo { get; set; }

        [Display(Name = "Distrito Endereço")]
        public string AdressDistrictName { get; set; }

        [Display(Name = "Nome da cidade de endereço")]
        public string AdressTownName { get; set; }

        [Display(Name = "Código da cidade")]
        public string AdressIbgeTownCode { get; set; }

        [Display(Name = "Endereço da subdivisão do país")]
        public string AdressCountrySubDivision { get; set; }

        [Display(Name = "CEP")]
        public string AdressPostCode { get; set; }

        [Display(Name = "Endereço País")]
        public string AdressCountry { get; set; }

        [Display(Name = "Código País")]
        public string AdressCountryCode { get; set; }

        [Display(Name = "Cordenadas latitude")]
        public string AdressGeographicCoordinatesLatitude { get; set; }

        [Display(Name = "Cordenadas Longitude")]
        public string AdressGeographicCoordinatesLongitude { get; set; }

        [Display(Name = "Tipo Celular")]
        public string PhonesType { get; set; }

        [Display(Name = "Info adicional Celular")]
        public string PhonesAdditionalInfo { get; set; }

        [Display(Name = "Código de chamadas")]
        public string PhonesCountryCallingCode { get; set; }

        [Display(Name = "Codigo de area")]
        public string PhonesAreaCode { get; set; }

        [Display(Name = "Numero Telefone")]
        public string PhonesNumber { get; set; }

        [Display(Name = "Extensao de numeros")]
        public string PhonesExtension { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
