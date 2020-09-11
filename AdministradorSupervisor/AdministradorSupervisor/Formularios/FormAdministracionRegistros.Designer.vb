<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministracionRegistros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdministracionRegistros))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnLiberacionRegistros = New System.Windows.Forms.Button()
        Me.btnIngresarDatos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Image = Global.AdministradorSupervisor.My.Resources.Resources.volver_2
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.Location = New System.Drawing.Point(230, 431)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(57, 56)
        Me.btnVolver.TabIndex = 11
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnLiberacionRegistros
        '
        Me.btnLiberacionRegistros.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiberacionRegistros.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnLiberacionRegistros.Image = CType(resources.GetObject("btnLiberacionRegistros.Image"), System.Drawing.Image)
        Me.btnLiberacionRegistros.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnLiberacionRegistros.Location = New System.Drawing.Point(106, 74)
        Me.btnLiberacionRegistros.Name = "btnLiberacionRegistros"
        Me.btnLiberacionRegistros.Size = New System.Drawing.Size(278, 69)
        Me.btnLiberacionRegistros.TabIndex = 12
        Me.btnLiberacionRegistros.Text = "Liberacion de Registros"
        Me.btnLiberacionRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLiberacionRegistros.UseVisualStyleBackColor = True
        '
        'btnIngresarDatos
        '
        Me.btnIngresarDatos.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarDatos.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnIngresarDatos.Image = CType(resources.GetObject("btnIngresarDatos.Image"), System.Drawing.Image)
        Me.btnIngresarDatos.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnIngresarDatos.Location = New System.Drawing.Point(106, 279)
        Me.btnIngresarDatos.Name = "btnIngresarDatos"
        Me.btnIngresarDatos.Size = New System.Drawing.Size(278, 69)
        Me.btnIngresarDatos.TabIndex = 13
        Me.btnIngresarDatos.Text = "Liberacion de Bloqueados"
        Me.btnIngresarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnIngresarDatos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.Location = New System.Drawing.Point(106, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 73)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Reciclado de Base"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormAdministracionRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(523, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnIngresarDatos)
        Me.Controls.Add(Me.btnLiberacionRegistros)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "FormAdministracionRegistros"
        Me.Text = "Administracion Registros"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnLiberacionRegistros As Button
    Friend WithEvents btnIngresarDatos As Button
    Friend WithEvents Button1 As Button
End Class
