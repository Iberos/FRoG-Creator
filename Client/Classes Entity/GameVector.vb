
Public Class GameVector

    Private xvalue As Integer
    Private yvalue As Integer

    Public Sub New()
        Me.X = 0
        Me.Y = 0
    End Sub

    Public Sub New(xval As Integer, yval As Integer)
        Me.X = xval
        Me.Y = yval
    End Sub

    Public Property X() As Integer
        Get
            Return Me.xvalue
        End Get
        Set(value As Integer)
            Me.xvalue = value
        End Set
    End Property

    Public Property Y() As Integer
        Get
            Return Me.yvalue
        End Get
        Set(value As Integer)
            Me.yvalue = value
        End Set
    End Property

    Public Function isNeighboor(location As GameVector) 'TODO Revoir
        Return (Math.Abs(location.X - Me.X) + Math.Abs(location.Y - Me.Y)).Equals(1)
    End Function

    Public Shared Operator +(vector1 As GameVector, vector2 As GameVector) As GameVector
        Return New GameVector(vector1.X + vector2.X, vector1.Y + vector2.Y)
    End Operator

    Public Shared Operator -(vector1 As GameVector, vector2 As GameVector) As GameVector
        Return New GameVector(vector1.X - vector2.X, vector1.Y - vector2.Y)
    End Operator

    Public Shared Operator *(vector1 As GameVector, vector2 As GameVector) As GameVector
        Return New GameVector(vector1.X * vector2.X, vector1.Y * vector2.Y)
    End Operator

    Public Shared Operator *(vector1 As GameVector, value As Integer) As GameVector
        Return New GameVector(vector1.X * value, vector1.Y * value)
    End Operator

    Public Shared Down As GameVector = New GameVector(0, 1)
    Public Shared Up As GameVector = New GameVector(0, -1)
    Public Shared Left As GameVector = New GameVector(-1, 0)
    Public Shared Right As GameVector = New GameVector(1, 0)
End Class
