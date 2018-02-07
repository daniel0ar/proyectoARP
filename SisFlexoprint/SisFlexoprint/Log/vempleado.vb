Public Class vempleado
    Dim idempleado, tipo As Integer
    Dim nombre, apellido, direccion, telefono, email, cedula As String


    'Setter and getter

    Public Property gidempleado
        Get
            Return idempleado
        End Get
        Set(ByVal value)
            idempleado = value
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

    Public Property gapellido
        Get
            Return apellido
        End Get
        Set(ByVal value)
            apellido = value
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

    Public Property gtipo
        Get
            Return tipo
        End Get
        Set(ByVal value)
            tipo = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idempleado As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal telefono As String, ByVal email As String, ByVal cedula As String, ByVal tipo As Integer)
        gidempleado = idempleado
        gnombre = nombre
        gapellido = apellido
        gdireccion = direccion
        gtelefono = telefono
        gemail = email
        gcedula = cedula
        gtipo = tipo
    End Sub
End Class