Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable>
Public Class GameSpell

    Public name As String
    Public description As String
    Public type As Byte
    Public icon As Short
    Public animation As Short
    Public damage As Integer


    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("Sorts/Sort" & lstSpells.IndexOf(Me) & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

End Class
