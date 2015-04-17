Imports SFML
Imports SFML.Graphics
Imports SFML.Window
Imports TGUI

Public Class RenderInterface
    Inherits Gui

    Public Shared AccountConnecterState As New AccountConnecterDesigner
    Public Shared CharacterSelectionState As New CharacterSelectionDesigner
    Public Shared ServerConnecterState As New ServerConnecterDesigner
    Public Shared GamePlayState As New GamePlayDesigner

    Private batch As RenderWindow
    Private configFilePath As String
    Private configFontPath As String

    Public Sub New(batch As RenderWindow, configurationFilePath As String, configurationFontPath As String)
        MyBase.New(batch)
        Me.batch = batch
        Me.configFilePath = configurationFilePath
        Me.configFontPath = configurationFontPath
        MyBase.GlobalFont = New Font(Me.configFontPath)
    End Sub

    Public Sub InitializeDesigner()
        Main.Designer.Load(Me, Me.configFilePath)
    End Sub
End Class
