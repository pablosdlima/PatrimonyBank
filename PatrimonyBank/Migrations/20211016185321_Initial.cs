using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatrimonyBank.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvestidorTb",
                columns: table => new
                {
                    IdInvestidor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naturalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgaoEmissor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomeMae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomePai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeConjuge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisDomicilioFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisDomicilioFiscalOutro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisCidadania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisCidadaniaOutro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<int>(type: "int", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OcupacaoProfissional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJEmpregativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnderecoEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroEmpresa = table.Column<int>(type: "int", nullable: false),
                    ComplementoEmpresa = table.Column<int>(type: "int", nullable: true),
                    BairroEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CepEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CidadeEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestidorTb", x => x.IdInvestidor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvestidorTb");
        }
    }
}
