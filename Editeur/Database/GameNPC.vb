Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class GameNPC

    Public Name As String

    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("PNJs/PNJ" & curResource & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

End Class
