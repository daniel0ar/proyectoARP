Public Class vdetalleservicio
    Dim iddetalle, idventa, idetiqueta, idempleado, cantidad As Integer
    Dim preciounitario As Double

    'Setter and getter

    Public Property giddetalle
        Get
            Return iddetalle
        End Get
        Set(ByVal value)
            iddetalle = value
        End Set
    End Property

    Public Property gidventa
        Get
            Return idventa
        End Get
        Set(ByVal value)
            idventa = value
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

    Public Property gidempleado
        Get
            Return idempleado
        End Get
        Set(ByVal value)
            idempleado = value
        End Set
    End Property

    Public Property gcantidad
        Get
            Return cantidad
        End Get
        Set(ByVal value)
            cantidad = value
        End Set
    End Property

    Public Property gpreciounitario
        Get
            Return preciounitario
        End Get
        Set(ByVal value)
            preciounitario = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal iddetalle As Integer, ByVal idventa As Integer, ByVal idetiqueta As Integer, ByVal idempleado As Integer, ByVal cantidad As Integer, ByVal preciounitario As Double)
        giddetalle = iddetalle
        gidventa = idventa
        gidetiqueta = idetiqueta
        gidempleado = idempleado
        gcantidad = cantidad
        preciounitario = preciounitario
    End Sub
End Class