Imports System.Data.SqlClient
Public Class frmOrdenEmpleado
    Private Sub frmOrdenEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Dim query As String = "Select  employeeid,FirstName+' '+LastName as nombre from Employees"
        da = New SqlDataAdapter(query, myConn)
        da.Fill(dt)
        If dt.Rows.Count <> 0 Then
            With cboEmpleados
                .DataSource = dt
                .ValueMember = "employeeid"
                .DisplayMember = "nombre"
            End With
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim glComand As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        glComand.Connection = myConn
        glComand.CommandText = "Sp_OrdenesAtendidas"
        glComand.Parameters.AddWithValue("@idEmpleado", cboEmpleados.SelectedValue)
        glComand.CommandTimeout = 0
        glComand.CommandType = CommandType.StoredProcedure
        Try
            myConn.Open()
            glComand.ExecuteNonQuery()
            da = New SqlDataAdapter(glComand)
            da.Fill(dt)
            If dt.Rows.Count <> 0 Then
                dtgvOrden.DataSource = dt
                dtgvOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then myConn.Close()
        End Try
    End Sub
End Class