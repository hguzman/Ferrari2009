Imports FerrariDll

Public Class LoginForm

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        Dim usr As New login(txtUsuario.Text, txtContrasena.Text)
        If usr.validarEntrada Then
            Me.Hide()
            Dim fprincipal As New MenuPrincipal
            fprincipal.Show()
            fprincipal.ToolStripStatusLabel.Text = "Usuario=" & txtUsuario.Text & ", Nombre=" & usr.nombrePersona
        Else
            MessageBox.Show("Negativo Compadre")

        End If
    End Sub

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Me.Close()
    End Sub
End Class