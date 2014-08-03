Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class GameClass

    Public ClassName As String
    Public ClassDescription As String
    Public ClassHP As Integer
    Public ClassMP As Integer
    Public ClassStrength As Integer
    Public ClassMagic As Integer
    Public ClassDefense As Integer
    Public ClassAgility As Integer
    Public ClassSpeed As Integer

    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("Classes/Classe" & curResource & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub
End Class
