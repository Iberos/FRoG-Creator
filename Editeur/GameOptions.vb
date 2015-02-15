Imports System.Xml.Serialization
Imports System.IO

<Serializable>
Public Class GameOptions

    Public tilesPreview As Boolean
    Public grid As Boolean
    Public nightMode As Boolean
    Public layerShiftMode As Boolean

    ' - Sauvegarde les options de l'éditeur
    Public Sub Save()
        Dim serializer As New XmlSerializer(GetType(GameOptions))
        Dim writer As New StreamWriter("Options.xml")
        serializer.Serialize(writer, editorOptions)
        writer.Close()
    End Sub

    ' - Charge les options de l'éditeur
    Public Sub Load()
        Dim deserializer As New XmlSerializer(GetType(GameOptions))
        Dim reader As New StreamReader("Options.xml")
        editorOptions = DirectCast(deserializer.Deserialize(reader), GameOptions)
        reader.Close()
    End Sub
End Class
