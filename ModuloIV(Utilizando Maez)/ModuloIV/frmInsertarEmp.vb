Imports System.Data.SqlClient
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class frmInsertarEmp

    Private Sub validar(ByVal cajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 39 Or Asc(e.KeyChar) = 61 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        validar(txtNombre, e)
    End Sub
    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        validar(txtApellido, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fechaNaci As String = dtpFecha.Value.ToString("yyyy-MM-dd")
        Dim sexo As String = "", hostName As String = "", direIp As String = ""
        buscarSexoyIp(sexo, hostName, direIp)
        If accion = "I" Then
            insertarDatosEmpleados(sexo, hostName, direIp, fechaNaci)
        Else
            actualizarDatos(sexo, hostName, direIp, fechaNaci)
        End If
    End Sub
    Public Sub Sexo(ByVal sexo As String)
        If sexo = "M" Then
            rdbMasculino.Checked = True
        ElseIf sexo = "F" Then
            rdbFemenino.Checked = True
        ElseIf sexo = "O" Then
            rdbOtros.Checked = True
        End If
    End Sub

    Public Sub buscarSexoyIp(ByRef sexo As String, ByRef hostName As String, ByRef direIp As String)
        hostName = Dns.GetHostName
        Dim localIp As IPHostEntry = Dns.GetHostEntry(hostName)
        direIp = localIp.AddressList(1).ToString
        If rdbFemenino.Checked Then
            sexo = "F"
        ElseIf rdbMasculino.Checked Then
            sexo = "M"
        ElseIf rdbOtros.Checked Then
            sexo = "O"
        End If
    End Sub

    Public Sub insertarDatosEmpleados(ByVal sexo As String, ByVal hostName As String, ByVal direIp As String, ByVal fechaNaci As String)
        Dim sqComand As New SqlCommand
        Dim mytrans As SqlTransaction
        Dim idEmpleado As Integer
        Dim sql As String
        myConn.Open()
        mytrans = myConn.BeginTransaction()
        sqComand.Connection = myConn
        sql = "INSERT INTO Empleados (nombre ,apellido ,sexo,fechaNacimiento ,fecha_creacion ,host_creacion ,ip_creacion) "
        sql += "VALUES (@nombre ,@apellido ,@sexo,@fechaNacimiento,@fecha_creacion,@host_creacion ,@ip_creacion) "
        sql += "; Select cast(scope_identity() as int)"
        sqComand.CommandText = sql
        sqComand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text
        sqComand.Parameters.Add("@apellido", SqlDbType.VarChar).Value = txtApellido.Text
        sqComand.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo
        sqComand.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = fechaNaci
        sqComand.Parameters.Add("@fecha_creacion", SqlDbType.DateTime).Value = DateTime.Now
        sqComand.Parameters.Add("@host_creacion", SqlDbType.VarChar).Value = hostName
        sqComand.Parameters.Add("@ip_creacion", SqlDbType.VarChar).Value = direIp
        Try
            sqComand.Transaction = mytrans
            idEmpleado = CType(sqComand.ExecuteScalar(), Integer)
            MsgBox("Registo No " & idEmpleado)
            mytrans.Commit()
        Catch ex As Exception
            MessageBox.Show("Error al Ejecutar" & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mytrans.Rollback()
        Finally
            If myConn.State <> ConnectionState.Closed Then myConn.Close()
        End Try

    End Sub

    Public Sub actualizarDatos(ByVal sexo As String, ByVal hostName As String, ByVal direIp As String, ByVal fechaNaci As String)
        Dim sqComand As New SqlCommand
        Dim mytrans As SqlTransaction
        Dim sql As String
        sql = "UPDATE Empleados   SET nombre = @nombre ,apellido = @apellido ,sexo = @sexo ,fechaNacimiento = @fechaNacimiento "
        sql &= " ,fecha_modificacion = @fecha_modi ,host_modificacion = @host_modi  ,ip_modificacion = @ip_modi  WHERE idEmpleado=@idEmpleado"
        myConn.Open()
        mytrans = myConn.BeginTransaction
        sqComand.Connection = myConn
        sqComand.CommandText = sql
        sqComand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text
        sqComand.Parameters.Add("@apellido", SqlDbType.VarChar).Value = txtApellido.Text
        sqComand.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo
        sqComand.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = fechaNaci
        sqComand.Parameters.Add("@fecha_modi", SqlDbType.DateTime).Value = DateTime.Now
        sqComand.Parameters.Add("@host_modi", SqlDbType.VarChar).Value = hostName
        sqComand.Parameters.Add("@ip_modi", SqlDbType.VarChar).Value = direIp
        sqComand.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado
        Try
            sqComand.Transaction = mytrans
            sqComand.ExecuteNonQuery()
            mytrans.Commit()
            MsgBox("Datos actulizados correctamente ")
        Catch ex As Exception
            MessageBox.Show("Error al Ejecutar" & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mytrans.Rollback()
        Finally
            If myConn.State <> ConnectionState.Closed Then myConn.Close()
        End Try
    End Sub


End Class