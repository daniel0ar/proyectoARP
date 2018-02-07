Public Class vservicio
    Dim idetiqueta, idcliente As Integer
    Dim arte, nombre As String
    Dim precioventa, medidax, mediday, diametro As Double

    'Setter and getter

    Public Property gidetiqueta
        Get
            Return idetiqueta
        End Get
        Set(ByVal value)
            idetiqueta = value
        End Set
    End Property

    Public Property garte
        Get
            Return arte
        End Get
        Set(ByVal value)
            arte = value
        End Set
    End Property

    Public Property gprecioventa
        Get
            Return precioventa
        End Get
        Set(ByVal value)
            precioventa = value
        End Set
    End Property

    Public Property gmedidax
        Get
            Return medidax
        End Get
        Set(ByVal value)
            medidax = value
        End Set
    End Property

    Public Property gmediday
        Get
            Return mediday
        End Get
        Set(ByVal value)
            mediday = value
        End Set
    End Property

    Public Property gdiametro
        Get
            Return diametro
        End Get
        Set(ByVal value)
            diametro = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property
    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idetiqueta As Integer, ByVal arte As String, ByVal precioventa As Double, ByVal medidax As Double, ByVal mediday As Double, ByVal diametro As Double, ByVal nombre As String, ByVal idcliente As Integer)
        garte = arte
        gprecioventa = precioventa
        gmedidax = medidax
        gmediday = mediday
        gdiametro = diametro
        gnombre = nombre
        gidcliente = idcliente
    End Sub
End Class