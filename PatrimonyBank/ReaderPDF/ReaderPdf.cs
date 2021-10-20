using iTextSharp.text;
using iTextSharp.text.pdf;
using PatrimonyBank.ViewMoldels;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace PatrimonyBank.Reader
{
    public class ReaderPDF
    {
        // Necessário definir os parametros para preencher o formulário
        public bool ReadPdf(AccountPFVm account)
        {
            try
            {
                // Define o caminho onde o formulário está
                PdfReader pdfReader = new PdfReader(@"C:\Temp\PDF\Documents\FichaCadastral_PF_Anexo_I.pdf");

                // Chama o método para pegar os campos do PDF com os valores
                var fieldList = GetFormFieldNamesWithValues(pdfReader);

                // Cria um novo arquivo, que será o editado
                string newFile = @"C:\Temp\PDF\Documents\FichaCadastral_PF_Anexo_I_Edit_completed.pdf";
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));

                AcroFields pdfFormFields = pdfStamper.AcroFields;

                // Necessário debugar e ver como cada campo vem, então preencher com os valores passados como parâmetro
                var nome = pdfFormFields.GetField("form1[0].Pg0[0].titular2NomeCompleto[0]");
                pdfFormFields.SetField("form1[0].Pg0[0].titular2NomeCompleto[0]", account.civilName);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2CPF[0]", account.CPF);

                if (account.typeFiliation.ToString().ToUpper() == "PAI")
                {
                    pdfFormFields.SetField("form1[0].Pg0[0].titular2Pai[0]", account.civilNameFiliation);

                }else if (account.typeFiliation.ToUpper() == "MAE")
                {
                    pdfFormFields.SetField("form1[0].Pg0[0].titular2Mae[0]", account.civilNameFiliation);
                }


                pdfFormFields.SetField("form1[0].Pg0[0].titular2DataNascimento[0]", account.dateTime.Date.ToShortDateString());

                
                pdfFormFields.SetField("form1[0].Pg0[0].titular2Nacionalidade[0]", account.country, true);

                pdfFormFields.SetField("form1[0].Pg0[0].titular2EnderecoUF[0]", account.countrySubDivision);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2EnderecoCidade[0]", account.districtName);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2EnderecoCEP[0]", account.postCode);
                //pdfFormFields.SetField("form1[0].Pg0[0].titular2EnderecoCEP[0]", account.countryCode);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2EnderecoLogradouro[0]", account.address);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2EnderecoComplemento[0]", account.additionalInfoAdress);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2Email[0]", account.email);
                pdfFormFields.SetField("form1[0].Pg1[0].titular2NomeCompleto[0]", account.email);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2EnderecoCidade[0]", account.townName);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2EnderecoBairro[0]", account.districtName);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2Naturalidade[0]", account.townName);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2EnderecoUF[0]", account.countrySubDivision);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2EstadoCivil[0]", account.maritalStatusCode);
                pdfFormFields.SetField("form1[0].Pg0[0].titular2EnderecoNomePais[0]", account.countryAdress);


                if (account.numberPhone1 != "" || account.numberPhone1 != null)
                {

                    pdfFormFields.SetField("form1[0].Pg0[0].titular2Telefone[0]", account.numberPhone1);
                    pdfFormFields.SetField("form1[0].Pg0[0].titular2TelefoneDDI[0]", account.countryCallingCode1);
                    pdfFormFields.SetField("form1[0].Pg0[0].titular2TelefoneDDD[0]", account.areaCodePhone1);

                }
                else if (account.numberPhone2 != "" || account.numberPhone2 != null)
                {

                    pdfFormFields.SetField("form1[0].Pg0[0].titular2Telefone[0]", account.numberPhone2);
                    pdfFormFields.SetField("form1[0].Pg0[0].titular2TelefoneDDI[0]", account.countryCallingCode2);
                    pdfFormFields.SetField("form1[0].Pg0[0].titular2TelefoneDDD[0]", account.areaCodePhone2);

                }



                if (account.typeAdditionalInfo.ToUpper() != "")
                {
                    pdfFormFields.SetField("form1[0].Pg0[0].titular2TipoRG[0]", account.typeAdditionalInfo, true);
                    pdfFormFields.SetField("form1[0].Pg0[0].titular2NumeroRG[0]", account.numberDocument);
                    pdfFormFields.SetField("form1[0].Pg0[0].titular2OrgaoExpedidor[0]", account.additionalInfo);
                    pdfFormFields.SetField("form1[0].Pg0[0].titular2DataExpedicaoRG[0]", account.issueDate.ToShortDateString());
                }

                    // Fecha o arquivo
                pdfStamper.Close();
                return true;
            }catch (Exception e)
            {
                return false;
            }
            

        }
        
        // Método que veririca os campos e formata para retornar 
        private static string GetFormFieldNamesWithValues(PdfReader pdfReader)
        {
            return string.Join("\r\n", pdfReader.AcroFields.Fields
                                           .Select(x => x.Key + "=" +
                                            pdfReader.AcroFields.GetField(x.Key))
                                           .ToArray());
        }
    }

}

