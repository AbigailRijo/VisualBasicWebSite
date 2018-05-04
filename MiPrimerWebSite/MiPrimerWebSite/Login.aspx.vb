
Partial Class Login
    Inherits System.Web.UI.Page
    Public objUsuarioDao As New UsuarioDao

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBoxCorreo.Text <> "" And TextBoxContrasenia.Text <> "" Then
            Dim objUsuario As New Usuario()
            objUsuario.Correo = TextBoxCorreo.Text
            objUsuario.Contrasenia = TextBoxContrasenia.Text
            objUsuarioDao.BuscarUsuarioLogin(objUsuario)
            If objUsuario.Nombre <> "" Then
                Session("Correo") = TextBoxCorreo.Text
                Session("Id") = objUsuario.Id.ToString
                Server.Transfer("Home.aspx", True)
            Else
                lError.Text = "Correo o contraseña invalida"
            End If
        End If
    End Sub
End Class
