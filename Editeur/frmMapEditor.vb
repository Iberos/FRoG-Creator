Imports SFML.Graphics
Imports SFML.Window
Imports System.Runtime.Serialization.Formatters.Binary
Imports System
Imports System.IO
Imports System.Collections

Public Class frmMapEditor

    Private Shared CURSOR_SELECTER_COLOR = Pens.DarkGreen
    Private Shared PIC_TILES_PADDING = New Point(50, 50)

    Private Shared selectingTiles As Boolean = False
    Private Shared picTilesOrigin As Point = New Point()

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

        frmLoading.Show()

        picGame.Cursor = Cursors.Cross
        game.Initialize()

        frmLoading.Hide()
        Application.DoEvents()
    End Sub

    Public Sub FormResize()
        picTiles.Refresh()

        vPicScroll.Location = New Point(pnlTiles.Location.X + pnlTiles.Size.Width, vPicScroll.Location.Y)
        hPicScroll.Size = New Size(pnlTiles.Width, hPicScroll.Size.Height)

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
            game.currentTileset = New Sprite(game.tileset(lstTiles.SelectedIndex)) 'Changement du tileset
            picTiles.Image = System.Drawing.Image.FromFile("Tiles/Tiles" & lstTiles.SelectedIndex & ".png")

            '***** Initialize ScrollBar *****
            vPicScroll.Minimum = 0
            vPicScroll.SmallChange = picTiles.Image.Height / 20
            vPicScroll.LargeChange = picTiles.Image.Height / 5
            vPicScroll.Maximum = picTiles.Image.Height + PIC_TILES_PADDING.Y - picTiles.Height
            vPicScroll.Maximum += vPicScroll.LargeChange
            vPicScroll.Value = vPicScroll.Minimum + 1

            hPicScroll.Minimum = 0
            hPicScroll.SmallChange = picTiles.Image.Width / 20
            hPicScroll.LargeChange = picTiles.Image.Width / 5
            hPicScroll.Maximum = picTiles.Image.Width + PIC_TILES_PADDING.X - picTiles.Width
            hPicScroll.Maximum += vPicScroll.LargeChange
            hPicScroll.Value = hPicScroll.Minimum + 1
            '********************************

            picTilesOrigin = New Point()

            pnlAttribute.Visible = False
            curAttribute.Type = 0
            ButtonCopy.Enabled = True
            ButtonFill.Enabled = True
            ButtonGround.Enabled = True
            ButtonLower1.Enabled = True
            ButtonLower2.Enabled = True
            ButtonLower3.Enabled = True
            ButtonTop1.Enabled = True
            ButtonTop2.Enabled = True
            ButtonTop3.Enabled = True
        Else
            curAttribute.Type = 1
            pnlAttribute.Visible = True
            ButtonCopy.Enabled = False
            ButtonFill.Enabled = False
            ButtonGround.Enabled = False
            ButtonLower1.Enabled = False
            ButtonLower2.Enabled = False
            ButtonLower3.Enabled = False
            ButtonTop1.Enabled = False
            ButtonTop2.Enabled = False
            ButtonTop3.Enabled = False
        End If
        DrawFocusItem()
    End Sub

    Private Sub GrilleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuGrill.Click
        If editorOptions.grid = False Then
            editorOptions.grid = True
        Else
            editorOptions.grid = False
        End If
        MenuGrill.Checked = editorOptions.grid
        ButtonGrid.Checked = editorOptions.grid
    End Sub

    Private Sub PrevisualisationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuPreview.Click
        If editorOptions.tilesPreview = False Then
            editorOptions.tilesPreview = True
        Else
            editorOptions.tilesPreview = False
        End If
        MenuPreview.Checked = editorOptions.tilesPreview
    End Sub

    Private Sub NuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuNight.Click
        If editorOptions.nightMode = False Then
            editorOptions.nightMode = True
        Else
            editorOptions.nightMode = False
        End If
        MenuNight.Checked = editorOptions.nightMode
        ButtonNight.Checked = editorOptions.nightMode
    End Sub

    Private Sub picGame_MouseClick(sender As Object, e As MouseEventArgs) Handles picGame.MouseClick
        If Not ButtonCopy.Checked Then
            If Not ButtonErase.Checked Then
                If curAttribute.Type = 0 Then
                    ' Mapping
                    Call PlaceTile(curX, curY)
                ElseIf curAttribute.Type = 4 Then
                    ' Attributs PNJ
                    npcConfigurator.Open(map.Attribut(curX, curY), curX, curY)
                Else
                    ' Attributs
                    Call PlaceAttribute(curX, curY)
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
            lstTiles.SelectedIndex = map.MapLayer(curLayer).tileset(curX, curY)
            game.recSelect.Position = New Vector2f(GameTileset.DecodeX(map.MapLayer(curLayer).tileCode(curX, curY)) * 32,
                                                   GameTileset.DecodeY(map.MapLayer(curLayer).tileCode(curX, curY)) * 32)
            ButtonCopy.Checked = False
            picGame.Cursor = Cursors.Cross
        End If
    End Sub

    Private Sub picGame_MouseMove(sender As Object, e As MouseEventArgs) Handles picGame.MouseMove
        ' Calculs de la position de la souris
        If Not e.X < 0 Then curX = Int(e.X / 32) Else curX = 0
        If curX > 20 Then curX = 20
        If Not e.Y < 0 Then curY = Int(e.Y / 32) Else curY = 0
        If curY > 14 Then curY = 14
        LabelCursor.Text = ("X: " & curX & " Y: " & curY)

        If mapping Then
            If Not ButtonErase.Checked Then
                If curAttribute.Type = 0 Then
                    ' Mapping
                    Call PlaceTile(curX, curY)
                Else
                    ' Attributs
                    If Not curAttribute.Type = CaseTypes.Character Then ' Eviter le placement sucessif
                        Call PlaceAttribute(curX, curY)
                    End If
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
    Private Sub PlaceAttribute(ByVal X As Byte, ByVal Y As Byte)
        If Not testMode Then
            With map.Attribut(X, Y)
                .Type = curAttribute.Type
                .sender = curAttribute.sender
            End With
        End If
    End Sub

    ' - Supprime l'attribut
    Private Sub DeleteAttribute(ByVal X As Byte, ByVal Y As Byte)
        If Not testMode Then
            With map.Attribut(X, Y)
                .Type = 0
                .sender = Nothing
            End With
        End If
    End Sub

    ' - Place la selection de tiles sur la map puis re dessine la couche
    Private Sub PlaceTile(ByVal X As Byte, ByVal Y As Byte)
        If Not testMode Then
            For x2 = 0 To CByte(game.recSelect.Size.X / 32) - 1
                For y2 = 0 To CByte(game.recSelect.Size.Y / 32) - 1
                    If Not X + x2 < 0 And Not X + x2 > 20 And Not Y + y2 < 0 And Not Y + y2 > 14 Then
                        map.MapLayer(curLayer).tileset(X + x2, Y + y2) = lstTiles.SelectedIndex
                        map.MapLayer(curLayer).tileCode(X + x2, Y + y2) = GameTileset.EncodeXY(Int(game.recSelect.Position.X / 32) + x2, Int(game.recSelect.Position.Y / 32) + y2)
                    End If
                Next
            Next
            game.DrawLayer(curLayer)
        End If
    End Sub

    ' - Supprime la selection de tiles de la map puis re dessine la couche
    Private Sub DeleteTile(ByVal X As Byte, ByVal Y As Byte)
        If Not testMode And Not X < 0 And Not X > 20 And Not Y < 0 And Not Y > 14 Then
            map.MapLayer(curLayer).tileset(X, Y) = 0
            map.MapLayer(curLayer).tileCode(X, Y) = 0
            game.DrawLayer(curLayer)
        End If
    End Sub

    Private Sub btGrid_Click(sender As Object, e As EventArgs) Handles ButtonGrid.Click
        If editorOptions.grid = False Then
            editorOptions.grid = True
        Else
            editorOptions.grid = False
        End If
        MenuGrill.Checked = editorOptions.grid
        ButtonGrid.Checked = editorOptions.grid
    End Sub

    Private Sub btNight_Click(sender As Object, e As EventArgs) Handles ButtonNight.Click
        If editorOptions.nightMode = False Then
            editorOptions.nightMode = True
        Else
            editorOptions.nightMode = False
        End If
        MenuNight.Checked = editorOptions.nightMode
        ButtonNight.Checked = editorOptions.nightMode
    End Sub

    Private Sub ButtonLayerShift_Click(sender As Object, e As EventArgs) Handles ButtonLayerShift.Click
        editorOptions.layerShiftMode = Not editorOptions.layerShiftMode
        ButtonLayerShift.Checked = editorOptions.layerShiftMode
    End Sub

    Private Sub picGame_MouseDown(sender As Object, e As MouseEventArgs) Handles picGame.MouseDown
        mapping = True
    End Sub

    Private Sub picGame_MouseUp(sender As Object, e As MouseEventArgs) Handles picGame.MouseUp
        map.BackUp()
        lstBackup.RemoveRange(curBck, lstBackup.Count - curBck)
        ButtonAfter.Enabled = False
        mapping = False
    End Sub

    ' - Outil : Remplissage
    Private Sub btFill_Click(sender As Object, e As EventArgs) Handles ButtonFill.Click
        For x = 0 To 20 Step Int(game.recSelect.Size.X / 32)
            For y = 0 To 16 Step Int(game.recSelect.Size.Y / 32)
                Call PlaceTile(x, y)
            Next
        Next
        map.BackUp()
    End Sub

    ' - Outil : Vider
    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
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
    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ButtonGround.Click
        curLayer = 0

        ' Affichage de la couche selectionnée
        ButtonGround.Checked = True
        ButtonLower1.Checked = False
        ButtonLower2.Checked = False
        ButtonLower3.Checked = False
        ButtonTop1.Checked = False
        ButtonTop2.Checked = False
        ButtonTop3.Checked = False

        game.DrawMap()
    End Sub

    ' - Couche : Inférieur 1
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ButtonLower1.Click
        curLayer = 1

        ' Affichage de la couche selectionnée
        ButtonGround.Checked = False
        ButtonLower1.Checked = True
        ButtonLower2.Checked = False
        ButtonLower3.Checked = False
        ButtonTop1.Checked = False
        ButtonTop2.Checked = False
        ButtonTop3.Checked = False

        game.DrawMap()
    End Sub

    ' - Couche : Inférieur 2
    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ButtonLower2.Click
        curLayer = 2

        ' Affichage de la couche selectionnée
        ButtonGround.Checked = False
        ButtonLower1.Checked = False
        ButtonLower2.Checked = True
        ButtonLower3.Checked = False
        ButtonTop1.Checked = False
        ButtonTop2.Checked = False
        ButtonTop3.Checked = False

        game.DrawMap()
    End Sub

    ' - Couche : Inférieur 3
    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ButtonLower3.Click
        curLayer = 3

        ' Affichage de la couche selectionnée
        ButtonGround.Checked = False
        ButtonLower1.Checked = False
        ButtonLower2.Checked = False
        ButtonLower3.Checked = True
        ButtonTop1.Checked = False
        ButtonTop2.Checked = False
        ButtonTop3.Checked = False

        game.DrawMap()
    End Sub

    ' - Couche : Supérieur 1
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ButtonTop1.Click
        curLayer = 4

        ' Affichage de la couche selectionnée
        ButtonGround.Checked = False
        ButtonLower1.Checked = False
        ButtonLower2.Checked = False
        ButtonLower3.Checked = False
        ButtonTop1.Checked = True
        ButtonTop2.Checked = False
        ButtonTop3.Checked = False

        game.DrawMap()
    End Sub

    ' - Couche : Supérieur 2
    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ButtonTop2.Click
        curLayer = 5

        ' Affichage de la couche selectionnée
        ButtonGround.Checked = False
        ButtonLower1.Checked = False
        ButtonLower2.Checked = False
        ButtonLower3.Checked = False
        ButtonTop1.Checked = False
        ButtonTop2.Checked = True
        ButtonTop3.Checked = False

        game.DrawMap()
    End Sub

    ' Couche : Supérieur 3
    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ButtonTop3.Click
        curLayer = 6
        ' Affichage de la couche selectionnée
        ButtonGround.Checked = False
        ButtonLower1.Checked = False
        ButtonLower2.Checked = False
        ButtonLower3.Checked = False
        ButtonTop1.Checked = False
        ButtonTop2.Checked = False
        ButtonTop3.Checked = True

        game.DrawMap()
    End Sub

    ' - Outil : Pipette
    Private Sub btCopy_Click(sender As Object, e As EventArgs) Handles ButtonCopy.Click
        If ButtonCopy.Checked Then
            ButtonCopy.Checked = False
            picGame.Cursor = Cursors.Cross
        Else
            ButtonCopy.Checked = True
            picGame.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub btErase_Click(sender As Object, e As EventArgs) Handles ButtonErase.Click
        If ButtonErase.Checked Then
            ButtonErase.Checked = False
        Else
            ButtonErase.Checked = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ButtonBefore.Click
        If Not curBck = 1 Then
            curBck -= 1
            Dim stream As New IO.MemoryStream(lstBackup(curBck - 1))
            Dim formater As New BinaryFormatter
            map = DirectCast(formater.Deserialize(stream), GameMap)
            stream.Close()
            stream.Dispose()
            game.DrawMap()
            ' Déverouillage du bouton "rétablir" et possible verouillage du bouton "Annuler"
            ButtonAfter.Enabled = True
            If curBck = 1 Then ButtonBefore.Enabled = False
        End If
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuOpenMap.Click
        frmMapOpen.Show()
    End Sub

    Private Sub btLocalSave_Click(sender As Object, e As EventArgs) Handles ButtonSaveMap.Click
        map.Save()
    End Sub

    Private Sub NouvelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuNewMap.Click
        frmMapNew.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ButtonAfter.Click
        If Not curBck = lstBackup.Count Then
            curBck += 1
            Dim stream As New IO.MemoryStream(lstBackup(curBck - 1))
            Dim formater As New BinaryFormatter
            map = DirectCast(formater.Deserialize(stream), GameMap)
            stream.Close()
            stream.Dispose()
            game.DrawMap()
            ' Déverouillage du boutton "annuler" et possible verouillage du bouton "rétablir"
            ButtonBefore.Enabled = True
            If curBck = lstBackup.Count Then ButtonAfter.Enabled = False
        End If
    End Sub

    Private Sub ProprietésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuProperty.Click
        frmMapProperties.Show()
    End Sub

    Private Sub EditeurDeDonnéesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuDataEditor.Click
        frmDataEditor.Show()
    End Sub

    Private Sub SauvegarderSurLeDisqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuSaveMapLocal.Click
        map.Save()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelWebSite.LinkClicked
        Process.Start("http://frogcreator.fr/")
    End Sub

    Private Sub btPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        If testMode Then
            testMode = False
            ButtonPlay.Image = My.Resources.Play
            pnlTiles.Enabled = True
            picTiles.Enabled = True
            lstTiles.Enabled = True
        Else
            testMode = True
            ButtonPlay.Image = My.Resources._Stop
            pnlTiles.Enabled = False
            picTiles.Enabled = False
            lstTiles.Enabled = False
        End If
    End Sub

    Private Sub screenshootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuScreenshot.Click
        game.gameSurface.Capture.SaveToFile("Map" & curMap & ".png")
    End Sub

    Private Sub NouveauToolStripButton_Click(sender As Object, e As EventArgs) Handles ButtleNewMap.Click
        frmMapNew.Show()
    End Sub

    Private Sub OuvrirToolStripButton_Click(sender As Object, e As EventArgs) Handles ButtonOpenMap.Click
        frmMapOpen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonBlock.Click
        curAttribute = New GameAttribute
        curAttribute.Type = 1
        DrawFocusItem()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonBlockDirection.Click
        ListDirection.SelectedIndex = 0
        pnlBlockDir.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonTeleport.Click
        curAttribute = New GameAttribute
        curAttribute.Type = 3
        DrawFocusItem()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        pnlBlockDir.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        curAttribute = New GameAttribute
        curAttribute.Type = 2
        ReDim curAttribute.sender(0)
        curAttribute.sender(0) = ListDirection.SelectedIndex
        pnlBlockDir.Visible = False
        DrawFocusItem()
    End Sub

    Private Sub buttonNPC_Click(sender As Object, e As EventArgs) Handles ButtonNPC.Click
        curAttribute = New GameAttribute
        curAttribute.Type = 4
        ReDim curAttribute.sender(0)
        DrawFocusItem()
    End Sub

    Private Sub DrawFocusItem()
        Dim boldFont = New Drawing.Font(ButtonBlock.Font.Name, ButtonBlock.Font.Size, FontStyle.Bold)
        Dim reguFont = New Drawing.Font(ButtonBlock.Font.Name, ButtonBlock.Font.Size, FontStyle.Regular)

        ButtonBlock.Font = reguFont
        ButtonBlockDirection.Font = reguFont
        ButtonTeleport.Font = reguFont
        ButtonNPC.Font = reguFont

        Select Case curAttribute.Type
            Case 1
                ButtonBlock.Font = boldFont
            Case 2
                ButtonBlockDirection.Font = boldFont
            Case 3
                ButtonTeleport.Font = boldFont
            Case 4
                ButtonNPC.Font = boldFont
        End Select

    End Sub

    Private Sub picTiles_Paint(sender As Object, e As PaintEventArgs) Handles picTiles.Paint
        e.Graphics.Clear(Drawing.Color.White)
        e.Graphics.DrawImage(picTiles.Image, e.ClipRectangle, picTilesOrigin.X, picTilesOrigin.Y, e.ClipRectangle.Width, e.ClipRectangle.Height, GraphicsUnit.Pixel)
        e.Graphics.DrawRectangle(CURSOR_SELECTER_COLOR, game.recSelect.Position.X - picTilesOrigin.X, game.recSelect.Position.Y - picTilesOrigin.Y, game.recSelect.Size.X, game.recSelect.Size.Y)
    End Sub

    Private Sub hScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles hPicScroll.Scroll
        picTilesOrigin.X = hPicScroll.Value
        picTiles.Refresh()
    End Sub

    Private Sub vPicScroll_Scroll(sender As Object, e As ScrollEventArgs) Handles vPicScroll.Scroll
        picTilesOrigin.Y = vPicScroll.Value
        picTiles.Refresh()
    End Sub

    Private Sub picTiles_MouseDown(sender As Object, e As MouseEventArgs) Handles picTiles.MouseDown
        Dim pt As Point = New Point(Int((e.Location.X - picTiles.Location.X + picTilesOrigin.X) / 32) * 32, Int((e.Location.Y - picTiles.Location.Y + picTilesOrigin.Y) / 32) * 32)
        game.recSelect.Position = New Vector2f(pt.X, pt.Y)
        game.recSelect.Size = New Vector2f(32, 32)
        selectingTiles = True
        picTiles.Refresh()
    End Sub

    Private Sub picTiles_MouseMove(sender As Object, e As MouseEventArgs) Handles picTiles.MouseMove
        Dim pt As Point = e.Location - picTiles.Location + picTilesOrigin
        If (selectingTiles And pt.X > game.recSelect.Position.X And pt.Y > game.recSelect.Position.Y) Then
            Dim tmpHeight As Integer = Int((pt.Y - game.recSelect.Position.Y) / 32) + 1
            Dim tmpWidth As Integer = Int((pt.X - game.recSelect.Position.X) / 32) + 1

            game.recSelect.Size = New Vector2f(tmpWidth * 32, tmpHeight * 32)
            picTiles.Refresh()
        End If
    End Sub

    Private Sub picTiles_MouseUp(sender As Object, e As MouseEventArgs) Handles picTiles.MouseUp
        selectingTiles = False
    End Sub
End Class
