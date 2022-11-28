Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports CDatos
Public Class Login
#Region "Close and Minimize Form - Cerrar y Minimizar Formulario"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


#End Region
#Region "Drag Form - Arrastrar/ mover Formulario"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


#End Region
#Region "Customize Controls - Personalizar Controles"
    Dim i, j As Integer
    Private Sub CustomizeComponents()
        'txtUser
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 30)
        'txtPass
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 30)
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            myConn.Open()
            cm = New SqlCommand("splogin", myConn)
            With cm
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@Username", txtUser.Text)
                .Parameters.AddWithValue("@Pass", txtPass.Text)
                .Parameters.Add("@ValidLogin", SqlDbType.Int).Direction = ParameterDirection.Output
                .Parameters.Add("@Nivel", SqlDbType.Int).Direction = ParameterDirection.Output
                .ExecuteScalar()

                If CInt(.Parameters("@ValidLogin").Value = 1) Then
                    MsgBox("Acceso Consedido", MessageBoxIcon.Information)
                ElseIf CInt(.Parameters("@ValidLogin").Value = 0) Then
                    MessageBox.Show("Error, Usuario o Contraseña no validas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MsgBox("Algo que no se, kagada", MessageBoxIcon.Information)
                End If
                If CInt(.Parameters("@Nivel").Value = 1) Then
                    nil = .Parameters("@Nivel").Value
                    MsgBox("Bienvenido Administrador " & txtUser.Text, MessageBoxIcon.Information)
                    'metodo para mostrar el mdi para admins
                    Dashboard.Show()
                    Me.Hide()
                ElseIf CInt(.Parameters("@Nivel").Value = 2) Then
                    nil = .Parameters("@Nivel").Value
                    MsgBox("Bienvenido Inventario " & txtUser.Text, MessageBoxIcon.Information)
                    'metodo para mostrar el mdi para admins
                    Dashboard.Show()
                    Me.Hide()
                ElseIf CInt(.Parameters("@Nivel").Value = 3) Then
                    nil = .Parameters("@Nivel").Value
                    MsgBox("Bienvenid@ Cajer@ " & txtUser.Text, MessageBoxIcon.Information)
                    'metodo para mostrar el mdi para admins
                    Dashboard.Show()
                    Me.Hide()
                ElseIf CInt(.Parameters("@nivel").Value = 0) Then
                    nil = .Parameters("@Nivel").Value
                    MsgBox("Bienvenido Usuario " & txtUser.Text, MessageBoxIcon.Information)
                    'metodo para mostrar el mdi para usuarios
                    Usuario.Show()
                    Me.Hide()
                Else
                    MsgBox("no se puede confirmar el nivel de seguridad del usuario", MessageBoxIcon.Information)
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
        conectarDb()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If i = 0 Then
            txtUser.UseSystemPasswordChar = False
            i = 1
        ElseIf i = 1 Then
            txtUser.UseSystemPasswordChar = True
            i = 0
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If j = 0 Then
            txtPass.UseSystemPasswordChar = False
            j = 1
        ElseIf j = 1 Then
            txtPass.UseSystemPasswordChar = True
            j = 0
        End If
    End Sub
#End Region
End Class
