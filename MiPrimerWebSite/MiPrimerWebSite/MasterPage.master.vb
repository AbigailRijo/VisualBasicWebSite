
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Private Sub MasterPage_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Session.Count() > 0 Then

        Else
            Server.Transfer("Login.aspx", True)
        End If
    End Sub
End Class

