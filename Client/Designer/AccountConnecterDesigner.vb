Imports TGUI
Imports SFML.Window
Imports SFML.Graphics

Class AccountConnecterDesigner
    Implements Designer

    '******** Attributs *********
    Private bground, bg As Sprite
    Private i As Single
    '*****************************

    Public Sub New()
        bground = New Sprite(New Texture("Config\Resources\background.png"))
        view.Zoom(0.5F)

    End Sub

    Public Sub Load(gui As Gui, configPath As String) Implements Designer.Load
        gui.RemoveAllWidgets()
    End Sub

    Public Sub DispatchEventsAndUpdate() Implements Designer.DispatchEventsAndUpdate
        view.Move(New Vector2f(0.01F, 0.01F))
    End Sub

    Public Sub Draw(batch As RenderWindow) Implements Designer.Draw
        batch.SetView(view)
        batch.Draw(bground)

    End Sub
End Class
