Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Public Class ClaseFacturas

#Region "Datos Privados de la clase"
    Private _fecha As Date
    Private _SQL As String
    Private _nombre As String
    Private _direccion As String
    Private _telefono As String
    Private _celular As String
    'Private _email As String
    Private _tipo As String
    Private _id As Integer
    Private _numFactura As String
    Private _abono As Single
    Private _valorLetras As String
#End Region

#Region "Propiedades de la clase"
    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property fecha_factura() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property
    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property
    Public Property celular() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property
    Public Property valorLetras() As String
        Get
            Return _valorLetras
        End Get
        Set(ByVal value As String)
            _valorLetras = value
        End Set
    End Property

    '    Public Property email() As String
    '       Get
    '          Return _email
    '     End Get
    '     Set(ByVal value As String)
    '         _email = value
    '     End Set
    ' End Property
#End Region

#Region "Constructores de la clase"
    Public Sub New()
        _fecha = Now.Date
    End Sub
#End Region

#Region "Metodos de la clase"
    Public Function Agregar_Factura(ByVal detalle As DataTable, ByVal subt As Single, ByVal abono As Single) As Boolean
        Dim conx As New MySqlConnection, resp As Boolean = True
        Dim item As Integer
        Dim i As Integer
        Try
            conx.ConnectionString = My.Settings.Cadena_Conexion 'Asigna la cadena de conexion que se encuentra en configuracion del proyecto
            conx.Open() 'Abre la conexion
            Dim Cmd As New MySqlCommand 'Crea la instancia comand
            _SQL = "Insert Into factura (fecha_factura," & _
            "tipo_doc,id,subtotal,abono) values(?fecha,?tipo,?id,?sub,?abono)"
            Cmd.CommandText = _SQL
            Cmd.Parameters.AddWithValue("?fecha", _fecha)
            Cmd.Parameters.AddWithValue("?tipo", _tipo)
            Cmd.Parameters.AddWithValue("?id", _id)
            Cmd.Parameters.AddWithValue("?sub", subt)
            Cmd.Parameters.AddWithValue("?abono", abono)
            _abono = abono
            Cmd.Connection = conx
            Cmd.ExecuteNonQuery()
            _SQL = "select max(nfactura) from factura"
            Cmd.CommandText = _SQL
            item = Cmd.ExecuteScalar
            _numFactura = item

            For i = 0 To detalle.Rows.Count - 1
                Dim cmd3 As New MySqlCommand("insert into detalle_factura(orden,nfactura,cod_articulo,vunitario,cantidad)values(" & i + 1 & ",'" & item & "','" & detalle.Rows(i)(1) & "','" & detalle.Rows(i)(4) & "','" & detalle.Rows(i)(3) & "')", conx)
                cmd3.ExecuteNonQuery()
            Next
            If abono > 0 Then
                Dim caja As New ClaseCaja
                caja.Movimiento_caja(abono, 1, "D", "Abono X Venta Factura N�" & item)

                'Dim cmd4 As New MySqlCommand("insert into caja(fecha_movimiento,cod_concepto,tipo_nota,importe,comentarios,hora_movimiento) values (?fecha,'1','D',?abono,'Ventas',?hora)", conx)
                'cmd4.Parameters.AddWithValue("?fecha", _fecha)
                'cmd4.Parameters.AddWithValue("?abono", abono)
                'cmd4.Parameters.AddWithValue("?hora", Now.TimeOfDay)
                'cmd4.ExecuteNonQuery()

                'Crea el registro de cartera
                Dim cartera As New ClaseCartera
                cartera.registro = _numFactura
                cartera.tipo = _tipo
                cartera.id = _id
                cartera.saldo = (subt - abono)
                cartera.adicionar_cartera()
                '********************************

                'cmd4.CommandText = "insert into cartera(registro,tipo_doc,id,fecha_cuenta,saldo) values (?fact,?tipo,?id,?fechaC,?saldo)"
                'cmd4.Parameters.AddWithValue("?fact", _numFactura)
                'cmd4.Parameters.AddWithValue("?tipo", _tipo)
                'cmd4.Parameters.AddWithValue("?id", _id)
                'cmd4.Parameters.AddWithValue("?fechaC", _fecha)
                'cmd4.Parameters.AddWithValue("?saldo", (subt - abono))
                'cmd4.Connection = conx
                'cmd4.ExecuteNonQuery()
            Else

                Dim caja As New ClaseCaja
                caja.Movimiento_caja(subt, 3, "D", "Pago total Factura N�" & item)

                'Dim cmd4 As New MySqlCommand("insert into caja(fecha_movimiento,cod_concepto,tipo_nota,importe,comentarios,hora_movimiento) values (?fecha,'1','D',?tot,'Ventas',?hora)", conx)
                'cmd4.Parameters.AddWithValue("?fecha", _fecha)
                'cmd4.Parameters.AddWithValue("?tot", subt)
                'cmd4.Parameters.AddWithValue("?hora", Now.TimeOfDay)
                'cmd4.ExecuteNonQuery()
            End If
        Catch ex As MySqlException
            resp = False
        Catch ex As Exception
            resp = False
        Finally
            If conx.State <> ConnectionState.Closed Then
                conx.Close()
            End If
        End Try
        Return resp

    End Function
    Public Function imprimir_factura(ByVal detalle As DataTable) As Boolean
        Dim App As Excel.Application
        Dim Book As Excel.Workbook
        Dim Hoja As Excel.Worksheet
        Dim i As Integer
        Try
            App = New Excel.Application
            Book = App.Workbooks.Open(Environment.CurrentDirectory & "\factura.xlsx")
            Hoja = App.Worksheets.Item(1)
            Hoja.Cells(8, 1) = _nombre
            Hoja.Cells(9, 1) = _direccion
            Hoja.Cells(10, 1) = "Telefono: " & _telefono
            Hoja.Cells(11, 1) = "Celular: " & _celular
            Hoja.Cells(2, 4) = _fecha
            Hoja.Cells(5, 4) = _numFactura
            Hoja.Cells(32, 4) = _abono
            Hoja.Cells(32, 1) = _valorLetras

            For i = 0 To detalle.Rows.Count - 1
                Hoja.Cells(i + 14, 1) = detalle.Rows(i)(2)
                Hoja.Cells(i + 14, 2) = detalle.Rows(i)(3)
                Hoja.Cells(i + 14, 3) = detalle.Rows(i)(4)
            Next

            Hoja.PrintOutEx()
            'Book.Save()
            App.Workbooks.Close()
            App.Quit()
            Return True
        Catch ex As MySqlException
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class
