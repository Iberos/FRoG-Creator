Imports SFML.Graphics
Imports SFML.Window
Imports System.Runtime.Serialization.Formatters.Binary
Imports System
Imports System.IO
Imports System.Collections

Public Class frmMapEditor

    Private selectingTiles As Boolean = False
    Private mapping As Boolean = False

    Private Sub frmMapEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        editorOptions.Save()
    End Sub

    Private Sub frmMapEditor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        game.StartGameLoop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Test l'existance des dossiers de base de l'éditeur
        If Not Directory.Exists("Classes") Then Directory.CreateDirectory("Classes")
        If Not Directory.Exists("Maps") Then Directory.CreateDirectory("Maps")
        If Not Directory.Exists("Objets") Then Directory.CreateDirectory("Objets")
        If Not Directory.Exists("PNJs") Then Directory.CreateDirectory("PNJS")
        If Not Directory.Exists("Sorts") Then Directory.CreateDirectory("Sorts")
        If Not Directory.Exists("Tiles") Then Directory.CreateDirectory("Tiles")
        If Not File.Exists("Sprite.png") Then
            MessageBox.Show("ATTENTION: Aucun sprite n'a été détecté, veuillez replacer Sprite.png à la racine du programme\n\nLe programme va maintenant se fermer")
            End
        End If

        frmLoading.Show()
        Application.DoEvents()

        picGame.Cursor = Cursors.Cross
        game.InitMapEditor()
        frmLoading.Hide()
    End Sub

    Public Sub FormResize()
        pnlTiles.Width = 0.25 * Me.Width
        pnlTiles.Height = Me.Height - 183
        pnlAttribute.Width = 0.25 * Me.Width
        pnlAttribute.Height = Me.Height - 183
        pnlAttribute.Left = pnlTiles.Left
        lstTiles.Width = pnlTiles.Width
        picGame.Top = (Me.Height - picGame.Height) / 2 - 5
        picGame.Left = (Me.Width - picGame.Width + pnlTiles.Width) / 2
        pnlStart.Top = (Me.Height - pnlStart.Height) / 2 - 5
        pnlStart.Left = (Me.Width - pnlStart.Width + pnlTiles.Width) / 2
    End Sub

    Private Sub frmMapEditor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Call FormResize()
    End Sub

    Private Sub lstTiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTiles.SelectedIndexChanged
        If lstTiles.SelectedIndex < lstTiles.Items.Count - 1 Then
            game.tileSurface.Dispose()
            picTiles.Size = New Size(game.tileset(lstTiles.SelectedIndex).Size.X, game.tileset(lstTiles.SelectedIndex).Size.Y)
            game.tileSurface = New RenderWindow(picTiles.Handle)
            game.currentTileset = New Sprite(game.tileset(lstTiles.SelectedIndex)) 'Changement du tileset
            picTiles.ImageLocation = ("Tiles/Tiles" & lstTiles.SelectedIndex & ".png")
            pnlAttribute.Visible = False
            curAttribute.Type = 0
            btCopy.Enabled = True
            btFill.Enabled = True
            ToolStripButton15.Enabled = True
            ToolStripButton8.Enabled = True
            ToolStripButton9.Enabled = True
            ToolStripButton10.Enabled = True
            ToolStripButton7.Enabled = True
            ToolStripButton12.Enabled = True
            ToolStripButton13.Enabled = True
        Else
            curAttribute.Type = 1
            pnlAttribute.Visible = True
            btCopy.Enabled = False
            btFill.Enabled = False
            ToolStripButton15.Enabled = False
            ToolStripButton8.Enabled = False
            ToolStripButton9.Enabled = False
            ToolStripButton10.Enabled = False
            ToolStripButton7.Enabled = False
            ToolStripButton12.Enabled = False
            ToolStripButton13.Enabled = False
        End If
    End Sub

    Private Sub GrilleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrilleToolStripMenuItem.Click
        If editorOptions.grid = False Then
            editorOptions.grid = True
        Else
            editorOptions.grid = False
        End If
        GrilleToolStripMenuItem.Checked = editorOptions.grid
        btGrid.Checked = editorOptions.grid
    End Sub

    Private Sub PrevisualisationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevisualisationToolStripMenuItem.Click
        If editorOptions.tilesPreview = False Then
            editorOptions.tilesPreview = True
        Else
            editorOptions.tilesPreview = False
        End If
        PrevisualisationToolStripMenuItem.Checked = editorOptions.tilesPreview
    End Sub

    Private Sub NuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuitToolStripMenuItem.Click
        If editorOptions.nightMode = False Then
            editorOptions.nightMode = True
        Else
            editorOptions.nightMode = False
        End If
        NuitToolStripMenuItem.Checked = editorOptions.nightMode
        btNight.Checked = editorOptions.nightMode
    End Sub

    Private Sub picTiles_MouseDown(sender As Object, e As MouseEventArgs) Handles picTiles.MouseDown
        game.recSelect.Position = New Vector2f(Int(Mouse.GetPosition(game.tileSurface).X / 32), Int(Mouse.GetPosition(game.tileSurface).Y / 32)) * 32
        game.recSelect.Size = New Vector2f(32, 32)
        selectingTiles = True
    End Sub

    Private Sub picTiles_MouseMove(sender As Object, e As MouseEventArgs) Handles picTiles.MouseMove
        If selectingTiles And
           Mouse.GetPosition(game.tileSurface).X > game.recSelect.Position.X And
           Mouse.GetPosition(game.tileSurface).Y > game.recSelect.Position.Y Then ' Eviter la séléction "négative"

            Dim tmpHeight As Integer = Int((Mouse.GetPosition(game.tileSurface).Y - game.recSelect.Position.Y) / 32) + 1
            Dim tmpWidth As Integer = Int((Mouse.GetPosition(game.tileSurface).X - game.recSelect.Position.X) / 32) + 1

            game.recSelect.Size = New Vector2f(tmpWidth * 32, tmpHeight * 32)
        End If
    End Sub

    Private Sub picTiles_MouseUp(sender As Object, e As MouseEventArgs) Handles picTiles.MouseUp
        selectingTiles = False
    End Sub

    Private Sub picGame_MouseClick(sender As Object, e As MouseEventArgs) Handles picGame.MouseClick
        If Not btCopy.Checked Then
            If Not btErase.Checked Then
                If curAttribute.Type = 0 Then
                    ' Mapping
                    Call PlaceTile(curX, curY)
                Else
                    ' Attributs
                    Call PlaceAttribute(curX, curY, Nothing, Nothing)
                End If
            Else
                If Not lstTiles.Text = "Attributs" Then
                    ' Gomme
                    Call DeleteTile(curX, curY)
                Else
                    Call DeleteAttribute(curX, curY)
                End If
            End If
        Else
            ' Pipette
            game.recSelect.Size = New Vector2f(32, 32)
            lstTiles.SelectedIndex = map.layer(curLayer).tilset(curX, curY)
            game.recSelect.Position = New Vector2f(map.DecodeX(map.layer(curLayer).tileCode(curX, curY)) * 32,
                                                   map.DecodeY(map.layer(curLayer).tileCode(curX, curY)) * 32)
            btCopy.Checked = False
            picGame.Cursor = Cursors.Cross
        End If
    End Sub

    Private Sub picGame_MouseMove(sender As Object, e As MouseEventArgs) Handles picGame.MouseMove
        ' Calculs de la position de la souris
        If Not e.X < 0 Then curX = Int(e.X / 32) Else curX = 0
        If curX > 20 Then curX = 20
        If Not e.Y < 0 Then curY = Int(e.Y / 32) Else curY = 0
        If curY > 14 Then curY = 14
        lblCursor.Text = ("X: " & curX & " Y: " & curY)

        If mapping Then
            If Not btErase.Checked Then
                If curAttribute.Type = 0 Then
                    ' Mapping
                    Call PlaceTile(curX, curY)
                Else
                    ' Attributs
                    Call PlaceAttribute(curX, curY, Nothing, Nothing)
                End If
            Else
                If Not lstTiles.Text = "Attributs" Then
                    ' Gomme
                    Call DeleteTile(curX, curY)
                Else
                    Call DeleteAttribute(curX, curY)
                End If
            End If
        End If
    End Sub

    ' - Placer l'attribut
    Private Sub PlaceAttribute(ByVal X As Byte, ByVal Y As Byte, ByVal Num() As Integer, ByVal Str() As String)
        If Not testMode Then
            With map.attribute(X, Y)
                .num = curAttribute.num
                .str = curAttribute.str
                .Type = curAttribute.Type
            End With
        End If
    End Sub

    ' - Supprime l'attribut
    Private Sub DeleteAttribute(ByVal X As Byte, ByVal Y As Byte)
        If Not testMode Then
            map.attribute(X, Y).Type = 0
        End If
    End Sub

    ' - Place la selection de tiles sur la map puis re dessine la couche
    Private Sub PlaceTile(ByVal X As Byte, ByVal Y As Byte)
        If Not testMode Then
            For x2 = 0 To CByte(game.recSelect.Size.X / 32) - 1
                For y2 = 0 To CByte(game.recSelect.Size.Y / 32) - 1
                    If Not X + x2 < 0 And Not X + x2 > 20 And Not Y + y2 < 0 And Not Y + y2 > 14 Then
                        map.layer(curLayer).tilset(X + x2, Y + y2) = lstTiles.SelectedIndex
                        map.layer(curLayer).tileCode(X + x2, Y + y2) = map.EncodeXY(Int(game.recSelect.Position.X / 32) + x2, Int(game.recSelect.Position.Y / 32) + y2)
                    End If
                Next
            Next
            game.DrawLayer(curLayer)
        End If
    End Sub

    ' - Supprime la selection de tiles de la map puis re dessine la couche
    Private Sub DeleteTile(ByVal X As Byte, ByVal Y As Byte)
        If Not testMode And Not X < 0 And Not X > 20 And Not Y < 0 And Not Y > 14 Then
            map.layer(curLayer).tilset(X, Y) = 0
            map.layer(curLayer).tileCode(X, Y) = 0
            game.DrawLayer(curLayer)
        End If
    End Sub

    Private Sub btGrid_Click(sender As Object, e As EventArgs) Handles btGrid.Click
        If editorOptions.grid = False Then
            editorOptions.grid = True
        Else
            editorOptions.grid = False
        End If
        GrilleToolStripMenuItem.Checked = editorOptions.grid
        btGrid.Checked = editorOptions.grid
    End Sub

    Private Sub btNight_Click(sender As Object, e As EventArgs) Handles btNight.Click
        If editorOptions.nightMode = False Then
            editorOptions.nightMode = True
        Else
            editorOptions.nightMode = False
        End If
        NuitToolStripMenuItem.Checked = editorOptions.nightMode
        btNight.Checked = editorOptions.nightMode
    End Sub

    Private Sub picGame_MouseDown(sender As Object, e As MouseEventArgs) Handles picGame.MouseDown
        mapping = True
    End Sub

    Private Sub picGame_MouseUp(sender As Object, e As MouseEventArgs) Handles picGame.MouseUp
        map.BackUp()
        lstBackup.RemoveRange(curBck, lstBackup.Count - curBck)
        ToolStripButton2.Enabled = False
        mapping = False
    End Sub

    ' - Outil : Remplissage
    Private Sub btFill_Click(sender As Object, e As EventArgs) Handles btFill.Click
        For x = 0 To 20 Step Int(game.recSelect.Size.X / 32)
            For y = 0 To 16 Step Int(game.recSelect.Size.Y / 32)
                Call PlaceTile(x, y)
            Next
        Next
        map.BackUp()
    End Sub

    ' - Outil : Vider
    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        If Not lstTiles.Text = "Attributs" Then
            For x = 0 To 20
                For y = 0 To 14
                    Call DeleteTile(x, y)
                Next
            Next
            map.BackUp()
        Else
            For x = 0 To 20
                For y = 0 To 14
                    Call DeleteAttribute(x, y)
                Next
            Next
        End If
    End Sub

    ' - Couche : Sol
    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        curLayer = 0

        ' Affichage de la couche selectionnée
        ToolStripButton15.Checked = True
        ToolStripButton8.Checked = False
        ToolStripButton9.Checked = False
        ToolStripButton10.Checked = False
        ToolStripButton7.Checked = False
        ToolStripButton12.Checked = False
        ToolStripButton13.Checked = False
    End Sub

    ' - Couche : Inférieur 1
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        curLayer = 1

        ' Affichage de la couche selectionnée
        ToolStripButton15.Checked = False
        ToolStripButton8.Checked = True
        ToolStripButton9.Checked = False
        ToolStripButton10.Checked = False
        ToolStripButton7.Checked = False
        ToolStripButton12.Checked = False
        ToolStripButton13.Checked = False
    End Sub

    ' - Couche : Inférieur 2
    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        curLayer = 2

        ' Affichage de la couche selectionnée
        ToolStripButton15.Checked = False
        ToolStripButton8.Checked = False
        ToolStripButton9.Checked = True
        ToolStripButton10.Checked = False
        ToolStripButton7.Checked = False
        ToolStripButton12.Checked = False
        ToolStripButton13.Checked = False
    End Sub

    ' - Couche : Inférieur 3
    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        curLayer = 3

        ' Affichage de la couche selectionnée
        ToolStripButton15.Checked = False
        ToolStripButton8.Checked = False
        ToolStripButton9.Checked = False
        ToolStripButton10.Checked = True
        ToolStripButton7.Checked = False
        ToolStripButton12.Checked = False
        ToolStripButton13.Checked = False
    End Sub

    ' - Couche : Supérieur 1
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        curLayer = 4

        ' Affichage de la couche selectionnée
        ToolStripButton15.Checked = False
        ToolStripButton8.Checked = False
        ToolStripButton9.Checked = False
        ToolStripButton10.Checked = False
        ToolStripButton7.Checked = True
        ToolStripButton12.Checked = False
        ToolStripButton13.Checked = False
    End Sub

    ' - Couche : Supérieur 2
    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        curLayer = 5

        ' Affichage de la couche selectionnée
        ToolStripButton15.Checked = False
        ToolStripButton8.Checked = False
        ToolStripButton9.Checked = False
        ToolStripButton10.Checked = False
        ToolStripButton7.Checked = False
        ToolStripButton12.Checked = True
        ToolStripButton13.Checked = False
    End Sub

    ' Couche : Supérieur 3
    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        curLayer = 6
        ' Affichage de la couche selectionnée
        ToolStripButton15.Checked = False
        ToolStripButton8.Checked = False
        ToolStripButton9.Checked = False
        ToolStripButton10.Checked = False
        ToolStripButton7.Checked = False
        ToolStripButton12.Checked = False
        ToolStripButton13.Checked = True
    End Sub

    ' - Outil : Pipette
    Private Sub btCopy_Click(sender As Object, e As EventArgs) Handles btCopy.Click
        If btCopy.Checked Then
            btCopy.Checked = False
            picGame.Cursor = Cursors.Cross
        Else
            btCopy.Checked = True
            picGame.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub btErase_Click(sender As Object, e As EventArgs) Handles btErase.Click
        If btErase.Checked Then
            btErase.Checked = False
        Else
            btErase.Checked = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Not curBck = 1 Then
            curBck -= 1
            Dim stream As New IO.MemoryStream(lstBackup(curBck - 1))
            Dim formater As New BinaryFormatter
            map = DirectCast(formater.Deserialize(stream), GameMap)
            stream.Close()
            stream.Dispose()
            game.DrawMap()
            ' Déverouillage du bouton "rétablir" et possible verouillage du bouton "Annuler"
            ToolStripButton2.Enabled = True
            If curBck = 1 Then ToolStripButton1.Enabled = False
        End If
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        frmMapOpen.Show()
    End Sub

    Private Sub btLocalSave_Click(sender As Object, e As EventArgs) Handles btLocalSave.Click
        map.Save()
    End Sub

    Private Sub NouvelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelleToolStripMenuItem.Click
        frmMapNew.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If Not curBck = lstBackup.Count Then
            curBck += 1
            Dim stream As New IO.MemoryStream(lstBackup(curBck - 1))
            Dim formater As New BinaryFormatter
            map = DirectCast(formater.Deserialize(stream), GameMap)
            stream.Close()
            stream.Dispose()
            game.DrawMap()
            ' Déverouillage du boutton "annuler" et possible verouillage du bouton "rétablir"
            ToolStripButton1.Enabled = True
            If curBck = lstBackup.Count Then ToolStripButton2.Enabled = False
        End If
    End Sub

    Private Sub ProprietésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProprietésToolStripMenuItem.Click
        frmMapProperties.Show()
    End Sub

    Private Sub EditeurDeDonnéesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditeurDeDonnéesToolStripMenuItem.Click
        frmDataEditor.Show()
    End Sub

    Private Sub SauvegarderSurLeDisqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SauvegarderSurLeDisqueToolStripMenuItem.Click
        map.Save()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://frogcreator.fr/")
    End Sub

    Private Sub btPlay_Click(sender As Object, e As EventArgs) Handles btPlay.Click
        If testMode Then
            testMode = False
            btPlay.Image = My.Resources.Play
            pnlTiles.Enabled = True
            picTiles.Enabled = True
            lstTiles.Enabled = True
        Else
            testMode = True
            btPlay.Image = My.Resources._Stop
            pnlTiles.Enabled = False
            picTiles.Enabled = False
            lstTiles.Enabled = False
        End If
    End Sub

    Private Sub FaireUneCaptureDécranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaireUneCaptureDécranToolStripMenuItem.Click
        game.gameSurface.Capture.SaveToFile("Map" & curMap & ".png")
    End Sub

    Private Sub NouveauToolStripButton_Click(sender As Object, e As EventArgs) Handles NouveauToolStripButton.Click
        frmMapNew.Show()
    End Sub

    Private Sub OuvrirToolStripButton_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripButton.Click
        frmMapOpen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        curAttribute = New Attribute
        curAttribute.Type = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lstDir.SelectedIndex = 0
        pnlBlockDir.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        curAttribute = New Attribute
        curAttribute.Type = 3
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pnlBlockDir.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        curAttribute = New Attribute
        curAttribute.Type = 2
        ReDim curAttribute.num(0)
        curAttribute.num(0) = lstDir.SelectedIndex
        pnlBlockDir.Visible = False
    End Sub

    Private Sub btn_attrNPC_Click(sender As Object, e As EventArgs) Handles btn_attrNPC.Click
        frmConfigNPC.ShowDialog()
    End Sub
End Class
