Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable>
Public Class GameClass

    Public name As String
    Public description As String
    Public sprite As Short
    Public HP As Integer
    Public MP As Integer
    Public strength As Integer
    Public magic As Integer
    Public defense As Integer
    Public agility As Integer
    Public speed As Integer

    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("Classes/Classe" & curResource & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub
End Class
