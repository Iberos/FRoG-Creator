Public Class GameWorldMapEntity
    Public Map As GameMap
    Public Button As ExtendedButton

    Public Sub New(map As GameMap, button As ExtendedButton)
        Me.Map = map
        Me.Button = button
    End Sub
End Class
