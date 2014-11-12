Imports SFML
Imports SFML.Graphics
Imports SFML.Window
Imports TGUI

Module Main
    Private Declare Function GetConsoleWindow Lib "kernel32.dll" () As IntPtr
    Private Declare Function ShowWindow Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal nCmdShow As Int32) As Int32
    Private Const SW_SHOWNORMAL As Int32 = 1
    Private Const SW_HIDE As Int32 = 0

    Private Const SCREEN_WIDTH As UShort = 639
    Private Const SCREEN_HEIGHT As UShort = 479
    Private Const SCREEN_TITLE As String = "Frog Creator 1.0"
    Private Const CONFIG_PATH As String = "Config/Widgets/Black.conf"
    Private Const FONT_PATH As String = "Config/Widgets/GoBoom.ttf"
    Private Const ICON_PATH As String = "Config/Icons/FC.png"

    Public window As RenderWindow
    Public gui As RenderInterface

    Sub Main()
        ShowWindow(GetConsoleWindow(), SW_HIDE)
        window = New RenderWindow(New VideoMode(SCREEN_WIDTH, SCREEN_HEIGHT), SCREEN_TITLE, Styles.Close)
        gui = New RenderInterface(window, CONFIG_PATH, FONT_PATH)
        Loader()

        AddHandler window.Closed, AddressOf OnClose

        Try
            While (window.IsOpen())
                window.DispatchEvents() ' TODO Erreur retournée lors d'un [CTRL + V] (editBox TGUI)
                DoEvent()

                window.Clear(Color.Black)
                Drawer(window)
                gui.Draw()
                window.Display()
            End While
        Catch e As NullReferenceException
            MsgBox(e.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub OnClose(sender As Object, e As EventArgs)
        Dim window As RenderWindow = DirectCast(sender, RenderWindow)
        window.Close()
    End Sub

    '*********** Attributs & Initialisations **************
    Private icon As Texture
    Private map As Sprite
    Private sInterface As Sprite
    Private chatBox As EditBox
    Private chatContainer As ChatBox
    Private characterWindow As ChildWindow

    Private Sub Loader()
        icon = New Texture(ICON_PATH)
        window.SetIcon(icon.Size.X, icon.Size.Y, icon.CopyToImage().Pixels)
        map = New Sprite(New Texture("MapFake.png"))
        sInterface = New Sprite(New Texture("InterfaceFake.png"))
        sInterface.Position = New Vector2f(window.Size.X - sInterface.Texture.Size.X, window.Size.Y - sInterface.Texture.Size.Y)

        chatBox = gui.Get(Of EditBox)("chatBox")
        chatContainer = gui.Get(Of ChatBox)("chatContainer")
        characterWindow = gui.Get(Of ChildWindow)("characterWindow")
    End Sub
    '*****************************************************

    Private Sub Drawer(batch As RenderWindow)
        batch.Draw(map)
        batch.Draw(sInterface)
    End Sub

    Private Sub DoEvent()
        If (Keyboard.IsKeyPressed(Keyboard.Key.Return)) Then 'Exemple d'écriture d'un texte dynamique dans le chatContainer
            If (chatBox.Focused And chatBox.Text.Length > 0) Then
                chatContainer.AddLine(chatBox.Text, Color.White)
                chatBox.Text = String.Empty
            End If
        ElseIf (Keyboard.IsKeyPressed(Keyboard.Key.C)) Then 'Exemple d'ouverture d'une fenêtre si celle-ci est "fermée"
            If (Not gui.GetWidgetNames.Contains("characterWindow")) Then
                gui.Add(characterWindow, "characterWindow")
            End If
        End If
    End Sub

End Module
