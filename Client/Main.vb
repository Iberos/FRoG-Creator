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

                Configs.SCREEN_WIDTH = If(tmpWidth < Configs.SCREEN_WIDTH, Configs.SCREEN_WIDTH, tmpWidth)
                Configs.SCREEN_HEIGHT = If(tmpHeight < Configs.SCREEN_HEIGHT, Configs.SCREEN_HEIGHT, tmpHeight)
            End If
        End If

        'ShowWindow(GetConsoleWindow(), SW_HIDE)
        Console.WriteLine("--- Console de debug ---")

        ' Premier Step : Panel de connexion
        gameState = GameStates.AccountConnectionState

        ' Création de la fenêtre cliente
        window = New RenderWindow(New VideoMode(Configs.SCREEN_WIDTH, Configs.SCREEN_HEIGHT), Configs.SCREEN_TITLE, Styles.Close)
        window.SetFramerateLimit(Configs.FPS)
        icon = New Texture(Configs.ICONS_PATH + Configs.ICON_FILE)
        window.SetIcon(icon.Size.X, icon.Size.Y, icon.CopyToImage().Pixels)

        ' Création de l'interface
        gui = New RenderInterface(window, Configs.WIDGET_PATH + Configs.GUI_CONFIG_FILE, Configs.WIDGET_PATH + Configs.FONT_FILE)

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
        designer.Load(gui, Configs.WIDGET_PATH + Configs.GUI_CONFIG_FILE)
    End Sub

    Private Sub LoadTilesets()
        Dim tilesets As List(Of GameTileset) = New List(Of GameTileset)
        For Each fileName As String In Directory.GetFiles(Configs.TILESETS_PATH, "Tiles*") ' Ouverture des fichiers commençants par "Tiles" dans leur nom
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
        For Each mapName As String In Directory.GetFiles(Configs.MAPS_PATH, "Map*")
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
