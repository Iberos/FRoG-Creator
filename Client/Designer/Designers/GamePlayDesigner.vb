Imports SFML.Window
Imports SFML.Graphics
Imports TGUI

Public Class GamePlayDesigner
    Implements Designer
    Implements IDisposable

    ' GuiObjects
    Private chatBox As EditBox
    Private chatContainer As ChatBox
    Private characterWindow As ChildWindow
    Private environment As GameEnvironment

    Private testPlayer As GamePlayer

    ' GuiLoad
    Public Sub Load(gui As RenderInterface, configPath As String) Implements Designer.Load
        gui.RemoveAllWidgets()
        '
        ' chatBox
        '
        chatBox = gui.Add(New EditBox(configPath), "chatBox")
        chatBox.Size = New Vector2f(Main.Window.Size.X * 0.4, 30)
        chatBox.Position = New Vector2f(20, Main.Window.Size.Y - 40)
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
        'TODO : Prendre en compte les textes qui prennent 2 lignes (ou +) !
        chatContainer.AddReckonLine("Bienvenue sur le serveur de jeu Frog Creator !", Color.Green)
        chatContainer.AddReckonLine("Votre ancienne connexion remonte à 10 jours !", Color.Black)
        '---------- fin test ----------
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
        ' pnlBarProgress
        '
        Dim pnlBarProgress = gui.Add(New Panel(), "pnlBarProgress")
        pnlBarProgress.Size = New Vector2f(Main.Window.Size.X * 0.2 + 30, 60)
        pnlBarProgress.BackgroundColor = New Color(0, 0, 0, 80)
        pnlBarProgress.Position = New Vector2f(Main.Window.Size.X - pnlBarProgress.Size.X - 20, 20)
        '
        ' hpProgress
        '
        Dim hpProgress = pnlBarProgress.Add(New LoadingBar(configPath), "hpProgress")
        hpProgress.Size = New Vector2f(Main.Window.Size.X * 0.2, 15)
        hpProgress.Position = New Vector2f(pnlBarProgress.Size.X / 2 - hpProgress.Size.X / 2, 10)
        hpProgress.TextColor = Color.Black
        hpProgress.Value = 30
        hpProgress.Text = String.Format("HP   {0} / {1}", hpProgress.Value, hpProgress.Maximum)
        '
        ' mpProgress
        '
        Dim mpProgress = pnlBarProgress.Add(New LoadingBar(configPath), "mpProgress")
        mpProgress.Size = New Vector2f(Main.Window.Size.X * 0.2, 15)
        mpProgress.Position = New Vector2f(pnlBarProgress.Size.X / 2 - mpProgress.Size.X / 2, 35)
        mpProgress.TextColor = Color.Black
        mpProgress.Value = 75
        mpProgress.Text = String.Format("MP   {0} / {1}", mpProgress.Value, mpProgress.Maximum)
        '
        ' dragNDropItem
        '
        Dim dragNDropItem = gui.Add(New GUIActionCase(), "dragNDropItem")
        dragNDropItem.Size = New Vector2f(32, 32)
        dragNDropItem.Position = New Vector2f(84, 10)
        dragNDropItem.AddFrame(ContentType.SPELLS + "spell1.png", 1000)
        dragNDropItem.AddFrame(ContentType.SPELLS + "spell2.png", 1000)
        dragNDropItem.AddFrame(ContentType.SPELLS + "spell3.png", 1000)
        dragNDropItem.AddFrame(ContentType.SPELLS + "spell4.png", 1000)
        dragNDropItem.IsEmpty = False
        dragNDropItem.Looping = True
        dragNDropItem.Play()
        '
        ' dragNDropClipser
        '
        Dim dragNDropClipser = gui.Add(New GUIActionCase(), "dragNDropClipser")
        dragNDropClipser.Size = New Vector2f(32, 32)
        dragNDropClipser.Position = New Vector2f(200, 10)
        dragNDropClipser.AddFrame(ContentType.SPELLS + "spell1.png", 1000)
        dragNDropClipser.IsEmpty = True
        '
        '
        '
    End Sub

    Public Sub New()
        Me.environment = New GameEnvironment()
        Me.testPlayer = New GamePlayer(New Texture(ContentType.SPRITES + "Sprite1.png"))
        Me.testPlayer.WarpTo(15, 5)
    End Sub

    Public Sub DispatchEventsAndUpdate() Implements Designer.DispatchEventsAndUpdate
        ' GuiEvents
        If (Keyboard.IsKeyPressed(Keyboard.Key.Return)) Then 'Exemple d'écriture d'un texte dynamique dans le chatContainer
            If (chatBox.Focused And chatBox.Text.Length > 0) Then
                chatContainer.AddReckonLine(chatBox.Text, Color.White)
                chatBox.Text = String.Empty
            End If
        ElseIf (Keyboard.IsKeyPressed(Keyboard.Key.C)) Then 'Exemple d'ouverture d'une fenêtre si celle-ci est "fermée"
            If (Not Render.GetWidgetNames.Contains("characterWindow") And Not characterWindow.Equals(Nothing)) Then
                Render.Add(characterWindow, "characterWindow")
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
        batch.Draw(Me.environment)
        ' Draw map primaire
        'If (MAPS_MEMORY_DATA.Count > 0) Then
        'batch.Draw(MAPS_MEMORY_DATA.ElementAt(0))
        'End If
        batch.Draw(Me.testPlayer)
        'If (MAPS_MEMORY_DATA.Count > 0) Then
        'MAPS_MEMORY_DATA.ElementAt(0).Draw2(batch, RenderStates.Default)
        'End If
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Me.testPlayer.Dispose()
    End Sub
End Class
