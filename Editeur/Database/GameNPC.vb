Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable>
Public Class GameNPC

    Public name As String
    Public type As Byte
    Public sprite As Short
    Public HP As Integer
    Public MP As Integer
    Public strength As Integer
    Public magic As Integer
    Public defense As Integer
    Public agility As Integer
    Public speed As Integer
    Public dialog As String


    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("PNJs/PNJ" & lstNPCs.IndexOf(Me) & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

End Class
