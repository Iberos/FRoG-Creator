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
    Private FPS As Byte = 60

    Public window As RenderWindow
    Public gui As RenderInterface
    Public gameState As GameStates
    Public designer As Designer
    Public view As View

    '*********** Attributs & Initialisations **************

    Private icon As Texture
    
    ' TEMP
    Dim client As New GameClient

    Private Sub Loader(args As String())
        ' Chargement des arguments instance
        If (args.Length > 1) Then
            If (Not args(0).Equals(Nothing) And Not args(1).Equals(Nothing)) Then
                SCREEN_WIDTH = UInteger.Parse(args(0))
                SCREEN_HEIGHT = UInteger.Parse(args(1))
            End If
        End If

        'ShowWindow(GetConsoleWindow(), SW_HIDE)
        Console.WriteLine("--- Console de debug ---")

        gameState = GameStates.AccountConnectionState

        window = New RenderWindow(New VideoMode(SCREEN_WIDTH, SCREEN_HEIGHT), SCREEN_TITLE, Styles.Close)
        window.SetFramerateLimit(FPS)
        icon = New Texture(ICON_PATH)
        window.SetIcon(icon.Size.X, icon.Size.Y, icon.CopyToImage().Pixels)

        gui = New RenderInterface(window, CONFIG_PATH, FONT_PATH)

        AddHandler window.Closed, AddressOf OnClose
        AddHandler window.Resized, AddressOf OnResized

    End Sub
    '*****************************************************

    Sub Main(args As String())

        Loader(args)

        Try
            ' Connexion au réseau
            client.Connect("localhost", 4608)

            While (window.IsOpen())
                window.DispatchEvents()
                designer.DispatchEventsAndUpdate()

                window.Clear(Color.Black)
                '*****************************
                designer.Draw(window)
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

    Private Sub OnResized(sender As Object, e As SizeEventArgs)
        Dim window As RenderWindow = DirectCast(sender, RenderWindow)
        Dim viewRect = New FloatRect(0, 0, window.Size.X, window.Size.Y)
        window.SetView(New View(viewRect))
        designer.Load(gui, CONFIG_PATH)
    End Sub
End Module
