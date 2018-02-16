Imports System.Xml
Imports System.Xml.Schema
Imports System.IO

Public Structure prescription
    Dim cod_nacion As Integer
    Dim nro_definitivo As String
    Dim des_nomco As String
    Dim nro_conte As String
    Dim url_fictec As String
    Dim url_prosp As String
    Dim sw_receta As Boolean
    Dim sw_generico As Boolean
    Dim sw_substituible As Boolean
    Dim laboratorio_titular As Integer
    Dim cod_principio_activo As Integer
End Structure

Public Structure laboratorio
    Dim codigo_laboratorio As Integer
    Dim laboratorio As String
    Dim direccion As String
    Dim codigo_postal As String
    Dim localidad As String
    Dim cif As String
End Structure

Public Structure principio_activo
    Dim nro_principio_activo As Integer
    Dim codigo_principio_activo As String
    Dim principio_activo As String
End Structure


Public Class frmXMLReader
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim prescriptions() As prescription
        prescriptions = GetPrescriptions()
    End Sub

    Public Function GetPrescriptions()
        Dim prescriptions() As prescription
        Dim quantitatPreinscriptions As Integer
        Dim cod_nacion As Boolean
        Dim nro_definitivo As Boolean
        Dim des_nomco As Boolean
        Dim nro_conte As Boolean
        Dim url_fictec As Boolean
        Dim url_prosp As Boolean
        Dim sw_receta As Boolean
        Dim sw_generico As Boolean
        Dim sw_substituible As Boolean
        Dim laboratorio_titular As Boolean
        Dim cod_principio_activo As Boolean

        quantitatPreinscriptions = -1
        cod_nacion = False
        nro_definitivo = False
        des_nomco = False
        nro_conte = False
        url_fictec = False
        url_prosp = False
        sw_receta = False
        sw_generico = False
        sw_substituible = False
        laboratorio_titular = False
        cod_principio_activo = False

        Dim settings As New XmlReaderSettings()
        settings.ConformanceLevel = ConformanceLevel.Fragment
        settings.IgnoreWhitespace = True
        settings.IgnoreComments = True
        Dim reader As XmlReader = XmlReader.Create("Prescripcion.xml", settings)
        reader.MoveToContent()
        ' Parsja el fitxer i mostra cadascun dels nodes.
        While reader.Read()
            If reader.NodeType = XmlNodeType.Element Then
                Select Case reader.Name
                    Case "prescription"
                        quantitatPreinscriptions = quantitatPreinscriptions + 1
                        ReDim Preserve prescriptions(quantitatPreinscriptions)
                    Case "cod_nacion"
                        cod_nacion = True
                    Case "nro_definitivo"
                        nro_definitivo = True
                    Case "des_nomco"
                        des_nomco = True
                    Case "nro_conte"
                        nro_conte = True
                    Case "url_fictec"
                        url_fictec = True
                    Case "url_prosp"
                        url_prosp = True
                    Case "sw_receta"
                        sw_receta = True
                    Case "sw_generico"
                        sw_generico = True
                    Case "sw_substituible"
                        sw_substituible = True
                    Case "laboratorio_titular"
                        laboratorio_titular = True
                    Case "cod_principio_activo"
                        cod_principio_activo = True
                End Select
            End If
            If reader.Value <> "" Then
                If cod_nacion Then
                    prescriptions(quantitatPreinscriptions).cod_nacion = reader.Value
                    cod_nacion = False
                End If
                If nro_definitivo Then
                    prescriptions(quantitatPreinscriptions).nro_definitivo = reader.Value
                    nro_definitivo = False
                End If
                If des_nomco Then
                    prescriptions(quantitatPreinscriptions).des_nomco = reader.Value
                    des_nomco = False
                End If
                If nro_conte Then
                    prescriptions(quantitatPreinscriptions).nro_conte = reader.Value
                    nro_conte = False
                End If
                If url_fictec Then
                    prescriptions(quantitatPreinscriptions).url_fictec = reader.Value
                    url_fictec = False
                End If
                If url_prosp Then
                    prescriptions(quantitatPreinscriptions).url_prosp = reader.Value
                    url_prosp = False
                End If
                If sw_receta Then
                    prescriptions(quantitatPreinscriptions).sw_receta = reader.Value
                    sw_receta = False
                End If
                If sw_generico Then
                    prescriptions(quantitatPreinscriptions).sw_generico = reader.Value
                    sw_generico = False
                End If
                If sw_substituible Then
                    prescriptions(quantitatPreinscriptions).sw_substituible = reader.Value
                    sw_substituible = False
                End If
                If laboratorio_titular Then
                    prescriptions(quantitatPreinscriptions).laboratorio_titular = reader.Value
                    laboratorio_titular = False
                End If
                If cod_principio_activo Then
                    prescriptions(quantitatPreinscriptions).cod_principio_activo = reader.Value
                    cod_principio_activo = False
                End If
            End If
        End While

        Return prescriptions

    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim laboratorios() As laboratorio
        laboratorios = GetLaboratorios()
    End Sub


    Public Function GetLaboratorios()
        Dim laboratorios() As laboratorio
        Dim quantitat_laboratorios As Integer
        Dim codigo_laboratorio As Boolean
        Dim laboratorio As Boolean
        Dim direccion As Boolean
        Dim codigo_postal As Boolean
        Dim localidad As Boolean
        Dim cif As Boolean


        quantitat_laboratorios = -1
        codigo_laboratorio = False
        laboratorio = False
        direccion = False
        codigo_postal = False
        localidad = False
        cif = False

        Dim settings As New XmlReaderSettings()
        settings.ConformanceLevel = ConformanceLevel.Fragment
        settings.IgnoreWhitespace = True
        settings.IgnoreComments = True
        Dim reader As XmlReader = XmlReader.Create("DICCIONARIO_LABORATORIOS.xml", settings)
        reader.MoveToContent()
        ' Parsja el fitxer i mostra cadascun dels nodes.
        While reader.Read()
            If reader.NodeType = XmlNodeType.Element Then
                Select Case reader.Name
                    Case "laboratorios"
                        quantitat_laboratorios = quantitat_laboratorios + 1
                        ReDim Preserve laboratorios(quantitat_laboratorios)
                    Case "codigolaboratorio"
                        codigo_laboratorio = True
                    Case "laboratorio"
                        laboratorio = True
                    Case "direccion"
                        direccion = True
                    Case "codigopostal"
                        codigo_postal = True
                    Case "localidad"
                        localidad = True
                    Case "cif"
                        cif = True
                End Select
            End If
            If reader.Value <> "" Then
                If codigo_laboratorio Then
                    laboratorios(quantitat_laboratorios).codigo_laboratorio = reader.Value
                    codigo_laboratorio = False
                End If
                If laboratorio Then
                    laboratorios(quantitat_laboratorios).laboratorio = reader.Value
                    laboratorio = False
                End If
                If direccion Then
                    laboratorios(quantitat_laboratorios).direccion = reader.Value
                    direccion = False
                End If
                If codigo_postal Then
                    laboratorios(quantitat_laboratorios).codigo_postal = reader.Value
                    codigo_postal = False
                End If
                If localidad Then
                    laboratorios(quantitat_laboratorios).localidad = reader.Value
                    localidad = False
                End If
                If cif Then
                    laboratorios(quantitat_laboratorios).cif = reader.Value
                    cif = False
                End If

            End If
        End While

        Return laboratorios

    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim principiosactivos() As principio_activo
        principiosactivos = GetPrincipiosActivos()
    End Sub

    Public Function GetPrincipiosActivos()
        Dim principios_activos() As principio_activo
        Dim quantitat_principios_activos As Integer
        Dim nro_principio_activo As Boolean
        Dim codigo_principio_activo As Boolean
        Dim principio_activo As Boolean

        quantitat_principios_activos = -1
        nro_principio_activo = False
        codigo_principio_activo = False
        principio_activo = False

        Dim settings As New XmlReaderSettings()
        settings.ConformanceLevel = ConformanceLevel.Fragment
        settings.IgnoreWhitespace = True
        settings.IgnoreComments = True
        Dim reader As XmlReader = XmlReader.Create("DICCIONARIO_PRINCIPIOS_ACTIVOS.xml", settings)
        reader.MoveToContent()
        ' Parsja el fitxer i mostra cadascun dels nodes.
        While reader.Read()
            If reader.NodeType = XmlNodeType.Element Then
                Select Case reader.Name
                    Case "principiosactivos"
                        quantitat_principios_activos = quantitat_principios_activos + 1
                        ReDim Preserve principios_activos(quantitat_principios_activos)
                    Case "nroprincipioactivo"
                        nro_principio_activo = True
                    Case "codigoprincipioactivo"
                        codigo_principio_activo = True
                    Case "principioactivo"
                        principio_activo = True
                End Select
            End If
            If reader.Value <> "" Then
                If nro_principio_activo Then
                    principios_activos(quantitat_principios_activos).nro_principio_activo = reader.Value
                    nro_principio_activo = False
                End If
                If codigo_principio_activo Then
                    principios_activos(quantitat_principios_activos).codigo_principio_activo = reader.Value
                    codigo_principio_activo = False
                End If
                If principio_activo Then
                    principios_activos(quantitat_principios_activos).principio_activo = reader.Value
                    principio_activo = False
                End If

            End If
        End While

        Return principios_activos

    End Function
End Class