Public Class FormAdministracionRegistros
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLiberacionRegistros.Click
        LiberacionRegistros.ShowDialog()
    End Sub

    Private Sub btnIngresarDatos_Click(sender As Object, e As EventArgs) Handles btnIngresarDatos.Click
        frmLiberacionBloqueados.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FrmLiberaTerminados.ShowDialog()
    End Sub
End Class