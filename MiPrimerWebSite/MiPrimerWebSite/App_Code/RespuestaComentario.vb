Imports Microsoft.VisualBasic

Public Class RespuestaComentario
    Private IdRespuestaComentario As Integer
    Private DescripcionRespuestaComentario As String
    Private IdUsuarioComentario As Integer
    Private IdComentarioRespuesta As Integer
    Private FechaComentario As String
    Private NombreCompletoUsuario As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal id As String)
        MyClass.IdRespuesta = id
    End Sub

    Public Sub New(ByVal descripcion As String, ByVal idUsuario As String, ByVal idComentario As Integer, ByVal fecha As String)
        MyClass.Descripcion = descripcion
        MyClass.IdUsuario = idUsuario
        MyClass.IdComentario = idComentario
        MyClass.Fecha = fecha
    End Sub

    Public Sub New(ByVal id As Integer, ByVal descripcion As String, ByVal idUsuario As String, ByVal idComentario As Integer, ByVal fecha As String)
        MyClass.IdRespuesta = id
        MyClass.Descripcion = descripcion
        MyClass.IdUsuario = idUsuario
        MyClass.IdComentario = idComentario
        MyClass.Fecha = fecha
    End Sub

    Public Sub New(ByVal id As Integer, ByVal descripcion As String, ByVal idUsuario As String, ByVal idComentario As Integer, ByVal fecha As String, ByVal nombreCompleto As String)
        MyClass.IdRespuesta = id
        MyClass.Descripcion = descripcion
        MyClass.IdUsuario = idUsuario
        MyClass.IdComentario = idComentario
        MyClass.Fecha = fecha
        MyClass.NombreCompleto = nombreCompleto
    End Sub

    Public Property IdRespuesta() As Integer
        Get
            Return IdRespuestaComentario
        End Get
        Set(value As Integer)
            IdRespuestaComentario = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return DescripcionRespuestaComentario
        End Get
        Set(value As String)
            DescripcionRespuestaComentario = value
        End Set
    End Property

    Public Property IdUsuario() As Integer
        Get
            Return IdUsuarioComentario
        End Get
        Set(value As Integer)
            IdUsuarioComentario = value
        End Set
    End Property

    Public Property IdComentario() As Integer
        Get
            Return IdComentarioRespuesta
        End Get
        Set(value As Integer)
            IdComentarioRespuesta = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return FechaComentario
        End Get
        Set(value As String)
            FechaComentario = value
        End Set
    End Property

    Public Property NombreCompleto() As String
        Get
            Return NombreCompletoUsuario
        End Get
        Set(value As String)
            NombreCompletoUsuario = value
        End Set
    End Property

End Class
