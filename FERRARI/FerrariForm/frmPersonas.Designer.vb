<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonas
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
        Me.components = New System.ComponentModel.Container
        Me.Grupo1 = New System.Windows.Forms.GroupBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCelular = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.id = New System.Windows.Forms.TextBox
        Me.tipo_doc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CargarFoto = New System.Windows.Forms.Button
        Me.PicFoto = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Salir = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Editar = New System.Windows.Forms.Button
        Me.Nuevo = New System.Windows.Forms.Button
        Me.Buscar = New System.Windows.Forms.Button
        Me.Guardar = New System.Windows.Forms.Button
        Me.CuadroDialogo = New System.Windows.Forms.OpenFileDialog
        Me.PError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Grupo1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grupo1
        '
        Me.Grupo1.Controls.Add(Me.txtEmail)
        Me.Grupo1.Controls.Add(Me.Label6)
        Me.Grupo1.Controls.Add(Me.txtCelular)
        Me.Grupo1.Controls.Add(Me.Label5)
        Me.Grupo1.Controls.Add(Me.txtTelefono)
        Me.Grupo1.Controls.Add(Me.Label4)
        Me.Grupo1.Controls.Add(Me.txtDireccion)
        Me.Grupo1.Controls.Add(Me.Label3)
        Me.Grupo1.Controls.Add(Me.txtNombre)
        Me.Grupo1.Controls.Add(Me.Label2)
        Me.Grupo1.Controls.Add(Me.id)
        Me.Grupo1.Controls.Add(Me.tipo_doc)
        Me.Grupo1.Controls.Add(Me.Label1)
        Me.Grupo1.Enabled = False
        Me.Grupo1.Location = New System.Drawing.Point(18, 17)
        Me.Grupo1.Name = "Grupo1"
        Me.Grupo1.Size = New System.Drawing.Size(449, 200)
        Me.Grupo1.TabIndex = 0
        Me.Grupo1.TabStop = False
        Me.Grupo1.Text = " Datos Basicos "
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(70, 123)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(365, 20)
        Me.txtEmail.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Email"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(287, 97)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(148, 20)
        Me.txtCelular.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Celular"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(70, 97)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(148, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Telefono"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(70, 71)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(365, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dirección"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(70, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(365, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(121, 19)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(97, 20)
        Me.id.TabIndex = 1
        '
        'tipo_doc
        '
        Me.tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo_doc.FormattingEnabled = True
        Me.tipo_doc.Items.AddRange(New Object() {"CC", "TI", "CE"})
        Me.tipo_doc.Location = New System.Drawing.Point(70, 19)
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.Size = New System.Drawing.Size(42, 21)
        Me.tipo_doc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CargarFoto)
        Me.GroupBox2.Controls.Add(Me.PicFoto)
        Me.GroupBox2.Location = New System.Drawing.Point(473, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 200)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Fotografia "
        '
        'CargarFoto
        '
        Me.CargarFoto.Enabled = False
        Me.CargarFoto.Location = New System.Drawing.Point(27, 177)
        Me.CargarFoto.Name = "CargarFoto"
        Me.CargarFoto.Size = New System.Drawing.Size(98, 23)
        Me.CargarFoto.TabIndex = 23
        Me.CargarFoto.Text = "Cargar Foto"
        Me.CargarFoto.UseVisualStyleBackColor = True
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(16, 19)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(121, 152)
        Me.PicFoto.TabIndex = 22
        Me.PicFoto.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Salir)
        Me.GroupBox3.Controls.Add(Me.Cancelar)
        Me.GroupBox3.Controls.Add(Me.Editar)
        Me.GroupBox3.Controls.Add(Me.Nuevo)
        Me.GroupBox3.Controls.Add(Me.Buscar)
        Me.GroupBox3.Controls.Add(Me.Guardar)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(611, 47)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(470, 19)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(74, 20)
        Me.Salir.TabIndex = 5
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Enabled = False
        Me.Cancelar.Location = New System.Drawing.Point(390, 19)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(74, 20)
        Me.Cancelar.TabIndex = 4
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Editar
        '
        Me.Editar.Enabled = False
        Me.Editar.Location = New System.Drawing.Point(310, 19)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(74, 20)
        Me.Editar.TabIndex = 3
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.Nuevo.Location = New System.Drawing.Point(71, 19)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(74, 20)
        Me.Nuevo.TabIndex = 0
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(230, 19)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(74, 20)
        Me.Buscar.TabIndex = 1
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(150, 19)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(74, 20)
        Me.Guardar.TabIndex = 1
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'CuadroDialogo
        '
        Me.CuadroDialogo.FileName = "OpenFileDialog1"
        Me.CuadroDialogo.Filter = "Archivos de Fotos (*.jpg)|*.jpg"
        '
        'PError
        '
        Me.PError.ContainerControl = Me
        '
        'frmPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 293)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Grupo1)
        Me.Name = "frmPersonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personas"
        Me.Grupo1.ResumeLayout(False)
        Me.Grupo1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grupo1 As System.Windows.Forms.GroupBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents tipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents CargarFoto As System.Windows.Forms.Button
    Friend WithEvents CuadroDialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Editar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents PError As System.Windows.Forms.ErrorProvider
End Class
