Imports SFML
Imports SFML.Graphics
Imports SFML.Window
Imports TGUI

Public Class RenderInterface
    Inherits Gui

    Private batch As RenderWindow
    Private configFilePath As String
    Private configFontPath As String

    Public Sub New(batch As RenderWindow, configurationFilePath As String, configurationFontPath As String)
        MyBase.New(batch)
        Me.batch = batch
        Me.configFilePath = configurationFilePath
        Me.configFontPath = configurationFontPath
        MyBase.GlobalFont = New Font(Me.configFontPath)
        LoadInterfaceObjects()
    End Sub

    Private Sub LoadInterfaceObjects()
        '
        ' chatBox
        '
        Dim chatBox = MyBase.Add(New EditBox(configFilePath), "chatBox")
        chatBox.Size = New Vector2f(300, 30)
        chatBox.Position = New Vector2f(20, batch.Size.Y - 40)
        chatBox.Transparency = 120
        '
        ' chatContainer
        '
        Dim chatContainer = MyBase.Add(New ChatBox(configFilePath), "chatContainer")
        chatContainer.Size = New Vector2f(chatBox.Size.X, 100)
        chatContainer.Position = New Vector2f(chatBox.Position.X, chatBox.Position.Y - chatContainer.Size.Y)
        chatContainer.TextSize = 12
        chatContainer.BackgroundColor = New Color(100, 100, 100, 150)
        chatContainer.BorderColor = Color.Transparent
        'TODO Prendre en compte les textes qui prennent 2 lignes (ou +)
        chatContainer.AddLine("Bienvenue sur le serveur de jeu Frog Creator !", Color.Green)
        chatContainer.AddLine("Votre ancienne connexion remonte à 10 jours !", Color.Black)
        '
        ' characterWindow
        '
        Dim characterWindow = MyBase.Add(New ChildWindow(configFilePath), "characterWindow")
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
        Dim hpProgress = MyBase.Add(New LoadingBar(configFilePath), "hpProgress")
        hpProgress.Size = New Vector2f(100, 15)
        hpProgress.Position = New Vector2f(batch.Size.X - hpProgress.Size.X - 20, 20)
        hpProgress.Text = "HP"
        hpProgress.Value = 30
        '
        ' mpProgress
        '
        Dim mpProgress = MyBase.Add(New LoadingBar(configFilePath), "mpProgress")
        mpProgress.Size = New Vector2f(100, 15)
        mpProgress.Position = New Vector2f(batch.Size.X - mpProgress.Size.X - 20, 40)
        mpProgress.Text = "MP"
        mpProgress.Value = 75
    End Sub

End Class
