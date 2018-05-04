Imports System.Data.SqlClient
Imports System.IO
Imports System.Web.Script.Serialization
Imports Microsoft.VisualBasic

Public Class PublicacionDao
    Inherits ConexionDB

    Public Function BuscarPublicacion(id As String) As Publicacion
        Dim objPublicacion As New Publicacion(id)
        If id <> "" Then
            Conectar()
            myCmd = New SqlCommand()
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "select * from Publicacion where Id=" + id + ""
            myReader = myCmd.ExecuteReader()
            While myReader.Read()
                objPublicacion.Id = Convert.ToInt32(myReader(0).ToString)
                objPublicacion.Descripcion = myReader(1).ToString
                objPublicacion.IdUsuario = Convert.ToInt32(myReader(2).ToString)
                objPublicacion.Fecha = Convert.ToDateTime(myReader(3).ToString)
            End While
            Desconectar()
        End If
        Return objPublicacion
    End Function

    Public Function BuscarTodasLasPublicaciones() As Publicacion()


        Dim arrayDePublicaciones As List(Of Publicacion) = New List(Of Publicacion)

        Conectar()
        myCmd = New SqlCommand()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "select * from Publicacion"
        myReader = myCmd.ExecuteReader()

        While myReader.Read()
            Dim objpublicacion As New Publicacion(Convert.ToInt32(myReader(0).ToString), myReader(1).ToString, Convert.ToInt32(myReader(2).ToString), myReader(3).ToString)
            arrayDePublicaciones.Add(objpublicacion)
        End While
        Desconectar()

        Dim publicaciones() As Publicacion = arrayDePublicaciones.ToArray()
        Return publicaciones
    End Function

    Public Function BuscarTodasLasPublicacionesyComentariosySubComentarios() As Publicacion()

        Dim objComentarioDao As New ComentarioDao()
        Dim objRespuestaComentarioDao As New RespuestaComentarioDao()
        Dim arrayDePublicaciones As List(Of Publicacion) = New List(Of Publicacion)

        Conectar()
        myCmd = New SqlCommand()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "select p.*, u.Nombre, u.Apellido from Publicacion p left join Usuario u on u.Id = p.IdUsuario"
        myReader = myCmd.ExecuteReader()

        While myReader.Read()
            Dim objpublicacion As New Publicacion(Convert.ToInt32(myReader(0).ToString()), myReader(1).ToString(), Convert.ToInt32(myReader(2).ToString()), myReader(3).ToString(), (myReader(4).ToString() + " " + myReader(5).ToString()))
            arrayDePublicaciones.Add(objpublicacion)
        End While
        Desconectar()

        For Each publicacion In arrayDePublicaciones
            publicacion.Comentarios = objComentarioDao.BuscarTodasLasComentariosPorIdPublicacion(publicacion.Id)
        Next


        Dim publicaciones() As Publicacion = arrayDePublicaciones.ToArray()
        Return publicaciones
    End Function


    Public Function GuardarPublicacion(objPublicacion As Publicacion) As String
        Conectar()
        myCmd = New SqlCommand()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "insert into Publicacion values ('" + objPublicacion.Descripcion + "'," & objPublicacion.IdUsuario & ", '" + objPublicacion.Fecha + "')"
        results = myCmd.ExecuteNonQuery
        Desconectar()
        Return results
    End Function
End Class
