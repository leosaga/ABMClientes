Public Class ClientesClass
    Dim id_ As Integer
    Dim nombre_, direccion_, categiva_ As String
    Dim saldo_ As Decimal
    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property



    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property
    Public Property categiva() As String
        Get
            Return categiva_
        End Get
        Set(ByVal value As String)
            categiva_ = value
        End Set
    End Property

    Public Property saldo() As Decimal

        Get
            Return saldo_

        End Get
        Set(ByVal value As Decimal)
            saldo_ = value
        End Set
    End Property



End Class
