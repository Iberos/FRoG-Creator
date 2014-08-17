Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable>
Public Class GameNPC

    Public name As String
    Public type As Byte
    Public sprite As UShort
    Public HP As Integer
    Public MP As Integer
    Public strength As UShort
    Public magic As UShort
    Public defense As UShort
    Public agility As UShort
    Public speed As UShort
    Public dialog As String

    Public Function getView() As Bitmap
        Dim texture As New Bitmap("Sprite.png") 'TODO Modifier
        Return texture.Clone(New Rectangle(0, 0, texture.Width / 4, texture.Height / 4), Imaging.PixelFormat.DontCare)
    End Function

    Public Function getShortView() As Bitmap
        Dim texture = getView()
        Return texture.Clone(New Rectangle(CType((texture.Width - 32) / 2, Integer),
                                           CType(0.05 * texture.Height, Integer),
                                           32, 32), Imaging.PixelFormat.DontCare)
    End Function

    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("PNJs/PNJ" & lstNPCs.IndexOf(Me) & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

End Class
