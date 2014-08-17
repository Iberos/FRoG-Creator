Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable>
Public Class GameItem

    Public name As String
    Public description As String
    Public icon As UShort
    Public paperdoll As UShort
    Public type As Byte
    Public addHP As Integer
    Public addMP As Integer
    Public addStrength As UShort
    Public addMagic As UShort
    Public addDefense As UShort
    Public addAgility As UShort
    Public addSpeed As UShort

    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("Objets/Objet" & lstItems.IndexOf(Me) & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

End Class
