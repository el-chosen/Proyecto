Imports System.Data.SqlClient
Public Class frmLogin
    Dim i, j As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            myConn.Open()
            cm = New SqlCommand("uselog", myConn)
            With cm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@user", TextBox1.Text)
                .Parameters.AddWithValue("@pass", TextBox2.Text)
                .Parameters.Add("@res", SqlDbType.Int).Direction = ParameterDirection.Output
                .Parameters.Add("@nivel", SqlDbType.Int).Direction = ParameterDirection.Output
                .ExecuteScalar()

                If CInt(.Parameters("@res").Value = 1) Then
                    MsgBox("Acceso Consedido", MessageBoxIcon.Information)
                ElseIf CInt(.Parameters("@res").Value = 2) Then
                    MessageBox.Show("Error, Usuario o Contraseña no validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MsgBox("Algo que no se pasa", MessageBoxIcon.Information)
                End If
                If CInt(.Parameters("@nivel").Value = 1) Then
                    MsgBox("Bienvenido Administrador" & TextBox1.Text, MessageBoxIcon.Information)
                    'metodo para mostrar el mdi para admins
                ElseIf CInt(.Parameters("@nivel").Value = 2) Then
                    MsgBox("Bienvenido Usuario" & TextBox1.Text, MessageBoxIcon.Information)
                    'metodo para mostrar el mdi para usuarios
                Else
                    MsgBox("Algo que no se pasa", MessageBoxIcon.Information)
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If myConn.State <> ConnectionState.Closed Then
                myConn.Close()
            End If
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        conectarDb()
        ' myConn.Open()
        'MsgBox("conexion realizada con exito", MessageBoxIcon.Information)
        'frmMenu.Show()
        'Me.Hide()
        'Catch ex As Exception
        'MessageBox.Show("Error al establecer la conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally
        'If myConn.State <> ConnectionState.Closed Then
        'myConn.Close()
        'End If
        'End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If i = 0 Then
            TextBox1.UseSystemPasswordChar = False
            i = 1
        ElseIf i = 1 Then
            TextBox1.UseSystemPasswordChar = True
            i = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If j = 0 Then
            TextBox1.UseSystemPasswordChar = False
            j = 1
        ElseIf j = 1 Then
            TextBox1.UseSystemPasswordChar = True
            j = 0
        End If
    End Sub
End Class
