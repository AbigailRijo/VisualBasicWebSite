Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class UsuarioDao
    Inherits ConexionDB

    Public Function BuscarUsuario(id As String) As Usuario
        Dim objUsuario As New Usuario(id)
        If id <> "" Then
            Conectar()
            myCmd = New SqlCommand()
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "select * from Usuario where Id=" + id + ""
            myReader = myCmd.ExecuteReader()
            While myReader.Read()
                objUsuario.Nombre = myReader(1).ToString
                objUsuario.Apellido = myReader(2).ToString
                objUsuario.Correo = myReader(3).ToString
                objUsuario.Contrasenia = myReader(4).ToString
            End While
            Desconectar()
        End If
        Return objUsuario
    End Function

    Public Function BuscarUsuarioLogin(objUsuario As Usuario) As Usuario

        If objUsuario.Correo <> "" And objUsuario.Contrasenia <> "" Then
            Conectar()
            myCmd = New SqlCommand()
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "select * from Usuario where Correo='" + objUsuario.Correo + "' and Contrasenia='" + objUsuario.Contrasenia + "'"
            myReader = myCmd.ExecuteReader()
            While myReader.Read()
                objUsuario.Id = myReader(0).ToString
                objUsuario.Nombre = myReader(1).ToString
                objUsuario.Apellido = myReader(2).ToString
            End While
            Desconectar()
        End If
        Return objUsuario
    End Function

    Public Sub RegistrarUsuario(objUsuario As Usuario)
        Conectar()
        myCmd = New SqlCommand()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "insert into Usuario values ('" + objUsuario.Nombre + "','" + objUsuario.Apellido + "', '" + objUsuario.Correo + "', '" + objUsuario.Contrasenia + "')"
        results = myCmd.ExecuteNonQuery
        myCmd.CommandText = "SELECT @@identity AS Id"
        myReader = myCmd.ExecuteReader()
        If results <> "0" Then
            While myReader.Read
                objUsuario.Id = Convert.ToInt32(myReader(0).ToString)
            End While
        End If
        Desconectar()
    End Sub
End Class
