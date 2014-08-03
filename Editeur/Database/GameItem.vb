Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class GameItem

    Public ItemName As String
    Public ItemDescription As String
    Public ItemPurchasePrice As Integer
    Public ItemSellingPrice As Integer
    Public ItemHPEffect As Integer
    Public ItemMPEffect As Integer


    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("Objets/Objet" & curResource & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

End Class
