Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class GameClass

    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("Classes/Classe" & curResource & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub
End Class
