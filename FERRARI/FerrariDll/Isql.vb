Public Interface Isql
    Function insert() As Boolean
    Function search() As Boolean
    Function update() As Boolean
    ReadOnly Property TextoError() As String
    ReadOnly Property numberError() As String
End Interface
