Imports MySql.Data.MySqlClient

Public Class login
#Region "Datos Publicos"
    Public nombrePersona As String
#End Region
#Region "Datos Privados"
    Private _usuario As String
    Private _contrasena As String
#End Region

    Sub New(ByVal UserName As String, ByVal Password As String)
        _usuario = UserName
        _contrasena = Password
    End Sub

#Region "Metodos"
    Public Function validarEntrada() As Boolean
        Dim conDB As MySqlConnection
        conDB = New MySqlConnection
        Dim sql As String
        conDB.ConnectionString = My.Settings.Cadena_Conexion
        conDB.Open()
        sql = "select * " & _
        "from usuarios " & _
        "where usuario=?usr " & _
        "and contrasena=?cont"

        Dim cmd As New MySqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("?usr", _usuario)
        cmd.Parameters.AddWithValue("?cont", _contrasena)
        cmd.Connection = conDB

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        If dr.Read Then
            nombrePersona = dr!nombre
            Return True
        Else
            Return False
        End If
        dr.Close()
    End Function

#End Region
End Class
