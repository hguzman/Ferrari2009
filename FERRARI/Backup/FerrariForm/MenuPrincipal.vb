Imports System.Windows.Forms

Public Class MenuPrincipal


    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        LoginForm.Close()
        Me.Close()
    End Sub
    Private Sub llamarForm(ByVal f As Form)
        f.MdiParent = Me
        f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FacturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturarToolStripMenuItem.Click
        llamarForm(Form1)
    End Sub

    Private Sub PersonasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonasToolStripMenuItem.Click
        llamarForm(frmPersonas)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        llamarForm(frmConsultaCartera)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        llamarForm(frmCaja)
    End Sub
End Class
