<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelFormularios = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btn_log_out = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_rol = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_registrar_compra = New System.Windows.Forms.Button()
        Me.btn_registrar_producto = New System.Windows.Forms.Button()
        Me.btn_registrar_usuario = New System.Windows.Forms.Button()
        Me.panelBarraTitulo = New System.Windows.Forms.Panel()
        Me.btn_restaurar = New System.Windows.Forms.PictureBox()
        Me.btn_maximizar = New System.Windows.Forms.PictureBox()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_cerrar = New System.Windows.Forms.PictureBox()
        Me.panelFormularios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBarraTitulo.SuspendLayout()
        CType(Me.btn_restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelFormularios
        '
        Me.panelFormularios.BackColor = System.Drawing.SystemColors.Control
        Me.panelFormularios.Controls.Add(Me.Label1)
        Me.panelFormularios.Controls.Add(Me.PictureBox1)
        Me.panelFormularios.Controls.Add(Me.panelMenu)
        Me.panelFormularios.Controls.Add(Me.panelBarraTitulo)
        Me.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFormularios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelFormularios.Location = New System.Drawing.Point(0, 0)
        Me.panelFormularios.Name = "panelFormularios"
        Me.panelFormularios.Size = New System.Drawing.Size(1100, 600)
        Me.panelFormularios.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(558, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PPinal Company cia"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Usuario.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(526, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btn_log_out)
        Me.panelMenu.Controls.Add(Me.PictureBox3)
        Me.panelMenu.Controls.Add(Me.btn_reporte)
        Me.panelMenu.Controls.Add(Me.Label3)
        Me.panelMenu.Controls.Add(Me.Label2)
        Me.panelMenu.Controls.Add(Me.lbl_rol)
        Me.panelMenu.Controls.Add(Me.PictureBox2)
        Me.panelMenu.Controls.Add(Me.btn_registrar_compra)
        Me.panelMenu.Controls.Add(Me.btn_registrar_producto)
        Me.panelMenu.Controls.Add(Me.btn_registrar_usuario)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 40)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(240, 560)
        Me.panelMenu.TabIndex = 1
        '
        'btn_log_out
        '
        Me.btn_log_out.FlatAppearance.BorderSize = 0
        Me.btn_log_out.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_log_out.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_log_out.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_log_out.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_log_out.Image = Global.Usuario.My.Resources.Resources.logout__1_1
        Me.btn_log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_log_out.Location = New System.Drawing.Point(0, 503)
        Me.btn_log_out.Name = "btn_log_out"
        Me.btn_log_out.Size = New System.Drawing.Size(230, 45)
        Me.btn_log_out.TabIndex = 10
        Me.btn_log_out.Text = "Log Out"
        Me.btn_log_out.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_log_out.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Usuario.My.Resources.Resources.menu
        Me.PictureBox3.Location = New System.Drawing.Point(201, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'btn_reporte
        '
        Me.btn_reporte.FlatAppearance.BorderSize = 0
        Me.btn_reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reporte.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reporte.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_reporte.Image = Global.Usuario.My.Resources.Resources.bar_graph1
        Me.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reporte.Location = New System.Drawing.Point(10, 293)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(230, 45)
        Me.btn_reporte.TabIndex = 8
        Me.btn_reporte.Text = "Reporte"
        Me.btn_reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_reporte.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(95, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(95, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'lbl_rol
        '
        Me.lbl_rol.AutoSize = True
        Me.lbl_rol.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rol.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_rol.Location = New System.Drawing.Point(96, 46)
        Me.lbl_rol.Name = "lbl_rol"
        Me.lbl_rol.Size = New System.Drawing.Size(23, 13)
        Me.lbl_rol.TabIndex = 5
        Me.lbl_rol.Text = "Rol"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Usuario.My.Resources.Resources.user__1_
        Me.PictureBox2.Location = New System.Drawing.Point(7, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'btn_registrar_compra
        '
        Me.btn_registrar_compra.FlatAppearance.BorderSize = 0
        Me.btn_registrar_compra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_registrar_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btn_registrar_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar_compra.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar_compra.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_registrar_compra.Image = Global.Usuario.My.Resources.Resources.patient__1_1
        Me.btn_registrar_compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_registrar_compra.Location = New System.Drawing.Point(7, 252)
        Me.btn_registrar_compra.Name = "btn_registrar_compra"
        Me.btn_registrar_compra.Size = New System.Drawing.Size(230, 45)
        Me.btn_registrar_compra.TabIndex = 2
        Me.btn_registrar_compra.Text = "Registrar compra"
        Me.btn_registrar_compra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_registrar_compra.UseVisualStyleBackColor = True
        '
        'btn_registrar_producto
        '
        Me.btn_registrar_producto.FlatAppearance.BorderSize = 0
        Me.btn_registrar_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_registrar_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btn_registrar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar_producto.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar_producto.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_registrar_producto.Image = Global.Usuario.My.Resources.Resources.payment1
        Me.btn_registrar_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_registrar_producto.Location = New System.Drawing.Point(7, 211)
        Me.btn_registrar_producto.Name = "btn_registrar_producto"
        Me.btn_registrar_producto.Size = New System.Drawing.Size(230, 45)
        Me.btn_registrar_producto.TabIndex = 1
        Me.btn_registrar_producto.Text = "Registrar Producto"
        Me.btn_registrar_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_registrar_producto.UseVisualStyleBackColor = True
        '
        'btn_registrar_usuario
        '
        Me.btn_registrar_usuario.FlatAppearance.BorderSize = 0
        Me.btn_registrar_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_registrar_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btn_registrar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar_usuario.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar_usuario.ForeColor = System.Drawing.Color.Gainsboro
        Me.btn_registrar_usuario.Image = Global.Usuario.My.Resources.Resources.person_settings1
        Me.btn_registrar_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_registrar_usuario.Location = New System.Drawing.Point(7, 168)
        Me.btn_registrar_usuario.Name = "btn_registrar_usuario"
        Me.btn_registrar_usuario.Size = New System.Drawing.Size(230, 45)
        Me.btn_registrar_usuario.TabIndex = 0
        Me.btn_registrar_usuario.Text = "Registrar Usuario"
        Me.btn_registrar_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_registrar_usuario.UseVisualStyleBackColor = True
        '
        'panelBarraTitulo
        '
        Me.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.panelBarraTitulo.Controls.Add(Me.btn_restaurar)
        Me.panelBarraTitulo.Controls.Add(Me.btn_maximizar)
        Me.panelBarraTitulo.Controls.Add(Me.btn_minimizar)
        Me.panelBarraTitulo.Controls.Add(Me.btn_cerrar)
        Me.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelBarraTitulo.Name = "panelBarraTitulo"
        Me.panelBarraTitulo.Size = New System.Drawing.Size(1100, 40)
        Me.panelBarraTitulo.TabIndex = 0
        '
        'btn_restaurar
        '
        Me.btn_restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_restaurar.Image = Global.Usuario.My.Resources.Resources.Normal
        Me.btn_restaurar.Location = New System.Drawing.Point(1038, 12)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(16, 16)
        Me.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_restaurar.TabIndex = 6
        Me.btn_restaurar.TabStop = False
        Me.btn_restaurar.Visible = False
        '
        'btn_maximizar
        '
        Me.btn_maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maximizar.Image = Global.Usuario.My.Resources.Resources.maximize3
        Me.btn_maximizar.Location = New System.Drawing.Point(1038, 12)
        Me.btn_maximizar.Name = "btn_maximizar"
        Me.btn_maximizar.Size = New System.Drawing.Size(16, 16)
        Me.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_maximizar.TabIndex = 5
        Me.btn_maximizar.TabStop = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimizar.Image = Global.Usuario.My.Resources.Resources.Minimize
        Me.btn_minimizar.Location = New System.Drawing.Point(1006, 12)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(16, 16)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_minimizar.TabIndex = 4
        Me.btn_minimizar.TabStop = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.Image = Global.Usuario.My.Resources.Resources.Close
        Me.btn_cerrar.Location = New System.Drawing.Point(1072, 12)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(16, 16)
        Me.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_cerrar.TabIndex = 2
        Me.btn_cerrar.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 600)
        Me.Controls.Add(Me.panelFormularios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(680, 500)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.panelFormularios.ResumeLayout(False)
        Me.panelFormularios.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBarraTitulo.ResumeLayout(False)
        Me.panelBarraTitulo.PerformLayout()
        CType(Me.btn_restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFormularios As Panel
    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelBarraTitulo As Panel
    Friend WithEvents btn_restaurar As PictureBox
    Friend WithEvents btn_maximizar As PictureBox
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_cerrar As PictureBox
    Friend WithEvents btn_registrar_compra As Button
    Friend WithEvents btn_registrar_producto As Button
    Friend WithEvents btn_registrar_usuario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_reporte As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_rol As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_log_out As Button
End Class
