﻿Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class GameSpell

    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("Sorts/Sort" & curResource & ".frog")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

End Class
