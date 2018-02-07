Public Class vdetalleproducto
    Dim iddetalleproducto, idventa, idproducto, cantidad As Integer
    Dim preciounitario As Double

    'Setter and getter

    Public Property giddetalleproducto
        Get
            Return iddetalleproducto
        End Get
        Set(ByVal value)
            iddetalleproducto = value
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

    Public Property gidproducto
        Get
            Return idproducto
        End Get
        Set(ByVal value)
            idproducto = value
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

    Public Sub New(ByVal iddetalleproducto As Integer, ByVal idventa As Integer, ByVal idproducto As Integer, ByVal cantidad As Integer, ByVal preciounitario As Double)
        giddetalleproducto = iddetalleproducto
        gidventa = idventa
        gidproducto = idproducto
        gcantidad = cantidad
        preciounitario = preciounitario
    End Sub
End Class