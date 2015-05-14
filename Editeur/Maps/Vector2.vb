<Serializable>
Public Class Vector2

    Private Shared nullVector As New Vector2
    Private xVal As Integer
    Private yVal As Integer

    Public Sub New()
        xVal = 0
        yVal = 0
    End Sub

    Public Sub New(ByVal xValue As Integer, ByVal yValue As Integer)
        xVal = xValue
        yVal = yValue
    End Sub

    Public Property X As Integer
        Get
            Return xVal
        End Get
        Set(value As Integer)
            xVal = value
        End Set
    End Property

    Public Property Y As Integer
        Get
            Return yVal
        End Get
        Set(value As Integer)
            yVal = value
        End Set
    End Property

    Public Shared ReadOnly Property Zero As Vector2
        Get
            Return nullVector
        End Get
    End Property
End Class

