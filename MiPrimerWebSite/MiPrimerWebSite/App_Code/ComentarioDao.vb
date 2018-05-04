Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class ComentarioDao
    Inherits ConexionDB

    Public Function BuscarTodasLasComentariosPorIdPublicacion(id As Integer) As List(Of Comentario)

        Dim arrayDeComentario As List(Of Comentario) = New List(Of Comentario)
        Dim objRespuestaComentarioDao As New RespuestaComentarioDao()

        Conectar()
        myCmd = New SqlCommand()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "select c.*, u.Nombre, u.Apellido from ComentarioPublicacion c left join Usuario u on u.Id = c.IdUsuario where IdPublicacion =" & id & ""
        myReader = myCmd.ExecuteReader()

        While myReader.Read()
            Dim objComentario As New Comentario(Convert.ToInt32(myReader(0).ToString), myReader(1).ToString, Convert.ToInt32(myReader(2).ToString), Convert.ToInt32(myReader(3).ToString), myReader(4).ToString, (myReader(5).ToString + " " + myReader(6).ToString))
            arrayDeComentario.Add(objComentario)
        End While
        Desconectar()

        For Each comentario In arrayDeComentario
            comentario.Respuestas = objRespuestaComentarioDao.BuscarTodasLasRespuestasComentarioPorIdComentario(comentario.Id)
        Next
        Return arrayDeComentario
    End Function

End Class
