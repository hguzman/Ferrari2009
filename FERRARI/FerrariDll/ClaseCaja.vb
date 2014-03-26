Imports MySql.Data.MySqlClient

Public Class ClaseCaja
#Region "Datos Privados de la clase"
    Private _SQL As String
    Private _registro As Integer
#End Region

    Public Function Movimiento_caja(ByVal abono As Double, ByVal concep As Integer, ByVal nota As String, ByVal Comentario As String) As Boolean
        Dim conx As New MySqlConnection, resp As Boolean = True
        Try
            conx.ConnectionString = My.Settings.Cadena_Conexion 'Asigna la cadena de conexion que se encuentra en configuracion del proyecto
            conx.Open() 'Abre la conexion
            Dim Cmd As New MySqlCommand 'Crea la instancia comand
            _SQL = "insert into caja(fecha_movimiento," & _
            "cod_concepto,tipo_nota,importe,comentarios," & _
            "hora_movimiento) values (?fecha,?conc,?nota,?abono,?comen,?hora)"
            Cmd.CommandText = _SQL
            Cmd.Parameters.AddWithValue("?fecha", Now.Date)
            Cmd.Parameters.AddWithValue("?abono", abono)
            Cmd.Parameters.AddWithValue("?nota", nota)
            Cmd.Parameters.AddWithValue("?conc", concep)
            Cmd.Parameters.AddWithValue("?comen", Comentario)
            Cmd.Parameters.AddWithValue("?hora", Now.TimeOfDay)
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
End Class
