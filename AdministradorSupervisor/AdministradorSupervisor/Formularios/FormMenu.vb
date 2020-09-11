Public Class FormMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    'Me.Close()
    'End Sub

    Private Sub BtnIngreso_Click(sender As Object, e As EventArgs) Handles BtnIngreso.Click
        Ejecutivos.ShowDialog()
        'FormCampaña.Show()
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Proximamente.ShowDialog()
        FormAdministracionRegistros.ShowDialog()
    End Sub

    Private Sub btnReferidos_Click(sender As Object, e As EventArgs) Handles btnReferidos.Click
        frmCargaReferido.ShowDialog()
    End Sub
End Class
