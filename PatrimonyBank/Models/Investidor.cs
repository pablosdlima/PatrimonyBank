using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PatrimonyBank.Models
{
    [Table("InvestidorTb")]
    public class Investidor
    {
        [Key]
        public int IdInvestidor { get; set; }
        public string Cnpj { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public string TipoDocumento { get; set; }
        public string OrgaoEmissor { get; set; }
        public DateTime DataEmissao { get; set; } = DateTime.Now;
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string EstadoCivil { get; set; }
        public string NomeConjuge { get; set; }
        public string PaisDomicilioFiscal { get; set; }
        public string PaisDomicilioFiscalOutro { get; set; }
        public string PaisCidadania { get; set; }
        public string PaisCidadaniaOutro { get; set; }

        //contatos
        public string Telefone { get; set; }
        public string Email { get; set; }
        //contatos

        //endereco
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public int? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        //endereco

        //vinculo empregativo
        public string OcupacaoProfissional { get; set; }
        public string Empresa { get; set; }
        public string CNPJEmpregativo { get; set; }
        //vinculo empregativo

        //Endereco empresarial
        public string EnderecoEmpresa { get; set; }
        public int NumeroEmpresa { get; set; }
        public int? ComplementoEmpresa { get; set; }
        public string BairroEmpresa { get; set; }
        public string CepEmpresa { get; set; }
        public string CidadeEmpresa { get; set; }
        public string EstadoEmpresa { get; set; }
        public string PaisEmpresa { get; set; }
        //Endereco empresarial
    }
}
