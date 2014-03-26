<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCartera
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
        Me.id = New System.Windows.Forms.TextBox
        Me.tipo_doc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Consultar = New System.Windows.Forms.Button
        Me.DgvCartera = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Pagar = New System.Windows.Forms.Button
        Me.Salir = New System.Windows.Forms.Button
        CType(Me.DgvCartera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(101, 12)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 4
        '
        'tipo_doc
        '
        Me.tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo_doc.FormattingEnabled = True
        Me.tipo_doc.Items.AddRange(New Object() {"CC", "TI", "CE"})
        Me.tipo_doc.Location = New System.Drawing.Point(50, 12)
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.Size = New System.Drawing.Size(45, 21)
        Me.tipo_doc.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo"
        '
        'Consultar
        '
        Me.Consultar.Location = New System.Drawing.Point(209, 10)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(75, 23)
        Me.Consultar.TabIndex = 5
        Me.Consultar.Text = "Consultar"
        Me.Consultar.UseVisualStyleBackColor = True
        '
        'DgvCartera
        '
        Me.DgvCartera.AllowUserToAddRows = False
        Me.DgvCartera.AllowUserToDeleteRows = False
        Me.DgvCartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCartera.Location = New System.Drawing.Point(17, 51)
        Me.DgvCartera.Name = "DgvCartera"
        Me.DgvCartera.ReadOnly = True
        Me.DgvCartera.Size = New System.Drawing.Size(362, 190)
        Me.DgvCartera.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Salir)
        Me.GroupBox1.Controls.Add(Me.Pagar)
        Me.GroupBox1.Location = New System.Drawing.Point(395, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 190)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Pagar
        '
        Me.Pagar.Location = New System.Drawing.Point(12, 15)
        Me.Pagar.Name = "Pagar"
        Me.Pagar.Size = New System.Drawing.Size(75, 23)
        Me.Pagar.TabIndex = 1
        Me.Pagar.Text = "Pagar"
        Me.Pagar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(12, 44)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 2
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'frmConsultaCartera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 259)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvCartera)
        Me.Controls.Add(Me.Consultar)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.tipo_doc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmConsultaCartera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado Cartera"
        CType(Me.DgvCartera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents tipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Consultar As System.Windows.Forms.Button
    Friend WithEvents DgvCartera As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Pagar As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
End Class
