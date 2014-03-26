<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaja
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.fecha = New System.Windows.Forms.TextBox
        Me.hora = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Nuevo = New System.Windows.Forms.Button
        Me.Guardar = New System.Windows.Forms.Button
        Me.Salir = New System.Windows.Forms.Button
        Me.Grupo1 = New System.Windows.Forms.GroupBox
        Me.Comentarios = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Importe = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboTipoNota = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboConcepto = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Grupo1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(104, 21)
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Size = New System.Drawing.Size(100, 20)
        Me.fecha.TabIndex = 8
        '
        'hora
        '
        Me.hora.Location = New System.Drawing.Point(278, 21)
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        Me.hora.Size = New System.Drawing.Size(100, 20)
        Me.hora.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hora"
        '
        'Nuevo
        '
        Me.Nuevo.Location = New System.Drawing.Point(23, 271)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Nuevo.TabIndex = 0
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(104, 271)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 1
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(185, 271)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 16
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Grupo1
        '
        Me.Grupo1.Controls.Add(Me.Comentarios)
        Me.Grupo1.Controls.Add(Me.Label5)
        Me.Grupo1.Controls.Add(Me.Importe)
        Me.Grupo1.Controls.Add(Me.Label4)
        Me.Grupo1.Controls.Add(Me.cboTipoNota)
        Me.Grupo1.Controls.Add(Me.Label1)
        Me.Grupo1.Controls.Add(Me.cboConcepto)
        Me.Grupo1.Controls.Add(Me.Label6)
        Me.Grupo1.Enabled = False
        Me.Grupo1.Location = New System.Drawing.Point(12, 47)
        Me.Grupo1.Name = "Grupo1"
        Me.Grupo1.Size = New System.Drawing.Size(437, 204)
        Me.Grupo1.TabIndex = 17
        Me.Grupo1.TabStop = False
        '
        'Comentarios
        '
        Me.Comentarios.Location = New System.Drawing.Point(92, 99)
        Me.Comentarios.Multiline = True
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Size = New System.Drawing.Size(301, 87)
        Me.Comentarios.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Comentarios"
        '
        'Importe
        '
        Me.Importe.Location = New System.Drawing.Point(92, 73)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(100, 20)
        Me.Importe.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Importe"
        '
        'cboTipoNota
        '
        Me.cboTipoNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoNota.FormattingEnabled = True
        Me.cboTipoNota.Items.AddRange(New Object() {"ENTRADA", "SALIDA"})
        Me.cboTipoNota.Location = New System.Drawing.Point(92, 46)
        Me.cboTipoNota.Name = "cboTipoNota"
        Me.cboTipoNota.Size = New System.Drawing.Size(94, 21)
        Me.cboTipoNota.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Tipo Nota"
        '
        'cboConcepto
        '
        Me.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConcepto.FormattingEnabled = True
        Me.cboConcepto.Items.AddRange(New Object() {"CC", "TI", "CE"})
        Me.cboConcepto.Location = New System.Drawing.Point(92, 19)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(301, 21)
        Me.cboConcepto.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Concepto"
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 314)
        Me.Controls.Add(Me.Grupo1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.hora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja"
        Me.Grupo1.ResumeLayout(False)
        Me.Grupo1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.TextBox
    Friend WithEvents hora As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Grupo1 As System.Windows.Forms.GroupBox
    Friend WithEvents Comentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Importe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboTipoNota As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboConcepto As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
