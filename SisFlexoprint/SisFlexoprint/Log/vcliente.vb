Public Class vcliente
    Dim idcliente As Integer
    Dim nombre, direccion, telefono, email, cedula As String

    'Setter and getter

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
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

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property gemail
        Get
            Return email
        End Get
        Set(ByVal value)
            email = value
        End Set
    End Property

    Public Property gcedula
        Get
            Return cedula
        End Get
        Set(ByVal value)
            cedula = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal direccion As String, ByVal telefono As String, ByVal email As String, ByVal cedula As String)
        gidcliente = idcliente
        gnombre = nombre
        gdireccion = direccion
        gtelefono = telefono
        gemail = email
        gcedula = cedula
    End Sub
End Class