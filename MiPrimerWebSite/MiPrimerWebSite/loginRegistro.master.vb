
Partial Class loginRegistro
    Inherits System.Web.UI.MasterPage

    Private Sub loginRegistro_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session.Count() > 0 Then
            Server.Transfer("Home.aspx", True)
        End If
    End Sub
End Class

