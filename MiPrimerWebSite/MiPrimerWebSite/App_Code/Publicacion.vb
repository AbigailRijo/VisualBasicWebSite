Imports Microsoft.VisualBasic

Public Class Publicacion
    Private IdPublicacion As Integer
    Private DescripcionPublicacion As String
    Private IdUsuarioPublicacion As Integer
    Private FechaPublicacion As String
    Private comentariosPublicacion As List(Of Comentario)
    Private NombreCompletoUsuario As String


    Public Sub New()
    End Sub

    Public Sub New(ByVal id As String)
        MyClass.Id = id
    End Sub

    Public Sub New(ByVal descripcion As String, ByVal idUsuario As String, ByVal fecha As String)
        MyClass.Descripcion = descripcion
        MyClass.IdUsuario = idUsuario
        MyClass.Fecha = fecha
    End Sub

    Public Sub New(ByVal id As String, ByVal descripcion As String, ByVal idUsuario As String, ByVal fecha As String)
        MyClass.Id = id
        MyClass.Descripcion = descripcion
        MyClass.IdUsuario = idUsuario
        MyClass.Fecha = fecha
    End Sub

    Public Sub New(ByVal id As String, ByVal descripcion As String, ByVal idUsuario As String, ByVal fecha As String, ByVal nombreCompleto As String)
        MyClass.Id = id
        MyClass.Descripcion = descripcion
        MyClass.IdUsuario = idUsuario
        MyClass.Fecha = fecha
        MyClass.NombreCompleto = nombreCompleto
    End Sub

    Public Property Id() As Integer
        Get
            Return IdPublicacion
        End Get
        Set(value As Integer)
            IdPublicacion = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return DescripcionPublicacion
        End Get
        Set(value As String)
            DescripcionPublicacion = value
        End Set
    End Property

    Public Property IdUsuario() As Integer
        Get
            Return IdUsuarioPublicacion
        End Get
        Set(value As Integer)
            IdUsuarioPublicacion = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return FechaPublicacion
        End Get
        Set(value As String)
            FechaPublicacion = value
        End Set
    End Property

    Public Property Comentarios() As List(Of Comentario)
        Get
            Return comentariosPublicacion
        End Get
        Set(value As List(Of Comentario))
            comentariosPublicacion = value
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