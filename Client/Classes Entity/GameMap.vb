Imports SFML.Graphics

Public Class GameMap
    Implements SFML.Graphics.Drawable

    Public name As String
    Public type As Byte
    Public layer(6) As Layer ' couche entière
    Public attribute(20, 14) As Attribute ' attribut sur une case
    Public borderMap(8) As Integer ' maps au voisinage

    Public Function isWalkable(location As GameVector)
        ' TODO isWalkable condition  
        Return True
    End Function

    Public Sub Draw(target As RenderTarget, states As RenderStates) Implements Drawable.Draw

    End Sub

End Class
