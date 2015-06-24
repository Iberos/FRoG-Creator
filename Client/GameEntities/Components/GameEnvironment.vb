Imports SFML.Graphics
Imports System.IO

Public Class GameEnvironment
    Implements Drawable
    Implements IUpdatable

    ' GameObjects
    Public Shared MAPS As Dictionary(Of Integer, GameMap) = New Dictionary(Of Integer, GameMap)
    Public Shared TILESETS As List(Of GameTileset) = New List(Of GameTileset)

    Private currentMap As GameMap

    Public Sub New()
        LoadTilesets()
        LoadMaps()

        Me.currentMap = MAPS.ElementAt(0).Value
    End Sub

    Public Sub SetCurrentMap(map As GameMap)
        Me.currentMap = map
    End Sub

    Public Sub Draw(target As RenderTarget, states As RenderStates) Implements Drawable.Draw
        If (Not IsNothing(currentMap)) Then
            currentMap.Draw(target, states)

            For index As Integer = 0 To GameMap.NEIGHBOORS_COUNT

                Dim neighborMapIndex = currentMap.NeighborIndex(index)

                If (Not neighborMapIndex = -1) Then
                    Dim neighborMap = GetMap(neighborMapIndex)

                    If (Not IsNothing(neighborMap)) Then
                        Dim relativeMap = GameRelativeMap.MAPS.ElementAt(index)
                        neighborMap.Origin = relativeMap.GetVector() + currentMap.Origin
                        neighborMap.Draw(target, states)
                    End If
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
                MAPS.Add(map.Index, map)
            End If
        Next
    End Sub

    Public Sub Update() Implements IUpdatable.Update

    End Sub

    Public Shared Function GetMap(ByVal i As Integer) As GameMap
        Dim map As GameMap
        If (MAPS.TryGetValue(i, map)) Then
            Return map
        End If
        Return Nothing
    End Function
End Class
