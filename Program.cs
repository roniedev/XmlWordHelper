using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using PdfSharpCore.Pdf;

var docPath = @"C:/TESTE.docx";

using (var document = WordprocessingDocument.Open(docPath, true))
{
	try
	{
		string textoBuscado = "NOMECOMPLETO";
		string novoTexto = "RONIE DE JESUS NOGUEIRA";

		var body = document.MainDocumentPart.Document.Body;
		body.InnerXml = body.InnerXml.Replace(textoBuscado, novoTexto);

		document.Save();
	}
	catch (Exception)
	{
		throw;
	}
	finally
	{
		document.Close();	
	}
}