
Partial Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles bRegistrar.Click
        If TextBoxNombre.Text <> "" And TextBoxApellido.Text <> "" And TextBoxCorreo.Text <> "" And TextBoxContrasenia.Text <> "" Then
            Dim objUsuario As New Usuario(TextBoxNombre.Text, TextBoxApellido.Text, TextBoxCorreo.Text, TextBoxContrasenia.Text)
            Dim objUsuarioDao As New UsuarioDao()
            objUsuarioDao.RegistrarUsuario(objUsuario)

            If objUsuario.Id.ToString <> "" Then
                Session("Id") = objUsuario.Id.ToString
                Session("Correo") = objUsuario.Correo
                Server.Transfer("Home.aspx", True)
            End If
        Else
            lError.Text = "Debe completar todos los campos"
        End If
    End Sub
End Class
