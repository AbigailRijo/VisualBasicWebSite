Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class RespuestaComentarioDao
    Inherits ConexionDB

    Public Function BuscarTodasLasRespuestasComentarioPorIdComentario(id As Integer) As List(Of RespuestaComentario)

        Dim arrayDeRespuestaComentario As List(Of RespuestaComentario) = New List(Of RespuestaComentario)

        Conectar()
        myCmd = New SqlCommand()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "select r.*, u.Nombre, u.Apellido from RespuestaComentario r left join Usuario u on u.Id = r.IdUsuario where IdComentario =" & id & ""
        myReader = myCmd.ExecuteReader()

        While myReader.Read()
            Dim objRespuestaComentario As New RespuestaComentario(Convert.ToInt32(myReader(0).ToString), myReader(1).ToString, Convert.ToInt32(myReader(2).ToString), Convert.ToInt32(myReader(3).ToString), myReader(4).ToString, (myReader(5).ToString + " " + myReader(6).ToString))
            arrayDeRespuestaComentario.Add(objRespuestaComentario)
        End While
        Desconectar()
        Return arrayDeRespuestaComentario
    End Function
End Class
