<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarEmpleados
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dtgvEmpleados = New System.Windows.Forms.DataGridView()
        CType(Me.dtgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(610, 38)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(303, 32)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "LISTAR EMPLEADOS"
        '
        'dtgvEmpleados
        '
        Me.dtgvEmpleados.AllowUserToAddRows = False
        Me.dtgvEmpleados.AllowUserToDeleteRows = False
        Me.dtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvEmpleados.Location = New System.Drawing.Point(54, 105)
        Me.dtgvEmpleados.Name = "dtgvEmpleados"
        Me.dtgvEmpleados.ReadOnly = True
        Me.dtgvEmpleados.RowHeadersWidth = 51
        Me.dtgvEmpleados.RowTemplate.Height = 24
        Me.dtgvEmpleados.Size = New System.Drawing.Size(1453, 402)
        Me.dtgvEmpleados.TabIndex = 1
        '
        'frmListarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1574, 648)
        Me.Controls.Add(Me.dtgvEmpleados)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmListarEmpleados"
        Me.Text = "frmListarEmpleados"
        CType(Me.dtgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents dtgvEmpleados As DataGridView
End Class
