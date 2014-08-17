Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable>
Public Class GameClass

    Public name As String
    Public description As String
    Public sprite As UShort
    Public HP As Integer
    Public MP As Integer
    Public strength As UShort
    Public magic As UShort
    Public defense As UShort
    Public agility As UShort
    Public speed As UShort

    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("Classes/Classe" & lstClasses.IndexOf(Me) & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub
End Class
