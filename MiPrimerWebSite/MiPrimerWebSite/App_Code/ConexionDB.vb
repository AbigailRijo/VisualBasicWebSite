Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class ConexionDB

    Public myCmd As SqlCommand
    Public myReader As SqlDataReader
    Public results As String
    Public myConn As SqlConnection = New SqlConnection("Initial Catalog=BlogDB;" & "Data Source=localhost;Integrated Security=SSPI;")

    Public Sub New()

    End Sub

    Public Sub Conectar()
        Try
            myConn.Open()
        Catch exc As Exception
            MsgBox(exc.Message.ToString)
        End Try
    End Sub

    Public Sub Desconectar()
        Try
            myConn.Close()
        Catch exc As Exception
            MsgBox(exc.Message.ToString)
        End Try
    End Sub

End Class
