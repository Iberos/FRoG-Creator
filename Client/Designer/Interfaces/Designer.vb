Imports TGUI
Imports SFML.Graphics

Public Interface Designer
    Sub Load(gui As RenderInterface, configPath As String)
    Sub Draw(batch As RenderWindow)

    Sub DispatchEventsAndUpdate()

End Interface
