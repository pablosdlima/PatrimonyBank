using iTextSharp.text.pdf;
using System.IO;
using System.Linq;

namespace PatrimonyBank.Reader
{
    public class Reader
    {
        // Necessário definir os parametros para preencher o formulário
        public bool ReadPdf(string nomePar)
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
                pdfFormFields.SetField("form1[0].Pg0[0].titular2NomeCompleto[0]", nomePar);
                
                // Fecha o arquivo
                pdfStamper.Close();

                return true;
            }catch
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

