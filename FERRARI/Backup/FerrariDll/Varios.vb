Imports System.Text.RegularExpressions

Public Class Varios
    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false    
        Return Regex.IsMatch(sMail, _
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
End Class
