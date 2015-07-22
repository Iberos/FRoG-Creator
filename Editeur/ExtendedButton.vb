Public Class ExtendedButton
    Inherits Button

    Private xCoordinate As Integer = 0
    Private yCoordinate As Integer = 0

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        Me.X = x
        Me.Y = y
    End Sub

    Public Property X As Integer
        Get
            Return xCoordinate
        End Get
        Set(value As Integer)
            xCoordinate = value
        End Set
    End Property

    Public Property Y As Integer
        Get
            Return yCoordinate
        End Get
        Set(value As Integer)
            yCoordinate = value
        End Set
    End Property

End Class
