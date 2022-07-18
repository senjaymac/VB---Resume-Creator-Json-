Imports System.IO
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Public Class formMenu

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim jsonpath As String = "C:\Users\Element 54\Documents\Repos\Resume Creator\VB - Resume Creator (Json)\VB - Resume Creator (Json)\ resumeInfo.json"
        Dim openfile As String = File.ReadAllText(jsonpath)
        Dim resumeout As JsonReader = JsonConvert.DeserializeObject(Of JsonReader)(openfile)
        Dim pdfcreator As Document = New Document()
        PdfWriter.GetInstance(pdfcreator, New FileStream("C:\Users\Element 54\Documents\Repos\Cl\json\Resume Creator VB\ Testing.pdf", FileMode.Create))
    End Sub
End Class
