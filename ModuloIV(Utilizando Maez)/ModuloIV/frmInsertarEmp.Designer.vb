<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertarEmp
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
        Me.gboxDatosEmp = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdbOtros = New System.Windows.Forms.RadioButton()
        Me.rdbFemenino = New System.Windows.Forms.RadioButton()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboxDatosEmp.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxDatosEmp
        '
        Me.gboxDatosEmp.Controls.Add(Me.Button1)
        Me.gboxDatosEmp.Controls.Add(Me.dtpFecha)
        Me.gboxDatosEmp.Controls.Add(Me.Label5)
        Me.gboxDatosEmp.Controls.Add(Me.rdbOtros)
        Me.gboxDatosEmp.Controls.Add(Me.rdbFemenino)
        Me.gboxDatosEmp.Controls.Add(Me.rdbMasculino)
        Me.gboxDatosEmp.Controls.Add(Me.Label4)
        Me.gboxDatosEmp.Controls.Add(Me.txtApellido)
        Me.gboxDatosEmp.Controls.Add(Me.Label3)
        Me.gboxDatosEmp.Controls.Add(Me.txtNombre)
        Me.gboxDatosEmp.Controls.Add(Me.Label2)
        Me.gboxDatosEmp.Controls.Add(Me.Label1)
        Me.gboxDatosEmp.Location = New System.Drawing.Point(227, 120)
        Me.gboxDatosEmp.Name = "gboxDatosEmp"
        Me.gboxDatosEmp.Size = New System.Drawing.Size(902, 556)
        Me.gboxDatosEmp.TabIndex = 0
        Me.gboxDatosEmp.TabStop = False
        Me.gboxDatosEmp.Text = "Datos Empleados"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(290, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(284, 53)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(403, 333)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(280, 22)
        Me.dtpFecha.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(149, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha de Nacimiento:"
        '
        'rdbOtros
        '
        Me.rdbOtros.AutoSize = True
        Me.rdbOtros.Location = New System.Drawing.Point(541, 269)
        Me.rdbOtros.Name = "rdbOtros"
        Me.rdbOtros.Size = New System.Drawing.Size(60, 20)
        Me.rdbOtros.TabIndex = 8
        Me.rdbOtros.TabStop = True
        Me.rdbOtros.Text = "Otros"
        Me.rdbOtros.UseVisualStyleBackColor = True
        '
        'rdbFemenino
        '
        Me.rdbFemenino.AutoSize = True
        Me.rdbFemenino.Location = New System.Drawing.Point(422, 270)
        Me.rdbFemenino.Name = "rdbFemenino"
        Me.rdbFemenino.Size = New System.Drawing.Size(88, 20)
        Me.rdbFemenino.TabIndex = 7
        Me.rdbFemenino.TabStop = True
        Me.rdbFemenino.Text = "Femenino"
        Me.rdbFemenino.UseVisualStyleBackColor = True
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Location = New System.Drawing.Point(290, 269)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(89, 20)
        Me.rdbMasculino.TabIndex = 6
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(149, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sexo:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(290, 199)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(339, 22)
        Me.txtApellido.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(290, 126)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(339, 22)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos Empleados"
        '
        'frmInsertarEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1748, 770)
        Me.Controls.Add(Me.gboxDatosEmp)
        Me.Name = "frmInsertarEmp"
        Me.Text = "frmInsertarEmp"
        Me.gboxDatosEmp.ResumeLayout(False)
        Me.gboxDatosEmp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gboxDatosEmp As GroupBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents rdbOtros As RadioButton
    Friend WithEvents rdbFemenino As RadioButton
    Friend WithEvents rdbMasculino As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
