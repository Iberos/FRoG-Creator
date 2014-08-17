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


    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("PNJs/PNJ" & lstNPCs.IndexOf(Me) & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

End Class
