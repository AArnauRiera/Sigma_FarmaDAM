Imports System.Xml
Imports System.Xml.Schema
Imports System.IO

Public Structure resum
    Dim totallin As Integer
    Dim receptalin As Integer
    Dim noreceptalin As Integer
    Dim totalrecepta As Integer
    Dim totalnorecepta As Integer
End Structure

Public Structure article
    Dim referencia As Integer
    Dim quantitat As Integer
    Dim recepta As Boolean
End Structure

Public Structure comanda
    Dim client As String
    Dim data_comanda As String
    Dim num As Integer
    Dim articles() As article
    Dim resum As resum
End Structure

Public Class frmXMLReader

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim comanda As comanda

        ''dades mentida
        comanda.client = "12345"
        comanda.data_comanda = "15/09/2017"
        comanda.num = 1
        ReDim Preserve comanda.articles(3)
        comanda.articles(1).referencia = "2345365"
        comanda.articles(1).quantitat = 2
        comanda.articles(1).recepta = True
        comanda.articles(2).referencia = "6515365"
        comanda.articles(2).quantitat = 5
        comanda.articles(2).recepta = False
        comanda.articles(3).referencia = "3652345"
        comanda.articles(3).quantitat = 6
        comanda.articles(3).recepta = True
        comanda.resum.totallin = 3
        comanda.resum.receptalin = 2
        comanda.resum.noreceptalin = 1
        comanda.resum.totalrecepta = 8
        comanda.resum.totalnorecepta = 5
        ''

        WriteComanda(comanda)
    End Sub

    Public Sub WriteComanda(ByVal comanda As comanda)
        Dim settings As New XmlWriterSettings()
        settings.Indent = True
        settings.IndentChars = "    "
        Using writer As XmlWriter = XmlWriter.Create("comanda.xml", settings)
            ' Write XML data.
            writer.WriteStartElement("comanda")
            writer.WriteElementString("client", comanda.client)
            writer.WriteElementString("dataComanda", comanda.data_comanda)
            writer.WriteElementString("num", comanda.num)
            writer.WriteStartElement("articles")
            For i = 1 To comanda.articles.Length - 1
                writer.WriteStartElement("article")
                writer.WriteAttributes("lin", i)
                writer.WriteElementString("referencia", comanda.articles(i).referencia)
                writer.WriteElementString("quantitat", comanda.articles(i).quantitat)
                If comanda.articles(i).recepta Then
                    writer.WriteElementString("recepta", " ")
                End If
                writer.WriteEndElement()
            Next
            writer.WriteStartElement("resum")
            writer.WriteElementString("totallin", comanda.resum.totallin)
            writer.WriteElementString("receptalin", comanda.resum.totallin)
            writer.WriteElementString("noreceptalin", comanda.resum.noreceptalin)
            writer.WriteElementString("totalrecepta", comanda.resum.totalrecepta)
            writer.WriteElementString("totalnorecepta", comanda.resum.totalnorecepta)

            writer.Flush()
        End Using
    End Sub


End Class