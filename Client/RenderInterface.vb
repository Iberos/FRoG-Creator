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
        chatBox.Size = New Vector2f(400, 30)
        chatBox.Position = New Vector2f(20, batch.Size.Y - 50)
        chatBox.Transparency = 120

    End Sub

End Class
