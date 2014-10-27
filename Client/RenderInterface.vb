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
        chatBox.Position = New Vector2f(20, batch.Size.Y - 50)
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
        chatContainer.AddLine("Bienvenue sur le serveur de jeu Frog Creator version 1.0 !", Color.Green)
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
    End Sub

End Class
