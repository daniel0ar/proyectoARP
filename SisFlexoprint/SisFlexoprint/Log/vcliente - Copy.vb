Public Class vcliente
    Dim idcliente As Integer
    Dim nombre, apellido, direccion, telefono, email, cedula As String
    Dim fechanacimiento As Date

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
            Return nombre
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return nombre
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property gemail
        Get
            Return nombre
        End Get
        Set(ByVal value)
            email = value
        End Set
    End Property

    Public Property gfechanacimiento
        Get
            Return nombre
        End Get
        Set(ByVal value)
            fechanacimiento = value
        End Set
    End Property

    Public Property gcedula
        Get
            Return nombre
        End Get
        Set(ByVal value)
            cedula = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal telefono As String, ByVal email As String, ByVal fechanacimiento As Date, ByVal cedula As String)
        gidcliente = idcliente
        gnombre = nombre
        gapellido = apellido
        gdireccion = direccion
        gtelefono = telefono
        gemail = email
        gfechanacimiento = fechanacimiento
        gcedula = cedula
    End Sub


End Class
