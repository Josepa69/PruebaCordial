Imports System.Data.SqlClient

Public Class frmAsociarGrabacion
    Private Sub frmAsociarGrabacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtId.Text = idRegistro
        listarAudiosAsociados(idRegistro, idCRMBase, nombreEjecutivo, idInst)
    End Sub

    Private Sub listarAudiosAsociados(ByVal id As Integer, ByVal crm As String, ByVal ejecutivo As String, ByVal instancia As Integer)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cnn As New SqlConnection("data source = 190.96.5.67; initial catalog = BASE_GENERAL_CORDIAL; User Id= cp; Password=Cordial.passs")
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""

        '    dtgGrabaciones.DataSource = ""
        'dtgGrabaciones.Rows.Clear()

        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Gestion.pa_ListaGrabacionesPorId"
            cmd.Parameters.AddWithValue("@C_ID", id)
            cmd.Parameters.AddWithValue("@idCRm", crm)
            cmd.Parameters.AddWithValue("@ejecutivo", ejecutivo)
            cmd.Parameters.AddWithValue("@idInstancia", instancia)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen datos de grabaciones para mostrar", vbInformation, "")
            End If

            dtgGrabaciones.DataSource = tabla
            dtgGrabaciones.RowHeadersWidth = 60

            For i As Integer = 0 To dtgGrabaciones.Rows.Count - 1
                If dtgGrabaciones.Rows(i).Cells(8).Value = 1 Then
                    dtgGrabaciones.Rows(i).DefaultCellStyle.BackColor = Color.Green
                    dtgGrabaciones.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
            Next

        Catch ex As Exception
            MsgBox("Error Listar Grabaciones Por Id" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        frmControlRegistro.ListarDatosCliente(idRegistro, idInst)
        Me.Close()
    End Sub

    Private Sub dtgGrabaciones_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgGrabaciones.CellMouseMove
        If e.ColumnIndex = 0 Then
            Me.Cursor = Cursors.Hand
        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub dtgGrabaciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgGrabaciones.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            If (MsgBox("¿Desea asociar este audio como el audio de Venta?", vbYesNo, "Asociar Grabacion")) = vbYes Then
                actualizarGrabacion(idRegistro, dtgGrabaciones.Rows(e.RowIndex).Cells(1).Value, idCRMBase, idInst)
            End If

        End If
    End Sub

    Private Sub actualizarGrabacion(ByVal id As Integer, ByVal idLlamada As String, ByVal idCRM As String, ByVal instancia As Integer)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cnn As New SqlConnection("data source = 190.96.5.67; initial catalog = BASE_GENERAL_CORDIAL; User Id= cp; Password=Cordial.passs")
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""



        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Gestion.pa_AsociarGrabacion"
            cmd.Parameters.AddWithValue("@C_ID", id)
            cmd.Parameters.AddWithValue("@IdLlamada", idLlamada)
            cmd.Parameters.AddWithValue("@idCRM", idCRM)
            cmd.Parameters.AddWithValue("@idInstancia", instancia)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            MsgBox("Grabacion asociada correctamente", vbInformation, "Actualización Correcta")
            listarAudiosAsociados(idRegistro, idCRMBase, nombreEjecutivo, idInst)

        Catch ex As Exception
            MsgBox("Error Asociar Grabacion" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

End Class