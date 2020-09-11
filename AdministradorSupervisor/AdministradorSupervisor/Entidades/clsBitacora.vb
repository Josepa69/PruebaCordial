Public Class clsBitacora
    Private _idBitacora As Integer
    Private _idCRM As Integer
    Private _Fecha As String
    Private _Detalle As String
    Private _Total As Integer
    Private _Ip_Equipo As String

    Public Sub New(_idBitacora As Integer, _idCRM As Integer, _Fecha As String, _Detalle As String, _Total As Integer, _Ip_Equipo As String)
        _idBitacora = IdBitacora
        _idCRM = IdCRM
        _Fecha = Fecha
        _Detalle = Detalle
        _Total = Total
        _Ip_Equipo = Ip_Equipo
    End Sub

    Public Sub New()
        _idBitacora = 0
        _idCRM = 0
        _Fecha = ""
        _Detalle = ""
        _Total = 0
        _Ip_Equipo = ""
    End Sub

    Public Property IdBitacora As Integer
        Get
            Return _idBitacora
        End Get
        Set(value As Integer)
            _idBitacora = value
        End Set
    End Property

    Public Property IdCRM As Integer
        Get
            Return _idCRM
        End Get
        Set(value As Integer)
            _idCRM = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _Detalle
        End Get
        Set(value As String)
            _Detalle = value
        End Set
    End Property

    Public Property Total As Integer
        Get
            Return _Total
        End Get
        Set(value As Integer)
            _Total = value
        End Set
    End Property

    Public Property Ip_Equipo As String
        Get
            Return _Ip_Equipo
        End Get
        Set(value As String)
            _Ip_Equipo = value
        End Set
    End Property
End Class
