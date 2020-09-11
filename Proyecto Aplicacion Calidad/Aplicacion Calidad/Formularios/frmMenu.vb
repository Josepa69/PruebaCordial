Public Class frmMenu
    Private Sub EvaluacionesPendientesAevaluar_Click(sender As Object, e As EventArgs) Handles EvaluacionesPendientesAevaluar.Click
        frmEvaluador.Show()
    End Sub

    Private Sub CambiarEstadoYObservaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarEstadoYObservaciónToolStripMenuItem.Click
        frmCambioEyO.Show()
    End Sub

    Private Sub ModificarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarDatosToolStripMenuItem.Click
        frmModificarRegistro.Show()
    End Sub
End Class