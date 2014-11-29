Public Class GameMap

    Public name As String
    Public type As Byte
    Public layer(6) As Layer ' couche entière
    Public attribute(20, 14) As Attribute ' attribut sur une case
    Public borderMap(8) As Integer ' maps au voisinage

    Public Function isWalkable(location As GameVector)
        ' TODO isWalkable condition  
        Return True
    End Function

End Class
