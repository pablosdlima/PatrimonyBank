using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PatrimonyBank.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountPFVm",
                columns: table => new
                {
                    personalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    civilName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    socialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maritalStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maritalStatusAdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    companyCnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hasBrazilianNationality = table.Column<bool>(type: "bit", nullable: false),
                    otherNationalitiesInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeAdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    checkDigit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    additionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    issueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typeFiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    civilNameFiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    socialNameFiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    additionalInfoAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    districtName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    townName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ibgeTownCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countrySubDivision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typePhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    additionalInfoPhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryCallingCode1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    areaCodePhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberPhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneExtension1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    typePhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    additionalInfoPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryCallingCode2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    areaCodePhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneExtension2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountPFVm", x => x.personalID);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFisica",
                columns: table => new
                {
                    PersonalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CivilName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaritalStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatusAdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBrazilianNationality = table.Column<bool>(type: "bit", nullable: false),
                    OtherNationalitiesInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeAdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckDigit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeFiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CivilNameFiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialNameFiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInfoAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IbgeTownCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountrySubDivision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypePhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInfoPhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCallingCode1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaCodePhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberPhone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneExtension1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypePhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInfoPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCallingCode2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaCodePhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberPhone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneExtension2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisica", x => x.PersonalID);
                });

            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    IdPessoaJuridica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncorporationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CnpjNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCnpjNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherDocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherDocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherDocumentCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PartiesPersonType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartieType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartieCivilName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartieSocialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartieTradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PartieShareHolding = table.Column<double>(type: "float", nullable: false),
                    PartieDocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartieDocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartieAdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartieDocumentCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartieDocumentExpirationOnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressAdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressDistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressTownName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressIbgeTownCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressCountrySubDivision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressPostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressGeographicCoordinatesLatitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressGeographicCoordinatesLongitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhonesType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhonesAdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhonesCountryCallingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhonesAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhonesNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhonesExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.IdPessoaJuridica);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountPFVm");

            migrationBuilder.DropTable(
                name: "PessoaFisica");

            migrationBuilder.DropTable(
                name: "PessoaJuridica");
        }
    }
}
