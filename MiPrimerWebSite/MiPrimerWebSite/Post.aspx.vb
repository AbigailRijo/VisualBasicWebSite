
Imports System.Web.Script.Serialization

Partial Class Post
    Inherits System.Web.UI.Page

    Private Sub Post_Load(sender As Object, e As EventArgs) Handles Me.Load

        'request method, Request.QueryString,Request.Form,Request.file,.allkey,variable aplication,accept,formdata '

        Dim miloquis As String = ""

        If Request.QueryString("fid") = "Addpost" Then
            Addpost()
        ElseIf Request.QueryString("fid") = "getposts" Then
            getposts()
        End If

        ''Dim jss As New javas


    End Sub


    Public Sub Addpost()
        If Request.Form.ToString() <> "" Then
            Dim objPublicacion As New Publicacion(Request.Form("Descripcion").ToString(), Convert.ToInt32(Session("Id").ToString), Request.Form("Date"))

            Dim objPublicacionDao As New PublicacionDao()
            objPublicacionDao.GuardarPublicacion(objPublicacion)
            MsgBox(objPublicacionDao.results)
        End If
    End Sub

    Public Sub getposts()
        Dim objPublicacionDao As New PublicacionDao()
        Dim publicaciones() As Publicacion = objPublicacionDao.BuscarTodasLasPublicacionesyComentariosySubComentarios()

        Dim jss As New JavaScriptSerializer()
        Dim myJson As String = jss.Serialize(publicaciones)
        With Response
            .Clear()
            .ContentType = "application/json"
            .Write(myJson)
            .End()
        End With
    End Sub

End Class
