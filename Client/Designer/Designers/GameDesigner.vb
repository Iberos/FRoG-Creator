﻿Imports SFML.Window
Imports SFML.Graphics
Imports TGUI

Class GameDesigner
    Implements Designer

    ' GuiObjects
    Private chatBox As EditBox
    Private chatContainer As ChatBox
    Private characterWindow As ChildWindow

    ' GameObjects
    Private testPlayer As GamePlayer

    ' GuiLoad
    Public Sub Load(gui As Gui, configPath As String) Implements Designer.Load
        gui.RemoveAllWidgets()
        '
        ' chatBox
        '
        chatBox = gui.Add(New EditBox(configPath), "chatBox")
        chatBox.Size = New Vector2f(Main.window.Size.X * 0.3, 30)
        chatBox.Position = New Vector2f(20, Main.window.Size.Y - 40)
        chatBox.Transparency = 120
        '
        ' chatContainer
        '
        chatContainer = gui.Add(New ChatBox(configPath), "chatContainer")
        chatContainer.Size = New Vector2f(chatBox.Size.X, 100)
        chatContainer.Position = New Vector2f(chatBox.Position.X, chatBox.Position.Y - chatContainer.Size.Y)
        chatContainer.TextSize = 12
        chatContainer.BackgroundColor = New Color(100, 100, 100, 150)
        chatContainer.BorderColor = Color.Transparent
        'TODO Prendre en compte les textes qui prennent 2 lignes (ou +) !
        chatContainer.AddLine("Bienvenue sur le serveur de jeu Frog Creator !", Color.Green)
        chatContainer.AddLine("Votre ancienne connexion remonte à 10 jours !", Color.Black)
        '
        ' characterWindow
        '
        characterWindow = gui.Add(New ChildWindow(configPath), "characterWindow")
        characterWindow.Size = New Vector2f(200, 150)
        characterWindow.Position = New Vector2f(20, 20)
        characterWindow.Transparency = 120
        characterWindow.BackgroundColor = New Color(100, 100, 100, 150)
        characterWindow.BorderColor = New Color(100, 100, 100)
        '
        ' picHead
        '
        Dim picHead = characterWindow.Add(New Picture("ItemFake.png"), "picHead")
        picHead.Size = New Vector2f(26, 25)
        picHead.Position = New Vector2f((characterWindow.Size.X - 26) / 2, (characterWindow.Size.Y - 25) / 4)
        '
        ' picArmor
        '
        Dim picArmor = characterWindow.Add(New Picture("ItemArmorFake.png"), "picArmor")
        picArmor.Position = New Vector2f((characterWindow.Size.X - 26) / 2, (characterWindow.Size.Y - 25) / 2)
        '
        ' hpProgress
        '
        Dim hpProgress = gui.Add(New LoadingBar(configPath), "hpProgress")
        hpProgress.Size = New Vector2f(Main.window.Size.X * 0.2, 15)
        hpProgress.Position = New Vector2f(Main.window.Size.X - hpProgress.Size.X - 20, 20)
        hpProgress.TextColor = Color.Black
        hpProgress.Value = 30
        hpProgress.Text = String.Format("HP   {0} / {1}", hpProgress.Value, hpProgress.Maximum)
        '
        ' mpProgress
        '
        Dim mpProgress = gui.Add(New LoadingBar(configPath), "mpProgress")
        mpProgress.Size = New Vector2f(Main.window.Size.X * 0.2, 15)
        mpProgress.Position = New Vector2f(Main.window.Size.X - mpProgress.Size.X - 20, 40)
        mpProgress.TextColor = Color.Black
        mpProgress.Value = 75
        mpProgress.Text = String.Format("MP   {0} / {1}", mpProgress.Value, mpProgress.Maximum)
        '
        ' aniDaD
        '
        Dim aniDaD = gui.Add(New GameActionCase(), "aniDaD")
        aniDaD.Size = New Vector2f(32, 32)
        aniDaD.Position = New Vector2f(84, 10)
        aniDaD.AddFrame(Main.SPELLS_PATH + "spell1.png", 1000)
        aniDaD.AddFrame(Main.SPELLS_PATH + "spell2.png", 1000)
        aniDaD.AddFrame(Main.SPELLS_PATH + "spell3.png", 1000)
        aniDaD.AddFrame(Main.SPELLS_PATH + "spell4.png", 1000)
        aniDaD.isEmpty = False
        aniDaD.Looping = True
        aniDaD.Play()

    End Sub

    Public Sub New()
        Me.testPlayer = New GamePlayer(New Texture(Main.SPRITES_PATH + "Sprite1.png"))
        Me.testPlayer.SetVelocity(GameVelocity.Fast)
        Me.testPlayer.WarpTo(15, 5)
    End Sub

    Public Sub DispatchEventsAndUpdate() Implements Designer.DispatchEventsAndUpdate
        ' GuiEvents
        If (Keyboard.IsKeyPressed(Keyboard.Key.Return)) Then 'Exemple d'écriture d'un texte dynamique dans le chatContainer
            If (chatBox.Focused And chatBox.Text.Length > 0) Then
                chatContainer.AddLine(chatBox.Text, Color.White)
                chatBox.Text = String.Empty
            End If
        ElseIf (Keyboard.IsKeyPressed(Keyboard.Key.C)) Then 'Exemple d'ouverture d'une fenêtre si celle-ci est "fermée"
            If (Not gui.GetWidgetNames.Contains("characterWindow") And Not characterWindow.Equals(Nothing)) Then
                gui.Add(characterWindow, "characterWindow")
            End If
        End If

        ' GameEvents
        If (Keyboard.IsKeyPressed(Keyboard.Key.Up)) Then
            Me.testPlayer.MoveTo(GameDirection.UP)
        ElseIf (Keyboard.IsKeyPressed(Keyboard.Key.Down)) Then
            Me.testPlayer.MoveTo(GameDirection.DOWN)
        ElseIf (Keyboard.IsKeyPressed(Keyboard.Key.Right)) Then
            Me.testPlayer.MoveTo(GameDirection.RIGHT)
        ElseIf (Keyboard.IsKeyPressed(Keyboard.Key.Left)) Then
            Me.testPlayer.MoveTo(GameDirection.LEFT)
        End If

        Me.testPlayer.Update()
    End Sub

    Public Sub Draw(batch As RenderWindow) Implements Designer.Draw
        batch.Draw(Me.testPlayer)
    End Sub
End Class
