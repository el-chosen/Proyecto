Imports System.Data.SqlClient
Imports System.IO
Imports CDatos
Public Class Registro_Usuario
    Dim OP, CB As String
    Dim N, Nivel, id As Integer
    Dim ms As New MemoryStream

    Private Sub Form2Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarDb()
        Dim sqlDa As SqlDataAdapter
        Dim dtResultado As New DataTable
        Dim sqlQuery As String = "select id,nombre,email,foto from usuarios"
        sqlDa = New SqlDataAdapter(sqlQuery, myConn)
        sqlDa.Fill(dtResultado)
        If dtResultado.Rows.Count <> 0 Then
            DataGridView1.DataSource = dtResultado
        End If
        If myConn.State <> ConnectionState.Closed Then myConn.Close()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OP = "UPDATE"
        If CB = "Chequiador" Then
            Nivel = 2
        ElseIf CB = "Administrador" AndAlso nil = 1 Then
            Nivel = 1
        ElseIf CB = "Facturador" Then
            Nivel = 3
        Else
            Nivel = 0
        End If
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Try
            myConn.Open()
            cm = New SqlCommand("IREUsuario", myConn)
            With cm
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@v_operation", SqlDbType.VarChar, 100).Value = OP
                .Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = TextBox1.Text.Trim()
                .Parameters.Add("@Pass", SqlDbType.VarChar, 50).Value = TextBox2.Text.Trim()
                .Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = TextBox3.Text.Trim()
                If nil = 1 Then
                    .Parameters.Add("@NN", SqlDbType.Int).Value = Nivel
                End If
                .Parameters.Add("@nivel", SqlDbType.Int).Value = nil
                .Parameters.Add("@imagen", SqlDbType.Image).Value = ms.ToArray()
                .Parameters.Add("@fecha", SqlDbType.DateTime2).Value = Date.Now
                .Parameters.Add("@ValidOP", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
                .ExecuteScalar()
                MsgBox(.Parameters("@ValidOP").Value, MessageBoxIcon.Information)

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then
                myConn.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OP = "DELETE"
        If CB = "Chequiador" Then
            Nivel = 2
        ElseIf CB = "Administrador" AndAlso nil = 1 Then
            Nivel = 1
        ElseIf CB = "Facturador" Then
            Nivel = 3
        Else
            Nivel = 0
        End If
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Try
            myConn.Open()
            cm = New SqlCommand("IREUsuario", myConn)
            With cm
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@v_operation", SqlDbType.VarChar, 100).Value = OP
                .Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = TextBox1.Text.Trim()
                .Parameters.Add("@Pass", SqlDbType.VarChar, 50).Value = TextBox2.Text.Trim()
                .Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = TextBox3.Text.Trim()
                If nil = 1 Then
                    .Parameters.Add("@NN", SqlDbType.Int).Value = Nivel
                End If
                .Parameters.Add("@nivel", SqlDbType.Int).Value = nil
                .Parameters.Add("@imagen", SqlDbType.Image).Value = ms.ToArray()
                .Parameters.Add("@fecha", SqlDbType.DateTime2).Value = Date.Now
                .Parameters.Add("@ValidOP", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
                .ExecuteScalar()
                MsgBox(.Parameters("@ValidOP").Value, MessageBoxIcon.Information)

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then
                myConn.Close()
            End If
        End Try
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        OP = "INSERT"
        If CB = "Chequiador" Then
            Nivel = 2
        ElseIf CB = "Administrador" AndAlso nil = 1 Then
            Nivel = 1
        ElseIf CB = "Facturador" Then
            Nivel = 3
        Else
            Nivel = 0
        End If
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Try
            myConn.Open()
            cm = New SqlCommand("IREUsuario", myConn)
            With cm
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@v_operation", SqlDbType.VarChar, 100).Value = OP
                .Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = TextBox1.Text.Trim()
                .Parameters.Add("@Pass", SqlDbType.VarChar, 50).Value = TextBox2.Text.Trim()
                .Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = TextBox3.Text.Trim()
                If nil = 1 Then
                    .Parameters.Add("@NN", SqlDbType.Int).Value = Nivel
                End If
                .Parameters.Add("@nivel", SqlDbType.Int).Value = nil
                .Parameters.Add("@imagen", SqlDbType.Image).Value = ms.ToArray()
                .Parameters.Add("@fecha", SqlDbType.DateTime2).Value = Date.Now
                .Parameters.Add("@ValidOP", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
                .ExecuteScalar()
                MsgBox(.Parameters("@ValidOP").Value, MessageBoxIcon.Information)

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If myConn.State <> ConnectionState.Closed Then
                myConn.Close()
            End If
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim upfot As New OpenFileDialog
        upfot.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        If upfot.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(upfot.FileName)
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CB = ComboBox1.SelectedItem.ToString
    End Sub
End Class