<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LiberacionRegistros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LiberacionRegistros))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.dtgRegistros = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEjecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idRut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFechaAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdHoraAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecAgendar = New System.Windows.Forms.Label()
        Me.lblHorAgendar = New System.Windows.Forms.Label()
        Me.cmbHora = New System.Windows.Forms.ComboBox()
        Me.cmbMinutos = New System.Windows.Forms.ComboBox()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkObs = New System.Windows.Forms.CheckBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.chkFono = New System.Windows.Forms.CheckBox()
        Me.lblFono = New System.Windows.Forms.Label()
        Me.txtFono = New System.Windows.Forms.TextBox()
        Me.gpbObservacion = New System.Windows.Forms.GroupBox()
        Me.gpbFonoAlternativo = New System.Windows.Forms.GroupBox()
        Me.gpbEjecutivo = New System.Windows.Forms.GroupBox()
        Me.cmbEjecutivo = New System.Windows.Forms.ComboBox()
        Me.lblEjecutivo = New System.Windows.Forms.Label()
        Me.chkOtroEjecutivo = New System.Windows.Forms.CheckBox()
        CType(Me.dtgRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbObservacion.SuspendLayout()
        Me.gpbFonoAlternativo.SuspendLayout()
        Me.gpbEjecutivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id :"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(52, 15)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(93, 20)
        Me.txtId.TabIndex = 1
        '
        'dtgRegistros
        '
        Me.dtgRegistros.AllowUserToAddRows = False
        Me.dtgRegistros.AllowUserToDeleteRows = False
        Me.dtgRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgRegistros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRegistros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.IdEjecutivo, Me.idRut, Me.idNombre, Me.idFechaAgenda, Me.IdHoraAgenda, Me.idEstado})
        Me.dtgRegistros.Location = New System.Drawing.Point(27, 59)
        Me.dtgRegistros.Name = "dtgRegistros"
        Me.dtgRegistros.ReadOnly = True
        Me.dtgRegistros.RowHeadersVisible = False
        Me.dtgRegistros.Size = New System.Drawing.Size(922, 148)
        Me.dtgRegistros.TabIndex = 3
        '
        'Id
        '
        Me.Id.DataPropertyName = "C_ID"
        Me.Id.HeaderText = "C_id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'IdEjecutivo
        '
        Me.IdEjecutivo.DataPropertyName = "Ejecutivo"
        Me.IdEjecutivo.HeaderText = "Ejecutivo"
        Me.IdEjecutivo.Name = "IdEjecutivo"
        Me.IdEjecutivo.ReadOnly = True
        '
        'idRut
        '
        Me.idRut.DataPropertyName = "C_RUT"
        Me.idRut.HeaderText = "Rut"
        Me.idRut.Name = "idRut"
        Me.idRut.ReadOnly = True
        '
        'idNombre
        '
        Me.idNombre.DataPropertyName = "C_NOMBRE"
        Me.idNombre.HeaderText = "Nombre"
        Me.idNombre.Name = "idNombre"
        Me.idNombre.ReadOnly = True
        '
        'idFechaAgenda
        '
        Me.idFechaAgenda.DataPropertyName = "Fecha Agendar"
        Me.idFechaAgenda.HeaderText = "Fecha Agenda"
        Me.idFechaAgenda.Name = "idFechaAgenda"
        Me.idFechaAgenda.ReadOnly = True
        '
        'IdHoraAgenda
        '
        Me.IdHoraAgenda.DataPropertyName = "Hora Agendar"
        Me.IdHoraAgenda.HeaderText = "Hora Agenda"
        Me.IdHoraAgenda.Name = "IdHoraAgenda"
        Me.IdHoraAgenda.ReadOnly = True
        '
        'idEstado
        '
        Me.idEstado.DataPropertyName = "G_ESTADO"
        Me.idEstado.HeaderText = "Estado"
        Me.idEstado.Name = "idEstado"
        Me.idEstado.ReadOnly = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(129, 235)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(131, 20)
        Me.dtpFecha.TabIndex = 4
        '
        'lblFecAgendar
        '
        Me.lblFecAgendar.AutoSize = True
        Me.lblFecAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecAgendar.Location = New System.Drawing.Point(12, 241)
        Me.lblFecAgendar.Name = "lblFecAgendar"
        Me.lblFecAgendar.Size = New System.Drawing.Size(93, 13)
        Me.lblFecAgendar.TabIndex = 5
        Me.lblFecAgendar.Text = "Fecha Agendar"
        '
        'lblHorAgendar
        '
        Me.lblHorAgendar.AutoSize = True
        Me.lblHorAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorAgendar.Location = New System.Drawing.Point(12, 271)
        Me.lblHorAgendar.Name = "lblHorAgendar"
        Me.lblHorAgendar.Size = New System.Drawing.Size(85, 13)
        Me.lblHorAgendar.TabIndex = 6
        Me.lblHorAgendar.Text = "Hora Agendar"
        '
        'cmbHora
        '
        Me.cmbHora.FormattingEnabled = True
        Me.cmbHora.Items.AddRange(New Object() {"09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbHora.Location = New System.Drawing.Point(129, 268)
        Me.cmbHora.Name = "cmbHora"
        Me.cmbHora.Size = New System.Drawing.Size(55, 21)
        Me.cmbHora.TabIndex = 7
        '
        'cmbMinutos
        '
        Me.cmbMinutos.FormattingEnabled = True
        Me.cmbMinutos.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cmbMinutos.Location = New System.Drawing.Point(197, 268)
        Me.cmbMinutos.Name = "cmbMinutos"
        Me.cmbMinutos.Size = New System.Drawing.Size(63, 21)
        Me.cmbMinutos.TabIndex = 8
        '
        'btnLiberar
        '
        Me.btnLiberar.Location = New System.Drawing.Point(146, 312)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(82, 23)
        Me.btnLiberar.TabIndex = 9
        Me.btnLiberar.Text = "Liberar"
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Image = Global.AdministradorSupervisor.My.Resources.Resources.volver_2
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.Location = New System.Drawing.Point(436, 416)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(57, 56)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(167, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkObs
        '
        Me.chkObs.AutoSize = True
        Me.chkObs.Location = New System.Drawing.Point(308, 224)
        Me.chkObs.Name = "chkObs"
        Me.chkObs.Size = New System.Drawing.Size(86, 30)
        Me.chkObs.TabIndex = 12
        Me.chkObs.Text = "Liberar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Observación"
        Me.chkObs.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(6, 34)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(179, 93)
        Me.txtObs.TabIndex = 13
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(3, 17)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(102, 13)
        Me.lblObs.TabIndex = 14
        Me.lblObs.Text = "Nueva Observación"
        '
        'chkFono
        '
        Me.chkFono.AutoSize = True
        Me.chkFono.Location = New System.Drawing.Point(526, 231)
        Me.chkFono.Name = "chkFono"
        Me.chkFono.Size = New System.Drawing.Size(142, 17)
        Me.chkFono.TabIndex = 15
        Me.chkFono.Text = "Agregar Fono alternativo"
        Me.chkFono.UseVisualStyleBackColor = True
        '
        'lblFono
        '
        Me.lblFono.AutoSize = True
        Me.lblFono.Location = New System.Drawing.Point(6, 17)
        Me.lblFono.Name = "lblFono"
        Me.lblFono.Size = New System.Drawing.Size(37, 13)
        Me.lblFono.TabIndex = 17
        Me.lblFono.Text = "Fono :"
        '
        'txtFono
        '
        Me.txtFono.Location = New System.Drawing.Point(9, 34)
        Me.txtFono.MaxLength = 9
        Me.txtFono.Name = "txtFono"
        Me.txtFono.Size = New System.Drawing.Size(87, 20)
        Me.txtFono.TabIndex = 18
        '
        'gpbObservacion
        '
        Me.gpbObservacion.Controls.Add(Me.txtObs)
        Me.gpbObservacion.Controls.Add(Me.lblObs)
        Me.gpbObservacion.Location = New System.Drawing.Point(308, 261)
        Me.gpbObservacion.Name = "gpbObservacion"
        Me.gpbObservacion.Size = New System.Drawing.Size(197, 149)
        Me.gpbObservacion.TabIndex = 19
        Me.gpbObservacion.TabStop = False
        '
        'gpbFonoAlternativo
        '
        Me.gpbFonoAlternativo.Controls.Add(Me.lblFono)
        Me.gpbFonoAlternativo.Controls.Add(Me.txtFono)
        Me.gpbFonoAlternativo.Location = New System.Drawing.Point(526, 261)
        Me.gpbFonoAlternativo.Name = "gpbFonoAlternativo"
        Me.gpbFonoAlternativo.Size = New System.Drawing.Size(197, 149)
        Me.gpbFonoAlternativo.TabIndex = 20
        Me.gpbFonoAlternativo.TabStop = False
        '
        'gpbEjecutivo
        '
        Me.gpbEjecutivo.Controls.Add(Me.cmbEjecutivo)
        Me.gpbEjecutivo.Controls.Add(Me.lblEjecutivo)
        Me.gpbEjecutivo.Location = New System.Drawing.Point(743, 261)
        Me.gpbEjecutivo.Name = "gpbEjecutivo"
        Me.gpbEjecutivo.Size = New System.Drawing.Size(197, 149)
        Me.gpbEjecutivo.TabIndex = 22
        Me.gpbEjecutivo.TabStop = False
        Me.gpbEjecutivo.Visible = False
        '
        'cmbEjecutivo
        '
        Me.cmbEjecutivo.FormattingEnabled = True
        Me.cmbEjecutivo.Location = New System.Drawing.Point(9, 34)
        Me.cmbEjecutivo.Name = "cmbEjecutivo"
        Me.cmbEjecutivo.Size = New System.Drawing.Size(182, 21)
        Me.cmbEjecutivo.TabIndex = 18
        '
        'lblEjecutivo
        '
        Me.lblEjecutivo.AutoSize = True
        Me.lblEjecutivo.Location = New System.Drawing.Point(6, 17)
        Me.lblEjecutivo.Name = "lblEjecutivo"
        Me.lblEjecutivo.Size = New System.Drawing.Size(57, 13)
        Me.lblEjecutivo.TabIndex = 17
        Me.lblEjecutivo.Text = "Ejecutivo :"
        Me.lblEjecutivo.Visible = False
        '
        'chkOtroEjecutivo
        '
        Me.chkOtroEjecutivo.AutoSize = True
        Me.chkOtroEjecutivo.Location = New System.Drawing.Point(743, 231)
        Me.chkOtroEjecutivo.Name = "chkOtroEjecutivo"
        Me.chkOtroEjecutivo.Size = New System.Drawing.Size(128, 17)
        Me.chkOtroEjecutivo.TabIndex = 21
        Me.chkOtroEjecutivo.Text = "Liberar Otro Ejecutivo"
        Me.chkOtroEjecutivo.UseVisualStyleBackColor = True
        '
        'LiberacionRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 484)
        Me.Controls.Add(Me.gpbEjecutivo)
        Me.Controls.Add(Me.chkOtroEjecutivo)
        Me.Controls.Add(Me.gpbFonoAlternativo)
        Me.Controls.Add(Me.gpbObservacion)
        Me.Controls.Add(Me.chkFono)
        Me.Controls.Add(Me.chkObs)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLiberar)
        Me.Controls.Add(Me.cmbMinutos)
        Me.Controls.Add(Me.cmbHora)
        Me.Controls.Add(Me.lblHorAgendar)
        Me.Controls.Add(Me.lblFecAgendar)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.dtgRegistros)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LiberacionRegistros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LiberacionRegistros"
        CType(Me.dtgRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbObservacion.ResumeLayout(False)
        Me.gpbObservacion.PerformLayout()
        Me.gpbFonoAlternativo.ResumeLayout(False)
        Me.gpbFonoAlternativo.PerformLayout()
        Me.gpbEjecutivo.ResumeLayout(False)
        Me.gpbEjecutivo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dtgRegistros As DataGridView
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblFecAgendar As Label
    Friend WithEvents lblHorAgendar As Label
    Friend WithEvents cmbHora As ComboBox
    Friend WithEvents cmbMinutos As ComboBox
    Friend WithEvents btnLiberar As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents IdEjecutivo As DataGridViewTextBoxColumn
    Friend WithEvents idRut As DataGridViewTextBoxColumn
    Friend WithEvents idNombre As DataGridViewTextBoxColumn
    Friend WithEvents idFechaAgenda As DataGridViewTextBoxColumn
    Friend WithEvents IdHoraAgenda As DataGridViewTextBoxColumn
    Friend WithEvents idEstado As DataGridViewTextBoxColumn
    Friend WithEvents btnVolver As Button
    Friend WithEvents chkObs As CheckBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents lblObs As Label
    Friend WithEvents chkFono As CheckBox
    Friend WithEvents lblFono As Label
    Friend WithEvents txtFono As TextBox
    Friend WithEvents gpbObservacion As GroupBox
    Friend WithEvents gpbFonoAlternativo As GroupBox
    Friend WithEvents gpbEjecutivo As GroupBox
    Friend WithEvents cmbEjecutivo As ComboBox
    Friend WithEvents lblEjecutivo As Label
    Friend WithEvents chkOtroEjecutivo As CheckBox
End Class
