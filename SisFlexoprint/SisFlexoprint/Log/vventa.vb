Public Class vventa
    Dim idventa, idcliente, reserva As Integer
    Dim total As Double
    Dim fecha, hora As Date

    'Setter and getter

    Public Property gidventa
        Get
            Return idventa
        End Get
        Set(ByVal value)
            idventa = value
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

    Public Property greserva
        Get
            Return reserva
        End Get
        Set(ByVal value)
            reserva = value
        End Set
    End Property

    Public Property gtotal
        Get
            Return total
        End Get
        Set(ByVal value)
            total = value
        End Set
    End Property

    Public Property gfecha
        Get
            Return fecha
        End Get
        Set(ByVal value)
            fecha = value
        End Set
    End Property

    Public Property ghora
        Get
            Return hora
        End Get
        Set(ByVal value)
            hora = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idventa As Integer, ByVal idcliente As Integer, ByVal reserva As Integer, ByVal fecha As Date, ByVal hora As Date, ByVal total As Double)
        idventa = idventa
        gidcliente = idcliente
        greserva = reserva
        gfecha = fecha
        ghora = hora
        gtotal = total
    End Sub
End Class