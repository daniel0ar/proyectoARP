Public Class vcolor
    Dim idcolor, idetiqueta As Integer
    Dim codigoColor As String

    'Setter and getter

    Public Property gidcolor
        Get
            Return idcolor
        End Get
        Set(ByVal value)
            idcolor = value
        End Set
    End Property

    Public Property gidetiqueta
        Get
            Return idetiqueta
        End Get
        Set(ByVal value)
            idetiqueta = value
        End Set
    End Property

    Public Property gcodigoColor
        Get
            Return codigoColor
        End Get
        Set(ByVal value)
            codigoColor = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcolor As Integer, ByVal idetiqueta As Integer, ByVal codigoColor As String)
        gidcolor = idcolor
        gidetiqueta = idetiqueta
        gcodigoColor = codigoColor
    End Sub
End Class