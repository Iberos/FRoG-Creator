Imports SFML.Window

Public Class GameRelativeMap
    Private Shared relMaps As New List(Of GameRelativeMap)

    Private vector As Vector2

    Public Sub New(vector As Vector2)
        Me.vector = vector
    End Sub

    Public Function GetVector()
        Return Me.vector
    End Function

    Public Shared Function MAPS() As List(Of GameRelativeMap)
        If (Not relMaps.Count > GameMap.NEIGHBOORS_COUNT) Then
            relMaps.Add(LEFT_TOP)
            relMaps.Add(MIDDLE_TOP)
            relMaps.Add(RIGHT_TOP)
            relMaps.Add(LEFT)
            relMaps.Add(RIGHT)
            relMaps.Add(LEFT_BOTTOM)
            relMaps.Add(MIDDLE_BOTTOM)
            relMaps.Add(RIGHT_BOTTOM)
        End If
        Return relMaps
    End Function

    Public Shared LEFT_TOP = New GameRelativeMap(New Vector2(-GameMap.WIDTH, -GameMap.HEIGHT))
    Public Shared MIDDLE_TOP = New GameRelativeMap(New Vector2(0, -GameMap.HEIGHT))
    Public Shared RIGHT_TOP = New GameRelativeMap(New Vector2(GameMap.WIDTH, -GameMap.HEIGHT))
    Public Shared LEFT = New GameRelativeMap(New Vector2(-GameMap.WIDTH, 0))
    Public Shared RIGHT = New GameRelativeMap(New Vector2(GameMap.WIDTH, 0))
    Public Shared LEFT_BOTTOM = New GameRelativeMap(New Vector2(-GameMap.WIDTH, GameMap.HEIGHT))
    Public Shared MIDDLE_BOTTOM = New GameRelativeMap(New Vector2(0, GameMap.HEIGHT))
    Public Shared RIGHT_BOTTOM = New GameRelativeMap(New Vector2(GameMap.WIDTH, GameMap.HEIGHT))
End Class
