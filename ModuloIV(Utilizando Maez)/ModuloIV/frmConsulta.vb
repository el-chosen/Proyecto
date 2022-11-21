Imports System.Data.SqlClient
Public Class frmConsulta
    Private Sub frmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlDa As SqlDataAdapter
        Dim dtResultado As New DataTable
        Dim sqlQuery As String = "select categoryid,categoryName,description, picture from categories"
        sqlDa = New SqlDataAdapter(sqlQuery, myConn)
        sqlDa.Fill(dtResultado)
        If dtResultado.Rows.Count <> 0 Then
            dtgvCategorias.DataSource = dtResultado
        End If
        If myConn.State <> ConnectionState.Closed Then myConn.Close()
        dtgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

End Class