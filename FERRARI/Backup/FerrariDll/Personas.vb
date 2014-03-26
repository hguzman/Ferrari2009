Imports MySql.Data.MySqlClient

Public Class Personas
    Implements Isql

#Region "Variable Privadas"
    Private _error As String 'Guarda el texto del error
    Private _numberError As String 'Numero del error cuando se produce
    Private _tipo_id As String 'Tipo de identificacion
    Private _id As Integer 'Número de identificacion
    Private _nombre As String 'Nombre completo de la persona
    Private _direccion As String
    Private _telefono As String
    Private _celular As String
    Private _email As String
    Private _foto As String
    Private _SQL As String
#End Region

#Region "Contructores"

#End Region

#Region "Propiedades"
    Public Property tipo() As String
        Get
            Return _tipo_id
        End Get
        Set(ByVal value As String)
            _tipo_id = value
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
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Public Property foto() As String
        Get
            Return _foto
        End Get
        Set(ByVal value As String)
            _foto = value
        End Set
    End Property
#End Region

    Public Function insert() As Boolean Implements Isql.insert
        Try
            Dim conX As New MySqlConnection
            conX.ConnectionString = My.Settings.Cadena_Conexion
            conX.Open() 'Abre la conexion
            Dim Cmd As New MySqlCommand
            _SQL = "insert into personas (tipo_doc,id,nombre,direccion,telefono,celular,email,foto)" & _
                    "values(?tipo,?idp,ucase(?nom),?dir,?tel,?cel,?mail,?fotop);"
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = _SQL
            Cmd.Parameters.AddWithValue("?tipo", _tipo_id)
            Cmd.Parameters.AddWithValue("?idp", _id)
            Cmd.Parameters.AddWithValue("?nom", _nombre)
            Cmd.Parameters.AddWithValue("?dir", _direccion)
            Cmd.Parameters.AddWithValue("?tel", _telefono)
            Cmd.Parameters.AddWithValue("?cel", _celular)
            Cmd.Parameters.AddWithValue("?mail", _email)
            Cmd.Parameters.AddWithValue("?fotop", _foto)
            Cmd.Connection = conX
            Cmd.ExecuteNonQuery()
            Return True
        Catch exMysql As MySqlException
            _numberError = exMysql.Number
            _error = exMysql.Message
            Return False
        End Try
    End Function

    Public ReadOnly Property TextoError() As String Implements Isql.TextoError
        Get
            Return _error
        End Get
    End Property

    Public ReadOnly Property numberError() As String Implements Isql.numberError
        Get
            Return _numberError
        End Get
    End Property

    Public Function search() As Boolean Implements Isql.search
        Try
            Dim conX As New MySqlConnection
            conX.ConnectionString = My.Settings.Cadena_Conexion
            conX.Open() 'Abre la conexion
            Dim Cmd As New MySqlCommand
            _SQL = "select nombre,direccion,telefono,celular,email,foto " & _
                   "from(Personas) " & _
                   "where tipo_doc=?tipo and id=?idp"
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = _SQL
            Cmd.Parameters.AddWithValue("?tipo", _tipo_id)
            Cmd.Parameters.AddWithValue("?idp", _id)
            Cmd.Connection = conX
            Dim dr As MySqlDataReader
            dr = Cmd.ExecuteReader
            If dr.Read Then
                _nombre = dr!nombre
                _direccion = dr!direccion
                _telefono = dr!telefono
                _celular = dr!celular
                _email = dr!email
                _foto = dr!foto
                Return True
            Else
                Return False
            End If
        Catch exMysql As MySqlException
            _numberError = exMysql.Number
            _error = exMysql.Message
            Return False
        End Try
    End Function

    Public Function update() As Boolean Implements Isql.update
        Try
            Dim conX As New MySqlConnection
            conX.ConnectionString = My.Settings.Cadena_Conexion
            conX.Open() 'Abre la conexion
            Dim Cmd As New MySqlCommand
            _SQL = "update personas set nombre=ucase(?nom)," & _
                   "direccion=?dir,telefono=?tel,celular=?cel, " & _
                   "email=?mail,foto=?fotop " & _
                   "where tipo_doc=?tipo and id=?idp"
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = _SQL
            Cmd.Parameters.AddWithValue("?tipo", _tipo_id)
            Cmd.Parameters.AddWithValue("?idp", _id)
            Cmd.Parameters.AddWithValue("?nom", _nombre)
            Cmd.Parameters.AddWithValue("?dir", _direccion)
            Cmd.Parameters.AddWithValue("?tel", _telefono)
            Cmd.Parameters.AddWithValue("?cel", _celular)
            Cmd.Parameters.AddWithValue("?mail", _email)
            Cmd.Parameters.AddWithValue("?fotop", _foto)
            Cmd.Connection = conX
            Cmd.ExecuteNonQuery()
            Return True
        Catch exMysql As MySqlException
            _numberError = exMysql.Number
            _error = exMysql.Message
            Return False
        End Try

    End Function

    Public Function GetListapersonas() As DataSet
        Dim conDB As New MySqlConnection, resp As DataSet = New DataSet

        Try
            conDB.ConnectionString = My.Settings.Cadena_Conexion
            Dim cmd As New MySqlCommand("Select tipo_doc,id,nombre from personas", conDB)
            Dim daDep = New MySqlDataAdapter(cmd)
            daDep.Fill(resp, "personas")
        Catch ex As MySqlException
            _error = ex.Message
        Catch ex As Exception
            _error = ex.Message
        End Try
        Return resp
    End Function

End Class
