Imports FerrariDll
Public Class frmConsultaCartera
    Private cart As New ClaseCartera
    Private dtv As DataView
    Private fila As Byte

    Private Sub Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Consultar.Click
        cart.tipo = Me.tipo_doc.Text
        cart.id = Me.id.Text
        dtv = cart.consulta_cartera.Tables(0).DefaultView
        DgvCartera.DataSource = dtv
        'DgvCartera.Refresh()
    End Sub

    Private Sub Abono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pagar.Click
        Dim reg As Integer
        Dim imp As Single
        Try

            fila = Me.DgvCartera.CurrentCell.RowIndex
            If fila > -1 Then
                reg = Integer.Parse(Me.DgvCartera.Item(0, fila).Value)
                imp = Single.Parse(Me.DgvCartera.Item(2, fila).Value)
                cart.registro = reg
                cart.saldo = imp
                Dim resp As MsgBoxResult
                resp = MsgBox("¿Desea Pagar $" & imp & " De Esta factura?", MsgBoxStyle.YesNo, "Pagar Factura")
                If resp = MsgBoxResult.Yes Then
                    If cart.actualiza_saldo("C") Then
                        Dim caja As New ClaseCaja
                        caja.Movimiento_caja(imp, 3, "D", "Pago Total del Saldo Factura Nº" & reg)

                        MsgBox("Se Realizo el pago por $" & imp)
                        dtv = cart.consulta_cartera.Tables(0).DefaultView
                        DgvCartera.DataSource = dtv
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
End Class