Imports Microsoft.VisualBasic

Public Class Comentario
    Private IdComentario As Integer
    Private DescripcionComentario As String
    Private IdUsuarioComentario As Integer
    Private IdComentarioPublicacion As Integer
    Private FechaComentario As String
    Private respuestasComentarios As List(Of RespuestaComentario)
    Private NombreCompletoUsuario As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal id As String)
        MyClass.Id = id
    End Sub

    Public Sub New(ByVal descripcion As String, ByVal idUsuario As String, ByVal idPublicacion As Integer, ByVal fecha As String)
        MyClass.Descripcion = descripcion
        MyClass.IdUsuario = idUsuario
        MyClass.IdPublicacion = idPublicacion
        MyClass.Fecha = fecha
    End Sub

    Public Sub New(ByVal id As Integer, ByVal descripcion As String, ByVal idUsuario As String, ByVal idPublicacion As Integer, ByVal fecha As String)
        MyClass.Id = id
        MyClass.Descripcion = descripcion
        MyClass.IdUsuario = idUsuario
        MyClass.IdPublicacion = idPublicacion
        MyClass.Fecha = fecha
    End Sub

    Public Sub New(ByVal id As Integer, ByVal descripcion As String, ByVal idUsuario As String, ByVal idPublicacion As Integer, ByVal fecha As String, ByVal nombreCompleto As String)
        MyClass.Id = id
        MyClass.Descripcion = descripcion
        MyClass.IdUsuario = idUsuario
        MyClass.IdPublicacion = idPublicacion
        MyClass.Fecha = fecha
        MyClass.NombreCompletoUsuario = nombreCompleto
    End Sub

    Public Property Id() As Integer
        Get
            Return IdComentario
        End Get
        Set(value As Integer)
            IdComentario = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return DescripcionComentario
        End Get
        Set(value As String)
            DescripcionComentario = value
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

    Public Property IdPublicacion() As Integer
        Get
            Return IdComentarioPublicacion
        End Get
        Set(value As Integer)
            IdComentarioPublicacion = value
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

    Public Property Respuestas() As List(Of RespuestaComentario)
        Get
            Return respuestasComentarios
        End Get
        Set(value As List(Of RespuestaComentario))
            respuestasComentarios = value
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
