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
        Select Case (Main.gameState)
            Case GameStates.AccountConnectionState
                Main.designer = New AccountConnecterDesigner()
            Case GameStates.CharacterSelectionState
                Main.designer = New CharacterSelectionDesigner()
            Case GameStates.GamePlayState
                Main.designer = New GameDesigner()
            Case GameStates.ServerSelectionState
                Main.designer = New ServerConnecterDesigner()
        End Select

        Main.designer.Load(Me, Me.configFilePath)
    End Sub

    Public Sub SetGameState(state As GameStates)
        Main.gameState = state
        LoadInterfaceObjects()
    End Sub
End Class
