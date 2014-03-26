Public Class FListaValores
    Public Function ShowListValues(ByVal ds As DataSet) As Object
        Dim valores As Object = Nothing

        Dim dtv As DataView = ds.Tables(0).DefaultView
        Me.Datos.DataSource = dtv
        If Me.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Formulario modal
            If Not Me.Datos.CurrentRow Is Nothing Then
                ReDim valores(Me.Datos.CurrentRow.Cells.Count)
                Dim i As Integer
                For i = 0 To Me.Datos.CurrentRow.Cells.Count - 1
                    valores(i) = Me.Datos.CurrentRow.Cells(i).Value
                Next
            End If
        End If
        Return valores
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub TextoBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoBuscar.TextChanged
        Dim dtv As DataView = Me.Datos.DataSource
        Dim Condicion As String = ""

        For Each dc As DataColumn In dtv.Table.Columns
            Condicion &= dc.ColumnName & " Like '%" & Me.TextoBuscar.Text & "%' or "
        Next
        Condicion = Condicion.Substring(0, Condicion.Length - 3)
        dtv.RowFilter = Condicion
        Me.Datos.DataSource = dtv
    End Sub

End Class