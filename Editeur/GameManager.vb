Imports SFML.Window
Imports SFML.Graphics
Imports System.IO

Class GameManager

    Public gameSurface As RenderWindow
    Private gridSurface As New RenderTexture(672, 480)
    Private nightSurface As New RectangleShape(New Vector2f(672, 480))
    Private mapSurface(6) As RenderTexture
    Private previewSprt As Sprite
    Public tileset() As Texture
    Public texPlayer As Texture
    Public sprtPlayer As Sprite
    Public recSelect As New RectangleShape
    Public currentTileset As Sprite
    ' - Initialisation des fonctions essentielles à l'éditeur

    Public Sub Initialize() 'TODO Modifier Initialize GameManager en constructeur

        ' Chargement des options
        LoadParameters()

        ' Initialisation des autres composants
        InitializeClass()

        ' Chargement des tiles
        LoadTiles()

        ' Chargement de la map
        LoadMap()

        ' Chargement du joueur de test
        LoadTestSprite()
    End Sub

    Private Sub LoadParameters()
        ' Chargement des options
        If File.Exists("Options.xml") Then
            editorOptions.Load()
        Else
            editorOptions.Save()
        End If

        frmMapEditor.MenuGrill.Checked = editorOptions.grid
        frmMapEditor.ButtonGrid.Checked = editorOptions.grid
        frmMapEditor.MenuPreview.Checked = editorOptions.tilesPreview
        frmMapEditor.MenuNight.Checked = editorOptions.nightMode
        frmMapEditor.ButtonNight.Checked = editorOptions.nightMode
    End Sub

    Private Sub InitializeClass()
        ' Chargement des éléments éditeur
        gameSurface = New RenderWindow(frmMapEditor.picGame.Handle)

        ' Initialisation SFML
        gameSurface.SetFramerateLimit(60)

        ' Initialisation du selecteur de tile
        recSelect.Size = New Vector2f(modVar.CASE_LENGTH, modVar.CASE_LENGTH)
        recSelect.OutlineColor = New Color(0, 100, 0)
        recSelect.OutlineThickness = 1
        recSelect.Position = New Vector2f(0, 0)
        recSelect.FillColor = Color.Transparent

        ' Création du configurateur de PNJs
        npcConfigurator = New frmConfigNPC()

        ' Initialisation des add-ons
        InitializeGrid()
        InitializeNight()
    End Sub

    Private Sub LoadTiles()
        ' TODO : Dynamiser les noms de fichiers texture ? (Laisser la liberté de nommage)
        ' Chargement des tiles
        Dim files() As String = IO.Directory.GetFiles("Tiles")
        If files.Count() > 0 Then
            For index As Integer = 0 To files.Count() - 1
                If (File.Exists("Tiles/Tiles" & index.ToString() & ".png")) Then
                    ReDim Preserve tileset(index)
                    tileset(index) = New Texture("Tiles/Tiles" & index.ToString() & ".png")
                    frmMapEditor.lstTiles.Items.Add("Tiles" & index.ToString & ".png")
                End If
            Next

            frmMapEditor.lstTiles.Items.Add("Attributs")
            frmMapEditor.lstTiles.SelectedIndex = 0
        Else
            MsgBox("L'éditeur ne peut se lancer sans tileset" + Environment.NewLine() +
                   "Erreur : Textures introuvables", MsgBoxStyle.Critical, "Erreur lors du chargement")
            Environment.Exit(1)
        End If
    End Sub

    Private Sub LoadMap()
        ' Chargement de la map 
        For mapLayerIndex As Integer = 0 To 6
            mapSurface(mapLayerIndex) = New RenderTexture(672, 480)
        Next
        map.Load(curMap)
        DrawMap()
    End Sub

    Private Sub LoadTestSprite()
        ' Chargement du joueur de test
        If File.Exists("Resources/Sprite.png") Then
            texPlayer = New Texture("Resources/Sprite.png")
        Else
            MsgBox("L'éditeur ne peut se lancer sans sprite" + Environment.NewLine() +
                   "Erreur : Textures introuvables", MsgBoxStyle.Critical, "Erreur lors du chargement")
            Environment.Exit(0)
        End If
    End Sub

    ' - Gestion des touches
    Private Sub KeyBoardListener()
        With player
            If (Not IsNothing(map.Attribut(.X, .Y))) Then ' Catch de l'attribut inexistant
                If Keyboard.IsKeyPressed(Keyboard.Key.Down) And .Y < 14 And .Mov = 0 Then
                    .Dir = 0
                    If Not map.Attribut(.X, .Y + 1).Type = 1 Then
                        If Not map.Attribut(.X, .Y + 1).Type = 2 Then
                            .Y += 1
                            .Mov = modVar.CASE_LENGTH
                        ElseIf Not map.Attribut(.X, .Y + 1).sender(0) = 0 Then
                            .Y += 1
                            .Mov = modVar.CASE_LENGTH
                        End If
                    End If
                End If

                If Keyboard.IsKeyPressed(Keyboard.Key.Up) And .Y > 0 And .Mov = 0 Then
                    .Dir = 3
                    If Not map.Attribut(.X, .Y - 1).Type = 1 Then
                        If Not map.Attribut(.X, .Y - 1).Type = 2 Then
                            .Y -= 1
                            .Mov = modVar.CASE_LENGTH
                        ElseIf Not map.Attribut(.X, .Y - 1).sender(0) = 3 Then
                            .Y -= 1
                            .Mov = modVar.CASE_LENGTH
                        End If
                    End If
                End If

                If Keyboard.IsKeyPressed(Keyboard.Key.Left) And .X > 0 And .Mov = 0 Then
                    .Dir = 1
                    If Not map.Attribut(.X - 1, .Y).Type = 1 Then
                        If Not map.Attribut(.X - 1, .Y).Type = 2 Then
                            .X -= 1
                            .Mov = modVar.CASE_LENGTH
                        ElseIf Not map.Attribut(.X - 1, .Y).sender(0) = 1 Then
                            .X -= 1
                            .Mov = modVar.CASE_LENGTH
                        End If
                    End If
                End If

                If Keyboard.IsKeyPressed(Keyboard.Key.Right) And .X < 20 And .Mov = 0 Then
                    .Dir = 2
                    If Not map.Attribut(.X + 1, .Y).Type = 1 Then
                        If Not map.Attribut(.X + 1, .Y).Type = 2 Then
                            .X += 1
                            .Mov = modVar.CASE_LENGTH
                        ElseIf Not map.Attribut(.X + 1, .Y).sender(0) = 2 Then
                            .X += 1
                            .Mov = modVar.CASE_LENGTH
                        End If
                    End If
                End If
            End If


            If Keyboard.IsKeyPressed(Keyboard.Key.LShift) Then
                .Run = True
            Else
                .Run = False
            End If

            If .Mov > 0 Then
                If .Run = False Then .Mov -= 2 Else .Mov -= 4
            End If
        End With
    End Sub

    ' - Dessin de la grille sur une renderTexture
    Private Sub InitializeGrid()
        Dim frame As New RectangleShape(New Vector2f(30, 30))
        frame.FillColor = New Color(0, 0, 0, 0)
        frame.OutlineThickness = 1
        frame.OutlineColor = New Color(0, 0, 0, 100)

        gridSurface.Clear(New Color(0, 0, 0, 0))

        For x = 0 To 20
            For y = 0 To 14
                frame.Position = New Vector2f(x * modVar.CASE_LENGTH, y * modVar.CASE_LENGTH)
                gridSurface.Draw(frame)
            Next
        Next

        gridSurface.Display()
    End Sub

    ' - Dessine la grille sur la surface principale
    Public Sub DrawGrid()
        gameSurface.Draw(New Sprite(gridSurface.Texture))
    End Sub

    ' - Dessin de la nuit sur une Shape
    Private Sub InitializeNight()
        nightSurface.FillColor = New Color(0, 12, 149, 85)
    End Sub

    ' - Dessine la nuit sur la surface principale
    Public Sub DrawNight()
        gameSurface.Draw(nightSurface)
    End Sub

    ' - Dessin de la map sur 2 renderTexture
    Public Sub DrawMap()
        For i = 0 To 6
            Call DrawLayer(i)
        Next
    End Sub

    ' - Dessin de la couche
    Public Sub DrawLayer(ByVal layer As Byte)
        If (editorOptions.layerShiftMode And curLayer.Equals(layer)) Then
            mapSurface(layer).Clear(New Color(0, 0, 0, 100))
        Else
            mapSurface(layer).Clear(New Color(0, 0, 0, 0))
        End If

        With map.MapLayer(layer)
            For x = 0 To modVar.MAP_WIDTH
                For y = 0 To modVar.MAP_HEIGHT
                    ' TODO : Catch les erreurs NullReferenceException (provoqué par le chargement d'une map ancienne version pas exemple)
                    If Not .TileCode(x, y) = 0 Then
                        Using sprt As New Sprite(game.tileset(.TilesetIndex(x, y)))
                            sprt.TextureRect = New IntRect(GameTileset.DecodeX(.TileCode(x, y)) * modVar.CASE_LENGTH, GameTileset.DecodeY(.TileCode(x, y)) * modVar.CASE_LENGTH, modVar.CASE_LENGTH, modVar.CASE_LENGTH)
                            sprt.Position = New Vector2f(x * modVar.CASE_LENGTH, y * modVar.CASE_LENGTH)
                            mapSurface(layer).Draw(sprt)
                        End Using
                    End If
                Next
            Next
        End With

        mapSurface(layer).Display()
    End Sub

    ' - Dessin du joueur
    Public Sub DrawPlayer()
        With player
            sprtPlayer = New Sprite(texPlayer)
            sprtPlayer.TextureRect = New IntRect(Int(.Mov / modVar.CASE_LENGTH * 4) * texPlayer.Size.X / 4, .Dir * texPlayer.Size.Y / 4, texPlayer.Size.X / 4, texPlayer.Size.Y / 4)
            If .Dir = GameDirection.Bas Then
                sprtPlayer.Position = New Vector2f(.X * modVar.CASE_LENGTH, (.Y - 1) * modVar.CASE_LENGTH - .Mov)
            ElseIf .Dir = GameDirection.Gauche Then
                sprtPlayer.Position = New Vector2f(.X * modVar.CASE_LENGTH + .Mov, (.Y - 1) * modVar.CASE_LENGTH)
            ElseIf .Dir = GameDirection.Droite Then
                sprtPlayer.Position = New Vector2f(.X * modVar.CASE_LENGTH - .Mov, (.Y - 1) * modVar.CASE_LENGTH)
            ElseIf .Dir = GameDirection.Haut Then
                sprtPlayer.Position = New Vector2f(.X * modVar.CASE_LENGTH, (.Y - 1) * modVar.CASE_LENGTH + .Mov)
            End If
            gameSurface.Draw(sprtPlayer)
        End With
        'Pense bête : modVar.CASE_LENGTH*48 (sprites RMXP)
    End Sub

    ' - Dessin des attributs
    Public Sub DrawAttribute()
        Dim bckAttribute As New RectangleShape()

        For x = 0 To modVar.MAP_WIDTH
            For y = 0 To modVar.MAP_HEIGHT
                If (Not IsNothing(map.Attribut(x, y))) Then ' Catch de l'attribut null
                    Select Case map.Attribut(x, y).Type
                        Case CaseTypes.Block
                            bckAttribute.Size = New Vector2f(modVar.CASE_LENGTH, modVar.CASE_LENGTH)
                            bckAttribute.FillColor = New Color(200, 0, 0, 100)
                            bckAttribute.Position = New Vector2f(x * modVar.CASE_LENGTH, y * modVar.CASE_LENGTH)
                            gameSurface.Draw(bckAttribute)
                        Case CaseTypes.DirectionBlock
                            If map.Attribut(x, y).sender(0) = 0 Then 'Bas
                                bckAttribute.Size = New Vector2f(modVar.CASE_LENGTH, 10)
                                bckAttribute.FillColor = New Color(200, 0, 0, 100)
                                bckAttribute.Position = New Vector2f(x * modVar.CASE_LENGTH, y * modVar.CASE_LENGTH)
                            ElseIf map.Attribut(x, y).sender(0) = 1 Then 'Gauche
                                bckAttribute.Size = New Vector2f(10, modVar.CASE_LENGTH)
                                bckAttribute.FillColor = New Color(200, 0, 0, 100)
                                bckAttribute.Position = New Vector2f(x * modVar.CASE_LENGTH + modVar.CASE_LENGTH - 10, y * modVar.CASE_LENGTH)
                            ElseIf map.Attribut(x, y).sender(0) = 2 Then 'Droite
                                bckAttribute.Size = New Vector2f(10, modVar.CASE_LENGTH)
                                bckAttribute.FillColor = New Color(200, 0, 0, 100)
                                bckAttribute.Position = New Vector2f(x * modVar.CASE_LENGTH, y * modVar.CASE_LENGTH)
                            ElseIf map.Attribut(x, y).sender(0) = 3 Then 'Haut
                                bckAttribute.Size = New Vector2f(modVar.CASE_LENGTH, 10)
                                bckAttribute.FillColor = New Color(200, 0, 0, 100)
                                bckAttribute.Position = New Vector2f(x * modVar.CASE_LENGTH, y * modVar.CASE_LENGTH + modVar.CASE_LENGTH - 10)
                            End If
                            gameSurface.Draw(bckAttribute)
                        Case CaseTypes.Teleportation
                            bckAttribute.Size = New Vector2f(modVar.CASE_LENGTH, modVar.CASE_LENGTH)
                            bckAttribute.FillColor = New Color(0, 0, 200, 100)
                            bckAttribute.Position = New Vector2f(x * modVar.CASE_LENGTH, y * modVar.CASE_LENGTH)
                            gameSurface.Draw(bckAttribute)
                        Case CaseTypes.Character
                            'TODO Draw Attribut PNJ (Recherche du bon pnj en liste [Data: x, y] et affichage de son portrait)
                            bckAttribute.Size = New Vector2f(modVar.CASE_LENGTH, modVar.CASE_LENGTH)
                            bckAttribute.FillColor = New Color(0, 200, 200, 100)
                            bckAttribute.Position = New Vector2f(x * modVar.CASE_LENGTH, y * modVar.CASE_LENGTH)
                            gameSurface.Draw(bckAttribute)
                    End Select
                End If
            Next
        Next
    End Sub


    ' - Boucle de rafraichissement de la surface principale
    Public Sub StartGameLoop()
        Dim Time As Long = My.Computer.Clock.TickCount
        While frmMapEditor.Visible
            gameSurface.Clear(Color.White)

            'Affichage de la map
            'couches inférieures
            For i = 0 To 3
                gameSurface.Draw(New Sprite(mapSurface(i).Texture))
            Next

            'Affichage des joueurs
            If testMode Then DrawPlayer()

            'couches supérieures
            For i = 4 To 6
                gameSurface.Draw(New Sprite(mapSurface(i).Texture))
            Next

            'Affichage de la prévisualisation des tiles
            If editorOptions.tilesPreview And testMode = False And frmMapEditor.ButtonCopy.Checked = False And frmMapEditor.ButtonErase.Checked = False Then
                If frmMapEditor.lstTiles.SelectedIndex < frmMapEditor.lstTiles.Items.Count - 1 Then
                    previewSprt = New Sprite(tileset(frmMapEditor.lstTiles.SelectedIndex))
                    previewSprt.TextureRect = New IntRect(recSelect.Position.X, recSelect.Position.Y, recSelect.Size.X, recSelect.Size.Y)
                    previewSprt.Color = New Color(255, 255, 255, 155)
                    previewSprt.Position = New Vector2f(curX * modVar.CASE_LENGTH, curY * modVar.CASE_LENGTH)
                    gameSurface.Draw(previewSprt)
                End If
            End If

            'Affichage de la nuit
            If editorOptions.nightMode Then DrawNight()

            'Affichage des attributs
            If frmMapEditor.lstTiles.Text = "Attributs" Then Call DrawAttribute()

            'Affichage de la grille
            If editorOptions.grid Then DrawGrid()

            ' Ecoute des évènements clavier
            Call KeyBoardListener()

            gameSurface.Display()

            FPS += 1
            If My.Computer.Clock.TickCount - Time >= 1000 Then
                frmMapEditor.LabelFPS.Text = "FPS : " & FPS.ToString
                FPS = 0
                Time = My.Computer.Clock.TickCount
            End If

            Application.DoEvents()
        End While
    End Sub
End Class
