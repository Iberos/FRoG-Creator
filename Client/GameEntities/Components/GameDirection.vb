Imports SFML.Window
Imports SFML.System

Public Class GameDirection
    Private vector As Vector2f
    Private index As Byte

    Public Sub New(vector As Vector2f, index As Byte)
        Me.vector = vector
        Me.index = index
    End Sub

    Public Function GetVector()
        Return Me.vector
    End Function

    Public Function GetIndex()
        Return Me.index
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (MyBase.Equals(obj)) Then
            Return True
        End If

        If (TypeOf obj Is GameDirection) Then
            Dim dir = DirectCast(obj, GameDirection)
            Return dir.index = Me.index
        Else
            Return False
        End If
    End Function

    Public Shared Down As New GameDirection(New Vector2f(0, 1), 0)
    Public Shared Up As New GameDirection(New Vector2f(0, -1), 3)
    Public Shared Right As New GameDirection(New Vector2f(1, 0), 2)
    Public Shared Left As New GameDirection(New Vector2f(-1, 0), 1)
End Class
