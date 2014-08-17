Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable>
Public Class GameItem

    Public name As String
    Public description As String
    Public icon As Short
    Public paperdoll As Short
    Public type As Byte
    Public HP As Integer
    Public MP As Integer


    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("Objets/Objet" & lstItems.IndexOf(Me) & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

End Class
