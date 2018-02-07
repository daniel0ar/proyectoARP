Public Class vusuario
    Dim idusuario As Integer
    Dim usuario, password As String

    'Setter and getter

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(ByVal value)
            idusuario = value
        End Set
    End Property

    Public Property gusuario
        Get
            Return usuario
        End Get
        Set(ByVal value)
            usuario = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idusuario As Integer, ByVal usuario As String, ByVal password As String)
        gidusuario = idusuario
        gusuario = usuario
        gpassword = password
    End Sub
End Class