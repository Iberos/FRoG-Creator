Imports SFML.Window

Public Class GameRelativeMap
    Private Shared relMaps As List(Of GameRelativeMap)

    Private vector As Vector2i

    Public Sub New(vector As Vector2i)
        Me.vector = vector
    End Sub

    Public Function GetVector()
        Return Me.vector
    End Function

    Public Shared Function MAPS() As List(Of GameRelativeMap)
        If (Not relMaps.Count.Equals(GameMap.NEIGHBOORS_COUNT)) Then
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

    Public Shared LEFT_TOP = New GameRelativeMap(New Vector2i(-GameMap.WIDTH, -GameMap.HEIGHT))
    Public Shared MIDDLE_TOP = New GameRelativeMap(New Vector2i(0, -GameMap.HEIGHT))
    Public Shared RIGHT_TOP = New GameRelativeMap(New Vector2i(GameMap.WIDTH, -GameMap.HEIGHT))
    Public Shared LEFT = New GameRelativeMap(New Vector2i(-GameMap.WIDTH, 0))
    Public Shared RIGHT = New GameRelativeMap(New Vector2i(GameMap.WIDTH, 0))
    Public Shared LEFT_BOTTOM = New GameRelativeMap(New Vector2i(-GameMap.WIDTH, GameMap.HEIGHT))
    Public Shared MIDDLE_BOTTOM = New GameRelativeMap(New Vector2i(0, GameMap.HEIGHT))
    Public Shared RIGHT_BOTTOM = New GameRelativeMap(New Vector2i(GameMap.WIDTH, GameMap.HEIGHT))
End Class
