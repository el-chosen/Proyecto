Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.Close()
    End Sub
    Private Sub ConsultaDataGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDataGridToolStripMenuItem.Click
        frmConsulta.MdiParent = Me
        frmConsulta.WindowState = FormWindowState.Maximized
        frmConsulta.Show()
        frmConsulta.lblTitulo.Left = Me.Width / 2 - (frmConsulta.lblTitulo.Width / 2)
        frmConsulta.dtgvCategorias.Left = Me.Width / 2 - (frmConsulta.dtgvCategorias.Width / 2)

    End Sub
    Private Sub ComboDataGridSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComboDataGridSPToolStripMenuItem.Click
        frmOrdenEmpleado.MdiParent = Me
        frmOrdenEmpleado.WindowState = FormWindowState.Maximized
        frmOrdenEmpleado.Show()
        frmOrdenEmpleado.gboxTitulo.Left = Me.Width / 2 - (frmOrdenEmpleado.gboxTitulo.Width / 2)
        frmOrdenEmpleado.dtgvOrden.Left = Me.Width / 2 - (frmOrdenEmpleado.dtgvOrden.Width / 2)
    End Sub

    Private Sub InsertarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarEmpleadosToolStripMenuItem.Click
        frmInsertarEmp.MdiParent = Me
        frmInsertarEmp.WindowState = FormWindowState.Maximized
        frmInsertarEmp.Show()
        frmInsertarEmp.gboxDatosEmp.Left = Me.Width / 2 - (frmInsertarEmp.gboxDatosEmp.Width / 2)
        accion = "I"
    End Sub

    Private Sub ListarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarEmpleadosToolStripMenuItem.Click
        frmListarEmpleados.MdiParent = Me
        frmListarEmpleados.WindowState = FormWindowState.Maximized
        frmListarEmpleados.Show()
        frmListarEmpleados.lblTitulo.Left = Me.Width / 2 - (frmListarEmpleados.lblTitulo.Width / 2)
        frmListarEmpleados.dtgvEmpleados.Left = Me.Width / 2 - (frmListarEmpleados.dtgvEmpleados.Width / 2)
    End Sub
End Class