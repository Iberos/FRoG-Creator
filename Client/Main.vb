Imports SFML
Imports SFML.Graphics
Imports SFML.Window
Imports TGUI
Imports System.IO

Module Main
    Public Window As RenderWindow
    Public Render As RenderInterface
    Public Designer As Designer
    Public View As View

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

        Try
            ' Contents
            ContentManager.Add(GameResources.GAME_TITLE, "Frog Creator 1.0")
            ContentManager.Add(GameResources.CONFIG_FILE, "Black.conf")
            ContentManager.Add(GameResources.FONT_FILE, "GoBoom.ttf")
            ContentManager.Add(GameResources.ICON_FILE, New Texture(ContentType.ICONS + "FC.png"))


            Console.WriteLine("--- DEBUG ---")

            ' Création de la fenêtre cliente
            Window = New RenderWindow(New VideoMode(SCREEN_WIDTH, SCREEN_HEIGHT), ContentManager.Load(Of String)(GameResources.GAME_TITLE), Styles.Default)
            Window.SetFramerateLimit(FPS)
            icon = ContentManager.Load(Of Texture)(GameResources.ICON_FILE)
            Window.SetIcon(icon.Size.X, icon.Size.Y, icon.CopyToImage().Pixels)

            ' Création de l'interface
            Dim configFilePath As String = ContentPath.WIDGETS + ContentManager.Load(Of String)(GameResources.CONFIG_FILE)
            Dim configFontPath As String = ContentPath.WIDGETS + ContentManager.Load(Of String)(GameResources.FONT_FILE)
            Render = New RenderInterface(Window, configFilePath, configFontPath)

        Catch e As LoadingFailedException
            MsgBox("Erreur " & e.HResult & " " & e.Source & Environment.NewLine & e.Message, MsgBoxStyle.Critical, "Client")
            ErrorLog.Write(e)
            Environment.Exit(1)
        Catch e As TypeInitializationException
            MsgBox("Erreur " & e.HResult & " " & e.Source & Environment.NewLine & e.Message, MsgBoxStyle.Critical, "Client")
            ErrorLog.Write(e)
            Environment.Exit(1)
        End Try

        AddHandler Window.Closed, AddressOf OnClose
        AddHandler Window.Resized, AddressOf OnResized

        NavigationHelper.NavigateTo(GameStates.AccountConnectionState)

    End Sub
    '*****************************************************

    Sub Main(args As String())

        'NativeMethods.ShowWindow(NativeMethods.GetConsoleWindow(), 0)

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

            ' FIX issue #8 : TGUI n'initialise pas son presse-papier. On s'en occupe pour lui...
            [Global].Clipboard = String.Empty

            While (Window.IsOpen())
                Window.DispatchEvents()
                Designer.DispatchEventsAndUpdate(Window)

                Window.Clear(Color.White)
                Designer.Draw(Window)
                Render.Draw()

                Window.Display()
            End While

        Catch e As NullReferenceException
            MsgBox("[" & e.HResult & "] " & e.Message, MsgBoxStyle.Critical, e.Source)
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
        window.SetView(New View(New FloatRect(0, 0, e.Width, e.Height)))

        Designer.Load(Render, ContentPath.WIDGETS + ContentManager.Load(Of String)(GameResources.CONFIG_FILE))
    End Sub
End Module
