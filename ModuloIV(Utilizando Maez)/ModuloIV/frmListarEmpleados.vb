Imports System.Data.SqlClient
Public Class frmListarEmpleados
    Private Sub frmListarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Dim sql As String
        sql = "SELECT  idEmpleado ,nombre ,apellido ,sexo ,fechaNacimiento FROM Empleados"
        da = New SqlDataAdapter(sql, myConn)
        da.Fill(dt)
        If dt.Rows.Count <> 0 Then
            dtgvEmpleados.DataSource = dt
        End If
        If myConn.State <> ConnectionState.Closed Then myConn.Close()
        dtgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub dtgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvEmpleados.CellClick
        Dim respuesta As String
        Dim nombreEmpleado As String
        nombreEmpleado = dtgvEmpleados(1, e.RowIndex).Value.ToString
        respuesta = MsgBox("Desea actualizar los datos del Empleado " & nombreEmpleado, vbYesNo)
        If respuesta = vbYes Then
            frmInsertarEmp.MdiParent = frmMenu
            frmInsertarEmp.WindowState = FormWindowState.Maximized
            frmInsertarEmp.txtNombre.Text = nombreEmpleado
            frmInsertarEmp.txtApellido.Text = dtgvEmpleados(2, e.RowIndex).Value.ToString
            frmInsertarEmp.Sexo(dtgvEmpleados(3, e.RowIndex).Value.ToString)
            frmInsertarEmp.dtpFecha.Value = dtgvEmpleados(4, e.RowIndex).Value.ToString
            idEmpleado = dtgvEmpleados(0, e.RowIndex).Value.ToString
            frmInsertarEmp.Show()
            accion = "U"
            frmInsertarEmp.Button1.Text = "Actualizar"
        End If
    End Sub
End Class