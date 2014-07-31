Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports SFML.Window
Imports SFML.Graphics

<Serializable>
Public Class GameMap

    Public name As String
    Public type As Byte
    Public layer(6) As Layer ' couche entière
    Public attribute(20, 14) As Attribute ' attribut sur une case
    Public borderMap(7) As Integer ' maps au voisinage

    ' - Constructeur
    Sub New()
        For i = 0 To 6
            layer(i) = New Layer
        Next

        For x = 0 To 20
            For y = 0 To 14
                attribute(x, y) = New Attribute
            Next
        Next
    End Sub

    ' - Comptacte les valeurs X et Y du tiles
    Public Function EncodeXY(ByVal X As Byte, ByVal Y As Byte) As Long
        Return Y * 20 + X
    End Function

    ' - Recupère la valeur X du tiles
    Public Function DecodeX(ByVal code As Long) As Byte
        Return Math.Floor(code - Math.Floor(code / 20) * 20)
    End Function

    ' - Recupère la valeur Y du tiles
    Public Function DecodeY(ByVal code As Long) As Byte
        Return Math.Floor(code / 20)
    End Function

    ' - Retourne une texture correspondant à la couche demandée
    Public Function LayerTexture(ByVal layerNum As Byte) As Texture
        Dim layerSurface As New RenderTexture(672, 480)
        Dim sprt As Sprite
        layerSurface.Clear(New Color(0, 0, 0, 0))

        With map.layer(layerNum)
            For x = 0 To 20
                For y = 0 To 14
                    If Not layer(layerNum).tileCode(x, y) = 0 Then
                        sprt = New Sprite(game.tileset(.tilset(x, y)))
                        sprt.TextureRect = New IntRect(DecodeX(.tileCode(x, y)) * 32, DecodeY(.tileCode(x, y)) * 32, 32, 32)
                        sprt.Position = New Vector2f(x * 32, y * 32)
                        layerSurface.Draw(sprt)
                        sprt.Dispose()
                    End If
                Next
            Next
        End With

        Return layerSurface.Texture
    End Function

    ' - Charge la map indiquée
    Public Sub Load(ByVal mapNum As Integer)
        Dim deserializer As New BinaryFormatter
        Dim reader As Stream
        If File.Exists("Maps/Map" & mapNum & ".frog") Then
            reader = File.OpenRead("Maps/Map" & mapNum & ".frog")
            map = DirectCast(deserializer.Deserialize(reader), GameMap)
            reader.Close() : reader.Dispose()
        End If
        lstBackup = New List(Of Byte())
        curBck = 0
        BackUp()
        ' Verouillage des boutons "annuler" et "rétablir"
        frmMapEditor.ToolStripButton1.Enabled = False
        frmMapEditor.ToolStripButton2.Enabled = False
        ' Affiche le nom de la map
        If Not map.name = "" Then frmMapEditor.lblMapName.Text = map.name Else frmMapEditor.lblMapName.Text = "Sans Titre"
    End Sub

    ' - Sauvegarde la map en cours
    Public Sub Save()
        Dim serializer As New BinaryFormatter
        Dim writer As Stream
        writer = File.Create("Maps/Map" & curMap & ".frog")
        serializer.Serialize(writer, map)
        writer.Close()
    End Sub

    ' - Sauvegarde en mémoire la map avant modification
    Public Sub BackUp()
        Dim formater As New BinaryFormatter
        Dim stream As New IO.MemoryStream
        formater.Serialize(stream, map)
        lstBackup.Insert(curBck, stream.ToArray)
        stream.Close()
        stream.Dispose()
        curBck += 1
        ' Déverouillage du bouton "annuler"
        frmMapEditor.ToolStripButton1.Enabled = True
    End Sub
End Class
