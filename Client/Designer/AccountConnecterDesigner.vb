Imports TGUI
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

    Private lblInfo As Label
    Private lblAccount As Label
    Private lblPassword As Label
    Private accountBox As EditBox
    Private passwordBox As EditBox

    '*****************************

    Public Sub New()
        bground = New Sprite(New Texture("Config\Resources\background.png"))
        bground.Scale = New Vector2f(1.5, 1.5)
        radiusMovement = New Vector2f(-1, -1)
        windowRect = New IntRect(0, 0, bground.Texture.Size.X - window.Size.X, bground.Texture.Size.Y - window.Size.Y)
    End Sub

    Public Sub Load(gui As Gui, configPath As String) Implements Designer.Load
        gui.RemoveAllWidgets()
        '
        ' lblInfo
        '
        lblInfo = gui.Add(New Label(configPath), "lblInfo")
        lblInfo.Size = New Vector2f(300, 50)
        lblInfo.Text = "HELLO"
        lblInfo.Position = New Vector2f(10, 10)
        lblInfo.TextSize = 12
        '
        ' accountBox
        '
        accountBox = gui.Add(New EditBox(configPath), "accountBox")
        accountBox.Size = New Vector2f(Main.window.Size.X * 0.3, 40)
        accountBox.Position = New Vector2f(window.Size.X / 2 - accountBox.Size.X / 2, Main.window.Size.Y / 2 - 100)
        accountBox.Transparency = 120
        '
        ' lblAccount
        '
        lblAccount = gui.Add(New Label(configPath), "lblAccount")
        lblAccount.Size = New Vector2f(accountBox.Size.X, 30)
        lblAccount.Text = "Nom de compte :"
        lblAccount.Position = New Vector2f(accountBox.Position.X, accountBox.Position.Y - lblAccount.Size.Y)
        '
        ' passwordBox
        '
        passwordBox = gui.Add(New EditBox(configPath), "passwordBox")
        passwordBox.Size = New Vector2f(Main.window.Size.X * 0.3, 40)
        passwordBox.Position = New Vector2f(window.Size.X / 2 - accountBox.Size.X / 2, Main.window.Size.Y / 2)
        passwordBox.Transparency = 120
        passwordBox.PasswordCharacter = "•"
        '
        ' lblPassword
        '
        lblPassword = gui.Add(New Label(configPath), "lblPassword")
        lblPassword.Size = New Vector2f(passwordBox.Size.X, 30)
        lblPassword.Text = "Mot de passe :"
        lblPassword.Position = New Vector2f(passwordBox.Position.X, passwordBox.Position.Y - lblPassword.Size.Y)
    End Sub

    Public Sub DispatchEventsAndUpdate() Implements Designer.DispatchEventsAndUpdate
        lblInfo.Text = bground.Position.ToString()

        Dim v = New Vector2f(oldPosition.X - bground.Position.X, oldPosition.Y - bground.Position.Y)
        If (Not windowRect.Contains(-bground.Position.X, -bground.Position.Y)) Then
            w = (Math.Atan2(v.X, v.Y) + Math.PI / 2) * (180 / Math.PI)
            radiusMovement = New Vector2f(Math.Cos(w), Math.Sin(w))
        Else
            oldPosition = bground.Position
        End If

        bground.Position += radiusMovement
    End Sub

    Public Sub Draw(batch As RenderWindow) Implements Designer.Draw

        batch.Draw(bground)

    End Sub
End Class
