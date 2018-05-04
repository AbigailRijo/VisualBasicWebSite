Imports Microsoft.VisualBasic

Public Class Usuario
    Private IdUsuario As Integer
    Private NombreUsuario As String
    Private ApellidoUsuario As String
    Private TelefonoUsuario As String
    Private CorreoUsuario As String
    Private ContraseniaUsuario As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal id As String)
        MyClass.Id = id
    End Sub

    Public Property Contrasenia() As String
        Get
            Return ContraseniaUsuario
        End Get
        Set(value As String)
            ContraseniaUsuario = value
        End Set
    End Property

    Public Sub New(ByVal nombre As String, ByVal apellido As String, ByVal correo As String, ByVal contrasenia As String)
        MyClass.Nombre = nombre
        MyClass.Apellido = apellido
        MyClass.Correo = correo
        MyClass.Contrasenia = contrasenia
    End Sub

    Public Property Id() As Integer
        Get
            Return IdUsuario
        End Get
        Set(value As Integer)
            IdUsuario = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return NombreUsuario
        End Get
        Set(value As String)
            NombreUsuario = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return ApellidoUsuario
        End Get
        Set(value As String)
            ApellidoUsuario = value
        End Set
    End Property

    Public Property Correo() As String
        Get
            Return CorreoUsuario
        End Get
        Set(value As String)
            CorreoUsuario = value
        End Set
    End Property
End Class
