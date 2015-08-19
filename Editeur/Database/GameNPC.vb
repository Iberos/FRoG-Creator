Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable>
Public Class GameNPC
    Inherits GameCharacter

    Public dialog As String
    Public texture As New Bitmap("Resources/Sprite.png")

    Public Function GetView(Optional normalized As Boolean = False) As Bitmap
        Return texture.Clone(New Rectangle(If(normalized, ((texture.Width / 4) - 32) / 2, 0),
                                            0,
                                            If(normalized, 32, texture.Width / 4),
                                            If(normalized, 48, texture.Height / 4)),
                                            Imaging.PixelFormat.DontCare)
    End Function

    Public Function GetShortView(Optional normalized As Boolean = False) As Bitmap
        Dim tex = GetView(normalized)
        Return tex.Clone(New Rectangle((tex.Width - 32) / 2, If(normalized, 0, 0.1 * tex.Height), 32, 32), Imaging.PixelFormat.DontCare)
    End Function

    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("PNJs/PNJ" & lstNPCs.IndexOf(Me) & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

End Class
