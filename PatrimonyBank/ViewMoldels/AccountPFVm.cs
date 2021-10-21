using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatrimonyBank.ViewMoldels
{
    public class AccountPFVm
    {
        [Key]
        public int personalID { get; set; }

        [Display(Name = "Marca")]
        public string brandName { get; set; }

        [Display(Name = "Nome Civil")]
        public string civilName { get; set; }

        [Display(Name = "Nome Social")]
        public string socialName { get; set; }

        [Display(Name = "Data")]
        public DateTime dateTime { get; set; }

        [Display(Name = "Estado Civil")]
        public string maritalStatusCode { get; set; }

        [Display(Name = "Info Estado Civil")]
        public string maritalStatusAdditionalInfo { get; set; }

        [Display(Name = "Sexo")]
        public string sex { get; set; }

        [Display(Name = "Compania CNPJ")]
        public string companyCnpj { get; set; }
        public string CPF { get; set; }
        //public List<OtherDocument> otherDocuments { get; set; }

        [Display(Name = "Nacionalidade Brasileira?")]
        public bool hasBrazilianNationality { get; set; }

        [Display(Name = "Outra nacionalidade")]
        public string otherNationalitiesInfo { get; set; }

        [Display(Name = "Tipo Documento")]
        public string typeDocument { get; set; }

        [Display(Name = "Info Adicional")]
        public string typeAdditionalInfo { get; set; }

        [Display(Name = "Nº Documento")]
        public string numberDocument { get; set; }

        [Display(Name = "Digito de verificação")]
        public char checkDigit { get; set; }

        [Display(Name = "Info Adicional")]
        public string additionalInfo { get; set; }

        [Display(Name = "Data de expiração")]
        public DateTime expirationDate { get; set; }

        [Display(Name = "Data de Emissão")]
        public DateTime issueDate { get; set; }

        [Display(Name = "País")]
        public string country { get; set; }

        //public List<Nationality> nationality { get; set; }
        //public List<Filiation> filiation { get; set; }

        [Display(Name = "Tipo filiação")]
        public string typeFiliation { get; set; }

        [Display(Name = "Nome filiação")]
        public string civilNameFiliation { get; set; }

        [Display(Name = "Filiação social")]
        public string socialNameFiliation { get; set; }
        //public Contacts contacts { get; set; }

        [Display(Name = "Endereço")]
        public string address { get; set; }

        [Display(Name = "Endereço Add")]
        public string additionalInfoAdress { get; set; }

        [Display(Name = "Nome distrito")]
        public string districtName { get; set; }

        [Display(Name = "Nome cidade")]
        public string townName { get; set; }

        [Display(Name = "Codigo Ibge")]
        public string ibgeTownCode { get; set; }

        [Display(Name = "sub divisão do país")]
        public string countrySubDivision { get; set; }

        [Display(Name = "Cep")]
        public string postCode { get; set; }

        [Display(Name = "Endereço país")]
        public string countryAdress { get; set; }

        [Display(Name = "Código endereço")]
        public string countryCode { get; set; }

        [Display(Name = "Tipo Telefone")]
        public string typePhone1 { get; set; }

        [Display(Name = "Telefone Adicional")]
        public string additionalInfoPhone1 { get; set; }

        [Display(Name = "Código país")]
        public string countryCallingCode1 { get; set; }

        [Display(Name = "Area de código")]
        public string areaCodePhone1 { get; set; }

        [Display(Name = "Nº telefone")]
        public string numberPhone1 { get; set; }

        [Display(Name = "Telefone adicional")]
        public string phoneExtension1 { get; set; }

        [Display(Name = "Tipo Telefone")]
        public string typePhone2 { get; set; }

        [Display(Name = "Telefone Adicional")]
        public string additionalInfoPhone2 { get; set; }

        [Display(Name = "Código país2")]
        public string countryCallingCode2 { get; set; }

        [Display(Name = "Area de código2")]
        public string areaCodePhone2 { get; set; }

        [Display(Name = "Nº telefon2")]
        public string numberPhone2 { get; set; }

        [Display(Name = "Telefone adicional2")]
        public string phoneExtension2 { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }
    }
}
