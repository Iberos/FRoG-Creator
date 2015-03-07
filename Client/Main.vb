Imports SFML
Imports SFML.Graphics
Imports SFML.Window
Imports TGUI
Imports System.IO

Module Main
    Private Declare Function GetConsoleWindow Lib "kernel32.dll" () As IntPtr
    Private Declare Function ShowWindow Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal nCmdShow As Int32) As Int32
    Private Const SW_SHOWNORMAL As Int32 = 1
    Private Const SW_HIDE As Int32 = 0

    'TODO : Réaliser classe de configs <Serializable>
    Public Const SCREEN_TITLE = "Frog Creator 1.0"
    Public Const WIDGET_PATH = "Config/Widgets/"
    Public Const ICONS_PATH = "Config/Icons/"
    Public Const RESOURCES_PATH = "Config/Resources/"
    Public Const SPRITES_PATH = RESOURCES_PATH + "Sprites/"
    Public Const SPELLS_PATH = RESOURCES_PATH + "Spells/"
    Public Const TILESETS_PATH = RESOURCES_PATH + "Tiles/"
    Public Const MAPS_PATH = RESOURCES_PATH + "Maps/"

    Public Const GUI_CONFIG_FILE = "Black.conf"
    Public Const FONT_FILE = "GoBoom.ttf"
    Public Const ICON_FILE = "FC.png"


    Private SCREEN_WIDTH As UShort = 640
    Private SCREEN_HEIGHT As UShort = 448
    Private FPS As Byte = 60

    Public window As RenderWindow
    Public gui As RenderInterface
    Public gameState As GameStates
    Public designer As Designer
    Public view As View

    '*********** Attributs & Initialisations **************

    Private icon As Texture

    ' TEMP
    Public client As New GameClient

    Private Sub Loader(args As String())
        ' Chargement des arguments d'instance
        If (args.Length > 1) Then
            ' Ajouter ici un nouveau test pour spécifier une obligation de lancement du client auprès d'un launcher
            If (Not args(0).Equals(Nothing) And Not args(1).Equals(Nothing)) Then
                Dim tmpWidth As UInteger = UInteger.Parse(args(0))
                Dim tmpHeight As UInteger = UInteger.Parse(args(1))

                SCREEN_WIDTH = If(tmpWidth < SCREEN_WIDTH, SCREEN_WIDTH, tmpWidth)
                SCREEN_HEIGHT = If(tmpHeight < SCREEN_HEIGHT, SCREEN_HEIGHT, tmpHeight)
            End If
        End If

        'ShowWindow(GetConsoleWindow(), SW_HIDE)
        Console.WriteLine("--- Console de debug ---")

        gameState = GameStates.AccountConnectionState

        window = New RenderWindow(New VideoMode(SCREEN_WIDTH, SCREEN_HEIGHT), SCREEN_TITLE, Styles.Close)
        window.SetFramerateLimit(FPS)
        icon = New Texture(ICONS_PATH + ICON_FILE)
        window.SetIcon(icon.Size.X, icon.Size.Y, icon.CopyToImage().Pixels)

        gui = New RenderInterface(window, WIDGET_PATH + GUI_CONFIG_FILE, WIDGET_PATH + FONT_FILE)

        AddHandler window.Closed, AddressOf OnClose
        AddHandler window.Resized, AddressOf OnResized

        ' Chargement des cartes de jeu
        LoadTilesets()
        LoadMaps()

    End Sub
    '*****************************************************

    Sub Main(args As String())

        Loader(args)

        Try
            ' Connexion au réseau
            client.Connect("localhost", 4608)

            '----- TEST DU RESEAU NE PAS EFFACER, MERCI -----
            Threading.Thread.Sleep(100)
            Console.WriteLine("- ENVOI D'UN PACKET DE TEST AU SERVEUR EN COURS -")
            Dim test As Byte = ClientPacket.NewChar
            If (Not IsNothing(client.buffer)) Then client.buffer.Write(test)

            ' ----- FIN DE TEST -----

            While (window.IsOpen())
                window.DispatchEvents()
                designer.DispatchEventsAndUpdate()

                window.Clear(Color.White)
                designer.Draw(window)
                gui.Draw()

                window.Display()
            End While

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
        designer.Load(gui, WIDGET_PATH + GUI_CONFIG_FILE)
    End Sub

    Private Sub LoadTilesets()
        Dim tilesets As List(Of GameTileset) = New List(Of GameTileset)
        For Each fileName As String In Directory.GetFiles(TILESETS_PATH, "Tiles*") ' Ouverture des fichiers commençants par "Tiles" dans leur nom
            fileName = Path.GetFileName(fileName)
            Dim tileset = GameTileset.Load(fileName)
            If (Not IsNothing(tileset)) Then 'Si le tilset existe, on l'ajoute en mémoire
                tilesets.Add(tileset)
            End If
        Next
        GameDesigner.LoadTilesets(tilesets)
    End Sub

    Private Sub LoadMaps()
        Dim maps As List(Of GameMap) = New List(Of GameMap)
        For Each mapName As String In Directory.GetFiles(MAPS_PATH, "Map*")
            Dim map As GameMap = New GameMap
            mapName = Path.GetFileName(mapName)
            map = GameMap.Load(mapName)
            If (Not IsNothing(map)) Then 'Si la map existe, on l'ajoute en mémoire
                maps.Add(map)
            End If
        Next
        GameDesigner.LoadMaps(maps)
    End Sub
End Module
