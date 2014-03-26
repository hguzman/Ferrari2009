<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FerrariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Dst1 = New FerrariForm.dst
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.Dst1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 724)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FerrariToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FerrariToolStripMenuItem
        '
        Me.FerrariToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturarToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.FerrariToolStripMenuItem.Name = "FerrariToolStripMenuItem"
        Me.FerrariToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.FerrariToolStripMenuItem.Text = "&Ferrari"
        '
        'FacturarToolStripMenuItem
        '
        Me.FacturarToolStripMenuItem.Name = "FacturarToolStripMenuItem"
        Me.FacturarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.FacturarToolStripMenuItem.Text = "Facturar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripMenuItem2.Text = "&Cartera"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripMenuItem3.Text = "Caja"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(123, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonasToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MantenimientoToolStripMenuItem.Text = "&Mantenimiento"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.PersonasToolStripMenuItem.Text = "&Personas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'Dst1
        '
        Me.Dst1.DataSetName = "dst"
        Me.Dst1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MenuPrincipal"
        Me.Text = "MenuPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.Dst1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FerrariToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Dst1 As FerrariForm.dst

End Class
