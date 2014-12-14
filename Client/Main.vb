Imports SFML
Imports SFML.Graphics
Imports SFML.Window
Imports TGUI

Module Main
    Private Declare Function GetConsoleWindow Lib "kernel32.dll" () As IntPtr
    Private Declare Function ShowWindow Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal nCmdShow As Int32) As Int32
    Private Const SW_SHOWNORMAL As Int32 = 1
    Private Const SW_HIDE As Int32 = 0

    Private Const SCREEN_TITLE As String = "Frog Creator 1.0"
    Private Const CONFIG_PATH As String = "Config/Widgets/Black.conf"
    Private Const FONT_PATH As String = "Config/Widgets/GoBoom.ttf"
    Private Const ICON_PATH As String = "Config/Icons/FC.png"

    Private SCREEN_WIDTH As UShort = 800
    Private SCREEN_HEIGHT As UShort = 600

    Public window As RenderWindow
    Public gui As RenderInterface
    Public gameState As GameStates

    '*********** Attributs & Initialisations **************
    Private icon As Texture
    Private map As Sprite
    Private sInterface As Sprite
    Private chatBox As EditBox
    Private chatContainer As ChatBox
    Private characterWindow As ChildWindow

    Private Sub Loader(args As String())
        If (args.Length > 1) Then
            If (Not args(0).Equals(Nothing) And Not args(1).Equals(Nothing)) Then
                SCREEN_WIDTH = UInteger.Parse(args(0))
                SCREEN_HEIGHT = UInteger.Parse(args(1))
            End If
        End If

        ShowWindow(GetConsoleWindow(), SW_HIDE)
        window = New RenderWindow(New VideoMode(SCREEN_WIDTH, SCREEN_HEIGHT), SCREEN_TITLE, Styles.Close)
        gui = New RenderInterface(window, CONFIG_PATH, FONT_PATH)
        gameState = GameStates.AccountConnectionState

        AddHandler window.Closed, AddressOf OnClose

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

    Sub Main(args As String())

        Loader(args)

        Try

            While (window.IsOpen())
                window.DispatchEvents()
                DoEvent()

                window.Clear(Color.Black)
                '*****************************
                DrawActionSelecter(window)
                '*****************************
                gui.Draw()
                window.Display()
            End While

        Catch e As IO.FileNotFoundException
            MsgBox(e.Message, MsgBoxStyle.Critical)
        Catch e As NullReferenceException
            MsgBox(e.Message, MsgBoxStyle.Critical)
        Finally
            Environment.Exit(1)
        End Try
    End Sub

    Private Sub OnClose(sender As Object, e As EventArgs)
        Dim window As RenderWindow = DirectCast(sender, RenderWindow)
        window.Close()
    End Sub

    Private Sub DrawActionSelecter(batch As RenderWindow)
        Select gameState
            Case GameStates.AccountConnectionState
                AccountConnectionLoop(batch)
            Case GameStates.CharacterSelectionState
                CharacterSelectLoop(batch)
            Case GameStates.ServerSelectionState
                ServerSelectionLoop(batch)
            Case GameStates.GamePlayState
                GamePlayLoop(batch)
        End Select
        'batch.Draw(map)
        'batch.Draw(sInterface)
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

    Private Sub AccountConnectionLoop(batch As RenderWindow)

    End Sub

    Private Sub ServerSelectionLoop(batch As RenderWindow)

    End Sub

    Private Sub CharacterSelectLoop(batch As RenderWindow)

    End Sub

    Private Sub GamePlayLoop(batch As RenderWindow)

    End Sub
End Module
