Imports System.Data.SqlClient

Public Class FormCampaña
    Dim bandera As Boolean

    Private Sub Actualiza_Cel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bandera = False
    End Sub

    'Private Sub BtCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCerrar.Click
    '    bandera = True
    '    Close()
    'End Sub

    Private Sub Actualiza_Cel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If bandera = False Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Dim cnn As New SqlConnection("data source = 190.96.5.67; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")

    Private Sub FormCampaña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaCampañas(cmbListaCampaña)
    End Sub

    Private Sub ListaCampañas(ByVal combo As ComboBox)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "dbo.ListaCampañasActivas"
            cmd.CommandText = sql
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            combo.DataSource = miTabla
            combo.DisplayMember = "Nombre"
            combo.ValueMember = "CRM"
            combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar Campañas" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click


        If cmbListaCampaña.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar campaña", vbExclamation)
            Exit Sub
        End If
        idCrm = cmbListaCampaña.SelectedValue


        'MsgBox("El CRM seleccionado es " & idCrm)
        'Me.Close()
        FormMenu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.Close()
        'Me.Hide()
        End
    End Sub
End Class
