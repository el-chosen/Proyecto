<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.mstrMenu = New System.Windows.Forms.MenuStrip()
        Me.ConsultaDataGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboDataGridSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstrMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstrMenu
        '
        Me.mstrMenu.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstrMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mstrMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDataGridToolStripMenuItem, Me.ComboDataGridSPToolStripMenuItem, Me.InsertarEmpleadosToolStripMenuItem, Me.ListarEmpleadosToolStripMenuItem})
        Me.mstrMenu.Location = New System.Drawing.Point(0, 0)
        Me.mstrMenu.Name = "mstrMenu"
        Me.mstrMenu.Size = New System.Drawing.Size(1387, 45)
        Me.mstrMenu.TabIndex = 1
        Me.mstrMenu.Text = "MenuStrip1"
        '
        'ConsultaDataGridToolStripMenuItem
        '
        Me.ConsultaDataGridToolStripMenuItem.Name = "ConsultaDataGridToolStripMenuItem"
        Me.ConsultaDataGridToolStripMenuItem.Size = New System.Drawing.Size(310, 41)
        Me.ConsultaDataGridToolStripMenuItem.Text = "Consulta+DataGrid"
        '
        'ComboDataGridSPToolStripMenuItem
        '
        Me.ComboDataGridSPToolStripMenuItem.Name = "ComboDataGridSPToolStripMenuItem"
        Me.ComboDataGridSPToolStripMenuItem.Size = New System.Drawing.Size(344, 41)
        Me.ComboDataGridSPToolStripMenuItem.Text = "Combo+DataGrid+SP"
        '
        'InsertarEmpleadosToolStripMenuItem
        '
        Me.InsertarEmpleadosToolStripMenuItem.Name = "InsertarEmpleadosToolStripMenuItem"
        Me.InsertarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(309, 41)
        Me.InsertarEmpleadosToolStripMenuItem.Text = "Insertar Empleados"
        '
        'ListarEmpleadosToolStripMenuItem
        '
        Me.ListarEmpleadosToolStripMenuItem.Name = "ListarEmpleadosToolStripMenuItem"
        Me.ListarEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(279, 41)
        Me.ListarEmpleadosToolStripMenuItem.Text = "Listar Empleados"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 624)
        Me.Controls.Add(Me.mstrMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mstrMenu
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mstrMenu.ResumeLayout(False)
        Me.mstrMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstrMenu As MenuStrip
    Friend WithEvents ConsultaDataGridToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboDataGridSPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarEmpleadosToolStripMenuItem As ToolStripMenuItem
End Class
