Imports MySql.Data.MySqlClient

Public Class ClaseCartera
#Region "Datos Privados de la clase"
    Private _error As String 'Guarda el texto del error
    Private _numberError As String 'Numero del error cuando se produce
    Private _fecha As Date
    Private _SQL As String
    Private _tipo_id As String
    Private _id As String
    Private _saldo As Double
    Private _registro As Integer
#End Region

#Region "Propiedades de la clase"
    Public Property tipo() As String
        Get
            Return _tipo_id
        End Get
        Set(ByVal value As String)
            _tipo_id = value
        End Set
    End Property
    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property
    Public Property fecha_cuenta() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property
    Public Property saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
        End Set
    End Property
    Public Property registro() As Integer
        Get
            Return _registro
        End Get
        Set(ByVal value As Integer)
            _registro = value
        End Set
    End Property
#End Region

#Region "Constructores de la clase"
    'Public Sub New()
    '    _fecha = Now.Date
    '    '        _registro = registro
    '    '       _tipo_doc = tipo_doc
    '    '      _id = id
    '    '     _tipo_nota = tipo_nota
    '    '    _importe = importe
    'End Sub
#End Region

#Region "Metodos de la clase"
    Public Function adicionar_cartera() As Boolean
        Dim conx As New MySqlConnection, resp As Boolean = True
        Try
            conx.ConnectionString = My.Settings.Cadena_Conexion 'Asigna la cadena de conexion que se encuentra en configuracion del proyecto
            conx.Open() 'Abre la conexion
            Dim Cmd As New MySqlCommand 'Crea la instancia comand
            _SQL = "insert into cartera (registro,tipo_doc," & _
            "id, fecha_cuenta,saldo) values (?reg,?tipo,?id,?fecha,?importe)"
            Cmd.CommandText = _SQL
            Cmd.Parameters.AddWithValue("?fecha", Now.Date)
            Cmd.Parameters.AddWithValue("?reg", _registro)
            Cmd.Parameters.AddWithValue("?tipo", _tipo_id)
            Cmd.Parameters.AddWithValue("?id", _id)
            Cmd.Parameters.AddWithValue("?importe", _saldo)
            Cmd.Connection = conx
            Cmd.ExecuteNonQuery()

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

    Public Function actualiza_saldo(ByVal tipo_nota As String) As Boolean
        Dim conx As New MySqlConnection, resp As Boolean = True
        Try
            conx.ConnectionString = My.Settings.Cadena_Conexion 'Asigna la cadena de conexion que se encuentra en configuracion del proyecto
            conx.Open() 'Abre la conexion
            Dim Cmd As New MySqlCommand 'Crea la instancia comand
            _SQL = "insert into detalle_cartera (registro,tipo_doc," & _
            "id, tipo_nota, fecha_movimiento,importe) values (?reg,?tipo,?id,?nota,?fecha,?importe)"
            Cmd.CommandText = _SQL
            Cmd.Parameters.AddWithValue("?fecha", Now.Date)
            Cmd.Parameters.AddWithValue("?reg", _registro)
            Cmd.Parameters.AddWithValue("?tipo", _tipo_id)
            Cmd.Parameters.AddWithValue("?id", _id)
            Cmd.Parameters.AddWithValue("?nota", tipo_nota)
            Cmd.Parameters.AddWithValue("?importe", _saldo)
            Cmd.Connection = conx
            Cmd.ExecuteNonQuery()
            If tipo_nota = "D" Then
                _SQL = "update cartera set saldo=saldo+?importe " & _
                "where registro=?reg and tipo_doc=?tipo and id=?id)"
            Else
                _SQL = "update cartera set saldo=saldo-?importe " & _
                "where registro=?reg and tipo_doc=?tipo and id=?id"
            End If
            Dim Cmd2 As New MySqlCommand 'Crea la instancia comand
            Cmd2.CommandText = _SQL
            Cmd2.Parameters.AddWithValue("?reg", _registro)
            Cmd2.Parameters.AddWithValue("?tipo", _tipo_id)
            Cmd2.Parameters.AddWithValue("?id", _id)
            Cmd2.Parameters.AddWithValue("?importe", _saldo)
            Cmd2.Connection = conx
            Cmd2.ExecuteNonQuery()

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

    Public Function consulta_cartera() As DataSet
        Dim conDB As New MySqlConnection, resp As DataSet = New DataSet

        Try
            conDB.ConnectionString = My.Settings.Cadena_Conexion
            conDB.Open() 'Abre la conexion
            Dim Cmd As New MySqlCommand
            _SQL = "select registro, fecha_cuenta,saldo " & _
                   "from cartera " & _
                   "where tipo_doc=?tipo and id=?idp and saldo>0"

            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = _SQL
            Cmd.Parameters.AddWithValue("?tipo", _tipo_id)
            Cmd.Parameters.AddWithValue("?idp", _id)
            Cmd.Connection = conDB
            Dim daCartera = New MySqlDataAdapter(Cmd)
            daCartera.Fill(resp, "personas")
        Catch exMysql As MySqlException
            _numberError = exMysql.Number
            _error = exMysql.Message
        Catch ex As Exception
            _error = ex.Message
        End Try
        Return resp
    End Function
    Public ReadOnly Property TextoError() As String
        Get
            Return _error
        End Get
    End Property

    Public ReadOnly Property numberError() As String
        Get
            Return _numberError
        End Get
    End Property

#End Region

End Class
