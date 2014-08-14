Imports SFML.Window
Imports SFML.Graphics
Imports System.IO

Class GameManager

    Public gameSurface As New RenderWindow(frmMapEditor.picGame.Handle)
    Public tileSurface As New RenderWindow(frmMapEditor.picTiles.Handle)
    Private gridSurface As New RenderTexture(672, 480)
    Private nightSurface As New RectangleShape(New Vector2f(672, 480))
    Private mapSurface(6) As RenderTexture
    Private previewSprt As Sprite
    Public tileset() As Texture
    Public texPlayer As Texture
    Public sprtPlayer As Sprite
    Public recSelect As New RectangleShape
    Public currentTileset As Sprite
    ' - Initialisation des fonctions essencielles à l'éditeur
    Public Sub InitMapEditor()

        Dim i As Short = 0

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

        ' Initialisation du selecteur de tile
        recSelect.Size = New Vector2f(32, 32)
        recSelect.OutlineColor = New Color(0, 100, 0)
        recSelect.OutlineThickness = 1
        recSelect.Position = New Vector2f(0, 0)
        recSelect.FillColor = Color.Transparent

        ' Chargement des tiles
        While (File.Exists("Tiles/Tiles" & i.ToString() & ".png"))
            ReDim Preserve tileset(i)
            tileset(i) = New Texture("Tiles/Tiles" & i.ToString() & ".png")
            frmMapEditor.lstTiles.Items.Add("Tiles" & i.ToString & ".png")
            i += 1
        End While
        frmMapEditor.lstTiles.Items.Add("Attributs")
        frmMapEditor.lstTiles.SelectedIndex = 0

        ' Chargement des maps 
        For i = 0 To 6
            mapSurface(i) = New RenderTexture(672, 480)
        Next
        map.Load(curMap)
        DrawMap()

        ' Chargement du joueur de test
        texPlayer = New Texture("Sprite.png")

        ' Chargement du configurateur de PNJs
        npcConfigurator = New frmConfigNPC()
        npcConfigurator.Initialize()

        ' Initialisation SFML
        gameSurface.SetFramerateLimit(60)
        InitGrid()
        InitNight()
    End Sub

    ' - Gestion des touches
    Private Sub KeyBoardListener()
        With player
            If Keyboard.IsKeyPressed(Keyboard.Key.Down) And .Y < 14 And .Mov = 0 Then
                .Dir = 0
                If Not map.attribute(.X, .Y + 1).Type = 1 Then
                    If Not map.attribute(.X, .Y + 1).Type = 2 Then
                        .Y += 1
                        .Mov = 32
                    ElseIf Not map.attribute(.X, .Y + 1).num(0) = 0 Then
                        .Y += 1
                        .Mov = 32
                    End If
                End If
            End If

            If Keyboard.IsKeyPressed(Keyboard.Key.Up) And .Y > 0 And .Mov = 0 Then
                .Dir = 3
                If Not map.attribute(.X, .Y - 1).Type = 1 Then
                    If Not map.attribute(.X, .Y - 1).Type = 2 Then
                        .Y -= 1
                        .Mov = 32
                    ElseIf Not map.attribute(.X, .Y - 1).num(0) = 3 Then
                        .Y -= 1
                        .Mov = 32
                    End If
                End If
            End If

            If Keyboard.IsKeyPressed(Keyboard.Key.Left) And .X > 0 And .Mov = 0 Then
                .Dir = 1
                If Not map.attribute(.X - 1, .Y).Type = 1 Then
                    If Not map.attribute(.X - 1, .Y).Type = 2 Then
                        .X -= 1
                        .Mov = 32
                    ElseIf Not map.attribute(.X - 1, .Y).num(0) = 1 Then
                        .X -= 1
                        .Mov = 32
                    End If
                End If
            End If

            If Keyboard.IsKeyPressed(Keyboard.Key.Right) And .X < 20 And .Mov = 0 Then
                .Dir = 2
                If Not map.attribute(.X + 1, .Y).Type = 1 Then
                    If Not map.attribute(.X + 1, .Y).Type = 2 Then
                        .X += 1
                        .Mov = 32
                    ElseIf Not map.attribute(.X + 1, .Y).num(0) = 2 Then
                        .X += 1
                        .Mov = 32
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
    Private Sub InitGrid()
        Dim frame As New RectangleShape(New Vector2f(30, 30))
        frame.FillColor = New Color(0, 0, 0, 0)
        frame.OutlineThickness = 1
        frame.OutlineColor = New Color(0, 0, 0, 100)

        gridSurface.Clear(New Color(0, 0, 0, 0))

        For x = 0 To 20
            For y = 0 To 14
                frame.Position = New Vector2f(x * 32, y * 32)
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
    Private Sub InitNight()
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
        Dim sprt As Sprite
        mapSurface(layer).Clear(New Color(0, 0, 0, 0))

        With map.layer(layer)
            For x = 0 To 20
                For y = 0 To 14
                    If Not .tileCode(x, y) = 0 Then
                        sprt = New Sprite(game.tileset(.tilset(x, y)))
                        sprt.TextureRect = New IntRect(map.DecodeX(.tileCode(x, y)) * 32, map.DecodeY(.tileCode(x, y)) * 32, 32, 32)
                        sprt.Position = New Vector2f(x * 32, y * 32)
                        mapSurface(layer).Draw(sprt)
                        sprt.Dispose()
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
            sprtPlayer.TextureRect = New IntRect(Int(.Mov / 32 * 4) * texPlayer.Size.X / 4, .Dir * texPlayer.Size.Y / 4, texPlayer.Size.X / 4, texPlayer.Size.Y / 4)
            If .Dir = 0 Then
                sprtPlayer.Position = New Vector2f(.X * 32, (.Y - 1) * 32 - .Mov)
            ElseIf .Dir = 1 Then
                sprtPlayer.Position = New Vector2f(.X * 32 + .Mov, (.Y - 1) * 32)
            ElseIf .Dir = 2 Then
                sprtPlayer.Position = New Vector2f(.X * 32 - .Mov, (.Y - 1) * 32)
            ElseIf .Dir = 3 Then
                sprtPlayer.Position = New Vector2f(.X * 32, (.Y - 1) * 32 + .Mov)
            End If
            gameSurface.Draw(sprtPlayer)
        End With
        'Pense bête : 32*48 (sprites RMXP)
    End Sub

    ' - Dessin des attributs
    Public Sub DrawAttribute()
        Dim bckAttribute As New RectangleShape()

        For x = 0 To 20
            For y = 0 To 14
                Select Case map.attribute(x, y).Type
                    Case 1
                        bckAttribute.Size = New Vector2f(32, 32)
                        bckAttribute.FillColor = New Color(200, 0, 0, 100)
                        bckAttribute.Position = New Vector2f(x * 32, y * 32)
                        gameSurface.Draw(bckAttribute)
                    Case 2
                        If map.attribute(x, y).num(0) = 0 Then
                            bckAttribute.Size = New Vector2f(32, 10)
                            bckAttribute.FillColor = New Color(200, 0, 0, 100)
                            bckAttribute.Position = New Vector2f(x * 32, y * 32)
                        ElseIf map.attribute(x, y).num(0) = 1 Then
                            bckAttribute.Size = New Vector2f(10, 32)
                            bckAttribute.FillColor = New Color(200, 0, 0, 100)
                            bckAttribute.Position = New Vector2f(x * 32 + 22, y * 32)
                        ElseIf map.attribute(x, y).num(0) = 2 Then
                            bckAttribute.Size = New Vector2f(10, 32)
                            bckAttribute.FillColor = New Color(200, 0, 0, 100)
                            bckAttribute.Position = New Vector2f(x * 32, y * 32)
                        ElseIf map.attribute(x, y).num(0) = 3 Then
                            bckAttribute.Size = New Vector2f(32, 10)
                            bckAttribute.FillColor = New Color(200, 0, 0, 100)
                            bckAttribute.Position = New Vector2f(x * 32, y * 32 + 22)
                        End If
                        gameSurface.Draw(bckAttribute)
                    Case 3
                        bckAttribute.Size = New Vector2f(32, 32)
                        bckAttribute.FillColor = New Color(0, 0, 200, 100)
                        bckAttribute.Position = New Vector2f(x * 32, y * 32)
                        gameSurface.Draw(bckAttribute)
                End Select
            Next
        Next
    End Sub

    ' - Dessin de la planche de tiles
    Public Sub DrawTileset()
        tileSurface.Clear(Color.White)

        ' Dessin du tileset
        tileSurface.Draw(currentTileset)

        ' Dessin du selecteur de tile
        tileSurface.Draw(recSelect)

        tileSurface.Display()
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
                    previewSprt.Position = New Vector2f(curX * 32, curY * 32)
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
