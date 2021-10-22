using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PatrimonyBank.Models
{
    [Table("PessoaFisica")]
    public class PessoaFisica
    {
        [Key]
        public int PersonalID { get; set; }

        [Display(Name = "Marca")]
        public string BrandName { get; set; }

        [Display(Name = "Nome Civil")]
        public string CivilName { get; set; }

        [Display(Name = "Nome Social")]
        public string SocialName { get; set; }

        [Display(Name = "Data")]
        public DateTime DateTime { get; set; }

        [Display(Name = "Estado Civil")]
        public string MaritalStatusCode { get; set; }

        [Display(Name = "Info Estado Civil")]
        public string MaritalStatusAdditionalInfo { get; set; }

        [Display(Name = "Sexo")]
        public string Sex { get; set; }

        [Display(Name = "Compania CNPJ")]
        [DisplayFormat(NullDisplayText = "Não Informado")]
        public string CompanyCnpj { get; set; }
        public string CPF { get; set; }
        //public List<OtherDocument> otherDocuments { get; set; }

        [Display(Name = "Nacionalidade Brasileira?")]
        public bool HasBrazilianNationality { get; set; }

        [Display(Name = "Outra nacionalidade")]
        public string OtherNationalitiesInfo { get; set; }

        [Display(Name = "Tipo Documento")]
        public string TypeDocument { get; set; }

        [Display(Name = "Info Adicional")]
        public string TypeAdditionalInfo { get; set; }

        [Display(Name = "Nº Documento")]
        public string NumberDocument { get; set; }

        [Display(Name = "Digito de verificação")]
        public char CheckDigit { get; set; }

        [Display(Name = "Info Adicional")]
        [DisplayFormat(NullDisplayText = "Não Informado")]
        public string AdditionalInfo { get; set; }

        [Display(Name = "Data de expiração")]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Data de Emissão")]
        public DateTime IssueDate { get; set; }

        [Display(Name = "País")]
        public string Country { get; set; }

        //public List<Nationality> nationality { get; set; }
        //public List<Filiation> filiation { get; set; }

        [Display(Name = "Tipo filiação")]
        public string TypeFiliation { get; set; }

        [Display(Name = "Nome filiação")]
        public string CivilNameFiliation { get; set; }

        [Display(Name = "Filiação social")]
        public string SocialNameFiliation { get; set; }
        //public Contacts contacts { get; set; }

        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Display(Name = "Endereço Add")]
        public string AdditionalInfoAdress { get; set; }

        [Display(Name = "Nome distrito")]
        public string DistrictName { get; set; }

        [Display(Name = "Nome cidade")]
        public string TownName { get; set; }

        [Display(Name = "Codigo Ibge")]
        public string IbgeTownCode { get; set; }

        [Display(Name = "sub divisão do país")]
        public string CountrySubDivision { get; set; }

        [Display(Name = "Cep")]
        public string PostCode { get; set; }

        [Display(Name = "Endereço país")]
        public string CountryAdress { get; set; }

        [Display(Name = "Código endereço")]
        public string CountryCode { get; set; }

        [Display(Name = "Tipo Telefone")]
        public string TypePhone1 { get; set; }

        [Display(Name = "Telefone Adicional")]
        public string AdditionalInfoPhone1 { get; set; }

        [Display(Name = "Código país")]
        public string CountryCallingCode1 { get; set; }

        [Display(Name = "Area de código")]
        public string AreaCodePhone1 { get; set; }

        [Display(Name = "Nº telefone")]
        public string NumberPhone1 { get; set; }

        [Display(Name = "Telefone adicional")]
        public string PhoneExtension1 { get; set; }

        [Display(Name = "Tipo Telefone")]
        public string TypePhone2 { get; set; }

        [Display(Name = "Telefone Adicional")]
        public string AdditionalInfoPhone2 { get; set; }

        [Display(Name = "Código país2")]
        public string CountryCallingCode2 { get; set; }

        [Display(Name = "Area de código2")]
        public string AreaCodePhone2 { get; set; }

        [Display(Name = "Nº telefon2")]
        public string NumberPhone2 { get; set; }

        [Display(Name = "Telefone adicional2")]
        public string PhoneExtension2 { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
