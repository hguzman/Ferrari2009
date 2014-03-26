Imports MySql.Data.MySqlClient
Imports FerrariDll

Public Class frmCaja

    Private Sub frmCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn As New MySqlConnection(My.Settings.Cadena_Conexion)
        Dim daproductos As New MySqlDataAdapter("select * from conceptos", cn)
        Dim ds As New DataSet
        daproductos.Fill(ds, "Conceptos_caja")
        cboConcepto.DataSource = ds.Tables("Conceptos_caja")
        cboConcepto.DisplayMember = "concepto"
        cboConcepto.ValueMember = "cod_concepto"
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Grupo1.Enabled = True
        Comentarios.Text = ""
        Importe.Text = ""
        cboTipoNota.Text = ""
        Guardar.Enabled = True
        Nuevo.Enabled = False
        cboConcepto.Focus()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Dim tnota As String
        Dim caja As New ClaseCaja
        If cboTipoNota.Text = "" Then
            MsgBox("Indique el tipo de nota", MsgBoxStyle.Critical, "Ferrari")
            Exit Sub
        End If
        If cboTipoNota.Text = "ENTRADA" Then
            tnota = "D"
        Else
            tnota = "C"
        End If
        If caja.Movimiento_caja(Importe.Text, cboConcepto.SelectedValue, tnota, Comentarios.Text) Then
            MsgBox("Proceso ok", MsgBoxStyle.Information, "Ferrari")
            Grupo1.Enabled = False
            Guardar.Enabled = False
            Nuevo.Enabled = True
        End If
    End Sub
End Class