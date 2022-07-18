Imports System.IO
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Public Class formMenu

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim jsonpath As String = "C:\Users\Element 54\Documents\Repos\Resume Creator\VB - Resume Creator (Json)\VB - Resume Creator (Json)\resumeInfo.json"
        Dim openfile As String = File.ReadAllText(jsonpath)
        Dim resumeout As JsonReader = JsonConvert.DeserializeObject(Of JsonReader)(openfile)
        Dim pdfcreator As Document = New Document()
        PdfWriter.GetInstance(pdfcreator, New FileStream("C:\Users\Element 54\Documents\Repos\Resume Creator\VB - Resume Creator (Json)\VB - Resume Creator (Json)\Testing.pdf", FileMode.Create))
        Dim font1 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 24, iTextSharp.text.Font.BOLD)
        Dim font2 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 14, iTextSharp.text.Font.BOLD)
        Dim font3 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 12)
        Dim font4 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 12, iTextSharp.text.Font.BOLD)
        Dim font5 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 8)
        Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(resumeout.Image)
        image.ScalePercent(10.5F)
        image.Alignment = 10
        Dim cut As LineSeparator = New LineSeparator(4.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim fullName As Paragraph = New Paragraph(resumeout.Name & vbLf, font1)
        Dim Address As Paragraph = New Paragraph(vbLf & resumeout.Address, font3)
        Dim emailAddress As Paragraph = New Paragraph(resumeout.emailAddress, font3)
        Dim birthdate As Paragraph = New Paragraph(resumeout.birthDate & vbLf & vbLf, font3)
        Dim contactInfo As Paragraph = New Paragraph(resumeout.contactInfo, font3)


        Dim headerObjective As Paragraph = New Paragraph(resumeout.headerObjective & vbLf & vbLf, font2)
        Dim objective As Paragraph = New Paragraph("      " & resumeout.objective & vbLf & vbLf, font3)


        Dim headerAcademic As Paragraph = New Paragraph(resumeout.headerAcademic & vbLf & vbLf, font2)
        Dim college As Phrase = New Phrase("          College      -         " & resumeout.college & vbLf, font3)
        Dim highschool As Phrase = New Phrase("          Highschool    -       " & resumeout.highSchool & vbLf, font3)
        Dim headerSkills As Paragraph = New Paragraph(resumeout.headerSkills & vbLf & vbLf, font2)


        Dim skill1 As Paragraph = New Paragraph(vbLf & "        • " & resumeout.skill1 & vbLf, font4)
        Dim skill2 As Paragraph = New Paragraph("        • " & resumeout.skill2 & vbLf, font4)
        Dim skill3 As Paragraph = New Paragraph("        • " & resumeout.skill3 & vbLf, font4)
        Dim skill4 As Paragraph = New Paragraph("        • " & resumeout.skill4 & vbLf & vbLf, font4)
        Dim exp1 As Paragraph = New Paragraph("        • " & resumeout.Exp1, font4)
        Dim exp2 As Paragraph = New Paragraph("        • " & resumeout.Exp2, font4)
        Dim exp3 As Paragraph = New Paragraph("        • " & resumeout.Exp3, font4)
        Dim footer As Paragraph = New Paragraph(resumeout.Footer, font5)
        footer.Alignment = Element.ALIGN_CENTER


        pdfcreator.Open()
        pdfcreator.Add(Image)
        pdfcreator.Add(fullName)
        pdfcreator.Add(Address)
        pdfcreator.Add(emailAddress)
        pdfcreator.Add(birthDate)
        pdfcreator.Add(contactInfo)

        pdfcreator.Add(headerObjective)
        pdfcreator.Add(cut)
        pdfcreator.Add(objective)
        pdfcreator.Add(headerAcademic)

        pdfcreator.Add(cut)
        pdfcreator.Add(college)
        pdfcreator.Add(highSchool)
        pdfcreator.Add(headerSkills)

        pdfcreator.Add(cut)
        pdfcreator.Add(skill1)
        pdfcreator.Add(skill2)
        pdfcreator.Add(skill3)
        pdfcreator.Add(skill4)

        pdfcreator.Add(exp1)
        pdfcreator.Add(exp2)
        pdfcreator.Add(exp3)



        pdfcreator.Close()

        MessageBox.Show("Your Resume is Created.")

    End Sub

    Public Class jsonreader

        Public Property Footer As String
        Public Property Image As String
        Public Property Name As String
        Public Property Address As String
        Public Property emailAddress As String
        Public Property birthDate As String
        Public Property contactInfo As String

        Public Property headerObjective As String
        Public Property objective As String


        Public Property headerAcademic As String
        Public Property college As String
        Public Property highSchool As String



        Public Property headerSkills As String
        Public Property skill1 As String
        Public Property skill2 As String
        Public Property skill3 As String
        Public Property skill4 As String

        Public Property headerExpheaderExperience As String
        Public Property Exp1 As String
        Public Property Exp2 As String
        Public Property Exp3 As String

    End Class

End Class
