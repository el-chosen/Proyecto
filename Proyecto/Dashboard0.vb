
Imports System.Windows

Public Class Dashboard
#Region "Funcionalidades del Formulario"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO'
    Dim cGrip As Integer = 10
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                    >= (Me.ClientSize.Width - cGrip)) _
                    AndAlso (pos.Y _
                    >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL' 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15
    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.panelFormularios.Region = region
        Me.Invalidate()
    End Sub
    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR'
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Application.Exit()
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        btn_maximizar.Visible = False
        btn_restaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btn_restaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btn_maximizar.Visible = True
        btn_restaurar.Visible = False
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


#End Region
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()

        Dim Formulario As Form
        Formulario = panelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion'

        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            AddHandler Formulario.FormClosed, AddressOf Me.CerrarForulario

            panelFormularios.Controls.Add(Formulario)
            panelFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_registrar_compra.Click
        AbrirFormEnPanel(Of Compra_Producto)()
        btn_registrar_compra.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_registrar_usuario.Click
        AbrirFormEnPanel(Of Registro_Usuario)()
        btn_registrar_usuario.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub panelFormularios_Paint(sender As Object, e As PaintEventArgs) Handles panelFormularios.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        AbrirFormEnPanel(Of Compra_Producto)()
        btn_reporte.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_log_out.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click
        AbrirFormEnPanel(Of Reporte)()
        btn_log_out.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_registrar_producto.Click
        AbrirFormEnPanel(Of Registro_Producto)()
        btn_registrar_producto.BackColor = Color.FromArgb(12, 61, 92)
    End Sub


    'METODO /EVENTO AL CERRAR FORMS
    Private Sub CerrarForulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'condicion para validar si el formulario esta abierto
        If (Application.OpenForms("Form1") Is Nothing) Then
            btn_registrar_usuario.BackColor = Color.FromArgb(4, 41, 68)
        End If

        If (Application.OpenForms("Form2") Is Nothing) Then
            btn_registrar_producto.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form3") Is Nothing) Then
            btn_registrar_compra.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("Form4") Is Nothing) Then
            btn_reporte.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub

End Class
