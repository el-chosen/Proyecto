Imports System.Data.SqlClient
Imports System.Xml
Public Module MConexion

    Public Sub conectarDb()
        Dim cadenaConexion As String = ""
        Dim servidorDb As String = "", nameDB As String = "", usuario As String = "", pass As String = ""
        leerXml(servidorDb, nameDB, usuario, pass)
        cadenaConexion = "data source=" & servidorDb & "; initial catalog=" & nameDB & "; user id=" & usuario & "; password=" & pass
        myConn = New SqlConnection(cadenaConexion)
    End Sub
    Public Sub leerXml(ByRef servidorDb As String, ByRef nameDB As String, ByRef usuario As String, ByRef pass As String)
        Dim archivoXml As XmlTextReader
        archivoXml = New XmlTextReader("../../Archivos/Config.xml")
        archivoXml.Read()
        While Not archivoXml.EOF
            archivoXml.Read()
            If Not archivoXml.IsStartElement Then
                Exit While
            End If
            archivoXml.Read()
            servidorDb = decodeBase64(archivoXml.ReadElementString("serverDB"))
            nameDB = decodeBase64(archivoXml.ReadElementString("dbName"))
            usuario = decodeBase64(archivoXml.ReadElementString("user"))
            pass = decodeBase64(archivoXml.ReadElementString("password"))
        End While
        archivoXml.Close()
    End Sub

    Private Function decodeBase64(ByVal mensaje As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(mensaje))
    End Function

End Module