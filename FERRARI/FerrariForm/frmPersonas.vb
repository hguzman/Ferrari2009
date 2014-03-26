Imports FerrariDll
Imports System.Drawing.Image

Public Class frmPersonas
    Private arch As String
    Private per As New Personas 'Dimensiona el objeto
    Private estado As Boolean = True 'Indica el estado del boton

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        '        Dim per As New Personas(tipo_doc.Text, id.Text)
        per.tipo = tipo_doc.Text
        per.id = id.Text
        per.nombre = txtNombre.Text
        per.direccion = txtDireccion.Text
        per.telefono = txtTelefono.Text
        per.celular = txtCelular.Text
        per.email = txtEmail.Text
        If arch = Nothing Then
            per.foto = Environment.CurrentDirectory & "\fotos\LogoFerrari.JPG"
        Else
            per.foto = arch
        End If
        If estado Then
            If per.insert() Then
                MsgBox("Proceso ok", MsgBoxStyle.Information, "Información")
                Grupo1.Enabled = False
                Nuevo.Enabled = True
                Guardar.Enabled = False
                Buscar.Enabled = True
                Editar.Enabled = False
                CargarFoto.Enabled = False
                Salir.Enabled = True
                Cancelar.Enabled = False
            Else
                MsgBox("Problemas con los datos", MsgBoxStyle.Critical, "Huyyyy")
            End If
        Else
            If per.update Then
                MsgBox("Proceso ok", MsgBoxStyle.Information, "Información")
                Grupo1.Enabled = False
                Nuevo.Enabled = True
                Guardar.Enabled = False
                Buscar.Enabled = True
                Editar.Enabled = False
                CargarFoto.Enabled = False
                Salir.Enabled = True
                Cancelar.Enabled = False
            Else
                MsgBox("Problemas con la actualizacion", MsgBoxStyle.Critical, "Huyyyy")
            End If
        End If
    End Sub

    Private Sub CargarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarFoto.Click
        CuadroDialogo.ShowDialog()
        PicFoto.Image = Image.FromFile(CuadroDialogo.FileName)
        arch = CuadroDialogo.FileName
    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Dim Valores() As Object
        Dim lista As New FListaValores
        Dim emp As New Personas
        Valores = lista.ShowListValues(emp.GetListapersonas)
        If Not Valores Is Nothing Then
            Me.tipo_doc.Text = Valores(0).ToString
            Me.id.Text = Valores(1).ToString
            per.tipo = tipo_doc.Text
            per.id = id.Text
            If per.search() Then
                txtNombre.Text = per.nombre
                txtDireccion.Text = per.direccion
                txtTelefono.Text = per.telefono
                txtCelular.Text = per.celular
                txtEmail.Text = per.email
                PicFoto.Image = Image.FromFile(per.foto)
                Editar.Enabled = True
            End If
        End If

    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Grupo1.Enabled = True
        Guardar.Enabled = True
        Nuevo.Enabled = False
        Buscar.Enabled = False
        CargarFoto.Enabled = True
        Cancelar.Enabled = True
        Salir.Enabled = False
        estado = True
    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        If Len(id.Text) > 0 Then
            Grupo1.Enabled = True
            txtNombre.ReadOnly = False
            txtDireccion.ReadOnly = False
            txtTelefono.ReadOnly = False
            txtCelular.ReadOnly = False
            txtEmail.ReadOnly = False
            Buscar.Enabled = False
            Guardar.Enabled = True
            Editar.Enabled = False
            CargarFoto.Enabled = True
            estado = False
        Else
            MsgBox("Debe Seleccionar un registro")
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Grupo1.Enabled = False
        Nuevo.Enabled = True
        Guardar.Enabled = False
        Buscar.Enabled = True
        Editar.Enabled = False
        Cancelar.Enabled = False
        Salir.Enabled = True
        CargarFoto.Enabled = False
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged
        PError.SetError(txtEmail, "")
    End Sub


    Private Sub txtEmail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim valid As New Varios
        If Not valid.validar_Mail(Me.txtEmail.Text) Then
            'Frecuencia conque parpadea el error
            PError.BlinkRate = 200
            'establecemos la propiedad BlinkStyle= ErrorBlinkStyle.AlwaysBlink,
            'para que siempre esté parpadeando cuando mientras no se corrija el error.
            PError.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            PError.SetError(txtEmail, "Dirección de correo no valida")
            e.Cancel = True
        End If
    End Sub

    Private Sub id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id.TextChanged

    End Sub

    Private Sub frmPersonas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mi Programa v" & Application.ProductVersion
    End Sub
End Class