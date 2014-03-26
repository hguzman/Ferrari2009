Imports FerrariDll
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Public Class Form1
    Dim carrito As New DataTable("articulos")
    Private fact As ClaseFacturas
    Dim dr As DataRow
    Dim cn As New MySqlConnection(My.Settings.Cadena_Conexion)
    Dim ds As New DataSet
    Dim fila As Byte
    Dim total As Single


    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        '        ConfiguraTabla()
        carrito.Rows.Clear()
        fact = New ClaseFacturas
        nombre.Text = ""
        direccion.Text = ""
        telefono.Text = ""
        celular.Text = ""
        email.Text = ""
        id.Text = ""
        tipo_doc.Text = ""
        cant.Value = 1
        valor.Text = ""
        ValorAbono.Text = ""
        '        dgdDetalle.cl
        grupo1.Enabled = True
        grupo2.Enabled = True
        Grupo3.Enabled = True
        Nuevo.Enabled = False
        Guardar.Enabled = True
        dgdDetalle.Enabled = True
        tipo_doc.Focus()
    End Sub

    Private Sub id_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles id.Validating
        Dim per As New Personas
        If Len(id.Text) > 0 Then

            per.tipo = tipo_doc.Text
            per.id = id.Text
            If per.search Then
                fact.nombre = per.nombre
                fact.direccion = per.direccion
                fact.telefono = per.telefono
                fact.celular = per.celular

                '        End If
                'If fact.ObtenerCliente(tipo_doc.Text, id.Text) Then
                nombre.Text = per.nombre
                direccion.Text = per.direccion
                telefono.Text = per.telefono
                celular.Text = per.celular
                email.Text = per.email
                fact.tipo = tipo_doc.Text
                fact.id = id.Text
                PEFactura.SetError(id, "")
            Else
                If (Len(id.Text) <> 0 And Len(tipo_doc.Text) <> 0) Then
                    PEFactura.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
                    PEFactura.SetError(id, "Cliente no registrado")
                    'e.Cancel = True 
                    'COloca los textbox vacios
                    nombre.Text = ""
                    direccion.Text = ""
                    telefono.Text = ""
                    celular.Text = ""
                    email.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub productos()
        Dim daproductos As New MySqlDataAdapter("select * from articulos", cn)
        daproductos.Fill(ds, "productos")
        cboProductos.DataSource = ds.Tables("productos")
        cboProductos.DisplayMember = "articulo"
        cboProductos.ValueMember = "cod_articulo"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfiguraTabla()
        productos()
    End Sub

    Private Sub agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar.Click
        Try
            If cant.Text = "" Or valor.Text = "" Then
                MessageBox.Show("Falta llenar datos del detalle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            Else
                dr = carrito.NewRow()
                dr(0) = carrito.Rows.Count + 1
                dr(1) = cboProductos.SelectedValue.ToString
                dr(2) = cboProductos.Text
                dr(3) = cant.Text
                dr(4) = valor.Text
                carrito.Rows.Add(dr)
                totales()
            End If

        Catch ex1 As System.Data.ConstraintException
            MsgBox("El producto ya ha sido seleccionado", MsgBoxStyle.Critical, "Verificar")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try

    End Sub
    Private Sub ConfiguraTabla()
        Dim dc0 As New DataColumn("Item", System.Type.GetType("System.Byte"))
        Dim dc1 As New DataColumn("Codigo", System.Type.GetType("System.String"))
        Dim dc2 As New DataColumn("Descripcion", System.Type.GetType("System.String"))
        Dim dc3 As New DataColumn("Cantidad", System.Type.GetType("System.Int16"))
        Dim dc4 As New DataColumn("PrecioUnitario", System.Type.GetType("System.Decimal"))
        Dim dc5 As New DataColumn("Total", System.Type.GetType("System.Decimal"))
        dc1.Unique = True
        dc5.Expression = "Cantidad*PrecioUnitario"
        With carrito.Columns
            .Add(dc0)
            .Add(dc1)
            .Add(dc2)
            .Add(dc3)
            .Add(dc4)
            .Add(dc5)
        End With
        dgdDetalle.DataSource = carrito

    End Sub
    Private Sub totales()
        Dim i As Integer
        Dim total As Single
        Dim totalp As Single
        For i = 0 To carrito.Rows.Count - 1
            total += carrito.Rows(i)(5)
        Next
        txtfinal.Text = total
        txtfinal.Text = Format(txtfinal.Text, "currency")
        Vletras.Text = "Valor en Letras: " & Letras(total)
        totalp = total - Val(ValorAbono.Text)
        tpagar.Text = Format(totalp, "currency")

        'Me.txtTotal.Text = total
        'igv = total * 19 / 100
        'txtigv.Text = igv.ToString("n1")
        'totalp = total + igv
        'Me.txtfinal.Text = totalp.ToString("n1")
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        Try
            fila = dgdDetalle.CurrentCell.RowIndex
            If fila > -1 And carrito.Rows.Count > 0 Then
                total -= Single.Parse(dgdDetalle.Item(4, fila).Value)
                carrito.Rows.RemoveAt(fila)
                Dim i As Integer
                For i = 0 To carrito.Rows.Count - 1
                    carrito.Rows(i).BeginEdit()
                    carrito.Rows(i)(0) = i + 1
                    carrito.Rows(i).EndEdit()
                Next
                totales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub cant_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'cant.SelectAll()
        cant.Select()
    End Sub
    Private Sub cboProductos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProductos.SelectedIndexChanged
        cant.Text = 1
        valor.Text = ""
    End Sub

    Private Sub id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id.TextChanged
        PEFactura.SetError(id, "")
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        If (Len(id.Text) <> 0 And Len(tipo_doc.Text) <> 0 And carrito.Rows.Count > 0) Then
            If abono.Checked And Val(ValorAbono.Text) <= 0 Then
                MsgBox("Falta Valor del Abono", MsgBoxStyle.Critical, "Verificar")
                Exit Sub
            End If
            If fact.Agregar_Factura(carrito, txtfinal.Text, Val(ValorAbono.Text)) Then
                fact.valorLetras = Vletras.Text
                MsgBox("Datos agregados correctamente", MsgBoxStyle.Information, "Proceso ok")
                grupo1.Enabled = False
                grupo2.Enabled = False
                Grupo3.Enabled = False
                Nuevo.Enabled = True
                Guardar.Enabled = False
                imprimir.Enabled = True
                dgdDetalle.Enabled = False
            End If
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "Verificar")
        End If
    End Sub


    Private Sub ValorAbono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ValorAbono.SelectAll()
    End Sub

    Private Sub abono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abono.CheckedChanged
        If abono.Checked Then
            ValorAbono.Enabled = True
            ValorAbono.Focus()
        Else
            ValorAbono.Enabled = False
        End If

    End Sub

    Private Sub imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprimir.Click
        'Excel 
        '        Dim App As Excel.Application
        '       Dim Book As Excel.Workbook
        '      Dim Hoja As Excel.Worksheet
        '     App = New Excel.Application
        '    Book = App.Workbooks.Open("F:\Compartida\Henry Guzman\Proyectos\Ferrari2009\FERRARI\factura.xlsx")
        '   Hoja = App.Worksheets.Item(1)
        '  'Hoja.Cells(6, 1) = "Hola"
        ' Hoja.PrintOutEx()
        'Book.Save()
        'App.Workbooks.Close()
        'App.Quit()
        If fact.imprimir_factura(carrito) Then
            MsgBox("Datos enviados a la Impresora", MsgBoxStyle.Information, "Proceso ok")
        End If
    End Sub

    Private Sub ValorAbono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorAbono.TextChanged
        totales()
        'ValorAbono.Text = Format(ValorAbono.Text, "currency")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f As New frmPersonas()
        'f.MdiParent = My.Forms.MenuPrincipal
        f.id.Text = Me.id.Text
        f.tipo_doc.Text = Me.tipo_doc.Text
        Me.AddOwnedForm(f)
        'f.ShowDialog()
        f.Show()

        'f.WindowState = FormWindowState.Maximized
        'MenuPrincipal.PersonasToolStripMenuItem.PerformClick()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub cmdBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBusqueda.Click
        Dim Valores() As Object
        Dim lista As New FListaValores
        Dim emp As New Personas
        Valores = lista.ShowListValues(emp.GetListapersonas)
        If Not Valores Is Nothing Then
            Me.tipo_doc.Text = Valores(0).ToString
            Me.id.Text = Valores(1).ToString
            Me.id.Focus()
        End If
    End Sub
End Class
