Imports SFML.Graphics
Imports SFML.Window
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable>
Public Class GameMap
    Implements SFML.Graphics.Drawable

    Private Const MAP_WIDTH As UInteger = 672
    Private Const MAP_HEIGHT As UInteger = 480

    Private name As String
    Private type As Byte
    Private layer(6) As Layer ' couche entière
    Private attribute(20, 14) As Attribute ' attribut sur une case
    Private borderMap(8) As Integer ' maps au voisinage

    Private mapSurface(6) As RenderTexture


    ' - Constructeur
    Public Sub New()
        For i = 0 To 6
            layer(i) = New Layer
        Next

        For x = 0 To 20
            For y = 0 To 14
                attribute(x, y) = New Attribute
            Next
        Next

        For mapLayerIndex As Integer = 0 To 6
            mapSurface(mapLayerIndex) = New RenderTexture(MAP_WIDTH, MAP_HEIGHT)
            mapSurface(mapLayerIndex).Draw(LayerTexture(mapLayerIndex))
        Next
    End Sub

    Public Function isWalkable(location As Vector2f)
        ' TODO isWalkable condition  
        Return True
    End Function

    ' - Retourne une texture correspondant à la couche demandée
    Private Function LayerTexture(ByVal layerNum As Byte) As Texture
        Dim layerSurface As New RenderTexture(MAP_WIDTH, MAP_HEIGHT)
        Dim sprt As Sprite
        layerSurface.Clear(New Color(0, 0, 0, 0))

        With Me.layer(layerNum)
            For x = 0 To 20
                For y = 0 To 14
                    If Not layer(layerNum).tileCode(x, y) = 0 Then
                        ' TODO : Try Catch Le cas où le tileset voulu n'a pas été chargé
                        sprt = New Sprite(GameDesigner.TILESETS_MEMORY_DATA.ElementAtOrDefault(.tileset(x, y)))
                        sprt.TextureRect = New IntRect(GameTileset.DecodeX(.tileCode(x, y)) * 32, GameTileset.DecodeY(.tileCode(x, y)) * 32, 32, 32)
                        sprt.Position = New Vector2f(x * 32, y * 32)
                        layerSurface.Draw(sprt)
                        sprt.Dispose()
                    End If
                Next
            Next
        End With

        Return layerSurface.Texture
    End Function

    Public Sub Draw(target As RenderTarget, states As RenderStates) Implements Drawable.Draw
        ' Dessin des couches inférieures seulement
        For i = 0 To 3
            target.Draw(New Sprite(mapSurface(i).Texture))
        Next
    End Sub

    Public Shared Function Load(ByVal mapNum As UInteger)
        Try
            ' TODO : Rendre quasi-identique les attributs et l'héritage de la class GameMap entre le client et l'éditeur pour éviter le catch
            Dim deserializer As New BinaryFormatter
            Dim reader As Stream
            Dim mapResult As GameMap
            If File.Exists(Main.MAPS_PATH + "Map" & mapNum & ".frog") Then
                reader = File.OpenRead(Main.MAPS_PATH + "Map" & mapNum & ".frog")
                mapResult = DirectCast(deserializer.Deserialize(reader), GameMap)
                reader.Close() : reader.Dispose()
                Return mapResult
            End If
        Catch ex As Exception
            MsgBox("Une erreur est survenue lors du chargement d'une carte de jeu.", MsgBoxStyle.Critical, "Erreur critique")
            Environment.Exit(1)
        End Try
        Return Nothing
    End Function
End Class
