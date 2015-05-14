Imports SFML.Graphics

<Serializable>
Public Class MapLayer
    Implements Drawable

    Public TileCode(20, 14) As UShort ' identifiant unique correspondant à la case sur la planche de tile
    Public TilesetIndex(20, 14) As Short ' index de la planche de tile

    Public Sub Draw(target As RenderTarget, states As RenderStates) Implements Drawable.Draw

    End Sub

End Class
