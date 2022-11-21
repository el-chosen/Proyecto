<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenEmpleado
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
        Me.gboxTitulo = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgvOrden = New System.Windows.Forms.DataGridView()
        Me.gboxTitulo.SuspendLayout()
        CType(Me.dtgvOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboxTitulo
        '
        Me.gboxTitulo.Controls.Add(Me.Button1)
        Me.gboxTitulo.Controls.Add(Me.cboEmpleados)
        Me.gboxTitulo.Controls.Add(Me.Label2)
        Me.gboxTitulo.Controls.Add(Me.Label1)
        Me.gboxTitulo.Location = New System.Drawing.Point(326, 46)
        Me.gboxTitulo.Name = "gboxTitulo"
        Me.gboxTitulo.Size = New System.Drawing.Size(1142, 213)
        Me.gboxTitulo.TabIndex = 0
        Me.gboxTitulo.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(789, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboEmpleados
        '
        Me.cboEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpleados.FormattingEnabled = True
        Me.cboEmpleados.Location = New System.Drawing.Point(424, 88)
        Me.cboEmpleados.Name = "cboEmpleados"
        Me.cboEmpleados.Size = New System.Drawing.Size(359, 39)
        Me.cboEmpleados.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empleado "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(586, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ordenes Atendidas por un Empleado"
        '
        'dtgvOrden
        '
        Me.dtgvOrden.AllowUserToAddRows = False
        Me.dtgvOrden.AllowUserToDeleteRows = False
        Me.dtgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvOrden.Location = New System.Drawing.Point(77, 312)
        Me.dtgvOrden.Name = "dtgvOrden"
        Me.dtgvOrden.ReadOnly = True
        Me.dtgvOrden.RowHeadersWidth = 51
        Me.dtgvOrden.RowTemplate.Height = 24
        Me.dtgvOrden.Size = New System.Drawing.Size(1604, 321)
        Me.dtgvOrden.TabIndex = 1
        '
        'frmOrdenEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1730, 727)
        Me.Controls.Add(Me.dtgvOrden)
        Me.Controls.Add(Me.gboxTitulo)
        Me.Name = "frmOrdenEmpleado"
        Me.Text = "frmOrdenEmpleado"
        Me.gboxTitulo.ResumeLayout(False)
        Me.gboxTitulo.PerformLayout()
        CType(Me.dtgvOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gboxTitulo As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cboEmpleados As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtgvOrden As DataGridView
End Class
