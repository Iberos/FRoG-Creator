﻿Imports TGUI
Imports SFML.Window
Imports SFML.Graphics

Class AccountConnecterDesigner
    Implements Designer

    '******** Attributs *********
    Private bground As Sprite
    Private radiusMovement As Vector2f
    Private oldPosition As Vector2f
    Private windowRect As IntRect
    Private w As Single

    Private pnlInfo As Panel
    Private lblInfo As Label
    Private pnlConnect As Panel
    Private lblAccount As Label
    Private lblPassword As Label
    Private accountBox As EditBox
    Private passwordBox As EditBox
    Private btnConnect As Button

    Private connectionTimeout As GameTimer

    '*****************************

    Public Sub New()
        bground = New Sprite(New Texture("Config\Resources\background.png"))
        bground.Scale = New Vector2f(1.5, 1.5)
        bground.Texture.Smooth = True
        radiusMovement = New Vector2f(-1, -1)
        windowRect = New IntRect(0, 0, bground.Texture.Size.X - window.Size.X, bground.Texture.Size.Y - window.Size.Y)
        connectionTimeout = New GameTimer()
    End Sub

    Public Sub Load(gui As Gui, configPath As String) Implements Designer.Load
        gui.RemoveAllWidgets()
        '
        ' pnlInfo
        '
        pnlInfo = gui.Add(New Panel(), "pnlInfo")
        pnlInfo.Size = New Vector2f(0, 25)
        pnlInfo.BackgroundColor = New Color(0, 0, 0, 80)
        pnlInfo.Position = New Vector2f(10, 10)
        '
        ' lblInfo
        '
        lblInfo = pnlInfo.Add(New Label(configPath), "lblInfo")
        lblInfo.Position = New Vector2f(5, 5)
        '
        ' pnlConnect
        '
        pnlConnect = gui.Add(New Panel(), "pnlConnect")
        pnlConnect.Size = New Vector2f(window.Size.X * 0.5, window.Size.Y * 0.5)
        pnlConnect.BackgroundColor = New Color(0, 0, 0, 80)
        pnlConnect.Position = New Vector2f(window.Size.X / 2 - pnlConnect.Size.X / 2, window.Size.Y / 2 - pnlConnect.Size.Y / 2)
        '
        ' accountBox
        '
        accountBox = pnlConnect.Add(New EditBox(configPath), "accountBox")
        accountBox.Size = New Vector2f(window.Size.X * 0.3, 40)
        accountBox.Position = New Vector2f(pnlConnect.Size.X / 2 - accountBox.Size.X / 2, pnlConnect.Size.Y / 2 - 100)
        accountBox.Transparency = 120
        '
        ' lblAccount
        '
        lblAccount = pnlConnect.Add(New Label(configPath), "lblAccount")
        lblAccount.Size = New Vector2f(accountBox.Size.X / 3, 30)
        lblAccount.Text = "Nom de compte :"
        lblAccount.Position = New Vector2f(accountBox.Position.X, accountBox.Position.Y - lblAccount.Size.Y)
        lblAccount.TextSize = lblAccount.Size.X * 0.2
        '
        ' passwordBox
        '
        passwordBox = pnlConnect.Add(New EditBox(configPath), "passwordBox")
        passwordBox.Size = New Vector2f(window.Size.X * 0.3, 40)
        passwordBox.Position = New Vector2f(pnlConnect.Size.X / 2 - accountBox.Size.X / 2, pnlConnect.Size.Y / 2)
        passwordBox.Transparency = 120
        passwordBox.PasswordCharacter = "•"
        '
        ' lblPassword
        '
        lblPassword = pnlConnect.Add(New Label(configPath), "lblPassword")
        lblPassword.Size = New Vector2f(passwordBox.Size.X / 3, 30)
        lblPassword.Text = "Mot de passe :"
        lblPassword.Position = New Vector2f(passwordBox.Position.X, passwordBox.Position.Y - lblPassword.Size.Y)
        lblPassword.TextSize = lblPassword.Size.X * 0.2
        '
        ' btnConnect
        '
        btnConnect = pnlConnect.Add(New Button(configPath), "btnConnect")
        btnConnect.Size = New Vector2f(passwordBox.Size.X / 2, passwordBox.Size.Y)
        btnConnect.Position = New Vector2f((pnlConnect.Size.X / 2) - (btnConnect.Size.X / 2), passwordBox.Position.Y + btnConnect.Size.Y * 2)
        btnConnect.Transparency = 120
        btnConnect.Text = "Se connecter !"
        btnConnect.CallbackId = 1
        AddHandler btnConnect.LeftMouseClickedCallback, AddressOf btnConnect_OnClick
    End Sub

    Public Sub DispatchEventsAndUpdate() Implements Designer.DispatchEventsAndUpdate

        Dim v = New Vector2f(oldPosition.X - bground.Position.X, oldPosition.Y - bground.Position.Y)
        If (Not windowRect.Contains(-bground.Position.X, -bground.Position.Y)) Then
            w = (Math.Atan2(v.X, v.Y) + Math.PI / 2) * (180 / Math.PI)
            radiusMovement = New Vector2f(Math.Cos(w), Math.Sin(w))
        Else
            oldPosition = bground.Position
        End If

        bground.Position += radiusMovement

        ' Exemple de poll pour IHM
        If (connectionTimeout.AsyncWait(200)) Then
            If (Not Main.client.isConnected()) Then
                lblInfo.TextColor = Color.Red
                lblInfo.TextSize = 15
                lblInfo.Text = "Impossible de se connecter au serveur"
                pnlInfo.Size = New Vector2f(lblInfo.Size.X + 10, pnlInfo.Size.Y)

                'Tentative de reconnection
                Main.client.Connect("localhost", 4608)
            Else
                lblInfo.Text = String.Empty
                pnlInfo.Size = New Vector2f(0, 0)
            End If
        End If
    End Sub

    Public Sub Draw(batch As RenderWindow) Implements Designer.Draw
        batch.Draw(bground)
    End Sub

    Private Sub btnConnect_OnClick(sender As Object, e As CallbackArgs)
        Dim validAccount = False

        If (validAccount) Then
            Main.gui.SetGameState(GameStates.GamePlayState)
        End If
    End Sub
End Class