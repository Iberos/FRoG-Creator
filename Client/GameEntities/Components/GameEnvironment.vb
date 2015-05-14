Imports SFML.Graphics
Imports System.IO

Public Class GameEnvironment
    Implements Drawable

    ' GameObjects
    Public Shared MAPS As List(Of GameMap) = New List(Of GameMap)
    Public Shared TILESETS As List(Of GameTileset) = New List(Of GameTileset)

    Private currentMap As GameMap

    Public Sub New()
        LoadTilesets()
        LoadMaps()

        Me.currentMap = MAPS.First()
    End Sub

    Public Sub SetCurrentMap(map As GameMap)
        Me.currentMap = map
    End Sub

    Public Sub Draw(target As RenderTarget, states As RenderStates) Implements Drawable.Draw
        If (Not IsNothing(currentMap)) Then
            currentMap.Draw(target, states)
            For neighboorMapIndex As Integer = 0 To GameMap.NEIGHBOORS_COUNT
                Dim neighboorMap = currentMap.MapsBorder(neighboorMapIndex)

                If (Not IsNothing(neighboorMap)) Then
                    neighboorMap.Origin = GameRelativeMap.MAPS.ElementAt(neighboorMapIndex).GetVector()
                    neighboorMap.Draw(target, states)
                End If
            Next
        End If
    End Sub


    Private Sub LoadTilesets()
        For Each fileName As String In Directory.GetFiles(ContentType.TILESETS, "Tiles*") ' Ouverture des fichiers commençants par "Tiles" dans leur nom
            fileName = Path.GetFileName(fileName)
            Dim tileset = GameTileset.Load(fileName)
            If (Not IsNothing(tileset)) Then 'Si le tilset existe, on l'ajoute en mémoire
                TILESETS.Add(tileset)
            End If
        Next
    End Sub

    Private Sub LoadMaps()
        For Each mapName As String In Directory.GetFiles(ContentType.MAPS, "Map*")
            Dim map As GameMap = New GameMap
            mapName = Path.GetFileName(mapName)
            map = GameMap.Load(mapName)
            If (Not IsNothing(map)) Then 'Si la map existe, on l'ajoute en mémoire
                maps.Add(map)
            End If
        Next
    End Sub
End Class
