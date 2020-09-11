Imports System.Data.SqlClient

Public Class LiberacionRegistros
    Dim cnn As New SqlConnection("data source = 190.96.5.67; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    'Dim cnn As New SqlConnection("data source = 152.231.73.174; initial catalog = BASE_GENERAL_CORDIAL; User id= yp; password=Cordial.passs ")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MostrarAgendados(txtId.Text)
    End Sub

    Private Sub listaEjecutivos(ByVal combo As ComboBox)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Gestion].[pa_ListaEjecutivosPorCRM]"
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.CommandText = sql
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            combo.DataSource = miTabla
            combo.DisplayMember = "Ejecutivo"
            combo.ValueMember = "Ejecutivo"
            combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar Ejecutivos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Private Sub MostrarAgendados(ByVal Id As String)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Config].[MostrarRegistrosAgendados]"
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.Parameters.AddWithValue("@c_id", Id)
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            dtgRegistros.DataSource = miTabla

        Catch ex As Exception
            MsgBox("Error Mostrar registros" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LiberarRegistros(ByVal fecha As String, ByVal hora As String, ByVal id As Integer)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[LiberarRegistros]"
        cmd.Parameters.AddWithValue("@fecha", fecha)
        cmd.Parameters.AddWithValue("@hora", hora)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@c_id", id)
        'cmd.Parameters.AddWithValue("@estado", estado)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
            MsgBox("Registro Liberado Correctamente", vbInformation, "Liberacion OK")

        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error Liberar registro: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click


        If cmbHora.SelectedIndex < 0 Then
            MsgBox("Debe ingresar Hora de Agendamiento", vbExclamation, "Liberacion")
            cmbHora.Focus()
            Exit Sub
        End If

        If cmbMinutos.SelectedIndex < 0 Then
            MsgBox("Debe ingresar Minutos de Agendamiento", vbExclamation, "Liberacion")
            cmbMinutos.Focus()
            Exit Sub
        End If

        If chkObs.Checked = True Then
            If txtObs.Text.Trim = "" Then
                MsgBox("Debe ingresar Observacion a modificar", vbExclamation, "Liberacion")
                txtObs.Focus()
                Exit Sub
            End If
        ElseIf chkFono.Checked = True Then
            If txtFono.Text.Trim = "" Then
                MsgBox("Debe ingresar Telefono a llamar", vbExclamation, "Liberacion")
                txtFono.Focus()
                Exit Sub
            ElseIf txtFono.Text.Length < 8 Then
                MsgBox("Debe ingresar un número de 8 dígitos")
                txtFono.Focus()
                Exit Sub
            End If
        ElseIf chkOtroEjecutivo.Checked = True Then
            If cmbEjecutivo.SelectedIndex < 0 Then
                MsgBox("Debe ingresar Ejecutivo nuevo", vbExclamation, "Liberacion")
                cmbEjecutivo.Focus()
                Exit Sub
            End If
        End If

        LiberarRegistros(dtpFecha.Value.ToString("yyyyMMdd"), cmbHora.Text + cmbMinutos.Text, txtId.Text)
        If chkObs.Checked = True Then
            ModificaObservacion(txtObs.Text, txtId.Text)
        End If
        If chkFono.Checked = True Then
            AgregarFono(txtFono.Text, txtId.Text)
        End If
        If chkOtroEjecutivo.Checked = True Then
            ModificaEjecutivo(cmbEjecutivo.Text, txtId.Text)
        End If
        MostrarAgendados(txtId.Text)
        dtpFecha.ResetText()
        limpiarFormulario()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FormMenu.Show()
        Me.Close()
    End Sub

    Private Sub chkObs_CheckedChanged(sender As Object, e As EventArgs) Handles chkObs.CheckedChanged
        If chkObs.Checked = True And txtId.Text IsNot "" Then
            gpbObservacion.Visible = True
        Else
            gpbObservacion.Visible = False
        End If
    End Sub

    Private Sub ModificaObservacion(ByVal texto As String, ByVal id As Integer)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[ModificaObservacion]"
        cmd.Parameters.AddWithValue("@texto", texto)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@c_id", id)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error en modificar la observación: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ModificaEjecutivo(ByVal ejecutivo As String, ByVal id As Integer)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[ModificaEjecutivo]"
        cmd.Parameters.AddWithValue("@Ejecutivo", ejecutivo)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@c_id", id)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
            'If chkObs.Checked = False And txtObs.Text IsNot "" Then
            '    MsgBox("Seguro que desea modificar la Observación?", vbYesNo, "Modificar")
            'End If
        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error en modificar la observación: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFono.CheckedChanged
        If chkFono.Checked = True And txtId.Text IsNot "" Then
            gpbFonoAlternativo.Visible = True
        Else
            gpbFonoAlternativo.Visible = False
        End If
    End Sub

    Private Sub AgregarFono(ByVal fono As String, ByVal id As Integer)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[AgregarNuevoTelefono]"
        cmd.Parameters.AddWithValue("@fono", fono)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@c_id", id)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
            'If chkFono.Checked = False And txtFono.Text IsNot "" Then
            '    MsgBox("Seguro que desea ingresar nuevo teléfono?", vbYesNo, "Ingresar nuevo fono")
            'End If
        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error en ingresar nuevo teléfono: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtFono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFono.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then
            If (e.KeyChar <> vbBack) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub chkOtroEjecutivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkOtroEjecutivo.CheckedChanged
        If chkOtroEjecutivo.Checked = True And txtId.Text.Trim IsNot "" Then
            gpbEjecutivo.Visible = True
        Else
            gpbEjecutivo.Visible = False
        End If
    End Sub

    Private Sub LiberacionRegistros_Load(sender As Object, e As EventArgs) Handles Me.Load

        listaEjecutivos(cmbEjecutivo)
        limpiarFormulario()
    End Sub

    Private Sub limpiarFormulario()
        chkFono.Checked = False
        chkObs.Checked = False
        chkOtroEjecutivo.Checked = False
        gpbEjecutivo.Visible = False
        gpbObservacion.Visible = False
        gpbFonoAlternativo.Visible = False
        cmbEjecutivo.SelectedIndex = -1
        txtObs.Text = ""
        txtFono.Text = ""
        cmbHora.SelectedIndex = -1
        cmbMinutos.SelectedIndex = -1
        txtId.Text = ""
        dtgRegistros.DataSource = Nothing
    End Sub

    Private Sub cmbMinutos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMinutos.SelectedIndexChanged

    End Sub

    Private Sub cmbHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHora.SelectedIndexChanged

    End Sub

    Private Sub lblHorAgendar_Click(sender As Object, e As EventArgs) Handles lblHorAgendar.Click

    End Sub

    Private Sub lblFecAgendar_Click(sender As Object, e As EventArgs) Handles lblFecAgendar.Click

    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged

    End Sub
End Class