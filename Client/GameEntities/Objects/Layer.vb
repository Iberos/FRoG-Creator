Imports SFML.Graphics

<Serializable>
Public Class Layer
    Implements Drawable

    Public tileCode(20, 14) As UShort ' identifiant unique correspondant à la case sur la planche de tile
    Public tileset(20, 14) As Short ' index de la planche de tile

    Public Sub Draw(target As RenderTarget, states As RenderStates) Implements Drawable.Draw

    End Sub

End Class
