<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grupo1 = New System.Windows.Forms.GroupBox
        Me.celular = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.email = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.telefono = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.direccion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.nombre = New System.Windows.Forms.TextBox
        Me.cmdBusqueda = New System.Windows.Forms.Button
        Me.id = New System.Windows.Forms.TextBox
        Me.tipo_doc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Salir = New System.Windows.Forms.Button
        Me.imprimir = New System.Windows.Forms.Button
        Me.Guardar = New System.Windows.Forms.Button
        Me.Nuevo = New System.Windows.Forms.Button
        Me.grupo2 = New System.Windows.Forms.GroupBox
        Me.cant = New System.Windows.Forms.NumericUpDown
        Me.Eliminar = New System.Windows.Forms.Button
        Me.agregar = New System.Windows.Forms.Button
        Me.valor = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboProductos = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtfinal = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dgdDetalle = New System.Windows.Forms.DataGridView
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PEFactura = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Grupo3 = New System.Windows.Forms.GroupBox
        Me.ValorAbono = New System.Windows.Forms.TextBox
        Me.abono = New System.Windows.Forms.CheckBox
        Me.tpagar = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Vletras = New System.Windows.Forms.Label
        Me.grupo1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grupo2.SuspendLayout()
        CType(Me.cant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupo1
        '
        Me.grupo1.Controls.Add(Me.celular)
        Me.grupo1.Controls.Add(Me.Label4)
        Me.grupo1.Controls.Add(Me.email)
        Me.grupo1.Controls.Add(Me.Label5)
        Me.grupo1.Controls.Add(Me.telefono)
        Me.grupo1.Controls.Add(Me.Label3)
        Me.grupo1.Controls.Add(Me.direccion)
        Me.grupo1.Controls.Add(Me.Label2)
        Me.grupo1.Controls.Add(Me.Button2)
        Me.grupo1.Controls.Add(Me.nombre)
        Me.grupo1.Controls.Add(Me.cmdBusqueda)
        Me.grupo1.Controls.Add(Me.id)
        Me.grupo1.Controls.Add(Me.tipo_doc)
        Me.grupo1.Controls.Add(Me.Label1)
        Me.grupo1.Enabled = False
        Me.grupo1.Location = New System.Drawing.Point(9, 12)
        Me.grupo1.Name = "grupo1"
        Me.grupo1.Size = New System.Drawing.Size(576, 106)
        Me.grupo1.TabIndex = 2
        Me.grupo1.TabStop = False
        Me.grupo1.Text = " Cliente "
        '
        'celular
        '
        Me.celular.BackColor = System.Drawing.SystemColors.Info
        Me.celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.celular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.celular.Location = New System.Drawing.Point(469, 74)
        Me.celular.Name = "celular"
        Me.celular.ReadOnly = True
        Me.celular.Size = New System.Drawing.Size(101, 20)
        Me.celular.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(424, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Celular"
        '
        'email
        '
        Me.email.BackColor = System.Drawing.SystemColors.Info
        Me.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.email.Location = New System.Drawing.Point(63, 74)
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Size = New System.Drawing.Size(345, 20)
        Me.email.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email"
        '
        'telefono
        '
        Me.telefono.BackColor = System.Drawing.SystemColors.Info
        Me.telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.telefono.Location = New System.Drawing.Point(469, 48)
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Size = New System.Drawing.Size(101, 20)
        Me.telefono.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Telefono"
        '
        'direccion
        '
        Me.direccion.BackColor = System.Drawing.SystemColors.Info
        Me.direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.direccion.Location = New System.Drawing.Point(63, 48)
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Size = New System.Drawing.Size(345, 20)
        Me.direccion.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Direccion"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(537, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.BackColor = System.Drawing.SystemColors.Info
        Me.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nombre.Location = New System.Drawing.Point(259, 22)
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(273, 20)
        Me.nombre.TabIndex = 4
        '
        'cmdBusqueda
        '
        Me.cmdBusqueda.Image = CType(resources.GetObject("cmdBusqueda.Image"), System.Drawing.Image)
        Me.cmdBusqueda.Location = New System.Drawing.Point(220, 17)
        Me.cmdBusqueda.Name = "cmdBusqueda"
        Me.cmdBusqueda.Size = New System.Drawing.Size(33, 29)
        Me.cmdBusqueda.TabIndex = 3
        Me.cmdBusqueda.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(114, 22)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 1
        '
        'tipo_doc
        '
        Me.tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo_doc.FormattingEnabled = True
        Me.tipo_doc.Items.AddRange(New Object() {"CC", "TI", "CE"})
        Me.tipo_doc.Location = New System.Drawing.Point(63, 22)
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.Size = New System.Drawing.Size(45, 21)
        Me.tipo_doc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Salir)
        Me.GroupBox3.Controls.Add(Me.imprimir)
        Me.GroupBox3.Controls.Add(Me.Guardar)
        Me.GroupBox3.Controls.Add(Me.Nuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(593, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(109, 190)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(15, 104)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'imprimir
        '
        Me.imprimir.Enabled = False
        Me.imprimir.Location = New System.Drawing.Point(15, 75)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 2
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(15, 46)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 1
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.Nuevo.Location = New System.Drawing.Point(15, 17)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Nuevo.TabIndex = 0
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'grupo2
        '
        Me.grupo2.Controls.Add(Me.cant)
        Me.grupo2.Controls.Add(Me.Eliminar)
        Me.grupo2.Controls.Add(Me.agregar)
        Me.grupo2.Controls.Add(Me.valor)
        Me.grupo2.Controls.Add(Me.Label8)
        Me.grupo2.Controls.Add(Me.Label7)
        Me.grupo2.Controls.Add(Me.cboProductos)
        Me.grupo2.Controls.Add(Me.Label6)
        Me.grupo2.Enabled = False
        Me.grupo2.Location = New System.Drawing.Point(9, 124)
        Me.grupo2.Name = "grupo2"
        Me.grupo2.Size = New System.Drawing.Size(574, 78)
        Me.grupo2.TabIndex = 3
        Me.grupo2.TabStop = False
        Me.grupo2.Text = " Detalle del Pedido "
        '
        'cant
        '
        Me.cant.Location = New System.Drawing.Point(423, 19)
        Me.cant.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cant.Name = "cant"
        Me.cant.Size = New System.Drawing.Size(40, 20)
        Me.cant.TabIndex = 1
        Me.cant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(142, 46)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 4
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'agregar
        '
        Me.agregar.Location = New System.Drawing.Point(61, 46)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(75, 23)
        Me.agregar.TabIndex = 3
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = True
        '
        'valor
        '
        Me.valor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.valor.Location = New System.Drawing.Point(494, 20)
        Me.valor.Mask = "0000000000"
        Me.valor.Name = "valor"
        Me.valor.Size = New System.Drawing.Size(74, 20)
        Me.valor.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(464, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Valor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(370, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Cantidad"
        '
        'cboProductos
        '
        Me.cboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductos.FormattingEnabled = True
        Me.cboProductos.Items.AddRange(New Object() {"CC", "TI", "CE"})
        Me.cboProductos.Location = New System.Drawing.Point(61, 19)
        Me.cboProductos.Name = "cboProductos"
        Me.cboProductos.Size = New System.Drawing.Size(301, 21)
        Me.cboProductos.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Producto"
        '
        'txtfinal
        '
        Me.txtfinal.BackColor = System.Drawing.SystemColors.Info
        Me.txtfinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfinal.Enabled = False
        Me.txtfinal.Location = New System.Drawing.Point(593, 320)
        Me.txtfinal.Name = "txtfinal"
        Me.txtfinal.ReadOnly = True
        Me.txtfinal.Size = New System.Drawing.Size(108, 20)
        Me.txtfinal.TabIndex = 51
        Me.txtfinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(590, 302)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Total Pagar"
        '
        'dgdDetalle
        '
        Me.dgdDetalle.AllowUserToAddRows = False
        Me.dgdDetalle.AllowUserToDeleteRows = False
        Me.dgdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Column1, Me.Column2, Me.Column4, Me.Column3, Me.Column5})
        Me.dgdDetalle.Enabled = False
        Me.dgdDetalle.Location = New System.Drawing.Point(9, 217)
        Me.dgdDetalle.Name = "dgdDetalle"
        Me.dgdDetalle.Size = New System.Drawing.Size(576, 169)
        Me.dgdDetalle.TabIndex = 49
        '
        'Item
        '
        Me.Item.DataPropertyName = "Item"
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 30
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codigo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Descripcion"
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 220
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 55
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "PrecioUnitario"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Precio U."
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 90
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Total"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 90
        '
        'PEFactura
        '
        Me.PEFactura.ContainerControl = Me
        '
        'Grupo3
        '
        Me.Grupo3.Controls.Add(Me.ValorAbono)
        Me.Grupo3.Controls.Add(Me.abono)
        Me.Grupo3.Enabled = False
        Me.Grupo3.Location = New System.Drawing.Point(593, 217)
        Me.Grupo3.Name = "Grupo3"
        Me.Grupo3.Size = New System.Drawing.Size(108, 77)
        Me.Grupo3.TabIndex = 55
        Me.Grupo3.TabStop = False
        Me.Grupo3.Text = "Abonos Factura"
        '
        'ValorAbono
        '
        Me.ValorAbono.Enabled = False
        Me.ValorAbono.Location = New System.Drawing.Point(15, 42)
        Me.ValorAbono.Name = "ValorAbono"
        Me.ValorAbono.Size = New System.Drawing.Size(80, 20)
        Me.ValorAbono.TabIndex = 56
        '
        'abono
        '
        Me.abono.AutoSize = True
        Me.abono.Location = New System.Drawing.Point(15, 19)
        Me.abono.Name = "abono"
        Me.abono.Size = New System.Drawing.Size(60, 17)
        Me.abono.TabIndex = 55
        Me.abono.Text = "Abonar"
        Me.abono.UseVisualStyleBackColor = True
        '
        'tpagar
        '
        Me.tpagar.BackColor = System.Drawing.SystemColors.Info
        Me.tpagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpagar.Enabled = False
        Me.tpagar.Location = New System.Drawing.Point(593, 361)
        Me.tpagar.Name = "tpagar"
        Me.tpagar.ReadOnly = True
        Me.tpagar.Size = New System.Drawing.Size(108, 20)
        Me.tpagar.TabIndex = 57
        Me.tpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(590, 343)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Saldo Factura"
        '
        'Vletras
        '
        Me.Vletras.AutoSize = True
        Me.Vletras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vletras.ForeColor = System.Drawing.Color.DarkBlue
        Me.Vletras.Location = New System.Drawing.Point(6, 400)
        Me.Vletras.Name = "Vletras"
        Me.Vletras.Size = New System.Drawing.Size(81, 13)
        Me.Vletras.TabIndex = 58
        Me.Vletras.Text = "Valor en Letras:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 427)
        Me.Controls.Add(Me.Vletras)
        Me.Controls.Add(Me.tpagar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Grupo3)
        Me.Controls.Add(Me.txtfinal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgdDetalle)
        Me.Controls.Add(Me.grupo2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grupo1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación"
        Me.grupo1.ResumeLayout(False)
        Me.grupo1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.grupo2.ResumeLayout(False)
        Me.grupo2.PerformLayout()
        CType(Me.cant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo3.ResumeLayout(False)
        Me.Grupo3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupo1 As System.Windows.Forms.GroupBox
    Friend WithEvents celular As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdBusqueda As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents tipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents grupo2 As System.Windows.Forms.GroupBox
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents agregar As System.Windows.Forms.Button
    Friend WithEvents valor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboProductos As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfinal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgdDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents PEFactura As System.Windows.Forms.ErrorProvider
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grupo3 As System.Windows.Forms.GroupBox
    Friend WithEvents abono As System.Windows.Forms.CheckBox
    Friend WithEvents tpagar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Vletras As System.Windows.Forms.Label
    Friend WithEvents imprimir As System.Windows.Forms.Button
    Friend WithEvents ValorAbono As System.Windows.Forms.TextBox
    Friend WithEvents cant As System.Windows.Forms.NumericUpDown
    Friend WithEvents Salir As System.Windows.Forms.Button

End Class
