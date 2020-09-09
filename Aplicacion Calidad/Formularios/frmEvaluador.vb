

Imports System.Data.SqlClient


Public Class frmEvaluador

    Dim cnn As New SqlConnection("data source = 190.96.5.67; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cmbInstancia.SelectedIndex <= 0 Then
            MsgBox("Debe seleccionar una instancia para buscar Registros", vbInformation, "Evaluacion Calidad")
            Exit Sub
        End If

        If chkID.Checked And cmbCampana.Text = "" Then
            MsgBox("Debe seleccionar una campaña para buscar registros por ID", vbInformation, "Evaluacion Calidad")
        Else
            listarVentasAEvaluar(cmbInstancia.SelectedIndex, cmbCampana.SelectedValue, IIf(chkConFecha.Checked = True, 1, 0), dtpFecha.Value.ToString("yyyyMMdd"), IIf(txtID.Text.Trim = "", "0", txtID.Text.Trim), txtTelefono.Text.Trim)
        End If





    End Sub

    Public Sub listarVentasAEvaluar(ByVal idInstancia As Integer, ByVal idCRM As String, ByVal conFecha As Integer, ByVal fecha As String, ByVal id As String, ByVal tel As String)
        ' 
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""



        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Calidad.pa_ListaVentasAEvaluar"
            cmd.Parameters.AddWithValue("@idInstancia", idInstancia)
            cmd.Parameters.AddWithValue("@idCRM", idCRM)
            cmd.Parameters.AddWithValue("@conFecha", conFecha)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@C_id", id)
            cmd.Parameters.AddWithValue("@fono", tel)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen datos de cliente para mostrar", vbInformation, "")
            Else
                dtgVentasEvaluar.DataSource = tabla
            End If

            lblRegistrosAuditar.Text = "Registros a Auditar: " + tabla.Rows.Count.ToString

        Catch ex As Exception
            MsgBox("Error Listar Ventas a Evaluar" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub FormCampaña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaCampañas(cmbCampana)
        chkConFecha.Checked = False
        cmbInstancia.SelectedIndex = 0
        dtgVentasEvaluar.DataSource = Nothing
        chkConFecha.Checked = False
        cmbCampana.Visible = False
        dtpFecha.Visible = False
        txtID.Visible = False
        txtTelefono.Visible = False
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


    Private Sub dtgVentasEvaluar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVentasEvaluar.CellDoubleClick
        idRegistro = dtgVentasEvaluar.Rows(e.RowIndex).Cells(2).Value
        idCRMBase = dtgVentasEvaluar.Rows(e.RowIndex).Cells(0).Value
        idInst = cmbInstancia.SelectedIndex
        frmControlRegistro.ShowDialog()
    End Sub

    Private Sub chkConFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkConFecha.CheckedChanged
        If chkConFecha.Checked = True Then
            dtpFecha.Visible = True
        Else
            dtpFecha.Visible = False
        End If
    End Sub

    Private Sub chkCRM_CheckedChanged(sender As Object, e As EventArgs) Handles chkCRM.CheckedChanged
        If chkCRM.Checked = True Then
            cmbCampana.Visible = True
        Else
            cmbCampana.Visible = False
        End If
    End Sub

    Private Sub chkID_CheckedChanged(sender As Object, e As EventArgs) Handles chkID.CheckedChanged
        If chkID.Checked = True Then
            txtID.Visible = True
            txtID.Text = ""
        Else
            txtID.Visible = False
            txtID.Text = ""
        End If
    End Sub

    Private Sub chkTel_CheckedChanged(sender As Object, e As EventArgs) Handles chkTel.CheckedChanged
        If chkTel.Checked = True Then
            txtTelefono.Visible = True
            txtTelefono.Text = ""
        Else
            txtTelefono.Visible = False
            txtTelefono.Text = ""
        End If
    End Sub


    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then
            If (e.KeyChar <> vbBack) Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then
            If (e.KeyChar <> vbBack) Then
                e.Handled = True
            End If
        End If
    End Sub


End Class